var appVue = new Vue({
	el: '#appVue',
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