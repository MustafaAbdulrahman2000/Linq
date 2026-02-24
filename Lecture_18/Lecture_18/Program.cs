using Lecture_18.Data;
using Lecture_18.Extensions;


// Data 

var enumerableShippings = Repository.AllAsList;

var shippingList = Repository.AllAsShippingList;


// AsEnumerable example

AsEnumerableExtensions.RunAsEnumerable(shippingList);

// AsQueryable example;

AsQueryableExtensions.RunAsQueryable(shippingList);

// ToList example

ToListExtensions.RunToList(enumerableShippings);

// ToArray example

ToArrayExtensions.RunToArray(enumerableShippings);

// ToDictionary example

ToDictionaryExtensions.RunToDictionary(enumerableShippings);

// ToLookup example

ToLookupExtensions.RunToLookup(enumerableShippings);

// Cast example

CastExtensions.RunCast(enumerableShippings);

// OfType example

OfTypeExtensions.RunOftype(enumerableShippings);

Console.ReadKey();