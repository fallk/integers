using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A087399
{
public static readonly long[] Value={ 25L,121L,5041L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087399Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087399.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087399Inst : IEnumerable<long>
{
public static readonly long[] Value=A087399.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087399.Bytes);
public long this[int i]=>Value[i];

public static A087399Inst Instance=new A087399Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087398
{
public static readonly BigInteger[] Value={ 13L,103L,1153L,15013L,255253L,4849843L,111546433L,100280245063L,152125131763603L,16294579238595022363UL,BigInteger.Parse("278970415063349480483707693"),BigInteger.Parse("11992411764462614086353260819346129198103"),BigInteger.Parse("481473710367991963528473107950567214598209565303106537707981745633") };
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
public class A087398Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087398.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087398Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A087398.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087398.Bytes);
public BigInteger this[int i]=>Value[i];

public static A087398Inst Instance=new A087398Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087397
{
public static readonly long[] Value={ 3L,10L,6L,15L,45L,66L,120L,153L,231L,378L,435L,630L,780L,861L,1035L,1326L,1653L,1770L,2145L,2415L,2556L,3003L,3321L,3828L,4560L,4950L,5151L,5565L,5778L,6216L,7875L,8385L,9180L,9453L,10878L,11175L,12090L,13041L,13695L,14706L,15753L,16110L,17955L,18336L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087397Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087397.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087397Inst : IEnumerable<long>
{
public static readonly long[] Value=A087397.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087397.Bytes);
public long this[int i]=>Value[i];

public static A087397Inst Instance=new A087397Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087396
{
public static readonly long[] Value={ 22L,44L,66L,88L,1010L,222L,1001L,1144L,333L,1100L,22L,444L,1001L,2002L,555L,2112L,1122L,666L,1881L,1100L,777L,44L,1771L,888L,1100L,1144L,999L,2772L,2233L,3300L,4433L,2112L,66L,1122L,1155L,1188L,111L,3344L,3003L,2200L,2255L,2772L,3311L,88L,4455L,4554L,1551L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087396Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087396.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087396Inst : IEnumerable<long>
{
public static readonly long[] Value=A087396.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087396.Bytes);
public long this[int i]=>Value[i];

public static A087396Inst Instance=new A087396Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087347
{
public static readonly long[] Value={ 1L,2L,5L,8L,12L,15L,20L,24L,25L,32L,36L,44L,48L,50L,56L,60L,63L,72L,80L,84L,95L,96L,104L,108L,110L,120L,125L,128L,135L,140L,144L,152L,155L,168L,175L,180L,185L,192L,200L,204L,207L,209L,216L,224L,228L,240L,252L,264L,276L,279L,288L,300L,320L,323L,324L,336L,360L,368L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087347Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087347.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087347Inst : IEnumerable<long>
{
public static readonly long[] Value=A087347.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087347.Bytes);
public long this[int i]=>Value[i];

public static A087347Inst Instance=new A087347Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087346
{
public static readonly long[] Value={ 11L,22L,33L,44L,55L,66L,77L,88L,99L,20L,33L,46L,59L,72L,85L,98L,111L,124L,137L,40L,55L,70L,85L,100L,115L,130L,145L,160L,175L,60L,77L,94L,111L,128L,145L,162L,179L,196L,213L,80L,99L,118L,137L,156L,175L,194L,213L,232L,251L,100L,121L,142L,163L,184L,205L,226L,247L,268L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087346Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087346.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087346Inst : IEnumerable<long>
{
public static readonly long[] Value=A087346.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087346.Bytes);
public long this[int i]=>Value[i];

public static A087346Inst Instance=new A087346Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087345
{
public static readonly BigInteger[] Value={ 3L,13L,210231253L,171190210231L,36101521L,136101521L,BigInteger.Parse("1596165317111770183018911953"),BigInteger.Parse("105120136153171190210231"),0L,BigInteger.Parse("17020172051739117578177661795518145183361852818721") };
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
public class A087345Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087345.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087345Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A087345.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087345.Bytes);
public BigInteger this[int i]=>Value[i];

public static A087345Inst Instance=new A087345Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087344
{
public static readonly BigInteger[] Value={ 2L,11L,5813L,1123L,235813L,BigInteger.Parse("67989163763861225811000877783661019311779979416004714189288006719437081612046600466103755303097540113804746346429") };
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
public class A087344Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087344.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087344Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A087344.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087344.Bytes);
public BigInteger this[int i]=>Value[i];

public static A087344Inst Instance=new A087344Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087343
{
public static readonly long[] Value={ 1L,3L,3L,5L,9L,7L,22L,9L,9L,19L,20L,13L,19L,29L,19L,27L,28L,19L,19L,39L,23L,31L,33L,25L,49L,57L,27L,43L,46L,39L,57L,43L,42L,45L,64L,37L,77L,81L,46L,59L,41L,51L,53L,55L,49L,79L,66L,59L,99L,99L,62L,83L,68L,55L,64L,99L,81L,75L,90L,79L,106L,109L,65L,75L,139L,75L,154L,79L,79L,99L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087343Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087343.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087343Inst : IEnumerable<long>
{
public static readonly long[] Value=A087343.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087343.Bytes);
public long this[int i]=>Value[i];

public static A087343Inst Instance=new A087343Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087342
{
public static readonly BigInteger[] Value={ 1L,32L,321L,5432L,98765L,765432L,22212019181716L,98765432L,987654321L,BigInteger.Parse("19181716151413121110"),BigInteger.Parse("2019181716151413121110"),1312111098765432L,BigInteger.Parse("19181716151413121110987"),BigInteger.Parse("2928272625242322212019181716") };
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
public class A087342Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087342.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087342Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A087342.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087342.Bytes);
public BigInteger this[int i]=>Value[i];

public static A087342Inst Instance=new A087342Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087341
{
public static readonly BigInteger[] Value={ 89L,138140141L,87889091L,8890919293L,141516182021L,BigInteger.Parse("122123124125126128129"),BigInteger.Parse("121122123124125126128129"),707274757677788081L,BigInteger.Parse("21222425262728303233"),BigInteger.Parse("206207208209210212213214215216217"),BigInteger.Parse("405406407408410411412413414415416417") };
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
public class A087341Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087341.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087341Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A087341.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087341.Bytes);
public BigInteger this[int i]=>Value[i];

public static A087341Inst Instance=new A087341Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087340
{
public static readonly long[] Value={ 2L,11L,23L,29L,41L,43L,47L,61L,67L,89L,223L,227L,229L,263L,269L,281L,463L,643L,661L,821L,827L,883L,887L,1123L,1129L,1163L,1213L,1231L,1237L,1279L,1291L,1297L,1321L,1327L,1361L,1367L,1433L,1439L,1453L,1459L,1471L,1493L,1523L,1543L,1549L,1567L,1613L,1637L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087340Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087340.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087340Inst : IEnumerable<long>
{
public static readonly long[] Value=A087340.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087340.Bytes);
public long this[int i]=>Value[i];

public static A087340Inst Instance=new A087340Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087339
{
public static readonly long[] Value={ 2L,11L,12L,14L,16L,21L,23L,25L,29L,32L,34L,41L,43L,47L,49L,52L,56L,58L,61L,65L,67L,74L,76L,85L,89L,92L,94L,98L,111L,122L,128L,166L,182L,212L,218L,221L,223L,227L,229L,232L,236L,245L,254L,256L,263L,265L,269L,272L,278L,281L,287L,292L,296L,322L,326L,346L,362L,364L,388L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087339Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087339.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087339Inst : IEnumerable<long>
{
public static readonly long[] Value=A087339.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087339.Bytes);
public long this[int i]=>Value[i];

public static A087339Inst Instance=new A087339Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087338
{
public static readonly long[] Value={ 1L,2L,2L,18L,6L,8L,30L,4L,26L,6L,6L,4L,50L,4L,56L,6L,22L,6L,50L,40L,12L,24L,138L,20L,132L,70L,78L,8L,232L,2L,160L,144L,32L,322L,12L,44L,216L,294L,60L,394L,1460L,82L,54L,452L,168L,1024L,86L,76L,308L,208L,104L,456L,268L,396L,350L,120L,10L,236L,180L,402L,112L,336L,530L,318L,112L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087338Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087338.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087338Inst : IEnumerable<long>
{
public static readonly long[] Value=A087338.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087338.Bytes);
public long this[int i]=>Value[i];

public static A087338Inst Instance=new A087338Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087337
{
public static readonly BigInteger[] Value={ 8L,64L,4096L,9393931L,59597778583981L,BigInteger.Parse("3551895212145224329469808361"),BigInteger.Parse("12615959598060168145040535737856890513190349434065506321"),BigInteger.Parse("159162436579886479377839626087832918585945622988682310523693499986431065917447322835061923884255835706090955041") };
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
public class A087337Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087337.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087337Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A087337.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087337.Bytes);
public BigInteger this[int i]=>Value[i];

public static A087337Inst Instance=new A087337Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087336
{
public static readonly BigInteger[] Value={ 7L,9L,65L,2294L,6344286L,59597778583982L,BigInteger.Parse("3551895212145224329469808362"),BigInteger.Parse("12615959598060168145040535737856890513190349434065506322") };
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
public class A087336Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087336.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087336Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A087336.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087336.Bytes);
public BigInteger this[int i]=>Value[i];

public static A087336Inst Instance=new A087336Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087335
{
public static readonly BigInteger[] Value={ 4L,16L,121L,361L,5041L,201601L,256032001L,4064251968001L,BigInteger.Parse("1024126980000259968001"),BigInteger.Parse("29365589556381243259975904529351552001"),BigInteger.Parse("82421263677202543043706796882184010324019881962069201381742720001") };
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
public class A087335Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087335.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087335Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A087335.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087335.Bytes);
public BigInteger this[int i]=>Value[i];

public static A087335Inst Instance=new A087335Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087334
{
public static readonly BigInteger[] Value={ 3L,5L,8L,3L,14L,40L,1270L,15874L,251984126L,28673777890680889L,BigInteger.Parse("2806729404119595479093401735"),BigInteger.Parse("15973219322678152520589944038429546981629762353084607") };
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
public class A087334Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087334.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087334Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A087334.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087334.Bytes);
public BigInteger this[int i]=>Value[i];

public static A087334Inst Instance=new A087334Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087333
{
public static readonly BigInteger[] Value={ 3L,13L,3571L,13577L,135799L,135791107L,13579111307L,1357911131503L,13579111315171L,135791113151719L,1357911131517192157L,13579111315171921231UL,BigInteger.Parse("35791113151719212325277"),BigInteger.Parse("357911131517192123252729") };
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
public class A087333Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087333.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087333Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A087333.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087333.Bytes);
public BigInteger this[int i]=>Value[i];

public static A087333Inst Instance=new A087333Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087332
{
public static readonly BigInteger[] Value={ 23L,241L,2467L,24683L,2468101L,246810121L,24681012149L,10121416182022247L,1618202224262830321L,BigInteger.Parse("141618202224262830323"),BigInteger.Parse("12141618202224262830329"),BigInteger.Parse("2426283032343638404244467"),BigInteger.Parse("468101214161820222426283") };
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
public class A087332Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087332.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087332Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A087332.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087332.Bytes);
public BigInteger this[int i]=>Value[i];

public static A087332Inst Instance=new A087332Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087283
{
public static readonly long[] Value={ 3L,1L,1L,3L,1L,1L,2L,2L,2L,1L,1L,3L,1L,1L,1L,2L,3L,1L,1L,3L,3L,2L,1L,1L,1L,2L,1L,3L,1L,2L,2L,1L,1L,2L,3L,1L,1L,3L,1L,1L,1L,2L,3L,1L,1L,2L,1L,1L,1L,3L,3L,1L,1L,2L,1L,1L,1L,3L,1L,2L,2L,1L,1L,2L,1L,3L,2L,1L,1L,3L,1L,2L,1L,1L,1L,3L,2L,2L,2L,1L,1L,2L,3L,1L,1L,3L,1L,1L,2L,2L,1L,1L,1L,2L,1L,3L,1L,2L,2L,1L,1L,2L,3L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087283Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087283.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087283Inst : IEnumerable<long>
{
public static readonly long[] Value=A087283.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087283.Bytes);
public long this[int i]=>Value[i];

public static A087283Inst Instance=new A087283Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087282
{
public static readonly long[] Value={ 1L,1L,1L,3L,1L,2L,2L,1L,1L,3L,1L,2L,1L,1L,1L,3L,2L,2L,2L,1L,2L,3L,2L,1L,1L,2L,1L,1L,1L,3L,1L,2L,1L,1L,1L,2L,1L,3L,1L,1L,1L,2L,1L,3L,2L,1L,1L,2L,3L,1L,1L,3L,2L,1L,3L,2L,2L,1L,1L,2L,1L,1L,1L,3L,1L,2L,2L,1L,2L,3L,2L,1L,1L,2L,1L,1L,1L,3L,1L,2L,2L,1L,1L,2L,1L,3L,1L,1L,1L,2L,1L,3L,1L,2L,2L,1L,1L,2L,1L,3L,2L,1L,1L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087282Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087282.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087282Inst : IEnumerable<long>
{
public static readonly long[] Value=A087282.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087282.Bytes);
public long this[int i]=>Value[i];

public static A087282Inst Instance=new A087282Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087281
{
public static readonly BigInteger[] Value={ 2L,29L,843L,24476L,710647L,20633239L,599074578L,17393796001L,505019158607L,14662949395604L,425730551631123L,12360848946698171L,358890350005878082L,10420180999117162549UL,BigInteger.Parse("302544139324403592003"),BigInteger.Parse("8784200221406821330636"),BigInteger.Parse("255044350560122222180447"),BigInteger.Parse("7405070366464951264563599") };
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
public class A087281Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087281.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087281Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A087281.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087281.Bytes);
public BigInteger this[int i]=>Value[i];

public static A087281Inst Instance=new A087281Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087280
{
public static readonly long[] Value={ 5L,8L,10L,12L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087280Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087280.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087280Inst : IEnumerable<long>
{
public static readonly long[] Value=A087280.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087280.Bytes);
public long this[int i]=>Value[i];

public static A087280Inst Instance=new A087280Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087279
{
public static readonly long[] Value={ 0L,2L,3L,5L,8L,10L,15L,17L,24L,26L,35L,37L,48L,50L,63L,65L,80L,82L,99L,101L,120L,122L,143L,145L,168L,170L,195L,197L,224L,226L,255L,257L,288L,290L,323L,325L,360L,362L,399L,401L,440L,442L,483L,485L,528L,530L,575L,577L,624L,626L,675L,677L,728L,730L,783L,785L,840L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087279Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087279.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087279Inst : IEnumerable<long>
{
public static readonly long[] Value=A087279.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087279.Bytes);
public long this[int i]=>Value[i];

public static A087279Inst Instance=new A087279Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087278
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,8L,9L,10L,15L,16L,17L,24L,25L,26L,35L,36L,37L,48L,49L,50L,63L,64L,65L,80L,81L,82L,99L,100L,101L,120L,121L,122L,143L,144L,145L,168L,169L,170L,195L,196L,197L,224L,225L,226L,255L,256L,257L,288L,289L,290L,323L,324L,325L,360L,361L,362L,399L,400L,401L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087278Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087278.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087278Inst : IEnumerable<long>
{
public static readonly long[] Value=A087278.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087278.Bytes);
public long this[int i]=>Value[i];

public static A087278Inst Instance=new A087278Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087277
{
public static readonly long[] Value={ 2L,6L,90L,960L,1974L,2430L,2730L,2736L,6006L,6096L,6306L,7014L,11934L,14190L,18276L,18486L,21204L,24906L,24984L,25200L,27210L,35700L,38556L,39306L,40860L,44694L,45654L,47124L,49524L,51246L,53220L,56700L,58176L,63330L,63960L,72996L,76650L,80394L,85560L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087277Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087277.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087277Inst : IEnumerable<long>
{
public static readonly long[] Value=A087277.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087277.Bytes);
public long this[int i]=>Value[i];

public static A087277Inst Instance=new A087277Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087276
{
public static readonly long[] Value={ 1L,3L,4L,7L,9L,9L,11L,15L,18L,19L,22L,19L,22L,23L,26L,31L,35L,37L,41L,39L,43L,45L,49L,39L,43L,45L,49L,47L,51L,53L,57L,63L,68L,71L,76L,75L,80L,83L,88L,79L,84L,87L,92L,91L,96L,99L,104L,79L,84L,87L,92L,91L,96L,99L,104L,95L,100L,103L,108L,107L,112L,115L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087276Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087276.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087276Inst : IEnumerable<long>
{
public static readonly long[] Value=A087276.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087276.Bytes);
public long this[int i]=>Value[i];

public static A087276Inst Instance=new A087276Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087275
{
public static readonly long[] Value={ 0L,1L,1L,3L,4L,3L,4L,7L,9L,9L,11L,7L,9L,9L,11L,15L,18L,19L,22L,19L,22L,23L,26L,15L,18L,19L,22L,19L,22L,23L,26L,31L,35L,37L,41L,39L,43L,45L,49L,39L,43L,45L,49L,47L,51L,53L,57L,31L,35L,37L,41L,39L,43L,45L,49L,39L,43L,45L,49L,47L,51L,53L,57L,63L,68L,71L,76L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087275Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087275.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087275Inst : IEnumerable<long>
{
public static readonly long[] Value=A087275.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087275.Bytes);
public long this[int i]=>Value[i];

public static A087275Inst Instance=new A087275Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087274
{
public static readonly long[] Value={ 4L,3L,1L,5L,7L,3L,6L,10L,4L,5L,15L,4L,11L,6L,20L,3L,24L,9L,26L,28L,5L,7L,3L,19L,21L,8L,11L,9L,13L,7L,43L,45L,27L,8L,4L,49L,17L,4L,54L,6L,57L,7L,13L,10L,12L,9L,66L,19L,11L,14L,4L,72L,42L,10L,44L,22L,26L,12L,6L,47L,7L,5L,89L,91L,15L,7L,20L,9L,98L,32L,16L,5L,10L,4L,104L,9L,21L,35L,14L,63L,12L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087274Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087274.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087274Inst : IEnumerable<long>
{
public static readonly long[] Value=A087274.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087274.Bytes);
public long this[int i]=>Value[i];

public static A087274Inst Instance=new A087274Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087273
{
public static readonly long[] Value={ 7L,5L,2L,11L,17L,5L,13L,29L,7L,11L,47L,7L,31L,13L,71L,5L,89L,23L,101L,107L,11L,17L,5L,67L,73L,19L,31L,23L,41L,17L,191L,197L,103L,19L,7L,227L,59L,7L,251L,13L,269L,17L,41L,29L,37L,23L,317L,67L,31L,43L,7L,359L,181L,29L,193L,79L,101L,37L,13L,211L,17L,11L,461L,467L,47L,17L,71L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087273Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087273.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087273Inst : IEnumerable<long>
{
public static readonly long[] Value=A087273.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087273.Bytes);
public long this[int i]=>Value[i];

public static A087273Inst Instance=new A087273Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087272
{
public static readonly long[] Value={ 2L,5L,2L,5L,5L,17L,2L,17L,5L,17L,5L,13L,17L,53L,2L,17L,17L,29L,5L,2L,17L,53L,5L,29L,13L,1619L,17L,29L,53L,1619L,2L,29L,17L,53L,17L,37L,29L,101L,5L,1619L,2L,43L,17L,17L,53L,1619L,5L,37L,29L,29L,13L,53L,1619L,1619L,17L,43L,29L,101L,53L,61L,1619L,1619L,2L,37L,29L,101L,17L,13L,53L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087272Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087272.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087272Inst : IEnumerable<long>
{
public static readonly long[] Value=A087272.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087272.Bytes);
public long this[int i]=>Value[i];

public static A087272Inst Instance=new A087272Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087271
{
public static readonly long[] Value={ 1L,4L,6L,8L,50L,66L,77L,56L,27L,30L,33L,156L,169L,182L,465L,224L,238L,252L,2299L,1380L,189L,902L,207L,96L,100L,1872L,1323L,2464L,1247L,120L,1333L,3168L,528L,1258L,1295L,828L,3441L,2888L,1755L,5800L,1271L,1932L,731L,748L,765L,2852L,2209L,11568L,2695L,4000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087271Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087271.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087271Inst : IEnumerable<long>
{
public static readonly long[] Value=A087271.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087271.Bytes);
public long this[int i]=>Value[i];

public static A087271Inst Instance=new A087271Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087270
{
public static readonly long[] Value={ 4L,6L,8L,10L,14L,15L,16L,20L,22L,24L,27L,30L,33L,38L,39L,40L,44L,46L,48L,50L,51L,54L,56L,58L,62L,63L,64L,66L,72L,75L,77L,78L,80L,82L,90L,92L,93L,94L,96L,100L,102L,105L,108L,114L,115L,116L,117L,118L,120L,122L,123L,124L,125L,126L,132L,134L,136L,138L,140L,142L,144L,146L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087270Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087270.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087270Inst : IEnumerable<long>
{
public static readonly long[] Value=A087270.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087270.Bytes);
public long this[int i]=>Value[i];

public static A087270Inst Instance=new A087270Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087269
{
public static readonly long[] Value={ 1L,9L,12L,18L,21L,25L,26L,28L,32L,34L,35L,36L,42L,45L,49L,52L,55L,57L,60L,65L,68L,69L,70L,74L,76L,81L,84L,85L,86L,87L,88L,91L,95L,98L,99L,104L,106L,110L,111L,112L,119L,121L,128L,129L,130L,133L,135L,141L,143L,145L,147L,155L,158L,159L,160L,161L,162L,165L,170L,172L,177L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087269Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087269.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087269Inst : IEnumerable<long>
{
public static readonly long[] Value=A087269.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087269.Bytes);
public long this[int i]=>Value[i];

public static A087269Inst Instance=new A087269Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087268
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,9L,11L,12L,13L,17L,18L,19L,21L,23L,25L,26L,28L,29L,31L,32L,34L,35L,36L,37L,41L,42L,43L,45L,47L,49L,52L,53L,55L,57L,59L,60L,61L,65L,67L,68L,69L,70L,71L,73L,74L,76L,79L,81L,83L,84L,85L,86L,87L,88L,89L,91L,95L,97L,98L,99L,101L,103L,104L,106L,107L,109L,110L,111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087268Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087268.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087268Inst : IEnumerable<long>
{
public static readonly long[] Value=A087268.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087268.Bytes);
public long this[int i]=>Value[i];

public static A087268Inst Instance=new A087268Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087203
{
public static readonly long[] Value={ 4L,7L,11L,19L,19L,37L,17L,17L,17L,17L,61L,43L,59L,71L,61L,43L,113L,71L,41L,101L,191L,103L,191L,179L,71L,127L,37L,97L,113L,373L,71L,373L,293L,157L,149L,241L,167L,211L,151L,89L,131L,113L,73L,107L,179L,227L,173L,113L,257L,239L,151L,227L,163L,509L,293L,347L,643L,373L,457L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087203Inst : IEnumerable<long>
{
public static readonly long[] Value=A087203.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087203.Bytes);
public long this[int i]=>Value[i];

public static A087203Inst Instance=new A087203Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087202
{
public static readonly long[] Value={ 4L,5L,7L,7L,11L,13L,19L,31L,23L,19L,19L,43L,73L,41L,149L,41L,53L,61L,109L,37L,37L,71L,109L,193L,97L,173L,59L,101L,229L,163L,241L,83L,139L,103L,83L,577L,397L,47L,269L,61L,211L,107L,97L,89L,379L,149L,269L,83L,137L,167L,281L,89L,79L,443L,229L,157L,179L,563L,389L,277L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087202Inst : IEnumerable<long>
{
public static readonly long[] Value=A087202.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087202.Bytes);
public long this[int i]=>Value[i];

public static A087202Inst Instance=new A087202Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087201
{
public static readonly long[] Value={ 11L,13L,17L,19L,47L,37L,61L,67L,79L,107L,53L,149L,97L,89L,109L,223L,107L,179L,181L,101L,197L,101L,257L,139L,137L,197L,313L,257L,257L,223L,449L,373L,233L,463L,479L,409L,257L,409L,383L,317L,587L,607L,401L,463L,347L,313L,751L,313L,443L,349L,809L,661L,587L,367L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087201Inst : IEnumerable<long>
{
public static readonly long[] Value=A087201.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087201.Bytes);
public long this[int i]=>Value[i];

public static A087201Inst Instance=new A087201Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087200
{
public static readonly long[] Value={ 5L,7L,11L,17L,29L,29L,41L,37L,47L,89L,83L,101L,107L,67L,109L,73L,89L,167L,139L,229L,163L,193L,269L,157L,173L,523L,233L,157L,251L,193L,179L,383L,647L,311L,223L,317L,509L,457L,211L,503L,251L,479L,617L,1019L,347L,863L,827L,349L,389L,563L,601L,419L,367L,349L,449L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087200Inst : IEnumerable<long>
{
public static readonly long[] Value=A087200.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087200.Bytes);
public long this[int i]=>Value[i];

public static A087200Inst Instance=new A087200Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087199
{
public static readonly long[] Value={ 6L,2L,0L,3L,5L,0L,4L,9L,0L,8L,9L,9L,4L,0L,0L,0L,1L,6L,6L,6L,8L,0L,0L,6L,8L,1L,2L,0L,4L,7L,7L,7L,8L,1L,6L,7L,3L,5L,0L,7L,8L,6L,2L,0L,0L,1L,8L,6L,0L,0L,1L,6L,2L,0L,0L,9L,8L,9L,5L,6L,8L,8L,9L,9L,1L,3L,1L,4L,6L,9L,0L,6L,0L,6L,0L,0L,3L,3L,3L,6L,4L,1L,8L,5L,5L,1L,6L,2L,5L,3L,1L,8L,1L,4L,9L,2L,4L,3L,2L,8L,0L,0L,7L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087199Inst : IEnumerable<long>
{
public static readonly long[] Value=A087199.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087199.Bytes);
public long this[int i]=>Value[i];

public static A087199Inst Instance=new A087199Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087198
{
public static readonly long[] Value={ 2L,8L,2L,0L,9L,4L,7L,9L,1L,7L,7L,3L,8L,7L,8L,1L,4L,3L,4L,7L,4L,0L,3L,9L,7L,2L,5L,7L,8L,0L,3L,8L,6L,2L,9L,2L,9L,2L,2L,0L,2L,5L,3L,1L,4L,6L,6L,4L,4L,9L,9L,4L,2L,8L,4L,2L,2L,0L,4L,2L,8L,6L,0L,8L,5L,5L,3L,2L,1L,2L,3L,4L,2L,2L,0L,7L,4L,6L,7L,0L,7L,2L,4L,3L,3L,7L,1L,8L,3L,0L,1L,0L,1L,0L,5L,3L,6L,8L,1L,7L,2L,1L,5L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087198Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087198.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087198Inst : IEnumerable<long>
{
public static readonly long[] Value=A087198.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087198.Bytes);
public long this[int i]=>Value[i];

public static A087198Inst Instance=new A087198Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087197
{
public static readonly long[] Value={ 5L,6L,4L,1L,8L,9L,5L,8L,3L,5L,4L,7L,7L,5L,6L,2L,8L,6L,9L,4L,8L,0L,7L,9L,4L,5L,1L,5L,6L,0L,7L,7L,2L,5L,8L,5L,8L,4L,4L,0L,5L,0L,6L,2L,9L,3L,2L,8L,9L,9L,8L,8L,5L,6L,8L,4L,4L,0L,8L,5L,7L,2L,1L,7L,1L,0L,6L,4L,2L,4L,6L,8L,4L,4L,1L,4L,9L,3L,4L,1L,4L,4L,8L,6L,7L,4L,3L,6L,6L,0L,2L,0L,2L,1L,0L,7L,3L,6L,3L,4L,4L,3L,0L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087197Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087197.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087197Inst : IEnumerable<long>
{
public static readonly long[] Value=A087197.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087197.Bytes);
public long this[int i]=>Value[i];

public static A087197Inst Instance=new A087197Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087196
{
public static readonly long[] Value={ 7L,13L,31L,37L,97L,109L,151L,193L,307L,751L,769L,1453L,1723L,2917L,3541L,5113L,8011L,10303L,12289L,12697L,15973L,17293L,28057L,30103L,86143L,106033L,147073L,151687L,362953L,459007L,492103L,552793L,579883L,598303L,684757L,704761L,712891L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087196Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087196.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087196Inst : IEnumerable<long>
{
public static readonly long[] Value=A087196.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087196.Bytes);
public long this[int i]=>Value[i];

public static A087196Inst Instance=new A087196Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087195
{
public static readonly long[] Value={ 7L,13L,25L,31L,37L,49L,57L,97L,109L,133L,151L,183L,193L,307L,325L,381L,385L,393L,553L,751L,769L,871L,973L,993L,1407L,1453L,1537L,1723L,1893L,2257L,2367L,2745L,2863L,2917L,3073L,3541L,3751L,3783L,4557L,5113L,5203L,5403L,6145L,6321L,6973L,7221L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087195Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087195.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087195Inst : IEnumerable<long>
{
public static readonly long[] Value=A087195.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087195.Bytes);
public long this[int i]=>Value[i];

public static A087195Inst Instance=new A087195Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087194
{
public static readonly BigInteger[] Value={ 2L,29L,484398L,15667221L,19291710979L,716525463939L,1068605567805152L,BigInteger.Parse("70525663815429108660"),BigInteger.Parse("2926081151105727289330"),BigInteger.Parse("221376944251520543756333062") };
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
public class A087194Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087194.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087194Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A087194.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087194.Bytes);
public BigInteger this[int i]=>Value[i];

public static A087194Inst Instance=new A087194Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087193
{
public static readonly BigInteger[] Value={ 3L,9L,156L,3431L,2280921L,64092034L,55747783602L,1700642242677L,1657887524047959L,BigInteger.Parse("54732141299289779730"),BigInteger.Parse("1783584256683646551447"),BigInteger.Parse("63884853139612229737722392") };
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
public class A087193Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087193.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087193Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A087193.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087193.Bytes);
public BigInteger this[int i]=>Value[i];

public static A087193Inst Instance=new A087193Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087192
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,8L,11L,15L,20L,27L,36L,48L,64L,86L,115L,154L,206L,275L,367L,490L,654L,872L,1163L,1551L,2068L,2758L,3678L,4904L,6539L,8719L,11626L,15502L,20670L,27560L,36747L,48996L,65328L,87104L,116139L,154852L,206470L,275294L,367059L,489412L,652550L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087192Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087192.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087192Inst : IEnumerable<long>
{
public static readonly long[] Value=A087192.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087192.Bytes);
public long this[int i]=>Value[i];

public static A087192Inst Instance=new A087192Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087191
{
public static readonly long[] Value={ 17L,131L,409L,953L,1889L,8669L,18539L,60623L,77689L,122321L,373049L,437293L,590267L,2249441L,8975009L,9649303L,11111117L,14526289L,19836689L,26484839L,31201649L,56608289L,67796273L,80565889L,84021983L,87588089L,107150489L,150402113L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087191Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087191.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087191Inst : IEnumerable<long>
{
public static readonly long[] Value=A087191.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087191.Bytes);
public long this[int i]=>Value[i];

public static A087191Inst Instance=new A087191Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087190
{
public static readonly long[] Value={ 3L,4L,5L,6L,7L,10L,12L,16L,17L,19L,25L,26L,28L,39L,55L,56L,58L,62L,67L,72L,75L,87L,91L,95L,96L,97L,102L,111L,114L,115L,116L,124L,126L,128L,132L,137L,152L,160L,161L,172L,181L,182L,184L,191L,198L,201L,205L,208L,209L,213L,214L,217L,220L,223L,227L,235L,237L,247L,248L,250L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087190Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087190.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087190Inst : IEnumerable<long>
{
public static readonly long[] Value=A087190.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087190.Bytes);
public long this[int i]=>Value[i];

public static A087190Inst Instance=new A087190Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087189
{
public static readonly BigInteger[] Value={ 1L,83L,16907L,279021L,89444018L,1695011087L,658067703933L,5768410509553937L,122108313460051500L,BigInteger.Parse("1226978854222034501448"),BigInteger.Parse("593538703869555995238872"),BigInteger.Parse("13175226571428140572866093"),BigInteger.Parse("6594852118968926152838341468") };
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
public class A087189Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087189.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087189Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A087189.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087189.Bytes);
public BigInteger this[int i]=>Value[i];

public static A087189Inst Instance=new A087189Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087188
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,3L,3L,4L,4L,5L,6L,6L,8L,9L,10L,13L,14L,16L,18L,20L,24L,27L,30L,35L,37L,42L,47L,51L,59L,64L,72L,81L,88L,98L,109L,120L,134L,147L,163L,179L,195L,216L,236L,258L,284L,310L,339L,371L,403L,441L,480L,523L,572L,621L,675L,734L,796L,865L,937L,1014L,1100L,1189L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087188Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087188.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087188Inst : IEnumerable<long>
{
public static readonly long[] Value=A087188.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087188.Bytes);
public long this[int i]=>Value[i];

public static A087188Inst Instance=new A087188Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087139
{
public static readonly long[] Value={ 2L,2L,3L,2L,11L,2L,5L,30L,15L,3L,6L,10L,81L,3L,17L,961L,15L,7L,2L,5L,6L,2L,3L,3L,12L,3L,57L,5L,16L,5L,166L,15L,13L,2L,3L,2L,30L,2L,25L,3L,47L,3L,3L,2L,521L,9L,3L,15L,17L,42L,17L,51L,39L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087139Inst : IEnumerable<long>
{
public static readonly long[] Value=A087139.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087139.Bytes);
public long this[int i]=>Value[i];

public static A087139Inst Instance=new A087139Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087138
{
public static readonly BigInteger[] Value={ 1L,1L,8L,64L,824L,12968L,252720L,5789712L,153169440L,4589004192L,153643615872L,5684390364288L,230307823878144L,10141452865049088L,482259966649655808L,BigInteger.Parse("24630247225278881280"),BigInteger.Parse("1344614199041549399040"),BigInteger.Parse("78137673004382654223360") };
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
public class A087138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087138Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A087138.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087138.Bytes);
public BigInteger this[int i]=>Value[i];

public static A087138Inst Instance=new A087138Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087137
{
public static readonly BigInteger[] Value={ 0L,1L,1L,6L,15L,120L,495L,5040L,29295L,362880L,2735775L,39916800L,370945575L,6227020800L,68916822975L,1307674368000L,16813959537375L,355687428096000L,5214921734397375L,121645100408832000L,2004231846526284375L,BigInteger.Parse("51090942171709440000"),BigInteger.Parse("934957186489800849375") };
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
public class A087137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087137Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A087137.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087137.Bytes);
public BigInteger this[int i]=>Value[i];

public static A087137Inst Instance=new A087137Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087136
{
public static readonly long[] Value={ 1L,2L,4L,6L,10L,12L,14L,22L,26L,28L,30L,46L,54L,58L,60L,62L,94L,110L,118L,122L,124L,126L,190L,222L,238L,246L,250L,252L,254L,382L,446L,478L,494L,502L,506L,508L,510L,766L,894L,958L,990L,1006L,1014L,1018L,1020L,1022L,1534L,1790L,1918L,1982L,2014L,2030L,2038L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087136Inst : IEnumerable<long>
{
public static readonly long[] Value=A087136.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087136.Bytes);
public long this[int i]=>Value[i];

public static A087136Inst Instance=new A087136Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087135
{
public static readonly long[] Value={ 1L,2L,2L,4L,4L,6L,8L,10L,12L,16L,20L,24L,30L,36L,44L,54L,64L,76L,92L,108L,128L,152L,178L,208L,244L,284L,330L,384L,444L,512L,592L,680L,780L,896L,1024L,1170L,1336L,1520L,1728L,1964L,2226L,2520L,2852L,3220L,3632L,4096L,4608L,5180L,5820L,6528L,7316L,8194L,9164L,10240L,11436L,12756L,14216L,15834L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087135Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087135.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087135Inst : IEnumerable<long>
{
public static readonly long[] Value=A087135.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087135.Bytes);
public long this[int i]=>Value[i];

public static A087135Inst Instance=new A087135Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087134
{
public static readonly long[] Value={ 1L,2L,6L,20L,42L,84L,156L,312L,684L,1020L,1380L,1860L,3480L,3720L,4920L,7320L,10980L,14640L,16920L,21960L,26280L,34920L,45720L,59640L,69840L,89880L,106680L,125160L,145320L,177240L,213360L,244440L,269640L,354480L,320040L,375480L,435960L,456120L,531720L,647640L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087134Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087134.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087134Inst : IEnumerable<long>
{
public static readonly long[] Value=A087134.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087134.Bytes);
public long this[int i]=>Value[i];

public static A087134Inst Instance=new A087134Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087133
{
public static readonly long[] Value={ 1L,2L,2L,2L,2L,3L,2L,2L,2L,3L,2L,3L,2L,3L,3L,2L,2L,3L,2L,4L,3L,3L,2L,3L,2L,3L,2L,4L,2L,4L,2L,2L,3L,3L,3L,3L,2L,3L,3L,4L,2L,5L,2L,4L,3L,3L,2L,3L,2L,3L,3L,4L,2L,3L,3L,4L,3L,3L,2L,5L,2L,3L,3L,2L,3L,5L,2L,4L,3L,4L,2L,3L,2L,3L,3L,4L,3L,5L,2L,4L,2L,3L,2L,6L,3L,3L,3L,5L,2L,4L,3L,4L,3L,3L,3L,3L,2L,3L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087133Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087133.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087133Inst : IEnumerable<long>
{
public static readonly long[] Value=A087133.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087133.Bytes);
public long this[int i]=>Value[i];

public static A087133Inst Instance=new A087133Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087132
{
public static readonly BigInteger[] Value={ 1L,2L,14L,146L,2602L,71412L,2675724L,134269158L,8747088662L,717107850956L,72007758701716L,8736187050160132L,1258160557017484564L,BigInteger.Parse("212232765513231245096"),BigInteger.Parse("41518913481377118146520"),BigInteger.Parse("9309797624034705006898470"),BigInteger.Parse("2374942651509463493006400390"),BigInteger.Parse("683620331016710787068868581580") };
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
public class A087132Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087132.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087132Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A087132.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087132.Bytes);
public BigInteger this[int i]=>Value[i];

public static A087132Inst Instance=new A087132Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087131
{
public static readonly long[] Value={ 2L,2L,12L,32L,112L,352L,1152L,3712L,12032L,38912L,125952L,407552L,1318912L,4268032L,13811712L,44695552L,144637952L,468058112L,1514668032L,4901568512L,15861809152L,51329892352L,166107021312L,537533612032L,1739495309312L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087131Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087131.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087131Inst : IEnumerable<long>
{
public static readonly long[] Value=A087131.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087131.Bytes);
public long this[int i]=>Value[i];

public static A087131Inst Instance=new A087131Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087130
{
public static readonly long[] Value={ 2L,5L,27L,140L,727L,3775L,19602L,101785L,528527L,2744420L,14250627L,73997555L,384238402L,1995189565L,10360186227L,53796120700L,279340789727L,1450500069335L,7531841136402L,39109705751345L,203080369893127L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087130Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087130.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087130Inst : IEnumerable<long>
{
public static readonly long[] Value=A087130.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087130.Bytes);
public long this[int i]=>Value[i];

public static A087130Inst Instance=new A087130Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087129
{
public static readonly long[] Value={ 1L,3L,1L,7L,9L,3L,9L,3L,9L,12L,3L,12L,24L,9L,36L,3L,33L,3L,12L,9L,3L,12L,9L,12L,15L,24L,9L,12L,15L,33L,12L,24L,3L,9L,36L,3L,9L,24L,36L,27L,12L,12L,9L,3L,21L,96L,3L,9L,3L,12L,9L,3L,12L,105L,3L,60L,12L,9L,39L,45L,27L,9L,12L,3L,12L,12L,45L,12L,15L,33L,15L,21L,3L,9L,3L,12L,9L,24L,3L,33L,15L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087129Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087129.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087129Inst : IEnumerable<long>
{
public static readonly long[] Value=A087129.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087129.Bytes);
public long this[int i]=>Value[i];

public static A087129Inst Instance=new A087129Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087128
{
public static readonly long[] Value={ 1L,2L,5L,6L,13L,22L,25L,34L,37L,46L,58L,61L,73L,97L,106L,142L,145L,178L,181L,193L,202L,205L,217L,226L,238L,253L,277L,286L,298L,313L,346L,358L,382L,385L,394L,430L,433L,442L,466L,502L,529L,541L,553L,562L,565L,586L,682L,685L,694L,697L,709L,718L,721L,733L,838L,841L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087128Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087128.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087128Inst : IEnumerable<long>
{
public static readonly long[] Value=A087128.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087128.Bytes);
public long this[int i]=>Value[i];

public static A087128Inst Instance=new A087128Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087127
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,8L,19L,18L,6L,1L,26L,163L,432L,564L,360L,90L,1L,80L,1135L,6354L,18078L,28800L,26100L,12600L,2520L,1L,242L,7291L,77400L,405060L,1210680L,2211570L,2520000L,1751400L,680400L,113400L,1L,728L,45199L,862218L,7667646L,38350080L,118848420L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087127Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087127.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087127Inst : IEnumerable<long>
{
public static readonly long[] Value=A087127.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087127.Bytes);
public long this[int i]=>Value[i];

public static A087127Inst Instance=new A087127Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087126
{
public static readonly long[] Value={ 3L,5L,7L,17L,19L,43L,101L,157L,163L,257L,487L,1459L,2029L,4423L,6163L,14407L,19183L,22651L,23549L,26407L,37057L,39367L,62501L,65537L,77659L,113233L,121453L,143263L,208393L,292141L,342733L,375157L,412807L,527803L,564899L,590593L,697049L,843643L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087126Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087126.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087126Inst : IEnumerable<long>
{
public static readonly long[] Value=A087126.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087126.Bytes);
public long this[int i]=>Value[i];

public static A087126Inst Instance=new A087126Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087125
{
public static readonly BigInteger[] Value={ 0L,5L,54L,539L,5340L,52865L,523314L,5180279L,51279480L,507614525L,5024865774L,49741043219L,492385566420L,4874114620985L,48248760643434L,477613491813359L,4727886157490160L,46801248083088245L,463284594673392294L,4586044698650834699L,BigInteger.Parse("45397162391834954700") };
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
public class A087125Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087125.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087125Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A087125.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087125.Bytes);
public BigInteger this[int i]=>Value[i];

public static A087125Inst Instance=new A087125Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087124
{
public static readonly long[] Value={ 1L,3L,6L,15L,37L,94L,241L,623L,1618L,4215L,11001L,28746L,75169L,196651L,514606L,1346879L,3525565L,9229062L,24160401L,63250167L,165586906L,433505383L,1134920881L,2971243730L,7778788417L,20365086099L,53316412566L,139584058863L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087124Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087124.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087124Inst : IEnumerable<long>
{
public static readonly long[] Value=A087124.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087124.Bytes);
public long this[int i]=>Value[i];

public static A087124Inst Instance=new A087124Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087059
{
public static readonly long[] Value={ 2L,1L,7L,4L,14L,9L,2L,16L,7L,25L,14L,1L,23L,8L,34L,17L,47L,28L,7L,41L,18L,56L,31L,4L,46L,17L,63L,32L,82L,49L,14L,68L,31L,89L,50L,9L,71L,28L,94L,49L,2L,72L,23L,97L,46L,124L,71L,16L,98L,41L,127L,68L,7L,97L,34L,128L,63L,161L,94L,25L,127L,56L,162L,89L,14L,124L,47L,161L,82L,1L,119L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087059Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087059.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087059Inst : IEnumerable<long>
{
public static readonly long[] Value=A087059.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087059.Bytes);
public long this[int i]=>Value[i];

public static A087059Inst Instance=new A087059Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087058
{
public static readonly long[] Value={ 4L,9L,25L,36L,64L,81L,100L,144L,169L,225L,256L,289L,361L,400L,484L,529L,625L,676L,729L,841L,900L,1024L,1089L,1156L,1296L,1369L,1521L,1600L,1764L,1849L,1936L,2116L,2209L,2401L,2500L,2601L,2809L,2916L,3136L,3249L,3364L,3600L,3721L,3969L,4096L,4356L,4489L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087058Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087058.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087058Inst : IEnumerable<long>
{
public static readonly long[] Value=A087058.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087058.Bytes);
public long this[int i]=>Value[i];

public static A087058Inst Instance=new A087058Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087057
{
public static readonly long[] Value={ 2L,3L,5L,6L,8L,9L,10L,12L,13L,15L,16L,17L,19L,20L,22L,23L,25L,26L,27L,29L,30L,32L,33L,34L,36L,37L,39L,40L,42L,43L,44L,46L,47L,49L,50L,51L,53L,54L,56L,57L,58L,60L,61L,63L,64L,66L,67L,68L,70L,71L,73L,74L,75L,77L,78L,80L,81L,83L,84L,85L,87L,88L,90L,91L,92L,94L,95L,97L,98L,99L,101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087057Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087057.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087057Inst : IEnumerable<long>
{
public static readonly long[] Value=A087057.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087057.Bytes);
public long this[int i]=>Value[i];

public static A087057Inst Instance=new A087057Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087056
{
public static readonly long[] Value={ 1L,4L,2L,7L,1L,8L,17L,7L,18L,4L,17L,32L,14L,31L,9L,28L,2L,23L,46L,16L,41L,7L,34L,63L,25L,56L,14L,47L,1L,36L,73L,23L,62L,8L,49L,92L,34L,79L,17L,64L,113L,47L,98L,28L,81L,7L,62L,119L,41L,100L,18L,79L,142L,56L,121L,31L,98L,4L,73L,144L,46L,119L,17L,92L,169L,63L,142L,32L,113L,196L,82L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087056Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087056.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087056Inst : IEnumerable<long>
{
public static readonly long[] Value=A087056.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087056.Bytes);
public long this[int i]=>Value[i];

public static A087056Inst Instance=new A087056Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087055
{
public static readonly long[] Value={ 1L,4L,16L,25L,49L,64L,81L,121L,144L,196L,225L,256L,324L,361L,441L,484L,576L,625L,676L,784L,841L,961L,1024L,1089L,1225L,1296L,1444L,1521L,1681L,1764L,1849L,2025L,2116L,2304L,2401L,2500L,2704L,2809L,3025L,3136L,3249L,3481L,3600L,3844L,3969L,4225L,4356L,4489L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087055Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087055.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087055Inst : IEnumerable<long>
{
public static readonly long[] Value=A087055.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087055.Bytes);
public long this[int i]=>Value[i];

public static A087055Inst Instance=new A087055Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087054
{
public static readonly long[] Value={ 31L,41L,59L,61L,71L,101L,103L,113L,131L,151L,167L,191L,199L,211L,227L,239L,241L,251L,263L,269L,271L,281L,293L,311L,331L,347L,359L,383L,401L,419L,421L,431L,439L,461L,467L,479L,487L,491L,503L,521L,541L,563L,571L,587L,599L,607L,617L,631L,641L,647L,653L,661L,691L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087054Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087054.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087054Inst : IEnumerable<long>
{
public static readonly long[] Value=A087054.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087054.Bytes);
public long this[int i]=>Value[i];

public static A087054Inst Instance=new A087054Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087053
{
public static readonly long[] Value={ 31L,41L,61L,59L,71L,91L,71L,87L,101L,101L,121L,113L,103L,129L,151L,131L,161L,143L,119L,191L,171L,131L,167L,211L,151L,221L,185L,151L,241L,167L,191L,213L,227L,271L,221L,199L,301L,191L,311L,269L,243L,167L,211L,341L,275L,297L,269L,361L,215L,311L,293L,247L,371L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087053Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087053.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087053Inst : IEnumerable<long>
{
public static readonly long[] Value=A087053.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087053.Bytes);
public long this[int i]=>Value[i];

public static A087053Inst Instance=new A087053Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087052
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,19L,19L,19L,19L,19L,19L,19L,19L,19L,19L,29L,29L,29L,29L,29L,29L,29L,29L,29L,29L,39L,39L,39L,39L,39L,39L,39L,39L,39L,39L,49L,49L,49L,49L,49L,49L,49L,49L,49L,49L,59L,59L,59L,59L,59L,59L,59L,59L,59L,59L,69L,69L,69L,69L,69L,69L,69L,69L,69L,69L,79L,79L,79L,79L,79L,79L,79L,79L,79L,79L,89L,89L,89L,89L,89L,89L,89L,89L,89L,89L,99L,99L,99L,99L,99L,99L,99L,99L,99L,99L,199L,199L,199L,199L,199L,199L,199L,199L,199L,199L,199L,199L,199L,199L,199L,199L,199L,199L,199L,199L,199L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087052Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087052.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087052Inst : IEnumerable<long>
{
public static readonly long[] Value=A087052.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087052.Bytes);
public long this[int i]=>Value[i];

public static A087052Inst Instance=new A087052Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087051
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10000L,11111L,11112L,11113L,11114L,11115L,11116L,11117L,11118L,11119L,20000L,21111L,22222L,22223L,22224L,22225L,22226L,22227L,22228L,22229L,30000L,31111L,32222L,33333L,33334L,33335L,33336L,33337L,33338L,33339L,40000L,41111L,42222L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087051Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087051.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087051Inst : IEnumerable<long>
{
public static readonly long[] Value=A087051.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087051.Bytes);
public long this[int i]=>Value[i];

public static A087051Inst Instance=new A087051Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087050
{
public static readonly long[] Value={ 2L,2L,3L,2L,4L,3L,2L,2L,5L,3L,2L,4L,6L,2L,2L,3L,4L,7L,5L,2L,3L,2L,2L,3L,8L,2L,6L,5L,2L,4L,9L,2L,2L,3L,2L,4L,7L,3L,10L,2L,6L,4L,2L,3L,2L,11L,2L,5L,3L,8L,2L,3L,2L,2L,12L,7L,2L,5L,2L,3L,2L,4L,9L,2L,2L,13L,3L,2L,5L,4L,6L,2L,2L,3L,8L,14L,3L,10L,2L,3L,4L,2L,6L,2L,4L,15L,2L,2L,3L,2L,4L,11L,9L,2L,7L,2L,5L,6L,16L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087050Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087050.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087050Inst : IEnumerable<long>
{
public static readonly long[] Value=A087050.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087050.Bytes);
public long this[int i]=>Value[i];

public static A087050Inst Instance=new A087050Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087049
{
public static readonly long[] Value={ 1L,1L,0L,0L,1L,0L,0L,0L,1L,1L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,1L,0L,1L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,1L,0L,0L,1L,1L,1L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,1L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,1L,0L,0L,0L,1L,1L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,1L,1L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087049Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087049.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087049Inst : IEnumerable<long>
{
public static readonly long[] Value=A087049.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087049.Bytes);
public long this[int i]=>Value[i];

public static A087049Inst Instance=new A087049Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087048
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,1L,2L,2L,2L,1L,2L,2L,1L,2L,1L,2L,2L,2L,1L,1L,2L,2L,4L,1L,2L,1L,2L,2L,1L,2L,2L,2L,2L,2L,2L,1L,2L,2L,4L,1L,1L,2L,4L,2L,1L,2L,1L,1L,2L,4L,2L,1L,2L,2L,2L,2L,4L,1L,4L,2L,4L,3L,1L,2L,2L,4L,1L,4L,2L,1L,4L,4L,2L,1L,2L,2L,2L,1L,2L,2L,2L,2L,4L,1L,1L,2L,2L,4L,4L,2L,2L,1L,2L,2L,2L,4L,4L,4L,2L,3L,2L,1L,2L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087048Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087048.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087048Inst : IEnumerable<long>
{
public static readonly long[] Value=A087048.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087048.Bytes);
public long this[int i]=>Value[i];

public static A087048Inst Instance=new A087048Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087047
{
public static readonly BigInteger[] Value={ 1L,4L,40L,800L,28000L,1568000L,131712000L,15805440000L,2607897600000L,573737472000000L,164088916992000000L,BigInteger.Parse("59728365785088000000"),BigInteger.Parse("27176406432215040000000"),BigInteger.Parse("15218787602040422400000000") };
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
public class A087047Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087047.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087047Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A087047.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087047.Bytes);
public BigInteger this[int i]=>Value[i];

public static A087047Inst Instance=new A087047Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087046
{
public static readonly BigInteger[] Value={ 1L,2L,12L,240L,65280L,4294901760L,18446744069414584320UL,BigInteger.Parse("340282366920938463444927863358058659840"),BigInteger.Parse("115792089237316195423570985008687907852929702298719625575994209400481361428480") };
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
public class A087046Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087046.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087046Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A087046.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087046.Bytes);
public BigInteger this[int i]=>Value[i];

public static A087046Inst Instance=new A087046Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087045
{
public static readonly long[] Value={ 1L,4L,64L,400L,489L,519L,2164L,3589L,8703L,84761L,358837L,1463825L,1668392L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087045Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087045.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087045Inst : IEnumerable<long>
{
public static readonly long[] Value=A087045.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087045.Bytes);
public long this[int i]=>Value[i];

public static A087045Inst Instance=new A087045Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087044
{
public static readonly long[] Value={ 9L,8L,6L,2L,4L,9L,0L,1L,5L,0L,4L,4L,8L,5L,9L,3L,3L,6L,3L,7L,0L,0L,3L,4L,7L,4L,3L,0L,0L,5L,8L,8L,2L,7L,8L,2L,3L,1L,1L,3L,2L,5L,3L,4L,2L,6L,0L,8L,6L,4L,6L,3L,3L,0L,1L,5L,5L,9L,5L,1L,4L,9L,4L,2L,1L,5L,8L,8L,4L,1L,2L,6L,7L,7L,7L,6L,1L,5L,0L,8L,1L,0L,5L,1L,5L,3L,9L,1L,6L,4L,8L,3L,8L,1L,1L,0L,0L,7L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087044Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087044.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087044Inst : IEnumerable<long>
{
public static readonly long[] Value=A087044.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087044.Bytes);
public long this[int i]=>Value[i];

public static A087044Inst Instance=new A087044Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087027
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,10L,110L,111L,112L,113L,114L,115L,116L,117L,118L,120L,210L,221L,222L,223L,224L,225L,226L,227L,228L,230L,310L,321L,332L,333L,334L,335L,336L,337L,338L,340L,410L,421L,432L,443L,444L,445L,446L,447L,448L,450L,510L,521L,532L,543L,554L,555L,556L,557L,558L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087027Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087027.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087027Inst : IEnumerable<long>
{
public static readonly long[] Value=A087027.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087027.Bytes);
public long this[int i]=>Value[i];

public static A087027Inst Instance=new A087027Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087026
{
public static readonly BigInteger[] Value={ 77760L,1382399778816000L,98221093640386560L,BigInteger.Parse("1053590173895849103360"),BigInteger.Parse("821095240766161265049600000"),BigInteger.Parse("511883170649353472639948811682935064652736000"),BigInteger.Parse("410719109641406326635474611575828305116907342385175347200") };
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
public class A087026Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087026.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087026Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A087026.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087026.Bytes);
public BigInteger this[int i]=>Value[i];

public static A087026Inst Instance=new A087026Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087025
{
public static readonly BigInteger[] Value={ 255360L,17205180696931968L,1951532915603927040L,BigInteger.Parse("12430490030984319840000"),BigInteger.Parse("9956179688423375044684800000"),BigInteger.Parse("6080633705911286890368486450696472902951229440"),BigInteger.Parse("4809378729404888733987843426081300724182624228548100710400") };
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
public class A087025Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087025.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087025Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A087025.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087025.Bytes);
public BigInteger this[int i]=>Value[i];

public static A087025Inst Instance=new A087025Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087024
{
public static readonly long[] Value={ 32L,384L,1280L,576L,1536L,384L,1536L,4194304L,16777216L,3538944L,1769472L,110592L,221184L,13824L,6912L,48318382080L,9663676416L,3538944L,75497472L,14155776L,56623104L,884736L,55296L,57982058496L,3710851743744L,37748736L,695784701952L,27648L,27648L,2654208L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087024Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087024.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087024Inst : IEnumerable<long>
{
public static readonly long[] Value=A087024.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087024.Bytes);
public long this[int i]=>Value[i];

public static A087024Inst Instance=new A087024Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087023
{
public static readonly long[] Value={ 3L,2L,4L,2L,2L,2L,2L,3L,3L,5L,2L,2L,2L,2L,2L,4L,3L,3L,3L,2L,2L,2L,2L,3L,3L,3L,5L,2L,2L,2L,5L,2L,7L,2L,3L,2L,2L,5L,3L,4L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087023Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087023.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087023Inst : IEnumerable<long>
{
public static readonly long[] Value=A087023.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087023.Bytes);
public long this[int i]=>Value[i];

public static A087023Inst Instance=new A087023Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087022
{
public static readonly long[] Value={ 6L,9L,12L,10L,11L,9L,11L,23L,25L,25L,22L,18L,19L,15L,14L,38L,35L,24L,28L,25L,27L,21L,17L,38L,44L,27L,43L,16L,16L,23L,42L,35L,37L,30L,29L,14L,23L,62L,41L,51L,28L,26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087022Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087022.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087022Inst : IEnumerable<long>
{
public static readonly long[] Value=A087022.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087022.Bytes);
public long this[int i]=>Value[i];

public static A087022Inst Instance=new A087022Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087021
{
public static readonly long[] Value={ 4L,8L,9L,8L,10L,8L,10L,21L,23L,19L,19L,15L,16L,12L,11L,33L,31L,19L,24L,22L,24L,18L,14L,33L,39L,23L,36L,13L,13L,19L,36L,32L,29L,27L,25L,11L,20L,56L,37L,46L,25L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087021Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087021.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087021Inst : IEnumerable<long>
{
public static readonly long[] Value=A087021.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087021.Bytes);
public long this[int i]=>Value[i];

public static A087021Inst Instance=new A087021Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087020
{
public static readonly BigInteger[] Value={ 37L,5882353L,333667L,513239L,121499449L,BigInteger.Parse("11111111111111111111111"),BigInteger.Parse("154083204930662557781201849"),39526741L,9999999900000001L,BigInteger.Parse("59779577156334533866654838281"),BigInteger.Parse("119968369144846370226083377"),BigInteger.Parse("8396862596258693901610602298557167100076327481") };
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
public class A087020Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087020.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087020Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A087020.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087020.Bytes);
public BigInteger this[int i]=>Value[i];

public static A087020Inst Instance=new A087020Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087019
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,100L,111L,112L,113L,114L,115L,116L,117L,118L,119L,200L,211L,222L,223L,224L,225L,226L,227L,228L,229L,300L,311L,322L,333L,334L,335L,336L,337L,338L,339L,400L,411L,422L,433L,444L,445L,446L,447L,448L,449L,500L,511L,522L,533L,544L,555L,556L,557L,558L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087019Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087019.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087019Inst : IEnumerable<long>
{
public static readonly long[] Value=A087019.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087019.Bytes);
public long this[int i]=>Value[i];

public static A087019Inst Instance=new A087019Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087018
{
public static readonly BigInteger[] Value={ 1L,3L,16L,123L,1453L,27060L,803383L,38256129L,2932126904L,362464081089L,72358024951979L,23344004888219544L,12176743686773409053UL,BigInteger.Parse("10272520597198595537175"),BigInteger.Parse("14018081932741301581509848") };
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
public class A087018Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087018.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087018Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A087018.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A087018.Bytes);
public BigInteger this[int i]=>Value[i];

public static A087018Inst Instance=new A087018Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087017
{
public static readonly long[] Value={ 9L,4L,7L,5L,7L,3L,9L,0L,1L,0L,8L,3L,8L,2L,5L,7L,7L,6L,8L,8L,4L,1L,5L,2L,9L,8L,6L,3L,5L,3L,4L,5L,8L,0L,6L,4L,3L,7L,6L,4L,1L,0L,2L,6L,2L,7L,2L,4L,3L,1L,3L,3L,4L,2L,2L,4L,0L,2L,6L,9L,8L,4L,9L,8L,5L,7L,6L,6L,1L,2L,3L,2L,6L,3L,2L,6L,9L,6L,9L,9L,2L,9L,5L,9L,9L,8L,3L,0L,4L,3L,9L,4L,4L,9L,3L,5L,8L,6L,2L,7L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087017Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087017.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087017Inst : IEnumerable<long>
{
public static readonly long[] Value=A087017.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087017.Bytes);
public long this[int i]=>Value[i];

public static A087017Inst Instance=new A087017Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087016
{
public static readonly long[] Value={ 1L,0L,6L,9L,2L,2L,2L,6L,4L,9L,2L,6L,6L,4L,1L,2L,9L,4L,9L,5L,4L,3L,0L,0L,8L,8L,7L,8L,6L,9L,7L,8L,9L,1L,6L,0L,4L,6L,5L,2L,7L,6L,1L,6L,3L,5L,6L,0L,6L,8L,3L,3L,1L,3L,6L,5L,9L,5L,5L,7L,7L,5L,6L,2L,9L,2L,1L,8L,0L,9L,3L,5L,5L,4L,3L,9L,1L,6L,7L,3L,9L,5L,0L,2L,6L,5L,3L,1L,2L,2L,2L,7L,1L,9L,2L,2L,5L,3L,8L,4L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087016Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087016.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087016Inst : IEnumerable<long>
{
public static readonly long[] Value=A087016.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087016.Bytes);
public long this[int i]=>Value[i];

public static A087016Inst Instance=new A087016Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087015
{
public static readonly long[] Value={ 8L,4L,8L,7L,1L,7L,5L,7L,9L,7L,2L,3L,8L,9L,9L,2L,2L,8L,6L,0L,8L,2L,0L,7L,6L,1L,2L,2L,7L,7L,2L,2L,9L,9L,7L,2L,7L,6L,5L,5L,2L,2L,5L,4L,1L,3L,8L,4L,8L,6L,9L,3L,5L,6L,9L,6L,0L,3L,4L,4L,9L,4L,7L,4L,8L,7L,2L,8L,5L,5L,5L,0L,9L,9L,6L,3L,0L,9L,2L,5L,3L,9L,9L,7L,3L,4L,5L,2L,3L,7L,0L,3L,1L,5L,0L,2L,5L,9L,1L,4L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087015Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087015.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087015Inst : IEnumerable<long>
{
public static readonly long[] Value=A087015.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087015.Bytes);
public long this[int i]=>Value[i];

public static A087015Inst Instance=new A087015Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087014
{
public static readonly long[] Value={ 6L,0L,3L,2L,4L,4L,2L,8L,1L,2L,0L,9L,4L,4L,6L,2L,0L,6L,1L,9L,1L,4L,2L,9L,2L,2L,4L,5L,3L,4L,7L,0L,2L,0L,7L,9L,8L,8L,3L,0L,0L,3L,4L,2L,0L,3L,8L,9L,4L,5L,9L,7L,6L,5L,3L,8L,7L,7L,6L,9L,2L,0L,4L,1L,1L,9L,4L,3L,2L,7L,8L,5L,6L,7L,9L,3L,3L,5L,2L,9L,0L,7L,4L,8L,2L,9L,8L,6L,8L,8L,3L,6L,9L,8L,7L,3L,7L,4L,1L,4L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087014Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087014.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087014Inst : IEnumerable<long>
{
public static readonly long[] Value=A087014.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087014.Bytes);
public long this[int i]=>Value[i];

public static A087014Inst Instance=new A087014Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087013
{
public static readonly long[] Value={ 2L,9L,3L,7L,5L,5L,9L,6L,5L,3L,3L,8L,6L,0L,9L,9L,5L,4L,7L,1L,7L,6L,8L,1L,6L,1L,0L,3L,2L,0L,5L,4L,6L,1L,7L,6L,6L,2L,0L,6L,2L,5L,3L,5L,9L,6L,7L,9L,8L,4L,3L,0L,5L,0L,1L,4L,9L,5L,7L,8L,9L,8L,8L,6L,3L,3L,3L,9L,6L,0L,4L,3L,0L,4L,0L,8L,7L,5L,0L,2L,2L,7L,3L,6L,1L,0L,2L,7L,2L,4L,3L,3L,2L,7L,3L,7L,4L,8L,4L,9L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087013Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087013.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087013Inst : IEnumerable<long>
{
public static readonly long[] Value=A087013.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087013.Bytes);
public long this[int i]=>Value[i];

public static A087013Inst Instance=new A087013Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A087012
{
public static readonly long[] Value={ 1L,3L,4L,5L,8L,10L,11L,12L,13L,15L,20L,22L,23L,24L,25L,26L,31L,34L,35L,37L,49L,50L,52L,53L,57L,58L,59L,62L,63L,69L,72L,73L,75L,79L,82L,83L,84L,85L,86L,91L,92L,93L,94L,95L,97L,99L,141L,147L,148L,149L,152L,153L,164L,165L,168L,175L,176L,182L,183L,187L,188L,189L,200L,244L,245L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A087012Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A087012.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A087012Inst : IEnumerable<long>
{
public static readonly long[] Value=A087012.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A087012.Bytes);
public long this[int i]=>Value[i];

public static A087012Inst Instance=new A087012Inst();

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