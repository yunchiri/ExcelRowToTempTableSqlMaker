# 엑셀의 데이터복사후 붙여넣기하면 sql script로 변환해주는 프로그램


##예제

###데이터 소스
```
김은옥	201312

류은영	200812

송명순	201012

정창일	201312

최주연	201012
```


엑셀에서 데이터를 복사하여 붙여넣으면

```
 WITH  T
AS (
    select * from 
    (
    select '김은옥' AS C0,'201312' AS C1 from dual union all
select '류은영' AS C0,'200812' AS C1 from dual union all
select '송명순' AS C0,'201012' AS C1 from dual union all
select '정창일' AS C0,'201312' AS C1 from dual union all
select '최주연' AS C0,'201012' AS C1 from dual 
        )
    )
Select * From T
```

또는
임시테이블 
```
 CREATE  GLOBAL TEMPORARY TABLE tempTalbe_145726
   ON  COMMIT  PRESERVE ROWS
 AS (
     select * from 
      (
      select '김은옥' AS C0,'201312' AS C1 from dual union all
select '류은영' AS C0,'200812' AS C1 from dual union all
select '송명순' AS C0,'201012' AS C1 from dual union all
select '정창일' AS C0,'201312' AS C1 from dual union all
select '최주연' AS C0,'201012' AS C1 from dual 
      )
  )
        
```

형식으로 만들어줌
                    
                    