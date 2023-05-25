# DataModel

* [Номенклатура](./Ojb__NmcCategory.md)
```mermaid
erDiagram
  Nmc {    
    String Title "Наименование"    
    String Name "Название"    
    UnitOfMeasure MeasureUnit "Единица измерения"
    EActualilty Actuality "Актуальнось"
    String Remarks "Примечания"
    
    Nmc Parent "Родительский объект"
    Boolean IsGroup "Является группой"
    
    GUID GlobalID "Глобальный ID"
    User CreationUser "Автор создания"
    DateTime CreationDate "Дата создания"
    User ModificationUser "Автор изменения"
    DateTime ModificationData "Дата модификации"
    
    
    InfoOfValidation ValidationInfo "Валидация"
    
    
    InfoOfDuplicate DuplicateInfo "Информация о дубликате"
  }
```

```mermaid
erDiagram
  EValidationResult {
    Int32_00 ValidationNotPerform "Валидация не проводилась"
    Int32_05 ValidationNotActual "Валидация не актуальна"
    Int32_10 Invalid "Не валидно"
    Int32_20 ValidWithSubjections "Валидно c замечаниями"
    Int32_30 Valid "Валидно"
  }
```



```mermaid
erDiagram
  InfoOfValidation {
    EValidationResult ValidationResult "Результат валидации"
    DateTime TimeStamp "Время заключения"
    User Validator "Автор валидации"
    Boolean IsDataCorrect "Содержит корректные данные"
    
    String ValidationRemarks "Примечания"
    String DataObjections "Замечания по данным"
    
    String Remarks "Примечания"
  }
```

```mermaid
erDiagram
  InfoOfDuplicate {
    DateTime TimeStamp "Время заключения"
    Int32 DuplicateNumber "Номер дубликата"
    Nmc DuplicateOf
    String Remarks "Примечания"
  }
```

* [Срок актуальности заключения СЕБ](./Ojb__SEBConclusionActualityTime.md)

```mermaid
erDiagram
  SEBConclusionActualityTime {
    String Title "Наименование"
    String Name "Название"
    EActualilty Actuality "Актуальнось"
    String Remarks "Примечания"
    TimeSpan ActualityTime_Days "Время актуальности, дней"    
  }
```
