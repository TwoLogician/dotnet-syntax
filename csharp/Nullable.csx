int? a = null;

Console.WriteLine(Nullable.GetUnderlyingType(typeof(int?)));

var array = new int[] { 1, 2, 3 };

var rs5 = array == null ? null : (int?)array.Length;

int? MyFunc(int[] array) {
    if (array == null) return null;
    else return array.Length;
}

// int? value = array == null ? null : array.Length;

int? rs2 = array != null ? new int?(array.Length) : null;

int? rs3 = array == null ? default : array.Length;

Console.WriteLine(rs5);
