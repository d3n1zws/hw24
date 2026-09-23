//using ConsoleApp24.enums;
//using ConsoleApp24.models;
//using ConsoleApp24.records;

//Abstraksiya, İnterfeyslər və Custom Exception-lar
//Xüsusi İstisnalar:
//StockUnavailableException(Anbarda kifayət qədər məhsul olmadıqda).
//OrderNotFoundException(ID - yə görə sifariş tapılmadıqda).


//IEntity(Interface): int Id { get; }
//IOrderService<T>(Generic Interface):
//Task AddOrderAsync(T order)
//Task<T> GetOrderByIdAsync(int id)
//Task ProcessOrdersConcurrentlyAsync()
//INotificationService(Dependency Injection Tətbiqi üçün):
//Task NotifyAsync(string message) (Məsələn: EmailNotificationService və ya SmsNotificationService).



//3. Modeller, Encapsulation, Operators və Indexer
//Order (Class — implements IEntity):



//4. Dependency Injection & Concurrency Engine (Core Part)
//Dependency Injection (DI):
//EmailNotificationService (implements INotificationService) sinifi yaradılır.
//OrderProcessor<T> generic sinifi (implements IOrderService<T>, where T : Order, IEntity) constructor vasitəsilə INotificationService obyektini qəbul edir (Constructor Injection).
//Concurrency, Parallel Programming & Race Condition (lock):
//OrderProcessor<T> daxilində List<T> saxlanılır.
//ProcessOrdersConcurrentlyAsync() metodu daxilində sifarişlər Parallel.ForEachAsync və ya Task.Run vasitəsilə paralel şəkildə emal olunur.
//Siyahıya eyni anda paralel yazılmalar zamanı data itkisinin (Race Condition) qarşısını almaq üçün lock obyektindən istifadə olunmalıdır. Tələbələr lock istifadə edilmədikdə elementlərin itdiyini, lock istifadə etdikdə datanın tam qaldığını göstərməlidirlər.