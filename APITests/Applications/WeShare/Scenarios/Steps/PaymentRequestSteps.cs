using System.Collections.Generic;
using FluentAssertions;
using Gauge.CSharp.Lib.Attribute;
using Applications.WeShare.Swagger.Api;
using Applications.WeShare.Swagger.Model;
using Applications.WeShare.Swagger.Client;
using Gauge.CSharp.Lib;
using System;

namespace Applications.WeShare.Scenarios.Steps
{
    public class PaymentRequestSteps
    {
        private readonly PaymentRequestsApi _paymentRequestsApi = new(StepsHelper.BasePath);

		// [Step("Get all payment requests and verify that sample payment requests match this data: <paymentRequestsTable>")]
		// public void GetAllPaymentRequestsAndVerifyThatSamplePaymentRequestsMatchThisData(Table paymentRequestsTable)
		// {
		// 	List<PaymentRequestDTO> paymentRequests = _paymentRequestsApi.FindAllPaymentRequests();
        //     var rows = paymentRequestsTable.GetTableRows();

        //     for (int i = 0; i < 2; i++) {
        //         var row = rows[i];
        //         int expectedId = Convert.ToInt32(row.GetCell("id"));
        //         int expectedExpenseId = Convert.ToInt32(row.GetCell("expenseId"));
        //         int expectedFromPersonId = Convert.ToInt32(row.GetCell("fromPersonId"));
        //         int expectedToPersonId = Convert.ToInt32(row.GetCell("toPersonId"));
        //         string expectedDate = row.GetCell("date");
        //         long expectedAmount = Convert.ToInt64(row.GetCell("amount"));
        //         bool expectedIsPaid = Convert.ToBoolean(row.GetCell("isPaid"));

        //         var paymentRequest = paymentRequests[i];
        //         paymentRequest.Id.Should().Be(expectedId);
        //         paymentRequest.ExpenseId.Should().Be(expectedExpenseId);
        //         paymentRequest.FromPersonId.Should().Be(expectedFromPersonId);
        //         paymentRequest.ToPersonId.Should().Be(expectedToPersonId);
        //         paymentRequest.Date.Should().Be(expectedDate);
        //         paymentRequest.Amount.Should().Be(expectedAmount);
        //         paymentRequest.Paid.Should().Be(expectedIsPaid);

        //     }
		// }
	
		[Step("Get all payment requests")]
		public void GetAllPaymentRequests()
		{
			throw new NotImplementedException();
		}
	
		[Step("Payment request(s) should match this data: <paymentRequestTable>")]
		public void PaymentRequestSShouldMatchThisData(Table paymentRequestTable)
		{
			throw new NotImplementedException();
		}
	}
}