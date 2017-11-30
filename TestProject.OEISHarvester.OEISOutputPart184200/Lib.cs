using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A214657
{
public static readonly long[] Value={ 0L,1L,3L,5L,7L,9L,11L,13L,15L,17L,19L,21L,22L,24L,26L,28L,30L,32L,34L,36L,38L,40L,42L,43L,45L,47L,49L,51L,53L,55L,57L,59L,61L,63L,65L,66L,68L,70L,72L,74L,76L,78L,80L,82L,84L,86L,87L,89L,91L,93L,95L,97L,99L,101L,103L,105L,107L,108L,110L,112L,114L,116L,118L,120L,122L,124L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214657Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214657.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214657Inst : IEnumerable<long>
{
public static readonly long[] Value=A214657.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214657.Bytes);
public long this[int i]=>Value[i];

public static A214657Inst Instance=new A214657Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214658
{
public static readonly long[] Value={ 2L,3L,31L,40519L,51061L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214658Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214658.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214658Inst : IEnumerable<long>
{
public static readonly long[] Value=A214658.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214658.Bytes);
public long this[int i]=>Value[i];

public static A214658Inst Instance=new A214658Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214659
{
public static readonly long[] Value={ 0L,1L,14L,53L,132L,265L,466L,749L,1128L,1617L,2230L,2981L,3884L,4953L,6202L,7645L,9296L,11169L,13278L,15637L,18260L,21161L,24354L,27853L,31672L,35825L,40326L,45189L,50428L,56057L,62090L,68541L,75424L,82753L,90542L,98805L,107556L,116809L,126578L,136877L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214659Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214659.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214659Inst : IEnumerable<long>
{
public static readonly long[] Value=A214659.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214659.Bytes);
public long this[int i]=>Value[i];

public static A214659Inst Instance=new A214659Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214660
{
public static readonly long[] Value={ 1L,17L,51L,103L,173L,261L,367L,491L,633L,793L,971L,1167L,1381L,1613L,1863L,2131L,2417L,2721L,3043L,3383L,3741L,4117L,4511L,4923L,5353L,5801L,6267L,6751L,7253L,7773L,8311L,8867L,9441L,10033L,10643L,11271L,11917L,12581L,13263L,13963L,14681L,15417L,16171L,16943L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214660Inst : IEnumerable<long>
{
public static readonly long[] Value=A214660.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214660.Bytes);
public long this[int i]=>Value[i];

public static A214660Inst Instance=new A214660Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214661
{
public static readonly long[] Value={ 1L,3L,9L,7L,15L,25L,13L,23L,35L,49L,21L,33L,47L,63L,81L,31L,45L,61L,79L,99L,121L,43L,59L,77L,97L,119L,143L,169L,57L,75L,95L,117L,141L,167L,195L,225L,73L,93L,115L,139L,165L,193L,223L,255L,289L,91L,113L,137L,163L,191L,221L,253L,287L,323L,361L,111L,135L,161L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214661Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214661.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214661Inst : IEnumerable<long>
{
public static readonly long[] Value=A214661.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214661.Bytes);
public long this[int i]=>Value[i];

public static A214661Inst Instance=new A214661Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214662
{
public static readonly BigInteger[] Value={ 5L,2L,3L,3413L,50069L,8089L,487L,2099L,10405071317L,1274641129L,164496735539L,3514531963L,15624709L,23747111L,10343539L,56429700667L,1931869473647715169L,2383792821710269L,144326697012150473L,2053857208873393249L,BigInteger.Parse("128801386946535261205906957"),2298815880166789L };
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
public class A214662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214662Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A214662.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A214662.Bytes);
public BigInteger this[int i]=>Value[i];

public static A214662Inst Instance=new A214662Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214663
{
public static readonly long[] Value={ 1L,1L,2L,6L,12L,25L,57L,124L,268L,588L,1285L,2801L,6118L,13362L,29168L,63685L,139057L,303608L,662888L,1447352L,3160121L,6899745L,15064810L,32892270L,71816436L,156802881L,342360937L,747505396L,1632091412L,3563482500L,7780451037L,16987713169L,37090703118L,80983251898L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214663Inst : IEnumerable<long>
{
public static readonly long[] Value=A214663.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214663.Bytes);
public long this[int i]=>Value[i];

public static A214663Inst Instance=new A214663Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214664
{
public static readonly long[] Value={ 1L,1L,-1L,-1L,2L,2L,-2L,-2L,0L,3L,3L,-3L,-3L,-3L,1L,4L,2L,0L,-4L,-4L,-4L,2L,5L,5L,-1L,-5L,-5L,-5L,-5L,-3L,6L,6L,2L,0L,-6L,-6L,-6L,0L,4L,7L,7L,7L,-1L,-3L,-7L,-7L,-7L,5L,8L,8L,8L,8L,8L,-2L,-8L,-8L,-8L,-8L,-4L,0L,2L,9L,9L,5L,3L,-1L,-9L,-9L,-5L,-3L,1L,7L,10L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214664Inst : IEnumerable<long>
{
public static readonly long[] Value=A214664.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214664.Bytes);
public long this[int i]=>Value[i];

public static A214664Inst Instance=new A214664Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214665
{
public static readonly long[] Value={ 0L,1L,1L,-1L,0L,2L,2L,0L,-2L,1L,3L,3L,-1L,-3L,-3L,0L,4L,4L,2L,-2L,-4L,-4L,-3L,3L,5L,5L,3L,-1L,-3L,-5L,0L,4L,6L,6L,2L,0L,-6L,-6L,-6L,-3L,3L,5L,7L,7L,7L,5L,-7L,-7L,-6L,-4L,0L,6L,8L,8L,8L,2L,-4L,-6L,-8L,-8L,-8L,-5L,9L,9L,9L,9L,3L,-3L,-9L,-9L,-9L,-9L,-4L,2L,8L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214665Inst : IEnumerable<long>
{
public static readonly long[] Value=A214665.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214665.Bytes);
public long this[int i]=>Value[i];

public static A214665Inst Instance=new A214665Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214666
{
public static readonly long[] Value={ -1L,-1L,1L,1L,-2L,-2L,2L,2L,0L,-3L,-3L,3L,3L,3L,-1L,-4L,-2L,0L,4L,4L,4L,-2L,-5L,-5L,1L,5L,5L,5L,5L,3L,-6L,-6L,-2L,0L,6L,6L,6L,0L,-4L,-7L,-7L,-7L,1L,3L,7L,7L,7L,-5L,-8L,-8L,-8L,-8L,-8L,2L,8L,8L,8L,8L,4L,0L,-2L,-9L,-9L,-5L,-3L,1L,9L,9L,5L,3L,-1L,-7L,-10L,-10L,-10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214666Inst : IEnumerable<long>
{
public static readonly long[] Value=A214666.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214666.Bytes);
public long this[int i]=>Value[i];

public static A214666Inst Instance=new A214666Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214667
{
public static readonly long[] Value={ 0L,-1L,-1L,1L,0L,-2L,-2L,0L,2L,-1L,-3L,-3L,1L,3L,3L,0L,-4L,-4L,-2L,2L,4L,4L,3L,-3L,-5L,-5L,-3L,1L,3L,5L,0L,-4L,-6L,-6L,-2L,0L,6L,6L,6L,3L,-3L,-5L,-7L,-7L,-7L,-5L,7L,7L,6L,4L,0L,-6L,-8L,-8L,-8L,-2L,4L,6L,8L,8L,8L,5L,-9L,-9L,-9L,-9L,-3L,3L,9L,9L,9L,9L,4L,-2L,-8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214667Inst : IEnumerable<long>
{
public static readonly long[] Value=A214667.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214667.Bytes);
public long this[int i]=>Value[i];

public static A214667Inst Instance=new A214667Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214668
{
public static readonly BigInteger[] Value={ 1L,9L,108L,1458L,21060L,318087L,4960116L,79227720L,1289516436L,21308126895L,356506456680L,6027199821864L,102804351279084L,1766931074710515L,30570993847594800L,532022685332573016L,9306598678048938420UL,BigInteger.Parse("163549467160708850910"),BigInteger.Parse("2886019647490699098588") };
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
public class A214668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214668Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A214668.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A214668.Bytes);
public BigInteger this[int i]=>Value[i];

public static A214668Inst Instance=new A214668Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214669
{
public static readonly BigInteger[] Value={ 1L,-4L,36L,-720L,29264L,-2370368L,379341376L,-119616350464L,74306729686272L,-91021121260127232L,BigInteger.Parse("220137897341768508416"),BigInteger.Parse("-1052620193410626774192128"),BigInteger.Parse("9963741205378506824566067200"),BigInteger.Parse("-186912918064963001770860269879296"),BigInteger.Parse("6955904583765468148520677987319955456") };
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
public class A214669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214669Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A214669.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A214669.Bytes);
public BigInteger this[int i]=>Value[i];

public static A214669Inst Instance=new A214669Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214670
{
public static readonly long[] Value={ 1L,1L,-1L,-1L,1L,-2L,-1L,4L,4L,1L,1L,-3L,0L,11L,1L,-30L,-42L,-26L,-8L,-1L,1L,-4L,2L,20L,-19L,-100L,3L,403L,808L,861L,584L,262L,76L,13L,1L,1L,-5L,5L,30L,-65L,-191L,378L,1557L,103L,-8551L,-23911L,-37958L,-41831L,-34156L,-21179L,-10015L,-3571L,-933L,-169L,-19L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214670Inst : IEnumerable<long>
{
public static readonly long[] Value=A214670.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214670.Bytes);
public long this[int i]=>Value[i];

public static A214670Inst Instance=new A214670Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214671
{
public static readonly long[] Value={ 0L,2L,4L,6L,8L,10L,11L,13L,15L,17L,19L,21L,22L,24L,26L,28L,30L,31L,33L,35L,37L,39L,41L,42L,44L,46L,48L,50L,52L,53L,55L,57L,59L,61L,63L,64L,66L,68L,70L,72L,74L,75L,77L,79L,81L,83L,85L,86L,88L,90L,92L,94L,95L,97L,99L,101L,103L,105L,106L,108L,110L,112L,114L,116L,117L,119L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214671Inst : IEnumerable<long>
{
public static readonly long[] Value=A214671.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214671.Bytes);
public long this[int i]=>Value[i];

public static A214671Inst Instance=new A214671Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214672
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,3L,3L,4L,4L,5L,5L,6L,7L,7L,8L,8L,9L,9L,10L,10L,11L,12L,12L,13L,13L,14L,14L,15L,15L,16L,17L,17L,18L,18L,19L,19L,20L,21L,21L,22L,22L,23L,23L,24L,24L,25L,26L,26L,27L,27L,28L,28L,29L,29L,30L,31L,31L,32L,32L,33L,33L,34L,35L,35L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214672Inst : IEnumerable<long>
{
public static readonly long[] Value=A214672.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214672.Bytes);
public long this[int i]=>Value[i];

public static A214672Inst Instance=new A214672Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214673
{
public static readonly long[] Value={ 0L,2L,4L,6L,8L,10L,12L,14L,16L,18L,20L,21L,23L,25L,27L,29L,31L,33L,35L,37L,39L,41L,43L,44L,46L,48L,50L,52L,54L,56L,58L,60L,62L,64L,65L,67L,69L,71L,73L,75L,77L,79L,81L,83L,85L,87L,88L,90L,92L,94L,96L,98L,100L,102L,104L,106L,108L,109L,111L,113L,115L,117L,119L,121L,123L,125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214673Inst : IEnumerable<long>
{
public static readonly long[] Value=A214673.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214673.Bytes);
public long this[int i]=>Value[i];

public static A214673Inst Instance=new A214673Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214674
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,4L,3L,7L,5L,6L,11L,17L,14L,31L,15L,23L,19L,21L,20L,41L,61L,51L,56L,107L,163L,135L,149L,142L,97L,239L,168L,37L,41L,39L,40L,79L,17L,48L,13L,61L,37L,49L,43L,46L,89L,45L,67L,56L,41L,97L,69L,83L,76L,53L,43L,48L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214674Inst : IEnumerable<long>
{
public static readonly long[] Value=A214674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214674.Bytes);
public long this[int i]=>Value[i];

public static A214674Inst Instance=new A214674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214675
{
public static readonly long[] Value={ 1L,15L,47L,97L,165L,251L,355L,477L,617L,775L,951L,1145L,1357L,1587L,1835L,2101L,2385L,2687L,3007L,3345L,3701L,4075L,4467L,4877L,5305L,5751L,6215L,6697L,7197L,7715L,8251L,8805L,9377L,9967L,10575L,11201L,11845L,12507L,13187L,13885L,14601L,15335L,16087L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214675Inst : IEnumerable<long>
{
public static readonly long[] Value=A214675.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214675.Bytes);
public long this[int i]=>Value[i];

public static A214675Inst Instance=new A214675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214676
{
public static readonly long[] Value={ 1L,1L,11L,1L,2L,111L,1L,2L,11L,1111L,1L,2L,3L,12L,11111L,1L,2L,3L,11L,21L,111111L,1L,2L,3L,4L,12L,22L,1111111L,1L,2L,3L,4L,11L,13L,111L,11111111L,1L,2L,3L,4L,5L,12L,21L,112L,111111111L,1L,2L,3L,4L,5L,11L,13L,22L,121L,1111111111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214676Inst : IEnumerable<long>
{
public static readonly long[] Value=A214676.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214676.Bytes);
public long this[int i]=>Value[i];

public static A214676Inst Instance=new A214676Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214677
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,11L,12L,13L,14L,15L,16L,17L,21L,22L,23L,24L,25L,26L,27L,31L,32L,33L,34L,35L,36L,37L,41L,42L,43L,44L,45L,46L,47L,51L,52L,53L,54L,55L,56L,57L,61L,62L,63L,64L,65L,66L,67L,71L,72L,73L,74L,75L,76L,77L,111L,112L,113L,114L,115L,116L,117L,121L,122L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214677Inst : IEnumerable<long>
{
public static readonly long[] Value=A214677.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214677.Bytes);
public long this[int i]=>Value[i];

public static A214677Inst Instance=new A214677Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214678
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,11L,12L,13L,14L,15L,16L,17L,18L,21L,22L,23L,24L,25L,26L,27L,28L,31L,32L,33L,34L,35L,36L,37L,38L,41L,42L,43L,44L,45L,46L,47L,48L,51L,52L,53L,54L,55L,56L,57L,58L,61L,62L,63L,64L,65L,66L,67L,68L,71L,72L,73L,74L,75L,76L,77L,78L,81L,82L,83L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214678Inst : IEnumerable<long>
{
public static readonly long[] Value=A214678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214678.Bytes);
public long this[int i]=>Value[i];

public static A214678Inst Instance=new A214678Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214679
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1L,1L,11L,1L,1L,2L,111L,1L,1L,2L,11L,11111L,1L,1L,2L,3L,21L,11111111L,1L,1L,2L,3L,12L,112L,1111111111111L,1L,1L,2L,3L,11L,22L,221L,BigInteger.Parse("111111111111111111111"),1L,1L,2L,3L,5L,14L,111L,1221L,BigInteger.Parse("1111111111111111111111111111111111") };
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
public class A214679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214679Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A214679.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A214679.Bytes);
public BigInteger this[int i]=>Value[i];

public static A214679Inst Instance=new A214679Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214680
{
public static readonly long[] Value={ 3L,5L,7L,23L,71L,73L,367L,1103L,7723L,131293L,3807499L,19037497L,57112493L,1427812327L,15705935599L,141353420393L,989473942753L,44526327423887L,311684291967211L,4675264379508167L,4675264379508169L,275840598390981973L,4137608975864729597L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214680Inst : IEnumerable<long>
{
public static readonly long[] Value=A214680.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214680.Bytes);
public long this[int i]=>Value[i];

public static A214680Inst Instance=new A214680Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214681
{
public static readonly long[] Value={ 1L,1L,1L,1L,5L,6L,7L,1L,1L,5L,11L,6L,13L,7L,5L,1L,17L,6L,19L,5L,7L,11L,23L,6L,25L,13L,1L,7L,29L,30L,31L,1L,11L,17L,35L,36L,37L,19L,13L,5L,41L,42L,43L,11L,5L,23L,47L,6L,49L,25L,17L,13L,53L,6L,55L,7L,19L,29L,59L,30L,61L,31L,7L,1L,65L,66L,67L,17L,23L,35L,71L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214681Inst : IEnumerable<long>
{
public static readonly long[] Value=A214681.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214681.Bytes);
public long this[int i]=>Value[i];

public static A214681Inst Instance=new A214681Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214682
{
public static readonly long[] Value={ 1L,1L,3L,4L,5L,3L,7L,4L,9L,5L,11L,12L,13L,7L,15L,16L,17L,9L,19L,20L,21L,11L,23L,12L,25L,13L,27L,28L,29L,15L,31L,16L,33L,17L,35L,36L,37L,19L,39L,20L,41L,21L,43L,44L,45L,23L,47L,48L,49L,25L,51L,52L,53L,27L,55L,28L,57L,29L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214682Inst : IEnumerable<long>
{
public static readonly long[] Value=A214682.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214682.Bytes);
public long this[int i]=>Value[i];

public static A214682Inst Instance=new A214682Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214683
{
public static readonly long[] Value={ -1L,0L,-3L,2L,-8L,9L,-23L,33L,-70L,113L,-220L,376L,-703L,1235L,-2265L,4032L,-7327L,13126L,-23748L,42673L,-77043L,138641L,-250054L,450293L,-811760L,1462292L,-2635519L,4748343L,-8557089L,15418256L,-27784091L,50063514L,-90213440L,162556377L,-292919743L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214683Inst : IEnumerable<long>
{
public static readonly long[] Value=A214683.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214683.Bytes);
public long this[int i]=>Value[i];

public static A214683Inst Instance=new A214683Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214684
{
public static readonly long[] Value={ 1L,1L,2L,3L,1L,4L,1L,1L,2L,3L,1L,4L,1L,1L,2L,3L,1L,4L,1L,1L,2L,3L,1L,4L,1L,1L,2L,3L,1L,4L,1L,1L,2L,3L,1L,4L,1L,1L,2L,3L,1L,4L,1L,1L,2L,3L,1L,4L,1L,1L,2L,3L,1L,4L,1L,1L,2L,3L,1L,4L,1L,1L,2L,3L,1L,4L,1L,1L,2L,3L,1L,4L,1L,1L,2L,3L,1L,4L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214684Inst : IEnumerable<long>
{
public static readonly long[] Value=A214684.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214684.Bytes);
public long this[int i]=>Value[i];

public static A214684Inst Instance=new A214684Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214685
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,7L,1L,1L,1L,11L,1L,13L,7L,1L,1L,17L,1L,19L,1L,7L,11L,23L,1L,1L,13L,1L,7L,29L,30L,31L,1L,11L,17L,7L,1L,37L,19L,13L,1L,41L,7L,43L,11L,1L,23L,47L,1L,49L,1L,17L,13L,53L,1L,11L,7L,19L,29L,59L,30L,61L,31L,7L,1L,13L,11L,67L,17L,23L,7L,71L,1L,73L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214685Inst : IEnumerable<long>
{
public static readonly long[] Value=A214685.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214685.Bytes);
public long this[int i]=>Value[i];

public static A214685Inst Instance=new A214685Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214686
{
public static readonly long[] Value={ 1L,1L,7L,1L,23L,1L,47L,1L,79L,1L,113L,89L,23L,73L,31L,1L,283L,89L,113L,139L,173L,67L,47L,1L,619L,131L,109L,83L,113L,211L,191L,1L,1087L,1L,1223L,1L,1367L,1L,1511L,367L,83L,1L,1847L,1L,2017L,317L,571L,241L,199L,1L,2593L,367L,211L,271L,223L,1L,3229L,1117L,239L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214686Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214686.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214686Inst : IEnumerable<long>
{
public static readonly long[] Value=A214686.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214686.Bytes);
public long this[int i]=>Value[i];

public static A214686Inst Instance=new A214686Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214687
{
public static readonly BigInteger[] Value={ 1L,1L,11L,217L,7691L,430921L,35117531L,3927676537L,577640740331L,108115035641641L,25097054302205051L,7076531411753120857L,BigInteger.Parse("2382432541064412524171"),BigInteger.Parse("943997056642739165681161"),BigInteger.Parse("434864796716131476530668571"),BigInteger.Parse("230460477665217932140097413177") };
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
public class A214687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214687Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A214687.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A214687.Bytes);
public BigInteger this[int i]=>Value[i];

public static A214687Inst Instance=new A214687Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214688
{
public static readonly BigInteger[] Value={ 1L,2L,24L,408L,9760L,299520L,11223744L,496802432L,25365482496L,1467480983040L,94873742909440L,6778628603670528L,530412734126346240L,BigInteger.Parse("45110083291805622272"),BigInteger.Parse("4143219058165730672640"),BigInteger.Parse("408715543077297795072000"),BigInteger.Parse("43097868598208296895512576"),BigInteger.Parse("4837629293480336802779234304") };
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
public class A214688Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214688.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214688Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A214688.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A214688.Bytes);
public BigInteger this[int i]=>Value[i];

public static A214688Inst Instance=new A214688Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214689
{
public static readonly BigInteger[] Value={ 1L,2L,8L,80L,1360L,32352L,989824L,37019264L,1636370432L,83464921088L,4825001503744L,311748850464768L,22263047494942720L,1741317007049007104L,BigInteger.Parse("148042703132414148608"),BigInteger.Parse("13593236125606306316288"),BigInteger.Parse("1340587859012582977110016"),BigInteger.Parse("141329649926949217139294208") };
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
public class A214689Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214689.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214689Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A214689.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A214689.Bytes);
public BigInteger this[int i]=>Value[i];

public static A214689Inst Instance=new A214689Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214690
{
public static readonly long[] Value={ 1L,1L,-2L,-3L,-1L,1L,-4L,-2L,22L,49L,49L,27L,8L,1L,1L,-6L,3L,61L,15L,-567L,-1946L,-3607L,-4489L,-4015L,-2640L,-1274L,-441L,-104L,-15L,-1L,1L,-8L,12L,108L,-218L,-1938L,-834L,27124L,136919L,393601L,809873L,1288950L,1646268L,1720788L,1487263L,1067345L,635682L,312646L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214690Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214690.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214690Inst : IEnumerable<long>
{
public static readonly long[] Value=A214690.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214690.Bytes);
public long this[int i]=>Value[i];

public static A214690Inst Instance=new A214690Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214691
{
public static readonly BigInteger[] Value={ 1L,1L,5L,151L,19025L,9702751L,19851828545L,162586475783551L,5327308465523832065L,BigInteger.Parse("698250320576208668759551"),BigInteger.Parse("366082867573618138109269955585"),BigInteger.Parse("767730685732013278335855487355082751"),BigInteger.Parse("6440190236715680978727827356359771295535105") };
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
public class A214691Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214691.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214691Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A214691.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A214691.Bytes);
public BigInteger this[int i]=>Value[i];

public static A214691Inst Instance=new A214691Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214692
{
public static readonly ulong[] Value={ 1L,1L,2L,11L,71L,515L,3997L,32488L,273009L,2352724L,20678966L,184660333L,1670619561L,15279692008L,141048655988L,1312429249996L,12296515232446L,115909188223053L,1098444610424929L,10459429664510189L,100021237512559055L,960168745226226195L,9249466125601138425UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214692Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214692.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214692Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A214692.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214692.Bytes);
public ulong this[int i]=>Value[i];

public static A214692Inst Instance=new A214692Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214693
{
public static readonly BigInteger[] Value={ 1L,1L,4L,34L,338L,3691L,42623L,510949L,6289912L,78972928L,1006665781L,12985611054L,169115724583L,2219614920740L,29318819296959L,389331204757856L,5192978617937181L,69522908878900079L,933674035184058960L,12571898958515379108UL,BigInteger.Parse("169651868248129552194") };
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
public class A214693Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214693.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214693Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A214693.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A214693.Bytes);
public BigInteger this[int i]=>Value[i];

public static A214693Inst Instance=new A214693Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214694
{
public static readonly BigInteger[] Value={ 1L,1L,6L,69L,929L,13692L,213402L,3456450L,57585400L,980408857L,16982002433L,298322996205L,5302587890821L,95196447689434L,1723782813066284L,31447947375375315L,577509675356805547L,10667460556561578780UL,BigInteger.Parse("198074286156460874227"),BigInteger.Parse("3695152948440645726312") };
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
public class A214694Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214694.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214694Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A214694.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A214694.Bytes);
public BigInteger this[int i]=>Value[i];

public static A214694Inst Instance=new A214694Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214695
{
public static readonly BigInteger[] Value={ 1L,1L,8L,116L,1972L,36682L,722098L,14784834L,311629580L,6716892893L,147372681787L,3280609461927L,73912217824094L,1682234535898788L,38621258859241912L,893358073179541313L,BigInteger.Parse("20800314016777824187"),BigInteger.Parse("487100732909778007223"),BigInteger.Parse("11465386711990265812207") };
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
public class A214695Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214695.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214695Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A214695.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A214695.Bytes);
public BigInteger this[int i]=>Value[i];

public static A214695Inst Instance=new A214695Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214696
{
public static readonly long[] Value={ 3L,7L,13L,17L,4919L,73789919L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214696Inst : IEnumerable<long>
{
public static readonly long[] Value=A214696.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214696.Bytes);
public long this[int i]=>Value[i];

public static A214696Inst Instance=new A214696Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214697
{
public static readonly long[] Value={ 2L,3L,5L,17L,7L,2L,89L,125L,3L,215L,269L,13L,10L,8L,11L,27L,719L,815L,21L,57L,316L,11L,26L,1517L,17L,1799L,30L,26L,7L,5L,2609L,11L,2975L,10L,2L,76L,3779L,1251L,208L,4445L,115L,4919L,1045L,5417L,11L,17L,1205L,6485L,38L,2860L,7349L,18L,25L,8267L,8585L,8909L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214697Inst : IEnumerable<long>
{
public static readonly long[] Value=A214697.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214697.Bytes);
public long this[int i]=>Value[i];

public static A214697Inst Instance=new A214697Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214698
{
public static readonly BigInteger[] Value={ 0L,0L,9L,120L,1550L,23310L,411747L,8388576L,193710204L,4999999950L,142655835245L,4458050224056L,151437553296042L,5556003412778910L,218946945190429575L,9223372036854775680L,BigInteger.Parse("413620130943168381944"),BigInteger.Parse("19673204037648268787550"),BigInteger.Parse("989209827830156794561809"),BigInteger.Parse("52428799999999999999999800") };
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
public class A214698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214698Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A214698.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A214698.Bytes);
public BigInteger this[int i]=>Value[i];

public static A214698Inst Instance=new A214698Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214699
{
public static readonly long[] Value={ 0L,3L,0L,9L,-3L,27L,-18L,84L,-81L,270L,-327L,891L,-1251L,3000L,-4644L,10251L,-16932L,35397L,-61047L,123123L,-218538L,430416L,-778737L,1509786L,-2766627L,5308095L,-9809667L,18690912L,-34737096L,65882403L,-122902200L,232384305L,-434589003L,820055115L,-1536151314L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214699Inst : IEnumerable<long>
{
public static readonly long[] Value=A214699.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214699.Bytes);
public long this[int i]=>Value[i];

public static A214699Inst Instance=new A214699Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214700
{
public static readonly long[] Value={ 1L,2L,3L,4L,8L,21L,22L,31L,45L,86L,99L,127L,239L,264L,332L,338L,752L,793L,2310L,4364L,7454L,14788L,20031L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214700Inst : IEnumerable<long>
{
public static readonly long[] Value=A214700.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214700.Bytes);
public long this[int i]=>Value[i];

public static A214700Inst Instance=new A214700Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214701
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214701Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214701.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214701Inst : IEnumerable<long>
{
public static readonly long[] Value=A214701.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214701.Bytes);
public long this[int i]=>Value[i];

public static A214701Inst Instance=new A214701Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214702
{
public static readonly long[] Value={ 100333331003L,100388881003L,100733331007L,100766661007L,100999991009L,101333331013L,101377771013L,101755551017L,102155551021L,102722221027L,102733331027L,102922221029L,102944441029L,103133331031L,103177771031L,103199991031L,103322221033L,103366661033L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214702Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214702.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214702Inst : IEnumerable<long>
{
public static readonly long[] Value=A214702.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214702.Bytes);
public long this[int i]=>Value[i];

public static A214702Inst Instance=new A214702Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214703
{
public static readonly long[] Value={ 2L,3L,5L,23L,53L,223L,233L,353L,523L,2333L,3253L,3323L,3533L,5233L,5323L,5333L,23333L,25253L,25523L,32233L,32323L,32353L,32533L,33223L,33353L,33533L,35323L,35353L,35533L,52223L,52253L,52553L,53233L,53323L,53353L,55333L,222323L,222533L,222553L,223253L,225223L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214703Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214703.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214703Inst : IEnumerable<long>
{
public static readonly long[] Value=A214703.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214703.Bytes);
public long this[int i]=>Value[i];

public static A214703Inst Instance=new A214703Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214704
{
public static readonly long[] Value={ 2L,3L,7L,23L,37L,73L,223L,227L,233L,277L,337L,373L,727L,733L,773L,2237L,2273L,2333L,2377L,2777L,3323L,3373L,3727L,3733L,7237L,7333L,7723L,7727L,22273L,22277L,22727L,22777L,23227L,23327L,23333L,23773L,27277L,27337L,27733L,27737L,27773L,32233L,32237L,32323L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214704Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214704.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214704Inst : IEnumerable<long>
{
public static readonly long[] Value=A214704.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214704.Bytes);
public long this[int i]=>Value[i];

public static A214704Inst Instance=new A214704Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214705
{
public static readonly long[] Value={ 2L,5L,7L,227L,257L,277L,557L,577L,727L,757L,2557L,2777L,5227L,5527L,5557L,7577L,7727L,7757L,22277L,22727L,22777L,25577L,27277L,27527L,52727L,52757L,57527L,57557L,57727L,72227L,72277L,72577L,72727L,75227L,75277L,75527L,75557L,75577L,77527L,77557L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214705Inst : IEnumerable<long>
{
public static readonly long[] Value=A214705.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214705.Bytes);
public long this[int i]=>Value[i];

public static A214705Inst Instance=new A214705Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214706
{
public static readonly BigInteger[] Value={ 1L,5L,5L,25L,125L,3125L,390625L,1220703125L,476837158203125L,BigInteger.Parse("582076609134674072265625"),BigInteger.Parse("277555756156289135105907917022705078125"),BigInteger.Parse("161558713389263217748322010169914619837072677910327911376953125") };
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
public class A214706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214706Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A214706.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A214706.Bytes);
public BigInteger this[int i]=>Value[i];

public static A214706Inst Instance=new A214706Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214707
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,2L,1L,3L,1L,2L,2L,2L,1L,1L,2L,2L,1L,2L,1L,3L,1L,2L,2L,2L,2L,1L,1L,2L,2L,2L,1L,3L,2L,1L,2L,2L,1L,1L,1L,2L,2L,2L,2L,3L,2L,2L,1L,2L,1L,3L,1L,2L,2L,2L,2L,3L,1L,2L,1L,2L,1L,1L,1L,2L,2L,2L,1L,3L,2L,2L,1L,2L,1L,1L,2L,2L,2L,2L,1L,3L,1L,2L,2L,2L,2L,3L,2L,2L,2L,2L,1L,3L,1L,1L,2L,2L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214707Inst : IEnumerable<long>
{
public static readonly long[] Value=A214707.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214707.Bytes);
public long this[int i]=>Value[i];

public static A214707Inst Instance=new A214707Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214708
{
public static readonly long[] Value={ 1L,2L,1L,2L,2L,2L,1L,2L,2L,2L,1L,2L,1L,2L,2L,2L,1L,2L,1L,2L,1L,2L,1L,2L,2L,2L,2L,2L,2L,2L,1L,2L,1L,2L,2L,2L,1L,2L,2L,2L,1L,2L,1L,2L,2L,2L,1L,2L,1L,2L,1L,2L,1L,2L,2L,2L,1L,2L,1L,2L,1L,2L,2L,2L,2L,2L,1L,2L,2L,2L,1L,2L,1L,2L,2L,2L,1L,2L,1L,2L,2L,2L,1L,2L,2L,2L,2L,2L,2L,2L,1L,2L,1L,2L,2L,2L,1L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214708Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214708.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214708Inst : IEnumerable<long>
{
public static readonly long[] Value=A214708.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214708.Bytes);
public long this[int i]=>Value[i];

public static A214708Inst Instance=new A214708Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214709
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,3L,1L,1L,1L,3L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,3L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,3L,1L,1L,1L,1L,1L,1L,1L,3L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214709Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214709.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214709Inst : IEnumerable<long>
{
public static readonly long[] Value=A214709.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214709.Bytes);
public long this[int i]=>Value[i];

public static A214709Inst Instance=new A214709Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214710
{
public static readonly long[] Value={ 2L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214710Inst : IEnumerable<long>
{
public static readonly long[] Value=A214710.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214710.Bytes);
public long this[int i]=>Value[i];

public static A214710Inst Instance=new A214710Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214711
{
public static readonly long[] Value={ 1L,5L,45L,57L,77L,81L,101L,105L,125L,137L,189L,197L,209L,249L,261L,281L,305L,329L,365L,377L,381L,429L,465L,477L,497L,501L,545L,585L,597L,605L,629L,641L,657L,725L,741L,809L,821L,825L,837L,857L,861L,881L,885L,905L,969L,989L,1049L,1085L,1149L,1161L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214711Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214711.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214711Inst : IEnumerable<long>
{
public static readonly long[] Value=A214711.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214711.Bytes);
public long this[int i]=>Value[i];

public static A214711Inst Instance=new A214711Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214712
{
public static readonly long[] Value={ 2L,1L,1L,1L,4L,1L,2L,1L,1L,2L,4L,5L,4L,1L,2L,1L,4L,1L,2L,2L,3L,2L,2L,1L,2L,1L,2L,1L,6L,3L,6L,2L,1L,2L,4L,1L,4L,1L,1L,2L,2L,3L,4L,1L,1L,1L,2L,1L,2L,2L,1L,2L,4L,1L,2L,1L,1L,2L,4L,7L,4L,4L,1L,1L,2L,1L,2L,1L,1L,2L,2L,5L,6L,1L,2L,1L,4L,1L,2L,2L,3L,2L,4L,1L,2L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214712Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214712.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214712Inst : IEnumerable<long>
{
public static readonly long[] Value=A214712.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214712.Bytes);
public long this[int i]=>Value[i];

public static A214712Inst Instance=new A214712Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214713
{
public static readonly long[] Value={ 2L,1L,2L,1L,1L,1L,2L,1L,2L,1L,1L,1L,2L,1L,2L,2L,1L,1L,2L,1L,2L,3L,1L,1L,2L,1L,2L,1L,1L,1L,2L,1L,2L,1L,1L,1L,2L,1L,2L,2L,2L,1L,2L,1L,2L,3L,1L,1L,2L,1L,2L,1L,1L,1L,2L,1L,2L,1L,1L,1L,2L,1L,2L,2L,1L,1L,2L,1L,2L,2L,1L,1L,2L,1L,2L,1L,1L,2L,2L,1L,2L,1L,1L,1L,2L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214713Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214713.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214713Inst : IEnumerable<long>
{
public static readonly long[] Value=A214713.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214713.Bytes);
public long this[int i]=>Value[i];

public static A214713Inst Instance=new A214713Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214714
{
public static readonly long[] Value={ 1L,1L,2L,2L,4L,1L,4L,1L,4L,1L,2L,1L,2L,1L,2L,1L,4L,1L,2L,1L,2L,2L,4L,1L,2L,3L,2L,1L,2L,1L,2L,1L,2L,2L,4L,2L,6L,1L,2L,1L,4L,1L,2L,1L,2L,2L,2L,1L,2L,1L,4L,2L,2L,1L,2L,1L,2L,2L,2L,1L,2L,1L,4L,1L,2L,1L,2L,1L,2L,2L,4L,1L,2L,1L,2L,1L,4L,2L,4L,1L,2L,2L,4L,1L,2L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214714Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214714.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214714Inst : IEnumerable<long>
{
public static readonly long[] Value=A214714.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214714.Bytes);
public long this[int i]=>Value[i];

public static A214714Inst Instance=new A214714Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214715
{
public static readonly long[] Value={ 2L,1L,2L,1L,2L,1L,2L,1L,2L,2L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,4L,1L,2L,1L,4L,2L,4L,1L,2L,1L,2L,1L,2L,1L,6L,1L,2L,1L,2L,1L,2L,1L,2L,3L,2L,1L,2L,1L,2L,2L,4L,1L,2L,1L,2L,2L,4L,1L,2L,1L,2L,2L,4L,2L,6L,1L,2L,1L,4L,1L,2L,1L,2L,1L,4L,1L,6L,1L,2L,1L,2L,1L,2L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214715Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214715.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214715Inst : IEnumerable<long>
{
public static readonly long[] Value=A214715.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214715.Bytes);
public long this[int i]=>Value[i];

public static A214715Inst Instance=new A214715Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214716
{
public static readonly long[] Value={ 2L,1L,2L,1L,2L,1L,4L,1L,2L,1L,2L,1L,2L,1L,2L,2L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,4L,1L,2L,1L,2L,1L,2L,1L,2L,2L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,4L,1L,2L,1L,2L,1L,2L,1L,2L,2L,2L,1L,2L,1L,2L,1L,2L,1L,2L,2L,4L,1L,2L,1L,2L,1L,2L,1L,2L,2L,2L,2L,2L,1L,2L,1L,2L,1L,2L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214716Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214716.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214716Inst : IEnumerable<long>
{
public static readonly long[] Value=A214716.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214716.Bytes);
public long this[int i]=>Value[i];

public static A214716Inst Instance=new A214716Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214717
{
public static readonly long[] Value={ 2L,1L,1L,3L,1L,3L,2L,1L,1L,3L,1L,1L,2L,1L,2L,3L,1L,1L,2L,1L,1L,3L,1L,1L,2L,5L,1L,3L,1L,1L,2L,1L,1L,3L,1L,3L,2L,1L,1L,3L,1L,1L,2L,1L,2L,3L,1L,1L,2L,1L,1L,3L,1L,1L,2L,3L,2L,3L,1L,1L,2L,1L,1L,3L,1L,3L,2L,1L,1L,3L,1L,1L,2L,1L,1L,3L,1L,3L,2L,1L,1L,3L,1L,1L,2L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214717Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214717.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214717Inst : IEnumerable<long>
{
public static readonly long[] Value=A214717.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214717.Bytes);
public long this[int i]=>Value[i];

public static A214717Inst Instance=new A214717Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214718
{
public static readonly long[] Value={ 2L,1L,2L,2L,4L,1L,2L,1L,2L,2L,4L,1L,2L,1L,2L,3L,4L,1L,2L,1L,2L,2L,4L,1L,2L,1L,2L,2L,4L,1L,2L,1L,2L,2L,4L,2L,2L,1L,2L,2L,4L,1L,4L,1L,2L,2L,4L,1L,2L,1L,2L,2L,4L,1L,2L,1L,2L,3L,4L,1L,2L,1L,2L,2L,4L,1L,2L,1L,2L,3L,4L,1L,2L,1L,2L,2L,4L,2L,2L,1L,2L,2L,4L,1L,2L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214718Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214718.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214718Inst : IEnumerable<long>
{
public static readonly long[] Value=A214718.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214718.Bytes);
public long this[int i]=>Value[i];

public static A214718Inst Instance=new A214718Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214719
{
public static readonly long[] Value={ 2L,1L,1L,1L,1L,5L,1L,3L,1L,1L,2L,1L,1L,1L,1L,3L,1L,1L,1L,1L,2L,3L,1L,1L,1L,3L,1L,1L,1L,1L,2L,1L,1L,1L,1L,5L,1L,1L,1L,1L,3L,1L,1L,1L,1L,3L,1L,1L,1L,3L,2L,1L,1L,1L,1L,3L,1L,1L,1L,1L,2L,1L,1L,3L,1L,5L,1L,1L,1L,1L,3L,1L,1L,1L,1L,3L,1L,5L,1L,1L,2L,1L,1L,1L,1L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214719Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214719.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214719Inst : IEnumerable<long>
{
public static readonly long[] Value=A214719.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214719.Bytes);
public long this[int i]=>Value[i];

public static A214719Inst Instance=new A214719Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214720
{
public static readonly long[] Value={ 2L,1L,2L,3L,2L,5L,2L,3L,2L,3L,2L,5L,2L,3L,2L,3L,2L,5L,2L,3L,2L,3L,2L,5L,2L,3L,2L,3L,2L,7L,2L,3L,2L,3L,2L,5L,2L,3L,2L,3L,2L,5L,2L,3L,2L,3L,2L,5L,2L,3L,2L,3L,2L,5L,2L,3L,2L,3L,2L,7L,2L,3L,2L,3L,2L,5L,2L,3L,2L,3L,2L,5L,2L,3L,2L,3L,2L,5L,2L,3L,2L,3L,2L,5L,2L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214720Inst : IEnumerable<long>
{
public static readonly long[] Value=A214720.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214720.Bytes);
public long this[int i]=>Value[i];

public static A214720Inst Instance=new A214720Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214721
{
public static readonly long[] Value={ 1L,2L,1L,4L,1L,6L,1L,3L,1L,10L,1L,12L,1L,14L,1L,2L,1L,3L,1L,20L,1L,22L,1L,24L,1L,26L,1L,3L,1L,2L,1L,32L,1L,34L,1L,36L,1L,3L,1L,7L,1L,42L,1L,2L,1L,46L,1L,3L,1L,50L,1L,52L,1L,54L,1L,4L,1L,2L,1L,60L,1L,7L,1L,64L,1L,66L,1L,3L,1L,70L,1L,2L,1L,74L,1L,76L,1L,3L,1L,80L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214721Inst : IEnumerable<long>
{
public static readonly long[] Value=A214721.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214721.Bytes);
public long this[int i]=>Value[i];

public static A214721Inst Instance=new A214721Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214722
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,1L,3L,16L,5L,1L,4L,91L,192L,14L,1L,5L,456L,5471L,2816L,42L,1L,6L,2145L,143164L,464836L,46592L,132L,1L,7L,9724L,3636776L,75965484L,48767805L,835584L,429L,1L,8L,43043L,91442364L,12753712037L,55824699632L,5900575762L,15876096L,1430L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214722Inst : IEnumerable<long>
{
public static readonly long[] Value=A214722.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214722.Bytes);
public long this[int i]=>Value[i];

public static A214722Inst Instance=new A214722Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214723
{
public static readonly long[] Value={ 8L,13L,18L,29L,34L,50L,53L,58L,74L,98L,125L,130L,146L,170L,173L,178L,194L,218L,242L,290L,293L,298L,314L,365L,370L,386L,458L,482L,530L,533L,538L,554L,698L,722L,818L,845L,850L,866L,962L,965L,970L,986L,1058L,1082L,1202L,1250L,1322L,1370L,1373L,1378L,1394L,1418L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214723Inst : IEnumerable<long>
{
public static readonly long[] Value=A214723.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214723.Bytes);
public long this[int i]=>Value[i];

public static A214723Inst Instance=new A214723Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214724
{
public static readonly BigInteger[] Value={ 1L,1L,2L,4L,10L,50L,220L,1240L,6140L,32860L,602200L,5668400L,62030200L,522328600L,4487190800L,62591332000L,715163146000L,30496564010000L,482341877812000L,8342949421288000L,124613700640580000L,1733826182453140000L,BigInteger.Parse("36635355834463000000"),BigInteger.Parse("597186420007933040000") };
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
public class A214724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214724Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A214724.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A214724.Bytes);
public BigInteger this[int i]=>Value[i];

public static A214724Inst Instance=new A214724Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214725
{
public static readonly long[] Value={ 0L,8L,35L,72L,133L,189L,216L,224L,280L,376L,411L,496L,533L,472L,568L,624L,712L,720L,784L,783L,908L,946L,992L,945L,1062L,1072L,1081L,1107L,1153L,1161L,1224L,1288L,1376L,1377L,1449L,1459L,1547L,1496L,1504L,1593L,1592L,1712L,1719L,1648L,1783L,1800L,1837L,1864L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214725Inst : IEnumerable<long>
{
public static readonly long[] Value=A214725.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214725.Bytes);
public long this[int i]=>Value[i];

public static A214725Inst Instance=new A214725Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214726
{
public static readonly long[] Value={ 3L,8L,6L,3L,7L,0L,3L,3L,0L,5L,1L,5L,6L,2L,7L,3L,1L,4L,6L,9L,9L,8L,9L,7L,2L,7L,9L,8L,9L,1L,5L,5L,8L,9L,4L,7L,0L,5L,3L,5L,6L,1L,9L,3L,5L,6L,0L,3L,3L,6L,1L,8L,2L,0L,1L,6L,0L,9L,3L,7L,2L,3L,0L,5L,2L,4L,1L,6L,9L,2L,8L,5L,5L,9L,1L,9L,4L,2L,2L,0L,6L,5L,3L,9L,0L,2L,4L,6L,9L,6L,7L,4L,3L,2L,2L,8L,1L,8L,0L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214726Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214726.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214726Inst : IEnumerable<long>
{
public static readonly long[] Value=A214726.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214726.Bytes);
public long this[int i]=>Value[i];

public static A214726Inst Instance=new A214726Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214727
{
public static readonly long[] Value={ 1L,2L,2L,5L,9L,16L,30L,55L,101L,186L,342L,629L,1157L,2128L,3914L,7199L,13241L,24354L,44794L,82389L,151537L,278720L,512646L,942903L,1734269L,3189818L,5866990L,10791077L,19847885L,36505952L,67144914L,123498751L,227149617L,417793282L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214727Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214727.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214727Inst : IEnumerable<long>
{
public static readonly long[] Value=A214727.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214727.Bytes);
public long this[int i]=>Value[i];

public static A214727Inst Instance=new A214727Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214728
{
public static readonly long[] Value={ 1L,1L,3L,5L,1L,9L,11L,13L,15L,1L,19L,3L,2L,25L,27L,29L,1L,33L,5L,37L,39L,8L,43L,45L,2L,1L,3L,53L,55L,57L,59L,61L,9L,65L,67L,6L,1L,8L,75L,11L,2L,81L,83L,5L,87L,9L,13L,3L,95L,1L,99L,101L,18L,15L,107L,109L,111L,8L,10L,117L,2L,121L,24L,125L,1L,129L,131L,19L,135L,25L,139L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214728Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214728.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214728Inst : IEnumerable<long>
{
public static readonly long[] Value=A214728.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214728.Bytes);
public long this[int i]=>Value[i];

public static A214728Inst Instance=new A214728Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214729
{
public static readonly long[] Value={ 0L,13L,34L,102L,267L,712L,1864L,4893L,12810L,33550L,87835L,229968L,602064L,1576237L,4126642L,10803702L,28284459L,74049688L,193864600L,507544125L,1328767770L,3478759198L,9107509819L,23843770272L,62423800992L,163427632717L,427859097154L,1120149658758L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214729Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214729.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214729Inst : IEnumerable<long>
{
public static readonly long[] Value=A214729.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214729.Bytes);
public long this[int i]=>Value[i];

public static A214729Inst Instance=new A214729Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214730
{
public static readonly long[] Value={ 3L,3L,3L,3L,13L,19L,43L,3L,61L,13L,29L,11L,5L,53L,73L,53L,23L,17L,229L,13L,3L,3L,17L,149L,5L,239L,5L,13L,223L,71L,3L,11L,31L,73L,97L,43L,11L,83L,149L,277L,311L,383L,127L,11L,3L,31L,233L,61L,61L,13L,73L,107L,613L,137L,53L,367L,467L,53L,233L,277L,17L,53L,109L,449L,151L,97L,13L,281L,103L,233L,193L,23L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214730Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214730.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214730Inst : IEnumerable<long>
{
public static readonly long[] Value=A214730.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214730.Bytes);
public long this[int i]=>Value[i];

public static A214730Inst Instance=new A214730Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214731
{
public static readonly long[] Value={ -2L,-1L,8L,31L,74L,143L,244L,383L,566L,799L,1088L,1439L,1858L,2351L,2924L,3583L,4334L,5183L,6136L,7199L,8378L,9679L,11108L,12671L,14374L,16223L,18224L,20383L,22706L,25199L,27868L,30719L,33758L,36991L,40424L,44063L,47914L,51983L,56276L,60799L,65558L,70559L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214731Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214731.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214731Inst : IEnumerable<long>
{
public static readonly long[] Value=A214731.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214731.Bytes);
public long this[int i]=>Value[i];

public static A214731Inst Instance=new A214731Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214732
{
public static readonly long[] Value={ 1021L,1061L,1151L,1291L,1481L,1721L,2011L,2351L,2741L,3181L,3671L,4211L,4801L,5441L,6131L,6871L,7661L,8501L,9391L,10331L,11321L,12361L,13451L,14591L,15781L,17021L,18311L,19651L,21041L,22481L,23971L,25511L,27101L,28741L,30431L,32171L,33961L,35801L,37691L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214732Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214732.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214732Inst : IEnumerable<long>
{
public static readonly long[] Value=A214732.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214732.Bytes);
public long this[int i]=>Value[i];

public static A214732Inst Instance=new A214732Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214733
{
public static readonly long[] Value={ 0L,1L,-1L,-2L,5L,1L,-16L,13L,35L,-74L,-31L,253L,-160L,-599L,1079L,718L,-3955L,1801L,10064L,-15467L,-14725L,61126L,-16951L,-166427L,217280L,282001L,-933841L,87838L,2713685L,-2977199L,-5163856L,14095453L,1396115L,-43682474L,39494129L,91553293L,-210035680L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214733Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214733.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214733Inst : IEnumerable<long>
{
public static readonly long[] Value=A214733.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214733.Bytes);
public long this[int i]=>Value[i];

public static A214733Inst Instance=new A214733Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214734
{
public static readonly long[] Value={ 1L,2L,3L,3L,1L,6L,6L,1L,4L,9L,2L,12L,10L,5L,1L,4L,12L,1L,18L,4L,20L,15L,1L,2L,6L,15L,3L,8L,24L,2L,30L,6L,30L,21L,1L,7L,1L,3L,7L,18L,30L,1L,5L,14L,40L,3L,45L,9L,42L,28L,1L,3L,8L,1L,4L,21L,1L,3L,7L,14L,36L,50L,2L,8L,21L,60L,5L,63L,12L,56L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214734Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214734.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214734Inst : IEnumerable<long>
{
public static readonly long[] Value=A214734.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214734.Bytes);
public long this[int i]=>Value[i];

public static A214734Inst Instance=new A214734Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214735
{
public static readonly long[] Value={ 2L,3L,5L,17L,29L,37L,41L,43L,53L,67L,73L,89L,109L,113L,131L,137L,149L,151L,157L,163L,181L,197L,199L,229L,233L,241L,277L,293L,313L,317L,331L,337L,349L,367L,373L,389L,401L,409L,421L,433L,449L,457L,461L,521L,541L,557L,577L,593L,601L,613L,617L,619L,631L,641L,643L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214735Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214735.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214735Inst : IEnumerable<long>
{
public static readonly long[] Value=A214735.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214735.Bytes);
public long this[int i]=>Value[i];

public static A214735Inst Instance=new A214735Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214736
{
public static readonly long[] Value={ 1L,2L,1L,4L,5L,2L,7L,8L,3L,10L,7L,4L,13L,14L,5L,10L,17L,6L,19L,20L,7L,22L,17L,8L,25L,16L,9L,28L,29L,10L,19L,32L,11L,34L,35L,12L,27L,38L,13L,40L,25L,14L,43L,32L,15L,28L,47L,16L,49L,50L,17L,52L,53L,18L,55L,34L,19L,42L,49L,20L,37L,62L,21L,64L,47L,22L,67L,68L,23L,58L,43L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214736Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214736.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214736Inst : IEnumerable<long>
{
public static readonly long[] Value=A214736.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214736.Bytes);
public long this[int i]=>Value[i];

public static A214736Inst Instance=new A214736Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214737
{
public static readonly long[] Value={ 1L,1L,3L,1L,5L,1L,5L,1L,7L,4L,5L,4L,11L,13L,13L,13L,17L,17L,7L,19L,21L,21L,23L,23L,25L,1L,1L,6L,17L,29L,31L,16L,33L,12L,19L,35L,35L,37L,37L,19L,41L,4L,41L,23L,11L,4L,47L,3L,19L,47L,49L,4L,49L,3L,27L,55L,11L,3L,29L,18L,57L,26L,39L,2L,65L,65L,23L,17L,69L,18L,71L,18L,71L,73L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214737Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214737.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214737Inst : IEnumerable<long>
{
public static readonly long[] Value=A214737.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214737.Bytes);
public long this[int i]=>Value[i];

public static A214737Inst Instance=new A214737Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214738
{
public static readonly long[] Value={ 1L,2L,3L,3L,4L,2L,7L,8L,5L,1L,6L,7L,13L,10L,15L,11L,16L,4L,15L,10L,19L,3L,12L,6L,17L,22L,27L,27L,20L,6L,21L,32L,27L,10L,3L,16L,37L,14L,35L,23L,11L,3L,43L,40L,37L,7L,24L,47L,25L,26L,21L,31L,52L,5L,37L,28L,57L,9L,30L,19L,61L,26L,63L,35L,64L,2L,67L,68L,55L,1L,36L,71L,41L,50L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214738Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214738.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214738Inst : IEnumerable<long>
{
public static readonly long[] Value=A214738.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214738.Bytes);
public long this[int i]=>Value[i];

public static A214738Inst Instance=new A214738Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214739
{
public static readonly long[] Value={ 1L,2L,1L,2L,4L,6L,4L,4L,1L,2L,2L,6L,3L,14L,4L,14L,8L,8L,16L,10L,16L,20L,10L,12L,12L,26L,1L,2L,28L,26L,12L,16L,8L,32L,32L,18L,28L,38L,11L,22L,5L,42L,40L,22L,28L,26L,4L,44L,24L,26L,2L,50L,23L,38L,12L,10L,27L,56L,16L,30L,24L,62L,16L,56L,32L,66L,40L,4L,19L,14L,32L,36L,36L,74L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214739Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214739.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214739Inst : IEnumerable<long>
{
public static readonly long[] Value=A214739.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214739.Bytes);
public long this[int i]=>Value[i];

public static A214739Inst Instance=new A214739Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214740
{
public static readonly long[] Value={ 1L,2L,2L,4L,1L,2L,2L,8L,8L,10L,8L,8L,5L,14L,8L,10L,16L,12L,8L,8L,3L,22L,4L,16L,11L,20L,5L,28L,28L,20L,5L,8L,32L,34L,32L,4L,4L,38L,12L,40L,40L,24L,14L,34L,24L,22L,11L,16L,32L,14L,14L,36L,52L,36L,4L,56L,56L,52L,14L,12L,29L,62L,24L,64L,1L,2L,32L,62L,68L,58L,64L,6L,16L,74L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214740Inst : IEnumerable<long>
{
public static readonly long[] Value=A214740.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214740.Bytes);
public long this[int i]=>Value[i];

public static A214740Inst Instance=new A214740Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214741
{
public static readonly long[] Value={ 1L,2L,2L,4L,1L,1L,3L,8L,8L,4L,11L,11L,2L,2L,15L,6L,17L,12L,7L,3L,3L,3L,22L,12L,9L,13L,27L,4L,4L,4L,31L,31L,33L,22L,34L,5L,5L,5L,14L,40L,41L,15L,21L,6L,6L,6L,23L,17L,24L,32L,18L,7L,7L,42L,54L,56L,57L,37L,59L,8L,8L,22L,63L,31L,23L,32L,66L,9L,9L,34L,25L,72L,73L,26L,10L,10L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214741Inst : IEnumerable<long>
{
public static readonly long[] Value=A214741.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214741.Bytes);
public long this[int i]=>Value[i];

public static A214741Inst Instance=new A214741Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214742
{
public static readonly long[] Value={ 1L,3L,2L,1L,1L,10L,4L,13L,2L,2L,9L,10L,20L,3L,3L,26L,10L,29L,4L,4L,12L,36L,13L,5L,20L,42L,43L,35L,6L,49L,49L,52L,7L,7L,20L,28L,21L,8L,8L,65L,23L,68L,9L,9L,72L,75L,75L,10L,10L,39L,29L,84L,11L,11L,31L,91L,32L,12L,95L,97L,98L,48L,13L,50L,104L,107L,14L,14L,39L,91L,40L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214742Inst : IEnumerable<long>
{
public static readonly long[] Value=A214742.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214742.Bytes);
public long this[int i]=>Value[i];

public static A214742Inst Instance=new A214742Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214743
{
public static readonly long[] Value={ 1L,2L,1L,3L,1L,2L,1L,4L,2L,5L,2L,2L,4L,7L,2L,11L,2L,7L,6L,2L,8L,14L,18L,23L,14L,7L,12L,5L,8L,7L,22L,20L,10L,29L,23L,16L,4L,8L,4L,8L,14L,8L,4L,22L,9L,17L,19L,8L,12L,27L,30L,9L,16L,19L,24L,32L,9L,9L,36L,18L,14L,45L,24L,9L,2L,18L,32L,8L,14L,29L,26L,23L,19L,54L,44L,47L,24L,15L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214743Inst : IEnumerable<long>
{
public static readonly long[] Value=A214743.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214743.Bytes);
public long this[int i]=>Value[i];

public static A214743Inst Instance=new A214743Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214744
{
public static readonly long[] Value={ 1L,2L,2L,3L,4L,3L,4L,3L,1L,8L,6L,6L,8L,8L,6L,4L,6L,4L,4L,6L,4L,4L,3L,15L,18L,2L,2L,3L,3L,15L,18L,15L,22L,17L,18L,15L,14L,15L,14L,17L,18L,11L,14L,15L,22L,11L,6L,7L,8L,9L,8L,11L,45L,7L,6L,45L,46L,7L,54L,9L,6L,42L,45L,46L,4L,42L,1L,30L,42L,45L,45L,42L,42L,42L,45L,45L,42L,45L,42L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214744Inst : IEnumerable<long>
{
public static readonly long[] Value=A214744.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214744.Bytes);
public long this[int i]=>Value[i];

public static A214744Inst Instance=new A214744Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214745
{
public static readonly long[] Value={ 1L,1L,3L,3L,5L,2L,7L,7L,9L,3L,5L,11L,13L,4L,15L,7L,17L,5L,19L,19L,9L,6L,23L,23L,15L,7L,27L,27L,29L,8L,13L,19L,33L,9L,35L,15L,37L,10L,23L,39L,17L,11L,43L,43L,45L,12L,35L,47L,49L,13L,21L,51L,31L,14L,55L,23L,57L,15L,59L,35L,25L,16L,63L,63L,65L,17L,39L,67L,51L,18L,29L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214745Inst : IEnumerable<long>
{
public static readonly long[] Value=A214745.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214745.Bytes);
public long this[int i]=>Value[i];

public static A214745Inst Instance=new A214745Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214746
{
public static readonly long[] Value={ 1L,11L,13L,16L,19L,29L,31L,37L,59L,61L,73L,79L,91L,92L,95L,97L,101L,102L,104L,106L,110L,120L,140L,160L,201L,203L,205L,207L,210L,225L,230L,238L,250L,252L,270L,283L,302L,308L,320L,328L,380L,382L,401L,405L,409L,410L,449L,450L,490L,494L,502L,504L,506L,508L,520L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214746Inst : IEnumerable<long>
{
public static readonly long[] Value=A214746.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214746.Bytes);
public long this[int i]=>Value[i];

public static A214746Inst Instance=new A214746Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214747
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,3L,1L,3L,3L,9L,6L,9L,7L,3L,8L,15L,9L,17L,10L,7L,11L,7L,12L,15L,13L,9L,14L,25L,15L,15L,16L,11L,17L,21L,13L,33L,19L,13L,11L,39L,21L,41L,22L,9L,23L,15L,1L,35L,3L,17L,26L,49L,11L,11L,28L,19L,29L,57L,1L,57L,3L,7L,32L,39L,33L,65L,34L,23L,11L,55L,36L,71L,37L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214747Inst : IEnumerable<long>
{
public static readonly long[] Value=A214747.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214747.Bytes);
public long this[int i]=>Value[i];

public static A214747Inst Instance=new A214747Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214748
{
public static readonly long[] Value={ 1L,1L,3L,3L,3L,5L,7L,3L,5L,9L,9L,11L,7L,5L,15L,15L,9L,17L,15L,7L,11L,21L,21L,15L,13L,9L,21L,27L,15L,29L,31L,11L,17L,21L,27L,35L,19L,13L,35L,39L,21L,41L,33L,15L,23L,45L,45L,35L,25L,17L,39L,51L,27L,33L,49L,19L,29L,57L,45L,59L,31L,21L,63L,39L,33L,65L,51L,23L,35L,69L,63L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214748Inst : IEnumerable<long>
{
public static readonly long[] Value=A214748.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214748.Bytes);
public long this[int i]=>Value[i];

public static A214748Inst Instance=new A214748Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214749
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,3L,2L,3L,5L,5L,6L,6L,4L,3L,8L,8L,9L,9L,5L,7L,11L,11L,4L,12L,8L,6L,14L,14L,15L,15L,8L,11L,17L,5L,18L,18L,12L,9L,20L,20L,21L,21L,8L,15L,23L,23L,6L,14L,16L,12L,26L,26L,9L,11L,14L,19L,29L,29L,30L,30L,20L,7L,12L,10L,33L,33L,17L,23L,35L,35L,36L,36L,24L,15L,32L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214749Inst : IEnumerable<long>
{
public static readonly long[] Value=A214749.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214749.Bytes);
public long this[int i]=>Value[i];

public static A214749Inst Instance=new A214749Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214750
{
public static readonly long[] Value={ 1L,1L,2L,3L,2L,5L,4L,3L,2L,9L,3L,11L,6L,5L,8L,15L,6L,17L,4L,3L,11L,21L,6L,15L,13L,9L,12L,27L,5L,29L,16L,11L,17L,10L,4L,35L,19L,13L,8L,39L,6L,41L,12L,15L,23L,45L,12L,35L,10L,17L,20L,51L,18L,5L,7L,19L,29L,57L,10L,59L,31L,9L,32L,15L,22L,65L,34L,23L,14L,69L,8L,71L,37L,25L,38L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214750Inst : IEnumerable<long>
{
public static readonly long[] Value=A214750.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214750.Bytes);
public long this[int i]=>Value[i];

public static A214750Inst Instance=new A214750Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214751
{
public static readonly long[] Value={ 1L,2L,1L,1L,2L,2L,7L,5L,3L,3L,4L,4L,10L,14L,5L,5L,6L,6L,12L,17L,7L,7L,8L,8L,22L,16L,9L,9L,10L,10L,19L,29L,11L,11L,12L,12L,27L,23L,13L,13L,14L,14L,36L,32L,15L,15L,16L,16L,30L,43L,17L,17L,18L,18L,40L,34L,19L,19L,20L,20L,37L,62L,21L,21L,22L,22L,60L,41L,23L,23L,24L,24L,70L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214751Inst : IEnumerable<long>
{
public static readonly long[] Value=A214751.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214751.Bytes);
public long this[int i]=>Value[i];

public static A214751Inst Instance=new A214751Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214752
{
public static readonly BigInteger[] Value={ 2L,3L,5L,61L,379L,4337L,568049L,74401441L,BigInteger.Parse("135641613564613015742379733"),BigInteger.Parse("1265128384429601209773279760867"),BigInteger.Parse("17454716892349876427463772074092822077069402994829708101921142701") };
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
public class A214752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214752Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A214752.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A214752.Bytes);
public BigInteger this[int i]=>Value[i];

public static A214752Inst Instance=new A214752Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214753
{
public static readonly long[] Value={ 1L,0L,1L,0L,2L,1L,0L,4L,4L,1L,0L,10L,16L,6L,1L,0L,26L,66L,34L,8L,1L,0L,76L,296L,192L,58L,10L,1L,0L,232L,1334L,1134L,406L,88L,12L,1L,0L,764L,6322L,6716L,2918L,730L,124L,14L,1L,0L,2620L,30930L,40872L,20718L,6118L,1186L,166L,16L,1L,0L,9496L,158008L,255308L,149826L,50056L,11310L,1796L,214L,18L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214753Inst : IEnumerable<long>
{
public static readonly long[] Value=A214753.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214753.Bytes);
public long this[int i]=>Value[i];

public static A214753Inst Instance=new A214753Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214754
{
public static readonly long[] Value={ 23L,29L,31L,47L,59L,61L,71L,79L,109L,113L,127L,151L,157L,167L,179L,191L,223L,229L,233L,239L,241L,251L,271L,283L,317L,349L,359L,367L,373L,379L,383L,431L,433L,439L,457L,463L,467L,479L,487L,491L,499L,503L,509L,541L,563L,599L,607L,631L,701L,719L,727L,733L,743L,751L,757L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214754Inst : IEnumerable<long>
{
public static readonly long[] Value=A214754.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214754.Bytes);
public long this[int i]=>Value[i];

public static A214754Inst Instance=new A214754Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214755
{
public static readonly long[] Value={ 37L,53L,73L,113L,137L,173L,193L,197L,233L,293L,311L,313L,317L,331L,337L,347L,353L,359L,367L,373L,379L,383L,389L,397L,433L,523L,541L,547L,557L,571L,577L,593L,613L,617L,673L,677L,719L,733L,743L,757L,761L,773L,797L,977L,1013L,1033L,1093L,1097L,1117L,1123L,1129L,1153L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214755Inst : IEnumerable<long>
{
public static readonly long[] Value=A214755.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214755.Bytes);
public long this[int i]=>Value[i];

public static A214755Inst Instance=new A214755Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A214756
{
public static readonly long[] Value={ 2L,2L,2L,17L,71L,107L,503L,881L,1103L,1301L,9521L,15671L,19543L,31387L,155849L,360289L,370061L,492067L,1349147L,1356869L,2010553L,4652239L,17051297L,20831119L,47326519L,122164649L,189695483L,191912659L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A214756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A214756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A214756Inst : IEnumerable<long>
{
public static readonly long[] Value=A214756.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A214756.Bytes);
public long this[int i]=>Value[i];

public static A214756Inst Instance=new A214756Inst();

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