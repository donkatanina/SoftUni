ALTER TABLE Users
DROP CONSTRAINT PK__Users__3214EC275BAF8F8D

ALTER TABLE Users
ADD CONSTRAINT PK_IdUsername PRIMARY KEY (ID,[Username])

