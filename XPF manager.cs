/*
 * Created by SharpDevelop.
 * User: Tommy
 * Date: 8/5/2017
 * Time: 3:30 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.DirectoryServices;
using System.Net.NetworkInformation;
using System.Management;
using System.Data;

namespace TSA_XPF_mgmt
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public List<string> cutelist = new List<string>();
		public List<string> cusslist = new List<string>();
		public string strouname;
		
		void MainFormLoad(object sender, EventArgs e)
		{
			try
			{
				strouname = "CUTE-WKS";
				string str_site = Environment.UserDomainName;
				string str_entry = string.Format(@"LDAP://OU={0},DC={1},DC=LOCAL",strouname,str_site);
				
			    DirectoryEntry entry = new DirectoryEntry( str_entry );    
			    DirectorySearcher mySearcher = new DirectorySearcher(entry);
	
			    mySearcher.Filter = (@"(objectClass=computer)");    
			    mySearcher.SizeLimit = int.MaxValue;
	    		mySearcher.PageSize = int.MaxValue;
	
	    		foreach(SearchResult resEnt in mySearcher.FindAll())
			    {
			        string ComputerName = resEnt.Properties["cn"][0].ToString();
	
			        if (ComputerName.Contains("CK") || ComputerName.Contains("GT") || ComputerName.Contains("BS") || ComputerName.Contains("BO") || ComputerName.Contains("XSR"))
			        {
			        	cutelist.Add(ComputerName);
			        }
			    }
	    		
	    		cutelist.Sort();
	    		
	    		cbstandard.Items.AddRange( cutelist.ToArray() );
	    		cbstandard.SelectedIndex = 0;
	    		
			    mySearcher.Dispose();
			    entry.Dispose();
			    
			    //CUSS start
			    strouname = "CUSS-WKS";
			    str_entry = string.Format(@"LDAP://OU={0},DC={1},DC=LOCAL",strouname,str_site);
			    
			    entry.Path = str_entry;    
			    mySearcher.SearchRoot = entry;
	
			    mySearcher.Filter = (@"(objectClass=computer)");    
			    mySearcher.SizeLimit = int.MaxValue;
	    		mySearcher.PageSize = int.MaxValue;
	
	    		foreach(SearchResult resEnt in mySearcher.FindAll())
			    {
			        string ComputerName = resEnt.Properties["cn"][0].ToString();
	
			        if ( ComputerName.Contains("AKA") )
			        {
			        	cusslist.Add(ComputerName);
			        }
			    }
	    		cusslist.Sort();
			    
			    mySearcher.Dispose();
			    entry.Dispose();		    
			    
			    label1.Text += str_site.Substring(0,3);
			}
			catch( Exception ex )
			{
				toolStripStatusLabel1.Text = "Form Load Error:"+ex.Message;
			}
		}
		
		private bool CheckcomboboxSelected()
		{
			if( cbstandard.SelectedIndex == -1 )
			{
				MessageBox.Show("Please select a computer.");
				return false;
			}
			else
				return true;
		}
		
		public static string PingHost(string host)
		{
			//string to hold our return messge
			string returnMessage = string.Empty;
			
			//create a new ping instance
			Ping pingsender = new Ping();
			
			try
			{
				PingReply pingReply = pingsender.Send( host, 100 );
				
				if( pingReply.Status == IPStatus.Success )
				{
					returnMessage = "Online";
				}
				else
				{
					returnMessage = pingReply.Status.ToString();
				}
			}
			catch (PingException ex)
			{
				returnMessage = string.Format("Connection Error: {0}", ex.Message);
			}
						
			return returnMessage;
		}
		
		void BtlistClick(object sender, EventArgs e)
		{
			if( !CheckcomboboxSelected() )
				return;
			
			string str_iws = cbstandard.SelectedItem.ToString();
			
			toolStripStatusLabel1.Text = string.Format(@"Waiting {0} reply message.",str_iws);
				
			if( !string.Equals("online", MainForm.PingHost(str_iws), StringComparison.OrdinalIgnoreCase) )
			{
				toolStripStatusLabel1.Text = string.Format(@"{0} is not Online.",str_iws);
				return;
			}
			else
				toolStripStatusLabel1.Text = string.Empty;
			
			try
			{
				dgvpkgname.DataSource = null;
				
				ManagementClass vspClass = new ManagementClass( string.Format(@"\\{0}\root\default:VirtualSoftwarePackage",str_iws) );
				ManagementObjectCollection vspCollection =  vspClass.GetInstances();
				
				DataTable dtpkglist = new DataTable(str_iws);
				dtpkglist.Columns.Add("PackageName");
				dtpkglist.Columns.Add("Active");
				DataRow drpkg;
				
				foreach (ManagementObject vspObject in vspCollection)
	            {
					drpkg = dtpkglist.NewRow();
					drpkg["PackageName"] = vspObject.GetPropertyValue("Name").ToString(); 
					drpkg["Active"] = vspObject.GetPropertyValue("Active").ToString();
					
					dtpkglist.Rows.Add(drpkg);
	            }
				
				dgvpkgname.DataSource = dtpkglist;
				dgvpkgname.Columns[0].Width = 445;
				//dgvpkgname.Columns[0].
			}
			catch( Exception ex )
			{
				toolStripStatusLabel1.Text = "Catch error:"+ex.Message;
				return;
			}
		}
		
		void RbcussCheckedChanged(object sender, EventArgs e)
		{
			try
			{
				if( rbcuss.Checked )
				{
					cbstandard.Items.Clear();
					cbstandard.Items.AddRange( cusslist.ToArray() );
					cbstandard.SelectedIndex = 0;
					cbmode.Items.Clear();
					cbmode.Items.AddRange( cusslist.ToArray() );
					cbmode.SelectedIndex = 0;
				}
				else if( rbcute.Checked )
				{
					cbstandard.Items.Clear();
		    		cbstandard.Items.AddRange( cutelist.ToArray() );
		    		cbstandard.SelectedIndex = 0;
		    		cbmode.Items.Clear();
		    		cbmode.Items.AddRange( cutelist.ToArray() );
		    		cbmode.SelectedIndex = 0;
				}
			}
			catch( Exception ex )
			{
				toolStripStatusLabel1.Text = "OU radio button:"+ex.Message;
			}
		}
		
		void Rbmode2CheckedChanged(object sender, EventArgs e)
		{
			try
			{
				if( rbmode2.Checked )
				{
					cbmode.Enabled = true;
					if( rbcuss.Checked )
					{
						cbmode.Items.Clear();
						cbmode.Items.AddRange( cusslist.ToArray() );
						cbmode.SelectedIndex = 0;
					}
					else if( rbcute.Checked )
					{
						cbmode.Items.Clear();
			    		cbmode.Items.AddRange( cutelist.ToArray() );
			    		cbmode.SelectedIndex = 0;
					}
				}
				else if( rbmode1.Checked )
				{
					cbmode.Enabled = false;
				}	
			}
			catch( Exception ex )
			{
				toolStripStatusLabel1.Text = "Mode radio button:"+ex.Message;
			}
		}
		
		void BtcompareClick(object sender, EventArgs e)
		{
			string standardiws = cbstandard.SelectedItem.ToString();
			List<string> standardnames = new List<string>();
			List<string> packagenames = new List<string>();
			List<string> comparenames = new List<string>();
			List<string> erroriws = new List<string>();			
			
			dgvresult.DataSource = null;
			dgvresult.Rows.Clear();
			if( !dgvresult.Columns.Contains( "iws" ) )
				dgvresult.Columns.Add( "iws" , "IWS Name");
			if( !dgvresult.Columns.Contains( "Action" ) )
			{
				dgvresult.Columns.Add( "action" , "Act");
				dgvresult.Columns[ "action" ].Width = 30;
			}
			if( !dgvresult.Columns.Contains( "pkgname" ) )
			{
				dgvresult.Columns.Add( "pkgname" , "Package Name" );
				dgvresult.Columns[ "pkgname" ].Width = 400;
			}
			
			btlist.PerformClick();
			string compareiws;
			if( rbmode1.Checked )
			{
				// start compare all
				for( int i = 0 ; i < cbstandard.Items.Count ; i++ )
				{
					compareiws = cbstandard.Items[i].ToString();
					
					if( !string.Equals("online", MainForm.PingHost(compareiws), StringComparison.OrdinalIgnoreCase) )
					{
						toolStripStatusLabel1.Text = string.Format(@"{0} is not Online.",compareiws);
						this.dgvresult.Rows.Add(compareiws, "N", "Not Online");
						continue;
					}
					
					if( string.Equals( compareiws, standardiws, StringComparison.OrdinalIgnoreCase) )
						continue;
					
					try //get compare iws package list to packagenames list
					{
						ManagementClass vspClass = new ManagementClass( string.Format(@"\\{0}\root\default:VirtualSoftwarePackage",compareiws) );
						ManagementObjectCollection vspCollection =  vspClass.GetInstances();
						
						foreach (ManagementObject vspObject in vspCollection)
			            {
							packagenames.Add( vspObject.GetPropertyValue("Name").ToString() );
			            }
					}
					catch( Exception ex )
					{
						toolStripStatusLabel1.Text = "Catch error1:"+ex.Message;
						erroriws.Add(compareiws +","+ ex.Message);
						continue;
					}
					try
					{
						if( standardnames.Count == 0 )
						{
							ManagementClass standClass = new ManagementClass( string.Format(@"\\{0}\root\default:VirtualSoftwarePackage",standardiws) );
							ManagementObjectCollection standCollection =  standClass.GetInstances();
							
							foreach (ManagementObject standObject in standCollection)
				            {
								standardnames.Add( standObject.GetPropertyValue("Name").ToString() );
				            }
						}
					}
					catch( Exception ex )
					{
						toolStripStatusLabel1.Text = "Catch error1:"+ex.Message;
						erroriws.Add(compareiws +","+ ex.Message); //Generic failure stop at tsa1ckb109 show last one is tsa1ckb108
					}
					
					try // compare with standard list in datagridview
					{
						for( int j = 0 ; j < standardnames.Count ; j++ )
						{
							if( packagenames.Contains( standardnames[j] ) )
								packagenames.Remove( standardnames[j] ); // have package in standard, remove from packagenames list
							else
								comparenames.Add( standardnames[j] ); // no package in standard, add to standardnames list
						}
					}
					catch( Exception ex )
					{
						toolStripStatusLabel1.Text = "Catch error2:"+ex.Message;
						return;
					}
					
					try
					{
						if( comparenames.Count == 0 && packagenames.Count == 0 )
						{
							this.dgvresult.Rows.Add( compareiws , "S", "package list is the same with "+standardiws );
							continue;
						}
						if( comparenames.Count != 0 )
						{
							foreach( string pkgname in comparenames )
							{
								this.dgvresult.Rows.Add( compareiws, "+", pkgname );
							}
							comparenames.Clear();
						}
						if( packagenames.Count != 0 )
						{
							foreach( string pkgname in packagenames )
							{
								this.dgvresult.Rows.Add( compareiws, "-", pkgname );
							}
							packagenames.Clear();
						}
						if( erroriws.Count != 0 )
						{
							foreach( string iws in erroriws )
							{
								this.dgvresult.Rows.Add( iws.Split(',')[0] , "E", iws.Split(',')[1] );
							}
							erroriws.Clear();
						}
					}
					catch( Exception ex )
					{
						toolStripStatusLabel1.Text = "Catch error3:"+ex.Message;
						return;
					}
	
				} //end compare all loop
			}
			else if( rbmode2.Checked )
			{
				compareiws = cbmode.SelectedItem.ToString();
				
				if( !string.Equals("online", MainForm.PingHost(compareiws), StringComparison.OrdinalIgnoreCase) )
				{
					toolStripStatusLabel1.Text = string.Format(@"{0} is not Online.",compareiws);
					this.dgvresult.Rows.Add(compareiws, "N", "Not Online");
					return;
				}
				
				if( string.Equals( compareiws, standardiws, StringComparison.OrdinalIgnoreCase) )
				{
					toolStripStatusLabel1.Text = "Please select different computer.";
					return;
				}
				
				try //get compare iws package list to packagenames list
				{
					ManagementClass vspClass = new ManagementClass( string.Format(@"\\{0}\root\default:VirtualSoftwarePackage",compareiws) );
					ManagementObjectCollection vspCollection =  vspClass.GetInstances();
					
					foreach (ManagementObject vspObject in vspCollection)
		            {
						packagenames.Add( vspObject.GetPropertyValue("Name").ToString() );
		            }
				}
				catch( Exception ex )
				{
					toolStripStatusLabel1.Text = "Catch error1:"+ex.Message;
					erroriws.Add(compareiws +","+ ex.Message);
				}
				try
				{
					if( standardnames.Count == 0 )
					{
						ManagementClass standClass = new ManagementClass( string.Format(@"\\{0}\root\default:VirtualSoftwarePackage",standardiws) );
						ManagementObjectCollection standCollection =  standClass.GetInstances();
						
						foreach (ManagementObject standObject in standCollection)
			            {
							standardnames.Add( standObject.GetPropertyValue("Name").ToString() );
			            }
					}
				}
				catch( Exception ex )
				{
					toolStripStatusLabel1.Text = "Catch error1:"+ex.Message;
					erroriws.Add(compareiws +","+ ex.Message);
				}
				
				try // compare with standard list in datagridview
				{
					for( int j = 0 ; j < standardnames.Count ; j++ )
					{
						if( packagenames.Contains( standardnames[j] ) )
							packagenames.Remove( standardnames[j] ); // have package in standard, remove from packagenames list
						else
							comparenames.Add( standardnames[j] ); // no package in standard, add to standardnames list
					}
				}
				catch( Exception ex )
				{
					toolStripStatusLabel1.Text = "Catch error2:"+ex.Message;
					return;
				}
				
				try
				{
					if( comparenames.Count == 0 && packagenames.Count == 0 )
					{
						this.dgvresult.Rows.Add( compareiws , "S", "package list is the same with "+standardiws );
					}
					if( comparenames.Count != 0 )
					{
						foreach( string pkgname in comparenames )
						{
							this.dgvresult.Rows.Add( compareiws, "+", pkgname );
						}
						comparenames.Clear();
					}
					if( packagenames.Count != 0 )
					{
						foreach( string pkgname in packagenames )
						{
							this.dgvresult.Rows.Add( compareiws, "-", pkgname );
						}
						packagenames.Clear();
					}
					if( erroriws.Count != 0 )
					{
						foreach( string iws in erroriws )
						{
							this.dgvresult.Rows.Add( iws.Split(',')[0] , "E", iws.Split(',')[1] );
						}
						erroriws.Clear();
					}
				}
				catch( Exception ex )
				{
					toolStripStatusLabel1.Text = "Catch error3:"+ex.Message;
					return;
				}
			}
		}
		
		void BtdeactivateClick(object sender, EventArgs e)
		{
			DataGridViewRow dgvrselected = dgvresult.SelectedRows[0];
			
			string striws = dgvrselected.Cells["iws"].Value.ToString();
			string strpkgname = dgvrselected.Cells["pkgname"].Value.ToString();
			string straction = dgvrselected.Cells["action"].Value.ToString();
			
			try
			{
				if( string.Equals("+",straction,StringComparison.OrdinalIgnoreCase ))
				{
					toolStripStatusLabel1.Text = string.Format(@"{0} is not on {1}.",strpkgname ,striws);
					return;
				}
			}
			catch(Exception ex)
			{
				toolStripStatusLabel1.Text = "Line 193:"+ex.Message;
			}
			
			string strid = "";
			try //get compare iws package list to packagenames list
			{
				ManagementClass vspClass = new ManagementClass( string.Format(@"\\{0}\root\default:VirtualSoftwarePackage",striws) );
				ManagementObjectCollection vspCollection =  vspClass.GetInstances();
				
				foreach (ManagementObject vspObject in vspCollection)
	            {
					if( string.Equals( strpkgname,vspObject.GetPropertyValue("Name").ToString(),StringComparison.OrdinalIgnoreCase ) )
					{
						strid = vspObject.GetPropertyValue("Id").ToString();
					}
	            }
			}
			catch( Exception ex )
			{
				toolStripStatusLabel1.Text = "Catch error1:"+ex.Message;
			}
			
			try
			{
			string ObjectPath = string.Format(@"\\{0}\root\default:VirtualSoftwarePackage.Id='{1}'", striws, strid );
			ManagementObject SVSClass = new ManagementObject(ObjectPath);
			ManagementBaseObject inParams = SVSClass.GetMethodParameters("Deactivate");
			ManagementBaseObject outParams = SVSClass.InvokeMethod("Deactivate", inParams, null);
			string myResult = outParams["ReturnValue"].ToString();
			if( string.Equals( "0" , myResult , StringComparison.OrdinalIgnoreCase) )
			{
				toolStripStatusLabel1.Text = string.Format(@"{0} deactivate successful. Workstation: {1}",strpkgname,striws);
			}
			else
				toolStripStatusLabel1.Text = "Return: "+myResult+" "+strpkgname+" deactivate failed. Workstation: "+striws;
			SVSClass.Dispose();
			}
			catch(Exception ex)
			{
				toolStripStatusLabel1.Text = "Line207:"+ex.Message;
			}
		}
	}
}
