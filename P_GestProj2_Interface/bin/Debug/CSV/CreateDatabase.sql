#------Scripts pour injecter les données dans db_smartphone depuis les fichiers csv /!\ executer dans l'ordre !!

USE db_smartphone

#--- table processeur	
LOAD DATA INFILE 't_processeur.csv' INTO TABLE t_processeur CHARACTER SET "latin1" COLUMNS TERMINATED BY ';' ENCLOSED BY "" ESCAPED BY '\t' LINES TERMINATED BY '\r\n' IGNORE 1 LINES SET idProcesseur=NULL;

#--- table smartphone
LOAD DATA INFILE 't_smartphone.csv' INTO TABLE t_smartphone CHARACTER SET "latin1" COLUMNS TERMINATED BY ';' ENCLOSED BY "" ESCAPED BY '\t' LINES TERMINATED BY '\r\n' IGNORE 1 LINES SET idSmartphone=NULL;

#--- table valeur 
LOAD DATA INFILE 't_valeur.csv' INTO TABLE t_valeur CHARACTER SET "latin1" COLUMNS TERMINATED BY ';' ENCLOSED BY "" ESCAPED BY '\t' LINES TERMINATED BY '\r\n' IGNORE 1 LINES SET idValeur=NULL;