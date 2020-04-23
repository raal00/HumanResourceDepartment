var ordervue = new Vue({
	el: '#ordervue',
	data:
	{
		staff: [],
		showSuccessResult: false,
		showErrorResult: false,
		resultMessage: '',
		/// buisnessTrip order +
		positionBuisnessTrip: '',
		startDateBuisnessTrip: '',
		endDateBuisnessTrip: '',
		paymentBuisnessTrip: '',
		employeeIdBuisnessTrip: 0,
		/// Dismissal order +
		endDateDismissal: '',
		reasonDismissal: '',
		employeeIdDismissal: 0,
		/// FailureToAppear order
		endDateFailureToAppear: '',
		reasonFailureToAppear: '',
		employeeIdFailureToAppear: 0,
		/// Qualification order +
		reasonQualification: '',
		startDateQualification: '',
		endDateQualification: '',
		employeeIdQualification: 0,
		/// Sick order +
		startDateSick: '',
		endDateSick: '',
		employeeIdSick: 0,
		/// Vacation order +
		startDateVacation: '',
		endDateVacation: '',
		paymentDaysVacation: 0,
		employeeIdVacation: 0
	},
	methods:
	{
		closeAlert: function ()
		{
			this.showErrorResult = false;
			this.showSuccessResult = false;
		},
		loadEmployee: function ()
		{
			// load staff from database 
			var vue = this;
			vue.staff = [];
			$.ajax({
				url: '/order/loadStaffList',
				type: 'GET',
				success: function (response) {
					vue.staff = response.staffList;
					console.log(response);
					alert('Успешно!');
				},
				error: function (data) {
					alert('Ошибка');
				}
			})
		},
		sendBuisnessTripOrder: function ()
		{
			var vue = this;
			dataPost = {
				Position: vue.positionBuisnessTrip,
				StartDate: vue.startDateBuisnessTrip,
				EndDate: vue.endDateBuisnessTrip,
				Payment: vue.paymentBuisnessTrip,
				EmployeeID: vue.employeeIdBuisnessTrip
			};
			$.ajax({
				url: '/order/sendBuisnessTripOrder',
				type: 'POST',
				data: dataPost,
				success: function (data) {
					if (data.state == 0) {
						vue.showSuccessResult = true;
						vue.resultMessage = data.message;
					}
					else {
						vue.showErrorResult = true;
						vue.resultMessage = data.message;
					}
				},
				error: function () {
				}
			})
		},
		sendDismissalOrder: function ()
		{
			var vue = this;
			dataPost = {
				EndDate: vue.endDateDismissal,
				Reason: vue.reasonDismissal,
				EmployeeID: vue.employeeIdDismissal
			};
			$.ajax({
				url: '/order/sendDismissalOrder',
				type: 'POST',
				data: dataPost,
				success: function (data) {
					if (data.state == 0) {
						vue.showSuccessResult = true;
						vue.resultMessage = data.message;
					}
					else {
						vue.showErrorResult = true;
						vue.resultMessage = data.message;
					}
				},
				error: function () {
					alert('/error');
				}
			})
		},
		sendFailureToAppearOrder: function ()
		{
			var vue = this;
			dataPost = {
				Date: vue.endDateFailureToAppear,
				Reason: vue.reasonFailureToAppear,
				EmployeeID: vue.employeeIdFailureToAppear
			};
			$.ajax({
				url: '/order/sendFailureOrder',
				type: 'POST',
				data: dataPost,
				success: function (data) {
					if (data.state == 0) {
						vue.showSuccessResult = true;
						vue.resultMessage = data.message;
					}
					else {
						vue.showErrorResult = true;
						vue.resultMessage = data.message;
					}
				},
				error: function () {
					alert('/error');
				}
			})
		},
		sendQualificationOrder: function ()
		{
			var vue = this;
			dataPost = {
				Reason: vue.reasonQualification,
				StartDate: vue.startDateQualification,
				EndDate: vue.endDateQualification,
				EmployeeID: vue.employeeIdQualification
			};
			$.ajax({
				url: '/order/sendQualificationOrder',
				type: 'POST',
				data: dataPost,
				success: function (data) {
					if (data.state == 0) {
						vue.showSuccessResult = true;
						vue.resultMessage = data.message;
					}
					else {
						vue.showErrorResult = true;
						vue.resultMessage = data.message;
					}
				},
				error: function () {
					alert('/error');
				}
			})
		},
		sendVacationOrder: function ()
		{
			var vue = this;
			dataPost = {
				StartDate: vue.startDateVacation,
				EndDate: vue.endDateVacation,
				PaymentDays: vue.paymentDaysVacation,
				EmployeeID: vue.employeeIdVacation
			};
			$.ajax({
				url: '/order/sendVacationOrder',
				type: 'POST',
				data: dataPost,
				success: function (data) {
					console.log(data);
					if (data.state == 0) {
						vue.showSuccessResult = true;
						vue.resultMessage = data.message;
					}
					else {
						vue.showErrorResult = true;
						vue.resultMessage = data.message;
					}
				},
				error: function () {
					alert('/error');
				}
			})
		},
		sendSickOrder: function ()
		{
			var vue = this;
			dataPost = {
				StartDate: vue.startDateSick,
				EndDate: vue.endDateSick,
				EmployeeID: vue.employeeIdSick
			};
			$.ajax({
				url: '/order/sendSickOrder',
				type: 'POST',
				data: dataPost,
				success: function (data) {
					if (data.state == 0) {
						vue.showSuccessResult = true;
						vue.resultMessage = data.message;
					}
					else {
						vue.showErrorResult = true;
						vue.resultMessage = data.message;
					}
				},
				error: function () {
					alert('/error');
			    }
			})
		}
	}
})