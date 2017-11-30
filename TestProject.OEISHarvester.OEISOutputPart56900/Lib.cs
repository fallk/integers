using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A064445
{
public static readonly long[] Value={ 5L,39L,172L,305L,1182L,1194L,2947L,8936L,24363L,24399L,24417L,64730L,174977L,482028L,9559785L,9559905L,25876016L,25876976L,70113457L,189965322L,189967014L,189967122L,189967266L,189968202L,1394198020L,3779850963L,3779851593L };
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
public class A064445Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064445.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064445Inst : IEnumerable<long>
{
public static readonly long[] Value=A064445.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064445.Bytes);
public long this[int i]=>Value[i];

public static A064445Inst Instance=new A064445Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064446
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,12L,7L,8L,9L,40L,11L,72L,13L,56L,45L,16L,17L,144L,19L,80L,63L,176L,23L,144L,25L,208L,27L,112L,29L,10800L,31L,32L,297L,544L,175L,864L,37L,608L,351L,800L,41L,6048L,43L,352L,675L,736L,47L,864L,49L,800L,459L,416L,53L,864L,275L,1568L,513L,928L,59L,21600L,61L };
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
public class A064446Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064446.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064446Inst : IEnumerable<long>
{
public static readonly long[] Value=A064446.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064446.Bytes);
public long this[int i]=>Value[i];

public static A064446Inst Instance=new A064446Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064447
{
public static readonly BigInteger[] Value={ 1L,2L,18L,128L,2500L,15552L,705894L,8388608L,258280326L,4000000000L,259374246010L,2972033482752L,279577021469772L,4762288639524864L,233543408203125000L,9223372036854775808UL,BigInteger.Parse("778579070010669895696") };
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
public class A064447Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064447.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064447Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A064447.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A064447.Bytes);
public BigInteger this[int i]=>Value[i];

public static A064447Inst Instance=new A064447Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064448
{
public static readonly BigInteger[] Value={ 1L,2L,9L,128L,625L,15552L,117649L,8388608L,129140163L,2000000000L,25937424601L,2972033482752L,23298085122481L,1587429546508288L,29192926025390625L,9223372036854775808UL,BigInteger.Parse("48661191875666868481"),BigInteger.Parse("13115469358432179191808") };
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
public class A064448Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064448.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064448Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A064448.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A064448.Bytes);
public BigInteger this[int i]=>Value[i];

