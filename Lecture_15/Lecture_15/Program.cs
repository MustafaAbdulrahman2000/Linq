using Lecture_15.Data;
using Lecture_15.Extensions;


// Distinct and DistinctBy examples.


var participantsInMeeting1AndMeeting2 = Repository.Meeting1.Participants.Concat(Repository.Meeting2.Participants);

participantsInMeeting1AndMeeting2.Print($"Participants in meeting 1 and meeting 2");

var distinctParticipantsInMeeting1AndMeeting2 = Repository.Meeting1.Participants.Concat(Repository.Meeting2.Participants).Distinct();

distinctParticipantsInMeeting1AndMeeting2.Print($"Distinct participants in meeting 1 and meeting 2");

var distinctParticipantsInMeeting1AndMeeting2ByEmployeeNumber = participantsInMeeting1AndMeeting2.DistinctBy(p => p.EmployeeNo);

distinctParticipantsInMeeting1AndMeeting2ByEmployeeNumber.Print($"Distinct participants in meeting 1 and meeting 2 by employee number");


// Meeting 1 and 2 participants examples.


var set1 = Repository.Meeting1.Participants;

set1.Print($"================ Meeting [1] {set1.Count} participants ================");

var set2 = Repository.Meeting2.Participants;

set2.Print($"================ Meeting [2] {set2.Count} participants ================");


// Except and ExceptBy examples.


var exceptSet1FromSet2 = set1.Except(set2);

exceptSet1FromSet2.Print($"================ Participants in meeting 1 but not in meeting 2 ================");

var exceptSet1FromSet2ByEmployeeNumber = set1.ExceptBy(set2.Select(p => p.EmployeeNo), p => p.EmployeeNo);

exceptSet1FromSet2ByEmployeeNumber.Print($"================ {exceptSet1FromSet2ByEmployeeNumber.Count()} Participants in meeting 1 but not in meeting 2 by employee number ================");


// Intersect and IntersectBy examples.


var intersectSet1FromSet2 = set1.Intersect(set2);

intersectSet1FromSet2.Print($"================ Participants in meeting 1 and meeting 2 ================");

var intersectSet1FromSet2ByEmployeeNumber = set1.IntersectBy(set2.Select(p => p.EmployeeNo), p => p.EmployeeNo);

intersectSet1FromSet2ByEmployeeNumber.Print($"================ {intersectSet1FromSet2ByEmployeeNumber.Count()} Participants in meeting 1 and meeting 2 by employee number ================");


// Union and UnionBy examples.


var unionSet1FromSet2 = set1.Union(set2);

unionSet1FromSet2.Print($"================ Participants in meeting 1 or meeting 2 ================");

var unionSet1FromSet2ByEmployeeNumber = set1.UnionBy(set2, p => p.EmployeeNo);

unionSet1FromSet2ByEmployeeNumber.Print($"================ {unionSet1FromSet2ByEmployeeNumber.Count()} Participants in meeting 1 or meeting 2 by employee number ================");


Console.ReadKey();