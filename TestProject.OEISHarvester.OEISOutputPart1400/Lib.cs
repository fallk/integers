using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A280572
{
public static readonly BigInteger[] Value={ 1L,5L,40L,525L,10025L,253475L,8015725L,305359050L,13645726250L,701304298375L,40822454374125L,2658840618527250L,191861336190647375L,15213199343853357500UL,BigInteger.Parse("1316408013706224687500"),BigInteger.Parse("123576861126283832953125"),BigInteger.Parse("12521371849855149886590625"),BigInteger.Parse("1363361618975383978443843750"),BigInteger.Parse("158900334287408210286438971875"),BigInteger.Parse("19755940413686794723417400000000"),BigInteger.Parse("2612146114817877629253999384562500"),BigInteger.Parse("366294181903982533559997504649828125") };
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
public class A280572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280572Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A280572.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A280572.Bytes);
public BigInteger this[int i]=>Value[i];

public static A280572Inst Instance=new A280572Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280571
{
public static readonly BigInteger[] Value={ 1L,4L,52L,1228L,42652L,1972324L,114581476L,8051020348L,666126945340L,63620722928308L,6907454641512244L,842227742687112604L,BigInteger.Parse("114192665828161184332"),BigInteger.Parse("17076069626235659815108"),BigInteger.Parse("2796969496541969481342100"),BigInteger.Parse("498871283058754285439126092"),BigInteger.Parse("96403472225110465517090352700"),BigInteger.Parse("20094942949266343527252229063204"),BigInteger.Parse("4500802213556155723422379457382916"),BigInteger.Parse("1079478060677848794106956676648220860") };
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
public class A280571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280571Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A280571.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A280571.Bytes);
public BigInteger this[int i]=>Value[i];

public static A280571Inst Instance=new A280571Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280570
{
public static readonly BigInteger[] Value={ 1L,4L,28L,332L,5748L,131940L,3791692L,131375324L,5343640212L,250142552212L,13271217848604L,788346022938556L,51916178572447140L,3759254932421361284L,BigInteger.Parse("297243198474965188732"),BigInteger.Parse("25513664852425377663756"),BigInteger.Parse("2365246919693613357168916"),BigInteger.Parse("235776253411115081902083556"),BigInteger.Parse("25174157913006507920211300588"),BigInteger.Parse("2869108641038261410331666767772") };
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
public class A280570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280570Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A280570.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A280570.Bytes);
public BigInteger this[int i]=>Value[i];

