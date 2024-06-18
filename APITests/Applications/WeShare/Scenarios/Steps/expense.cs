using System.Net;
using NUnit.Framework;
using RestSharp;

[TestFixture]
public class ApiTests
{
    private RestClient client;

    [SetUp]
    public void Setup()
    {
        // Initialize the REST client with the base API URL
        client = new RestClient("http://localhost:5050");
    }

    [Test]
    public void TestCreateNewExpense()
    {
        // Specify the expense data in the specified format
        var expenseData = new
        {
            personId = 123, // Replace with the actual person ID
            date = "2023-01-01", // Replace with the desired date format
            description = "Test Expense",
            amount = 50.00 // Replace with the desired amount
        };

        // Create the API request to create a new expense
        var request = new RestRequest("/expenses", Method.Post);
        request.AddJsonBody(expenseData);

        // Execute the request
        var response = client.Execute(request);

        // Assert the response status code and content
        Assert.AreEqual(HttpStatusCode.Created, response.StatusCode);
        Assert.IsTrue(response.Content.Contains("Expense Created"));
        // Modify assertions based on the actual response content
    }

    // Additional tests for other API endpoints can be added similarly.

        public void TestFindExpensesForPerson()
        
    {
        // Replace with the actual person ID
        string personId = "person123";

        // Create the request payload in the specified format
        var requestPayload = new
        {
            personId = 0, // You can replace this with the actual person ID
            date = "2023-01-01", // Replace with the desired date format
            description = "Test Expense",
            amount = 50.00 // Replace with the desired amount
        };

        // Create the API request to find expenses for a person
        var request = new RestRequest($"/expenses/person/{personId}", Method.Get);
        request.AddJsonBody(requestPayload);

        // Execute the request
        var response = client.Execute(request);

        // Assert the response status code and content
        Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        Assert.IsTrue(response.Content.Contains("Expenses for Person"));
        // Modify assertions based on the actual response content and structure
    }
}



    // Additional tests for other API endpoints can be added similarly.

    // Model class to represent the structure of an expense object
    public class ExpenseModel
    {
        public int ExpenseId { get; set; }
        public int PersonId { get; set; }
        public string Date { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public decimal TotalPaymentsRequested { get; set; }
        public decimal TotalPaymentsReceived { get; set; }
        public decimal NettAmount { get; set; }


    // Additional tests for other API endpoints can be added similarly.
}
    
// }

