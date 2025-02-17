package com.example.demo.controllers;

import com.example.demo.Repositories.StudentRepository;
import com.example.demo.entities.Student;
import com.example.demo.services.StudentService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

@RestController
@RequestMapping(path = "api/student")
public class StudentController {

    private final StudentService studentService;

    @Autowired
    public StudentController(StudentService studentService) {
        this.studentService = studentService;
    }

    @PostMapping
    public Student createStudent(@RequestBody Student student) {
        return studentService.createStudent(student);
    }

    //student should be get by id as name and surname might retrieve students with the same name
    // and surname
    @GetMapping(path = "/{id}")
    public Student getStudentById(@PathVariable("id") Long id) {
        return  studentService.getById(id);
    }



}
