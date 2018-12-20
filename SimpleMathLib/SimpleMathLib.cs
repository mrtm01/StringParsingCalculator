using System;

namespace SimpleMathLib
{
    public class SimpleMathLib
    {
        private bool _useRadians = false;
        public void SetUseRadians(bool useRadians)
        {
            _useRadians = useRadians;
        }
        public bool GetUseRadians()
        {
            return _useRadians;
        }

        public double sqrt(double num)
        {
            return Math.Sqrt(num);
        }
        public double pow(double b, double exp)
        {
            return Math.Pow(b,exp);
        }
        public double sin(double angle)
        {
            if (_useRadians) return Math.Sin(angle);
            else return Math.Sin(DegreesToRadians(angle) );
        }
        public double cos(double angle)
        {
            if (_useRadians) return Math.Cos(angle);
            else return Math.Cos(DegreesToRadians(angle) );
        }
        public double tan(double angle)
        {
            if (_useRadians) return Math.Tan(angle);
            else return Math.Tan(DegreesToRadians(angle) );
        }

        public double asin(double value)
        {
            if (_useRadians) return Math.Asin(value);
            else return RadiansToDegrees(Math.Asin(value));
        }
        public double acos(double value)
        {
            if (_useRadians) return Math.Acos(value);
            else return RadiansToDegrees(Math.Acos(value));
        }
        public double atan(double value)
        {
            if (_useRadians) return Math.Atan(value);
            else return RadiansToDegrees(Math.Atan(value));
        }

        public double DegreesToRadians(double degrees)
        {
            return degrees * Math.PI / 180;
        }
        public double RadiansToDegrees(double radians)
        {
            return radians * 180 / Math.PI;
        }
    }

}
