using Microsoft.VisualBasic;
using System.Linq.Expressions;


// Differences between delegate and expression trees.


Func<int, bool> isEven = (number) => number % 2 == 0;

Console.WriteLine(isEven(10));

Console.WriteLine(isEven.Invoke(10));

Expression<Func<int, bool>> isEvenExpression = (number) => number % 2 == 0;

Func<int, bool> isEvenFromExpression = isEvenExpression.Compile();

Console.WriteLine(isEvenFromExpression(10));


// Parsing expression trees.


Expression<Func<int, bool>> isNegativeExpression = (number) => number < 0;

ParameterExpression numberParameter = isNegativeExpression.Parameters[0];

BinaryExpression body = isNegativeExpression.Body as BinaryExpression;

ParameterExpression left = body.Left as ParameterExpression;

ConstantExpression right = body.Right as ConstantExpression;

Console.WriteLine($"Parsed Expression: {numberParameter} => {left!.Name} {body.NodeType} {right!.Value}");


// Generate expression tree from scratsh.


ParameterExpression numberParameter2 = Expression.Parameter(typeof(int), "number");

ConstantExpression twoParameter = Expression.Constant(2, typeof(int));

ConstantExpression zeroParameter = Expression.Constant(0, typeof(int));

BinaryExpression moduloBinaryExpression = Expression.Modulo(numberParameter2, twoParameter);

BinaryExpression isEvenBinaryExpression = Expression.Equal(moduloBinaryExpression, zeroParameter);

Expression<Func<int, bool>> isEvenExpression2 = Expression.Lambda<Func<int, bool>>(isEvenBinaryExpression, new ParameterExpression[] { numberParameter2 });

var isEven2 = isEvenExpression2.Compile();

Console.WriteLine(isEven2(10));

Console.WriteLine(isEven2(9));


Console.ReadKey();