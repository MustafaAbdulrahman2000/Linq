using Lecture_01.Extensions;
using Lecture_01.Services;

IPureVsImpureService service = new PureVsImpureService();

service.Numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9];


// [1] Impure function: External dependencies (e.g., random number generation).

service.Numbers.Print();

service.AddInteger();

service.Numbers.Print();


// [2] Impure function: mutate the state of global variable.

service.Numbers.Print();

service.AddInteger(number: 10);

service.Numbers.Print();


// [3] Impure function: mutate the state of parameter.

service.Numbers.Print();

int number = 9;

service.AddInteger(ref number);

service.Numbers.Print();


// [4] Pure function: no side effects, same input -> same output.

var target = service.AddInteger(service.Numbers, 10);

target.Print();

service.Numbers.Print();
