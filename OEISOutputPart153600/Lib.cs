using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A196705
{
public static readonly BigInteger[] Value={ 22L,1744L,55436L,2264381L,88057485L,3444722540L,134682461126L,5269250186071L,206166859931473L,8065792226445503L,315546555294232838L,12344751415733916603UL,BigInteger.Parse("482952689817901349673"),BigInteger.Parse("18894135165739360648424") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196705Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196705.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196705.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196705Inst Instance=new A196705Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196706
{
public static readonly BigInteger[] Value={ 40L,6208L,353591L,26495227L,1883754015L,134682461126L,9630587515529L,688873132970642L,49276676966789269L,3524626082557601875L,BigInteger.Parse("252104533342881651241"),BigInteger.Parse("18032369299020473778391"),BigInteger.Parse("1289809476341608457763412") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196706Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196706.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196706.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196706Inst Instance=new A196706Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196707
{
public static readonly long[] Value={ 1L,2L,2L,4L,11L,4L,6L,38L,38L,6L,12L,136L,207L,136L,12L,22L,488L,1366L,1366L,488L,22L,40L,1744L,8672L,16676L,8672L,1744L,40L,74L,6208L,55436L,193326L,193326L,55436L,6208L,74L,136L,22202L,353591L,2264381L,4114365L,2264381L,353591L,22202L,136L,250L,79292L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196707Inst : IEnumerable<long>
{
public static readonly long[] Value=A196707.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196707.Bytes);
public long this[int i]=>Value[i];

public static A196707Inst Instance=new A196707Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196708
{
public static readonly BigInteger[] Value={ 1L,1L,3L,12L,58L,323L,2026L,14125L,108472L,911203L,8326290L,82382317L,879231033L,10088749986L,124101412790L,1632187723201L,22895274500999L,341738132438907L,5415659970194984L,90928786402251744L,1614244644876588572L,BigInteger.Parse("30243386104969900766"),BigInteger.Parse("596915061724923842269") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196708Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196708.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196708Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196708.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196708.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196708Inst Instance=new A196708Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196709
{
public static readonly long[] Value={ 1L,1L,2L,7L,26L,110L,490L,2289L,11032L,54566L,275290L,1411846L,7339180L,38588752L,204877804L,1096919969L,5916055860L,32113211082L,175311638256L,961935749512L,5302286426878L,29347327341840L,163040493728376L,908865025329612L,5082227505135978L,28500261134798892L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196709Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196709.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196709Inst : IEnumerable<long>
{
public static readonly long[] Value=A196709.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196709.Bytes);
public long this[int i]=>Value[i];

public static A196709Inst Instance=new A196709Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196710
{
public static readonly BigInteger[] Value={ 1L,1L,3L,12L,59L,340L,2240L,16583L,136185L,1229220L,12119025L,129957670L,1510458859L,18958901987L,255980593558L,3703327622812L,57208927916093L,941005426734340L,16442518936115083L,304566619900207724L,5967901050385272977L,BigInteger.Parse("123436972340208737237"),BigInteger.Parse("2689201938559338920299") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196710Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196710.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196710.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196710Inst Instance=new A196710Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196711
{
public static readonly BigInteger[] Value={ 1L,1L,3L,12L,59L,341L,2274L,17380L,152492L,1546370L,18253752L,251911212L,4077747676L,77875414462L,1766771227627L,47719589665506L,1529956518699126L,58172058892474403L,2633354766431360249L,BigInteger.Parse("142248925696032886182"),BigInteger.Parse("9135446223074433352932"),BigInteger.Parse("695222497681195469397031") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196711Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196711.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196711Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196711.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196711.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196711Inst Instance=new A196711Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196712
{
public static readonly long[] Value={ 1L,6L,40L,1142L,56137L,9202067L,3464871506L,3526366342860L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196712Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196712.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196712Inst : IEnumerable<long>
{
public static readonly long[] Value=A196712.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196712.Bytes);
public long this[int i]=>Value[i];

public static A196712Inst Instance=new A196712Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196713
{
public static readonly long[] Value={ 4L,14L,40L,171L,543L,1984L,7368L,25698L,91687L,332017L,1186007L,4235449L,15208172L,54482712L,194977275L,698710198L,2503440997L,8965814332L,32118124605L,115063138815L,412164687036L,1476447370087L,5289072335399L,18946554005675L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196713Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196713.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196713Inst : IEnumerable<long>
{
public static readonly long[] Value=A196713.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196713.Bytes);
public long this[int i]=>Value[i];

public static A196713Inst Instance=new A196713Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196714
{
public static readonly long[] Value={ 5L,36L,171L,1142L,6078L,36590L,222112L,1307674L,7735880L,45646026L,269504078L,1595690953L,9445961529L,55865469801L,330371020703L,1953941440845L,11557262522313L,68362216702686L,404360196543732L,2391711672587354L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196714Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196714.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196714Inst : IEnumerable<long>
{
public static readonly long[] Value=A196714.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196714.Bytes);
public long this[int i]=>Value[i];

public static A196714Inst Instance=new A196714Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196715
{
public static readonly long[] Value={ 8L,83L,543L,6078L,56137L,573131L,5443550L,50508808L,481054949L,4618260844L,44096133059L,419989162410L,4001092015315L,38160566402453L,364041145786794L,3471329248464444L,33096140079277931L,315588530171400369L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196715Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196715.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196715Inst : IEnumerable<long>
{
public static readonly long[] Value=A196715.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196715.Bytes);
public long this[int i]=>Value[i];

public static A196715Inst Instance=new A196715Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196716
{
public static readonly long[] Value={ 12L,192L,1984L,36590L,573131L,9202067L,139260414L,2140451320L,33452130666L,518611497139L,8011630549571L,124177751877894L,1925826968293386L,29837828260022815L,462236367480831086L,7162862918976810615L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196716Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196716.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196716Inst : IEnumerable<long>
{
public static readonly long[] Value=A196716.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196716.Bytes);
public long this[int i]=>Value[i];

public static A196716Inst Instance=new A196716Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196717
{
public static readonly BigInteger[] Value={ 17L,468L,7368L,222112L,5443550L,139260414L,3464871506L,87347779774L,2189117562853L,54554907624355L,1364716687922414L,34203898910729035L,856342981705944451L,BigInteger.Parse("21436725243287303475"),BigInteger.Parse("536742033291537818929") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196717Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196717.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196717Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196717.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196717.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196717Inst Instance=new A196717Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196718
{
public static readonly long[] Value={ 1L,3L,3L,4L,6L,4L,5L,14L,14L,5L,8L,36L,40L,36L,8L,12L,83L,171L,171L,83L,12L,17L,192L,543L,1142L,543L,192L,17L,25L,468L,1984L,6078L,6078L,1984L,468L,25L,37L,1112L,7368L,36590L,56137L,36590L,7368L,1112L,37L,54L,2624L,25698L,222112L,573131L,573131L,222112L,25698L,2624L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196718Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196718.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196718Inst : IEnumerable<long>
{
public static readonly long[] Value=A196718.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196718.Bytes);
public long this[int i]=>Value[i];

public static A196718Inst Instance=new A196718Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196719
{
public static readonly long[] Value={ 1L,2L,4L,7L,11L,16L,24L,31L,40L,52L,68L,79L,102L,115L,140L,175L,201L,218L,265L,284L,336L,396L,446L,469L,547L,599L,662L,742L,837L,866L,1034L,1065L,1153L,1275L,1370L,1511L,1719L,1756L,1869L,2030L,2244L,2285L,2613L,2656L,2865L,3236L,3394L,3441L,3780L,3921L,4232L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196719Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196719.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196719Inst : IEnumerable<long>
{
public static readonly long[] Value=A196719.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196719.Bytes);
public long this[int i]=>Value[i];

public static A196719Inst Instance=new A196719Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196720
{
public static readonly long[] Value={ 1L,2L,4L,8L,13L,25L,33L,61L,81L,116L,140L,256L,282L,530L,606L,692L,823L,1551L,1653L,3173L,3391L,3805L,4177L,8049L,8345L,11524L,12508L,15294L,16204L,31692L,32048L,63280L,70834L,77224L,82048L,91686L,93597L,185245L,196109L,212359L,218223L,432495L,436031L,867647L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196720Inst : IEnumerable<long>
{
public static readonly long[] Value=A196720.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196720.Bytes);
public long this[int i]=>Value[i];

public static A196720Inst Instance=new A196720Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196721
{
public static readonly long[] Value={ 1L,2L,4L,8L,14L,28L,42L,84L,132L,236L,352L,704L,920L,1840L,2736L,3816L,5700L,11400L,15384L,30768L,39552L,54656L,81672L,163344L,196176L,362656L,542304L,930352L,1195168L,2390336L,2914304L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196721Inst : IEnumerable<long>
{
public static readonly long[] Value=A196721.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196721.Bytes);
public long this[int i]=>Value[i];

public static A196721Inst Instance=new A196721Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196722
{
public static readonly long[] Value={ 1L,2L,4L,7L,11L,16L,23L,30L,38L,47L,58L,69L,83L,96L,111L,128L,144L,161L,181L,200L,223L,246L,269L,292L,319L,344L,371L,398L,429L,458L,496L,527L,559L,594L,629L,668L,708L,745L,784L,825L,870L,911L,962L,1005L,1052L,1102L,1149L,1196L,1248L,1297L,1349L,1402L,1457L,1510L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196722Inst : IEnumerable<long>
{
public static readonly long[] Value=A196722.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196722.Bytes);
public long this[int i]=>Value[i];

public static A196722Inst Instance=new A196722Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196723
{
public static readonly long[] Value={ 1L,2L,4L,8L,15L,28L,50L,86L,143L,236L,376L,594L,913L,1380L,2048L,3016L,4367L,6302L,8974L,12670L,17685L,24580L,33738L,46072L,62367L,83990L,112342L,149734L,198153L,261562L,343210L,448694L,583445L,756846L,976086L,1255658L,1607831L,2053186L,2610560L,3312040L,4183689L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196723Inst : IEnumerable<long>
{
public static readonly long[] Value=A196723.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196723.Bytes);
public long this[int i]=>Value[i];

public static A196723Inst Instance=new A196723Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196724
{
public static readonly long[] Value={ 1L,2L,4L,8L,16L,32L,58L,116L,212L,416L,720L,1440L,2340L,4680L,7920L,13024L,23328L,46656L,74168L,148336L,229856L,371424L,615304L,1230608L,1780224L,3401568L,5589360L,9468504L,14397744L,28795488L,40312128L,80624256L,131388480L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196724Inst : IEnumerable<long>
{
public static readonly long[] Value=A196724.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196724.Bytes);
public long this[int i]=>Value[i];

public static A196724Inst Instance=new A196724Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196725
{
public static readonly BigInteger[] Value={ 1L,5L,76L,3394L,547874L,280203939L,466328648058L,2525576718158704L,BigInteger.Parse("44298467976731953802"),BigInteger.Parse("2511317101071327391390891") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196725Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196725.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196725.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196725Inst Instance=new A196725Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196726
{
public static readonly ulong[] Value={ 6L,101L,2025L,30971L,547874L,9376754L,155884161L,2642927522L,44901935948L,759934568782L,12869664286125L,217998199717188L,3691905169363581L,62529315118785567L,1059069284509026344L,17937180980623591659UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196726Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196726.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196726Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A196726.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196726.Bytes);
public ulong this[int i]=>Value[i];

public static A196726Inst Instance=new A196726Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196727
{
public static readonly BigInteger[] Value={ 9L,299L,10548L,299031L,9376754L,280203939L,8480784814L,260413708520L,7925738767972L,240995847511411L,7341178616840827L,223581927300557652L,6808249999744006848L,BigInteger.Parse("207322812709656178441"),BigInteger.Parse("6313316805630919549681") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196727Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196727.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196727Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196727.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196727.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196727Inst Instance=new A196727Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196728
{
public static readonly BigInteger[] Value={ 13L,890L,55431L,2810070L,155884161L,8480784814L,466328648058L,25627044432018L,1401061856163452L,76824706430678661L,4214277934317634634L,BigInteger.Parse("230987804774562016288"),BigInteger.Parse("12662004308972053192420"),BigInteger.Parse("694169878513382740535063") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196728Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196728.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196728Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196728.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196728.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196728Inst Instance=new A196728Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196729
{
public static readonly long[] Value={ 1L,2L,2L,3L,5L,3L,4L,11L,11L,4L,6L,34L,76L,34L,6L,9L,101L,408L,408L,101L,9L,13L,299L,2025L,3394L,2025L,299L,13L,19L,890L,10548L,30971L,30971L,10548L,890L,19L,28L,2643L,55431L,299031L,547874L,299031L,55431L,2643L,28L,41L,7855L,289038L,2810070L,9376754L,9376754L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196729Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196729.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196729Inst : IEnumerable<long>
{
public static readonly long[] Value=A196729.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196729.Bytes);
public long this[int i]=>Value[i];

public static A196729Inst Instance=new A196729Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196730
{
public static readonly long[] Value={ 1L,2L,4L,8L,9L,10L,16L,26L,32L,34L,58L,64L,74L,81L,82L,84L,106L,122L,128L,146L,178L,194L,196L,202L,218L,226L,250L,256L,274L,298L,314L,346L,361L,362L,386L,394L,441L,458L,466L,480L,482L,512L,514L,538L,554L,562L,586L,626L,634L,674L,676L,698L,706L,722L,729L,746L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196730Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196730.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196730Inst : IEnumerable<long>
{
public static readonly long[] Value=A196730.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196730.Bytes);
public long this[int i]=>Value[i];

public static A196730Inst Instance=new A196730Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196731
{
public static readonly long[] Value={ 1L,11L,132L,1584L,19008L,228096L,2737152L,32845824L,394149888L,4729798656L,56757583872L,681091006464L,8173092077568L,98077104930816L,1176925259169792L,14123103110037504L,169477237320450048L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196731Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196731.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196731Inst : IEnumerable<long>
{
public static readonly long[] Value=A196731.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196731.Bytes);
public long this[int i]=>Value[i];

public static A196731Inst Instance=new A196731Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196732
{
public static readonly long[] Value={ 2L,17L,16L,37L,49L,73L,97L,75L,56L,855L,710L,1081L,1077L,1637L,1658L,1652L,890L,1675L,1228L,2040L,1487L,2373L,2691L,2289L,2034L,2283L,1786L,2704L,4156L,3103L,3522L,3768L,4326L,3809L,3552L,4082L,3786L,3230L,4465L,4885L,4128L,4229L,5337L,3962L,4243L,3634L,4572L,3869L,4357L,5836L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196732Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196732.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196732Inst : IEnumerable<long>
{
public static readonly long[] Value=A196732.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196732.Bytes);
public long this[int i]=>Value[i];

public static A196732Inst Instance=new A196732Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196733
{
public static readonly long[] Value={ 555383L,1767407L,2103107L,7400567L,12836987L,14668163L,15404867L,16238303L,19572647L,25003799L,26978663L,27370727L,35182919L,36180527L,38553023L,39714083L,52503587L,53061143L,53735699L,55072427L,63302159L,70728839L,77199743L,77401679L,86334299L,97298759L,97375319L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196733Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196733.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196733Inst : IEnumerable<long>
{
public static readonly long[] Value=A196733.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196733.Bytes);
public long this[int i]=>Value[i];

public static A196733Inst Instance=new A196733Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196734
{
public static readonly BigInteger[] Value={ 1L,1L,3L,22L,377L,15236L,1458577L,326046946L,166826961233L,192154584592072L,491898410990385281L,BigInteger.Parse("2770349200953966300494"),BigInteger.Parse("34041983929934523771795481"),BigInteger.Parse("906333341309409985333411618492"),BigInteger.Parse("51972772881917637838407651811301201"),BigInteger.Parse("6386414140694907598544170345261596881026") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196734Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196734.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196734Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196734.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196734.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196734Inst Instance=new A196734Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196735
{
public static readonly BigInteger[] Value={ 1L,1L,3L,28L,941L,121696L,58279927L,98693039488L,574767759680921L,11307939591431088640UL,BigInteger.Parse("741800547536454112053131"),BigInteger.Parse("160601295262890881800391317504"),BigInteger.Parse("113798222852671185437521059198500869"),BigInteger.Parse("262065699673092152689287590716544261804032") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196735Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196735.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196735Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196735.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196735.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196735Inst Instance=new A196735Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196736
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,8L,9L,11L,12L,13L,15L,16L,17L,19L,23L,25L,27L,29L,31L,32L,33L,35L,37L,41L,43L,45L,47L,49L,51L,53L,59L,61L,63L,64L,65L,67L,71L,73L,75L,77L,79L,81L,83L,87L,89L,91L,95L,97L,99L,101L,103L,107L,109L,113L,119L,121L,123L,125L,127L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196736Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196736.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196736Inst : IEnumerable<long>
{
public static readonly long[] Value=A196736.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196736.Bytes);
public long this[int i]=>Value[i];

public static A196736Inst Instance=new A196736Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196737
{
public static readonly long[] Value={ 6L,6L,7L,3L,0L,7L,0L,5L,2L,1L,6L,5L,4L,3L,7L,1L,2L,7L,2L,3L,9L,6L,0L,1L,6L,3L,9L,1L,3L,8L,8L,4L,1L,9L,9L,2L,4L,3L,7L,1L,6L,6L,8L,3L,0L,0L,6L,9L,1L,8L,5L,7L,2L,6L,4L,5L,7L,9L,2L,5L,6L,5L,1L,6L,5L,9L,0L,5L,4L,1L,2L,9L,2L,0L,2L,2L,8L,0L,2L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196737Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196737.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196737Inst : IEnumerable<long>
{
public static readonly long[] Value=A196737.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196737.Bytes);
public long this[int i]=>Value[i];

public static A196737Inst Instance=new A196737Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196738
{
public static readonly long[] Value={ 1L,0L,-254L,-6555L,-65512L,-390505L,-1678896L,-5759761L,-16736896L,-42683841L,-96371200L,-174442081L,49019904L,5411290079L,85702502144L,1305111477375L,20918494920704L,355680452338559L,6402362685767424L,121645083425268959L,2432901982576640000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196738Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196738.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196738Inst : IEnumerable<long>
{
public static readonly long[] Value=A196738.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196738.Bytes);
public long this[int i]=>Value[i];

public static A196738Inst Instance=new A196738Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196739
{
public static readonly long[] Value={ 1L,0L,-1022L,-59043L,-1048552L,-9765505L,-60465456L,-282470209L,-1073701504L,-3486421521L,-9996371200L,-25897507801L,-61438362624L,-131631471049L,-202076363776L,731023977375L,19823278260224L,353671434195551L,6398803238501376L,121638969342574199L,2432891768176640000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196739Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196739.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196739Inst : IEnumerable<long>
{
public static readonly long[] Value=A196739.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196739.Bytes);
public long this[int i]=>Value[i];

public static A196739Inst Instance=new A196739Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196740
{
public static readonly BigInteger[] Value={ 1L,1L,20L,401L,35202L,7942712L,5423213789L,10714890351493L,61977591097741664L,BigInteger.Parse("1045534716234234877628"),BigInteger.Parse("51543884247862488090471612") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196740Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196740.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196740.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196740Inst Instance=new A196740Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196741
{
public static readonly long[] Value={ 1L,3L,20L,71L,282L,1144L,4559L,18153L,72678L,290202L,1158957L,4630454L,18496588L,73884837L,295148260L,1179007713L,4709690448L,18813523020L,75153147188L,300209266280L,1199226506236L,4790471735629L,19136183610441L,76442062534904L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196741Inst : IEnumerable<long>
{
public static readonly long[] Value=A196741.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196741.Bytes);
public long this[int i]=>Value[i];

public static A196741Inst Instance=new A196741Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196742
{
public static readonly long[] Value={ 1L,7L,71L,401L,2923L,19567L,134507L,919377L,6283897L,42987489L,293903925L,2009922151L,13744157339L,93985887721L,642701573055L,4394944856905L,30053778082923L,205515234410701L,1405365233289259L,9610242269541951L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196742Inst : IEnumerable<long>
{
public static readonly long[] Value=A196742.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196742.Bytes);
public long this[int i]=>Value[i];

public static A196742Inst Instance=new A196742Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196743
{
public static readonly long[] Value={ 1L,17L,282L,2923L,35202L,400368L,4717086L,54734117L,637202902L,7415237912L,86331859442L,1004805781910L,11695057039086L,136127743720180L,1584471104135721L,18442469973189797L,214661809896066563L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196743Inst : IEnumerable<long>
{
public static readonly long[] Value=A196743.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196743.Bytes);
public long this[int i]=>Value[i];

public static A196743Inst Instance=new A196743Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196744
{
public static readonly BigInteger[] Value={ 1L,41L,1144L,19567L,400368L,7942712L,158910093L,3154873061L,62983652064L,1254587192478L,24999683657717L,498208235612370L,9928170924108502L,197840444358226725L,3942513809137853076L,BigInteger.Parse("78564804146413114965") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196744Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196744.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196744.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196744Inst Instance=new A196744Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196745
{
public static readonly BigInteger[] Value={ 1L,99L,4559L,134507L,4717086L,158910093L,5423213789L,184583551173L,6281590396734L,213663802431954L,7273588793555438L,247506982572487479L,8422846977433705331L,BigInteger.Parse("286636127515942129449"),BigInteger.Parse("9754487417323791315992") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196745Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196745.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196745.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196745Inst Instance=new A196745Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196746
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,3L,3L,1L,1L,7L,20L,7L,1L,1L,17L,71L,71L,17L,1L,1L,41L,282L,401L,282L,41L,1L,1L,99L,1144L,2923L,2923L,1144L,99L,1L,1L,239L,4559L,19567L,35202L,19567L,4559L,239L,1L,1L,577L,18153L,134507L,400368L,400368L,134507L,18153L,577L,1L,1L,1393L,72678L,919377L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196746Inst : IEnumerable<long>
{
public static readonly long[] Value=A196746.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196746.Bytes);
public long this[int i]=>Value[i];

public static A196746Inst Instance=new A196746Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196747
{
public static readonly long[] Value={ 0L,1L,2L,6L,7L,8L,18L,19L,20L,24L,25L,26L,54L,55L,56L,60L,61L,62L,72L,73L,74L,78L,79L,80L,162L,163L,164L,168L,169L,170L,180L,181L,182L,186L,187L,188L,216L,217L,218L,222L,223L,224L,234L,235L,236L,240L,241L,242L,486L,487L,488L,492L,493L,494L,504L,505L,506L,510L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196747Inst : IEnumerable<long>
{
public static readonly long[] Value=A196747.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196747.Bytes);
public long this[int i]=>Value[i];

public static A196747Inst Instance=new A196747Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196748
{
public static readonly long[] Value={ 0L,1L,2L,20L,24L,54L,60L,61L,62L,72L,73L,74L,504L,510L,511L,512L,560L,564L,1512L,1513L,1514L,1520L,1620L,1621L,1622L,6320L,6324L,6372L,6373L,6374L,6500L,6504L,6552L,6553L,6554L,6560L,13122L,13123L,13124L,13770L,13771L,13772L,13824L,13850L,15072L,15073L,15074L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196748Inst : IEnumerable<long>
{
public static readonly long[] Value=A196748.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196748.Bytes);
public long this[int i]=>Value[i];

public static A196748Inst Instance=new A196748Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196749
{
public static readonly long[] Value={ 0L,1L,2L,20L,1512L,1513L,1514L,6320L,6372L,6373L,6374L,6500L,15120L,15121L,15122L,15302L,40014L,119096754L,119096802L,91547225622L,91550794374L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196749Inst : IEnumerable<long>
{
public static readonly long[] Value=A196749.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196749.Bytes);
public long this[int i]=>Value[i];

public static A196749Inst Instance=new A196749Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196750
{
public static readonly long[] Value={ 0L,1L,2L,6320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196750Inst : IEnumerable<long>
{
public static readonly long[] Value=A196750.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196750.Bytes);
public long this[int i]=>Value[i];

public static A196750Inst Instance=new A196750Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196751
{
public static readonly long[] Value={ 1L,0L,6L,8L,9L,6L,1L,2L,1L,8L,4L,8L,0L,1L,3L,6L,4L,8L,5L,4L,4L,7L,9L,0L,4L,8L,8L,5L,4L,7L,2L,7L,5L,8L,4L,2L,2L,4L,9L,3L,5L,8L,1L,1L,8L,7L,0L,8L,0L,2L,2L,4L,1L,0L,6L,3L,5L,3L,5L,5L,6L,7L,5L,5L,9L,9L,4L,1L,9L,3L,2L,0L,1L,1L,7L,2L,3L,1L,4L,9L,1L,0L,1L,7L,9L,6L,6L,3L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196751Inst : IEnumerable<long>
{
public static readonly long[] Value=A196751.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196751.Bytes);
public long this[int i]=>Value[i];

public static A196751Inst Instance=new A196751Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196752
{
public static readonly long[] Value={ 129L,24398L,105402L,148886L,148998L,159078L,171078L,211878L,334260L,334638L,684272L,848610L,932988L,1068420L,1092752L,1142886L,1520118L,2112540L,2770038L,2873108L,2985972L,3126060L,3309512L,3760878L,3955742L,4143422L,4331708L,4696272L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196752Inst : IEnumerable<long>
{
public static readonly long[] Value=A196752.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196752.Bytes);
public long this[int i]=>Value[i];

public static A196752Inst Instance=new A196752Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196753
{
public static readonly long[] Value={ 60918125432L,100204679508L,184734855140L,318367666368L,404695759730L,521920922792L,755839079558L,966837148602L,1080550892412L,1088081614826L,1516213475052L,1720816433808L,1833181814670L,2680075789926L,2993867920578L,3204931381760L,3260730290378L,4432211851700L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196753Inst : IEnumerable<long>
{
public static readonly long[] Value=A196753.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196753.Bytes);
public long this[int i]=>Value[i];

public static A196753Inst Instance=new A196753Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196754
{
public static readonly long[] Value={ 5L,9L,4L,8L,3L,9L,1L,7L,2L,5L,0L,5L,4L,9L,2L,9L,5L,4L,8L,3L,4L,8L,9L,9L,7L,7L,5L,3L,7L,7L,9L,2L,1L,5L,1L,0L,8L,5L,6L,7L,7L,7L,0L,5L,1L,7L,4L,0L,1L,9L,0L,8L,8L,9L,2L,4L,7L,6L,3L,0L,9L,2L,7L,7L,9L,1L,2L,3L,8L,3L,7L,6L,1L,7L,3L,2L,0L,2L,4L,8L,1L,7L,8L,4L,0L,4L,9L,4L,9L,9L,3L,7L,2L,4L,2L,3L,7L,2L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196754Inst : IEnumerable<long>
{
public static readonly long[] Value=A196754.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196754.Bytes);
public long this[int i]=>Value[i];

public static A196754Inst Instance=new A196754Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196755
{
public static readonly long[] Value={ 5L,1L,1L,1L,0L,2L,2L,4L,0L,2L,6L,7L,9L,0L,3L,2L,8L,1L,1L,9L,7L,6L,3L,5L,0L,8L,6L,9L,8L,9L,5L,4L,5L,9L,4L,7L,7L,0L,9L,7L,3L,4L,2L,5L,7L,3L,8L,5L,6L,6L,8L,5L,0L,9L,8L,6L,8L,8L,4L,8L,0L,4L,0L,8L,8L,8L,8L,0L,7L,0L,5L,5L,0L,0L,0L,4L,5L,7L,7L,2L,2L,0L,7L,0L,0L,6L,0L,9L,2L,5L,4L,9L,8L,1L,4L,2L,7L,5L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196755Inst : IEnumerable<long>
{
public static readonly long[] Value=A196755.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196755.Bytes);
public long this[int i]=>Value[i];

public static A196755Inst Instance=new A196755Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196756
{
public static readonly long[] Value={ 4L,5L,5L,0L,5L,2L,6L,3L,6L,7L,9L,4L,1L,5L,1L,9L,9L,2L,0L,4L,5L,3L,9L,7L,9L,6L,5L,1L,4L,2L,0L,4L,0L,6L,6L,9L,8L,7L,1L,8L,1L,4L,3L,7L,0L,7L,3L,0L,3L,9L,9L,0L,3L,9L,0L,9L,8L,4L,7L,9L,4L,4L,1L,2L,2L,6L,4L,4L,4L,3L,8L,2L,4L,4L,2L,6L,3L,8L,2L,6L,9L,5L,9L,2L,0L,9L,2L,1L,5L,3L,4L,5L,9L,4L,5L,0L,9L,2L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196756Inst : IEnumerable<long>
{
public static readonly long[] Value=A196756.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196756.Bytes);
public long this[int i]=>Value[i];

public static A196756Inst Instance=new A196756Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196757
{
public static readonly long[] Value={ 4L,1L,4L,1L,5L,9L,9L,3L,3L,2L,3L,1L,8L,7L,2L,9L,7L,5L,5L,1L,3L,7L,5L,7L,8L,9L,6L,3L,2L,0L,4L,4L,2L,1L,1L,2L,3L,0L,9L,6L,7L,5L,1L,8L,1L,1L,8L,3L,7L,6L,6L,2L,0L,1L,2L,3L,4L,3L,7L,5L,4L,9L,7L,4L,3L,7L,0L,1L,9L,0L,4L,2L,9L,3L,4L,9L,2L,2L,5L,1L,8L,8L,3L,5L,3L,0L,9L,1L,0L,1L,3L,0L,2L,6L,6L,5L,1L,9L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196757Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196757.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196757Inst : IEnumerable<long>
{
public static readonly long[] Value=A196757.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196757.Bytes);
public long this[int i]=>Value[i];

public static A196757Inst Instance=new A196757Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196758
{
public static readonly long[] Value={ 5L,4L,9L,5L,3L,9L,3L,9L,9L,3L,5L,5L,1L,5L,3L,4L,1L,1L,5L,2L,1L,9L,3L,8L,9L,8L,7L,3L,2L,5L,3L,8L,3L,9L,3L,8L,0L,9L,0L,0L,3L,3L,7L,2L,8L,1L,1L,5L,2L,8L,5L,6L,2L,7L,9L,9L,1L,4L,1L,4L,4L,8L,6L,9L,2L,6L,4L,3L,3L,4L,8L,0L,3L,1L,1L,8L,0L,1L,2L,5L,1L,7L,1L,0L,9L,1L,7L,7L,2L,2L,1L,6L,8L,3L,7L,7L,9L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196758Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196758.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196758Inst : IEnumerable<long>
{
public static readonly long[] Value=A196758.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196758.Bytes);
public long this[int i]=>Value[i];

public static A196758Inst Instance=new A196758Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196759
{
public static readonly long[] Value={ 2L,4L,2L,9L,6L,2L,6L,8L,5L,0L,9L,5L,0L,3L,4L,0L,8L,6L,9L,1L,2L,6L,1L,1L,5L,8L,0L,7L,9L,5L,1L,2L,3L,0L,7L,3L,0L,1L,2L,2L,6L,9L,4L,4L,5L,7L,7L,8L,0L,1L,5L,6L,2L,1L,4L,8L,8L,6L,0L,3L,9L,0L,7L,9L,6L,1L,2L,1L,9L,6L,3L,4L,1L,9L,9L,6L,2L,3L,0L,1L,4L,0L,8L,6L,3L,3L,5L,1L,0L,5L,3L,7L,7L,4L,7L,9L,2L,5L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196759Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196759.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196759Inst : IEnumerable<long>
{
public static readonly long[] Value=A196759.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196759.Bytes);
public long this[int i]=>Value[i];

public static A196759Inst Instance=new A196759Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196760
{
public static readonly long[] Value={ 6L,5L,9L,1L,4L,6L,7L,8L,0L,7L,2L,7L,6L,4L,5L,0L,4L,0L,8L,6L,8L,9L,1L,9L,3L,5L,3L,6L,4L,5L,6L,4L,7L,7L,3L,6L,6L,6L,0L,6L,9L,5L,3L,6L,2L,0L,3L,2L,8L,7L,0L,8L,9L,1L,3L,0L,8L,6L,4L,5L,7L,2L,7L,8L,2L,4L,9L,4L,9L,9L,7L,0L,6L,6L,6L,9L,6L,3L,3L,5L,0L,8L,4L,7L,8L,9L,6L,7L,6L,7L,2L,2L,6L,7L,5L,4L,6L,3L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196760Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196760.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196760Inst : IEnumerable<long>
{
public static readonly long[] Value=A196760.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196760.Bytes);
public long this[int i]=>Value[i];

public static A196760Inst Instance=new A196760Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196761
{
public static readonly long[] Value={ 6L,7L,4L,4L,1L,6L,8L,3L,5L,3L,2L,5L,9L,1L,4L,8L,5L,5L,5L,8L,5L,5L,2L,8L,1L,1L,7L,3L,0L,1L,5L,3L,2L,5L,9L,4L,4L,0L,2L,6L,8L,7L,9L,9L,7L,1L,4L,1L,3L,4L,0L,7L,9L,1L,2L,9L,6L,2L,3L,6L,7L,5L,1L,2L,6L,6L,8L,7L,8L,6L,9L,0L,0L,1L,9L,5L,5L,7L,3L,4L,1L,7L,3L,9L,0L,9L,4L,6L,9L,1L,2L,7L,1L,6L,1L,6L,5L,4L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196761Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196761.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196761Inst : IEnumerable<long>
{
public static readonly long[] Value=A196761.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196761.Bytes);
public long this[int i]=>Value[i];

public static A196761Inst Instance=new A196761Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196762
{
public static readonly long[] Value={ 6L,9L,0L,1L,4L,1L,2L,6L,0L,9L,0L,2L,1L,3L,0L,4L,2L,9L,3L,2L,3L,8L,7L,3L,2L,3L,1L,3L,6L,3L,9L,9L,2L,6L,5L,5L,1L,6L,5L,9L,2L,0L,1L,1L,5L,3L,5L,1L,3L,2L,7L,6L,8L,7L,7L,7L,3L,6L,7L,4L,0L,1L,2L,3L,7L,2L,4L,3L,4L,8L,0L,2L,1L,1L,1L,0L,8L,5L,5L,9L,4L,1L,2L,0L,7L,0L,1L,5L,5L,5L,4L,3L,3L,3L,9L,0L,8L,4L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196762Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196762.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196762Inst : IEnumerable<long>
{
public static readonly long[] Value=A196762.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196762.Bytes);
public long this[int i]=>Value[i];

public static A196762Inst Instance=new A196762Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196763
{
public static readonly long[] Value={ 7L,0L,6L,8L,8L,9L,1L,4L,0L,3L,3L,9L,5L,0L,6L,6L,8L,0L,0L,6L,8L,7L,5L,9L,9L,5L,6L,1L,9L,1L,6L,7L,6L,2L,0L,4L,2L,7L,1L,5L,0L,4L,5L,1L,0L,1L,7L,0L,0L,5L,9L,5L,1L,7L,8L,7L,8L,0L,8L,5L,5L,2L,2L,9L,2L,2L,7L,5L,8L,0L,2L,5L,6L,0L,3L,5L,9L,4L,4L,1L,4L,9L,2L,2L,0L,8L,7L,2L,9L,7L,6L,5L,7L,9L,7L,9L,2L,8L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196763Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196763.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196763Inst : IEnumerable<long>
{
public static readonly long[] Value=A196763.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196763.Bytes);
public long this[int i]=>Value[i];

public static A196763Inst Instance=new A196763Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196764
{
public static readonly long[] Value={ 7L,2L,5L,6L,6L,3L,2L,9L,3L,6L,6L,2L,8L,3L,9L,9L,8L,6L,4L,3L,1L,3L,5L,5L,6L,1L,0L,0L,8L,6L,6L,9L,5L,7L,1L,2L,9L,1L,9L,4L,7L,1L,7L,0L,0L,4L,8L,3L,9L,7L,4L,2L,5L,3L,9L,6L,5L,8L,2L,0L,2L,5L,0L,8L,7L,7L,0L,8L,8L,9L,5L,7L,4L,1L,2L,5L,2L,7L,0L,7L,3L,9L,7L,1L,4L,4L,7L,1L,1L,7L,3L,4L,7L,2L,2L,2L,6L,3L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196764Inst : IEnumerable<long>
{
public static readonly long[] Value=A196764.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196764.Bytes);
public long this[int i]=>Value[i];

public static A196764Inst Instance=new A196764Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196765
{
public static readonly long[] Value={ 1L,8L,1L,9L,7L,0L,5L,7L,4L,1L,1L,5L,9L,6L,5L,3L,0L,4L,6L,2L,0L,6L,9L,5L,7L,6L,8L,0L,3L,7L,5L,5L,2L,8L,1L,4L,5L,6L,1L,6L,5L,2L,2L,4L,7L,8L,4L,4L,1L,6L,3L,4L,0L,3L,6L,1L,5L,1L,2L,9L,5L,5L,0L,7L,3L,3L,1L,4L,4L,0L,0L,1L,6L,7L,6L,0L,3L,3L,9L,6L,1L,7L,8L,6L,5L,6L,1L,9L,5L,0L,7L,4L,4L,4L,8L,1L,5L,2L,6L,6L,0L,5L,3L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196765Inst : IEnumerable<long>
{
public static readonly long[] Value=A196765.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196765.Bytes);
public long this[int i]=>Value[i];

public static A196765Inst Instance=new A196765Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196766
{
public static readonly long[] Value={ 4L,4L,2L,1L,2L,0L,5L,9L,2L,9L,5L,4L,9L,9L,8L,3L,9L,1L,3L,3L,5L,6L,1L,6L,2L,4L,4L,0L,5L,0L,4L,7L,6L,1L,3L,6L,1L,8L,6L,9L,0L,7L,0L,8L,6L,1L,2L,8L,6L,1L,0L,1L,5L,2L,9L,5L,8L,7L,9L,4L,3L,9L,1L,1L,9L,4L,5L,6L,6L,6L,5L,7L,9L,4L,5L,8L,7L,2L,6L,2L,5L,7L,9L,6L,8L,0L,2L,6L,6L,6L,0L,0L,1L,7L,6L,8L,9L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196766Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196766.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196766Inst : IEnumerable<long>
{
public static readonly long[] Value=A196766.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196766.Bytes);
public long this[int i]=>Value[i];

public static A196766Inst Instance=new A196766Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196767
{
public static readonly long[] Value={ 2L,0L,7L,3L,9L,3L,2L,8L,0L,9L,0L,9L,1L,2L,1L,4L,9L,0L,1L,1L,6L,7L,7L,7L,6L,2L,9L,7L,7L,9L,9L,3L,6L,0L,0L,6L,7L,9L,4L,6L,2L,1L,9L,5L,3L,1L,5L,2L,8L,5L,3L,0L,5L,4L,4L,6L,7L,9L,2L,9L,5L,2L,6L,7L,8L,5L,7L,8L,6L,8L,5L,6L,8L,8L,8L,6L,8L,7L,0L,2L,3L,2L,9L,9L,2L,8L,2L,1L,8L,4L,1L,3L,0L,6L,9L,9L,4L,6L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196767Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196767.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196767Inst : IEnumerable<long>
{
public static readonly long[] Value=A196767.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196767.Bytes);
public long this[int i]=>Value[i];

public static A196767Inst Instance=new A196767Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196768
{
public static readonly long[] Value={ 1L,6L,8L,3L,3L,0L,5L,5L,8L,6L,7L,0L,8L,8L,9L,6L,1L,4L,5L,4L,3L,7L,3L,6L,1L,7L,5L,8L,9L,9L,4L,8L,5L,5L,6L,3L,5L,4L,5L,1L,3L,9L,4L,8L,6L,6L,0L,4L,2L,0L,4L,7L,1L,7L,2L,7L,3L,3L,8L,7L,6L,5L,3L,2L,7L,3L,2L,9L,2L,9L,6L,6L,5L,6L,0L,6L,5L,7L,1L,5L,8L,2L,3L,9L,6L,4L,2L,9L,2L,5L,4L,4L,5L,0L,5L,6L,9L,2L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196768Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196768.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196768Inst : IEnumerable<long>
{
public static readonly long[] Value=A196768.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196768.Bytes);
public long this[int i]=>Value[i];

public static A196768Inst Instance=new A196768Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196769
{
public static readonly long[] Value={ 1L,5L,0L,9L,5L,0L,6L,8L,3L,2L,2L,2L,4L,4L,7L,2L,8L,8L,5L,5L,6L,5L,3L,2L,6L,2L,2L,0L,4L,3L,7L,7L,6L,8L,5L,0L,5L,5L,3L,2L,8L,8L,0L,8L,1L,7L,0L,6L,6L,7L,1L,9L,6L,4L,6L,6L,6L,7L,2L,3L,7L,1L,0L,6L,1L,3L,4L,3L,0L,5L,4L,2L,1L,6L,9L,1L,4L,0L,3L,4L,8L,1L,5L,9L,4L,3L,3L,3L,4L,5L,5L,5L,4L,1L,1L,9L,2L,2L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196769Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196769.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196769Inst : IEnumerable<long>
{
public static readonly long[] Value=A196769.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196769.Bytes);
public long this[int i]=>Value[i];

public static A196769Inst Instance=new A196769Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196770
{
public static readonly long[] Value={ 1L,4L,1L,3L,9L,2L,2L,5L,4L,0L,9L,0L,9L,2L,9L,6L,7L,4L,0L,4L,2L,4L,4L,5L,3L,3L,3L,3L,0L,3L,6L,0L,3L,3L,1L,1L,3L,0L,4L,0L,9L,0L,1L,9L,1L,5L,7L,1L,0L,0L,0L,8L,3L,1L,5L,0L,5L,5L,0L,3L,1L,6L,0L,0L,5L,8L,0L,6L,3L,7L,8L,3L,6L,7L,5L,4L,0L,2L,7L,3L,0L,1L,2L,4L,9L,0L,2L,5L,7L,2L,8L,1L,9L,1L,2L,2L,6L,1L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196770Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196770.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196770Inst : IEnumerable<long>
{
public static readonly long[] Value=A196770.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196770.Bytes);
public long this[int i]=>Value[i];

public static A196770Inst Instance=new A196770Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196771
{
public static readonly long[] Value={ 1L,3L,5L,4L,2L,8L,7L,2L,1L,4L,1L,5L,7L,7L,2L,1L,4L,1L,7L,8L,3L,0L,6L,3L,7L,1L,6L,1L,6L,3L,7L,5L,3L,0L,6L,8L,5L,9L,7L,7L,2L,6L,3L,2L,5L,7L,6L,7L,5L,5L,1L,4L,7L,7L,6L,4L,6L,9L,9L,2L,1L,1L,6L,1L,2L,5L,1L,9L,2L,2L,3L,4L,1L,6L,4L,3L,7L,6L,0L,3L,8L,8L,1L,9L,0L,8L,5L,8L,3L,0L,1L,8L,6L,4L,0L,3L,5L,0L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196771Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196771.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196771Inst : IEnumerable<long>
{
public static readonly long[] Value=A196771.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196771.Bytes);
public long this[int i]=>Value[i];

public static A196771Inst Instance=new A196771Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196772
{
public static readonly long[] Value={ 9L,6L,5L,0L,1L,6L,1L,0L,9L,7L,7L,3L,3L,4L,2L,9L,1L,0L,0L,8L,2L,9L,0L,4L,1L,2L,5L,8L,8L,0L,0L,5L,2L,6L,7L,1L,0L,5L,0L,4L,6L,6L,7L,9L,6L,5L,7L,3L,4L,0L,4L,5L,0L,4L,7L,0L,2L,3L,0L,5L,7L,5L,6L,4L,1L,8L,5L,8L,9L,6L,1L,6L,9L,8L,6L,0L,9L,5L,7L,6L,9L,1L,9L,1L,5L,4L,0L,0L,2L,8L,8L,5L,2L,1L,7L,9L,4L,1L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196772Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196772.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196772Inst : IEnumerable<long>
{
public static readonly long[] Value=A196772.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196772.Bytes);
public long this[int i]=>Value[i];

public static A196772Inst Instance=new A196772Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196773
{
public static readonly long[] Value={ 1L,8L,6L,3L,0L,4L,5L,3L,0L,8L,2L,4L,8L,6L,9L,9L,2L,2L,4L,0L,6L,9L,7L,9L,3L,2L,0L,4L,6L,9L,3L,6L,3L,5L,4L,1L,8L,3L,3L,4L,4L,2L,1L,0L,0L,0L,4L,6L,3L,5L,7L,8L,9L,5L,6L,7L,1L,4L,4L,9L,5L,9L,1L,8L,9L,2L,6L,4L,5L,2L,7L,4L,8L,9L,3L,9L,5L,0L,4L,7L,6L,3L,9L,3L,5L,3L,0L,7L,4L,8L,8L,7L,1L,0L,0L,8L,9L,1L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196773Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196773.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196773Inst : IEnumerable<long>
{
public static readonly long[] Value=A196773.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196773.Bytes);
public long this[int i]=>Value[i];

public static A196773Inst Instance=new A196773Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196774
{
public static readonly long[] Value={ 4L,2L,0L,8L,4L,2L,7L,5L,2L,6L,5L,6L,6L,7L,4L,1L,9L,5L,1L,6L,0L,6L,5L,3L,1L,2L,5L,0L,6L,9L,3L,2L,7L,8L,2L,4L,9L,0L,7L,0L,4L,2L,6L,0L,6L,5L,4L,9L,7L,3L,8L,9L,8L,9L,0L,5L,0L,2L,0L,0L,6L,4L,2L,0L,9L,6L,9L,4L,9L,8L,0L,6L,5L,0L,6L,4L,7L,9L,2L,4L,4L,8L,6L,7L,5L,2L,7L,9L,8L,5L,5L,9L,2L,8L,9L,1L,2L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196774Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196774.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196774Inst : IEnumerable<long>
{
public static readonly long[] Value=A196774.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196774.Bytes);
public long this[int i]=>Value[i];

public static A196774Inst Instance=new A196774Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196775
{
public static readonly long[] Value={ 2L,8L,8L,1L,0L,6L,5L,7L,2L,8L,3L,1L,2L,9L,8L,9L,6L,7L,2L,7L,3L,9L,8L,9L,5L,9L,9L,4L,5L,0L,8L,3L,9L,2L,5L,3L,4L,5L,5L,0L,0L,3L,4L,9L,2L,3L,1L,6L,1L,2L,3L,0L,3L,1L,5L,7L,6L,3L,1L,8L,7L,8L,6L,9L,3L,8L,2L,3L,1L,4L,4L,3L,9L,3L,5L,1L,0L,4L,3L,4L,2L,5L,5L,7L,7L,1L,0L,3L,5L,1L,5L,6L,7L,7L,7L,5L,6L,8L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196775Inst : IEnumerable<long>
{
public static readonly long[] Value=A196775.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196775.Bytes);
public long this[int i]=>Value[i];

public static A196775Inst Instance=new A196775Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196776
{
public static readonly long[] Value={ 1L,0L,2L,1L,0L,6L,0L,8L,0L,24L,1L,0L,60L,0L,120L,0L,32L,0L,480L,0L,720L,1L,0L,546L,0L,4200L,0L,5040L,0L,128L,0L,8064L,0L,40320L,0L,40320L,1L,0L,4920L,0L,115920L,0L,423360L,0L,362880L,0L,512L,0L,130560L,0L,1693440L,0L,4838400L,0L,3628800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196776Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196776.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196776Inst : IEnumerable<long>
{
public static readonly long[] Value=A196776.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196776.Bytes);
public long this[int i]=>Value[i];

public static A196776Inst Instance=new A196776Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196777
{
public static readonly long[] Value={ 0L,1L,0L,1L,0L,2L,0L,1L,0L,5L,0L,2L,0L,0L,0L,1L,0L,2L,0L,2L,0L,0L,0L,2L,0L,13L,0L,0L,0L,0L,0L,1L,0L,17L,0L,2L,0L,0L,0L,2L,0L,4L,0L,22L,0L,0L,0L,2L,0L,25L,0L,0L,0L,2L,0L,28L,0L,29L,0L,4L,0L,0L,0L,1L,0L,0L,0L,17L,0L,0L,0L,2L,0L,37L,0L,38L,0L,0L,0L,2L,0L,41L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196777Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196777.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196777Inst : IEnumerable<long>
{
public static readonly long[] Value=A196777.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196777.Bytes);
public long this[int i]=>Value[i];

public static A196777Inst Instance=new A196777Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196778
{
public static readonly long[] Value={ 1L,3L,5L,6L,7L,7L,9L,8L,9L,12L,7L,9L,4L,4L,8L,11L,6L,11L,7L,8L,14L,7L,8L,11L,6L,10L,9L,8L,8L,11L,6L,10L,13L,7L,6L,9L,10L,8L,8L,10L,5L,10L,15L,6L,11L,9L,14L,7L,8L,16L,12L,10L,5L,10L,9L,8L,10L,8L,7L,10L,11L,13L,12L,6L,12L,9L,4L,10L,12L,13L,8L,14L,7L,2L,13L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196778Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196778.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196778Inst : IEnumerable<long>
{
public static readonly long[] Value=A196778.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196778.Bytes);
public long this[int i]=>Value[i];

public static A196778Inst Instance=new A196778Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196779
{
public static readonly long[] Value={ 1147L,113L,113L,400L,866L,131L,399L,32L,26L,29L,23L,58L,77L,21L,42L,3L,817L,4L,2L,37L,80L,29L,181L,39L,120L,382L,76L,5L,29L,20L,48L,19L,36L,7L,43L,7L,62L,22L,7L,43L,5L,17L,23L,44L,52L,137L,103L,2L,5L,49L,31L,10L,30L,5L,25L,25L,49L,10L,72L,50L,13L,4L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196779Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196779.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196779Inst : IEnumerable<long>
{
public static readonly long[] Value=A196779.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196779.Bytes);
public long this[int i]=>Value[i];

public static A196779Inst Instance=new A196779Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196780
{
public static readonly BigInteger[] Value={ 1L,1L,17L,145L,6137L,404589L,65282256L,22331701461L,16774271567427L,27461523421500033L,BigInteger.Parse("98038364298327333400") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196780Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196780.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196780Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196780.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196780.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196780Inst Instance=new A196780Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196781
{
public static readonly long[] Value={ 1L,3L,17L,39L,135L,427L,1351L,4319L,13715L,43607L,138727L,441175L,1403139L,4462583L,14192759L,45138911L,143560379L,456581095L,1452116295L,4618328471L,14688188867L,46714497719L,148571365447L,472518206415L,1502802742427L,4779532410183L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196781Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196781.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196781Inst : IEnumerable<long>
{
public static readonly long[] Value=A196781.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196781.Bytes);
public long this[int i]=>Value[i];

public static A196781Inst Instance=new A196781Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196782
{
public static readonly long[] Value={ 1L,7L,39L,145L,797L,3569L,17175L,81389L,385231L,1829101L,8668831L,41113007L,194955001L,924449179L,4383753391L,20787435021L,98573175383L,467429309303L,2216527199343L,10510668481659L,49841089379745L,236344089239897L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196782Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196782.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196782Inst : IEnumerable<long>
{
public static readonly long[] Value=A196782.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196782.Bytes);
public long this[int i]=>Value[i];

public static A196782Inst Instance=new A196782Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196783
{
public static readonly long[] Value={ 1L,17L,135L,797L,6137L,40749L,289761L,2025511L,14215709L,99646153L,698024127L,4892934573L,34291191221L,240334383531L,1684405081345L,11805196899669L,82737396174443L,579869401345235L,4064046980256775L,28483094044958233L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196783Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196783.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196783Inst : IEnumerable<long>
{
public static readonly long[] Value=A196783.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196783.Bytes);
public long this[int i]=>Value[i];

public static A196783Inst Instance=new A196783Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196784
{
public static readonly long[] Value={ 1L,41L,427L,3569L,40749L,404589L,4216301L,43457133L,448071435L,4621262139L,47666356469L,491646083197L,5070868714285L,52302472643609L,539455130405867L,5564052932385685L,57388767910023213L,591918940819313175L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196784Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196784.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196784Inst : IEnumerable<long>
{
public static readonly long[] Value=A196784.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196784.Bytes);
public long this[int i]=>Value[i];

public static A196784Inst Instance=new A196784Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196785
{
public static readonly long[] Value={ 1L,99L,1351L,17175L,289761L,4216301L,65282256L,993629439L,15177736646L,231779144185L,3537181684727L,53999808742021L,824352446553481L,12584320094861238L,192108754190909442L,2932675433265799165L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196785Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196785.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196785Inst : IEnumerable<long>
{
public static readonly long[] Value=A196785.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196785.Bytes);
public long this[int i]=>Value[i];

public static A196785Inst Instance=new A196785Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196786
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,3L,3L,1L,1L,7L,17L,7L,1L,1L,17L,39L,39L,17L,1L,1L,41L,135L,145L,135L,41L,1L,1L,99L,427L,797L,797L,427L,99L,1L,1L,239L,1351L,3569L,6137L,3569L,1351L,239L,1L,1L,577L,4319L,17175L,40749L,40749L,17175L,4319L,577L,1L,1L,1393L,13715L,81389L,289761L,404589L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196786Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196786.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196786Inst : IEnumerable<long>
{
public static readonly long[] Value=A196786.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196786.Bytes);
public long this[int i]=>Value[i];

public static A196786Inst Instance=new A196786Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196787
{
public static readonly long[] Value={ 1L,1L,1L,3L,6L,12L,24L,46L,87L,163L,303L,561L,1036L,1910L,3518L,6476L,11917L,21925L,40333L,74191L,136466L,251008L,461684L,849178L,1561891L,2872775L,5283867L,9718557L,1783L,2341247774L,4306226036L,7920384528L,14567858374L,26794468975L,49282711915L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196787Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196787.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196787Inst : IEnumerable<long>
{
public static readonly long[] Value=A196787.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196787.Bytes);
public long this[int i]=>Value[i];

public static A196787Inst Instance=new A196787Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196788
{
public static readonly long[] Value={ 1L,1805L,133L,2L,3L,4L,5L,13L,6L,9L,8L,10L,19L,16L,32L,24L,74L,30L,18L,60L,168L,20L,42L,90L,180L,210L,186L,408L,144L,1020L,1050L,900L,2520L,3348L,2850L,5520L,3390L,774L,5760L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196788Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196788.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196788Inst : IEnumerable<long>
{
public static readonly long[] Value=A196788.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196788.Bytes);
public long this[int i]=>Value[i];

public static A196788Inst Instance=new A196788Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196789
{
public static readonly long[] Value={ 1L,66L,1001L,8008L,43758L,184756L,646646L,1961256L,5311735L,13123110L,30045015L,64512240L,131128140L,254186856L,472733756L,847660528L,1471442973L,2481256778L,4076350421L,6540715896L,10272278170L,15820024220L,23930713170L,35607051480L,52179482355L,75394027566L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196789Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196789.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196789Inst : IEnumerable<long>
{
public static readonly long[] Value=A196789.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196789.Bytes);
public long this[int i]=>Value[i];

public static A196789Inst Instance=new A196789Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196790
{
public static readonly long[] Value={ 11L,286L,3003L,19448L,92378L,352716L,1144066L,3268760L,8436285L,20030010L,44352165L,92561040L,183579396L,348330136L,635745396L,1121099408L,1917334783L,3190187286L,5178066751L,8217822536L,12777711870L,19499099620L,29248649430L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196790Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196790.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196790Inst : IEnumerable<long>
{
public static readonly long[] Value=A196790.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196790.Bytes);
public long this[int i]=>Value[i];

public static A196790Inst Instance=new A196790Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196791
{
public static readonly long[] Value={ 1L,2L,14L,158L,1886L,22622L,271454L,3257438L,39089246L,469070942L,5628851294L,67546215518L,810554586206L,9726655034462L,116719860413534L,1400638324962398L,16807659899548766L,201691918794585182L,2420303025535022174L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196791Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196791.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196791Inst : IEnumerable<long>
{
public static readonly long[] Value=A196791.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196791.Bytes);
public long this[int i]=>Value[i];

public static A196791Inst Instance=new A196791Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196792
{
public static readonly ulong[] Value={ 1L,2L,15L,184L,2381L,30942L,402235L,5229044L,67977561L,883708282L,11488207655L,149346699504L,1941507093541L,25239592216022L,328114698808275L,4265491084507564L,55451384098598321L,720867993281778162L,9371283912663116095UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196792Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196792.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196792Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A196792.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196792.Bytes);
public ulong this[int i]=>Value[i];

public static A196792Inst Instance=new A196792Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196793
{
public static readonly BigInteger[] Value={ 1L,2L,7L,44L,401L,4682L,66431L,1111112L,21435889L,469070942L,11488207655L,311505013052L,9267595563617L,300239975158034L,10523614159962559L,396861212733968144L,16024522975978953761UL,BigInteger.Parse("689852631578947368422"),BigInteger.Parse("31544039619835776489479") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196793Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196793.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196793Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196793.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196793.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196793Inst Instance=new A196793Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196794
{
public static readonly BigInteger[] Value={ 1L,3L,13L,69L,425L,2953L,22701L,190445L,1725777L,16757649L,173244629L,1896821941L,21897166137L,265525063001L,3371067773565L,44683137692157L,616811052816545L,8847765111928609L,131622808197394341L,2027097866771329349L,BigInteger.Parse("32267707989783480201"),BigInteger.Parse("530125689222591861993") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196794Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196794.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196794Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196794.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196794.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196794Inst Instance=new A196794Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196795
{
public static readonly BigInteger[] Value={ 1L,4L,22L,145L,1096L,9259L,85924L,865183L,9364864L,108173827L,1325589676L,17149360111L,233271228880L,3324545097475L,49493784653644L,767665750130839L,12376226335249024L,206967901014192643L,3583561993192959436L,BigInteger.Parse("64136093489935863583"),BigInteger.Parse("1184711492540805987856") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196795Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196795.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196795Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196795.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196795.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196795Inst Instance=new A196795Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196796
{
public static readonly BigInteger[] Value={ 1L,7L,120L,7407L,1516652L,1029024216L,2336509457978L,17524876527067107L,BigInteger.Parse("436288315960458288785") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196796Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196796.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196796Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196796.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196796.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196796Inst Instance=new A196796Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196797
{
public static readonly long[] Value={ 2L,20L,120L,698L,4078L,23920L,140348L,821284L,4813216L,28205816L,165271574L,968402976L,5674170654L,33247932210L,194815836754L,1141514840080L,6688663128942L,39191982301068L,229644142997092L,1345591934306596L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196797Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196797.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196797Inst : IEnumerable<long>
{
public static readonly long[] Value=A196797.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196797.Bytes);
public long this[int i]=>Value[i];

public static A196797Inst Instance=new A196797Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196798
{
public static readonly long[] Value={ 3L,65L,698L,7407L,79003L,834632L,8882811L,94530039L,1004745630L,10681187595L,113575660599L,1207591084696L,12839042473735L,136508257135233L,1451400786295740L,15431631832722251L,164072914020649465L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196798Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196798.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196798Inst : IEnumerable<long>
{
public static readonly long[] Value=A196798.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196798.Bytes);
public long this[int i]=>Value[i];

public static A196798Inst Instance=new A196798Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196799
{
public static readonly BigInteger[] Value={ 5L,203L,4078L,79003L,1516652L,29239326L,567312297L,10969537457L,212128886217L,4104645843820L,79400771205004L,1535972443663444L,29714060354536788L,574817774193408199L,11119837928249291579UL,BigInteger.Parse("215114059044446417887") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196799Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196799.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196799Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196799.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196799.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196799Inst Instance=new A196799Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196800
{
public static readonly BigInteger[] Value={ 8L,648L,23920L,834632L,29239326L,1029024216L,36350586798L,1279579729422L,45097830841266L,1589630250146316L,56014699053391990L,1974063158226709556L,BigInteger.Parse("69568832383885224954"),BigInteger.Parse("2451683126595415033544"),BigInteger.Parse("86400830410674087049712") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196800Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196800.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196800Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196800.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196800.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196800Inst Instance=new A196800Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196801
{
public static readonly BigInteger[] Value={ 13L,2057L,140348L,8882811L,567312297L,36350586798L,2336509457978L,149921556582391L,9626071838140254L,617911286516585441L,BigInteger.Parse("39661708458260298030"),BigInteger.Parse("2546127117580511443456"),BigInteger.Parse("163441791893758118667088") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196801Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196801.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196801Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196801.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196801.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196801Inst Instance=new A196801Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196802
{
public static readonly long[] Value={ 1L,1L,1L,2L,7L,2L,3L,20L,20L,3L,5L,65L,120L,65L,5L,8L,203L,698L,698L,203L,8L,13L,648L,4078L,7407L,4078L,648L,13L,21L,2057L,23920L,79003L,79003L,23920L,2057L,21L,34L,6527L,140348L,834632L,1516652L,834632L,140348L,6527L,34L,55L,20740L,821284L,8882811L,29239326L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196802Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196802.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196802Inst : IEnumerable<long>
{
public static readonly long[] Value=A196802.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196802.Bytes);
public long this[int i]=>Value[i];

public static A196802Inst Instance=new A196802Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196803
{
public static readonly BigInteger[] Value={ 1L,1L,16L,193L,19449L,2535368L,1436535356L,2099296647197L,9043086011797968L,BigInteger.Parse("109561680407727718539") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196803Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196803.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196803Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196803.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196803.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196803Inst Instance=new A196803Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196804
{
public static readonly long[] Value={ 1L,3L,16L,37L,120L,420L,1468L,4801L,15885L,53128L,178165L,594582L,1983454L,6622194L,22119691L,73864009L,246623786L,823483995L,2749775102L,9181948002L,30659615818L,102376096183L,341847401583L,1141474348346L,3811532000911L,12727199593820L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196804Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196804.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196804Inst : IEnumerable<long>
{
public static readonly long[] Value=A196804.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196804.Bytes);
public long this[int i]=>Value[i];

public static A196804Inst Instance=new A196804Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

}