using Applications.WeShare.Swagger.Api;
using System;
using System.Collections.Generic;
using System.Net.Http;
using NUnit.Framework;
using Applications.WeShare.Swagger.Model;
using Applications.WeShare.Swagger.Client;

[TestFixture]
public class People
{
    private readonly HttpClient _httpClient = new HttpClient();
    private readonly IPeopleApiSync _peopleApi = new PeopleApi("http://localhost:5050");

    [Test]
    public void TestFindAllPeople()
    {
        // Arrange & Act
        List<Person> people = _peopleApi.FindAllPeople();

        // Assert
        Assert.IsNotNull(people);
        Assert.IsNotEmpty(people);
    }

    [Test]
    public void TestFindPersonById()
    {
        // Arrange
        int validPersonId = 1;

        // Act
        Person person = _peopleApi.FindPersonById(validPersonId);

        // Assert
        Assert.IsNotNull(person);
        Assert.AreEqual(validPersonId, person.Id);
    }

    // [Test]
    // public void TestFindPaymentsByPersonId()
    // {
    //     // Arrange
    //     int validPersonId = 1;

    //     // Act
    //     List<PaymentDTO> payments = _peopleApi.FindPaymentsByPersonId(validPersonId);

    //     // Assert
    //     Assert.IsNotNull(payments);
    //     // Add specific assertions based on your API response structure
    // }

    // [Test]
    // public void TestCreatePayment()
    // {
    //     // Arrange
    //     PaymentDTO payment = new PaymentDTO
    //     {
    //         Amount = 100.0,
    //         Recipient = "example@example.com",
    //         // Add other required payment properties
    //     };

    //     // Act
    //     ApiResponse<PaymentDTO> response = _peopleApi.CreatePayment(payment);

    //     // Assert
    //     Assert.IsNotNull(response);
    //     Assert.IsTrue(response.StatusCode == System.Net.HttpStatusCode.Created);
    // }

    [Test]
    public void TestLogin()
    {
        // Arrange
        LoginDTO validLoginDTO = new LoginDTO
        {
            Email = "student1@wethinkcode.co.za",
            // Add other required login properties
        };

        // Act
        Person loggedInPerson = _peopleApi.Login(validLoginDTO);

        // Assert
        Assert.IsNotNull(loggedInPerson);
        Assert.AreEqual(validLoginDTO.Email, loggedInPerson.Email);
    }


    [TearDown]
    public void Cleanup()
    {
        _httpClient.Dispose();
    }
}
