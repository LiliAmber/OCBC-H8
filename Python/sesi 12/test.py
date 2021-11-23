import unittest
from my_sum import sum
from fractions import Fraction
import app

class TestSum(unittest.TestCase):
    def test_list_int(self):
        '''
        test that ut can suma a lisy of integers
        '''
        data = [1,2,3]
        result = sum(data)
        self.assertEqual(result, 6)

    def test_list_fraction(self):
        """
        Test that it can sum a list of fractions
        """
        data = [Fraction(1, 2), Fraction(1, 2)]
        result = sum(data)
        self.assertEqual(result, 1)

class MyTestCase(unittest.TestCase):
    def setUp(self):
        app.app.testing = True
        self.app = app.app.test_client()

    def test_home(self):
        result = self.app.get('/')
        # Make your assertions

if __name__ == '__main__':
    unittest.main()