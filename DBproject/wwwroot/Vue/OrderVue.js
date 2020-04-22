var ordervue = new Vue({
	el: '#ordervue',
	data:
	{
		staff: [{name:'', id:''}],
		/// buisnessTrip order
		positionBuisnessTrip: '',
		startDateBuisnessTrip: '',
		endDateBuisnessTrip: '',
		paymentBuisnessTrip: '',
		employeeIdBuisnessTrip: 0,
		/// Dismissal order
		endDateDismissal: '',
		reasonDismissal: '',
		employeeIdDismissal: 0,
		/// FailureToAppear order
		endDateFailureToAppear: '',
		reasonFailureToAppear: '',
		employeeIdFailureToAppear: 0,
		/// Qualification order
		reasonQualification: '',
		startDateQualification: '',
		endDateQualification: '',
		employeeIdQualification: 0,
		/// Sick order
		startDateSick: '',
		endDateSick: '',
		employeeIdSick: 0,
		/// Vacation order
		startDateVacation: '',
		endDateVacation: '',
		paymentDaysVacation: 0,
		employeeIdVacation: 0
	},

	methods:
	{
		loadEmployee: function () {

			// load staff from database 
		},
		sendBuisnessTripOrder: function ()
		{
			dataPost = {
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