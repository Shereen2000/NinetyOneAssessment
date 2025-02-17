package com.example.demo.services;

import com.example.demo.Repositories.StudentRepository;
import com.example.demo.entities.Student;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
public class StudentService {

    private final StudentRepository studentRepository;

    @Autowired
    public StudentService(StudentRepository studentRepository) {
        this.studentRepository = studentRepository;
    }

    public Student createStudent(Student student)
    {
        return studentRepository.save(student);
    }

    public Student getById(Long id)
    {
        return studentRepository.findById(id).orElse(null);
    }
}