public static A280570Inst Instance=new A280570Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280569
{
public static readonly long[] Value={ 1L,-1L,1L,-1L,1L,-2L,1L,-1L,1L,-1L,2L,-1L,1L,-1L,1L,-2L,1L,-1L,1L,-1L,2L,-1L,1L,-1L,1L,-2L,1L,-1L,1L,-1L,2L,-1L,1L,-1L,1L,-2L,1L,-1L,1L,-1L,2L,-1L,1L,-1L,1L,-2L,1L,-1L,1L,-1L,2L,-1L,1L,-1L,1L,-2L,1L,-1L,1L,-1L,2L,-1L,1L,-1L,1L,-2L,1L,-1L,1L,-1L,2L,-1L,1L,-1L,1L };
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
public class A280569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280569Inst : IEnumerable<long>
{
public static readonly long[] Value=A280569.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280569.Bytes);
public long this[int i]=>Value[i];

public static A280569Inst Instance=new A280569Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280568
{
public static readonly long[] Value={ 1L,2L,6L,1L,16L,47L,96L,15L,448L,63L,1024L,2943L,6400L,767L,21504L,64255L,3072L,246783L,12288L,985087L,32768L,3768319L,196608L,8421375L,25034752L,50364415L,8126464L,241434623L,65536L,599982079L,1343619072L,4020305919L,752091136L,13962575871L,3037200384L };
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
public class A280568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280568Inst : IEnumerable<long>
{
public static readonly long[] Value=A280568.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280568.Bytes);
public long this[int i]=>Value[i];

public static A280568Inst Instance=new A280568Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280567
{
public static readonly long[] Value={ 1L,1L,3L,8L,1L,61L,3L,240L,7L,1008L,1L,4077L,19L,16336L,21L,65375L,96L,261903L,96L,1048079L,32L,4194215L,96L,16776705L,253L,67106819L,496L,268434535L,4096L,1073729777L,13317L,4294903287L,22120L,17179832331L,34152L,68719383833L,104257L,274877651549L,49731L };
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
public class A280567Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280567.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280567Inst : IEnumerable<long>
{
public static readonly long[] Value=A280567.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280567.Bytes);
public long this[int i]=>Value[i];

public static A280567Inst Instance=new A280567Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280566
{
public static readonly ulong[] Value={ 1L,10L,110L,1L,10000L,101111L,1100000L,1111L,111000000L,111111L,10000000000L,101101111111L,1100100000000L,1011111111L,101010000000000L,1111101011111111L,110000000000L,111100001111111111L,11000000000000L,11110000011111111111UL,1000000000000000L };
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
public class A280566Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280566.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280566Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A280566.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280566.Bytes);
public ulong this[int i]=>Value[i];

public static A280566Inst Instance=new A280566Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280565
{
public static readonly BigInteger[] Value={ 1L,1L,11L,1000L,1L,111101L,11L,11110000L,111L,1111110000L,1L,111111101101L,10011L,11111111010000L,10101L,1111111101011111L,1100000L,111111111100001111L,1100000L,11111111111000001111UL,100000L,BigInteger.Parse("1111111111111110100111"),1100000L,BigInteger.Parse("111111111111111000000001"),11111101L };
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
public class A280565Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280565.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280565Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A280565.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A280565.Bytes);
public BigInteger this[int i]=>Value[i];

public static A280565Inst Instance=new A280565Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280532
{
public static readonly long[] Value={ 1L,1L,6L,13L,37L,31L,605L,1411L,7174L,15567L,608953L,78903L,334535L,611552L,105928L,2557047L,2979162L,3263358L,6242520L,7825254L,37404834L,267494881L,639174488L };
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
public class A280532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280532Inst : IEnumerable<long>
{
public static readonly long[] Value=A280532.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280532.Bytes);
public long this[int i]=>Value[i];

public static A280532Inst Instance=new A280532Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280531
{
public static readonly long[] Value={ 0L,0L,1L,2L,2L,4L,11L,16L,16L,25L,30L,64L,39L,83L,111L,139L,139L,165L,205L,242L,283L,320L,336L,474L,440L,395L,637L,655L,886L,842L,1019L,1159L,1159L,1153L,1327L,1366L,1328L,1243L,1487L,1756L,1623L,2362L,2394L,2274L,2487L,2642L,2907L,2843L,3211L,3049L,3736L };
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
public class A280531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280531Inst : IEnumerable<long>
{
public static readonly long[] Value=A280531.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280531.Bytes);
public long this[int i]=>Value[i];

public static A280531Inst Instance=new A280531Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280530
{
public static readonly long[] Value={ 1L,2L,6L,5L,20L,59L,24L,151L,272L,687L,1760L,1887L,4416L,11199L,27008L,29055L,67840L,185087L,411136L,304639L,1082368L,2976767L,6797312L,4839423L,16838656L,50147327L,117858304L,15261695L,472236032L,189710335L,1293123584L,2390851583L,5745868800L,16517890047L };
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
public class A280530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280530Inst : IEnumerable<long>
{
public static readonly long[] Value=A280530.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280530.Bytes);
public long this[int i]=>Value[i];

public static A280530Inst Instance=new A280530Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280529
{
public static readonly long[] Value={ 1L,1L,3L,10L,5L,55L,12L,233L,17L,981L,59L,4014L,81L,16245L,203L,65166L,289L,261421L,787L,1047122L,1057L,4191661L,3827L,16771986L,7681L,67097341L,13063L,268415344L,29831L,1073700020L,58457L,4294869361L,113877L,17179690095L,168240L,68719183111L,406128L };
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
public class A280529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280529Inst : IEnumerable<long>
{
public static readonly long[] Value=A280529.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280529.Bytes);
public long this[int i]=>Value[i];

public static A280529Inst Instance=new A280529Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280528
{
public static readonly long[] Value={ 1L,10L,110L,101L,10100L,111011L,11000L,10010111L,100010000L,1010101111L,11011100000L,11101011111L,1000101000000L,10101110111111L,110100110000000L,111000101111111L,10000100100000000L,101101001011111111L,1100100011000000000L,1001010010111111111L };
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
public class A280528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280528Inst : IEnumerable<long>
{
public static readonly long[] Value=A280528.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280528.Bytes);
public long this[int i]=>Value[i];

public static A280528Inst Instance=new A280528Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280527
{
public static readonly BigInteger[] Value={ 1L,1L,11L,1010L,101L,110111L,1100L,11101001L,10001L,1111010101L,111011L,111110101110L,1010001L,11111101110101L,11001011L,1111111010001110L,100100001L,111111110100101101L,1100010011L,11111111101001010010UL,10000100001L,BigInteger.Parse("1111111111010110101101"),111011110011L };
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
public class A280527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280527Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A280527.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A280527.Bytes);
public BigInteger this[int i]=>Value[i];

public static A280527Inst Instance=new A280527Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280526
{
public static readonly long[] Value={ 1L,3L,1L,3L,1L,3L,17L,51L,1L,67L,17L,1139L,4097L,12611L,273L,18291L,69889L,205379L,5393L,294771L,1114369L,3277379L,70929L,4603763L,17891585L,52888131L,5393L,68501363L,269746433L,897319491L,352392465L,1045577587L,21299457L,132055619L,5372908817L,15327117171L };
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
public class A280526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280526Inst : IEnumerable<long>
{
public static readonly long[] Value=A280526.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280526.Bytes);
public long this[int i]=>Value[i];

public static A280526Inst Instance=new A280526Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280525
{
public static readonly long[] Value={ 1L,3L,4L,12L,16L,48L,68L,204L,256L,776L,1088L,3298L,4097L,12451L,17472L,52962L,65809L,198931L,279872L,847842L,1052689L,3182611L,4478016L,13565026L,16843025L,50922387L,71647232L,217041538L,269485313L,814747563L,1146372180L,3472640636L,4311827712L,13036154752L };
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
public class A280525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280525Inst : IEnumerable<long>
{
public static readonly long[] Value=A280525.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280525.Bytes);
public long this[int i]=>Value[i];

public static A280525Inst Instance=new A280525Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280524
{
public static readonly BigInteger[] Value={ 1L,11L,1L,11L,1L,11L,10001L,110011L,1L,1000011L,10001L,10001110011L,1000000000001L,11000101000011L,100010001L,100011101110011L,10001000100000001L,110010001001000011L,1010100010001L,1000111111101110011L,BigInteger.Parse("100010000000100000001"),BigInteger.Parse("1100100000001001000011") };
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
public class A280524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280524Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A280524.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A280524.Bytes);
public BigInteger this[int i]=>Value[i];

public static A280524Inst Instance=new A280524Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280523
{
public static readonly long[] Value={ 1L,3L,10L,30L,84L,227L,603L,1589L,4172L,10936L,28646L,75013L,196405L,514215L,1346254L,3524562L,9227448L,24157799L,63245967L,165580121L,433494416L,1134903148L,2971215050L,7778742025L,20365011049L,53316291147L,139583862418L };
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
public class A280523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280523Inst : IEnumerable<long>
{
public static readonly long[] Value=A280523.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280523.Bytes);
public long this[int i]=>Value[i];

public static A280523Inst Instance=new A280523Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280522
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,1L,0L,1L,1L,2L,1L,0L,1L,1L,2L,1L,2L,2L,1L,0L,1L,1L,2L,1L,2L,2L,1L,2L,2L,3L,2L,1L,0L,1L,1L,2L,1L,2L,2L,1L,2L,2L,3L,2L,1L,2L,2L,3L,2L,3L,3L,2L,1L,0L,1L,1L,2L,1L,2L,2L,1L,2L,2L,3L,2L,1L,2L,2L,3L,2L,3L,3L,2L,1L,2L,2L,3L,2L,3L,3L,2L,3L,3L,4L,3L,2L,1L };
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
public class A280522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280522Inst : IEnumerable<long>
{
public static readonly long[] Value=A280522.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280522.Bytes);
public long this[int i]=>Value[i];

public static A280522Inst Instance=new A280522Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280521
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,2L,1L,2L,2L,3L,2L,1L,2L,2L,3L,2L,3L,3L,2L,1L,2L,2L,3L,2L,3L,3L,2L,3L,3L,4L,3L,2L,1L,2L,2L,3L,2L,3L,3L,2L,3L,3L,4L,3L,2L,3L,3L,4L,3L,4L,4L,3L,2L,1L,2L,2L,3L,2L,3L,3L,2L,3L,3L,4L,3L,2L,3L,3L,4L,3L,4L,4L,3L,2L,3L,3L,4L,3L,4L,4L,3L,4L,4L,5L,4L,3L,2L };
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
public class A280521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280521Inst : IEnumerable<long>
{
public static readonly long[] Value=A280521.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280521.Bytes);
public long this[int i]=>Value[i];

public static A280521Inst Instance=new A280521Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280520
{
public static readonly long[] Value={ 1L,0L,1L,6L,1L,72L,6L,2320L,72L,245765L,2320L,151182379L,245765L };
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
public class A280520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280520Inst : IEnumerable<long>
{
public static readonly long[] Value=A280520.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280520.Bytes);
public long this[int i]=>Value[i];

public static A280520Inst Instance=new A280520Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280519
{
public static readonly long[] Value={ 1L,1L,1L,10L,3L,1L,215L,41L,6L,1L,12231L,1115L,105L,10L,1L,2025462L,74862L,3466L,215L,15L,1L,1351857641L,14294210L,267281L,8372L,385L,21L,1L,6255560531733L,10837663111L,57646358L,727049L,17318L,630L,28L,1L };
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
public class A280519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280519Inst : IEnumerable<long>
{
public static readonly long[] Value=A280519.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280519.Bytes);
public long this[int i]=>Value[i];

public static A280519Inst Instance=new A280519Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280518
{
public static readonly long[] Value={ 1L,0L,1L,7L,78L,2392L,248085L,151428144L };
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
public class A280518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280518Inst : IEnumerable<long>
{
public static readonly long[] Value=A280518.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280518.Bytes);
public long this[int i]=>Value[i];

public static A280518Inst Instance=new A280518Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280517
{
public static readonly long[] Value={ 1L,2L,14L,263L,13462L,2104021L,1366427911L,6266456586228L };
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
public class A280517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280517Inst : IEnumerable<long>
{
public static readonly long[] Value=A280517.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280517.Bytes);
public long this[int i]=>Value[i];

public static A280517Inst Instance=new A280517Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280452
{
public static readonly long[] Value={ 1L,1L,0L,0L,2L,2L,0L,0L,1L,3L,2L,0L,0L,4L,4L,0L,3L,5L,3L,1L,6L,6L,2L,2L,3L,11L,9L,1L,0L,16L,16L,0L,3L,11L,15L,7L,10L,10L,14L,14L,11L,23L,19L,9L,6L,36L,32L,4L,5L,31L,46L,18L,16L,26L,48L,36L,25L,35L,38L,36L,20L,60L,60L,28L,20L,82L,98L,30L,31L,65L,104L,64L,40L };
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
public class A280452Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280452.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280452Inst : IEnumerable<long>
{
public static readonly long[] Value=A280452.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280452.Bytes);
public long this[int i]=>Value[i];

public static A280452Inst Instance=new A280452Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280451
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,4L,5L,7L,9L,13L,16L,20L,27L,34L,42L,53L,67L,82L,102L,125L,153L,188L,227L,274L,332L,401L,478L,574L,686L,815L,969L,1147L,1356L,1600L,1884L,2210L,2597L,3040L,3547L,4141L,4824L,5607L,6508L,7546L,8732L,10100L,11656L,13431L,15473L,17793L,20429L,23436L };
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
public class A280451Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280451.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280451Inst : IEnumerable<long>
{
public static readonly long[] Value=A280451.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280451.Bytes);
public long this[int i]=>Value[i];

public static A280451Inst Instance=new A280451Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280450
{
public static readonly long[] Value={ 4L,8L,9L,14L,22L,21L,16L,32L,27L,26L,46L,33L,38L,58L,62L,44L,39L,57L,45L,55L,49L,52L,94L,86L,64L,106L,75L,63L,118L,77L,74L,104L,134L,92L,142L,91L,82L,93L,158L,162L,166L,128L,116L,115L,95L,99L,111L,119L,122L,125L,206L,112L,214L,133L,117L,145L,178L,135L,153L,242L };
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
public class A280450Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280450.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280450Inst : IEnumerable<long>
{
public static readonly long[] Value=A280450.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280450.Bytes);
public long this[int i]=>Value[i];

public static A280450Inst Instance=new A280450Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280449
{
public static readonly long[] Value={ 2L,3L,5L,6L,8L,11L,15L,25L,38L,54L,101L,105L,158L,295L,303L,389L,482L,558L,693L,1965L,3503L,9818L,13255L,30351L,51285L,54767L,57384L,88808L };
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
public class A280449Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280449.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280449Inst : IEnumerable<long>
{
public static readonly long[] Value=A280449.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280449.Bytes);
public long this[int i]=>Value[i];

public static A280449Inst Instance=new A280449Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280448
{
public static readonly long[] Value={ 1L,3L,4L,4L,6L,10L,9L,7L,6L,20L,15L,11L,17L,28L,19L,11L,23L,23L,25L,27L,36L,48L,30L,24L,12L,55L,16L,35L,39L,56L,41L,20L,55L,73L,55L,44L,50L,81L,65L,39L,53L,96L,56L,71L,33L,97L,63L,40L,29L,53L,88L,83L,71L,63L,91L,68L,98L,126L,78L,87L,80L,134L,65L,40L,107L,147L,89L,107L,119L };
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
public class A280448Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280448.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280448Inst : IEnumerable<long>
{
public static readonly long[] Value=A280448.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280448.Bytes);
public long this[int i]=>Value[i];

public static A280448Inst Instance=new A280448Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280447
{
public static readonly long[] Value={ 176594L,281894L,371894L,446594L,1765940L,2818940L,2822594L,3718940L,3722594L,4465940L,17659400L,28189400L,28225940L,37189400L,37225940L,44659400L };
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
public class A280447Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280447.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280447Inst : IEnumerable<long>
{
public static readonly long[] Value=A280447.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280447.Bytes);
public long this[int i]=>Value[i];

public static A280447Inst Instance=new A280447Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280446
{
public static readonly long[] Value={ 5848L,6884L,58480L,68840L,394062L,584800L,688400L,3940620L,5848000L,6884000L,39406200L,58480000L,68840000L };
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
public class A280446Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280446.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280446Inst : IEnumerable<long>
{
public static readonly long[] Value=A280446.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280446.Bytes);
public long this[int i]=>Value[i];

public static A280446Inst Instance=new A280446Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280445
{
public static readonly long[] Value={ 655L,5848L,176594L,25820986L,1394797593315L };
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
public class A280445Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280445.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280445Inst : IEnumerable<long>
{
public static readonly long[] Value=A280445.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280445.Bytes);
public long this[int i]=>Value[i];

public static A280445Inst Instance=new A280445Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280444
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,2L,1L,1L,2L,3L,4L,1L,2L,1L,1L,1L,2L,3L,1L,1L,2L,1L,2L,1L,2L,1L,1L,2L,1L,2L,1L,2L,3L,6L,1L,2L,1L,1L,2L,1L,1L,1L,2L,3L,1L,2L,3L,1L,2L,1L,1L,1L,1L,2L,3L,4L,1L,1L,2L,3L,1L,1L,2L,3L,4L,1L,2L,3L,1L,1L,2L,1L,2L,3L,1L,2L,1L,1L,1L };
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
public class A280444Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280444.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280444Inst : IEnumerable<long>
{
public static readonly long[] Value=A280444.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280444.Bytes);
public long this[int i]=>Value[i];

public static A280444Inst Instance=new A280444Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280443
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,11L,1L,1L,1L,1L,11L,17L,1L,23L,1L,11L,1L,1L,1L,17L,11L,1L,1L,1L,23L,11L,43L,17L,1L,1L,121L,1L,1L,1L,1L,4301L,1L,1L,1L,73L,11L,1L,1L,17L,1L,11L,23L,43L,1L,1L,11L,17L,1L,1L,1L,11L,101L,23L,89L,17L,11L,1L,1L,83L,1L,11L,1L };
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
public class A280443Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280443.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280443Inst : IEnumerable<long>
{
public static readonly long[] Value=A280443.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280443.Bytes);
public long this[int i]=>Value[i];

public static A280443Inst Instance=new A280443Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280442
{
public static readonly BigInteger[] Value={ 1L,1L,11L,173L,22931L,1319183L,233526463L,29412432709L,39959591850371L,8797116290975003L,4872532317019728133L,BigInteger.Parse("1657631603843299234219"),BigInteger.Parse("2718086236621937756966743"),BigInteger.Parse("1321397724505770800453750299"),BigInteger.Parse("1503342018433974345747514544039") };
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
public class A280442Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280442.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280442Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A280442.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A280442.Bytes);
public BigInteger this[int i]=>Value[i];

public static A280442Inst Instance=new A280442Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280441
{
public static readonly long[] Value={ 4L,9L,4L,25L,55L,49L,9L,25L,49L,121L,253L,49L,529L,129L,121L,125L,515L,133L,961L,121L,25L,529L,1081L,169L,917L,471L,361L,377L,1711L,121L,2809L,289L,529L,721L,319L,169L,2831L,1145L,961L,289L,3403L,497L,49L,529L,361L,1529L,4811L,289L,841L,781L,1339L,1369L,5671L,361L };
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
public class A280441Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280441.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280441Inst : IEnumerable<long>
{
public static readonly long[] Value=A280441.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280441.Bytes);
public long this[int i]=>Value[i];

public static A280441Inst Instance=new A280441Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280440
{
public static readonly long[] Value={ 0L,0L,0L,1L,4L,1L,2L,10L,10L,2L,5L,20L,21L,20L,5L,10L,38L,42L,42L,38L,10L,20L,68L,77L,80L,77L,68L,20L,38L,120L,136L,138L,138L,136L,120L,38L,71L,208L,236L,232L,225L,232L,236L,208L,71L,130L,358L,404L,386L,360L,360L,386L,404L,358L,130L,235L,612L,687L,640L,574L,548L,574L,640L,687L };
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
public class A280440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280440Inst : IEnumerable<long>
{
public static readonly long[] Value=A280440.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280440.Bytes);
public long this[int i]=>Value[i];

public static A280440Inst Instance=new A280440Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280439
{
public static readonly long[] Value={ 20L,120L,236L,386L,574L,834L,1211L,1784L,2684L,4128L,6478L,10334L,16693L,27208L,44620L,73470L,121278L,200490L,331695L,548936L,908476L,1503260L,2486766L,4112326L,6797929L,11232984L,18554156L,30634874L,50561854L,83419218L,137578403L };
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
public class A280439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280439Inst : IEnumerable<long>
{
public static readonly long[] Value=A280439.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280439.Bytes);
public long this[int i]=>Value[i];

public static A280439Inst Instance=new A280439Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280438
{
public static readonly long[] Value={ 10L,68L,136L,232L,360L,548L,834L,1284L,2008L,3188L,5128L,8332L,13638L,22436L,37032L,61248L,101416L,168020L,278410L,461284L,764088L,1265228L,2094216L,3464892L,5730190L,9472388L,15651784L,25851544L,42680808L,70438148L,116203218L,191632452L };
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
public class A280438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280438Inst : IEnumerable<long>
{
public static readonly long[] Value=A280438.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280438.Bytes);
public long this[int i]=>Value[i];

public static A280438Inst Instance=new A280438Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280437
{
public static readonly long[] Value={ 5L,38L,77L,138L,225L,360L,574L,920L,1487L,2422L,3971L,6542L,10814L,17914L,29713L,49314L,81861L,135876L,225470L,373996L,620083L,1027598L,1702087L,2817898L,4662910L,7712270L,12749909L,21068730L,34800297L,57457632L,94828606L,156445952L };
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
public class A280437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280437Inst : IEnumerable<long>
{
public static readonly long[] Value=A280437.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280437.Bytes);
public long this[int i]=>Value[i];

public static A280437Inst Instance=new A280437Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280388
{
public static readonly long[] Value={ 43L,53L,97L,107L,1613L,2423L,3331L,3631L,4241L,4643L,5147L,5347L,5653L,5953L,6361L,6661L,6761L,6967L,7573L,7673L,7873L,8179L,8783L,9689L,102101L,106103L,108107L,111109L,114113L,116113L,123113L,125113L,129127L,130127L,135131L,137131L,144139L,145139L,147139L,148139L };
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
public class A280388Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280388.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280388Inst : IEnumerable<long>
{
public static readonly long[] Value=A280388.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280388.Bytes);
public long this[int i]=>Value[i];

public static A280388Inst Instance=new A280388Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280387
{
public static readonly long[] Value={ 4L,8L,9L,16L,21L,25L,27L,32L,36L,45L,49L,64L,81L,87L,91L,99L,121L,125L,128L,144L,169L,196L,217L,243L,256L,289L,325L,343L,361L,400L,417L,481L,512L,529L,559L,625L,685L,697L,703L,721L,729L,745L,749L,775L,801L,841L,925L,931L,961L };
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
public class A280387Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280387.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280387Inst : IEnumerable<long>
{
public static readonly long[] Value=A280387.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280387.Bytes);
public long this[int i]=>Value[i];

public static A280387Inst Instance=new A280387Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280386
{
public static readonly long[] Value={ 1L,2L,3L,3L,4L,5L,4L,4L,4L,6L,5L,6L,5L,6L,5L,5L,5L,6L,7L,7L,6L,7L,7L,5L,4L,7L,7L,9L,5L,7L,8L,7L,6L,5L,9L,6L,8L,8L,6L,10L,6L,9L,7L,8L,5L,7L,10L,7L,5L,6L,9L,9L,7L,10L,11L,10L,6L,9L,8L,5L,5L,8L,10L,10L,6L,8L,10L,10L,7L,8L,9L,10L,8L,8L,8L,9L,10L,7L,8L,11L };
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
public class A280386Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280386.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280386Inst : IEnumerable<long>
{
public static readonly long[] Value=A280386.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280386.Bytes);
public long this[int i]=>Value[i];

public static A280386Inst Instance=new A280386Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280385
{
public static readonly long[] Value={ 0L,4L,13L,17L,42L,55L,104L,108L,117L,146L,267L,280L,449L,502L,536L,540L,829L,842L,1203L,1232L,1290L,1415L,1944L,1957L,1982L,2155L,2164L,2217L,3058L,3096L,4057L,4061L,4191L,4484L,4558L,4571L,5940L,6305L,6483L,6512L,8193L,8255L,10104L,10229L,10263L,10796L,13005L,13018L,13067L,13096L,13394L,13567L,16376L,16389L,16535L };
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
public class A280385Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280385.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280385Inst : IEnumerable<long>
{
public static readonly long[] Value=A280385.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280385.Bytes);
public long this[int i]=>Value[i];

public static A280385Inst Instance=new A280385Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280384
{
public static readonly long[] Value={ 1L,3L,-1L,-5L,8L,-1L,-28L,11L,10L,-41L,41L,26L,-53L,84L,21L,-101L,76L,3L,-129L,99L,14L,-190L,187L,59L,-299L,263L,62L,-336L,340L,27L,-459L,370L,111L,-645L,518L,228L,-774L,806L,179L,-973L,882L,147L,-1233L,955L,291L,-1565L,1325L,395L,-1883L,1767L,338L,-2318L,1994L };
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
public class A280384Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280384.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280384Inst : IEnumerable<long>
{
public static readonly long[] Value=A280384.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280384.Bytes);
public long this[int i]=>Value[i];

public static A280384Inst Instance=new A280384Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280383
{
public static readonly long[] Value={ 4L,6L,12L,18L,19L,30L,34L,42L,51L,55L,56L,60L,72L,86L,92L,94L,102L,108L,138L,142L,144L,150L,160L,180L,184L,186L,192L,198L,202L,204L,214L,216L,218L,220L,228L,236L,240L,243L,248L,249L,266L,270L,282L,300L,302L,304L,307L,312L,320L,322L,328L,340L,341L,348L,349L,392L,394L,412L,414L,416L,420L,424L,432L,446L,452L,462L,470L,472L,476L,491L,516L,518L,522L,534L,536L,544L,552L,570L,580L,582L,590L,600L,604L,618L,634L,638L,642L,660L,664L,668L,670L,680L,686L,688L,696L,698L,701L,722L };
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
public class A280383Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280383.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280383Inst : IEnumerable<long>
{
public static readonly long[] Value=A280383.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280383.Bytes);
public long this[int i]=>Value[i];

public static A280383Inst Instance=new A280383Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280382
{
public static readonly long[] Value={ 4L,5L,6L,12L,18L,19L,29L,30L,34L,42L,43L,50L,51L,55L,56L,60L,67L,69L,72L,77L,86L,89L,92L,94L,102L,108L,115L,120L,122L,138L,142L,144L,150L,151L,160L,171L,173L,180L,184L,186L,187L,189L,192L,197L,198L,202L,204L,214L,216L,218L,220L,228L,233L,236L,237L,240L,243L,245L,248L,249L,266L,267L,270L,271L,274L,282L };
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
public class A280382Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280382.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280382Inst : IEnumerable<long>
{
public static readonly long[] Value=A280382.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280382.Bytes);
public long this[int i]=>Value[i];

public static A280382Inst Instance=new A280382Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280381
{
public static readonly long[] Value={ 1L,2L,5L,6L,8L,12L,13L,14L,19L,61L,127L,137L,173L,175L,305L,540L,617L,935L,1398L,1834L,3295L,4351L,9188L,10808L,39409L,57325L,63798L,67091L };
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
public class A280381Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280381.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280381Inst : IEnumerable<long>
{
public static readonly long[] Value=A280381.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280381.Bytes);
public long this[int i]=>Value[i];

public static A280381Inst Instance=new A280381Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280380
{
public static readonly long[] Value={ 1L,2L,30L,46L,374L,2146L,5945L,14855L,24702L };
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
public class A280380Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280380.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280380Inst : IEnumerable<long>
{
public static readonly long[] Value=A280380.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280380.Bytes);
public long this[int i]=>Value[i];

public static A280380Inst Instance=new A280380Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280379
{
public static readonly long[] Value={ 0L,1L,1L,1L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,0L,1L,1L,1L,1L,0L,0L,1L,0L,1L,2L,0L,1L,1L,2L,0L,0L,1L,1L,0L,1L,0L,0L,1L,2L,2L,3L,2L,1L,0L,0L,0L,0L,0L,1L,1L,0L,0L,1L,1L,0L,1L,2L,0L,0L,1L,1L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,1L,1L,0L };
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
public class A280379Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280379.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280379Inst : IEnumerable<long>
{
public static readonly long[] Value=A280379.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280379.Bytes);
public long this[int i]=>Value[i];

public static A280379Inst Instance=new A280379Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280378
{
public static readonly BigInteger[] Value={ 1L,1L,2L,6L,144L,1440L,1036800L,326592000L,1463132160000L,6636767477760000L,BigInteger.Parse("24083501823295488000000"),BigInteger.Parse("278164446059062886400000000"),BigInteger.Parse("133241214725404817086218240000000000"),BigInteger.Parse("1851999588197236795571599048704000000000000"),BigInteger.Parse("79730449087475946864047275218548293632000000000000") };
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
public class A280378Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280378.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280378Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A280378.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A280378.Bytes);
public BigInteger this[int i]=>Value[i];

public static A280378Inst Instance=new A280378Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280377
{
public static readonly BigInteger[] Value={ 1L,2L,4L,7L,31L,41L,761L,1076L,5556L,10092L,3638892L,3650442L,482652042L,496551642L,539602650L,1178115525L,20923968003525L,20925873907525L,6423299579635525L,6423418373678893L,6491526825518893L,11027299390478893L,BigInteger.Parse("1124011755076998158893"),BigInteger.Parse("1124011800169644507643") };
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
public class A280377Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280377.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280377Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A280377.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A280377.Bytes);
public BigInteger this[int i]=>Value[i];

public static A280377Inst Instance=new A280377Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280376
{
public static readonly long[] Value={ 23L,67L,811L,911L,1213L,2729L,3137L,3637L,4243L,4447L,4547L,5153L,5659L,6367L,6871L,6971L,7879L,8389L,8689L,9397L,9497L,9697L,98101L,102103L,104107L,105107L,108109L,115127L,117127L,118127L,123127L,126127L,132137L,138139L,150151L,151157L,154157L,156157L,157163L };
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
public class A280376Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280376.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280376Inst : IEnumerable<long>
{
public static readonly long[] Value=A280376.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280376.Bytes);
public long this[int i]=>Value[i];

public static A280376Inst Instance=new A280376Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280375
{
public static readonly long[] Value={ 1L,1L,1L,9L,1L,9L,1L,9L,28L,9L,1L,36L,1L,9L,28L,73L,1L,36L,1L,73L,28L,9L,1L,100L,126L,9L,28L,73L,1L,161L,1L,73L,28L,9L,126L,316L,1L,9L,28L,198L,1L,252L,1L,73L,153L,9L,1L,316L,344L,134L,28L,73L,1L,252L,126L,416L,28L,9L,1L,441L,1L,9L,371L,585L,126L,252L,1L,73L,28L,477L,1L,828L,1L,9L,153L,73L,344L,252L,1L,710L,757L,9L,1L,659L,126L };
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
public class A280375Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280375.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280375Inst : IEnumerable<long>
{
public static readonly long[] Value=A280375.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280375.Bytes);
public long this[int i]=>Value[i];

public static A280375Inst Instance=new A280375Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280374
{
public static readonly long[] Value={ 1L,1L,5L,1L,1L,5L,21L,65L,257L,5L,21L,65L,1L,5L,21L,65L,1L,5L,21L,65L,1L,5L,21L,65L,1L,5L,21L,65L,1L,5L,21L,65L,1L,5L,21L,65L,1L,5L,21L,65L,1L,5L,21L,65L,1L,5L,21L,65L,1L,5L,21L,65L,1L,5L,21L,65L,1L,5L,21L,65L,1L,5L,21L,65L,1L,5L,21L,65L,1L,5L,21L,65L,1L,5L };
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
public class A280374Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280374.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280374Inst : IEnumerable<long>
{
public static readonly long[] Value=A280374.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280374.Bytes);
public long this[int i]=>Value[i];

public static A280374Inst Instance=new A280374Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280373
{
public static readonly long[] Value={ 1L,2L,5L,8L,16L,40L,84L,130L,257L,640L,1344L,2080L,4096L,10240L,21504L,33280L,65536L,163840L,344064L,532480L,1048576L,2621440L,5505024L,8519680L,16777216L,41943040L,88080384L,136314880L,268435456L,671088640L,1409286144L,2181038080L,4294967296L,10737418240L };
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
public class A280373Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280373.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280373Inst : IEnumerable<long>
{
public static readonly long[] Value=A280373.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280373.Bytes);
public long this[int i]=>Value[i];

public static A280373Inst Instance=new A280373Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280340
{
public static readonly BigInteger[] Value={ 1L,1L,101L,1101L,1011101L,111111101L,1011212111101L,1112122222111101L,BigInteger.Parse("101122323232322111101"),BigInteger.Parse("1112223344434333322111101"),BigInteger.Parse("1011224344546565545343322111101"),BigInteger.Parse("111223345667777878776655443322111101"),BigInteger.Parse("1011224455769911213121200887756443322111101") };
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
public class A280340Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280340.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280340Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A280340.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A280340.Bytes);
public BigInteger this[int i]=>Value[i];

public static A280340Inst Instance=new A280340Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280339
{
public static readonly long[] Value={ 1L,2L,-1L,-2L,-5L,-14L,4L,12L,5L,40L,0L,-26L,11L,-68L,-15L,30L,-18L,106L,3L,-50L,-10L,-182L,29L,104L,10L,270L,11L,-130L,37L,-360L,-51L,164L,-16L,506L,-30L,-266L,-65L,-686L,62L,320L,53L,898L,22L,-414L,50L,-1206L,-61L,612L,-52L,1560L,-4L,-696L,-81L,-1958L,120L };
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
public class A280339Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280339.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280339Inst : IEnumerable<long>
{
public static readonly long[] Value=A280339.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280339.Bytes);
public long this[int i]=>Value[i];

public static A280339Inst Instance=new A280339Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280338
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,2L,4L,3L,4L,3L,4L,3L,6L,4L,3L,3L,5L,4L,6L,5L,4L,4L,4L,4L,6L,6L,6L,6L,6L,3L,8L,6L,4L,5L,6L,6L,9L,6L,6L,6L,8L,4L,8L,7L,7L,4L,4L,5L,8L,6L,5L,9L,6L,6L,6L,8L,6L,6L,4L,5L,12L,8L,6L,7L,6L,4L,8L,9L,4L,6L,8L,8L,12L,9L,7L,10L,8L,6L,8L,6L,9L,8L,4L,6L,5L,8L };
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
public class A280338Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280338.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280338Inst : IEnumerable<long>
{
public static readonly long[] Value=A280338.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280338.Bytes);
public long this[int i]=>Value[i];

public static A280338Inst Instance=new A280338Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280337
{
public static readonly long[] Value={ 1L,0L,7L,2L,29L,8L,119L,42L,261L,496L,575L,962L,5629L,2632L,24951L,32170L,35589L,51184L,387647L,152514L,1611261L,2067016L,2220407L,3825578L,24617221L,11090416L,114122303L,98478018L,44374525L,975435336L,389819767L,3419085738L,3164075269L,5627457008L };
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
public class A280337Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280337.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280337Inst : IEnumerable<long>
{
public static readonly long[] Value=A280337.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280337.Bytes);
public long this[int i]=>Value[i];

public static A280337Inst Instance=new A280337Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280336
{
public static readonly long[] Value={ 1L,0L,7L,4L,23L,4L,119L,84L,321L,62L,2018L,1084L,6133L,1172L,30531L,21950L,82338L,16268L,516797L,277668L,1570083L,300158L,7816130L,5634652L,21040093L,4092500L,132371867L,71194554L,401806504L,77328663L,2002394740L,1440273363L,5391766138L,1053875146L };
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
public class A280336Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280336.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280336Inst : IEnumerable<long>
{
public static readonly long[] Value=A280336.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280336.Bytes);
public long this[int i]=>Value[i];

public static A280336Inst Instance=new A280336Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280335
{
public static readonly BigInteger[] Value={ 1L,0L,111L,10L,11101L,1000L,1110111L,101010L,100000101L,111110000L,1000111111L,1111000010L,1010111111101L,101001001000L,110000101110111L,111110110101010L,1000101100000101L,1100011111110000L,1011110101000111111L,100101001111000010L,BigInteger.Parse("110001001010111111101") };
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
public class A280335Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280335.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280335Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A280335.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A280335.Bytes);
public BigInteger this[int i]=>Value[i];

public static A280335Inst Instance=new A280335Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280334
{
public static readonly BigInteger[] Value={ 1L,0L,111L,100L,10111L,100L,1110111L,1010100L,101000001L,111110L,11111100010L,10000111100L,1011111110101L,10010010100L,111011101000011L,101010110111110L,10100000110100010L,11111110001100L,1111110001010111101L,1000011110010100100L,BigInteger.Parse("101111111010100100011") };
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
public class A280334Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280334.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280334Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A280334.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A280334.Bytes);
public BigInteger this[int i]=>Value[i];

public static A280334Inst Instance=new A280334Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280333
{
public static readonly long[] Value={ 1L,1L,12L,815L,157762L,64916201L,48508522364L };
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
public class A280333Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280333.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280333Inst : IEnumerable<long>
{
public static readonly long[] Value=A280333.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280333.Bytes);
public long this[int i]=>Value[i];

public static A280333Inst Instance=new A280333Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280332
{
public static readonly long[] Value={ 1L,3L,1L,7L,9L,31L,9L,63L,193L,335L,761L,1807L,3057L,7199L,12265L,28703L,45921L,129711L,132441L,449199L,634321L,2051775L,2422601L,8338175L,9690369L,33386255L,38458169L,133513167L,153863409L,536632863L,605009897L,2087739423L,2679974753L,8066421423L,9260252505L };
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
public class A280332Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280332.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280332Inst : IEnumerable<long>
{
public static readonly long[] Value=A280332.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280332.Bytes);
public long this[int i]=>Value[i];

public static A280332Inst Instance=new A280332Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280331
{
public static readonly long[] Value={ 1L,3L,4L,14L,18L,62L,72L,252L,262L,970L,1274L,3854L,4602L,15886L,19450L,63502L,69018L,251262L,316674L,1004982L,1144498L,4152510L,4814738L,16735486L,16873362L,63167230L,82205330L,255838974L,300186258L,1042190334L,1274476562L,4161146430L,4524178418L };
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
public class A280331Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280331.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280331Inst : IEnumerable<long>
{
public static readonly long[] Value=A280331.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280331.Bytes);
public long this[int i]=>Value[i];

public static A280331Inst Instance=new A280331Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280330
{
public static readonly ulong[] Value={ 1L,11L,1L,111L,1001L,11111L,1001L,111111L,11000001L,101001111L,1011111001L,11100001111L,101111110001L,1110000011111L,10111111101001L,111000000011111L,1011001101100001L,11111101010101111L,100000010101011001L,1101101101010101111L,10011010110111010001UL };
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
public class A280330Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280330.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280330Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A280330.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280330.Bytes);
public ulong this[int i]=>Value[i];

public static A280330Inst Instance=new A280330Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280329
{
public static readonly ulong[] Value={ 1L,11L,100L,1110L,10010L,111110L,1001000L,11111100L,100000110L,1111001010L,10011111010L,111100001110L,1000111111010L,11111000001110L,100101111111010L,1111100000001110L,10000110110011010L,111101010101111110L,1001101010100000010L,11110101010110110110UL };
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
public class A280329Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280329.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280329Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A280329.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280329.Bytes);
public ulong this[int i]=>Value[i];

public static A280329Inst Instance=new A280329Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280328
{
public static readonly long[] Value={ 1L,-3L,-1L,5L,8L,1L,-28L,-11L,10L,41L,41L,-26L,-53L,-84L,21L,101L,76L,-3L,-129L,-99L,14L,190L,187L,-59L,-299L,-263L,62L,336L,340L,-27L,-459L,-370L,111L,645L,518L,-228L,-774L,-806L,179L,973L,882L,-147L,-1233L,-955L,291L,1565L,1325L,-395L,-1883L,-1767L,338L,2318L };
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
public class A280328Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280328.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280328Inst : IEnumerable<long>
{
public static readonly long[] Value=A280328.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280328.Bytes);
public long this[int i]=>Value[i];

public static A280328Inst Instance=new A280328Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280327
{
public static readonly long[] Value={ 4L,12L,25L,39L,60L,94L,133L,183L,236L,320L,415L,520L,640L,805L,1007L,1212L,1463L,1800L,2144L,2562L,3021L,3523L,4135L,4840L,5747L,6630L,7701L,9057L,10392L,11812L,13519L,15400L,17534L,19827L,22564L,25624L,29206L,32998L,37041L,41819L,46659L,53223L,59345L,66104L,73368L,81897L,91157L,100827L,112045L };
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
public class A280327Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280327.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280327Inst : IEnumerable<long>
{
public static readonly long[] Value=A280327.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280327.Bytes);
public long this[int i]=>Value[i];

public static A280327Inst Instance=new A280327Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280326
{
public static readonly long[] Value={ 11L,17L,23L,29L,37L,41L,59L,67L,71L,73L,83L,89L,101L,107L,131L,137L,157L,179L,191L,211L,233L,311L,317L,331L,337L,359L,419L,431L,443L,461L,467L,479L,521L,523L,541L,547L,557L,599L,607L,613L,617L,631L,683L,701L,727L,743L,751L,757L,809L,881L,887L,953L,991L,997L,1013L,1031L,1033L,1039L,1049L,1061L,1063L };
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
public class A280326Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280326.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280326Inst : IEnumerable<long>
{
public static readonly long[] Value=A280326.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280326.Bytes);
public long this[int i]=>Value[i];

public static A280326Inst Instance=new A280326Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280325
{
public static readonly long[] Value={ 261L,-187L,74L,-38L,36L,-2L,1L,0L };
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
public class A280325Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280325.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280325Inst : IEnumerable<long>
{
public static readonly long[] Value=A280325.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280325.Bytes);
public long this[int i]=>Value[i];

public static A280325Inst Instance=new A280325Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280276
{
public static readonly long[] Value={ 1L,2L,3L,5L,8L,12L,17L,24L,33L,46L,62L,82L,108L,141L,182L,233L,297L,375L,472L,590L,733L,907L,1117L,1369L,1671L,2034L,2465L,2978L,3586L,4304L,5152L,6149L,7319L,8689L,10293L,12162L,14340L,16871L,19806L,23207L,27139L,31678L,36909L,42932L,49851L,57794L,66897L };
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
public class A280276Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280276.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280276Inst : IEnumerable<long>
{
public static readonly long[] Value=A280276.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280276.Bytes);
public long this[int i]=>Value[i];

public static A280276Inst Instance=new A280276Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280275
{
public static readonly long[] Value={ 1L,1L,2L,5L,12L,37L,118L,387L,1312L,4445L,17034L,73339L,342532L,1616721L,7299100L,31195418L,129179184L,578924785L,3057167242L,18723356715L,120613872016L,738703713245L,4080301444740L,20353638923275L,95273007634552L,443132388701107L,2149933834972928L };
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
public class A280275Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280275.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280275Inst : IEnumerable<long>
{
public static readonly long[] Value=A280275.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280275.Bytes);
public long this[int i]=>Value[i];

public static A280275Inst Instance=new A280275Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280274
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,2L,1L,1L,1L,3L,1L,2L,1L,3L,2L,1L,1L,4L,1L,2L,2L,4L,1L,2L,1L,4L,1L,2L,1L,4L,1L,1L,3L,5L,2L,3L,1L,5L,3L,2L,1L,5L,1L,3L,2L,5L,1L,3L,1L,5L,3L,3L,1L,5L,2L,2L,3L,5L,1L,3L,1L,5L,2L,1L,2L,6L,1L,3L,3L,6L,1L,2L,1L,6L,3L,3L,2L,6L,1L,2L,1L,6L,1L,4L,2L,6L,4L,2L,1L,6L,2L,3L,4L,6L,2L,4L,1L,6L,2L,3L };
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
public class A280274Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280274.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280274Inst : IEnumerable<long>
{
public static readonly long[] Value=A280274.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280274.Bytes);
public long this[int i]=>Value[i];

public static A280274Inst Instance=new A280274Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280273
{
public static readonly long[] Value={ 3L,5L,23L,41L,59L,113L,131L,173L,179L,269L,281L,383L,401L,431L,443L,449L,461L,479L,521L,641L,653L,863L,929L,941L,953L,1013L,1103L,1163L,1301L,1319L,1361L,1439L,1481L,1559L,1583L,1871L,2003L,2213L,2309L,2411L,2609L,2693L,2711L,2729L,2801L,2903L,2909L,2969L,3041L };
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
public class A280273Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280273.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280273Inst : IEnumerable<long>
{
public static readonly long[] Value=A280273.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280273.Bytes);
public long this[int i]=>Value[i];

public static A280273Inst Instance=new A280273Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280272
{
public static readonly long[] Value={ 3L,6L,8L,9L,10L,17L,27L,28L,45L,81L,83L,225L,246L,1732L,2957L,3021L,5459L,5702L,5740L,7924L,15110L,18683L,25149L };
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
public class A280272Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280272.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280272Inst : IEnumerable<long>
{
public static readonly long[] Value=A280272.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280272.Bytes);
public long this[int i]=>Value[i];

public static A280272Inst Instance=new A280272Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280271
{
public static readonly long[] Value={ 1L,1L,2L,3L,3L,5L,5L,7L,8L,9L,11L,12L,14L,16L,18L,20L,23L,25L,29L,32L,36L,40L,44L,49L,54L,59L,65L,70L,76L,83L,89L,98L,105L,114L,123L,132L,143L,154L,165L,178L,190L,204L,219L,234L,251L,267L,285L,304L,324L,345L,368L,390L,415L,441L,468L,498L,527L,559L,591L,626L,663L,702L,742L,784L,828L,873L,923L,973L,1026L,1081L,1138L };
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
public class A280271Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280271.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280271Inst : IEnumerable<long>
{
public static readonly long[] Value=A280271.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280271.Bytes);
public long this[int i]=>Value[i];

public static A280271Inst Instance=new A280271Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280270
{
public static readonly long[] Value={ 6L,8L,12L,18L,20L,24L,28L,30L,32L,36L,40L,42L,44L,48L,50L,52L,54L,56L,60L,64L,66L,70L,72L,80L,84L,88L,90L,96L,108L,112L,116L,120L,126L,132L,140L,144L,148L,150L,156L,160L,162L,168L,174L,176L,180L,186L,188L,192L,196L,198L,200L,204L,210L,216L,220L,224L,230L,232L,234L,240L };
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
public class A280270Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280270.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280270Inst : IEnumerable<long>
{
public static readonly long[] Value=A280270.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280270.Bytes);
public long this[int i]=>Value[i];

public static A280270Inst Instance=new A280270Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280269
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,2L,1L,0L,1L,0L,1L,1L,1L,0L,1L,1L,0L,1L,2L,1L,3L,1L,0L,1L,0L,1L,1L,1L,1L,2L,2L,1L,0L,1L,0L,1L,2L,1L,3L,1L,0L,1L,1L,2L,1L,0L,1L,1L,1L,1L,0L,1L,0L,1L,1L,2L,1L,3L,1L,2L,4L,1L,0L,1L,0L,1L,1L,1L,2L,1L,2L,1L,0L,1L,1L,2L,1L,0L,1L,2L,3L,1L,4L,1L,0L,1L,0L,1L,1L,1L,1L,1L };
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
public class A280269Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280269.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280269Inst : IEnumerable<long>
{
public static readonly long[] Value=A280269.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280269.Bytes);
public long this[int i]=>Value[i];

public static A280269Inst Instance=new A280269Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280268
{
public static readonly long[] Value={ 2L,14L,26L,38L,86L,94L,106L,214L,218L };
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
public class A280268Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280268.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280268Inst : IEnumerable<long>
{
public static readonly long[] Value=A280268.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280268.Bytes);
public long this[int i]=>Value[i];

public static A280268Inst Instance=new A280268Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280267
{
public static readonly long[] Value={ 1L,0L,0L,1L,2L,2L,1L,1L,3L,4L,4L,4L,4L,6L,9L,27L,5L,8L,16L,256L,6L,10L,25L,3125L,7L,12L,36L,46656L,8L,14L,49L,823543L,9L,16L,64L,16777216L,10L,18L,81L,387420489L,11L,20L,100L,10000000000L,12L,22L,121L,285311670611L,13L,24L,144L,8916100448256L,14L,26L,169L,302875106592253L };
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
public class A280267Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280267.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280267Inst : IEnumerable<long>
{
public static readonly long[] Value=A280267.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280267.Bytes);
public long this[int i]=>Value[i];

public static A280267Inst Instance=new A280267Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280266
{
public static readonly long[] Value={ 5L,7L,13L,19L,31L,37L,43L,47L,53L,61L,73L,79L,89L,97L,137L,151L,167L,173L,193L,199L,223L,229L,241L,251L,271L,349L,353L,367L,379L,383L,409L,439L,457L,463L,487L,503L,521L,523L,587L,593L,619L,643L,647L,653L,727L,787L,797L,809L,829L,853L,859L,937L };
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
public class A280266Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280266.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280266Inst : IEnumerable<long>
{
public static readonly long[] Value=A280266.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280266.Bytes);
public long this[int i]=>Value[i];

public static A280266Inst Instance=new A280266Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280265
{
public static readonly long[] Value={ 3L,2L,0L,1L,1L,3L,3L,2L,1L,1L,3L,4L,4L,4L,4L,3L,5L,6L,9L,27L,3L,6L,8L,16L,256L,3L,7L,10L,25L,3125L,3L,8L,12L,36L,46656L,3L,9L,14L,49L,823543L,3L,10L,16L,64L,16777216L,3L,11L,18L,81L,387420489L,3L,12L,20L,100L,10000000000L,3L,13L,22L,121L,285311670611L,3L,14L,24L,144L,8916100448256L };
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
public class A280265Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280265.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280265Inst : IEnumerable<long>
{
public static readonly long[] Value=A280265.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280265.Bytes);
public long this[int i]=>Value[i];

public static A280265Inst Instance=new A280265Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280264
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,2L,2L,3L,2L,5L,4L,6L,7L,8L,10L,12L,15L,16L,21L,23L,28L,33L,38L,44L,51L,60L,68L,79L,91L,103L,120L,136L,156L,177L,202L,230L,260L,296L,333L,378L,425L,480L,540L,606L,682L,764L,857L,958L,1073L,1197L,1337L,1492L,1660L,1849L,2057L,2285L,2537L,2816L };
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
public class A280264Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280264.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280264Inst : IEnumerable<long>
{
public static readonly long[] Value=A280264.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280264.Bytes);
public long this[int i]=>Value[i];

public static A280264Inst Instance=new A280264Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280263
{
public static readonly long[] Value={ 1L,2L,2L,2L,2L,2L,2L,2L,4L,6L,6L,6L,6L,6L,6L,6L,8L,10L,10L,10L,10L,10L,10L,10L,12L,14L,14L,16L,18L,18L,18L,18L,20L,22L,22L,26L,30L,30L,30L,30L,32L,34L,34L,38L,42L,42L,42L,42L,44L,46L,46L,50L,54L,54L,56L,58L,60L,62L,62L,66L,70L,70L,74L,78L,82L,86L,86L,90L,94L };
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
public class A280263Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280263.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280263Inst : IEnumerable<long>
{
public static readonly long[] Value=A280263.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280263.Bytes);
public long this[int i]=>Value[i];

public static A280263Inst Instance=new A280263Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280262
{
public static readonly long[] Value={ 21L,33L,57L,65L,69L,77L,91L,93L,105L,129L,133L,141L,145L,161L,177L,185L,189L,201L,209L,213L,217L,225L,237L,249L,253L,265L,273L,297L,301L,305L,309L,321L,329L,341L,345L,369L,377L,381L,385L,393L,413L,417L,437L,441L,451L,453L,465L,469L,473L,481L,489L,497L,501L,505L,513L,517L,537L,545L,553L,559L,573L };
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
public class A280262Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280262.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280262Inst : IEnumerable<long>
{
public static readonly long[] Value=A280262.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280262.Bytes);
public long this[int i]=>Value[i];

public static A280262Inst Instance=new A280262Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280261
{
public static readonly long[] Value={ 0L,1L,-1L,0L,-1L,-1L,0L,-1L,1L,0L,1L,1L,0L,1L,-1L,0L,-1L,-1L,0L,-1L,1L,0L,1L,1L,0L,1L,-1L,0L,-1L,-1L,0L,-1L,1L,0L,1L,1L,0L,1L,-1L,0L,-1L,-1L,0L,-1L,1L,0L,1L,1L,0L,1L,-1L,0L,-1L,-1L,0L,-1L,1L,0L,1L,1L,0L,1L,-1L,0L,-1L,-1L,0L,-1L,1L,0L,1L,1L,0L,1L,-1L,0L,-1L,-1L,0L,-1L,1L,0L,1L,1L };
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
public class A280261Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280261.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280261Inst : IEnumerable<long>
{
public static readonly long[] Value=A280261.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280261.Bytes);
public long this[int i]=>Value[i];

public static A280261Inst Instance=new A280261Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280164
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,1L,0L,1L,0L,1L,2L,0L,0L,3L,0L,0L,1L,1L,0L,2L,0L,2L,1L,0L,1L,1L,0L,0L,2L,5L,0L,1L,0L,1L,2L,0L,0L,6L,0L,0L,1L,1L,0L,0L,2L,4L,2L,0L,0L,3L,0L,0L,1L,1L,2L,3L,0L,1L,1L,2L,0L,5L,0L,0L,3L,2L,2L,2L,0L,5L,0L,0L,0L,6L,1L,1L,1L };
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
public class A280164Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280164.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280164Inst : IEnumerable<long>
{
public static readonly long[] Value=A280164.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280164.Bytes);
public long this[int i]=>Value[i];

public static A280164Inst Instance=new A280164Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280163
{
public static readonly long[] Value={ 4L,9L,32L,25L,12L,49L,48L,54L,20L,121L,96L,169L,28L,45L,144L,289L,162L,361L,160L,63L,44L,529L,-1L,250L,52L,-1L,224L,841L,60L,961L,320L,99L,68L,175L,180L,1369L,76L,117L,240L,1681L,84L,1849L,352L,270L,92L,2209L,-1L,686L,-1L,153L,416L,2809L,-1L,275L,336L,171L,116L };
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
public class A280163Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280163.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280163Inst : IEnumerable<long>
{
public static readonly long[] Value=A280163.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280163.Bytes);
public long this[int i]=>Value[i];

public static A280163Inst Instance=new A280163Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280162
{
public static readonly long[] Value={ 1L,67L,212L,1983L,1120L,14204L,3652L,43339L,24033L,75040L,19156L,420396L,35872L,244684L,237440L,821335L,99472L,1610211L,152404L,2220960L,774224L,1283452L,318532L,9187868L,810969L,2403424L,2222704L,7241916L,783904L,15908480L,1016836L,14445411L,4061072L,6664624L,4090240L,47657439L,2031712L };
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
public class A280162Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280162.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280162Inst : IEnumerable<long>
{
public static readonly long[] Value=A280162.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280162.Bytes);
public long this[int i]=>Value[i];

public static A280162Inst Instance=new A280162Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280161
{
public static readonly long[] Value={ 0L,0L,0L,2L,4L,2L,2L,8L,8L,2L,5L,18L,31L,18L,5L,8L,40L,94L,94L,40L,8L,15L,92L,305L,424L,305L,92L,15L,26L,208L,950L,1854L,1854L,950L,208L,26L,46L,470L,2901L,7628L,10677L,7628L,2901L,470L,46L,80L,1060L,8728L,30874L,58852L,58852L,30874L,8728L,1060L,80L,139L,2384L,26068L };
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
public class A280161Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280161.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280161Inst : IEnumerable<long>
{
public static readonly long[] Value=A280161.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280161.Bytes);
public long this[int i]=>Value[i];

public static A280161Inst Instance=new A280161Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280160
{
public static readonly long[] Value={ 15L,208L,2901L,30874L,318220L,3138340L,30089398L,285461736L,2671391625L,24767920958L,227975959120L,2085061428192L,18968539604655L,171769706597400L,1549174969429286L,13922125649869206L,124717748809003344L };
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
public class A280160Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280160.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280160Inst : IEnumerable<long>
{
public static readonly long[] Value=A280160.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280160.Bytes);
public long this[int i]=>Value[i];

public static A280160Inst Instance=new A280160Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280159
{
public static readonly long[] Value={ 8L,92L,950L,7628L,58852L,434790L,3138340L,22348406L,157294986L,1097158250L,7598014364L,52296147282L,358119530526L,2441393217986L,16579221466148L,112199621622362L,756987753165838L,5093205986747148L,34183505883347834L };
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
public class A280159Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280159.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280159Inst : IEnumerable<long>
{
public static readonly long[] Value=A280159.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280159.Bytes);
public long this[int i]=>Value[i];

public static A280159Inst Instance=new A280159Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280158
{
public static readonly long[] Value={ 5L,40L,305L,1854L,10677L,58852L,318220L,1695030L,8941285L,46760710L,242970442L,1255597078L,6458360287L,33085037590L,168885713050L,859370947890L,4360537440625L,22069557056618L,111441207638795L,561547964534696L };
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
public class A280158Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280158.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280158Inst : IEnumerable<long>
{
public static readonly long[] Value=A280158.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280158.Bytes);
public long this[int i]=>Value[i];

public static A280158Inst Instance=new A280158Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280157
{
public static readonly long[] Value={ 2L,18L,94L,424L,1854L,7628L,30874L,123312L,488256L,1920790L,7513678L,29249892L,113386708L,437908264L,1685639238L,6469357240L,24762845248L,94557090250L,360277506538L,1369975634630L,5199885300498L,19703519987286L,74545164231536L };
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
public class A280157Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280157.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280157Inst : IEnumerable<long>
{
public static readonly long[] Value=A280157.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280157.Bytes);
public long this[int i]=>Value[i];

public static A280157Inst Instance=new A280157Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280156
{
public static readonly long[] Value={ 2L,8L,31L,94L,305L,950L,2901L,8728L,26068L,77326L,228367L,671446L,1967328L,5745190L,16730555L,48594066L,140815777L,407186706L,1175159395L,3385527188L,9737463217L,27964574958L,80197812317L,229694924100L,657073271390L,1877519404364L };
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
public class A280156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280156Inst : IEnumerable<long>
{
public static readonly long[] Value=A280156.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280156.Bytes);
public long this[int i]=>Value[i];

public static A280156Inst Instance=new A280156Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280155
{
public static readonly long[] Value={ 0L,4L,8L,18L,40L,92L,208L,470L,1060L,2384L,5352L,11992L,26824L,59906L,133592L,297510L,661720L,1470062L,3262264L,7231940L,16016596L,35439722L,78349800L,173074816L,382029988L,842648168L,1857362384L,4091321478L,9006604780L,19815365450L };
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
public class A280155Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280155.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280155Inst : IEnumerable<long>
{
public static readonly long[] Value=A280155.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280155.Bytes);
public long this[int i]=>Value[i];

public static A280155Inst Instance=new A280155Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280154
{
public static readonly long[] Value={ 10L,5L,15L,20L,35L,55L,90L,145L,235L,380L,615L,995L,1610L,2605L,4215L,6820L,11035L,17855L,28890L,46745L,75635L,122380L,198015L,320395L,518410L,838805L,1357215L,2196020L,3553235L,5749255L,9302490L,15051745L,24354235L,39405980L,63760215L,103166195L,166926410L,270092605L,437019015L };
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
public class A280154Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280154.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280154Inst : IEnumerable<long>
{
public static readonly long[] Value=A280154.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280154.Bytes);
public long this[int i]=>Value[i];

public static A280154Inst Instance=new A280154Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280153
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,2L,1L,2L,2L,1L,3L,2L,3L,2L,2L,2L,1L,5L,2L,3L,4L,2L,3L,1L,4L,3L,4L,5L,4L,5L,2L,4L,4L,6L,3L,1L,6L,1L,2L,4L,3L,4L,3L,6L,3L,3L,4L,3L,5L,2L,3L,1L,5L,3L,2L,5L,2L,3L,3L,6L,3L,1L,5L,3L,4L,6L,6L,8L,7L,4L,5L,6L,3L,5L,7L,5L,3L,3L,5L,4L };
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
public class A280153Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280153.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280153Inst : IEnumerable<long>
{
public static readonly long[] Value=A280153.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280153.Bytes);
public long this[int i]=>Value[i];

public static A280153Inst Instance=new A280153Inst();

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