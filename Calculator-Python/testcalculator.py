import unittest
import calculator
import sys
import io

class MyTestCase(unittest.TestCase):
    def test_input_valid(self):
        self.assertTrue(calculator.is_valid_input("2","+","3"))
    
    def test_firstnum_invalid(self):
        suppress_text = io.StringIO()
        sys.stdout = suppress_text
        self.assertFalse(calculator.is_valid_input("w","/","7"))
        sys.stdout =sys.__stdout__

    def test_op_invalid(self):
        suppress_text = io.StringIO()
        sys.stdout = suppress_text
        self.assertFalse(calculator.is_valid_input("3","=","6"))
        sys.stdout =sys.__stdout__

    def test_second_invalid(self):
        suppress_text = io.StringIO()
        sys.stdout = suppress_text
        self.assertFalse(calculator.is_valid_input("2","*","y"))
        sys.stdout =sys.__stdout__

    def test_firstnum_empty(self):
        suppress_text = io.StringIO()
        sys.stdout = suppress_text
        self.assertFalse(calculator.is_valid_input("","-","8"))
        sys.stdout =sys.__stdout__
    
    def test_op_empty(self):
        suppress_text = io.StringIO()
        sys.stdout = suppress_text
        self.assertFalse(calculator.is_valid_input("9","","6"))
        sys.stdout =sys.__stdout__

    def test_sec_empty(self):
        suppress_text = io.StringIO()
        sys.stdout = suppress_text
        self.assertFalse(calculator.is_valid_input("78","/",""))
        sys.stdout =sys.__stdout__

    def test_div_zero(self):
        suppress_text = io.StringIO()
        sys.stdout = suppress_text
        self.assertFalse(calculator.is_valid_input("34","/","0"))
        sys.stdout =sys.__stdout__

    def test_addition(self):
        result = calculator.calc_result("3","+","8")
        self.assertEqual(11, result)

    def test_subtraction(self):
        result = calculator.calc_result("4","-","2")
        self.assertEqual(2, result)
    
    def test_multiplication(self):
        result = calculator.calc_result("3","*","6")
        self.assertEqual(18, result)

    def test_division(self):
        result = calculator.calc_result("27","/","3")
        self.assertEqual(9, result)

    def test_division_decimal(self):
        result = calculator.calc_result("9","/","4")
        self.assertEqual(2.2,result)


    


if __name__=="__main__":
    unittest.main()