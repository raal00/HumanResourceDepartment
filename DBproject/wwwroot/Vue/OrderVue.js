var ordervue = new Vue({
	el: '#ordervue',
	data:
	{
		staff: [],
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
				error: function () {
					alert('Ошибка');
				}
			})
		},
		sendBuisnessTripOrder: function ()
		{
			dataPost = {
				Position: this.positionBuisnessTrip,
				StartDate: this.startDateBuisnessTrip,
				EndDate: this.endDateBuisnessTrip,
				Payment: this.paymentBuisnessTrip,
				EmployeeID: this.employeeIdBuisnessTrip
			};
			$.ajax({
				url: '/order/sendBuisnessTripOrder',
				type: 'POST',
				data: dataPost,
				success: function (data) {
					alert('Успешно');
				},
				error: function () {
					alert('Ошибка');
				}
			})
		},
		sendDismissalOrder: function ()
		{
			dataPost = {
				EndDate: this.endDateDismissal,
				Reason: this.reasonDismissal,
				EmployeeID: this.employeeIdDismissal
			};
			$.ajax({
				url: '/order/sendDismissalOrder',
				type: 'POST',
				data: dataPost,
				success: function (data) {
					alert('Успешно');
				},
				error: function () {
					alert('Ошибка');
				}
			})
		},
		sendFailureToAppearOrder: function ()
		{
			dataPost = {
				Date: this.endDateFailureToAppear,
				Reason: this.reasonFailureToAppear,
				EmployeeID: this.employeeIdFailureToAppear
			};
			$.ajax({
				url: '/order/sendFailureOrder',
				type: 'POST',
				data: dataPost,
				success: function (data) {
					alert('Успешно');
				},
				error: function () {
					alert('Ошибка');
				}
			})
		},
		sendQualificationOrder: function ()
		{
			dataPost = {
				Reason: this.reasonQualification,
				StartDate: this.startDateQualification,
				EndDate: this.endDateQualification,
				EmployeeID: this.employeeIdQualification
			};
			$.ajax({
				url: '/order/sendQualificationOrder',
				type: 'POST',
				data: dataPost,
				success: function (data) {
					alert('Успешно');
				},
				error: function () {
					alert('Ошибка');
				}
			})
		},
		sendVacationOrder: function ()
		{
			dataPost = {
				StartDate: this.startDateVacation,
				EndDate: this.endDateVacation,
				PaymentDays: this.paymentDaysVacation,
				EmployeeID: this.employeeIdVacation
			};
			$.ajax({
				url: '/order/sendVacationOrder',
				type: 'POST',
				data: dataPost,
				success: function (data) {
					alert('Успешно');
				},
				error: function () {
					alert('Ошибка');
				}
			})
		},
		sendSickOrder: function ()
		{
			dataPost = {
				StartDate: this.startDateSick,
				EndDate: this.endDateSick,
				EmployeeID: this.employeeIdSick
			};
			$.ajax({
				url: '/order/sendSickOrder',
				type: 'POST',
				data: dataPost,
				success: function (data) {
					alert('Успешно');
				},
				error: function () {
					alert('Ошибка');
				}
			})
		}
	}
})