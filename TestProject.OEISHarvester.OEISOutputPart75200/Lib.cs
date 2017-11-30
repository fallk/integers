using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A271428
{
public static readonly long[] Value={ 3L,6L,24L,42L,48L,86L,102L,138L,182L,302L,438L,506L,926L,1266L,3600L,23550L,24122L,42410L,51432L,82290L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271428Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271428.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271428Inst : IEnumerable<long>
{
public static readonly long[] Value=A271428.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271428.Bytes);
public long this[int i]=>Value[i];

public static A271428Inst Instance=new A271428Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271429
{
public static readonly BigInteger[] Value={ 2L,11L,197L,521L,3571L,20633237L,54018521L,370248451L,119218851371L,5600748293801L,10420180999117162547UL,BigInteger.Parse("412670427844921037470771"),BigInteger.Parse("258899611203303418721656157249445530046830073044201152332257717521") };
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
public class A271429Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271429.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271429Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A271429.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A271429.Bytes);
public BigInteger this[int i]=>Value[i];

public static A271429Inst Instance=new A271429Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271430
{
public static readonly long[] Value={ 1L,2L,5L,6L,8L,17L,18L,20L,26L,30L,45L,56L,156L,176L,306L,308L,548L,680L,1197L,2393L,2396L,3870L,4397L,7224L,9734L,17724L,25584L,31793L,44924L,70028L,79760L,91544L,96600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271430Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271430.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271430Inst : IEnumerable<long>
{
public static readonly long[] Value=A271430.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271430.Bytes);
public long this[int i]=>Value[i];

public static A271430Inst Instance=new A271430Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271431
{
public static readonly long[] Value={ 1103L,1109L,1123L,1163L,1181L,1193L,1301L,1303L,1319L,1321L,1327L,1361L,1777L,1783L,1907L,1913L,1931L,1933L,1949L,1951L,1979L,1987L,1993L,1997L,2113L,2131L,2161L,2311L,2333L,2339L,2347L,2377L,2381L,2389L,2393L,2399L,2707L,2713L,2729L,2741L,2777L,2791L,2909L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271431Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271431.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271431Inst : IEnumerable<long>
{
public static readonly long[] Value=A271431.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271431.Bytes);
public long this[int i]=>Value[i];

public static A271431Inst Instance=new A271431Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271432
{
public static readonly BigInteger[] Value={ 1L,0L,24L,192L,3384L,51840L,911040L,16369920L,307009080L,5902176000L,116083727424L,2323941903360L,47232891389376L,972252599205888L,20233078205573376L,425067670281526272L,9004456318854367800L,BigInteger.Parse("192148701659269774848") };
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
public class A271432Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271432.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271432Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A271432.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A271432.Bytes);
public BigInteger this[int i]=>Value[i];

public static A271432Inst Instance=new A271432Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271433
{
public static readonly BigInteger[] Value={ 0L,0L,12L,864L,41328L,2009952L,116220672L,8608449792L,850781715456L,114969127987200L,21579927922212864L,5686939126548676608L,BigInteger.Parse("2120212910213354962944") };
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
public class A271433Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271433.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271433Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A271433.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A271433.Bytes);
public BigInteger this[int i]=>Value[i];

public static A271433Inst Instance=new A271433Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271434
{
public static readonly long[] Value={ 0L,0L,12L,1503L,114696L,8913024L,847131696L,107419889151L,19047514016106L,4855914055193274L,1811510852881383396L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271434Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271434.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271434Inst : IEnumerable<long>
{
public static readonly long[] Value=A271434.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271434.Bytes);
public long this[int i]=>Value[i];

public static A271434Inst Instance=new A271434Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271435
{
public static readonly long[] Value={ 0L,0L,12L,1620L,148392L,14979216L,1978392960L,370450049664L,102638643985920L,43175669754811392L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271435Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271435.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271435Inst : IEnumerable<long>
{
public static readonly long[] Value=A271435.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271435.Bytes);
public long this[int i]=>Value[i];

public static A271435Inst Instance=new A271435Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271436
{
public static readonly long[] Value={ 0L,0L,12L,1629L,153984L,16992846L,2653292322L,639869193777L,247683857110080L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271436Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271436.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271436Inst : IEnumerable<long>
{
public static readonly long[] Value=A271436.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271436.Bytes);
public long this[int i]=>Value[i];

public static A271436Inst Instance=new A271436Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271437
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,12L,0L,0L,0L,12L,864L,0L,0L,0L,12L,1503L,41328L,0L,0L,0L,12L,1620L,114696L,2009952L,0L,0L,0L,12L,1629L,148392L,8913024L,116220672L,0L,0L,0L,12L,1629L,153984L,14979216L,847131696L,8608449792L,0L,0L,0L,12L,1629L,154296L,16992846L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271437Inst : IEnumerable<long>
{
public static readonly long[] Value=A271437.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271437.Bytes);
public long this[int i]=>Value[i];

public static A271437Inst Instance=new A271437Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271438
{
public static readonly long[] Value={ 1L,17L,451L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271438Inst : IEnumerable<long>
{
public static readonly long[] Value=A271438.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271438.Bytes);
public long this[int i]=>Value[i];

public static A271438Inst Instance=new A271438Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271439
{
public static readonly long[] Value={ 0L,0L,1L,0L,2L,3L,0L,4L,5L,6L,0L,7L,8L,9L,10L,0L,11L,12L,13L,14L,15L,0L,16L,17L,18L,19L,20L,21L,0L,22L,23L,24L,25L,26L,27L,28L,0L,29L,30L,31L,32L,33L,34L,35L,36L,0L,37L,38L,39L,40L,41L,42L,43L,44L,45L,0L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,0L,56L,57L,58L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271439Inst : IEnumerable<long>
{
public static readonly long[] Value=A271439.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271439.Bytes);
public long this[int i]=>Value[i];

public static A271439Inst Instance=new A271439Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271440
{
public static readonly BigInteger[] Value={ 2L,7L,56L,743L,30746L,773527L,49783736L,1837403019L,160181560802L,29532404308019L,1666577516860962L,360777399719461393L,BigInteger.Parse("45691067858241526814"),BigInteger.Parse("3477439299142731351087"),BigInteger.Parse("518913689466371066697746"),BigInteger.Parse("147680787468230866751370317"),BigInteger.Parse("43490064769447225534580532962") };
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
public class A271440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271440Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A271440.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A271440.Bytes);
public BigInteger this[int i]=>Value[i];

public static A271440Inst Instance=new A271440Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271441
{
public static readonly long[] Value={ 2L,3L,4L,7L,8L,11L,12L,16L,19L,20L,28L,40L,48L,52L,100L,108L,112L,124L,125L,133L,258L,259L,260L,308L,336L,348L,349L,350L,362L,363L,391L,651L,1042L,1043L,1044L,1406L,1407L,1408L,1436L,1437L,1438L,1439L,1440L,1448L,1449L,1709L,1710L,1835L,1836L,1948L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271441Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271441.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271441Inst : IEnumerable<long>
{
public static readonly long[] Value=A271441.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271441.Bytes);
public long this[int i]=>Value[i];

public static A271441Inst Instance=new A271441Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271442
{
public static readonly long[] Value={ 2L,1L,50L,22100L,6409000L,32045000L,1185665000L,11856650000L,628402450000L,1169065690000L,16338463700000L,81692318500000L,875993015300000L,1388769414500000L,8054862604100000L,88701519427300000L,443507597136500000L,80548626041000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271442Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271442.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271442Inst : IEnumerable<long>
{
public static readonly long[] Value=A271442.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271442.Bytes);
public long this[int i]=>Value[i];

public static A271442Inst Instance=new A271442Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271443
{
public static readonly long[] Value={ 8L,80L,1375L,22624L,18035622L,4379776620L,1204244328624L,2604639091138248L,2604639091138248L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271443Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271443.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271443Inst : IEnumerable<long>
{
public static readonly long[] Value=A271443.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271443.Bytes);
public long this[int i]=>Value[i];

public static A271443Inst Instance=new A271443Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271508
{
public static readonly long[] Value={ 1L,4L,11L,14L,21L,24L,31L,34L,41L,44L,51L,54L,61L,64L,71L,74L,81L,84L,91L,94L,101L,104L,111L,114L,121L,124L,131L,134L,141L,144L,151L,154L,161L,164L,171L,174L,181L,184L,191L,194L,201L,204L,211L,214L,221L,224L,231L,234L,241L,244L,251L,254L,261L,264L,271L,274L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271508Inst : IEnumerable<long>
{
public static readonly long[] Value=A271508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271508.Bytes);
public long this[int i]=>Value[i];

public static A271508Inst Instance=new A271508Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271509
{
public static readonly long[] Value={ 5L,5L,5L,5L,2L,13L,13L,13L,13L,14L,17L,17L,17L,17L,14L,25L,25L,25L,25L,34L,29L,29L,29L,29L,2L,37L,37L,37L,37L,46L,41L,41L,41L,41L,62L,53L,53L,53L,53L,34L,61L,61L,61L,61L,98L,65L,65L,65L,65L,94L,65L,65L,65L,65L,46L,73L,73L,73L,73L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271509Inst : IEnumerable<long>
{
public static readonly long[] Value=A271509.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271509.Bytes);
public long this[int i]=>Value[i];

public static A271509Inst Instance=new A271509Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271510
{
public static readonly long[] Value={ 1L,3L,3L,2L,4L,4L,1L,1L,3L,4L,5L,2L,3L,5L,2L,1L,4L,5L,5L,3L,4L,2L,2L,1L,1L,8L,5L,4L,4L,4L,2L,2L,3L,3L,7L,2L,6L,7L,3L,3L,5L,6L,4L,6L,2L,4L,4L,1L,3L,6L,9L,4L,8L,5L,6L,2L,2L,6L,10L,4L,1L,5L,3L,7L,4L,10L,3L,5L,5L,2L,4L,1L,5L,6L,7L,2L,6L,1L,7L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271510Inst : IEnumerable<long>
{
public static readonly long[] Value=A271510.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271510.Bytes);
public long this[int i]=>Value[i];

public static A271510Inst Instance=new A271510Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271511
{
public static readonly long[] Value={ 6L,10L,21L,36L,78L,105L,171L,210L,300L,465L,528L,741L,903L,990L,1176L,1485L,1830L,1953L,2346L,2628L,2775L,3240L,3570L,4095L,4851L,5253L,5460L,5886L,6105L,6555L,8256L,8778L,9591L,9870L,11325L,11628L,12561L,13530L,14196L,15225L,16290L,16653L,18528L,18915L,19701L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271511Inst : IEnumerable<long>
{
public static readonly long[] Value=A271511.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271511.Bytes);
public long this[int i]=>Value[i];

public static A271511Inst Instance=new A271511Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271512
{
public static readonly long[] Value={ 10L,20L,56L,120L,364L,560L,1140L,1540L,2600L,4960L,5984L,9880L,13244L,15180L,19600L,27720L,37820L,41664L,54740L,64824L,70300L,88560L,102340L,125580L,161700L,182104L,192920L,215820L,227920L,253460L,357760L,392084L,447580L,467180L,573800L,596904L,669920L,748660L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271512Inst : IEnumerable<long>
{
public static readonly long[] Value=A271512.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271512.Bytes);
public long this[int i]=>Value[i];

public static A271512Inst Instance=new A271512Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271513
{
public static readonly long[] Value={ 1L,3L,2L,1L,4L,6L,3L,2L,2L,5L,6L,1L,2L,5L,4L,2L,4L,4L,3L,2L,6L,5L,1L,1L,3L,8L,6L,2L,4L,6L,6L,4L,2L,3L,8L,3L,7L,7L,1L,6L,6L,8L,6L,1L,2L,11L,7L,1L,2L,12L,8L,2L,7L,5L,9L,4L,4L,4L,7L,2L,4L,9L,4L,7L,4L,11L,6L,1L,5L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271513Inst : IEnumerable<long>
{
public static readonly long[] Value=A271513.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271513.Bytes);
public long this[int i]=>Value[i];

public static A271513Inst Instance=new A271513Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271514
{
public static readonly BigInteger[] Value={ 0L,0L,12L,1440L,207360L,46448640L,17836277760L,12328435187712L,15780397040271360L,BigInteger.Parse("38089369770346414080"),BigInteger.Parse("175515815901756276080640"),BigInteger.Parse("1557644360856119698123653120"),BigInteger.Parse("26796467468679998390760829353984") };
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
public class A271514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271514Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A271514.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A271514.Bytes);
public BigInteger this[int i]=>Value[i];

public static A271514Inst Instance=new A271514Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271515
{
public static readonly BigInteger[] Value={ 0L,0L,12L,2961L,948561L,526617762L,562292792592L,1216012764422331L,5487274513266786993L,BigInteger.Parse("52651038343578804040698"),BigInteger.Parse("1087983884115200260451577219") };
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
public class A271515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271515Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A271515.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A271515.Bytes);
public BigInteger this[int i]=>Value[i];

public static A271515Inst Instance=new A271515Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271516
{
public static readonly BigInteger[] Value={ 0L,0L,12L,3192L,1460310L,1400351232L,2894119482336L,13177722597521472L,BigInteger.Parse("135132206434712566080") };
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
public class A271516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271516Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A271516.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A271516.Bytes);
public BigInteger this[int i]=>Value[i];

public static A271516Inst Instance=new A271516Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271517
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,12L,0L,0L,0L,12L,1440L,0L,0L,0L,12L,2961L,207360L,0L,0L,0L,12L,3192L,948561L,46448640L,0L,0L,0L,12L,3195L,1460310L,526617762L,17836277760L,0L,0L,0L,12L,3195L,1563960L,1400351232L,562292792592L,12328435187712L,0L,0L,0L,12L,3195L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271517Inst : IEnumerable<long>
{
public static readonly long[] Value=A271517.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271517.Bytes);
public long this[int i]=>Value[i];

public static A271517Inst Instance=new A271517Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271518
{
public static readonly long[] Value={ 1L,2L,2L,2L,2L,1L,1L,1L,1L,3L,3L,2L,2L,2L,4L,2L,2L,5L,5L,3L,2L,2L,2L,3L,1L,5L,5L,2L,2L,5L,8L,1L,2L,6L,3L,3L,2L,3L,7L,5L,2L,8L,6L,1L,4L,6L,6L,2L,2L,6L,9L,5L,4L,3L,7L,6L,2L,6L,7L,5L,2L,1L,6L,6L,2L,10L,9L,6L,3L,3L,6L,2L,3L,8L,12L,5L,5L,7L,11L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271518Inst : IEnumerable<long>
{
public static readonly long[] Value=A271518.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271518.Bytes);
public long this[int i]=>Value[i];

public static A271518Inst Instance=new A271518Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271519
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,2L,3L,3L,4L,3L,5L,3L,6L,4L,7L,4L,8L,5L,9L,4L,10L,6L,11L,4L,12L,7L,13L,5L,14L,8L,15L,5L,16L,9L,17L,6L,18L,10L,19L,5L,20L,11L,21L,7L,22L,12L,23L,5L,24L,13L,25L,8L,26L,14L,27L,6L,28L,15L,29L,9L,30L,16L,31L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271519Inst : IEnumerable<long>
{
public static readonly long[] Value=A271519.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271519.Bytes);
public long this[int i]=>Value[i];

public static A271519Inst Instance=new A271519Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271520
{
public static readonly long[] Value={ 1L,1L,2L,4L,6L,8L,16L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271520Inst : IEnumerable<long>
{
public static readonly long[] Value=A271520.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271520.Bytes);
public long this[int i]=>Value[i];

public static A271520Inst Instance=new A271520Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271521
{
public static readonly long[] Value={ 8L,3L,4L,0L,6L,1L,5L,7L,3L,3L,9L,2L,4L,0L,5L,6L,4L,1L,4L,3L,8L,4L,5L,7L,1L,6L,2L,9L,5L,6L,8L,8L,3L,0L,7L,5L,3L,8L,0L,6L,1L,2L,9L,4L,7L,3L,9L,2L,0L,1L,1L,6L,6L,9L,9L,4L,0L,3L,2L,6L,4L,1L,1L,9L,0L,2L,3L,8L,3L,7L,6L,7L,9L,1L,9L,5L,4L,1L,3L,5L,9L,3L,9L,1L,0L,0L,8L,3L,3L,0L,7L,3L,4L,6L,3L,2L,9L,6L,8L,5L,7L,3L,3L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271521Inst : IEnumerable<long>
{
public static readonly long[] Value=A271521.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271521.Bytes);
public long this[int i]=>Value[i];

public static A271521Inst Instance=new A271521Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271522
{
public static readonly long[] Value={ 5L,0L,6L,8L,4L,7L,0L,1L,7L,1L,6L,7L,5L,6L,9L,0L,8L,1L,9L,2L,3L,6L,7L,7L,7L,2L,0L,3L,4L,7L,5L,1L,9L,6L,7L,5L,2L,6L,2L,0L,0L,3L,5L,0L,7L,0L,7L,4L,0L,1L,0L,7L,5L,1L,2L,3L,4L,2L,1L,5L,2L,3L,3L,6L,1L,7L,0L,8L,3L,3L,8L,1L,6L,3L,9L,4L,1L,5L,7L,4L,9L,9L,4L,9L,6L,3L,7L,9L,2L,6L,3L,9L,2L,3L,4L,3L,5L,5L,9L,0L,3L,8L,7L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271522Inst : IEnumerable<long>
{
public static readonly long[] Value=A271522.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271522.Bytes);
public long this[int i]=>Value[i];

public static A271522Inst Instance=new A271522Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271523
{
public static readonly long[] Value={ 5L,3L,2L,5L,9L,3L,1L,8L,1L,7L,6L,3L,0L,9L,6L,1L,6L,6L,5L,7L,0L,9L,6L,5L,0L,0L,8L,1L,9L,7L,3L,1L,9L,0L,4L,4L,7L,2L,7L,7L,8L,5L,7L,6L,8L,1L,4L,3L,4L,9L,2L,1L,9L,2L,2L,3L,9L,7L,4L,8L,7L,2L,5L,9L,5L,9L,4L,3L,8L,2L,6L,3L,1L,5L,6L,3L,1L,1L,1L,7L,7L,6L,6L,8L,6L,6L,0L,8L,9L,6L,4L,8L,9L,7L,7L,9L,5L,5L,7L,2L,2L,4L,1L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271523Inst : IEnumerable<long>
{
public static readonly long[] Value=A271523.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271523.Bytes);
public long this[int i]=>Value[i];

public static A271523Inst Instance=new A271523Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271572
{
public static readonly long[] Value={ 0L,1L,0L,11L,0L,13L,0L,23L,0L,25L,0L,3L,0L,5L,0L,15L,0L,17L,0L,27L,0L,29L,0L,7L,0L,9L,0L,19L,0L,21L,0L,31L,0L,1L,0L,11L,0L,13L,0L,23L,0L,25L,0L,3L,0L,5L,0L,15L,0L,17L,0L,27L,0L,29L,0L,7L,0L,9L,0L,19L,0L,21L,0L,31L,0L,1L,0L,11L,0L,13L,0L,23L,0L,25L,0L,3L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271572Inst : IEnumerable<long>
{
public static readonly long[] Value=A271572.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271572.Bytes);
public long this[int i]=>Value[i];

public static A271572Inst Instance=new A271572Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271573
{
public static readonly long[] Value={ 0L,1L,1L,7L,3L,21L,19L,71L,17L,265L,261L,1035L,515L,4109L,4103L,16399L,2049L,65553L,65545L,262163L,131077L,1048597L,1048587L,4194327L,1048579L,16777241L,16777229L,67108891L,33554439L,268435485L,268435471L,1073741855L,67108865L,4294967329L,4294967313L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271573Inst : IEnumerable<long>
{
public static readonly long[] Value=A271573.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271573.Bytes);
public long this[int i]=>Value[i];

public static A271573Inst Instance=new A271573Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271574
{
public static readonly long[] Value={ 2L,1L,2L,9L,7L,0L,2L,5L,4L,8L,9L,8L,3L,3L,0L,6L,4L,1L,8L,1L,3L,4L,5L,2L,3L,6L,1L,0L,5L,9L,5L,4L,1L,3L,4L,6L,8L,3L,1L,9L,2L,2L,0L,7L,4L,7L,0L,3L,9L,1L,6L,9L,3L,0L,3L,7L,6L,2L,9L,9L,6L,8L,6L,0L,2L,9L,9L,9L,9L,6L,2L,2L,9L,2L,9L,9L,8L,7L,3L,0L,1L,7L,9L,6L,3L,8L,3L,2L,7L,8L,1L,2L,7L,1L,0L,4L,2L,2L,4L,9L,3L,5L,6L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271574Inst : IEnumerable<long>
{
public static readonly long[] Value=A271574.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271574.Bytes);
public long this[int i]=>Value[i];

public static A271574Inst Instance=new A271574Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271575
{
public static readonly long[] Value={ 13L,31L,97L,163L,181L,283L,409L,499L,709L,787L,811L,877L,1087L,1399L,1423L,1609L,1777L,1801L,1879L,2347L,2677L,2719L,3457L,3517L,3919L,4273L,4483L,5701L,6043L,6121L,6211L,6481L,6691L,7573L,8941L,9733L,9739L,10069L,10093L,10159L,10243L,10789L,11161L,11251L,11689L,12799L,12907L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271575Inst : IEnumerable<long>
{
public static readonly long[] Value=A271575.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271575.Bytes);
public long this[int i]=>Value[i];

public static A271575Inst Instance=new A271575Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271576
{
public static readonly long[] Value={ 5L,15L,20L,34L,39L,41L,45L,60L,65L,80L,85L,111L,125L,135L,136L,145L,150L,156L,164L,175L,180L,194L,219L,240L,245L,255L,260L,265L,306L,313L,320L,325L,340L,351L,353L,369L,371L,375L,405L,410L,444L,445L,455L,500L,505L,514L,540L,544L,580L,585L,600L,605L,609L,624L,629L,656L,671L,674L,689L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271576Inst : IEnumerable<long>
{
public static readonly long[] Value=A271576.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271576.Bytes);
public long this[int i]=>Value[i];

public static A271576Inst Instance=new A271576Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271577
{
public static readonly long[] Value={ 32L,512L,2197L,3125L,8000L,8192L,15625L,64000L,100000L,131072L,1419857L,1953125L,2097152L,3200000L,7189057L,8000000L,8998912L,9765625L,11390625L,11881376L,30664297L,32768000L,33554432L,35287552L,62748517L,64000000L,69343957L,115856201L,125000000L,221445125L,262144000L,272097792L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271577Inst : IEnumerable<long>
{
public static readonly long[] Value=A271577.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271577.Bytes);
public long this[int i]=>Value[i];

public static A271577Inst Instance=new A271577Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271578
{
public static readonly long[] Value={ 120L,126L,132L,136L,138L,140L,142L,144L,146L,148L,150L,154L,156L,158L,160L,162L,164L,166L,168L,170L,172L,174L,176L,178L,180L,182L,184L,186L,188L,190L,192L,194L,196L,198L,200L,202L,204L,206L,208L,210L,212L,214L,216L,218L,220L,222L,224L,226L,228L,230L,232L,234L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271578Inst : IEnumerable<long>
{
public static readonly long[] Value=A271578.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271578.Bytes);
public long this[int i]=>Value[i];

public static A271578Inst Instance=new A271578Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271579
{
public static readonly long[] Value={ 1402L,1912L,2162L,2164L,2422L,2612L,3362L,3512L,3737L,3952L,4207L,4257L,4322L,4462L,4887L,4972L,5312L,5362L,5442L,5466L,5482L,5593L,5986L,5992L,6162L,6337L,6438L,6532L,6662L,6747L,6792L,6887L,6974L,6987L,7112L,7177L,7437L,7507L,7662L,7975L,8032L,8222L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271579Inst : IEnumerable<long>
{
public static readonly long[] Value=A271579.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271579.Bytes);
public long this[int i]=>Value[i];

public static A271579Inst Instance=new A271579Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271580
{
public static readonly long[] Value={ 2823L,3230L,4350L,4590L,6462L,7150L,7735L,7905L,8515L,9230L,9775L,9945L,10625L,11220L,11292L,11310L,11985L,12155L,12675L,12750L,12920L,13050L,13390L,13775L,14355L,14705L,14825L,15275L,15300L,15950L,16150L,16250L,16830L,17300L,17316L,17400L,18315L,18360L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271580Inst : IEnumerable<long>
{
public static readonly long[] Value=A271580.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271580.Bytes);
public long this[int i]=>Value[i];

public static A271580Inst Instance=new A271580Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271581
{
public static readonly long[] Value={ 251L,305L,317L,341L,362L,366L,371L,377L,387L,389L,410L,421L,427L,431L,434L,435L,440L,446L,455L,458L,470L,482L,483L,484L,490L,494L,497L,500L,506L,512L,515L,519L,521L,523L,525L,536L,546L,547L,548L,550L,551L,553L,563L,566L,572L,575L,578L,580L,584L,586L,590L,591L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271581Inst : IEnumerable<long>
{
public static readonly long[] Value=A271581.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271581.Bytes);
public long this[int i]=>Value[i];

public static A271581Inst Instance=new A271581Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271582
{
public static readonly long[] Value={ 11220L,15300L,17300L,17316L,19380L,20900L,26900L,27300L,28100L,29900L,31620L,33660L,34060L,34580L,35700L,39100L,39780L,42500L,42900L,43540L,43732L,43860L,44748L,45900L,46900L,47580L,47892L,47940L,49300L,50700L,51508L,52260L,53300L,53980L,54340L,55100L,55796L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271582Inst : IEnumerable<long>
{
public static readonly long[] Value=A271582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271582.Bytes);
public long this[int i]=>Value[i];

public static A271582Inst Instance=new A271582Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271583
{
public static readonly long[] Value={ 509020L,736300L,860932L,1368340L,2431780L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271583Inst : IEnumerable<long>
{
public static readonly long[] Value=A271583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271583.Bytes);
public long this[int i]=>Value[i];

public static A271583Inst Instance=new A271583Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271584
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,0L,0L,2L,0L,1L,4L,0L,0L,2L,6L,0L,1L,4L,9L,0L,0L,2L,6L,12L,0L,1L,4L,9L,16L,0L,0L,2L,6L,12L,20L,0L,1L,4L,9L,16L,25L,0L,0L,2L,6L,12L,20L,30L,0L,1L,4L,9L,16L,25L,36L,0L,0L,2L,6L,12L,20L,30L,42L,0L,1L,4L,9L,16L,25L,36L,49L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271584Inst : IEnumerable<long>
{
public static readonly long[] Value=A271584.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271584.Bytes);
public long this[int i]=>Value[i];

public static A271584Inst Instance=new A271584Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271585
{
public static readonly long[] Value={ 1L,2L,3L,6L,7L,10L,11L,25L,26L,32L,122L,123L,126L,161L,292L,320L,743L,1630L,2738L,3178L,4814L,4833L,5030L,7035L,8151L,12554L,13954L,15113L,80490L,96112L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271585Inst : IEnumerable<long>
{
public static readonly long[] Value=A271585.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271585.Bytes);
public long this[int i]=>Value[i];

public static A271585Inst Instance=new A271585Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271586
{
public static readonly long[] Value={ 1L,2L,5L,4L,9L,10L,25L,8L,37L,18L,61L,20L,49L,50L,45L,24L,81L,74L,181L,36L,125L,122L,265L,40L,121L,98L,329L,100L,225L,90L,481L,88L,305L,162L,225L,148L,361L,362L,245L,72L,441L,250L,925L,244L,333L,530L,1105L,120L,1177L,242L,405L,196L,729L,658L,549L,200L,905L,450L,1741L,180L,961L,962L,925L,344L,441L,610L,2245L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271586Inst : IEnumerable<long>
{
public static readonly long[] Value=A271586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271586.Bytes);
public long this[int i]=>Value[i];

public static A271586Inst Instance=new A271586Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271587
{
public static readonly long[] Value={ 3L,19L,220L,8924L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271587Inst : IEnumerable<long>
{
public static readonly long[] Value=A271587.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271587.Bytes);
public long this[int i]=>Value[i];

public static A271587Inst Instance=new A271587Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271636
{
public static readonly long[] Value={ 0L,28L,152L,468L,1072L,2060L,3528L,5572L,8288L,11772L,16120L,21428L,27792L,35308L,44072L,54180L,65728L,78812L,93528L,109972L,128240L,148428L,170632L,194948L,221472L,250300L,281528L,315252L,351568L,390572L,432360L,477028L,524672L,575388L,629272L,686420L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271636Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271636.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271636Inst : IEnumerable<long>
{
public static readonly long[] Value=A271636.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271636.Bytes);
public long this[int i]=>Value[i];

public static A271636Inst Instance=new A271636Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271637
{
public static readonly BigInteger[] Value={ 6L,820L,104391567L,119304648L,858993460L,900719925474100L,26202761468337432L,29478106651879611L,32753451835421790L,BigInteger.Parse("225701339254799219773"),BigInteger.Parse("243062980735937621294"),BigInteger.Parse("260424622217076022815"),BigInteger.Parse("277786263698214424336"),BigInteger.Parse("944473296573929042740"),BigInteger.Parse("232485734541274841289650") };
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
public class A271637Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271637.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271637Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A271637.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A271637.Bytes);
public BigInteger this[int i]=>Value[i];

public static A271637Inst Instance=new A271637Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271638
{
public static readonly long[] Value={ 1L,10L,48L,170L,512L,1398L,3580L,8770L,20808L,48206L,109652L,245850L,544864L,1196134L,2605164L,5636210L,12124280L,25952382L,55312516L,117440650L,248512656L,524288150L,1103102108L,2315255970L,4848615592L,10133438638L,21139292340L,44023414970L,91536490688L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271638Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271638.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271638Inst : IEnumerable<long>
{
public static readonly long[] Value=A271638.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271638.Bytes);
public long this[int i]=>Value[i];

public static A271638Inst Instance=new A271638Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271639
{
public static readonly long[] Value={ 648L,649L,659L,737L,738L,739L,747L,748L,749L,758L,759L,769L,828L,829L,837L,838L,839L,846L,847L,848L,849L,857L,858L,859L,868L,869L,879L,919L,928L,929L,937L,938L,939L,946L,947L,948L,949L,956L,957L,958L,959L,967L,968L,969L,978L,979L,989L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271639Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271639.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271639Inst : IEnumerable<long>
{
public static readonly long[] Value=A271639.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271639.Bytes);
public long this[int i]=>Value[i];

public static A271639Inst Instance=new A271639Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271640
{
public static readonly long[] Value={ 1L,2L,5L,6L,13L,37L,50L,55L,71L,89L,217L,352L,355L,398L,449L,668L,742L,870L,1360L,1579L,2848L,3774L,5039L,5051L,6134L,6824L,7255L,12586L,17106L,27502L,30581L,33817L,97399L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271640Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271640.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271640Inst : IEnumerable<long>
{
public static readonly long[] Value=A271640.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271640.Bytes);
public long this[int i]=>Value[i];

public static A271640Inst Instance=new A271640Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271641
{
public static readonly long[] Value={ 9L,17L,15L,13L,11L,9L,7L,5L,3L,1L,17L,32L,29L,25L,21L,17L,13L,9L,5L,2L,15L,28L,26L,23L,19L,15L,11L,7L,4L,2L,13L,24L,22L,20L,17L,13L,9L,6L,4L,2L,11L,20L,18L,16L,14L,11L,8L,6L,4L,2L,9L,16L,14L,12L,10L,9L,8L,6L,4L,2L,7L,12L,10L,8L,7L,7L,7L,6L,4L,2L,5L,8L,6L,5L,5L,5L,5L,5L,4L,2L,3L,4L,3L,3L,3L,3L,3L,3L,3L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,17L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271641Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271641.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271641Inst : IEnumerable<long>
{
public static readonly long[] Value=A271641.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271641.Bytes);
public long this[int i]=>Value[i];

public static A271641Inst Instance=new A271641Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271642
{
public static readonly long[] Value={ 101L,102L,415L,515L,505L,506L,805L,522L,103L,414L,806L,809L,815L,507L,1805L,807L,808L,1509L,418L,1506L,814L,1107L,822L,1108L,1122L,518L,412L,1806L,1115L,1514L,1520L,1814L,1820L,1508L,5705L,1522L,521L,104L,1415L,818L,1807L,1515L,918L,1907L,110L,111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271642Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271642.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271642Inst : IEnumerable<long>
{
public static readonly long[] Value=A271642.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271642.Bytes);
public long this[int i]=>Value[i];

public static A271642Inst Instance=new A271642Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271643
{
public static readonly long[] Value={ 204L,304L,209L,504L,509L,215L,218L,505L,503L,521L,524L,219L,220L,803L,208L,1021L,1209L,226L,1205L,515L,1003L,1704L,520L,216L,1203L,526L,1014L,1017L,1705L,519L,1805L,1821L,508L,920L,206L,1020L,1120L,1220L,826L,808L,908L,1008L,915L,506L,1015L,1814L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271643Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271643.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271643Inst : IEnumerable<long>
{
public static readonly long[] Value=A271643.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271643.Bytes);
public long this[int i]=>Value[i];

public static A271643Inst Instance=new A271643Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271644
{
public static readonly long[] Value={ 1L,3L,1L,1L,4L,4L,1L,3L,4L,4L,2L,2L,5L,2L,1L,1L,8L,8L,2L,5L,7L,3L,2L,4L,8L,7L,3L,2L,6L,4L,4L,3L,7L,6L,2L,4L,6L,4L,3L,4L,9L,4L,3L,4L,8L,4L,1L,2L,5L,7L,4L,7L,10L,11L,3L,2L,5L,5L,2L,2L,7L,4L,2L,1L,8L,9L,2L,8L,14L,9L,1L,8L,8L,6L,5L,4L,8L,2L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271644Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271644.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271644Inst : IEnumerable<long>
{
public static readonly long[] Value=A271644.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271644.Bytes);
public long this[int i]=>Value[i];

public static A271644Inst Instance=new A271644Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271645
{
public static readonly long[] Value={ 1L,2L,4L,15L,16L,19L,20L,26L,38L,47L,52L,75L,122L,191L,246L,257L,294L,305L,374L,592L,682L,729L,1092L,2053L,2997L,4065L,13936L,17214L,19059L,37433L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271645Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271645.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271645Inst : IEnumerable<long>
{
public static readonly long[] Value=A271645.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271645.Bytes);
public long this[int i]=>Value[i];

public static A271645Inst Instance=new A271645Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271646
{
public static readonly long[] Value={ 0L,1L,2L,9L,13L,14L,15L,17L,22L,23L,80L,297L,393L,524L,591L,1107L,1135L,1179L,1442L,2819L,3549L,3756L,3837L,4903L,5277L,5639L,7230L,13147L,14828L,16158L,18119L,28880L,99275L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271646Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271646.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271646Inst : IEnumerable<long>
{
public static readonly long[] Value=A271646.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271646.Bytes);
public long this[int i]=>Value[i];

public static A271646Inst Instance=new A271646Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271647
{
public static readonly long[] Value={ 1L,2L,4L,3L,6L,5L,9L,8L,7L,12L,11L,10L,16L,15L,14L,13L,20L,19L,18L,17L,25L,24L,23L,22L,21L,30L,29L,28L,27L,26L,36L,35L,34L,33L,32L,31L,42L,41L,40L,39L,38L,37L,49L,48L,47L,46L,45L,44L,43L,56L,55L,54L,53L,52L,51L,50L,64L,63L,62L,61L,60L,59L,58L,57L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271647Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271647.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271647Inst : IEnumerable<long>
{
public static readonly long[] Value=A271647.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271647.Bytes);
public long this[int i]=>Value[i];

public static A271647Inst Instance=new A271647Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271648
{
public static readonly long[] Value={ 6L,119L,2279L,18042L,83921L,284428L,782795L,1859374L,3957717L,7738336L,14140143L,24449570L,40377369L,64143092L,98567251L,147171158L,214284445L,305160264L,426098167L,584574666L,789381473L,1050771420L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271648Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271648.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271648Inst : IEnumerable<long>
{
public static readonly long[] Value=A271648.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271648.Bytes);
public long this[int i]=>Value[i];

public static A271648Inst Instance=new A271648Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271649
{
public static readonly long[] Value={ 4L,8L,16L,28L,44L,64L,88L,116L,148L,184L,224L,268L,316L,368L,424L,484L,548L,616L,688L,764L,844L,928L,1016L,1108L,1204L,1304L,1408L,1516L,1628L,1744L,1864L,1988L,2116L,2248L,2384L,2524L,2668L,2816L,2968L,3124L,3284L,3448L,3616L,3788L,3964L,4144L,4328L,4516L,4708L,4904L,5104L,5308L,5516L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271649Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271649.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271649Inst : IEnumerable<long>
{
public static readonly long[] Value=A271649.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271649.Bytes);
public long this[int i]=>Value[i];

public static A271649Inst Instance=new A271649Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271650
{
public static readonly BigInteger[] Value={ 1L,0L,40L,480L,11880L,281280L,7506400L,210268800L,6166993000L,187069411200L,5833030976640L,186014056166400L,6044435339896800L,199561060892793600L,6679216425794140800L,BigInteger.Parse("226213441773789550080"),BigInteger.Parse("7741313040820500484200") };
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
public class A271650Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271650.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271650Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A271650.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A271650.Bytes);
public BigInteger this[int i]=>Value[i];

public static A271650Inst Instance=new A271650Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271651
{
public static readonly BigInteger[] Value={ 1L,0L,60L,960L,30780L,996480L,36560400L,1430553600L,59089923900L,2543035488000L,113129280527760L,5170796720812800L,241741903350301200L,11520044551208793600UL,BigInteger.Parse("558061378022616811200"),BigInteger.Parse("27421336248833005839360") };
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
public class A271651Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271651.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271651Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A271651.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A271651.Bytes);
public BigInteger this[int i]=>Value[i];

public static A271651Inst Instance=new A271651Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271684
{
public static readonly long[] Value={ 0L,1L,2L,1L,5L,4L,1L,5L,22L,132L,1L,6L,43L,532L,3440L,1L,6L,51L,1060L,19448L,358792L,1L,6L,60L,1564L,52748L,2249488L,71771952L,1L,6L,60L,1939L,96249L,7094704L,556148184L,39547904272L,1L,6L,61L,2113L,139023L,15313428L,2145306564L,357523207792L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271684Inst : IEnumerable<long>
{
public static readonly long[] Value=A271684.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271684.Bytes);
public long this[int i]=>Value[i];

public static A271684Inst Instance=new A271684Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271685
{
public static readonly long[] Value={ 1L,5L,9L,28L,17L,89L,32L,145L,53L,268L,77L,377L,100L,533L,213L,624L,161L,921L,208L,1101L,253L,1380L,361L,1509L,404L,1865L,453L,2124L,513L,2453L,720L,2625L,669L,3172L,749L,3593L,756L,4149L,937L,4452L,1009L,4953L,1248L,5273L,1317L,5912L,1525L,6185L,1524L,6929L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271685Inst : IEnumerable<long>
{
public static readonly long[] Value=A271685.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271685.Bytes);
public long this[int i]=>Value[i];

public static A271685Inst Instance=new A271685Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271686
{
public static readonly long[] Value={ 1L,5L,28L,145L,624L,2625L,10864L,43861L,175856L,710113L,2832596L,11426185L,45425292L,182291585L,725671444L,2934064869L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271686Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271686.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271686Inst : IEnumerable<long>
{
public static readonly long[] Value=A271686.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271686.Bytes);
public long this[int i]=>Value[i];

public static A271686Inst Instance=new A271686Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271687
{
public static readonly long[] Value={ 1L,6L,15L,43L,60L,149L,181L,326L,379L,647L,724L,1101L,1201L,1734L,1947L,2571L,2732L,3653L,3861L,4962L,5215L,6595L,6956L,8465L,8869L,10734L,11187L,13311L,13824L,16277L,16997L,19622L,20291L,23463L,24212L,27805L,28561L,32710L,33647L,38099L,39108L,44061L,45309L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271687Inst : IEnumerable<long>
{
public static readonly long[] Value=A271687.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271687.Bytes);
public long this[int i]=>Value[i];

public static A271687Inst Instance=new A271687Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271688
{
public static readonly long[] Value={ 4L,4L,19L,-11L,72L,-57L,113L,-92L,215L,-191L,300L,-277L,433L,-320L,411L,-463L,760L,-713L,893L,-848L,1127L,-1019L,1148L,-1105L,1461L,-1412L,1671L,-1611L,1940L,-1733L,1905L,-1956L,2503L,-2423L,2844L,-2837L,3393L,-3212L,3515L,-3443L,3944L,-3705L,4025L,-3956L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271688Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271688.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271688Inst : IEnumerable<long>
{
public static readonly long[] Value=A271688.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271688.Bytes);
public long this[int i]=>Value[i];

public static A271688Inst Instance=new A271688Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271689
{
public static readonly long[] Value={ 1L,8L,5L,44L,17L,108L,33L,204L,57L,324L,77L,452L,85L,656L,109L,852L,157L,1044L,217L,1348L,193L,1628L,261L,1920L,261L,2320L,309L,2628L,369L,3100L,445L,3488L,417L,3980L,505L,4392L,601L,4904L,597L,5464L,685L,6092L,745L,6704L,801L,7384L,913L,7884L,957L,8596L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271689Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271689.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271689Inst : IEnumerable<long>
{
public static readonly long[] Value=A271689.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271689.Bytes);
public long this[int i]=>Value[i];

public static A271689Inst Instance=new A271689Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271690
{
public static readonly long[] Value={ 1L,8L,44L,204L,852L,3488L,14064L,57188L,228044L,908996L,3633896L,14522920L,58046984L,232143556L,928391308L,3713183932L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271690Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271690.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271690Inst : IEnumerable<long>
{
public static readonly long[] Value=A271690.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271690.Bytes);
public long this[int i]=>Value[i];

public static A271690Inst Instance=new A271690Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271691
{
public static readonly long[] Value={ 1L,9L,14L,58L,75L,183L,216L,420L,477L,801L,878L,1330L,1415L,2071L,2180L,3032L,3189L,4233L,4450L,5798L,5991L,7619L,7880L,9800L,10061L,12381L,12690L,15318L,15687L,18787L,19232L,22720L,23137L,27117L,27622L,32014L,32615L,37519L,38116L,43580L,44265L,50357L,51102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271691Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271691.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271691Inst : IEnumerable<long>
{
public static readonly long[] Value=A271691.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271691.Bytes);
public long this[int i]=>Value[i];

public static A271691Inst Instance=new A271691Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271692
{
public static readonly long[] Value={ 7L,-3L,39L,-27L,91L,-75L,171L,-147L,267L,-247L,375L,-367L,571L,-547L,743L,-695L,887L,-827L,1131L,-1155L,1435L,-1367L,1659L,-1659L,2059L,-2011L,2319L,-2259L,2731L,-2655L,3043L,-3071L,3563L,-3475L,3887L,-3791L,4303L,-4307L,4867L,-4779L,5407L,-5347L,5959L,-5903L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271692Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271692.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271692Inst : IEnumerable<long>
{
public static readonly long[] Value=A271692.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271692.Bytes);
public long this[int i]=>Value[i];

public static A271692Inst Instance=new A271692Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271693
{
public static readonly long[] Value={ 1L,5L,8L,21L,20L,28L,36L,76L,76L,64L,88L,116L,128L,152L,156L,296L,308L,196L,276L,276L,300L,376L,324L,452L,472L,412L,528L,608L,616L,740L,780L,1004L,1072L,840L,1004L,864L,952L,1072L,952L,1128L,1184L,1196L,1324L,1424L,1268L,1508L,1568L,1920L,1984L,1696L,2168L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271693Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271693.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271693Inst : IEnumerable<long>
{
public static readonly long[] Value=A271693.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271693.Bytes);
public long this[int i]=>Value[i];

public static A271693Inst Instance=new A271693Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271694
{
public static readonly long[] Value={ 1L,5L,21L,76L,296L,1004L,3984L,15556L,60308L,241016L,959044L,3834608L,15311436L,61288052L,245072724L,980065360L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271694Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271694.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271694Inst : IEnumerable<long>
{
public static readonly long[] Value=A271694.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271694.Bytes);
public long this[int i]=>Value[i];

public static A271694Inst Instance=new A271694Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271695
{
public static readonly long[] Value={ 1L,6L,14L,35L,55L,83L,119L,195L,271L,335L,423L,539L,667L,819L,975L,1271L,1579L,1775L,2051L,2327L,2627L,3003L,3327L,3779L,4251L,4663L,5191L,5799L,6415L,7155L,7935L,8939L,10011L,10851L,11855L,12719L,13671L,14743L,15695L,16823L,18007L,19203L,20527L,21951L,23219L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271695Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271695.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271695Inst : IEnumerable<long>
{
public static readonly long[] Value=A271695.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271695.Bytes);
public long this[int i]=>Value[i];

public static A271695Inst Instance=new A271695Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271696
{
public static readonly long[] Value={ 4L,3L,13L,-1L,8L,8L,40L,0L,-12L,24L,28L,12L,24L,4L,140L,12L,-112L,80L,0L,24L,76L,-52L,128L,20L,-60L,116L,80L,8L,124L,40L,224L,68L,-232L,164L,-140L,88L,120L,-120L,176L,56L,12L,128L,100L,-156L,240L,60L,352L,64L,-288L,472L,-200L,188L,-8L,96L,364L,88L,-220L,364L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271696Inst : IEnumerable<long>
{
public static readonly long[] Value=A271696.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271696.Bytes);
public long this[int i]=>Value[i];

public static A271696Inst Instance=new A271696Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271697
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,7L,1L,0L,0L,1L,21L,21L,1L,0L,0L,1L,51L,161L,51L,1L,0L,0L,1L,113L,813L,813L,113L,1L,0L,0L,1L,239L,3361L,7631L,3361L,239L,1L,0L,0L,1L,493L,12421L,53833L,53833L,12421L,493L,1L,0L,0L,1L,1003L,42865L,320107L,607009L,320107L,42865L,1003L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271697Inst : IEnumerable<long>
{
public static readonly long[] Value=A271697.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271697.Bytes);
public long this[int i]=>Value[i];

public static A271697Inst Instance=new A271697Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271698
{
public static readonly long[] Value={ 1L,1L,0L,0L,1L,0L,0L,2L,1L,0L,0L,2L,8L,1L,0L,0L,2L,28L,22L,1L,0L,0L,2L,72L,182L,52L,1L,0L,0L,2L,164L,974L,864L,114L,1L,0L,0L,2L,352L,4174L,8444L,3474L,240L,1L,0L,0L,2L,732L,15782L,61464L,57194L,12660L,494L,1L,0L,0L,2L,1496L,55286L,373940L,660842L,332528L,43358L,1004L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271698Inst : IEnumerable<long>
{
public static readonly long[] Value=A271698.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271698.Bytes);
public long this[int i]=>Value[i];

public static A271698Inst Instance=new A271698Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271699
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,2L,0L,1L,3L,9L,0L,1L,4L,14L,58L,0L,1L,5L,20L,90L,475L,0L,1L,6L,27L,131L,729L,4666L,0L,1L,7L,35L,182L,1064L,7070L,53116L,0L,1L,8L,44L,244L,1494L,10284L,79470L,684762L,0L,1L,9L,54L,318L,2034L,14478L,114918L,1012368L,9833391L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271699Inst : IEnumerable<long>
{
public static readonly long[] Value=A271699.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271699.Bytes);
public long this[int i]=>Value[i];

public static A271699Inst Instance=new A271699Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271860
{
public static readonly long[] Value={ 0L,1L,0L,3L,0L,3L,2L,5L,0L,5L,4L,7L,2L,5L,4L,11L,4L,7L,6L,9L,4L,11L,10L,13L,4L,9L,8L,15L,10L,13L,12L,15L,6L,13L,12L,19L,12L,15L,14L,21L,12L,15L,14L,17L,12L,23L,22L,25L,12L,17L,16L,23L,18L,21L,20L,27L,18L,25L,24L,27L,18L,21L,20L,31L,20L,27L,26L,29L,24L,31L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271860Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271860.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271860Inst : IEnumerable<long>
{
public static readonly long[] Value=A271860.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271860.Bytes);
public long this[int i]=>Value[i];

public static A271860Inst Instance=new A271860Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271861
{
public static readonly long[] Value={ 1L,2L,3L,5L,4L,7L,9L,8L,10L,12L,15L,14L,6L,16L,19L,11L,13L,18L,21L,24L,20L,28L,27L,25L,22L,30L,23L,34L,37L,36L,26L,29L,33L,17L,41L,44L,40L,39L,32L,35L,45L,31L,49L,52L,48L,55L,54L,51L,38L,46L,50L,58L,61L,57L,64L,67L,66L,56L,43L,59L,47L,68L,71L,63L,74L,77L,81L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271861Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271861.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271861Inst : IEnumerable<long>
{
public static readonly long[] Value=A271861.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271861.Bytes);
public long this[int i]=>Value[i];

public static A271861Inst Instance=new A271861Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271862
{
public static readonly long[] Value={ 1L,2L,3L,5L,4L,13L,6L,8L,7L,9L,16L,10L,17L,12L,11L,14L,34L,18L,15L,21L,19L,25L,27L,20L,24L,31L,23L,22L,32L,26L,42L,39L,33L,28L,40L,30L,29L,49L,38L,37L,35L,81L,59L,36L,41L,50L,61L,45L,43L,51L,48L,44L,92L,47L,46L,58L,54L,52L,60L,75L,53L,73L,64L,55L,71L,57L,56L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271862Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271862.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271862Inst : IEnumerable<long>
{
public static readonly long[] Value=A271862.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271862.Bytes);
public long this[int i]=>Value[i];

public static A271862Inst Instance=new A271862Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271863
{
public static readonly long[] Value={ 1L,2L,4L,3L,8L,6L,7L,10L,12L,5L,11L,19L,16L,14L,18L,15L,22L,25L,17L,9L,24L,13L,29L,23L,32L,28L,26L,31L,27L,39L,20L,38L,40L,33L,35L,30L,34L,49L,36L,46L,37L,21L,45L,43L,48L,44L,51L,59L,41L,56L,42L,50L,55L,53L,58L,54L,67L,62L,70L,64L,57L,65L,63L,52L,60L,69L,47L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271863Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271863.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271863Inst : IEnumerable<long>
{
public static readonly long[] Value=A271863.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271863.Bytes);
public long this[int i]=>Value[i];

public static A271863Inst Instance=new A271863Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271864
{
public static readonly long[] Value={ 1L,2L,4L,3L,10L,6L,7L,5L,20L,8L,11L,9L,22L,14L,16L,13L,19L,15L,12L,31L,42L,17L,24L,21L,18L,27L,29L,26L,23L,36L,28L,25L,34L,37L,35L,39L,41L,32L,30L,33L,49L,51L,44L,46L,43L,40L,67L,45L,38L,52L,47L,64L,54L,56L,53L,50L,61L,55L,48L,65L,87L,58L,63L,60L,62L,85L,57L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271864Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271864.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271864Inst : IEnumerable<long>
{
public static readonly long[] Value=A271864.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271864.Bytes);
public long this[int i]=>Value[i];

public static A271864Inst Instance=new A271864Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271865
{
public static readonly long[] Value={ 1L,2L,4L,3L,6L,9L,7L,8L,10L,13L,5L,15L,12L,14L,16L,19L,11L,23L,20L,17L,22L,18L,24L,27L,21L,31L,35L,28L,32L,34L,26L,33L,29L,37L,25L,41L,45L,39L,47L,30L,44L,46L,42L,40L,36L,49L,43L,53L,57L,51L,58L,50L,61L,54L,52L,60L,55L,59L,38L,63L,56L,67L,71L,65L,72L,75L,70L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271865Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271865.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271865Inst : IEnumerable<long>
{
public static readonly long[] Value=A271865.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271865.Bytes);
public long this[int i]=>Value[i];

public static A271865Inst Instance=new A271865Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271866
{
public static readonly long[] Value={ 1L,2L,4L,3L,11L,5L,7L,8L,6L,9L,17L,13L,10L,14L,12L,15L,20L,22L,16L,19L,25L,21L,18L,23L,35L,31L,24L,28L,33L,40L,26L,29L,32L,30L,27L,45L,34L,59L,38L,44L,36L,43L,47L,41L,37L,42L,39L,73L,46L,52L,50L,55L,48L,54L,57L,61L,49L,51L,58L,56L,53L,70L,60L,75L,64L,74L,62L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271866Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271866.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271866Inst : IEnumerable<long>
{
public static readonly long[] Value=A271866.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271866.Bytes);
public long this[int i]=>Value[i];

public static A271866Inst Instance=new A271866Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271867
{
public static readonly long[] Value={ 1L,1L,1L,3L,5L,14L,30L,82L,203L,552L,1458L,4004L,10956L,30514L,85259L,240507L,681571L,1943472L,5565744L,16011492L,46233297L,133975566L,389455910L,1135431759L,3319060758L,9726061473L,28565447104L,84073146827L,247924840773L,732439856638L,2167507140543L,6424491527538L,19070573498367L,56688719414910L,168733726744153L,502859937709589L,1500383417733522L,4481672952197057L,13400947416395067L,40111136395590224L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271867Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271867.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271867Inst : IEnumerable<long>
{
public static readonly long[] Value=A271867.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271867.Bytes);
public long this[int i]=>Value[i];

public static A271867Inst Instance=new A271867Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271868
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,2L,0L,3L,2L,0L,7L,7L,0L,4L,21L,5L,1L,6L,46L,29L,0L,9L,65L,114L,15L,0L,13L,113L,304L,122L,0L,8L,169L,649L,582L,50L,0L,19L,229L,1311L,1931L,514L,0L,14L,326L,2289L,5235L,2915L,177L,0L,4L,511L,3800L,12353L,11667L,2179L,0L,8L,528L,6365L,25663L,37605L,14439L,651L,1L,14L,602L,9933L,50117L,102960L,67567L,9313L,0L,17L,779L,13887L,93176L,249123L,251277L,70851L,2461L,0L,27L,822L,19953L,161702L,554778L,787255L,378828L,40107L,0L,20L,985L,26748L,267548L,1149904L,2169902L,1596301L,344833L,9503L,0L,33L,1423L,33547L,428642L,2237223L,5425404L,5639060L,2072343L,173817L,0L,22L,1696L,45001L,644977L,4148095L,12510282L,17417722L,9761246L,1666931L,37325L,0L,8L,1951L,60518L,941911L,7327901L,27001551L,48380186L,38383316L,11121058L,757166L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271868Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271868.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271868Inst : IEnumerable<long>
{
public static readonly long[] Value=A271868.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271868.Bytes);
public long this[int i]=>Value[i];

public static A271868Inst Instance=new A271868Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271869
{
public static readonly long[] Value={ 0L,6L,0L,8L,2L,1L,6L,5L,5L,1L,2L,0L,3L,0L,5L,0L,8L,6L,0L,0L,5L,6L,3L,2L,2L,7L,5L,4L,6L,1L,9L,2L,0L,8L,5L,5L,4L,3L,1L,3L,3L,7L,3L,7L,3L,4L,7L,5L,7L,6L,7L,9L,4L,1L,9L,8L,2L,6L,4L,3L,4L,0L,3L,1L,5L,0L,4L,0L,8L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271869Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271869.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271869Inst : IEnumerable<long>
{
public static readonly long[] Value=A271869.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271869.Bytes);
public long this[int i]=>Value[i];

public static A271869Inst Instance=new A271869Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271870
{
public static readonly long[] Value={ 1L,12L,66L,236L,651L,1512L,3108L,5832L,10197L,16852L,26598L,40404L,59423L,85008L,118728L,162384L,218025L,287964L,374794L,481404L,610995L,767096L,953580L,1174680L,1435005L,1739556L,2093742L,2503396L,2974791L,3514656L,4130192L,4829088L,5619537L,6510252L,7510482L,863002888L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271870Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271870.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271870Inst : IEnumerable<long>
{
public static readonly long[] Value=A271870.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271870.Bytes);
public long this[int i]=>Value[i];

public static A271870Inst Instance=new A271870Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271871
{
public static readonly long[] Value={ 4L,8L,3L,4L,9L,8L,3L,4L,7L,1L,5L,4L,4L,2L,5L,5L,0L,0L,9L,2L,4L,0L,2L,6L,3L,6L,0L,8L,5L,0L,7L,5L,6L,1L,9L,4L,4L,4L,9L,2L,4L,6L,6L,7L,9L,5L,4L,1L,3L,3L,8L,1L,0L,4L,3L,2L,9L,2L,6L,4L,9L,4L,1L,5L,5L,2L,4L,7L,0L,9L,3L,3L,5L,1L,1L,4L,0L,3L,2L,9L,5L,9L,9L,2L,3L,7L,3L,2L,3L,1L,9L,6L,0L,8L,7L,7L,0L,1L,8L,9L,4L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271871Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271871.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271871Inst : IEnumerable<long>
{
public static readonly long[] Value=A271871.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271871.Bytes);
public long this[int i]=>Value[i];

public static A271871Inst Instance=new A271871Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271872
{
public static readonly long[] Value={ 2L,5L,1L,9L,3L,5L,6L,1L,5L,2L,0L,8L,9L,4L,4L,5L,3L,1L,3L,3L,4L,2L,7L,1L,1L,7L,2L,7L,3L,2L,9L,4L,3L,7L,9L,1L,2L,1L,1L,6L,4L,9L,9L,1L,3L,6L,7L,5L,1L,7L,3L,2L,5L,7L,7L,5L,0L,0L,6L,6L,0L,7L,8L,5L,6L,7L,7L,4L,3L,9L,0L,1L,2L,6L,9L,1L,8L,7L,2L,7L,7L,4L,0L,9L,6L,4L,2L,8L,0L,2L,1L,0L,1L,6L,2L,3L,7L,3L,0L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271872Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271872.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271872Inst : IEnumerable<long>
{
public static readonly long[] Value=A271872.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271872.Bytes);
public long this[int i]=>Value[i];

public static A271872Inst Instance=new A271872Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271873
{
public static readonly long[] Value={ 341L,561L,91L,11305L,286L,15L,825265L,41041L,435L,124L,45593065L,825265L,11305L,561L,35L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271873Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271873.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271873Inst : IEnumerable<long>
{
public static readonly long[] Value=A271873.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271873.Bytes);
public long this[int i]=>Value[i];

public static A271873Inst Instance=new A271873Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271874
{
public static readonly long[] Value={ 341L,286L,11305L,2203201L,12306385L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271874Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271874.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271874Inst : IEnumerable<long>
{
public static readonly long[] Value=A271874.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271874.Bytes);
public long this[int i]=>Value[i];

public static A271874Inst Instance=new A271874Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271875
{
public static readonly long[] Value={ 1L,-1L,1L,-1L,-2L,1L,-2L,-1L,-3L,1L,-5L,-2L,0L,-4L,1L,-14L,-5L,-1L,2L,-5L,1L,-42L,-14L,-3L,0L,5L,-6L,1L,-132L,-42L,-9L,-1L,0L,9L,-7L,1L,-429L,-132L,-28L,-4L,0L,-2L,14L,-8L,1L,-1430L,-429L,-90L,-14L,-1L,0L,-7L,20L,-9L,1L,-4862L,-1430L,-297L,-48L,-5L,0L,0L,-16L,27L,-10L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271875Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271875.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271875Inst : IEnumerable<long>
{
public static readonly long[] Value=A271875.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271875.Bytes);
public long this[int i]=>Value[i];

public static A271875Inst Instance=new A271875Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271924
{
public static readonly long[] Value={ 1L,3L,13L,19L,285L,465L,17205L,147963L,345247L,11137L,291153L,175741L,12829093L,494964309L,494964309L,919219431L,6858791139L,706455487317L,77003648117553L,1262354887173L,1262354887173L,26321041453443L,500099787615417L,952244801075931L,50118147425049L,95795446344081L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271924Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271924.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271924Inst : IEnumerable<long>
{
public static readonly long[] Value=A271924.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271924.Bytes);
public long this[int i]=>Value[i];

public static A271924Inst Instance=new A271924Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271925
{
public static readonly long[] Value={ 3L,5L,87L,156L,913L,1693L,69769L,658529L,5002953L,173619L,1616141L,3107877L,239756907L,3244922897L,3402714857L,6606018008L,51386679347L,5504537914811L,622652618545649L,10572475711004L,10931562934889L,235301799307039L,4608689892802861L,9034390134407023L,488936376609325L,959905250448181L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271925Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271925.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271925Inst : IEnumerable<long>
{
public static readonly long[] Value=A271925.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271925.Bytes);
public long this[int i]=>Value[i];

public static A271925Inst Instance=new A271925Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271926
{
public static readonly long[] Value={ 1L,1L,13L,19L,95L,155L,5735L,49321L,345247L,11137L,97051L,175741L,12829093L,164988103L,164988103L,306406477L,2286263713L,235485162439L,25667882705851L,420784962391L,420784962391L,8773680484481L,166699929205139L,317414933691977L,16706049141683L,31931815448027L,5013295025340239L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271926Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271926.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271926Inst : IEnumerable<long>
{
public static readonly long[] Value=A271926.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271926.Bytes);
public long this[int i]=>Value[i];

public static A271926Inst Instance=new A271926Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A271927
{
public static readonly long[] Value={ 1L,2L,4L,6L,9L,23L,25L,71L,73L,263L,265L,911L,913L,5021L,5023L,23291L,23293L,41359L,152681L,152683L,285985L,857951L,857953L,1517571L,1873772L,2498606L,11032457L,11032459L,16576383L,50600183L,50600185L,58908616L,235819403L,235819405L,707458211L,707458213L,1160837269L,3482511803L,3482511805L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A271927Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A271927.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A271927Inst : IEnumerable<long>
{
public static readonly long[] Value=A271927.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A271927.Bytes);
public long this[int i]=>Value[i];

public static A271927Inst Instance=new A271927Inst();

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