-- MySQL Script generated by MySQL Workbench
-- Tue May 10 12:51:54 2022
-- Model: New Model    Version: 1.0
-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema university
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema university
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `university` DEFAULT CHARACTER SET utf8 ;
USE `university` ;

-- -----------------------------------------------------
-- Table `university`.`subject`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `university`.`subject` (
  `subj_id` INT NOT NULL AUTO_INCREMENT,
  `subj_name` NVARCHAR(50) NULL,
  `hour` INT NULL,
  `semestr` INT NULL,
  PRIMARY KEY (`subj_id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `university`.`university`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `university`.`university` (
  `univ_id` INT NOT NULL AUTO_INCREMENT,
  `univ_name` NVARCHAR(50) NULL,
  `raiting` INT NULL,
  `city` NVARCHAR(50) NULL,
  PRIMARY KEY (`univ_id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `university`.`student`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `university`.`student` (
  `student_id` INT NOT NULL AUTO_INCREMENT,
  `surname` NVARCHAR(50) NULL,
  `name` NVARCHAR(50) NULL,
  `stipend` FLOAT NULL,
  `kurs` INT NULL,
  `city` NVARCHAR(50) NULL,
  `birthday` DATETIME NULL,
  `univ_id` INT NOT NULL,
  PRIMARY KEY (`student_id`),
  INDEX `fk_student_university1_idx` (`univ_id` ASC) VISIBLE,
  CONSTRAINT `fk_student_university1`
    FOREIGN KEY (`univ_id`)
    REFERENCES `university`.`university` (`univ_id`)
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `university`.`exam_marks`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `university`.`exam_marks` (
  `exam_id` INT NOT NULL AUTO_INCREMENT,
  `mark` INT NULL,
  `exam_date` DATETIME NULL,
  `subj_id` INT NOT NULL,
  `student_id` INT NOT NULL,
  PRIMARY KEY (`exam_id`),
  INDEX `fk_exam_marks_subject_idx` (`subj_id` ASC) VISIBLE,
  INDEX `fk_exam_marks_student1_idx` (`student_id` ASC) VISIBLE,
  CONSTRAINT `fk_exam_marks_subject`
    FOREIGN KEY (`subj_id`)
    REFERENCES `university`.`subject` (`subj_id`)
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT `fk_exam_marks_student1`
    FOREIGN KEY (`student_id`)
    REFERENCES `university`.`student` (`student_id`)
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `university`.`lectures`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `university`.`lectures` (
  `lecturer_id` INT NOT NULL AUTO_INCREMENT,
  `surname` NVARCHAR(50) NULL,
  `name` NVARCHAR(50) NULL,
  `city` NVARCHAR(50) NULL,
  `univ_id` INT NOT NULL,
  PRIMARY KEY (`lecturer_id`),
  INDEX `fk_lectures_university1_idx` (`univ_id` ASC) VISIBLE,
  CONSTRAINT `fk_lectures_university1`
    FOREIGN KEY (`univ_id`)
    REFERENCES `university`.`university` (`univ_id`)
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;