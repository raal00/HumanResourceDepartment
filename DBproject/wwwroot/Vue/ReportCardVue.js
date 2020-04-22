var reportcardvue = new Vue({
	el: '#reportcardvue',
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