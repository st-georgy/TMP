# Диаграмма использования покупки билета
```
@startuml

actor Покупатель
actor Кассир

usecase "Покупка билета" as UC1
usecase "Выбор места" as UC2
usecase "Ввод персональных данных" as UC3
usecase "Прием оплаты" as UC4
usecase "Оплата картой" as UC5
usecase "Оплата наличными" as UC6
usecase "Внос данных о продаже в базу" as UC7

Покупатель --> UC1
UC1 ..> UC2 : include
UC1 ..> UC3 : include
UC1 --> Кассир
Кассир --> UC4
UC4 ..> UC5 : extends
UC4 ..> UC6 : extends
Кассир --> UC7
@enduml
```

![alt text](https://github.com/st-georgy/TMP/lab2/img/1-1.png)

# Диаграмма использования возврата билета
```
@startuml

actor Покупатель
actor Кассир

usecase "Сдача билета" as UC1
usecase "Описание причины" as UC2
usecase "Возврат денежных средств" as UC3
usecase "Предоставление реквизитов карты" as UC4
usecase "Выставление билета на продажу" as UC5
usecase "Внос данных о возврате в базу" as UC6

Покупатель --> UC1
UC1 ..> UC2 : extends
UC1 --> Кассир
Кассир --> UC3
UC3 ..> UC4 : uses
Кассир --> UC5
Кассир --> UC6

@enduml
```

![alt text](https://github.com/st-georgy/TMP/lab2/img/1-2.png)

#Диаграмма классов
```
@startuml
left to right direction

class Матч {
  +date : Timestamp
  +teams : Text
  +sponsor : String
  +getGame() : Game
}

class Болельщик {
  - phoneNumber : Bigint
  - balance : Float
  - email : String
  + Pay() : Float
}

class БилетАбонемент {
  + code : Bigint
  + getActivateNum() : Int
}

class Кассир {
  - orderProcessing : Order
  + getTicket() : Boolean
}

class Касса {
  - cost : Float
  - employeeName : String
  - currentClient : String
  - orderProcessing : Order
  + getPayment() : Boolean
  + changeInfo(orderProcessing) : void
  + issueCheque(employeeName) : String
}

class Человек {
  firstName : String
  lastName : String
  + setName(firstname, lastname) : void
  + getName() : String
}

Человек --> Болельщик : extends
Человек --> Кассир : extends
Болельщик --> Кассир : Покупает билет
Кассир --> Касса : Проводит оплату
Кассир --> БилетАбонемент : Выдает
Болельщик --> Матч : Смотрит
Матч --> БилетАбонемент
@enduml
```

![alt text](https://github.com/st-georgy/TMP/lab2/img/1-3.png)