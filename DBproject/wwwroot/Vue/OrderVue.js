var ordervue = new Vue({
	el: '#ordervue',
	data:
	{
		email: "",
		password: ""
	},

	methods:
	{
		AlertText: function () {
			this.email = this.email.split(' ').reverse().join(' ');
			alert(this.email);
		}
	}
})