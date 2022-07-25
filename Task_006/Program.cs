using Task_006;

Reger reger = new Reger();

var login = reger.EnterLogin();
var password = reger.EnterPassword();

reger.Registration(login, password);