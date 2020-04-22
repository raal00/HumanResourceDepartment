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

		},
		sendDismissalOrder: function ()
		{

		},
		sendFailureToAppearOrder: function ()
		{

		},
		sendQualificationOrder: function ()
		{

		},
		sendVacationOrder: function ()
		{

		},
		sendSickOrder: function ()
		{

		}
	}
})