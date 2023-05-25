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
    
    DateTime CreationDate "Дата создания"
    DateTime ModificationData "Дата модификации"
    
    ValidationInfo Validation "Результат валидации"
  }
```

```mermaid
erDiagram
  ValidationInfo {
    DateTime TimeStamp "Время заключения"
    Boolean IsCorrectData "Содержит корректные данные"
    String DataObjections ""
    Boolean IsDuplicate "Является ли дубликатом"
    Duplicate DuplicateInfo "Информация о дубликате"
    Boolean IsValie ""
    String Remarks "Примечания"
    
  }
```

```mermaid
erDiagram
  EValidation {
    Int32_00 Valid "Валидировано"
    Int32_10 WithObjections "С возражениями"
    Int32_20 Invalid "Не валидно"
  }
```

```mermaid
erDiagram
  Duplicate {
    Int32 DuplicateNumber "Номер дубликата"
    Nmc DuplicateOf
    
    DateTime TimeStamp "Время заключения"
    EValidation ValidationResult "Результат валидации"    
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
