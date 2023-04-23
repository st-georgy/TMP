# Диаграмма
```
@startuml
skin rose
title Банкомат
left to right direction
actor Клиент
actor Банк

rectangle Банкомат {
Клиент --- (Снятие наличных)
Клиент --- (Проверка баланса)
Клиент --- (Пополнение карты)
(Проверка пин-кода)

(Проверка баланса) .> (Проверка пин-кода) : include
(Снятие наличных) .> (Проверка пин-кода) : include

Банк --- (Проверка работопособности)
(Проверка пин-кода) --- Банк
}
@enduml
```

![alt text](https://github.com/st-georgy/TMP/blob/master/lab0/img/1.png)

