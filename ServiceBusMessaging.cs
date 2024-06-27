using Azure.Messaging.ServiceBus;
using Microsoft.Azure.ServiceBus.Core;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Configuration;
using System.Text;
using Message = Microsoft.Azure.ServiceBus.Message;

namespace AzureServiceBusMessaging
{
    public partial class ServiceBusMessaging : Form
    {
        string asbConnectionString = string.Empty;

        string asbContactMessageTemplate = "{\r\n  \"EntityType\": \"Contact\",\r\n  \"EventType\": \"Cmc.Core.Eventing.SavedEvent, Cmc.Core\",\r\n  \"ArgumentData\": {\r\n    \"ValidationMessages\": [],\r\n    \"OriginalEntity\": null,\r\n    \"Context\": null,\r\n    \"CancelPipelineExecution\": false\r\n  },\r\n  \"EventTimeStamp\": \"2023-05-11T15:33:35.4241471Z\",\r\n  \"EntityData\": \"{\\r\\n  \\\"IsExcludedCrmIntegration\\\": false,\\r\\n  \\\"AddressTypeId\\\": 0,\\r\\n  \\\"StudentInquiryRequired\\\": true,\\r\\n  \\\"ExtraCurricularsList\\\": [],\\r\\n  \\\"ProgramsList\\\": [],\\r\\n  \\\"EnrolledProgramIdList\\\": [],\\r\\n  \\\"EthnicitiesList\\\": [],\\r\\n  \\\"LeadSourcesList\\\": [],\\r\\n  \\\"DeleteVeteranDetails\\\": false,\\r\\n  \\\"Vendors\\\": [],\\r\\n  \\\"StudentAddressAssociation\\\": 2,\\r\\n  \\\"NewAssignedAdmissionsRepId\\\": 0,\\r\\n  \\\"AssignedAdmissionsRepReassignedDate\\\": \\\"0001-01-01T00:00:00\\\",\\r\\n  \\\"StudentRelationshipAddress\\\": null,\\r\\n  \\\"LastFourSsn\\\": \\\"\\\",\\r\\n  \\\"CustomProperties\\\": {},\\r\\n  \\\"MultiValueCustomProperties\\\": {},\\r\\n  \\\"OriginalCustomPropertiesValues\\\": null,\\r\\n  \\\"OriginalMultiValueCustomPropertiesValues\\\": null,\\r\\n  \\\"GenderPronounList\\\": [],\\r\\n  \\\"OverridePrevEducAltPellValidation\\\": false,\\r\\n  \\\"Id\\\": 10,\\r\\n  \\\"AcgEligReasonCode\\\": null,\\r\\n  \\\"AgencyId\\\": 0,\\r\\n  \\\"AlienNumber\\\": \\\"\\\",\\r\\n  \\\"ArAccountStatus\\\": \\\"X\\\",\\r\\n  \\\"ArBalance\\\": 0.0,\\r\\n  \\\"ArNextTransactionNumber\\\": 0,\\r\\n  \\\"AssignedAdmissionsRepId\\\": 68,\\r\\n  \\\"AthleticIdentifier\\\": null,\\r\\n  \\\"BestTimeToContact\\\": \\\"Anytime\\\",\\r\\n  \\\"CampusId\\\": 6,\\r\\n  \\\"CitizenId\\\": 0,\\r\\n  \\\"City\\\": \\\"\\\",\\r\\n  \\\"CollegeId\\\": null,\\r\\n  \\\"CountryId\\\": 1,\\r\\n  \\\"CountyId\\\": 0,\\r\\n  \\\"CreatedDateTime\\\": \\\"2023-04-21T04:04:23\\\",\\r\\n  \\\"CumulativeGpa\\\": null,\\r\\n  \\\"CumulativeGpaPoints\\\": null,\\r\\n  \\\"CurrencyCodeId\\\": null,\\r\\n  \\\"CurrentLda\\\": null,\\r\\n  \\\"DataBlockIndicator\\\": false,\\r\\n  \\\"DateOfBirth\\\": null,\\r\\n  \\\"DbiModifiedDate\\\": null,\\r\\n  \\\"DefaultAddressCode\\\": null,\\r\\n  \\\"DefaultMasterStudentAddressId\\\": null,\\r\\n  \\\"DefaultStudentAddressId\\\": null,\\r\\n  \\\"Disabled\\\": \\\"X\\\",\\r\\n  \\\"DriverLicenseNumber\\\": \\\"\\\",\\r\\n  \\\"DriverLicenseState\\\": \\\"\\\",\\r\\n  \\\"EmailAddress\\\": \\\"asbdemo@asbdemo.com\\\",\\r\\n  \\\"EmployabilityAboutInfo\\\": null,\\r\\n  \\\"EmployerId\\\": 0,\\r\\n  \\\"EmploymentStatusId\\\": 0,\\r\\n  \\\"ExternalStudentIdentifier\\\": null,\\r\\n  \\\"ExtraCurricularActivityId\\\": 0,\\r\\n  \\\"FacebookUrl\\\": null,\\r\\n  \\\"FaGradPlusCounselingDate\\\": null,\\r\\n  \\\"FaRigorousHighSchoolProgramCodeId\\\": null,\\r\\n  \\\"FirstName\\\": \\\"ASB DEMO\\\",\\r\\n  \\\"GenderId\\\": 6,\\r\\n  \\\"GpaCredits\\\": null,\\r\\n  \\\"HispanicLatino\\\": null,\\r\\n  \\\"HsAcademicGpa\\\": null,\\r\\n  \\\"InstagramUrl\\\": null,\\r\\n  \\\"IsActive\\\": true,\\r\\n  \\\"IsAllowedBulkRegistrationByTrack\\\": null,\\r\\n  \\\"IsBadAddress\\\": false,\\r\\n  \\\"IsBadPhone\\\": false,\\r\\n  \\\"IsDdVeteran\\\": false,\\r\\n  \\\"IsEftDefaultForStipends\\\": false,\\r\\n  \\\"IsInDistrict\\\": false,\\r\\n  \\\"IsSscrError11Received\\\": false,\\r\\n  \\\"LastActivityDate\\\": null,\\r\\n  \\\"LastInterestDate\\\": null,\\r\\n  \\\"LastModifiedDateTime\\\": \\\"2023-05-11T11:33:34.8303895-04:00\\\",\\r\\n  \\\"LastModifiedUserId\\\": 56,\\r\\n  \\\"LastName\\\": \\\"Test 2\\\",\\r\\n  \\\"LastNameFirstFour\\\": \\\"Test\\\",\\r\\n  \\\"LastStatementBeginDate\\\": null,\\r\\n  \\\"LastStatementCloseDate\\\": null,\\r\\n  \\\"LastStatementDate\\\": null,\\r\\n  \\\"LeadDate\\\": \\\"2023-04-21T13:33:00\\\",\\r\\n  \\\"LeadSourceId\\\": 692,\\r\\n  \\\"LeadTypeId\\\": 0,\\r\\n  \\\"LinkedInUrl\\\": null,\\r\\n  \\\"MaidenName\\\": \\\"\\\",\\r\\n  \\\"MaritalStatusId\\\": 0,\\r\\n  \\\"Mi\\\": \\\"\\\",\\r\\n  \\\"MiddleName\\\": \\\"\\\",\\r\\n  \\\"MobilePhoneNumber\\\": \\\"\\\",\\r\\n  \\\"NationalityId\\\": 0,\\r\\n  \\\"NickName\\\": \\\"\\\",\\r\\n  \\\"NiStudent\\\": false,\\r\\n  \\\"Note\\\": \\\"\\\",\\r\\n  \\\"OriginalAssignedAdmissionsRepId\\\": 68,\\r\\n  \\\"OriginalExpectedStartDate\\\": null,\\r\\n  \\\"OriginalStartDate\\\": null,\\r\\n  \\\"OtherEmailAddress\\\": \\\"\\\",\\r\\n  \\\"OtherPhoneNumber\\\": null,\\r\\n  \\\"PersonId\\\": 157,\\r\\n  \\\"PhoneNumber\\\": \\\"\\\",\\r\\n  \\\"Pin\\\": null,\\r\\n  \\\"PostalCode\\\": \\\"\\\",\\r\\n  \\\"PostalCodeFirstThree\\\": \\\"   \\\",\\r\\n  \\\"PreferredContactType\\\": \\\"Ph\\\",\\r\\n  \\\"PreferredName\\\": null,\\r\\n  \\\"PreviousEducationGpa\\\": null,\\r\\n  \\\"PreviousEducationId\\\": 0,\\r\\n  \\\"ProgramGroupId\\\": 0,\\r\\n  \\\"ProgramId\\\": 0,\\r\\n  \\\"RawFirstName\\\": \\\"ASBDEMO\\\",\\r\\n  \\\"RawLastName\\\": \\\"Test\\\",\\r\\n  \\\"RawPhoneNumber\\\": \\\"\\\",\\r\\n  \\\"RowVersion\\\": \\\"AAAAAABiT/k=\\\",\\r\\n  \\\"SchoolStatusId\\\": 1,\\r\\n  \\\"ShiftId\\\": 0,\\r\\n  \\\"SmsServiceProviderId\\\": null,\\r\\n  \\\"SourceSystem\\\": \\\"C\\\",\\r\\n  \\\"Ssn\\\": \\\"\\\",\\r\\n  \\\"StartDate\\\": null,\\r\\n  \\\"State\\\": \\\"\\\",\\r\\n  \\\"StatementComment\\\": \\\"\\\",\\r\\n  \\\"StreetAddress\\\": \\\"\\\",\\r\\n  \\\"StreetAddress2\\\": null,\\r\\n  \\\"StudentFullName\\\": null,\\r\\n  \\\"StudentIdentifier\\\": null,\\r\\n  \\\"StudentNumber\\\": \\\"10\\\",\\r\\n  \\\"SubscribeToSms\\\": false,\\r\\n  \\\"Suffix\\\": null,\\r\\n  \\\"SuffixId\\\": null,\\r\\n  \\\"TitleId\\\": 0,\\r\\n  \\\"TwitterUrl\\\": null,\\r\\n  \\\"Veteran\\\": \\\"X\\\",\\r\\n  \\\"WorkPhoneNumber\\\": \\\"\\\",\\r\\n  \\\"WorkPhoneNumberExtension\\\": \\\"\\\",\\r\\n  \\\"OriginalState\\\": \\\"\\\",\\r\\n  \\\"SecureState\\\": \\\"\\\",\\r\\n  \\\"ExtendedProperties\\\": [],\\r\\n  \\\"EntityState\\\": 2\\r\\n}\",\r\n  \"UserId\": 0\r\n}";

