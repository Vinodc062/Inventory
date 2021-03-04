CREATE TABLE User_Master
(
um_User_Id		INT PRIMARY KEY IDENTITY(1000,1),	
um_User_Name	VARCHAR(255),
um_First_Name	VARCHAR(255),
um_Last_Name	VARCHAR(255),
um_Status		BIT,
um_CreatedTime	DATETIME,
um_CreatedeBy	INT,
um_ModifiedTime	DATETIME,
um_ModifiedBy	INT
)
go	
ALTER PROCEDURE proc_User_Master
(
@um_User_Id		INT,
@um_User_Name	VARCHAR(255),
@um_First_Name	VARCHAR(255),
@um_Last_Name	VARCHAR(255),
@um_Status		BIT,
@um_User	INT
)
AS
BEGIN
	IF EXISTS(SELECT um_user_name 
				FROM User_Master 
				WHERE um_User_Id = @um_User_Id)
	BEGIN
		UPDATE User_Master
		SET um_User_Name	= @um_User_Name,
			um_First_Name	= @um_First_Name,
			um_Last_Name	= @um_Last_Name,
			um_Status		= @um_Status,
			um_ModifiedBy	= @um_User
		WHERE um_User_Id = @um_User_Id
	END
	ELSE
	BEGIN
		INSERT INTO User_Master(um_User_Name, um_First_Name, um_Last_Name, um_Status, um_CreatedTime, um_CreatedeBy, um_ModifiedTime, um_ModifiedBy)
		VALUES (@um_User_Name, @um_First_Name, @um_Last_Name, @um_Status, GETDATE(), @um_User, GETDATE(), @um_User)
	END
END