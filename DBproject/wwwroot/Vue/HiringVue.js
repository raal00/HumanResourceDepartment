var hiringvue = new Vue({
	el: '#hiringvue',
	data:
	{
		fname: '',
		sname: '',
		tname: '',
		passportId: '',
		Birthday: '',
		position: '',
		salary: 0,
		conditions: '',
		vacationDays: 0,
		isVacPay: false,
		isTravPay: false,
		isSickPay: false
	},
	methods:
	{
		SendRequest: function () {
			if (this.fname == '' || this.sname == '' || this.tname == '' ||
				this.passportId == '' || this.Birthday == '')
			{
				alert('Введите все поля');
				return;
			}
			if (this.salary <= 0)
			{
				alert('Зарплата не может быть отрицательной');
				return;
			}
			dataPost = {
				fname: this.fname,
				sname: this.sname
            };
            $.ajax({
                url: '/controller/method',
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