        public ServiceBusMessaging()
        {
            InitializeComponent();
        }
        private void btnSendMessages_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            if (string.IsNullOrEmpty(txtASBConnectionString.Text.Trim()))
            {
                MessageBox.Show("Please enter Service Bus Connection String");
                return;
            }

            if (string.IsNullOrEmpty(txtasbTopicName.Text.Trim()))
            {

                MessageBox.Show("Please enter Service Bus Topic Name");
                return;
            }

            if (string.IsNullOrEmpty(txtSessionid1.Text))
            {
                MessageBox.Show("Please enter Session 1 Id");
                return;
            }
            if (string.IsNullOrEmpty(txtSessionid2.Text))
            {
                MessageBox.Show("Please enter Session 2 Id");
                return;
            }

            JObject asbMessageobj = JObject.Parse(asbContactMessageTemplate);

            var asbMessageSender = new MessageSender(asbConnectionString, txtasbTopicName.Text.Trim());
            var messageList = new List<Message>();
            //ServiceBusClient serviceBusClient = new ServiceBusClient(asbConnectionString);
            //var asbMessageSender = serviceBusClient.CreateSender("anth-studentsync-stu-sbt-01");
            for (var i = 0; i < 10; i++)
            {
                Message message = new Message();
                asbMessageobj["EntityData"] = string.IsNullOrEmpty(txtAsbMessage.Text) ? asbContactMessageTemplate : txtAsbMessage.Text;
                var id = i < 5 ? txtSessionid1.Text : txtSessionid2.Text;
                asbMessageobj["EntityType"] = "SampleObjectType";
                message.SessionId = id;
                message.Body = Encoding.ASCII.GetBytes(JsonConvert.SerializeObject(asbMessageobj));
                messageList.Add(message);
            }
            asbMessageSender.SendAsync(messageList).Wait();
            MessageBox.Show($"Message sent to topic: {txtasbTopicName} successfully ");
            txtSessionid1.Clear();
            txtSessionid2.Clear();
            this.Cursor = Cursors.Default;
        }

