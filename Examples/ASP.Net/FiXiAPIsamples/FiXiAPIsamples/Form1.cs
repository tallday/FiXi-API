using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FiXiAPIsamples
{
    public partial class Form1 : Form
    {
        Guid AppId = new Guid("3ef77e2d-12e3-4011-814e-df9785d5270f");
        string Username = "apidemo";
        string Password = "apidemo";


        public Form1()
        {
            InitializeComponent();
        }

        private void btnMatchbyDate_Click(object sender, EventArgs e)
        {

            //Match Service 
            MatchService.MatchServiceClient MatchServiceClient = new MatchService.MatchServiceClient();
            MatchServiceClient.ClientCredentials.UserName.UserName = Username;
            MatchServiceClient.ClientCredentials.UserName.Password = Password;

            MatchService.GetMatchesByDateRangeRequest GetMatchesByDateRangeRequest = new MatchService.GetMatchesByDateRangeRequest();
            GetMatchesByDateRangeRequest.ApplicationId = AppId;
            GetMatchesByDateRangeRequest.StartDate = new DateTime(dtMatchByDate.Value.Year,dtMatchByDate.Value.Month,dtMatchByDate.Value.Day);
            GetMatchesByDateRangeRequest.EndDate = GetMatchesByDateRangeRequest.StartDate.AddDays(1);
            MatchService.GetMatchesByDateRangeResponse response = MatchServiceClient.GetMatchesByDateRange(GetMatchesByDateRangeRequest);

            txtGetMatchesByDateRange.AppendText(response.Message + Environment.NewLine);


            MatchService.MatchListView[] Matches = response.MatchListViewList;

            if (Matches.Length > 0)
            {
                foreach (MatchService.MatchListView match in Matches)
                {
                    txtGetMatchesByDateRange.AppendText("StartTime: " + match.StartTime.ToString() + Environment.NewLine);
                }
            }
            else { txtGetMatchesByDateRange.AppendText("No Matches Found for that date"); }

            
                
          

        }

        private void btnGetTeamDetails_Click(object sender, EventArgs e)
        {
            //Team Service - Get a Team by ID
            TeamService.TeamServiceClient TeamServiceClient = new TeamService.TeamServiceClient();
            TeamServiceClient.ClientCredentials.UserName.UserName = Username;
            TeamServiceClient.ClientCredentials.UserName.Password = Password;

            TeamService.GetTeamDetailsRequest TeamDetailsRequest = new TeamService.GetTeamDetailsRequest();
            TeamDetailsRequest.ApplicationId = AppId;
            TeamDetailsRequest.TeamId = int.Parse(txtGetTeamDetailsParam.Text);
            TeamService.GetTeamDetailsResponse response = TeamServiceClient.GetTeamDetails(TeamDetailsRequest);

            txtGetTeamDetails.AppendText(response.Message + Environment.NewLine);

            txtGetTeamDetails.AppendText("Team Name: " + response.TeamDetailView.Name);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Customer Service
            CustomerService.CustomerServiceClient CustomerServiceClient = new CustomerService.CustomerServiceClient();
            CustomerServiceClient.ClientCredentials.UserName.UserName = Username;
            CustomerServiceClient.ClientCredentials.UserName.Password = Password;

            CustomerService.SaveCustomerAttendanceRequest request = new CustomerService.SaveCustomerAttendanceRequest();
            request.ApplicationId = AppId;
            request.Attended = true;
            request.CalendarId = 165840;
            request.CustomerId = 10538;
            request.TeamId = 6281;
            CustomerService.SaveCustomerAttendanceResponse response = CustomerServiceClient.SaveCustomerAttendance(request);

            MessageBox.Show(response.Message); 
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Resource Service
            ResourceService.ResourceServiceClient ResourceServiceClient = new ResourceService.ResourceServiceClient();
            ResourceServiceClient.ClientCredentials.UserName.UserName = Username;
            ResourceServiceClient.ClientCredentials.UserName.Password = Password;

            ResourceService.GetResourcesRequest GetResourceRequest = new ResourceService.GetResourcesRequest();
            GetResourceRequest.ApplicationId = AppId;
            ResourceService.GetResourcesResponse response = ResourceServiceClient.GetResources(GetResourceRequest);

            MessageBox.Show(response.Message); 

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Transaction Service
            TransactionService.TransactionServiceClient TransactionServiceClient = new TransactionService.TransactionServiceClient();
            TransactionServiceClient.ClientCredentials.UserName.UserName = Username;
            TransactionServiceClient.ClientCredentials.UserName.Password = Password;

            TransactionService.GetTeamPaymentTransactionRequest GetTeamPaymentTransactionRequest = new TransactionService.GetTeamPaymentTransactionRequest();
            GetTeamPaymentTransactionRequest.ApplicationId = AppId;
            GetTeamPaymentTransactionRequest.TeamId = 6281;
            TransactionService.GetTeamPaymentTransactionResponse response = TransactionServiceClient.GetTeamPaymentTransactions(GetTeamPaymentTransactionRequest);

            MessageBox.Show(response.Message);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Centre Service
            CentreService.CentreServiceClient CentreServiceClient = new CentreService.CentreServiceClient();
            CentreServiceClient.ClientCredentials.UserName.UserName = Username;
            CentreServiceClient.ClientCredentials.UserName.Password = Password;
            CentreService.GetCentreRequest GetCentreRequest = new CentreService.GetCentreRequest();
            GetCentreRequest.ApplicationId = AppId;
           CentreService.GetCentreResponse response = CentreServiceClient.GetCentre(GetCentreRequest);

           MessageBox.Show(response.Message); 


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("http://api.fixionline.com/");
            Process.Start(sInfo);
        }
        

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://github.com/tallday/FiXi-API");
            Process.Start(sInfo);
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
             ProcessStartInfo sInfo = new ProcessStartInfo("mailto:support@fixionline.com");
            Process.Start(sInfo);
        
        }
      
    }
}
