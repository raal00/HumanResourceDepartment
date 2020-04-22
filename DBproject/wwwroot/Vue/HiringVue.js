var hiringvue = new Vue({
	el: '#hiringvue',
	data:
	{
		fname: '',
		sname: '',
		tname: '',
		passportId: '',
		birthday: new Date(),
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
				this.passportId == '')
			{
				alert('Введите все поля');
				return;
			}
			if (this.salary <= 0)
			{
				alert('Зарплата не может быть отрицательной');
				return;
			}
			var vue = this;
			dataPost = {
				Fname: vue.fname,
				Sname: vue.sname,
				Tname: vue.tname,
				Birthday: vue.birthday,
				PassportId: vue.passportId,
				Position: vue.position,
				Salary: vue.salary,
				Conditions: vue.conditions,
				VacationDays: vue.vacationDays,
				IsVacationPay: vue.isVacPay,
				IsTravelingPay: vue.isTravPay,
				IsSickPay: vue.isSickPay
			};
            $.ajax({
				url: '/staff/newEmployeeRequest',
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