        private void btnBulkUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtASBConnectionString.Text.Trim()))
            {
                MessageBox.Show("Please enter Service Bus Connection String");
                return;
            }

            if (string.IsNullOrEmpty(txtasbTopicName.Text.Trim()))
            {

                MessageBox.Show("Please enter Service Bus Topic Name");
                return;
            }           

            this.Cursor = Cursors.WaitCursor;
            JObject asbMessageobj = new JObject();
            asbMessageobj["EntityData"] = txtAsbMessage.Text.Trim();
            asbMessageobj["EntityType"] = "SampleObjectType";
            JObject asbBulkMessage = new JObject();

            ServiceBusClient serviceBusClient = new ServiceBusClient(asbConnectionString);
            var asbMessageSender = serviceBusClient.CreateSender(txtasbTopicName.Text.Trim());
            var sessionId = new Random().Next();
            var entityBulkUpdate = new JArray();
            for (var i = 0; i < 10; i++)
            {
                var entity = asbBulkMessage;
                entity[$"Message{i}"] = entity["EntityData"].ToString()+" Update " + sessionId + i.ToString();
                entityBulkUpdate.Add(entity);
            }
            asbMessageobj["EntityData"] = entityBulkUpdate;
            ServiceBusMessage message = new ServiceBusMessage();
            message.SessionId = sessionId.ToString();
            message.Body = BinaryData.FromBytes(Encoding.ASCII.GetBytes(JsonConvert.SerializeObject(asbMessageobj)));
            asbMessageSender.SendMessageAsync(message).Wait();
            MessageBox.Show($"Bulk Message sent to topic: {txtasbTopicName.Text} successfully ");
            this.Cursor = Cursors.Default;
        }

        private void txtASBConnectionString_Leave(object sender, EventArgs e)
        {
            asbConnectionString = txtASBConnectionString.Text.Trim();
            var asbConnectionStringArray = asbConnectionString.Split(';');
            var asbNameSpace = asbConnectionStringArray[0].Split('/')[2];
            txtServiceBusNamespace.Text = asbNameSpace;
            txtasbNamespaceKeyName.Text = asbConnectionStringArray[1].Split('=')[1];
        }
    }
}
