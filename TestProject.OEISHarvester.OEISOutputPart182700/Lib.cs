using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A213157
{
public static readonly BigInteger[] Value={ 1L,-99L,-99L,1960101L,7840701L,-155226277899L,-1319555674899L,26121225430931301L,381134689417943901L,BigInteger.Parse("-7543761920163143670699"),BigInteger.Parse("-168204228721945992219699"),BigInteger.Parse("3328727258163288077733522501") };
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
public class A213157Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213157.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213157Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A213157.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213157.Bytes);
public BigInteger this[int i]=>Value[i];

public static A213157Inst Instance=new A213157Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213158
{
public static readonly long[] Value={ 3L,8L,15L,20L,24L,35L,36L,48L,56L,63L,80L,84L,96L,99L,108L,120L,128L,135L,140L,143L,144L,168L,176L,180L,195L,200L,216L,224L,231L,240L,243L,255L,260L,264L,275L,288L,300L,308L,320L,323L,336L,351L,360L,384L,396L,399L,416L,420L,440L,455L,468L,476L,483L,495L,504L };
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
public class A213158Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213158.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213158Inst : IEnumerable<long>
{
public static readonly long[] Value=A213158.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213158.Bytes);
public long this[int i]=>Value[i];

public static A213158Inst Instance=new A213158Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213159
{
public static readonly long[] Value={ 3918251L,18727199L,395564539L,397687709L,503720279L,873201911L,1088927209L,1329433951L,2108335769L,2376506131L,3684190621L,3728773019L,3934099049L,3971294419L,4272771301L,5047170421L,5091014389L,5380213021L,6187560259L,6219076681L,7243803841L,8309591011L,8448425231L };
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
public class A213159Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213159.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213159Inst : IEnumerable<long>
{
public static readonly long[] Value=A213159.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213159.Bytes);
public long this[int i]=>Value[i];

public static A213159Inst Instance=new A213159Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213160
{
public static readonly long[] Value={ 14L,70L,286L,1099L,4124L,14935L,53242L,188684L,667972L,2368095L,8426224L,30130319L,108331818L,391700269L,1424153146L,5205387976L,19120256344L,70552778548L,261426207564L,972390417749L,3629462152664L,13590042842272L,51033678706020L,192151581932541L };
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
public class A213160Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213160.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213160Inst : IEnumerable<long>
{
public static readonly long[] Value=A213160.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213160.Bytes);
public long this[int i]=>Value[i];

public static A213160Inst Instance=new A213160Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213161
{
public static readonly long[] Value={ 1329433951L,25778112821L,75902670689L,80358496679L,84005465699L,184273377289L,188745495049L,220260667439L,225830918741L,227706130541L,250232659249L,314987199911L,396580371571L,532375084669L,535798256839L,542604984109L,634725913009L,676837365821L,706769028239L };
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
public class A213161Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213161.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213161Inst : IEnumerable<long>
{
public static readonly long[] Value=A213161.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213161.Bytes);
public long this[int i]=>Value[i];

public static A213161Inst Instance=new A213161Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213162
{
public static readonly long[] Value={ 2L,199L,409L,17569L,981091L,3918251L,1329433951L,75902670689L };
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
public class A213162Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213162.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213162Inst : IEnumerable<long>
{
public static readonly long[] Value=A213162.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213162.Bytes);
public long this[int i]=>Value[i];

public static A213162Inst Instance=new A213162Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213163
{
public static readonly long[] Value={ 1L,7L,32L,122L,422L,1376L,4315L,13165L,39360L,115860L,336876L,969792L,2768917L,7851187L,22130912L,62066126L,173294930L,481976480L,1335880495L,3691245145L,10171349376L,27957706152L,76672984152L,209839988352L,573211991977L,1563112278751L,4255708706720L };
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
public class A213163Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213163.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213163Inst : IEnumerable<long>
{
public static readonly long[] Value=A213163.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213163.Bytes);
public long this[int i]=>Value[i];

public static A213163Inst Instance=new A213163Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213164
{
public static readonly long[] Value={ 1L,9L,51L,235L,966L,3702L,13546L,47994L,166095L,564679L,1893285L,6277677L,20626588L,67260540L,217924068L,702199684L,2251881645L,7191492885L,22882022695L,72568700415L,229473998466L,723725687314L,2277088137966L,7148997642270L,22400192612251L,70060176893427L };
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
public class A213164Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213164.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213164Inst : IEnumerable<long>
{
public static readonly long[] Value=A213164.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213164.Bytes);
public long this[int i]=>Value[i];

public static A213164Inst Instance=new A213164Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213165
{
public static readonly long[] Value={ 1L,11L,74L,396L,1859L,8033L,32827L,128969L,492302L,1838836L,6753760L,24476710L,87754722L,311834270L,1099874777L };
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
public class A213165Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213165.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213165Inst : IEnumerable<long>
{
public static readonly long[] Value=A213165.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213165.Bytes);
public long this[int i]=>Value[i];

public static A213165Inst Instance=new A213165Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213166
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,1L,1L,12L,10L,1L,1L,35L,63L,20L,1L,1L,111L,348L,224L,35L,1L,1L,405L,1920L,2027L,630L,56L,1L,1L,1733L,11247L,17142L,8600L,1512L,84L,1L,1L,8666L,71861L,145375L,104175L,29447L,3234L,120L,1L };
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
public class A213166Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213166.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213166Inst : IEnumerable<long>
{
public static readonly long[] Value=A213166.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213166.Bytes);
public long this[int i]=>Value[i];

public static A213166Inst Instance=new A213166Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213167
{
public static readonly long[] Value={ 1L,5L,22L,114L,696L,4920L,39600L,357840L,3588480L,39553920L,475372800L,6187104000L,86699289600L,1301447347200L,20835611596800L,354379753728000L,6381450915840000L,121289412980736000L,2426499634470912000L };
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
public class A213167Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213167.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213167Inst : IEnumerable<long>
{
public static readonly long[] Value=A213167.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213167.Bytes);
public long this[int i]=>Value[i];

public static A213167Inst Instance=new A213167Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213168
{
public static readonly BigInteger[] Value={ 0L,0L,4L,33L,236L,1795L,15114L,141113L,1451512L,16329591L,199583990L,2634508789L,37362124788L,566658892787L,9153720575986L,156920924159985L,2845499424767984L,54420176498687983L,1094805903679487982L,BigInteger.Parse("23112569077678079981"),BigInteger.Parse("510909421717094399980") };
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
public class A213168Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213168.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213168Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A213168.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213168.Bytes);
public BigInteger this[int i]=>Value[i];

public static A213168Inst Instance=new A213168Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213169
{
public static readonly long[] Value={ 2L,3L,5L,10L,29L,126L,727L,5048L,40329L,362890L,3628811L,39916812L,479001613L,6227020814L,87178291215L,1307674368016L,20922789888017L,355687428096018L,6402373705728019L,121645100408832020L,2432902008176640021L };
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
public class A213169Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213169.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213169Inst : IEnumerable<long>
{
public static readonly long[] Value=A213169.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213169.Bytes);
public long this[int i]=>Value[i];

public static A213169Inst Instance=new A213169Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213170
{
public static readonly long[] Value={ 1L,-2L,2L,2L,-6L,-14L,26L,178L,90L,-2382L,-9446L,13746L,287194L,998578L,-3687782L,-56264782L,-208446118L,1017677490L,17194912282L,79540574642L,-317691584294L,-7577787031374L,-47958156443238L,77252406086578L };
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
public class A213170Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213170.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213170Inst : IEnumerable<long>
{
public static readonly long[] Value=A213170.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213170.Bytes);
public long this[int i]=>Value[i];

public static A213170Inst Instance=new A213170Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213171
{
public static readonly long[] Value={ 1L,4L,5L,2L,3L,6L,9L,10L,13L,14L,7L,8L,11L,12L,15L,18L,19L,22L,23L,26L,27L,16L,17L,20L,21L,24L,25L,28L,31L,32L,35L,36L,39L,40L,43L,44L,29L,30L,33L,34L,37L,38L,41L,42L,45L,48L,49L,52L,53L,56L,57L,60L,61L,64L,65L,46L,47L,50L,51L,54L,55L,58L,59L,62L,63L,66L,69L };
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
public class A213171Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213171.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213171Inst : IEnumerable<long>
{
public static readonly long[] Value=A213171.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213171.Bytes);
public long this[int i]=>Value[i];

public static A213171Inst Instance=new A213171Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213172
{
public static readonly long[] Value={ 0L,1L,2L,3L,6L,9L,12L,16L,21L,26L,32L,38L,45L,52L,61L,69L,78L,88L,99L,110L,121L,133L,146L,159L,173L,188L,203L,218L,234L,251L,268L,286L,305L,324L,343L,364L,384L,406L,428L,450L,473L,497L,521L,546L,571L,597L,624L,651L,679L,707L,736L,765L,795L,826L,857L };
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
public class A213172Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213172.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213172Inst : IEnumerable<long>
{
public static readonly long[] Value=A213172.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213172.Bytes);
public long this[int i]=>Value[i];

public static A213172Inst Instance=new A213172Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213173
{
public static readonly long[] Value={ 1L,1L,4L,4L,16L,16L,64L,64L,256L,256L,1024L,1024L,4096L,4096L,16384L,16384L,65536L,65536L,262144L,262144L,1048576L,1048576L,4194304L,4194304L,16777216L,16777216L,67108864L,67108864L,268435456L,268435456L,1073741824L,1073741824L,4294967296L,4294967296L };
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
public class A213173Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213173.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213173Inst : IEnumerable<long>
{
public static readonly long[] Value=A213173.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213173.Bytes);
public long this[int i]=>Value[i];

public static A213173Inst Instance=new A213173Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213174
{
public static readonly long[] Value={ 23L,83L,119L,401L,1025L,3321L,863L,5683L,1523L,3397L,3979L,8983L,7901L,21775L,11131L,9073L,14699L,16277L,30895L,9167L,15947L,40091L,105131L,54923L,14413L,15605L,122135L,29775L,173649L,80841L,99149L,56495L,189807L,46421L,290203L,158741L,56099L,276535L,189869L };
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
public class A213174Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213174.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213174Inst : IEnumerable<long>
{
public static readonly long[] Value=A213174.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213174.Bytes);
public long this[int i]=>Value[i];

public static A213174Inst Instance=new A213174Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213175
{
public static readonly long[] Value={ 5L,7L,43L,73L,463L,859L,883L,3559L,3823L,4273L,77269L };
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
public class A213175Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213175.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213175Inst : IEnumerable<long>
{
public static readonly long[] Value=A213175.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213175.Bytes);
public long this[int i]=>Value[i];

public static A213175Inst Instance=new A213175Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213176
{
public static readonly long[] Value={ 7L,11L,31L,59L,73L,137L,563L,34819L,48751L,73849L };
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
public class A213176Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213176.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213176Inst : IEnumerable<long>
{
public static readonly long[] Value=A213176.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213176.Bytes);
public long this[int i]=>Value[i];

public static A213176Inst Instance=new A213176Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213177
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,2L,0L,3L,0L,3L,0L,3L,5L,0L,4L,0L,5L,6L,4L,0L,5L,0L,8L,9L,7L,5L,0L,6L,0L,10L,13L,13L,5L,6L,0L,7L,0L,13L,23L,14L,15L,6L,7L,0L,8L,0L,18L,30L,27L,16L,13L,7L,8L,0L,9L,0L,25L,44L,33L,30L,18L,15L,8L,9L,0L,10L,0L,30L,58L,55L,36L,34L,15L,17L,9L,10L,0L,11L };
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
public class A213177Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213177.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213177Inst : IEnumerable<long>
{
public static readonly long[] Value=A213177.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213177.Bytes);
public long this[int i]=>Value[i];

public static A213177Inst Instance=new A213177Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213178
{
public static readonly long[] Value={ 1L,8L,4L,32L,4L,32L,16L,128L,4L,32L,16L,128L,16L,128L,64L,512L,4L,32L,16L,128L,16L,128L,64L,512L,16L,128L,64L,512L,64L,512L,256L,2048L,4L,32L,16L,128L,16L,128L,64L,512L,16L,128L,64L,512L,64L,512L,256L,2048L,16L,128L,64L,512L,64L,512L,256L,2048L,64L,512L,256L,2048L,256L,2048L,1024L,8192L,4L,32L,16L,128L,16L,128L,64L,512L,16L,128L };
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
public class A213178Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213178.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213178Inst : IEnumerable<long>
{
public static readonly long[] Value=A213178.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213178.Bytes);
public long this[int i]=>Value[i];

public static A213178Inst Instance=new A213178Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213179
{
public static readonly long[] Value={ 1L,11L,15L,21L,28L,88L,245L,396L,501L,979L,1218L,1505L,1859L,2802L,3421L,6155L,18669L,26587L,44567L,52779L,62377L,102113L,225638L,307077L,357610L,415910L,650078L,870815L,1006279L,1161760L,2043984L,3544750L,4059132L,6066082L,6924325L,7898238L,13271830L };
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
public class A213179Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213179.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213179Inst : IEnumerable<long>
{
public static readonly long[] Value=A213179.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213179.Bytes);
public long this[int i]=>Value[i];

public static A213179Inst Instance=new A213179Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213180
{
public static readonly long[] Value={ 0L,1L,3L,7L,16L,28L,59L,91L,170L,269L,450L,655L,1162L,1602L,2527L,3793L,5805L,8034L,12660L,17131L,26484L,37384L,53738L,73504L,114683L,153613L,221225L,313339L,453769L,609179L,927968L,1223909L,1804710L,2522264L,3539835L,4855420L,7439870L,9765555L,14009545L };
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
public class A213180Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213180.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213180Inst : IEnumerable<long>
{
public static readonly long[] Value=A213180.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213180.Bytes);
public long this[int i]=>Value[i];

public static A213180Inst Instance=new A213180Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213181
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,1L,3L,1L,4L,1L,3L,2L,2L,3L,2L,1L,3L,4L,4L,2L,1L,3L,2L,2L,5L,2L,17L,4L,4L,2L,16L,1L,6L,3L,2L,5L,4L,4L,6L,2L,17L,1L,6L,4L,4L,2L,16L,2L,5L,5L,5L,3L,2L,17L,17L,4L,7L,4L,6L,3L,3L,16L,15L,1L,6L,6L,5L,4L,3L,2L,16L,5L,18L,4L,2L,5L,5L,6L,6L,2L,4L,17L,17L };
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
public class A213181Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213181.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213181Inst : IEnumerable<long>
{
public static readonly long[] Value=A213181.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213181.Bytes);
public long this[int i]=>Value[i];

public static A213181Inst Instance=new A213181Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213182
{
public static readonly long[] Value={ 10100L,10101L,10102L,10103L,10104L,10105L,10106L,10107L,10108L,10109L,10110L,10111L,10112L,10113L,10114L,10115L,10116L,10117L,10118L,10119L,10120L,10121L,10122L,10123L,10124L,10125L,10126L,10127L,10128L,10129L,10130L,10131L,10132L,10133L,10134L,10135L,10136L,10137L,10138L,10139L,10140L };
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
public class A213182Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213182.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213182Inst : IEnumerable<long>
{
public static readonly long[] Value=A213182.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213182.Bytes);
public long this[int i]=>Value[i];

public static A213182Inst Instance=new A213182Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213183
{
public static readonly long[] Value={ 1L,1L,2L,3L,2L,3L,4L,5L,3L,4L,5L,6L,7L,4L,5L,6L,7L,8L,9L,5L,6L,7L,8L,9L,10L,11L,6L,7L,8L,9L,10L,11L,12L,13L,7L,8L,9L,10L,11L,12L,13L,14L,15L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,11L,12L };
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
public class A213183Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213183.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213183Inst : IEnumerable<long>
{
public static readonly long[] Value=A213183.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213183.Bytes);
public long this[int i]=>Value[i];

public static A213183Inst Instance=new A213183Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213184
{
public static readonly long[] Value={ 10100L,10101L,10102L,10103L,10104L,10105L,10106L,10107L,10108L,10109L,10110L,10111L,10112L,10113L,10114L,10115L,10116L,10117L,10118L,10119L,10120L,10121L,10122L,10123L,10124L,10125L,10126L,10127L,10128L,10129L,10130L,10131L,10132L,10133L,10134L,10135L,10136L,10137L,10138L,10139L,10140L };
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
public class A213184Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213184.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213184Inst : IEnumerable<long>
{
public static readonly long[] Value=A213184.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213184.Bytes);
public long this[int i]=>Value[i];

public static A213184Inst Instance=new A213184Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213185
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,2L,0L,0L,1L,1L,0L,0L,2L,3L,0L,0L,3L,1L,0L,0L,1L,2L,0L,0L,1L,1L,0L,0L,3L,4L,0L,0L,2L,1L,2L,0L,1L,2L,0L,0L,1L,1L,1L,0L,2L,3L,0L,0L,2L,1L,0L,0L,1L,2L,0L,0L,2L,1L,1L,0L,4L,5L,0L,0L,3L,1L,1L,0L,1L,2L,0L,0L,1L,1L,1L,0L,2L,3L,0L,0L,5L,1L,0L,0L,1L,2L };
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
public class A213185Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213185.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213185Inst : IEnumerable<long>
{
public static readonly long[] Value=A213185.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213185.Bytes);
public long this[int i]=>Value[i];

public static A213185Inst Instance=new A213185Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213186
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,7L,0L,9L,0L,0L,0L,16L,0L,5L,0L,9L,0L,0L,0L,0L,0L,16L,9L,0L,0L,0L,0L,9L,0L,19L,16L,0L,0L,0L,0L,0L,0L,14L,9L,0L,0L,0L,16L,20L,0L,9L,0L,106L,0L,0L,0L,0L,0L,17L,0L,95L,0L,0L,16L,23L,0L,12L,9L,0L,0L,0L,0L,0L,0L,20L,0L,27L,0L,0L,0L };
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
public class A213186Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213186.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213186Inst : IEnumerable<long>
{
public static readonly long[] Value=A213186.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213186.Bytes);
public long this[int i]=>Value[i];

public static A213186Inst Instance=new A213186Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213187
{
public static readonly long[] Value={ 2L,2L,5L,5L,4L,4L,6L,6L,13L,6L,13L,13L,17L,17L,10L,17L,10L,10L,12L,12L,16L,12L,29L,16L,29L,16L,37L,29L,16L,16L,41L,37L,37L,41L,41L,37L,24L,41L,22L,41L,22L,22L,24L,24L,61L,24L,53L,61L,53L,30L,61L,53L,61L,34L,30L,61L,73L,30L,61L,61L,36L,34L,34L,36L,36L,34L,42L,36L,73L,36L,73L,73L,89L,40L,40L,42L,42L,40L,89L,42L,97L,42L,89L,97L,89L,101L,97L,89L,97L,52L,101L,97L,109L,101L,52L,97L,54L,101L,52L,101L };
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
public class A213187Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213187.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213187Inst : IEnumerable<long>
{
public static readonly long[] Value=A213187.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213187.Bytes);
public long this[int i]=>Value[i];

public static A213187Inst Instance=new A213187Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213188
{
public static readonly long[] Value={ 10L,45L,136L,325L,435L,595L,630L,666L,780L,1225L,2080L,2145L,3321L,5050L,5565L,5886L,6216L,7381L,7503L,9316L,10440L,11026L,11175L,12246L,13530L,14196L,14365L,14535L,15753L,16653L,18915L,19306L,24310L,25425L,32896L,33670L,39060L,41905L,42195L,49141L,50721L,52650L };
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
public class A213188Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213188.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213188Inst : IEnumerable<long>
{
public static readonly long[] Value=A213188.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213188.Bytes);
public long this[int i]=>Value[i];

public static A213188Inst Instance=new A213188Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213189
{
public static readonly long[] Value={ 6L,36L,91L,120L,210L,253L,300L,378L,528L,630L,1176L,2016L,2346L,3003L,3240L,3828L,4560L,4656L,4950L,5460L,6105L,6903L,7140L,7260L,8778L,10296L,11628L,13530L,14028L,14196L,15400L,17766L,19110L,23220L,23436L,24310L,25200L,26796L,32640L,34980L,41616L,43365L,44253L,52326L,55278L };
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
public class A213189Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213189.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213189Inst : IEnumerable<long>
{
public static readonly long[] Value=A213189.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213189.Bytes);
public long this[int i]=>Value[i];

public static A213189Inst Instance=new A213189Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213190
{
public static readonly BigInteger[] Value={ 1L,1L,5L,18L,87L,489L,3195L,23832L,200241L,1873665L,19337373L,218332098L,2677997295L,35468961129L,504599447691L,7675398598752L,124320175923105L,2136469186489041L,38829405884572053L,744168119366336130L,14999850604980438759UL,BigInteger.Parse("317229367062688222329") };
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
public class A213190Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213190.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213190Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A213190.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213190.Bytes);
public BigInteger this[int i]=>Value[i];

public static A213190Inst Instance=new A213190Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213191
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,3L,0L,1L,4L,6L,0L,1L,6L,9L,12L,0L,1L,10L,17L,20L,20L,0L,1L,18L,39L,44L,35L,35L,0L,1L,34L,101L,122L,87L,66L,54L,0L,1L,66L,279L,392L,287L,180L,105L,86L,0L,1L,130L,797L,1370L,1119L,660L,311L,176L,128L,0L,1L,258L,2319L,5024L,4775L,2904L,1281L,558L,270L,192L };
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
public class A213191Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213191.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213191Inst : IEnumerable<long>
{
public static readonly long[] Value=A213191.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213191.Bytes);
public long this[int i]=>Value[i];

public static A213191Inst Instance=new A213191Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213192
{
public static readonly BigInteger[] Value={ 1L,1L,4L,25L,204L,2024L,23560L,315147L,4777932L,81249562L,1536125144L,32033803936L,731461308600L,18165906647652L,487702581895824L,14076885317410829L,434705720055275532L,14300349927653656920UL,BigInteger.Parse("499229708336982490936"),BigInteger.Parse("18432449956359308918034"),BigInteger.Parse("717597821570439742670440") };
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
public class A213192Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213192.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213192Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A213192.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213192.Bytes);
public BigInteger this[int i]=>Value[i];

public static A213192Inst Instance=new A213192Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213193
{
public static readonly BigInteger[] Value={ 1L,3124L,191757120L,49208861869440L,BigInteger.Parse("33030777426968816640"),BigInteger.Parse("45829974166034718596428800"),BigInteger.Parse("114009204539207742166715857223680"),BigInteger.Parse("462192193445890293982679086838571270144"),BigInteger.Parse("2851153321165202191241172917762717987236478976") };
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
public class A213193Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213193.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213193Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A213193.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213193.Bytes);
public BigInteger this[int i]=>Value[i];

public static A213193Inst Instance=new A213193Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213194
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,3L,1L,1L,2L,2L,3L,3L,4L,4L,5L,1L,1L,2L,2L,3L,3L,4L,4L,5L,5L,6L,6L,7L,1L,1L,2L,2L,3L,3L,4L,4L,5L,5L,6L,6L,7L,7L,8L,8L,9L,1L,1L,2L,2L,3L,3L,4L,4L,5L,5L,6L,6L,7L,7L,8L,8L,9L,9L,10L,10L,11L,1L,1L,2L,2L,3L,3L,4L,4L,5L,5L,6L,6L,7L,7L,8L,8L,9L,9L,10L };
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
public class A213194Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213194.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213194Inst : IEnumerable<long>
{
public static readonly long[] Value=A213194.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213194.Bytes);
public long this[int i]=>Value[i];

public static A213194Inst Instance=new A213194Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213195
{
public static readonly long[] Value={ 1L,3L,2L,1L,2L,1L,5L,4L,3L,4L,3L,2L,1L,2L,1L,7L,6L,5L,6L,5L,4L,3L,4L,3L,2L,1L,2L,1L,9L,8L,7L,8L,7L,6L,5L,6L,5L,4L,3L,4L,3L,2L,1L,2L,1L,11L,10L,9L,10L,9L,8L,7L,8L,7L,6L,5L,6L,5L,4L,3L,4L,3L,2L,1L,2L,1L,13L,12L,11L,12L,11L,10L,9L,10L,9L,8L,7L,8L,7L,6L,5L,6L,5L,4L };
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
public class A213195Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213195.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213195Inst : IEnumerable<long>
{
public static readonly long[] Value=A213195.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213195.Bytes);
public long this[int i]=>Value[i];

public static A213195Inst Instance=new A213195Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213196
{
public static readonly long[] Value={ 1L,4L,2L,3L,5L,6L,11L,7L,8L,12L,13L,9L,10L,14L,15L,22L,16L,17L,23L,24L,18L,19L,25L,26L,20L,21L,27L,28L,37L,29L,30L,38L,39L,31L,32L,40L,41L,33L,34L,42L,43L,35L,36L,44L,45L,56L,46L,47L,57L,58L,48L,49L,59L,60L,50L,51L,61L,62L,52L,53L,63L,64L,54L,55L,65L,66L,79L };
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
public class A213196Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213196.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213196Inst : IEnumerable<long>
{
public static readonly long[] Value=A213196.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213196.Bytes);
public long this[int i]=>Value[i];

public static A213196Inst Instance=new A213196Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213197
{
public static readonly long[] Value={ 1L,3L,4L,2L,6L,5L,8L,9L,11L,12L,7L,15L,10L,14L,13L,17L,18L,20L,21L,23L,24L,16L,28L,19L,27L,22L,26L,25L,30L,31L,33L,34L,36L,37L,39L,40L,29L,45L,32L,44L,35L,43L,38L,42L,41L,47L,48L,50L,51L,53L,54L,56L,57L,59L,60L,46L,66L,49L,65L,52L,64L,55L,63L,58L,62L,61L,68L };
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
public class A213197Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213197.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213197Inst : IEnumerable<long>
{
public static readonly long[] Value=A213197.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213197.Bytes);
public long this[int i]=>Value[i];

public static A213197Inst Instance=new A213197Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213198
{
public static readonly long[] Value={ 0L,1L,5L,2L,0L,7L,4L,6L,7L,8L,11L,8L,8L,10L,10L,3L,9L,6L,6L,5L,5L,11L,11L,9L,12L,9L,13L,7L,7L,7L,10L,1L,10L,9L,9L,6L,6L,6L,10L,7L,11L,7L,8L,4L,4L,4L,10L,12L,10L,10L,10L,12L,12L,7L,7L,7L,2L,7L,2L,7L,7L,15L,15L,8L,14L,14L,14L,11L,11L,11L,14L,12L,12L,12L,11L,12L };
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
public class A213198Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213198.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213198Inst : IEnumerable<long>
{
public static readonly long[] Value=A213198.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213198.Bytes);
public long this[int i]=>Value[i];

public static A213198Inst Instance=new A213198Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213199
{
public static readonly long[] Value={ 3L,5L,6L,7L,9L,10L,11L,12L,13L,14L,15L,17L,18L,19L,21L,22L,23L,25L,26L,27L,28L,29L,30L,31L,33L,34L,35L,36L,37L,38L,39L,41L,42L,43L,44L,45L,46L,47L,49L,50L,51L,53L,54L,55L,57L,58L,59L,60L,61L,62L,63L,65L,66L,67L,69L,70L,71L,73L,74L,75L,76L,77L,78L,79L,81L,82L,83L };
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
public class A213199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213199Inst : IEnumerable<long>
{
public static readonly long[] Value=A213199.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213199.Bytes);
public long this[int i]=>Value[i];

public static A213199Inst Instance=new A213199Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213200
{
public static readonly long[] Value={ 1L,2L,8L,180L,135602L,140706863394L };
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
public class A213200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213200Inst : IEnumerable<long>
{
public static readonly long[] Value=A213200.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213200.Bytes);
public long this[int i]=>Value[i];

public static A213200Inst Instance=new A213200Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213201
{
public static readonly long[] Value={ 3L,4L,4L,0L,2L,3L,6L,9L,6L,7L,1L,2L,3L,2L,0L,6L,2L,4L,8L,8L,2L,5L,2L,3L,8L,7L,6L,0L,0L,3L,9L,9L,4L,4L,4L,0L,9L,1L,0L,6L,7L,7L,2L,8L,5L,8L,1L,4L,0L,5L,9L,9L,8L,8L,6L,3L,1L,4L,3L,3L,7L,7L,1L,8L,2L,9L,8L,1L,8L,0L,8L,1L,3L,3L,1L,6L,7L,2L,9L,2L,8L,4L,8L,4L,0L,4L,5L,1L,5L,3L,6L,8L,5L,2L,9L,2L,9L,1L,8L,8L,3L,7L,2L,6L,1L };
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
public class A213201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213201Inst : IEnumerable<long>
{
public static readonly long[] Value=A213201.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213201.Bytes);
public long this[int i]=>Value[i];

public static A213201Inst Instance=new A213201Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213202
{
public static readonly long[] Value={ 0L,0L,1L,2L,2L,3L,3L,2L,2L,3L,1L,2L,2L,2L,3L,2L,1L,3L,2L,1L,3L,1L,3L,5L,2L,2L,3L,2L,3L,4L,4L,4L,2L,3L,3L,3L,3L,2L,1L,2L,4L,5L,4L,4L,4L,2L,3L,3L,4L,4L,3L,2L,1L,4L,6L,6L,4L,4L,4L,4L,4L,4L,4L,2L,3L,3L,5L,6L,2L,2L,1L,4L,4L,5L,3L,3L,1L,2L,5L,4L,5L,5L,2L,4L,5L,7L,2L,5L,1L,5L,4L,4L,4L,6L,3L,2L,6L,4L,5L,4L };
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
public class A213202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213202Inst : IEnumerable<long>
{
public static readonly long[] Value=A213202.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213202.Bytes);
public long this[int i]=>Value[i];

public static A213202Inst Instance=new A213202Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213203
{
public static readonly BigInteger[] Value={ -1L,-1L,3L,132L,4260L,172440L,9069480L,609618240L,51209444160L,5267273961600L,651825357321600L,95601055094899200L,16405141092269529600UL,BigInteger.Parse("3257166195621552614400"),BigInteger.Parse("741005309513165913216000") };
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
public class A213203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213203Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A213203.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213203.Bytes);
public BigInteger this[int i]=>Value[i];

public static A213203Inst Instance=new A213203Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213204
{
public static readonly long[] Value={ 1L,1L,6L,1L,3L,4L,13L,1L,14L,2L,9L,2L,4L,9L,12L,1L,5L,8L,11L,1L,3L,5L,8L,1L,11L,2L,103L,4L,6L,9L,98L,1L,11L,3L,6L,3L,5L,6L,18L,1L,98L,2L,11L,2L,4L,6L,93L,1L,6L,5L,8L,1L,3L,96L,99L,1L,10L,2L,12L,5L,7L,92L,94L,1L,6L,4L,7L,1L,3L,4L,88L,1L,98L,2L,8L,2L,4L,11L,14L };
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
public class A213204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213204Inst : IEnumerable<long>
{
public static readonly long[] Value=A213204.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213204.Bytes);
public long this[int i]=>Value[i];

public static A213204Inst Instance=new A213204Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213205
{
public static readonly long[] Value={ 1L,5L,4L,2L,3L,6L,10L,9L,14L,13L,7L,8L,11L,12L,15L,19L,18L,23L,22L,27L,26L,16L,17L,20L,21L,24L,25L,28L,32L,31L,36L,35L,40L,39L,44L,43L,29L,30L,33L,34L,37L,38L,41L,42L,45L,49L,48L,53L,52L,57L,56L,61L,60L,65L,64L,46L,47L,50L,51L,54L,55L,58L,59L,62L,63L,66L,70L };
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
public class A213205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213205Inst : IEnumerable<long>
{
public static readonly long[] Value=A213205.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213205.Bytes);
public long this[int i]=>Value[i];

public static A213205Inst Instance=new A213205Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213206
{
public static readonly long[] Value={ 1L,1L,1L,3L,4L,5L,6L,12L,15L,20L,21L,30L,60L,60L,84L,105L,140L,140L,210L,420L,420L,420L,420L,840L,840L,1260L,1260L,1540L,1540L,2520L,4620L,4620L,5460L,5460L,9240L,9240L,13860L,13860L,16380L,16380L,27720L,27720L,32760L,60060L,60060L,60060L,60060L,120120L,120120L,180180L,180180L,180180L };
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
public class A213206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213206Inst : IEnumerable<long>
{
public static readonly long[] Value=A213206.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213206.Bytes);
public long this[int i]=>Value[i];

public static A213206Inst Instance=new A213206Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213207
{
public static readonly long[] Value={ 1L,1L,1L,3L,5L,9L,13L,19L,25L,35L,43L,55L,65L,79L,91L,111L,127L,149L,167L,193L,217L,249L,273L,311L,339L,383L,419L,463L,501L,551L,591L,643L,693L,751L,799L,869L,925L,995L,1057L,1133L,1199L,1281L,1347L,1439L,1515L,1615L,1697L,1801L,1883L,2001L,2101L,2219L,2313L };
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
public class A213207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213207Inst : IEnumerable<long>
{
public static readonly long[] Value=A213207.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213207.Bytes);
public long this[int i]=>Value[i];

public static A213207Inst Instance=new A213207Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213208
{
public static readonly long[] Value={ 1L,1L,1L,3L,5L,9L,11L,19L,23L,33L,39L,51L,57L,75L,87L,103L,117L,143L,155L,187L,207L,235L,259L,297L,319L,363L,395L,441L,473L,525L,555L,615L,659L,721L,765L,831L,875L,959L,1017L,1091L,1147L,1239L,1291L,1397L,1467L,1553L,1631L,1743L,1813L,1937L,2023L,2141L,2233L,2379L,2465L };
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
public class A213208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213208Inst : IEnumerable<long>
{
public static readonly long[] Value=A213208.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213208.Bytes);
public long this[int i]=>Value[i];

public static A213208Inst Instance=new A213208Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213209
{
public static readonly long[] Value={ 0L,1L,1L,0L,0L,2L,2L,0L,2L,1L,1L,1L,0L,3L,3L,0L,0L,3L,2L,0L,0L,2L,2L,1L,2L,1L,24L,2L,1L,4L,23L,0L,2L,1L,1L,2L,2L,3L,5L,0L,23L,1L,3L,1L,0L,3L,22L,1L,2L,3L,2L,0L,0L,25L,24L,2L,3L,2L,4L,3L,2L,24L,24L,0L,2L,3L,3L,0L,0L,2L,21L,2L,24L,3L,1L,2L,1L,6L,5L,0L,2L,24L,23L,0L };
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
public class A213209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213209Inst : IEnumerable<long>
{
public static readonly long[] Value=A213209.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213209.Bytes);
public long this[int i]=>Value[i];

public static A213209Inst Instance=new A213209Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213210
{
public static readonly long[] Value={ 3L,5L,11L,29L,59L,4091L,262139L };
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
public class A213210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213210Inst : IEnumerable<long>
{
public static readonly long[] Value=A213210.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213210.Bytes);
public long this[int i]=>Value[i];

public static A213210Inst Instance=new A213210Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213211
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,2L,3L,1L,1L,1L,1L,2L,3L,4L,1L,1L,1L,1L,3L,3L,4L,5L,1L,1L,1L,1L,3L,6L,4L,5L,6L,1L,1L,1L,1L,3L,6L,10L,5L,6L,7L,1L,1L,1L,1L,4L,6L,10L,15L,6L,7L,8L,1L,1L,1L,1L,4L,10L,10L,15L,21L,7L,8L,9L,1L,1L,1L,1L,4L,10L,20L,15L,21L,28L,8L,9L,10L,1L,1L,1L };
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
public class A213211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213211Inst : IEnumerable<long>
{
public static readonly long[] Value=A213211.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213211.Bytes);
public long this[int i]=>Value[i];

public static A213211Inst Instance=new A213211Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213212
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,5L,6L,10L,12L,17L,20L,26L,29L,38L,44L,52L,59L,72L,78L,94L,104L,118L,130L,149L,160L,182L,198L,221L,237L,263L,278L,308L,330L,361L,383L,416L,438L,480L,509L,546L,574L,620L,646L,699L,734L,777L,816L,872L,907L,969L,1012L,1071L,1117L,1190L,1233L,1307L,1361L };
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
public class A213212Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213212.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213212Inst : IEnumerable<long>
{
public static readonly long[] Value=A213212.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213212.Bytes);
public long this[int i]=>Value[i];

public static A213212Inst Instance=new A213212Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213213
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,5L,7L,10L,13L,18L,22L,28L,33L,40L,46L,56L,64L,75L,84L,97L,109L,125L,137L,156L,170L,192L,210L,232L,251L,276L,296L,322L,347L,376L,400L,435L,463L,498L,529L,567L,600L,641L,674L,720L,758L,808L,849L,901L,942L,1001L,1051L,1110L,1157L,1225L,1275L };
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
public class A213213Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213213.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213213Inst : IEnumerable<long>
{
public static readonly long[] Value=A213213.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213213.Bytes);
public long this[int i]=>Value[i];

public static A213213Inst Instance=new A213213Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213214
{
public static readonly long[] Value={ 1L,3L,10L,9L,96L,95L,32L,31L,43L,42L,134L,133L,132L,131L,99L,98L,190L,189L,139L,138L,261L,260L,427L,426L,394L,393L,330L,329L,390L,389L,388L,387L,461L,460L,459L,458L,457L,456L,455L,454L,453L,452L,500L,499L,498L,497L,496L,495L,494L,493L,492L,491L,746L,745L,488L };
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
public class A213214Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213214.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213214Inst : IEnumerable<long>
{
public static readonly long[] Value=A213214.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213214.Bytes);
public long this[int i]=>Value[i];

public static A213214Inst Instance=new A213214Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213215
{
public static readonly long[] Value={ 3L,7L,15L,27L,27L,127L,255L,511L,1023L,1819L,4095L,4255L,16383L,32767L,65535L,77671L,262143L,459759L,1048575L };
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
public class A213215Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213215.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213215Inst : IEnumerable<long>
{
public static readonly long[] Value=A213215.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213215.Bytes);
public long this[int i]=>Value[i];

public static A213215Inst Instance=new A213215Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213216
{
public static readonly long[] Value={ 47L,401L,509L,8609L };
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
public class A213216Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213216.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213216Inst : IEnumerable<long>
{
public static readonly long[] Value=A213216.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213216.Bytes);
public long this[int i]=>Value[i];

public static A213216Inst Instance=new A213216Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213217
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,21L,11L,12L,12L,12L,12L,12L,12L,12L,12L,21L,21L,11L,12L,12L,12L,12L,12L,12L,12L,21L,21L,21L,11L,12L,12L,12L,12L,12L,12L,21L,21L,21L,21L,11L,12L,12L,12L,12L,12L,21L,21L,21L,21L,21L,11L,12L,12L,12L,12L,21L,21L,21L,21L,21L,21L,11L,12L,12L,12L,21L,21L,21L,21L,21L,21L,21L,11L,12L,12L,21L,21L,21L,21L,21L,21L,21L,21L,11L,12L,21L,21L,21L,21L,21L,21L,21L,21L,21L,11L,211L,212L,213L,213L,213L,213L,213L,213L,213L,213L,221L,111L,112L,112L,112L,112L,112L,112L,112L,112L };
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
public class A213217Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213217.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213217Inst : IEnumerable<long>
{
public static readonly long[] Value=A213217.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213217.Bytes);
public long this[int i]=>Value[i];

public static A213217Inst Instance=new A213217Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213218
{
public static readonly long[] Value={ 20L,192L,352L,104L,736L,264L,64L,464L,1088L,640L,1344L,800L,3136L,896L,1952L,2496L,22272L,2752L,1728L,1504L,8576L,4480L,3520L,12672L,7552L,4160L,3840L,11520L,2304L,19712L,9088L,8000L,10880L,14592L,11904L,4864L,21248L,8448L,17664L,26624L,10112L,6528L,5696L,6208L,24704L,22912L,28480L,9536L,39168L,41216L,36736L };
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
public class A213218Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213218.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213218Inst : IEnumerable<long>
{
public static readonly long[] Value=A213218.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213218.Bytes);
public long this[int i]=>Value[i];

public static A213218Inst Instance=new A213218Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213219
{
public static readonly long[] Value={ 1L,2L,4L,5L,7L,8L,10L,11L,13L,14L,16L,17L,19L,21L,22L,24L,25L,27L,28L,30L,31L,33L,34L,36L,38L,39L,41L,42L,44L,45L,47L,48L,50L,51L,53L,55L,56L,58L,59L,61L,62L,64L,65L,67L,68L,70L,71L,73L,75L,76L,78L,79L,81L,82L,84L,85L,87L,88L,90L,92L,93L,95L,96L,98L,99L,101L,102L,104L,105L,107L,108L,110L,112L,113L,115L,116L,118L,119L,121L,122L,124L,125L,127L,129L };
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
public class A213219Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213219.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213219Inst : IEnumerable<long>
{
public static readonly long[] Value=A213219.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213219.Bytes);
public long this[int i]=>Value[i];

public static A213219Inst Instance=new A213219Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213220
{
public static readonly long[] Value={ 1L,7L,9L,15L,23L,26L,31L,34L,41L,47L,52L,57L,63L,68L,76L,82L,88L,95L,100L,106L,110L,118L,124L,133L,139L,145L,152L,159L,167L,174L,184L,191L,197L,204L,209L,218L,224L,236L,243L,252L,261L,270L,276L,284L,291L,299L,307L,319L,326L,334L,340L,348L,355L,363L,370L,377L,384L,391L,397L,405L,415L,423L,431L,440L,447L,454L,462L,472L };
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
public class A213220Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213220.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213220Inst : IEnumerable<long>
{
public static readonly long[] Value=A213220.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213220.Bytes);
public long this[int i]=>Value[i];

public static A213220Inst Instance=new A213220Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213221
{
public static readonly long[] Value={ 1L,2L,1L,6L,3L,1L,18L,10L,4L,1L,58L,32L,15L,5L,1L,192L,106L,52L,21L,6L,1L,650L,357L,180L,79L,28L,7L,1L,2232L,1222L,624L,288L,114L,36L,8L,1L,7746L,4230L,2178L,1035L,439L,158L,45L,9L,1L,27096L,14770L,7648L,3706L,1642L,643L,212L,55L,10L,1L };
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
public class A213221Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213221.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213221Inst : IEnumerable<long>
{
public static readonly long[] Value=A213221.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213221.Bytes);
public long this[int i]=>Value[i];

public static A213221Inst Instance=new A213221Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213222
{
public static readonly long[] Value={ 3L,4L,4L,6L,6L,8L,8L,10L,10L,12L,12L,14L,14L,16L,16L,18L,18L,20L,20L,22L,22L,24L,24L,26L,26L,28L,28L,30L,30L,32L,32L,34L,34L,36L,36L,38L,38L,40L,40L,42L,42L,44L,44L,46L,46L,48L,48L,50L,50L,52L,52L,54L,54L,56L,56L,58L,58L,60L,60L,62L,62L,64L,64L,66L,66L,68L,68L,70L,70L,72L,72L,74L,74L,76L,76L,78L,78L,80L,80L,82L,82L,84L };
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
public class A213222Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213222.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213222Inst : IEnumerable<long>
{
public static readonly long[] Value=A213222.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213222.Bytes);
public long this[int i]=>Value[i];

public static A213222Inst Instance=new A213222Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213223
{
public static readonly long[] Value={ 1L,20L,120L,1030L,10040L,100050L,1000060L,10000070L,100000080L,1000000090L,10000000100L,100000000110L,1000000000120L,10000000000130L,100000000000140L,1000000000000150L,10000000000000160L,100000000000000170L };
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
public class A213223Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213223.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213223Inst : IEnumerable<long>
{
public static readonly long[] Value=A213223.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213223.Bytes);
public long this[int i]=>Value[i];

public static A213223Inst Instance=new A213223Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213224
{
public static readonly long[] Value={ 1L,1L,3L,1L,4L,7L,1L,3L,13L,5L,1L,4L,31L,5L,31L,1L,3L,9L,13L,11L,9L,1L,7L,7L,5L,11L,7L,127L,1L,3L,9L,16L,2801L,7L,1093L,17L,1L,4L,307L,5L,25L,36L,19531L,32L,73L,1L,3L,27L,5L,30941L,9L,29L,32L,757L,11L,1L,3L,7L,16L,88741L,63L,43L,64L,19L,44L,23L };
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
public class A213224Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213224.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213224Inst : IEnumerable<long>
{
public static readonly long[] Value=A213224.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213224.Bytes);
public long this[int i]=>Value[i];

public static A213224Inst Instance=new A213224Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213225
{
public static readonly long[] Value={ 1L,1L,2L,6L,20L,76L,313L,1375L,6337L,30243L,148129L,739172L,3737993L,19077868L,97955307L,504707999L,2604312205L,13436676965L,69229324721L,355854322633L,1823672937884L,9314227843463L,47406130512872L,240498260267049L,1216833204738419L,6146116088495029L };
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
public class A213225Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213225.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213225Inst : IEnumerable<long>
{
public static readonly long[] Value=A213225.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213225.Bytes);
public long this[int i]=>Value[i];

public static A213225Inst Instance=new A213225Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213226
{
public static readonly long[] Value={ 1L,1L,2L,7L,27L,122L,607L,3208L,17688L,99803L,571238L,3292738L,19001315L,109303307L,624615928L,3537913240L,19843769848L,110273489737L,608712132055L,3355449334452L,18624818099047L,105191779542849L,610586100129734L,3662333209225714L,22652502251884322L };
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
public class A213226Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213226.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213226Inst : IEnumerable<long>
{
public static readonly long[] Value=A213226.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213226.Bytes);
public long this[int i]=>Value[i];

public static A213226Inst Instance=new A213226Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213227
{
public static readonly long[] Value={ 1L,1L,2L,8L,35L,181L,1042L,6301L,39435L,249744L,1585386L,10027385L,62696192L,385398251L,2322152120L,13727653882L,80274175978L,472701550856L,2883417403654L,18796497074750L,132728456810968L,995480740265410L,7605881152587204L,56821415293287735L,403362682583930224L };
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
public class A213227Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213227.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213227Inst : IEnumerable<long>
{
public static readonly long[] Value=A213227.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213227.Bytes);
public long this[int i]=>Value[i];

public static A213227Inst Instance=new A213227Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213228
{
public static readonly long[] Value={ 1L,1L,3L,14L,73L,440L,2862L,19991L,146939L,1125413L,8896018L,72067978L,595097838L,4987609871L,42290465703L,361845473658L,3117830204185L,27009650432888L,234932107635587L,2049479335366836L,17915253987741538L,156799716352350344L,1373180896765862962L };
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
public class A213228Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213228.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213228Inst : IEnumerable<long>
{
public static readonly long[] Value=A213228.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213228.Bytes);
public long this[int i]=>Value[i];

public static A213228Inst Instance=new A213228Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213229
{
public static readonly ulong[] Value={ 1L,1L,3L,16L,93L,649L,4924L,40221L,344817L,3058115L,27798895L,257009431L,2404734586L,22679499148L,214947515333L,2042353663088L,19417906390395L,184458621283607L,1748712359825873L,16530801697256737L,155736745914813741L,1461877902947680987L,13674142992787617967UL };
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
public class A213229Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213229.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213229Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A213229.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213229.Bytes);
public ulong this[int i]=>Value[i];

public static A213229Inst Instance=new A213229Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213230
{
public static readonly BigInteger[] Value={ 1L,1L,3L,18L,115L,902L,7722L,70784L,678251L,6670586L,66851992L,677328214L,6903177354L,70490174298L,718856047396L,7304677030708L,73837797474235L,741722190452840L,7402780597473820L,73459355234486763L,726095774886910232L,7170907377415662763L,BigInteger.Parse("71063833561266044578") };
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
public class A213230Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213230.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213230Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A213230.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213230.Bytes);
public BigInteger this[int i]=>Value[i];

public static A213230Inst Instance=new A213230Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213231
{
public static readonly BigInteger[] Value={ 1L,1L,4L,25L,176L,1431L,12526L,117850L,1167446L,12080563L,129326575L,1422908670L,15999766613L,183070661566L,2124252427416L,24929036429880L,295250330398281L,3523043486823439L,42294807342916249L,510274778010082846L,6181011777164665559L,BigInteger.Parse("75112032752942278141") };
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
public class A213231Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213231.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213231Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A213231.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213231.Bytes);
public BigInteger this[int i]=>Value[i];

public static A213231Inst Instance=new A213231Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213232
{
public static readonly BigInteger[] Value={ 1L,1L,4L,28L,215L,1983L,19789L,213698L,2426851L,28661509L,348287354L,4322627557L,54508747790L,695534616050L,8953637420349L,116002300640637L,1509724588732027L,19707310304585212L,257698683361191598L,3372154116182404890L,BigInteger.Parse("44121356408759264549") };
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
public class A213232Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213232.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213232Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A213232.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213232.Bytes);
public BigInteger this[int i]=>Value[i];

public static A213232Inst Instance=new A213232Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213233
{
public static readonly BigInteger[] Value={ 1L,1L,5L,39L,345L,3512L,38431L,451620L,5587237L,72275004L,968509140L,13361356169L,188704259571L,2716467168169L,39716842554828L,588125693790055L,8800638181341593L,132838773216409675L,2019626662710709088L,BigInteger.Parse("30891440565153652705"),BigInteger.Parse("474899505740289874276") };
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
public class A213233Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213233.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213233Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A213233.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213233.Bytes);
public BigInteger this[int i]=>Value[i];

public static A213233Inst Instance=new A213233Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213234
{
public static readonly long[] Value={ 2L,1L,1L,-2L,1L,-3L,1L,-4L,2L,1L,-5L,5L,1L,-6L,9L,-2L,1L,-7L,14L,-7L,1L,-8L,20L,-16L,2L,1L,-9L,27L,-30L,9L,1L,-10L,35L,-50L,25L,-2L,1L,-11L,44L,-77L,55L,-11L,1L,-12L,54L,-112L,105L,-36L,2L,1L,-13L,65L,-156L,182L,-91L,13L,1L,-14L,77L,-210L,294L,-196L,49L,-2L,1L,-15L,90L,-275L,450L,-378L,140L,-15L };
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
public class A213234Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213234.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213234Inst : IEnumerable<long>
{
public static readonly long[] Value=A213234.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213234.Bytes);
public long this[int i]=>Value[i];

public static A213234Inst Instance=new A213234Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213235
{
public static readonly long[] Value={ 2L,1L,1L,-2L,1L,-3L,1L,-4L,2L,1L,-5L,5L,1L,-6L,4L,2L,1L,-7L,1L,-7L };
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
public class A213235Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213235.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213235Inst : IEnumerable<long>
{
public static readonly long[] Value=A213235.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213235.Bytes);
public long this[int i]=>Value[i];

public static A213235Inst Instance=new A213235Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213236
{
public static readonly BigInteger[] Value={ 1L,-2L,9L,-64L,625L,-7776L,117649L,-2097152L,43046721L,-1000000000L,25937424601L,-743008370688L,23298085122481L,-793714773254144L,29192926025390625L,-1152921504606846976L,BigInteger.Parse("48661191875666868481"),BigInteger.Parse("-2185911559738696531968"),BigInteger.Parse("104127350297911241532841") };
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
public class A213236Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213236.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213236Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A213236.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213236.Bytes);
public BigInteger this[int i]=>Value[i];

public static A213236Inst Instance=new A213236Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213237
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,1L,1L,1L,2L,1L,2L,1L,3L,3L,2L,3L,1L,2L,3L,3L,2L,2L,4L,3L,5L,3L,2L,3L,3L,4L,4L,5L,1L,3L,2L,4L,4L,6L,3L,3L,2L,3L,4L,9L,3L,4L,9L,4L,3L,5L,4L,4L,4L,6L,6L,5L,5L,4L,7L,4L,8L,6L,4L,7L,3L,6L,5L,3L,4L,6L,5L,4L,6L,6L,5L,7L,4L,6L,9L,7L,6L,6L,8L,4L,7L,5L };
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
public class A213237Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213237.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213237Inst : IEnumerable<long>
{
public static readonly long[] Value=A213237.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213237.Bytes);
public long this[int i]=>Value[i];

public static A213237Inst Instance=new A213237Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213238
{
public static readonly long[] Value={ 1L,3L,8L,12L,18L,24L,32L,40L,42L,50L,60L,64L,72L,84L,88L,90L,98L,99L,105L,112L,120L,128L,130L,135L,144L,162L,168L,180L,182L,192L,200L,208L,210L,220L,231L,242L,252L,264L,266L,272L,280L,288L,294L,300L,312L,315L,320L,324L,330L,338L,340L,360L,364L,378L,392L,400L };
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
public class A213238Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213238.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213238Inst : IEnumerable<long>
{
public static readonly long[] Value=A213238.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213238.Bytes);
public long this[int i]=>Value[i];

public static A213238Inst Instance=new A213238Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213239
{
public static readonly long[] Value={ 5L,8L,64L,691L,1779L,2851L,6361L,9066L,9606L,9771L,10789L,10996L,18996L,21481L,22569L,27529L,27691L,31516L,36709L,36776L,42649L,48651L,53296L,56586L,58749L,60369L,64794L,72889L,76754L,78766L,79374L,79896L,80989L,86596L,90606L,90879L,92766L,96171L,98979L,108529L };
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
public class A213239Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213239.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213239Inst : IEnumerable<long>
{
public static readonly long[] Value=A213239.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213239.Bytes);
public long this[int i]=>Value[i];

public static A213239Inst Instance=new A213239Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213240
{
public static readonly long[] Value={ 4L,22L,27L,54L,56L,81L,94L,108L,121L,135L,166L,202L,216L,243L,245L,260L,265L,266L,272L,274L,308L,344L,346L,355L,382L,405L,445L,454L,459L,513L,517L,518L,526L,562L,567L,594L,634L,648L,675L,702L,706L,729L,784L,806L,832L,837L,841L,891L,913L,920L,922L,945L,950L,972L };
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
public class A213240Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213240.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213240Inst : IEnumerable<long>
{
public static readonly long[] Value=A213240.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213240.Bytes);
public long this[int i]=>Value[i];

public static A213240Inst Instance=new A213240Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213241
{
public static readonly long[] Value={ 16L,20L,64L,108L,135L,164L,352L,432L,729L,1024L,1107L,2376L,2916L,6912L,12500L,15625L,16038L,16384L,19683L,43692L,46656L,47616L,50000L,84375L,110592L,128125L,188228L,275000L,294921L,314928L,321408L,337500L,746496L,800000L,1270539L,1856250L };
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
public class A213241Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213241.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213241Inst : IEnumerable<long>
{
public static readonly long[] Value=A213241.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213241.Bytes);
public long this[int i]=>Value[i];

public static A213241Inst Instance=new A213241Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213242
{
public static readonly long[] Value={ 1L,2L,3L,6L,12L,31L,89L,303L,1119L,4649L,20572L,99241L,502622L,2725840L,15424019L,92211327L,571446565L,3716191974L,24920512847L,174169990243L,1251875604302L,9326245177768L,71241318920624L,562221733320241L,4535497053407716L,37677863148632647L,319551379756283637L };
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
public class A213242Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213242.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213242Inst : IEnumerable<long>
{
public static readonly long[] Value=A213242.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213242.Bytes);
public long this[int i]=>Value[i];

public static A213242Inst Instance=new A213242Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213243
{
public static readonly long[] Value={ 1L,1L,7L,5L,31L,21L,127L,85L,511L,341L,2047L,1365L,8191L,5461L,32767L,21845L,131071L,87381L,524287L,349525L,2097151L,1398101L,8388607L,5592405L,33554431L,22369621L,134217727L,89478485L,536870911L,357913941L,2147483647L,1431655765L,8589934591L,5726623061L,34359738367L,22906492245L };
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
public class A213243Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213243.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213243Inst : IEnumerable<long>
{
public static readonly long[] Value=A213243.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213243.Bytes);
public long this[int i]=>Value[i];

public static A213243Inst Instance=new A213243Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213244
{
public static readonly long[] Value={ 1L,3L,7L,3L,31L,63L,127L,51L,511L,1023L,2047L,819L,8191L,16383L,32767L,13107L,131071L,262143L,524287L,209715L,2097151L,4194303L,8388607L,3355443L,33554431L,67108863L,134217727L };
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
public class A213244Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213244.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213244Inst : IEnumerable<long>
{
public static readonly long[] Value=A213244.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213244.Bytes);
public long this[int i]=>Value[i];

public static A213244Inst Instance=new A213244Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213245
{
public static readonly long[] Value={ 1L,3L,1L,15L,31L,9L,127L,255L,73L,1023L,2047L,585L,8191L,16383L,4681L,65535L,131071L,37449L,524287L,1048575L,299593L,4194303L,8388607L,2396745L,33554431L,67108863L,19173961L,268435455L,536870911L,153391689L,2147483647L,4294967295L,1227133513L,17179869183L,34359738367L,9817068105L };
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
public class A213245Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213245.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213245Inst : IEnumerable<long>
{
public static readonly long[] Value=A213245.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213245.Bytes);
public long this[int i]=>Value[i];

public static A213245Inst Instance=new A213245Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213246
{
public static readonly long[] Value={ 1L,1L,7L,5L,31L,7L,127L,85L,511L,341L,2047L,455L,8191L,5461L,32767L,21845L,131071L,29127L,524287L,349525L,2097151L,1398101L,8388607L,1864135L,33554431L,22369621L,134217727L,89478485L,536870911L,119304647L,2147483647L,1431655765L,8589934591L,5726623061L,34359738367L,7635497415L };
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
public class A213246Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213246.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213246Inst : IEnumerable<long>
{
public static readonly long[] Value=A213246.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213246.Bytes);
public long this[int i]=>Value[i];

public static A213246Inst Instance=new A213246Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213247
{
public static readonly long[] Value={ 1L,3L,7L,15L,31L,63L,127L,255L,511L,93L,2047L,4095L,8191L,16383L,32767L,65535L,131071L,262143L,524287L,95325L,2097151L,4194303L,8388607L,16777215L,33554431L,67108863L,134217727L,268435455L,536870911L,97612893L,2147483647L,4294967295L,8589934591L,17179869183L,34359738367L,68719476735L };
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
public class A213247Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213247.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213247Inst : IEnumerable<long>
{
public static readonly long[] Value=A213247.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213247.Bytes);
public long this[int i]=>Value[i];

public static A213247Inst Instance=new A213247Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213248
{
public static readonly long[] Value={ 1L,3L,7L,15L,31L,63L,127L,255L,511L,1023L,2047L,315L,8191L,16383L,32767L,65535L,131071L,262143L,524287L,1048575L,2097151L,4194303L,8388607L,1290555L,33554431L,67108863L,134217727L,268435455L,536870911L,1073741823L,2147483647L,4294967295L,8589934591L,17179869183L,34359738367L,5286113595L };
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
public class A213248Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213248.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213248Inst : IEnumerable<long>
{
public static readonly long[] Value=A213248.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213248.Bytes);
public long this[int i]=>Value[i];

public static A213248Inst Instance=new A213248Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213249
{
public static readonly long[] Value={ 2L,8L,16L,18L,64L,134L,34L,170L,706L,1854L,60L,398L,2346L,13198L,41478L,102L,880L,6832L,55454L,382116L,1424988L };
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
public class A213249Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213249.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213249Inst : IEnumerable<long>
{
public static readonly long[] Value=A213249.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213249.Bytes);
public long this[int i]=>Value[i];

public static A213249Inst Instance=new A213249Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213250
{
public static readonly long[] Value={ 7L,11L,12L,17L,18L,21L,22L,25L,32L,37L,39L,41L,42L,43L,46L,47L,49L,54L,57L,58L,60L,62L,65L,67L,68L,72L,74L,75L,76L,81L,82L,87L,88L,90L,92L,95L,97L,98L,99L,106L,107L,109L,111L,112L,113L,116L,117L,120L,122L,123L,125L,126L,128L,130L,132L,136L,137L };
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
public class A213250Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213250.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213250Inst : IEnumerable<long>
{
public static readonly long[] Value=A213250.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213250.Bytes);
public long this[int i]=>Value[i];

public static A213250Inst Instance=new A213250Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213251
{
public static readonly long[] Value={ 1L,1L,2L,3L,3L,4L,3L,4L,4L,4L,4L,4L,4L,5L,4L,5L,5L,5L,4L,5L,5L,5L,5L,5L,4L,5L,5L,6L,5L,5L,5L,5L,5L,5L,5L,6L,5L,6L,5L,5L,5L,6L,6L,5L,5L,6L,6L,6L,6L,6L,5L,6L,6L,6L,5L,6L,6L,6L,6L,6L,6L,6L,5L,6L,6L,6L,6L,6L,5L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,5L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L };
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
public class A213251Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213251.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213251Inst : IEnumerable<long>
{
public static readonly long[] Value=A213251.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213251.Bytes);
public long this[int i]=>Value[i];

public static A213251Inst Instance=new A213251Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213252
{
public static readonly long[] Value={ 1L,1L,2L,-1L,-10L,7L,88L,-68L,-946L,767L,11298L,-9425L,-144024L,122436L,1919440L,-1653776L,-26419778L,22992655L,372670246L,-326863667L,-5358911450L,4729547023L,78264621664L,-69424933968L,-1157715304760L,1031309398852L,17309542787288L,-15474833826028L };
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
public class A213252Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213252.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213252Inst : IEnumerable<long>
{
public static readonly long[] Value=A213252.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213252.Bytes);
public long this[int i]=>Value[i];

public static A213252Inst Instance=new A213252Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213253
{
public static readonly long[] Value={ 1L,2L,3L,3L,4L,4L,4L,4L,4L,4L,4L,4L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,7L,7L,7L,7L,7L,7L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,9L,9L,14L,14L,14L,14L,14L,14L,14L,14L,14L,14L,14L,14L,14L,14L,14L,14L };
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
public class A213253Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213253.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213253Inst : IEnumerable<long>
{
public static readonly long[] Value=A213253.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213253.Bytes);
public long this[int i]=>Value[i];

public static A213253Inst Instance=new A213253Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213254
{
public static readonly long[] Value={ 5460351493L,5149323841L,3565129261L,9957903589L,3325859059L,2585905943L,1584069953L,3319460519L,8659090247L,5835260219L,5576104823L,2357339423L,6189977069L,4041808621L,6217941101L,2179411019L,2487537187L,1131571261L,4398500173L,7388749561L,4621624339L };
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
public class A213254Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213254.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213254Inst : IEnumerable<long>
{
public static readonly long[] Value=A213254.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213254.Bytes);
public long this[int i]=>Value[i];

public static A213254Inst Instance=new A213254Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213255
{
public static readonly long[] Value={ 1L,3L,6L,13L,26L,54L,110L,225L,456L,922L,1862L,3755L,7562L,15214L,30584L,61441L,123362L,247581L,496694L,996148L,1997288L,4003654L,8023886L,16078166L,32212255L,64527754L,129246702L,258848476L,518358122L,1037950430L,2078209982L,4160749569L,8329633544L };
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
public class A213255Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213255.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213255Inst : IEnumerable<long>
{
public static readonly long[] Value=A213255.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213255.Bytes);
public long this[int i]=>Value[i];

public static A213255Inst Instance=new A213255Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A213256
{
public static readonly long[] Value={ 11L,297L,3718L,31185L,204226L,1121505L,5392783L,23338469L,92669720L,342325709L,1188908248L,3913864295L,12292341831L,37027355200L,107438159466L,301384802048L,819876908323L,2168627105469L,5590088317495L,14070545699287L,34643126322519L,83561103925871L,197726516681672L,459545750448675L,1050197489931117L };
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
public class A213256Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A213256.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A213256Inst : IEnumerable<long>
{
public static readonly long[] Value=A213256.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A213256.Bytes);
public long this[int i]=>Value[i];

public static A213256Inst Instance=new A213256Inst();

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