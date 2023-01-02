//----------------------------------------
// Quoted literal
//----------------------------------------

var a = "Great for single line text without escaped characters";

//----------------------------------------
// Verbatim literal
//----------------------------------------

var b = @"Shall I compare ""Thee"" to a Summers day?
Thou art more lovely and more temperate:";

//----------------------------------------
// Raw literal
//----------------------------------------

var c = $$""""
        Shall I {compare} """Thee""" to a Summers day?
        Thou art {{DateTime.Now.DayOfWeek}} more lovely and more temperate:
        """";

