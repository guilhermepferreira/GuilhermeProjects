CREATE TABLE `persons` (
  `id` bigint NOT NULL AUTO_INCREMENT,
  `first_name` varchar(255) NOT NULL,
  `last_name` varchar(255) NOT NULL,
  `address` varchar(255) NOT NULL,
  `gender` varchar(6) NOT NULL,
  PRIMARY KEY (`id`)
)