public static A064448Inst Instance=new A064448Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064449
{
public static readonly long[] Value={ 1L,1L,2L,4L,4L,16L,6L,64L,18L,64L,10L,1152L,12L,1536L,1080L,1024L,16L,442368L,18L,163840L,972L,163840L,22L,15925248L,100L,196608L,1458L,196608L,28L,4777574400L,30L,1048576L,481140L,1048576L,21000L,2293235712L,36L,37748736L,157464L,524288000L };
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
public class A064449Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064449.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064449Inst : IEnumerable<long>
{
public static readonly long[] Value=A064449.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064449.Bytes);
public long this[int i]=>Value[i];

public static A064449Inst Instance=new A064449Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064450
{
public static readonly long[] Value={ 1L,2L,3L,6L,8L,18L,30L,86L,106L,158L,290L,662L,1410L,3674L,7166L,16242L,20242L,46754L,72910L,162686L,304866L,524570L,1179430L,2842710L,5230210L,11035402L,24478394L,40473686L,63927602L,155016682L,328928338L,888801182L,928681474L,1765045802L };
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
public class A064450Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064450.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064450Inst : IEnumerable<long>
{
public static readonly long[] Value=A064450.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064450.Bytes);
public long this[int i]=>Value[i];

public static A064450Inst Instance=new A064450Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064451
{
public static readonly long[] Value={ 1L,1L,2L,2L,4L,8L,24L,24L,72L,288L,240L,240L,1440L,2880L,2880L,11520L,23040L,46080L,207360L,276480L,82944L,829440L,2280960L,9123840L,15206400L,60825600L,273715200L,1642291200L,766402560L,7664025600L,1916006400L,1277337600L };
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
public class A064451Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064451.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064451Inst : IEnumerable<long>
{
public static readonly long[] Value=A064451.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064451.Bytes);
public long this[int i]=>Value[i];

public static A064451Inst Instance=new A064451Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064452
{
public static readonly long[] Value={ 6L,10L,14L,15L,21L,33L,35L,55L,65L,77L,91L,119L,133L,143L,187L,209L,221L,247L,299L,323L,391L,437L,493L,527L,551L,589L,667L,713L,851L,899L,1073L,1147L,1189L,1247L,1271L,1333L,1457L,1517L,1591L,1739L,1763L,1927L,2021L,2173L,2279L,2419L,2491L,2623L,2747L,2773L };
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
public class A064452Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064452.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064452Inst : IEnumerable<long>
{
public static readonly long[] Value=A064452.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064452.Bytes);
public long this[int i]=>Value[i];

public static A064452Inst Instance=new A064452Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064453
{
public static readonly long[] Value={ 1L,5L,15L,44L,85L,216L,343L,806L,1299L,2155L,2926L,7162L,9477L,13209L,17935L,37824L,47957L,75600L,93613L,138074L,170730L,209000L,249481L,635974L,764425L,915551L,1109772L,1390375L,1624029L,2103690L,2430431L,5120488L,5976553L,6946897L };
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
public class A064453Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064453.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064453Inst : IEnumerable<long>
{
public static readonly long[] Value=A064453.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064453.Bytes);
public long this[int i]=>Value[i];

public static A064453Inst Instance=new A064453Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064454
{
public static readonly long[] Value={ 2L,4L,13L,8L,9L,12L,17L,20L };
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
public class A064454Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064454.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064454Inst : IEnumerable<long>
{
public static readonly long[] Value=A064454.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064454.Bytes);
public long this[int i]=>Value[i];

public static A064454Inst Instance=new A064454Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064455
{
public static readonly long[] Value={ 1L,3L,2L,6L,3L,9L,4L,12L,5L,15L,6L,18L,7L,21L,8L,24L,9L,27L,10L,30L,11L,33L,12L,36L,13L,39L,14L,42L,15L,45L,16L,48L,17L,51L,18L,54L,19L,57L,20L,60L,21L,63L,22L,66L,23L,69L,24L,72L,25L,75L,26L,78L,27L,81L,28L,84L,29L,87L,30L,90L,31L,93L,32L,96L,33L,99L,34L,102L,35L,105L,36L,108L };
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
public class A064455Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064455.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064455Inst : IEnumerable<long>
{
public static readonly long[] Value=A064455.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064455.Bytes);
public long this[int i]=>Value[i];

public static A064455Inst Instance=new A064455Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064456
{
public static readonly long[] Value={ 1L,3L,79L,235L,431L,1503L,2943L,6059L,6619L,18911L,54223L,302467995L,1772665631L,2148845167L,5145362667L,129465909327L,212089391807L };
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
public class A064456Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064456.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064456Inst : IEnumerable<long>
{
public static readonly long[] Value=A064456.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064456.Bytes);
public long this[int i]=>Value[i];

public static A064456Inst Instance=new A064456Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064457
{
public static readonly long[] Value={ 3L,7L,47L,157L,293L,1807L,8697L,9447L,15147L,31497L,74847L,159111L,1031187L,1100457L,1740087L,3589707L,8498937L,10312173L,15086925L,51874335L,54072205L,746239895L,1433920655L };
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
public class A064457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064457Inst : IEnumerable<long>
{
public static readonly long[] Value=A064457.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064457.Bytes);
public long this[int i]=>Value[i];

public static A064457Inst Instance=new A064457Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064458
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,9L,9L };
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
public class A064458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064458Inst : IEnumerable<long>
{
public static readonly long[] Value=A064458.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064458.Bytes);
public long this[int i]=>Value[i];

public static A064458Inst Instance=new A064458Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064459
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,8L,8L,8L,8L,8L };
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
public class A064459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064459Inst : IEnumerable<long>
{
public static readonly long[] Value=A064459.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064459.Bytes);
public long this[int i]=>Value[i];

public static A064459Inst Instance=new A064459Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064460
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,1L,0L,3L,4L,3L,0L,5L,2L,2L,1L,8L,6L,9L,6L,7L,6L,6L,0L,11L,11L,10L,13L,13L,9L,13L,10L,16L,15L,14L,14L,18L,15L,13L,14L,19L,15L,15L,9L,15L,19L,14L,3L,24L,24L,25L,24L,24L,18L,26L,25L,28L,26L,25L,19L,27L,18L,12L,28L,32L,31L,31L,30L,31L,27L,30L,27L,36L };
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
public class A064460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064460Inst : IEnumerable<long>
{
public static readonly long[] Value=A064460.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064460.Bytes);
public long this[int i]=>Value[i];

public static A064460Inst Instance=new A064460Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064461
{
public static readonly long[] Value={ 0L,4L,13L,8L,9L,12L,17L,20L,16L,18L,26L,24L,62L,27L,34L,33L,32L,-1L,36L,40L,-1L,95L,-1L,79L,48L,50L,54L,60L,56L,74L,67L,65L,64L,73L,-1L,94L,72L,91L,85L,83L,80L,84L,119L,88L,-1L,97L,104L,101L,96L,98L,100L,-1L,115L,-1L,108L,114L,112L,123L,122L,120L,121L,125L,131L };
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
public class A064461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064461Inst : IEnumerable<long>
{
public static readonly long[] Value=A064461.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064461.Bytes);
public long this[int i]=>Value[i];

public static A064461Inst Instance=new A064461Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064462
{
public static readonly long[] Value={ 0L,6L,4L,14L,13L,10L,8L,-1L,9L,12L,-1L,22L,17L,20L,-1L,16L,-1L,18L,29L,26L,31L,24L,25L,62L,-1L,28L,27L,34L,35L,42L,33L,32L,-1L,-1L,-1L,36L,53L,40L,45L,-1L,-1L,-1L,95L,-1L,-1L,-1L,79L,48L,49L,50L,55L,54L,57L,60L,69L,56L,63L,74L,-1L,70L,67L,66L,65L,64L,77L,-1L };
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
public class A064462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064462Inst : IEnumerable<long>
{
public static readonly long[] Value=A064462.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064462.Bytes);
public long this[int i]=>Value[i];

public static A064462Inst Instance=new A064462Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064463
{
public static readonly long[] Value={ 1L,4L,14L,39L,46L,94L,158L,291L,334L,446L,718L,878L,1454L,1678L,2174L,2446L,2734L,3694L,4414L,4798L,6046L,7438L,7934L,9518L,10078L,11246L,11854L,15838L,17294L,21214L,22894L,27374L,28318L,29278L,32254L,34318L,36446L,38638L,42046L,48046L,51838L };
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
public class A064463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064463Inst : IEnumerable<long>
{
public static readonly long[] Value=A064463.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064463.Bytes);
public long this[int i]=>Value[i];

public static A064463Inst Instance=new A064463Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064464
{
public static readonly long[] Value={ 1L,2L,3L,3L,5L,6L,5L,8L,9L,10L,11L,12L,13L,14L,15L,16L,16L,18L,19L,19L,21L,22L,23L,21L,23L,26L,25L,28L,25L,26L,31L,32L,33L,34L,35L,35L,37L,38L,39L,39L,40L,42L,43L,44L,44L,46L,47L,47L,47L,48L,50L,51L,51L,54L,54L,56L,56L,58L,59L,60L,60L,59L,63L,63L,63L,66L,65L,67L,69L,69L,70L,69L };
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
public class A064464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064464Inst : IEnumerable<long>
{
public static readonly long[] Value=A064464.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064464.Bytes);
public long this[int i]=>Value[i];

public static A064464Inst Instance=new A064464Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064465
{
public static readonly long[] Value={ 5L,7L,13L,16L,19L,31L,36L,40L,41L,43L,49L,50L,53L,61L,74L,82L,84L,89L,92L,94L,102L,103L,107L,109L,113L,130L,138L,140L,149L,151L,154L,158L,169L,181L,182L,197L,199L,217L,229L,233L,239L,241L,243L,257L,266L,271L,293L,331L,349L,361L,383L,389L,409L,419L,421L,439L,463L };
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
public class A064465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064465Inst : IEnumerable<long>
{
public static readonly long[] Value=A064465.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064465.Bytes);
public long this[int i]=>Value[i];

public static A064465Inst Instance=new A064465Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064466
{
public static readonly long[] Value={ 6L,8L,10L,12L,14L,16L,18L,20L,22L,24L,26L,28L,30L,32L,34L,36L,38L,42L,44L,46L,48L,50L,52L,54L,56L,58L,60L,62L,64L,66L,68L,72L,74L,76L,78L,80L,84L,86L,88L,90L,92L,94L,96L,98L,102L,104L,106L,108L,110L,112L,114L,116L,118L,120L,122L,126L,128L,132L,134L,136L,138L,140L,142L };
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
public class A064466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064466Inst : IEnumerable<long>
{
public static readonly long[] Value=A064466.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064466.Bytes);
public long this[int i]=>Value[i];

public static A064466Inst Instance=new A064466Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064467
{
public static readonly long[] Value={ 7L,1L,5L,14L,95L,111L,96L,38L,17L,187L,1L,47L,3L,24L,120L,9L,5L,220L,99L,40L,300L,14L,27L,12L,13L,853L,3487L,1488L,207L,363L,298L,1097L,860L,526L,2607L,394L,1658L,1411L,1183L,429L,439L,729L,1945L,169L,38L,705L,94L,136L,485L,186L,230L,1689L,1708L,1714L,1007L,614L };
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
public class A064467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064467Inst : IEnumerable<long>
{
public static readonly long[] Value=A064467.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064467.Bytes);
public long this[int i]=>Value[i];

public static A064467Inst Instance=new A064467Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064468
{
public static readonly long[] Value={ 1L,2L,7L,16L,30L,63L,121L,239L,484L,981L,1960L,3931L,7897L,15819L,31728L,63575L,127353L,255161L,511013L,1023397L,2049131L,4102600L,8213243L };
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
public class A064468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064468Inst : IEnumerable<long>
{
public static readonly long[] Value=A064468.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064468.Bytes);
public long this[int i]=>Value[i];

public static A064468Inst Instance=new A064468Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064469
{
public static readonly long[] Value={ 2L,4L,6L,12L,8L,10L,18L,14L,24L,16L,20L,22L,30L,28L,26L,36L,32L,34L,42L,38L,40L,44L,46L,48L,50L,52L,54L,56L,60L,70L,58L,66L,62L,72L,64L,68L,74L,78L,76L,80L,82L,84L,88L,86L,90L,100L,92L,94L,96L,98L,104L,102L,108L,106L,114L,110L,112L,116L,118L,120L };
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
public class A064469Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064469.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064469Inst : IEnumerable<long>
{
public static readonly long[] Value=A064469.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064469.Bytes);
public long this[int i]=>Value[i];

public static A064469Inst Instance=new A064469Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064470
{
public static readonly long[] Value={ 1L,2L,3L,6L,4L,5L,9L,7L,12L,8L,10L,11L,15L,14L,13L,18L,16L,17L,21L,19L,20L,22L,23L,24L,25L,26L,27L,28L,30L,35L,29L,33L,31L,36L,32L,34L,37L,39L,38L,40L,41L,42L,44L,43L,45L,50L,46L,47L,48L,49L,52L,51L,54L,53L,57L,55L,56L,58L,59L,60L,65L,61L,63L,70L,62L,64L };
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
public class A064470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064470Inst : IEnumerable<long>
{
public static readonly long[] Value=A064470.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064470.Bytes);
public long this[int i]=>Value[i];

public static A064470Inst Instance=new A064470Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064471
{
public static readonly long[] Value={ 1L,3L,9L,5L,15L,7L,21L,11L,33L,27L,25L,35L,13L,39L,17L,51L,19L,57L,45L,23L,69L,49L,63L,55L,65L,29L,87L,31L,93L,37L,111L,75L,41L,123L,81L,77L,43L,129L,85L,95L,47L,141L,91L,99L,105L,53L,159L,59L,177L,117L,115L,125L,61L,183L,119L,133L,121L,143L,67L,201L };
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
public class A064471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064471Inst : IEnumerable<long>
{
public static readonly long[] Value=A064471.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064471.Bytes);
public long this[int i]=>Value[i];

public static A064471Inst Instance=new A064471Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064472
{
public static readonly long[] Value={ 1L,2L,3L,6L,7L,8L,11L,12L,15L,16L,17L,18L,22L,25L,26L,29L,30L,31L,34L,35L,39L,40L,41L,44L,45L,46L,47L,48L,51L,54L,55L,58L,59L,62L,63L,64L,65L,69L,70L,71L,72L,76L,78L,79L,82L,85L,86L,87L,90L,91L,93L,94L,97L,98L,101L,102L,103L,104L,105L,109L,112L,113L };
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
public class A064472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064472Inst : IEnumerable<long>
{
public static readonly long[] Value=A064472.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064472.Bytes);
public long this[int i]=>Value[i];

public static A064472Inst Instance=new A064472Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064473
{
public static readonly long[] Value={ 4L,5L,9L,10L,13L,14L,19L,20L,21L,23L,24L,27L,28L,32L,33L,36L,37L,38L,42L,43L,49L,50L,52L,53L,56L,57L,60L,61L,66L,67L,68L,73L,74L,75L,77L,80L,81L,83L,84L,88L,89L,92L,95L,96L,99L,100L,106L,107L,108L,110L,111L,114L,115L,117L,118L,123L,124L,127L,128L };
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
public class A064473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064473Inst : IEnumerable<long>
{
public static readonly long[] Value=A064473.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064473.Bytes);
public long this[int i]=>Value[i];

public static A064473Inst Instance=new A064473Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064474
{
public static readonly long[] Value={ 0L,1L,2L,3L,3L,3L,4L,5L,6L,6L,6L,7L,8L,8L,8L,9L,10L,11L,12L,12L,12L,12L,13L,13L,13L,14L,15L,15L,15L,16L,17L,18L,18L,18L,19L,20L,20L,20L,20L,21L,22L,23L,23L,23L,24L,25L,26L,27L,28L,28L,28L,29L,29L,29L,30L,31L,31L,31L,32L,33L,33L,33L,34L,35L,36L,37L,37L,37L,37L };
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
public class A064474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064474Inst : IEnumerable<long>
{
public static readonly long[] Value=A064474.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064474.Bytes);
public long this[int i]=>Value[i];

public static A064474Inst Instance=new A064474Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064475
{
public static readonly long[] Value={ 0L,0L,0L,1L,2L,2L,2L,2L,3L,4L,4L,4L,5L,6L,6L,6L,6L,6L,7L,8L,9L,9L,10L,11L,11L,11L,12L,13L,13L,13L,13L,14L,15L,15L,15L,16L,17L,18L,18L,18L,18L,19L,20L,20L,20L,20L,20L,20L,21L,22L,22L,23L,24L,24L,24L,25L,26L,26L,26L,27L,28L,28L,28L,28L,28L,29L,30L,31L,31L,31L };
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
public class A064475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064475Inst : IEnumerable<long>
{
public static readonly long[] Value=A064475.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064475.Bytes);
public long this[int i]=>Value[i];

public static A064475Inst Instance=new A064475Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064476
{
public static readonly long[] Value={ 1L,6L,12L,36L,72L,144L,216L,432L,864L,1296L,1728L,2592L,5184L,7776L,10368L,15552L,20736L,31104L,46656L,62208L,93312L,124416L,186624L,248832L,279936L,373248L,559872L,746496L,1119744L,1492992L,1679616L,2239488L,2985984L,3359232L,4478976L };
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
public class A064476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064476Inst : IEnumerable<long>
{
public static readonly long[] Value=A064476.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064476.Bytes);
public long this[int i]=>Value[i];

public static A064476Inst Instance=new A064476Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064477
{
public static readonly long[] Value={ 220L,221L,1220L,1221L,2200L,2201L,2210L,2211L,10220L,10221L,11220L,11221L,12200L,12201L,12210L,12211L,22000L,22001L,22010L,22011L,22100L,22101L,22110L,22111L,22220L,22221L,23020L,23021L,33300L,33301L,33310L,33311L,100220L,100221L,101220L };
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
public class A064477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064477Inst : IEnumerable<long>
{
public static readonly long[] Value=A064477.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064477.Bytes);
public long this[int i]=>Value[i];

public static A064477Inst Instance=new A064477Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064478
{
public static readonly long[] Value={ 1L,2L,3L,4L,9L,6L,12L,8L,27L,16L,18L,12L,36L,14L,24L,24L,81L,18L,48L,20L,54L,32L,36L,24L,108L,36L,42L,64L,72L,30L,72L,32L,243L,48L,54L,48L,144L,38L,60L,56L,162L,42L,96L,44L,108L,96L,72L,48L,324L,64L,108L,72L,126L,54L,192L,72L,216L,80L,90L,60L,216L,62L,96L,128L,729L,84L,144L };
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
public class A064478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064478Inst : IEnumerable<long>
{
public static readonly long[] Value=A064478.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064478.Bytes);
public long this[int i]=>Value[i];

public static A064478Inst Instance=new A064478Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064479
{
public static readonly long[] Value={ 5L,7L,10L,11L,13L,15L,17L,19L,21L,22L,23L,25L,26L,28L,29L,31L,33L,34L,35L,37L,39L,40L,41L,43L,45L,46L,47L,49L,50L,51L,52L,53L,55L,57L,58L,59L,61L,63L,65L,66L,67L,69L,70L,71L,73L,75L,76L,77L,78L,79L,82L,83L,85L,86L,87L,88L,89L,91L,92L,93L,94L,95L,97L,99L,100L,101L,103L,105L };
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
public class A064479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064479Inst : IEnumerable<long>
{
public static readonly long[] Value=A064479.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064479.Bytes);
public long this[int i]=>Value[i];

public static A064479Inst Instance=new A064479Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064480
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,10L,13L,19L,26L,36L,51L,69L,94L,130L,188L };
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
public class A064480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064480Inst : IEnumerable<long>
{
public static readonly long[] Value=A064480.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064480.Bytes);
public long this[int i]=>Value[i];

public static A064480Inst Instance=new A064480Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064481
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,8L,10L,12L,15L,16L,18L,20L,24L,25L,26L,27L,28L,30L,32L,36L,40L,42L,45L,48L,50L,51L,52L,54L,56L,60L,63L,64L,65L,66L,72L,75L,76L,78L,80L,85L,88L,90L,91L,96L,99L,100L,102L,104L,105L,112L,117L,120L,125L,126L,128L,130L,132L,135L,136L,138L,140L,144L,145L };
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
public class A064481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064481Inst : IEnumerable<long>
{
public static readonly long[] Value=A064481.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064481.Bytes);
public long this[int i]=>Value[i];

public static A064481Inst Instance=new A064481Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064482
{
public static readonly long[] Value={ 2L,2L,4L,2L,10L,12L,2L,18L,52L,48L,2L,32L,146L,300L,240L,2L,54L,372L,1204L,1968L,1440L,2L,86L,954L,4082L,10476L,14640L,10080L,2L,134L,2376L,13348L,46012L,97968L,122400L,80640L,2L,206L,5704L,44274L,186202L,536652L,990960L,1139040L,725760L,2L,312L,13278L,145216L };
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
public class A064482Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064482.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064482Inst : IEnumerable<long>
{
public static readonly long[] Value=A064482.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064482.Bytes);
public long this[int i]=>Value[i];

public static A064482Inst Instance=new A064482Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064483
{
public static readonly long[] Value={ 12L,30L,60L,96L,336L,660L,702L,756L,984L,990L,1188L,1302L,1488L,1830L,1866L,2070L,2142L,2340L,2586L,2874L,2910L,3618L,3714L,3750L,3774L,3906L,4008L,4470L,4512L,4902L,5094L,5754L,6012L,6174L,6432L,6840L,6846L,6930L,7446L,7578L,7734L,8064L,8190L,8328L };
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
public class A064483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064483Inst : IEnumerable<long>
{
public static readonly long[] Value=A064483.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064483.Bytes);
public long this[int i]=>Value[i];

public static A064483Inst Instance=new A064483Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064484
{
public static readonly long[] Value={ 2L,2L,4L,4L,8L,12L,4L,32L,36L,48L,8L,64L,216L,192L,240L,8L,208L,648L,1536L,1200L,1440L,16L,416L,3024L,6144L,12000L,8640L,10080L,16L,1280L,9072L,37632L,60000L,103680L,70560L,80640L,32L,2560L,38880L,150528L,456000L,622080L,987840L,645120L,725760L };
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
public class A064484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064484Inst : IEnumerable<long>
{
public static readonly long[] Value=A064484.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064484.Bytes);
public long this[int i]=>Value[i];

public static A064484Inst Instance=new A064484Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064485
{
public static readonly long[] Value={ 1L,10L,18L,40L,40L,108L,70L,160L,162L,280L,154L,432L,208L,532L,540L,640L,340L,972L,418L,1120L,1008L,1276L,598L,1728L,1000L,1768L,1458L,2128L,928L,2880L,1054L,2560L,2376L,2992L,2380L,3888L,1480L,3724L,3276L,4480L,1804L,5544L,1978L,5104L,4860L,5428L,2350L,6912L };
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
public class A064485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064485Inst : IEnumerable<long>
{
public static readonly long[] Value=A064485.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064485.Bytes);
public long this[int i]=>Value[i];

public static A064485Inst Instance=new A064485Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064486
{
public static readonly long[] Value={ 1L,2L,2L,2L,2L,4L,2L,36L,38L,244L,244L,1830L,3422L,10626L,3828L,20970L,580384L,4197850L };
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
public class A064486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064486Inst : IEnumerable<long>
{
public static readonly long[] Value=A064486.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064486.Bytes);
public long this[int i]=>Value[i];

public static A064486Inst Instance=new A064486Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064487
{
public static readonly BigInteger[] Value={ 20L,29120L,32537600L,34093383680L,35115786567680L,36011213418659840L,BigInteger.Parse("36888985097480437760"),BigInteger.Parse("37777778976635853209600"),BigInteger.Parse("38685331082014736871587840"),BigInteger.Parse("39614005699412557795646504960"),BigInteger.Parse("40564799864499450381466515537920") };
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
public class A064487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064487Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A064487.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A064487.Bytes);
public BigInteger this[int i]=>Value[i];

public static A064487Inst Instance=new A064487Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064488
{
public static readonly long[] Value={ 0L,1L,2L,2L,3L,4L,4L,5L,6L,7L,7L,8L,9L,9L,10L,11L,11L,12L,13L,14L,14L,15L,16L,16L,17L,18L,19L,19L,20L,21L,21L,22L,23L,23L,24L,25L,26L,26L,27L,28L,28L,29L,30L,31L,31L,32L,33L,33L,34L,35L,35L,36L,37L,38L,38L,39L,40L,40L,41L,42L,43L,43L,44L,45L,45L,46L,47L,47L,48L,49L,50L,50L,51L,52L };
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
public class A064488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064488Inst : IEnumerable<long>
{
public static readonly long[] Value=A064488.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064488.Bytes);
public long this[int i]=>Value[i];

public static A064488Inst Instance=new A064488Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064489
{
public static readonly BigInteger[] Value={ 5L,26L,1230L,78499L,455052512L,37607912019L,279238341033926L,24739954287740861L,BigInteger.Parse("201467286689315906291") };
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
public class A064489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064489Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A064489.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A064489.Bytes);
public BigInteger this[int i]=>Value[i];

public static A064489Inst Instance=new A064489Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064490
{
public static readonly BigInteger[] Value={ 11L,101L,10007L,1000003L,10000000019L,1000000000039L,10000000000000061L,1000000000000000003L,BigInteger.Parse("10000000000000000000009"),BigInteger.Parse("10000000000000000000000000331"),BigInteger.Parse("1000000000000000000000000000057") };
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
public class A064490Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064490.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064490Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A064490.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A064490.Bytes);
public BigInteger this[int i]=>Value[i];

public static A064490Inst Instance=new A064490Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064491
{
public static readonly long[] Value={ 1L,2L,4L,7L,9L,12L,18L,24L,32L,38L,42L,50L,56L,64L,71L,73L,75L,81L,86L,90L,102L,110L,118L,122L,126L,138L,146L,150L,162L,172L,178L,182L,190L,198L,210L,226L,230L,238L,246L,254L,258L,266L,274L,278L,282L,290L,298L,302L,306L,318L,326L,330L,346L,350L,362L,366L,374L };
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
public class A064491Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064491.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064491Inst : IEnumerable<long>
{
public static readonly long[] Value=A064491.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064491.Bytes);
public long this[int i]=>Value[i];

public static A064491Inst Instance=new A064491Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064492
{
public static readonly long[] Value={ 1L,2L,4L,7L,12L,22L,40L,77L,135L,249L,454L,845L,1521L,2753L,5046L,9318L,17224L,31222L,57072L,99742L,181694L,328256L,589933L,1034839L,1788538L,3225919L,5784586L,10212211L,18399785L,32148795L,58056876L,101769230L,173395920L,302890749L,511561221L,904036925L,1610187039L,2789150424L,4910758398L,8416580355L,13808215356L,23006557539L,39488697701L,65854567303L,107078836274L,188471115227L,325374626149L,535755688022L,872467803894L,1404720439054L,2402964238974L,3883018238330L,6283167591180L,10125357598983L,16166305650061L,25735985498862L,40806937801473L,64628644387495L,102481019573338L,159888464280047L,250759470174414L,394178473635589L,599819882554936L,939455761022725L };
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
public class A064492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064492Inst : IEnumerable<long>
{
public static readonly long[] Value=A064492.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064492.Bytes);
public long this[int i]=>Value[i];

public static A064492Inst Instance=new A064492Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064493
{
public static readonly long[] Value={ 1L,2L,4L,20L,260L,9620L,4454060L };
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
public class A064493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064493Inst : IEnumerable<long>
{
public static readonly long[] Value=A064493.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064493.Bytes);
public long this[int i]=>Value[i];

public static A064493Inst Instance=new A064493Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064494
{
public static readonly long[] Value={ 1L,4L,8L,6L,12L,14L,16L,9L,18L,20L,24L,26L,28L,22L,39L,15L,36L,35L,40L,38L,57L,34L,48L,49L,51L,44L,46L,33L,60L,77L,64L,32L,75L,56L,81L,68L,76L,58L,100L,55L,84L,111L,88L,62L,125L,70L,96L,91L,98L,95L,134L,72L,108L,82L,141L,80L,140L,92L,120L,156L,124L,94L,121L,52L,152L,145L };
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
public class A064494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064494Inst : IEnumerable<long>
{
public static readonly long[] Value=A064494.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064494.Bytes);
public long this[int i]=>Value[i];

public static A064494Inst Instance=new A064494Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064495
{
public static readonly long[] Value={ 30L,138L,960L,1056L,1278L,1470L,1968L,2538L,2730L,3030L,3570L,3810L,4122L,4248L,4350L,4506L,5568L,5586L,5718L,5856L,6156L,6486L,6570L,6942L,7194L,7260L,7380L,7410L,7422L,7584L,7920L,8034L,8304L,8910L,9180L,11340L,12684L,13260L,13380L,13620L };
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
public class A064495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064495Inst : IEnumerable<long>
{
public static readonly long[] Value=A064495.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064495.Bytes);
public long this[int i]=>Value[i];

public static A064495Inst Instance=new A064495Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064496
{
public static readonly long[] Value={ 7L,7L,11L,7L,11L,7L,7L,11L,7L,11L,7L,7L,11L,11L,7L,7L,11L,11L,7L,11L,7L,7L,11L,7L,11L,7L,7L,11L,7L,11L,7L,11L,7L,7L,7L,11L,7L,7L,11L,11L,7L,7L,11L,11L,7L,11L,7L,11L,7L,11L,11L,7L,7L,7L,7L,11L,11L,7L,7L,11L,11L,11L,7L,7L,11L,7L,11L,11L,11L,11L,7L,7L,11L };
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
public class A064496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064496Inst : IEnumerable<long>
{
public static readonly long[] Value=A064496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064496.Bytes);
public long this[int i]=>Value[i];

public static A064496Inst Instance=new A064496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064497
{
public static readonly long[] Value={ 2L,3L,10L,21L,55L,104L,221L,399L,782L,1595L,2759L,5328L,9553L,16211L,28670L,52311L,94223L,157624L,280127L,480315L,799058L,1399169L,2378531L,4126752L,7277425L,12260693L,20231054L,34005777L,56050961L,94020520L };
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
public class A064497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064497Inst : IEnumerable<long>
{
public static readonly long[] Value=A064497.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064497.Bytes);
public long this[int i]=>Value[i];

public static A064497Inst Instance=new A064497Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064498
{
public static readonly long[] Value={ 1L,42L,120L,156L,246L,287L,1434L,1673L,2016L,5256L,9799L,11808L,18330L,19740L,21385L,34440L,39990L,44772L,45990L,46655L,57270L,60156L,66815L,68832L,102648L,115620L,125255L,149472L,156570L,170820L,182665L,195510L,200760L,208182L,223944L,224196L };
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
public class A064498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064498Inst : IEnumerable<long>
{
public static readonly long[] Value=A064498.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064498.Bytes);
public long this[int i]=>Value[i];

public static A064498Inst Instance=new A064498Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064499
{
public static readonly long[] Value={ 12L,16L,18L,20L,28L,32L,44L,45L,48L,50L,52L,63L,68L,75L,76L,80L,81L,92L,98L,99L,112L,116L,117L,124L,147L,148L,153L,162L,164L,171L,172L,175L,176L,180L,188L,192L,207L,208L,212L,236L,242L,243L,244L,245L,252L,256L,261L,268L,272L,275L,279L,284L,288L,292L,300L,304L };
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
public class A064499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064499Inst : IEnumerable<long>
{
public static readonly long[] Value=A064499.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064499.Bytes);
public long this[int i]=>Value[i];

public static A064499Inst Instance=new A064499Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064500
{
public static readonly BigInteger[] Value={ 1L,36L,159L,1247L,11259L,111279L,1111377L,11111388L,111111399L,1111111569L,0L,111111112378L,0L,11111111112567L,111111111112568L,1111111111114448L,0L,111111111111113469L,0L,11111111111111122566UL,BigInteger.Parse("111111111111111112779"),0L,0L };
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
public class A064500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064500Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A064500.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A064500.Bytes);
public BigInteger this[int i]=>Value[i];

public static A064500Inst Instance=new A064500Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064501
{
public static readonly long[] Value={ 1L,2L,345L,690L,46035L,92070L,29764712L,46059025L,52096527L,61565160L,92118050L,94399912L,104193054L,140553735L,155064548L,184566592L,188194335L,215515727L,281107470L,288564647L,376388670L,431031454L,479685360L,577129294L,735517552L,888105120L,1066525860L };
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
public class A064501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064501Inst : IEnumerable<long>
{
public static readonly long[] Value=A064501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064501.Bytes);
public long this[int i]=>Value[i];

public static A064501Inst Instance=new A064501Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064502
{
public static readonly long[] Value={ 0L,2L,3L,0L,5L,0L,7L,15L,14L,21L,11L,35L,13L,33L,26L,39L,17L,65L,19L,51L,38L,57L,23L,95L,46L,69L,285L,115L,29L,161L,31L,87L,62L,93L,741L,155L,37L,217L,74L,111L,41L,185L,43L,123L,86L,129L,47L,215L,94L,141L,645L,235L,53L,329L,106L,159L,987L,265L,59L,371L,61L,177L,122L };
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
public class A064502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064502Inst : IEnumerable<long>
{
public static readonly long[] Value=A064502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064502.Bytes);
public long this[int i]=>Value[i];

public static A064502Inst Instance=new A064502Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064503
{
public static readonly long[] Value={ 4L,8L,22L,26L,32L,50L,56L,70L,76L,82L,94L,100L,112L,118L,128L,134L,176L,186L,196L,266L,274L,280L,296L,342L,352L,358L,364L,372L,386L,392L,400L,406L,426L,454L,472L,484L,496L,560L,580L,598L,638L,656L,666L,682L,696L,704L,714L,724L,738L,750L,772L,776L,800L,832L };
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
public class A064503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064503Inst : IEnumerable<long>
{
public static readonly long[] Value=A064503.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064503.Bytes);
public long this[int i]=>Value[i];

public static A064503Inst Instance=new A064503Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064504
{
public static readonly long[] Value={ 9L,96L,461L,548L,565L,876L,1053L,1202L,1302L,1426L,1596L,2040L,3040L,4392L,5710L,6960L,7749L,7988L,8630L,8818L,9323L,9505L,10465L,11617L,11828L,12674L,13119L,17580L,18507L,18954L,22922L,23197L,25821L,33502L,35877L,37065L,37321L };
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
public class A064504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064504Inst : IEnumerable<long>
{
public static readonly long[] Value=A064504.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064504.Bytes);
public long this[int i]=>Value[i];

public static A064504Inst Instance=new A064504Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064505
{
public static readonly long[] Value={ 1L,4L,9L,2L,25L,6L,49L,8L,3L,10L,121L,12L,169L,14L,15L,16L,289L,18L,361L,20L,21L,22L,529L,24L,5L,26L,27L,28L,841L,30L,961L,32L,33L,34L,35L,36L,1369L,38L,39L,40L,1681L,42L,1849L,44L,45L,46L,2209L,48L,7L,50L,51L,52L,2809L,54L,55L,56L,57L,58L,3481L,60L,3721L,62L,63L,64L,65L,66L };
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
public class A064505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064505Inst : IEnumerable<long>
{
public static readonly long[] Value=A064505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064505.Bytes);
public long this[int i]=>Value[i];

public static A064505Inst Instance=new A064505Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064506
{
public static readonly long[] Value={ 0L,1L,2L,2L,3L,4L,4L,5L,6L,6L,7L,8L,9L,9L,10L,11L,11L,12L,13L,14L,14L,15L,16L,16L,17L,18L,18L,19L,20L,21L,21L,22L,23L,23L,24L,25L,26L,26L,27L,28L,28L,29L,30L,30L,31L,32L,33L,33L,34L,35L,35L,36L,37L,38L,38L,39L,40L,40L,41L,42L,42L,43L,44L,45L,45L,46L,47L,47L,48L,49L,50L,50L,51L,52L };
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
public class A064506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064506Inst : IEnumerable<long>
{
public static readonly long[] Value=A064506.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064506.Bytes);
public long this[int i]=>Value[i];

public static A064506Inst Instance=new A064506Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064507
{
public static readonly long[] Value={ 21L,27L,29L,61L,67L,111L,151L,191L,201L,203L,223L,241L,313L,319L,331L,351L,373L,397L,403L,409L,461L,463L,481L,553L,559L,571L,667L,711L,791L,807L,841L,869L,889L,931L,979L,1071L,1079L,1107L,1129L,1189L,1257L,1273L,1277L,1297L,1431L,1437L,1583L,1611L,1639L };
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
public class A064507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064507Inst : IEnumerable<long>
{
public static readonly long[] Value=A064507.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064507.Bytes);
public long this[int i]=>Value[i];

public static A064507Inst Instance=new A064507Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064508
{
public static readonly long[] Value={ 43L,61L,67L,367L,409L,12433L,23557L,38201L,80803L,82421L,99907L,117127L,294223L,305611L,329677L,371359L,420001L,476407L,649639L,669133L,852851L,860257L,929293L,1531813L,1565209L,1634203L,2673343L,3539359L,4386887L,5209999L,5661613L };
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
public class A064508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064508Inst : IEnumerable<long>
{
public static readonly long[] Value=A064508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064508.Bytes);
public long this[int i]=>Value[i];

public static A064508Inst Instance=new A064508Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064509
{
public static readonly long[] Value={ 2L,3L,5L,7L,10L,13L,15L,17L,20L,25L,30L,35L,40L,45L,50L,55L,60L,65L,70L,75L,80L,85L,90L,95L,100L,105L,110L,115L,120L,125L,130L,135L,140L,145L,150L,155L,160L,165L,170L,175L,180L,185L,190L,195L,200L,205L,210L,215L,220L,225L,230L,235L,240L,245L,260L,265L };
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
public class A064509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064509Inst : IEnumerable<long>
{
public static readonly long[] Value=A064509.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064509.Bytes);
public long this[int i]=>Value[i];

public static A064509Inst Instance=new A064509Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064510
{
public static readonly long[] Value={ 1L,6L,24L,28L,496L,2016L,8128L,8190L,42336L,45864L,392448L,714240L,1571328L,33550336L,61900800L,91963648L,211891200L,1931236608L,2013143040L,4428914688L,8589869056L,10200236032L,137438691328L,214204956672L };
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
public class A064510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064510Inst : IEnumerable<long>
{
public static readonly long[] Value=A064510.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064510.Bytes);
public long this[int i]=>Value[i];

public static A064510Inst Instance=new A064510Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064511
{
public static readonly long[] Value={ 1L,10L,0L,0L,-30L,30L,-20L,0L,0L,70L,-20L,120L,0L,0L,-60L,40L,-110L,0L,0L,200L,-90L,120L,0L,0L,-100L,130L,-120L,0L,0L,300L,-60L,320L,0L,0L,-160L,120L,-210L,0L,0L,240L,-100L,420L,0L,0L,-360L,210L,-220L,0L,0L,430L,-120L,320L,0L,0L,-200L,360L,-300L,0L,0L,600L,-120L,620L };
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
public class A064511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064511Inst : IEnumerable<long>
{
public static readonly long[] Value=A064511.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064511.Bytes);
public long this[int i]=>Value[i];

public static A064511Inst Instance=new A064511Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064512
{
public static readonly long[] Value={ 1L,14L,42L,-14L,-70L,-42L,70L,-140L,42L,126L,210L,-84L,294L,-294L,-84L,0L,154L,-504L,378L,-630L,882L,-350L,-252L,252L,1190L,350L,1470L,-1148L,1372L,-756L,0L,-1680L,-630L,-1708L,2520L,-1050L,-630L,-532L,3150L,0L,3570L,-2940L,1750L,812L,420L,-3066L,756L,-3864L };
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
public class A064512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064512Inst : IEnumerable<long>
{
public static readonly long[] Value=A064512.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064512.Bytes);
public long this[int i]=>Value[i];

public static A064512Inst Instance=new A064512Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064513
{
public static readonly long[] Value={ 2L,5L,10L,15L,24L,32L,50L };
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
public class A064513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064513Inst : IEnumerable<long>
{
public static readonly long[] Value=A064513.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064513.Bytes);
public long this[int i]=>Value[i];

public static A064513Inst Instance=new A064513Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064514
{
public static readonly long[] Value={ 0L,1L,2L,2L,3L,4L,3L,4L,5L,4L,6L,5L,6L,5L,7L,6L,8L,7L,6L,8L,7L,9L,8L,10L,7L,9L,8L,10L,9L,11L,8L,10L,12L,9L,11L,10L,12L,9L,11L,13L,10L,12L,14L,11L,13L,10L,12L,14L,11L,13L,15L,12L,14L,11L,16L,13L,15L,12L,14L,16L,13L,15L,12L,17L,14L,16L,13L,18L,15L,17L,14L,16L,13L,18L,15L,17L,14L,19L,16L };
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
public class A064514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064514Inst : IEnumerable<long>
{
public static readonly long[] Value=A064514.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064514.Bytes);
public long this[int i]=>Value[i];

public static A064514Inst Instance=new A064514Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064515
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,2L,3L,3L,3L,4L,3L,4L,4L,5L,4L,5L,4L,5L,6L,5L,6L,5L,6L,5L,7L,6L,7L,6L,7L,6L,8L,7L,6L,8L,7L,8L,7L,9L,8L,7L,9L,8L,7L,9L,8L,10L,9L,8L,10L,9L,8L,10L,9L,11L,8L,10L,9L,11L,10L,9L,11L,10L,12L,9L,11L,10L,12L,9L,11L,10L,12L,11L,13L,10L,12L,11L,13L,10L,12L,11L,13L,10L,12L,14L,11L,13L,12L };
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
public class A064515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064515Inst : IEnumerable<long>
{
public static readonly long[] Value=A064515.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064515.Bytes);
public long this[int i]=>Value[i];

public static A064515Inst Instance=new A064515Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064516
{
public static readonly long[] Value={ 2L,6L,17L,28L,33L,34L,40L,41L,43L,50L,53L,54L,57L,59L,60L,69L,75L,76L,79L,97L,100L,107L,109L,110L,111L,113L,119L,127L,137L,142L,157L,161L,178L,198L,202L,232L,238L,246L,262L,263L,267L,273L,276L,282L,287L,300L,302L,306L,317L,322L,335L,339L,341L,344L,348L,353L,365L };
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
public class A064516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064516Inst : IEnumerable<long>
{
public static readonly long[] Value=A064516.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064516.Bytes);
public long this[int i]=>Value[i];

public static A064516Inst Instance=new A064516Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064517
{
public static readonly long[] Value={ 1L,2L,7L,8L,9L,10L,23L,24L,25L,26L,27L,28L,53L,54L,55L,56L,57L,58L,97L,98L,99L,100L,151L,152L,153L,154L,155L,156L,227L,228L,311L,312L,419L,420L,541L,542L,543L,544L,545L,546L,661L,662L,663L,664L,665L,666L,667L,668L,669L,670L,671L,672L,827L,828L,1009L,1010L,1011L };
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
public class A064517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064517Inst : IEnumerable<long>
{
public static readonly long[] Value=A064517.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064517.Bytes);
public long this[int i]=>Value[i];

public static A064517Inst Instance=new A064517Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064518
{
public static readonly long[] Value={ 1L,12L,36L,144L,432L,1296L,1728L,5184L,15552L,20736L,46656L,62208L,186624L,248832L,559872L,746496L,1679616L,2239488L,2985984L,6718464L,8957952L,20155392L,26873856L,60466176L,35831808L,80621568L,107495424L,241864704L,322486272L };
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
public class A064518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064518Inst : IEnumerable<long>
{
public static readonly long[] Value=A064518.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064518.Bytes);
public long this[int i]=>Value[i];

public static A064518Inst Instance=new A064518Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064519
{
public static readonly long[] Value={ 3L,5L,6L,13L,18L,20L,27L,37L,50L,61L,73L,96L,157L,193L,242L,277L,313L,397L,421L,457L,486L,541L,613L,661L,673L,722L,733L,757L,877L,997L,1093L,1153L,1201L,1213L,1237L,1321L,1381L,1453L,1621L,1657L,1682L,1753L,1873L,1933L,1993L,2017L,2137L,2341L,2473L,2557L };
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
public class A064519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064519Inst : IEnumerable<long>
{
public static readonly long[] Value=A064519.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064519.Bytes);
public long this[int i]=>Value[i];

public static A064519Inst Instance=new A064519Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064520
{
public static readonly long[] Value={ 1L,-1L,-4L,0L,5L,11L,4L,-4L,-13L,-23L,-12L,0L,13L,27L,42L,26L,9L,-9L,-28L,-48L,-69L,-47L,-24L,0L,25L,51L,78L,106L,77L,47L,16L,-16L,-49L,-83L,-118L,-154L,-117L,-79L,-40L,0L,41L,83L,126L,170L,215L,169L,122L,74L,25L,-25L,-76L,-128L,-181L,-235L,-290L,-234L,-177L,-119L,-60L,0L,61L,123L,186L,250L,315L,381L,314L,246L,177L };
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
public class A064520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064520Inst : IEnumerable<long>
{
public static readonly long[] Value=A064520.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064520.Bytes);
public long this[int i]=>Value[i];

public static A064520Inst Instance=new A064520Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064521
{
public static readonly long[] Value={ 1L,0L,6L,13L,55L,189L,694L,2516L,9213L,33782L,124300L,458502L,1695469L,6284175L,23344173L,86904615L,324197100L,1211841846L,4538611107L,17029834923L,64014608376L,241046175666L,909171583214L,3434698413540L,12995770332449L };
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
public class A064521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064521Inst : IEnumerable<long>
{
public static readonly long[] Value=A064521.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064521.Bytes);
public long this[int i]=>Value[i];

public static A064521Inst Instance=new A064521Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064522
{
public static readonly long[] Value={ 1L,2L,4L,6L,8L,12L,16L,20L,24L,32L,36L,40L,48L,64L,72L,80L,84L,96L,120L,128L,144L,160L,168L,192L,216L,240L,256L,272L,288L,312L,320L,336L,384L,400L,432L,440L,480L,504L,512L,544L,576L,624L,640L,672L,720L,768L,800L,864L,880L,960L,1008L,1024L,1088L,1152L,1248L,1280L };
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
public class A064522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064522Inst : IEnumerable<long>
{
public static readonly long[] Value=A064522.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064522.Bytes);
public long this[int i]=>Value[i];

public static A064522Inst Instance=new A064522Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064523
{
public static readonly long[] Value={ 1L,3L,5L,10L,2640L,8304L,11699L,15330L,16810L,16910L,22463L,25906L,26652L,35950L,72429L,75470L,134141L,142413L,194711L,270353L,296073L,371964L,496254L,654609L,1640679L,1729409L,1854680L };
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
public class A064523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064523Inst : IEnumerable<long>
{
public static readonly long[] Value=A064523.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064523.Bytes);
public long this[int i]=>Value[i];

public static A064523Inst Instance=new A064523Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064524
{
public static readonly long[] Value={ 0L,0L,1L,2L,3L,4L,5L,6L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,60L,61L,62L,63L,64L,65L,66L,67L,68L };
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
public class A064524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064524Inst : IEnumerable<long>
{
public static readonly long[] Value=A064524.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064524.Bytes);
public long this[int i]=>Value[i];

public static A064524Inst Instance=new A064524Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064525
{
public static readonly BigInteger[] Value={ 13L,144L,10946L,1346269L,12586269025L,1548008755920L,14472334024676221L,1100087778366101931L,BigInteger.Parse("10284720757613717413913"),BigInteger.Parse("11825896447871834976429068427"),BigInteger.Parse("1454489111232772683678306641953") };
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
public class A064525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064525Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A064525.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A064525.Bytes);
public BigInteger this[int i]=>Value[i];

public static A064525Inst Instance=new A064525Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064526
{
public static readonly BigInteger[] Value={ 0L,1L,2L,3L,5L,13L,49L,529L,21121L,10369921L,213952189441L,2214253468601687041L,BigInteger.Parse("473721461635593679669210030081"),BigInteger.Parse("1048939288228833101089604217183056027094304481281") };
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
public class A064526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064526Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A064526.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A064526.Bytes);
public BigInteger this[int i]=>Value[i];

public static A064526Inst Instance=new A064526Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064527
{
public static readonly long[] Value={ 1L,2L,4L,6L,8L,12L,16L,18L,24L,32L,36L,48L,54L,64L,72L,96L,108L,120L,128L,144L,162L,192L,200L,216L,240L,256L,288L,324L,384L,400L,432L,480L,486L,512L,576L,648L,720L,768L,800L,864L,960L,972L,1024L,1152L,1200L,1296L,1440L,1458L,1536L,1600L,1728L,1920L,1944L };
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
public class A064527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064527Inst : IEnumerable<long>
{
public static readonly long[] Value=A064527.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064527.Bytes);
public long this[int i]=>Value[i];

public static A064527Inst Instance=new A064527Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064528
{
public static readonly long[] Value={ 2L,3L,6L,7L,8L,10L,12L,14L,15L,17L,18L,19L,20L,21L,22L,23L,24L,28L,29L,30L,31L,32L,33L,34L,35L,37L,38L,39L,40L,43L,44L,45L,46L,48L };
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
public class A064528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064528Inst : IEnumerable<long>
{
public static readonly long[] Value=A064528.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064528.Bytes);
public long this[int i]=>Value[i];

public static A064528Inst Instance=new A064528Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064529
{
public static readonly long[] Value={ 2L,3L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,1L,1L,1L,1L,1L,1L,1L,1L };
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
public class A064529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064529Inst : IEnumerable<long>
{
public static readonly long[] Value=A064529.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064529.Bytes);
public long this[int i]=>Value[i];

public static A064529Inst Instance=new A064529Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064530
{
public static readonly long[] Value={ 1L,2L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L };
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
public class A064530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064530Inst : IEnumerable<long>
{
public static readonly long[] Value=A064530.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064530.Bytes);
public long this[int i]=>Value[i];

public static A064530Inst Instance=new A064530Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064531
{
public static readonly long[] Value={ 2L,1L,1L,1L,1L,1L,2L,1L,3L,2L,2L,1L,1L,1L,1L,1L,2L,1L,3L,2L,2L,1L,1L,1L,1L,1L,2L,1L,3L,2L,2L,1L,1L,1L,1L,1L,2L,1L,3L,2L,2L,1L,1L,1L,1L,1L,2L,1L,3L,2L,2L,1L,1L,1L,1L,1L,2L,1L,3L,2L,3L,2L,2L,2L,2L,2L,3L,2L,4L,3L,2L,1L,1L,1L,1L,1L,2L,1L,3L,2L,4L,3L,3L,3L,3L,3L,4L,3L,5L,4L,3L,2L,2L,2L,2L,2L,3L,2L,4L,3L,3L,2L,2L,2L,2L };
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
public class A064531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064531Inst : IEnumerable<long>
{
public static readonly long[] Value=A064531.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064531.Bytes);
public long this[int i]=>Value[i];

public static A064531Inst Instance=new A064531Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064532
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,1L,0L,2L,1L,1L,0L,0L,0L,0L,0L,1L,0L,2L,1L,1L,0L,0L,0L,0L,0L,1L,0L,2L,1L,1L,0L,0L,0L,0L,0L,1L,0L,2L,1L,1L,0L,0L,0L,0L,0L,1L,0L,2L,1L,1L,0L,0L,0L,0L,0L,1L,0L,2L,1L,2L,1L,1L,1L,1L,1L,2L,1L,3L,2L,1L,0L,0L,0L,0L,0L,1L,0L,2L,1L,3L,2L,2L,2L,2L,2L,3L,2L,4L,3L,2L,1L,1L,1L,1L,1L,2L,1L,3L,2L,2L,1L,1L,1L,1L };
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
public class A064532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064532Inst : IEnumerable<long>
{
public static readonly long[] Value=A064532.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064532.Bytes);
public long this[int i]=>Value[i];

public static A064532Inst Instance=new A064532Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064533
{
public static readonly long[] Value={ 7L,6L,4L,2L,2L,3L,6L,5L,3L,5L,8L,9L,2L,2L,0L,6L,6L,2L,9L,9L,0L,6L,9L,8L,7L,3L,1L,2L,5L,0L,0L,9L,2L,3L,2L,8L,1L,1L,6L,7L,9L,0L,5L,4L,1L,3L,9L,3L,4L,0L,9L,5L,1L,4L,7L,2L,1L,6L,8L,6L,6L,7L,3L,7L,4L,9L,6L,1L,4L,6L,4L,1L,6L,5L,8L,7L,3L,2L,8L,5L,8L,8L,3L,8L,4L,0L,1L,5L,0L,5L,0L,1L,3L,1L,3L,1L,2L,3L,3L,7L,2L,1L,9L,3L,7L,2L,6L,9L,1L,2L,0L,7L,9L,2L,5L,9L,2L,6L,3L,4L,1L,8L,7L,4L,2L,0L,6L,4L,6L,7L,8L,0L,8L,4L,3L,2L,3L,0L,6L,3L,3L,1L,5L,4L,3L,4L,6L,2L,9L,3L,8L,0L,5L,3L,1L,6L,0L,5L,1L,7L,1L,1L,6L,9L,6L,3L,6L,1L,7L,7L,5L,0L,8L,8L,1L,9L,9L,6L,1L,2L,4L,3L,8L,2L,4L,9L,9L,4L,2L,7L,7L,6L,8L,3L,4L,6L,9L,0L,5L,1L,6L,2L,3L,5L,1L,3L,9L,2L,1L,8L,7L,1L,9L,6L,2L,0L,5L,6L,9L,0L,5L,3L,2L,9L,5L,6L,4L,4L,6L,7L,0L,4L };
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
public class A064533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064533Inst : IEnumerable<long>
{
public static readonly long[] Value=A064533.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064533.Bytes);
public long this[int i]=>Value[i];

public static A064533Inst Instance=new A064533Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064534
{
public static readonly long[] Value={ 3L,5L,7L,11L,13L,17L,19L,23L,29L,53L,59L };
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
public class A064534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064534Inst : IEnumerable<long>
{
public static readonly long[] Value=A064534.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064534.Bytes);
public long this[int i]=>Value[i];

public static A064534Inst Instance=new A064534Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064535
{
public static readonly BigInteger[] Value={ 0L,1L,2L,6L,18L,186L,630L,7710L,27594L,364722L,18512790L,69273666L,3714566310L,53634713550L,204560302842L,2994414645858L,169947155749830L,9770521225481754L,37800705069076950L,2202596307308603178L,BigInteger.Parse("33256101992039755026"),BigInteger.Parse("129379903640264252430") };
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
public class A064535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064535Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A064535.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A064535.Bytes);
public BigInteger this[int i]=>Value[i];

public static A064535Inst Instance=new A064535Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064536
{
public static readonly long[] Value={ 1L,3L,2L,13L,20L,3L,51L,87L,121L,711L,1139L,3537L,8034L,15752L,27922L,49629L,33201L,35975L,143900L,136341L,545364L,2181456L,1060135L,4240540L,16962160L,28647197L,13597858L,205877827L,100616667L,381266393L,1397863922L,3825576990L };
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
public class A064536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064536Inst : IEnumerable<long>
{
public static readonly long[] Value=A064536.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064536.Bytes);
public long this[int i]=>Value[i];

public static A064536Inst Instance=new A064536Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064537
{
public static readonly long[] Value={ 1L,3L,5L,7L,4L,6L,12L,14L,16L,11L,2L,21L,23L,25L,10L,17L,30L,32L,34L,22L,8L,39L,41L,43L,27L,28L,48L,50L,52L,20L,33L,57L,59L,61L,38L,9L,66L,68L,70L,26L,44L,75L,77L,79L,49L,18L,84L,86L,88L,54L,55L,93L,95L,97L,36L,60L,102L,104L,106L,65L,40L,111L,113L,115L,42L,71L,120L,122L,124L };
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
public class A064537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064537Inst : IEnumerable<long>
{
public static readonly long[] Value=A064537.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064537.Bytes);
public long this[int i]=>Value[i];

public static A064537Inst Instance=new A064537Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064538
{
public static readonly long[] Value={ 1L,2L,6L,4L,30L,12L,42L,24L,90L,20L,66L,24L,2730L,420L,90L,48L,510L,180L,3990L,840L,6930L,660L,690L,720L,13650L,1092L,378L,56L,870L,60L,14322L,7392L,117810L,7140L,210L,72L,1919190L,103740L,8190L,1680L,94710L,13860L,99330L,9240L,217350L,9660L,9870L,10080L,324870L };
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
public class A064538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064538Inst : IEnumerable<long>
{
public static readonly long[] Value=A064538.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064538.Bytes);
public long this[int i]=>Value[i];

public static A064538Inst Instance=new A064538Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064539
{
public static readonly long[] Value={ 1L,3L,9L,15L,21L,33L,2007L,2127L,3759L,29355L,34653L,57285L,99069L };
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
public class A064539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064539Inst : IEnumerable<long>
{
public static readonly long[] Value=A064539.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064539.Bytes);
public long this[int i]=>Value[i];

public static A064539Inst Instance=new A064539Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064540
{
public static readonly long[] Value={ 3L,7L,8L,4L,9L,2L,3L,4L,3L,5L,3L,5L,7L,5L,1L,6L,8L,9L,8L,3L,3L,3L,5L,8L,9L,5L,1L,6L,2L,7L,8L,6L,9L,6L,8L,2L,5L,5L,4L,1L,7L,5L,4L,2L,6L,8L,2L,6L,1L,4L,8L,2L,8L,2L,1L,2L,1L,2L,1L,9L,7L,2L,9L,8L,3L,5L,5L,8L,9L,8L,9L,7L,1L,4L,9L,5L,2L,2L,9L,1L,7L,8L,8L,8L,6L,5L,2L,2L,4L,4L,8L,3L,7L,1L,2L,5L,3L,9L,6L,4L,5L,6L,3L,4L,2L };
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
public class A064540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064540Inst : IEnumerable<long>
{
public static readonly long[] Value=A064540.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064540.Bytes);
public long this[int i]=>Value[i];

public static A064540Inst Instance=new A064540Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064541
{
public static readonly BigInteger[] Value={ 36L,736L,8736L,48736L,948736L,2948736L,32948736L,432948736L,3432948736L,53432948736L,353432948736L,5353432948736L,75353432948736L,5075353432948736L,15075353432948736L,615075353432948736L,8615075353432948736L,BigInteger.Parse("98615075353432948736"),BigInteger.Parse("8098615075353432948736"),BigInteger.Parse("38098615075353432948736") };
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
public class A064541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064541Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A064541.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A064541.Bytes);
public BigInteger this[int i]=>Value[i];

public static A064541Inst Instance=new A064541Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064542
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,4L,4L,5L,5L,6L,7L,7L,8L,8L,9L,10L,10L,11L,11L,12L,13L,13L,14L,14L,15L,15L,16L,17L,17L,18L,18L,19L,20L,20L,21L,21L,22L,22L,23L,24L,24L,25L,25L,26L,27L,27L,28L,28L,29L,29L,30L,31L,31L,32L,32L,33L,33L,34L,35L,35L,36L,36L,37L,37L,38L,39L,39L,40L,40L,41L,41L,42L,43L,43L };
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
public class A064542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064542Inst : IEnumerable<long>
{
public static readonly long[] Value=A064542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064542.Bytes);
public long this[int i]=>Value[i];

public static A064542Inst Instance=new A064542Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064543
{
public static readonly long[] Value={ 17L,23L,13L,13L,41L,1627L,37L,17L,73L,431L,89L,37L,23L,571L,199L,41L,137L,211L,349L,941L,13729L,41299L,19259L,313L,5309L,1031L,42409L,2797L,53L,6211L,13339L,17L,43759L,47L,491L,13L,787L,139787L,13L,89L,21937L,29947L,3449L,24533L,8839L,18979L,619L,2713L,23L };
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
public class A064543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064543Inst : IEnumerable<long>
{
public static readonly long[] Value=A064543.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064543.Bytes);
public long this[int i]=>Value[i];

public static A064543Inst Instance=new A064543Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064544
{
public static readonly long[] Value={ 0L,11L,22L,33L,44L,55L,66L,77L,88L,99L,101L,110L,112L,121L,123L,132L,134L,143L,145L,154L,156L,165L,167L,176L,178L,187L,189L,198L,202L,211L,213L,220L,224L,231L,235L,242L,246L,253L,257L,264L,268L,275L,279L,286L,297L,303L,312L,314L,321L,325L,330L,336L,341L,347L,352L,358L };
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
public class A064544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064544Inst : IEnumerable<long>
{
public static readonly long[] Value=A064544.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064544.Bytes);
public long this[int i]=>Value[i];

public static A064544Inst Instance=new A064544Inst();

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