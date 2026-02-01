using Lecture_02.Services;
                                                                               
// [1] Procedural queries.                                                     
                                                                               
IQueryService service = new ProceduralQueryService();                        
                                                                             
service.Query();                                                             
                                                                               
                                                                               
// [2] Functional queries.                                                     
                                                                               
IQueryService functionalService = new FunctionalQueryService();              
                                                                             
functionalService.Query();                                                   
                                                                               
                                                                               
// [3] Full version functional queries.                                        

IQueryService fullVersionFunctionalQueryService = new FullVersionFunctionalQueryService();

fullVersionFunctionalQueryService.Query();