using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A142655
{
public static readonly long[] Value={ 89L,257L,313L,593L,761L,929L,1097L,1153L,1321L,1433L,1489L,1601L,1657L,1993L,2161L,2273L,2441L,2609L,2777L,2833L,3001L,3169L,3449L,3617L,3673L,4177L,4289L,4457L,4513L,4793L,5297L,5521L,5689L,5801L,5857L,6361L,6473L,6529L,6977L,7369L,7481L,7537L,7649L,7817L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142655Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142655.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142655Inst : IEnumerable<long>
{
public static readonly long[] Value=A142655.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142655.Bytes);
public long this[int i]=>Value[i];

public static A142655Inst Instance=new A142655Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142654
{
public static readonly long[] Value={ 31L,199L,311L,367L,479L,647L,983L,1039L,1151L,1319L,1487L,1543L,1823L,1879L,2383L,2551L,2663L,2719L,2887L,2999L,3167L,3391L,3559L,3671L,3727L,4007L,4231L,4567L,4679L,4903L,5351L,5407L,5519L,5743L,6079L,6247L,6359L,6863L,7591L,7703L,7759L,7927L,8039L,8263L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142654Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142654.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142654Inst : IEnumerable<long>
{
public static readonly long[] Value=A142654.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142654.Bytes);
public long this[int i]=>Value[i];

public static A142654Inst Instance=new A142654Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142653
{
public static readonly long[] Value={ 29L,197L,421L,701L,757L,1093L,1373L,1429L,1597L,1709L,1877L,1933L,2213L,2269L,2381L,2437L,2549L,3109L,3221L,3389L,3557L,3613L,4229L,4397L,4621L,4733L,4789L,4957L,5237L,5573L,5741L,6133L,6301L,6469L,6581L,6637L,6917L,7253L,7309L,7477L,7589L,7757L,8093L,8317L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142653Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142653.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142653Inst : IEnumerable<long>
{
public static readonly long[] Value=A142653.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142653.Bytes);
public long this[int i]=>Value[i];

public static A142653Inst Instance=new A142653Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142652
{
public static readonly long[] Value={ 83L,139L,251L,307L,419L,587L,643L,811L,1091L,1259L,1427L,1483L,1931L,1987L,2099L,2267L,2659L,2939L,3163L,3331L,3499L,3779L,3947L,4003L,4283L,4339L,4451L,4507L,4787L,5011L,5179L,5347L,5683L,5851L,6131L,6299L,6691L,6803L,6971L,7027L,7307L,7643L,7699L,7867L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142652Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142652.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142652Inst : IEnumerable<long>
{
public static readonly long[] Value=A142652.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142652.Bytes);
public long this[int i]=>Value[i];

public static A142652Inst Instance=new A142652Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142651
{
public static readonly long[] Value={ 137L,193L,641L,809L,977L,1033L,1201L,1481L,1873L,2153L,2377L,2657L,2713L,3049L,3217L,3329L,3833L,3889L,4001L,4057L,4337L,4561L,4673L,4729L,5009L,5233L,5569L,5737L,5849L,6073L,6353L,6521L,6577L,6689L,6857L,7193L,7417L,7529L,7753L,8089L,8369L,8537L,8761L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142651Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142651.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142651Inst : IEnumerable<long>
{
public static readonly long[] Value=A142651.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142651.Bytes);
public long this[int i]=>Value[i];

public static A142651Inst Instance=new A142651Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142650
{
public static readonly long[] Value={ 23L,79L,191L,359L,751L,863L,919L,1031L,1087L,1367L,1423L,1759L,1871L,2039L,2207L,2543L,2711L,2767L,2879L,3271L,3607L,3719L,3943L,4111L,4391L,4447L,4783L,4951L,5119L,5231L,5399L,5623L,5791L,5903L,6911L,6967L,7079L,7247L,7583L,7639L,7919L,8087L,8311L,8423L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142650Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142650.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142650Inst : IEnumerable<long>
{
public static readonly long[] Value=A142650.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142650.Bytes);
public long this[int i]=>Value[i];

public static A142650Inst Instance=new A142650Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142649
{
public static readonly long[] Value={ 19L,131L,467L,523L,691L,859L,971L,1307L,1531L,1699L,1811L,1867L,1979L,2203L,2371L,2539L,2707L,2819L,3323L,3491L,3547L,3659L,4051L,4219L,4723L,5003L,5059L,5171L,5227L,5507L,5563L,5843L,6011L,6067L,6571L,6907L,7019L,7187L,7243L,7411L,7523L,7691L,8363L,8419L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142649Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142649.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142649Inst : IEnumerable<long>
{
public static readonly long[] Value=A142649.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142649.Bytes);
public long this[int i]=>Value[i];

public static A142649Inst Instance=new A142649Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142648
{
public static readonly long[] Value={ 17L,73L,241L,353L,409L,521L,577L,857L,1193L,1249L,1361L,1697L,1753L,2089L,2593L,3041L,3209L,3433L,3769L,3881L,4049L,4217L,4273L,4441L,4721L,4889L,5113L,5281L,5393L,5449L,5897L,5953L,6121L,6569L,6737L,6793L,6961L,7129L,7297L,7577L,8081L,8641L,8753L,9257L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142648Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142648.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142648Inst : IEnumerable<long>
{
public static readonly long[] Value=A142648.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142648.Bytes);
public long this[int i]=>Value[i];

public static A142648Inst Instance=new A142648Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142471
{
public static readonly BigInteger[] Value={ 0L,0L,2L,2L,6L,14L,86L,1206L,103718L,125083910L,12973452977382L,BigInteger.Parse("1622770224612082123622"),BigInteger.Parse("21052933202100473722674133293917606"),BigInteger.Parse("34164073141115747076263787631563122725393126176374288934") };
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
public class A142471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142471Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A142471.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A142471.Bytes);
public BigInteger this[int i]=>Value[i];

public static A142471Inst Instance=new A142471Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142470
{
public static readonly long[] Value={ 1L,1L,1L,1L,8L,1L,1L,30L,30L,1L,1L,80L,300L,80L,1L,1L,175L,1750L,1750L,175L,1L,1L,336L,7350L,19600L,7350L,336L,1L,1L,588L,24696L,144060L,144060L,24696L,588L,1L,1L,960L,70560L,790272L,1728720L,790272L,70560L,960L,1L,1L,1485L,178200L,3492720L,14669424L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142470Inst : IEnumerable<long>
{
public static readonly long[] Value=A142470.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142470.Bytes);
public long this[int i]=>Value[i];

public static A142470Inst Instance=new A142470Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142469
{
public static readonly long[] Value={ 3L,3L,46L,6L,46L,347L,532L,532L,347L,1932L,14505L,740L,14505L,1932L,9199L,203925L,152405L,152405L,203925L,9199L,40250L,2087884L,6882086L,-86372L,6882086L,2087884L,40250L,168318L,17968725L,152844537L,78623775L,78623775L,152844537L,17968725L,168318L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142469Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142469.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142469Inst : IEnumerable<long>
{
public static readonly long[] Value=A142469.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142469.Bytes);
public long this[int i]=>Value[i];

public static A142469Inst Instance=new A142469Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142468
{
public static readonly long[] Value={ 1L,1L,1L,1L,9L,1L,1L,45L,45L,1L,1L,165L,825L,165L,1L,1L,495L,9075L,9075L,495L,1L,1L,1287L,70785L,259545L,70785L,1287L,1L,1L,3003L,429429L,4723719L,4723719L,429429L,3003L,1L,1L,6435L,2147145L,61408347L,184225041L,61408347L,2147145L,6435L,1L,1L,12870L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142468Inst : IEnumerable<long>
{
public static readonly long[] Value=A142468.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142468.Bytes);
public long this[int i]=>Value[i];

public static A142468Inst Instance=new A142468Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142467
{
public static readonly long[] Value={ 1L,1L,1L,1L,8L,1L,1L,36L,36L,1L,1L,120L,540L,120L,1L,1L,330L,4950L,4950L,330L,1L,1L,792L,32670L,108900L,32670L,792L,1L,1L,1716L,169884L,1557270L,1557270L,169884L,1716L,1L,1L,3432L,736164L,16195608L,44537922L,16195608L,736164L,3432L,1L,1L,6435L,2760615L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142467Inst : IEnumerable<long>
{
public static readonly long[] Value=A142467.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142467.Bytes);
public long this[int i]=>Value[i];

public static A142467Inst Instance=new A142467Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142466
{
public static readonly long[] Value={ 127L,227L,277L,577L,677L,727L,827L,877L,977L,1277L,1327L,1427L,1627L,1777L,1877L,2027L,2377L,2477L,2677L,2777L,2927L,3527L,3677L,3727L,3877L,4027L,4127L,4177L,4327L,4877L,5077L,5227L,5477L,5527L,5827L,5927L,6277L,6427L,6577L,6827L,6977L,7027L,7127L,7177L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142466Inst : IEnumerable<long>
{
public static readonly long[] Value=A142466.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142466.Bytes);
public long this[int i]=>Value[i];

public static A142466Inst Instance=new A142466Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142465
{
public static readonly long[] Value={ 1L,1L,1L,1L,7L,1L,1L,28L,28L,1L,1L,84L,336L,84L,1L,1L,210L,2520L,2520L,210L,1L,1L,462L,13860L,41580L,13860L,462L,1L,1L,924L,60984L,457380L,457380L,60984L,924L,1L,1L,1716L,226512L,3737448L,9343620L,3737448L,226512L,1716L,1L,1L,3003L,736164L,24293412L,133613766L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142465Inst : IEnumerable<long>
{
public static readonly long[] Value=A142465.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142465.Bytes);
public long this[int i]=>Value[i];

public static A142465Inst Instance=new A142465Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142464
{
public static readonly long[] Value={ 3L,6L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142464Inst : IEnumerable<long>
{
public static readonly long[] Value=A142464.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142464.Bytes);
public long this[int i]=>Value[i];

public static A142464Inst Instance=new A142464Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142463
{
public static readonly long[] Value={ -1L,3L,11L,23L,39L,59L,83L,111L,143L,179L,219L,263L,311L,363L,419L,479L,543L,611L,683L,759L,839L,923L,1011L,1103L,1199L,1299L,1403L,1511L,1623L,1739L,1859L,1983L,2111L,2243L,2379L,2519L,2663L,2811L,2963L,3119L,3279L,3443L,3611L,3783L,3959L,4139L,4323L,4511L,4703L,4899L,5099L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142463Inst : IEnumerable<long>
{
public static readonly long[] Value=A142463.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142463.Bytes);
public long this[int i]=>Value[i];

public static A142463Inst Instance=new A142463Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142462
{
public static readonly long[] Value={ 1L,1L,1L,1L,16L,1L,1L,143L,143L,1L,1L,1166L,4290L,1166L,1L,1L,9357L,90002L,90002L,9357L,1L,1L,74892L,1621383L,3960088L,1621383L,74892L,1L,1L,599179L,27016857L,134142043L,134142043L,27016857L,599179L,1L,1L,4793482L,431017552L,3923731798L,7780238494L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142462Inst : IEnumerable<long>
{
public static readonly long[] Value=A142462.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142462.Bytes);
public long this[int i]=>Value[i];

public static A142462Inst Instance=new A142462Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142461
{
public static readonly long[] Value={ 1L,1L,1L,1L,14L,1L,1L,111L,111L,1L,1L,796L,2886L,796L,1L,1L,5597L,52642L,52642L,5597L,1L,1L,39210L,824271L,2000396L,824271L,39210L,1L,1L,274507L,11931033L,58614299L,58614299L,11931033L,274507L,1L,1L,1921592L,165260188L,1483533704L,2930714950L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142461Inst : IEnumerable<long>
{
public static readonly long[] Value=A142461.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142461.Bytes);
public long this[int i]=>Value[i];

public static A142461Inst Instance=new A142461Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142460
{
public static readonly long[] Value={ 1L,1L,1L,1L,12L,1L,1L,83L,83L,1L,1L,514L,1826L,514L,1L,1L,3105L,28310L,28310L,3105L,1L,1L,18656L,376615L,905920L,376615L,18656L,1L,1L,111967L,4627821L,22403635L,22403635L,4627821L,111967L,1L,1L,671838L,54377008L,478781506L,940952670L,478781506L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142460Inst : IEnumerable<long>
{
public static readonly long[] Value=A142460.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142460.Bytes);
public long this[int i]=>Value[i];

public static A142460Inst Instance=new A142460Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142459
{
public static readonly long[] Value={ 1L,1L,1L,1L,10L,1L,1L,59L,59L,1L,1L,308L,1062L,308L,1L,1L,1557L,13562L,13562L,1557L,1L,1L,7806L,148527L,352612L,148527L,7806L,1L,1L,39055L,1500669L,7108915L,7108915L,1500669L,39055L,1L,1L,195304L,14482396L,123929944L,241703110L,123929944L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142459Inst : IEnumerable<long>
{
public static readonly long[] Value=A142459.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142459.Bytes);
public long this[int i]=>Value[i];

public static A142459Inst Instance=new A142459Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142458
{
public static readonly long[] Value={ 1L,1L,1L,1L,8L,1L,1L,39L,39L,1L,1L,166L,546L,166L,1L,1L,677L,5482L,5482L,677L,1L,1L,2724L,47175L,109640L,47175L,2724L,1L,1L,10915L,373809L,1709675L,1709675L,373809L,10915L,1L,1L,43682L,2824048L,23077694L,44451550L,23077694L,2824048L,43682L,1L,1L,174753L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142458Inst : IEnumerable<long>
{
public static readonly long[] Value=A142458.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142458.Bytes);
public long this[int i]=>Value[i];

public static A142458Inst Instance=new A142458Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142457
{
public static readonly long[] Value={ 0L,0L,2L,0L,6L,5L,0L,1L,8L,10L,0L,9L,4L,7L,7L,0L,8L,4L,10L,4L,8L,0L,9L,8L,8L,9L,0L,3L,0L,1L,5L,1L,0L,2L,7L,4L,0L,6L,6L,0L,10L,3L,1L,4L,1L,0L,2L,0L,5L,6L,3L,7L,7L,3L,6L,0L,0L,9L,5L,10L,2L,3L,2L,10L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142457Inst : IEnumerable<long>
{
public static readonly long[] Value=A142457.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142457.Bytes);
public long this[int i]=>Value[i];

public static A142457Inst Instance=new A142457Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142456
{
public static readonly long[] Value={ 3L,3L,5L,5L,7L,13L,31L,31L,37L,43L,47L,53L,53L,59L,73L,83L,97L,137L,137L,157L,173L,173L,191L,199L,233L,281L,293L,337L,397L,397L,409L,421L,431L,449L,457L,463L,467L,467L,487L,487L,499L,499L,503L,509L,521L,523L,593L,593L,599L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142456Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142456.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142456Inst : IEnumerable<long>
{
public static readonly long[] Value=A142456.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142456.Bytes);
public long this[int i]=>Value[i];

public static A142456Inst Instance=new A142456Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142407
{
public static readonly long[] Value={ 29L,173L,269L,317L,461L,509L,557L,653L,701L,797L,941L,1181L,1229L,1277L,1373L,1613L,1709L,1901L,1949L,1997L,2141L,2237L,2333L,2381L,2477L,2621L,2861L,2909L,2957L,3389L,3533L,3581L,3677L,3821L,3917L,4013L,4157L,4253L,4349L,4397L,4493L,4637L,4733L,4877L,4973L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142407Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142407.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142407Inst : IEnumerable<long>
{
public static readonly long[] Value=A142407.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142407.Bytes);
public long this[int i]=>Value[i];

public static A142407Inst Instance=new A142407Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142406
{
public static readonly long[] Value={ 73L,313L,409L,457L,601L,937L,1033L,1129L,1321L,1609L,1657L,1753L,1801L,1993L,2089L,2137L,2281L,2377L,2473L,2521L,2617L,2713L,2857L,2953L,3001L,3049L,3433L,3529L,3673L,3769L,4057L,4153L,4201L,4297L,4441L,4729L,4969L,5113L,5209L,5449L,5641L,5689L,5737L,5881L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142406Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142406.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142406Inst : IEnumerable<long>
{
public static readonly long[] Value=A142406.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142406.Bytes);
public long this[int i]=>Value[i];

public static A142406Inst Instance=new A142406Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142405
{
public static readonly long[] Value={ 23L,71L,167L,263L,311L,359L,503L,599L,647L,743L,839L,887L,983L,1031L,1223L,1319L,1367L,1511L,1559L,1607L,1847L,2039L,2087L,2423L,2663L,2711L,2903L,2999L,3191L,3527L,3623L,3671L,3719L,3767L,3863L,3911L,4007L,4391L,4583L,4679L,4871L,4919L,4967L,5303L,5351L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142405Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142405.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142405Inst : IEnumerable<long>
{
public static readonly long[] Value=A142405.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142405.Bytes);
public long this[int i]=>Value[i];

public static A142405Inst Instance=new A142405Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142404
{
public static readonly long[] Value={ 19L,67L,163L,211L,307L,499L,547L,643L,691L,739L,787L,883L,1123L,1171L,1459L,1699L,1747L,1987L,2083L,2131L,2179L,2371L,2467L,2659L,2707L,2803L,2851L,3187L,3331L,3571L,3907L,4003L,4051L,4099L,4243L,4339L,4483L,4723L,5011L,5059L,5107L,5347L,5443L,5683L,5779L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142404Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142404.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142404Inst : IEnumerable<long>
{
public static readonly long[] Value=A142404.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142404.Bytes);
public long this[int i]=>Value[i];

public static A142404Inst Instance=new A142404Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142403
{
public static readonly long[] Value={ 17L,113L,257L,353L,401L,449L,593L,641L,881L,929L,977L,1217L,1361L,1409L,1553L,1601L,1697L,1889L,2081L,2129L,2273L,2417L,2609L,2657L,2753L,2801L,2897L,3041L,3089L,3137L,3329L,3617L,3761L,4001L,4049L,4241L,4289L,4337L,4481L,4673L,4721L,4817L,5009L,5153L,5297L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142403Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142403.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142403Inst : IEnumerable<long>
{
public static readonly long[] Value=A142403.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142403.Bytes);
public long this[int i]=>Value[i];

public static A142403Inst Instance=new A142403Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142402
{
public static readonly long[] Value={ 13L,61L,109L,157L,349L,397L,541L,733L,829L,877L,1021L,1069L,1117L,1213L,1453L,1549L,1597L,1693L,1741L,1789L,1933L,2029L,2221L,2269L,2557L,2749L,2797L,3037L,3181L,3229L,3373L,3469L,3517L,3613L,3709L,3853L,4093L,4621L,4813L,4861L,4909L,4957L,5101L,5197L,5437L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142402Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142402.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142402Inst : IEnumerable<long>
{
public static readonly long[] Value=A142402.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142402.Bytes);
public long this[int i]=>Value[i];

public static A142402Inst Instance=new A142402Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142401
{
public static readonly long[] Value={ 11L,59L,107L,251L,347L,443L,491L,587L,683L,827L,971L,1019L,1163L,1259L,1307L,1451L,1499L,1787L,1931L,1979L,2027L,2267L,2411L,2459L,2699L,2843L,2939L,3083L,3323L,3371L,3467L,3659L,3803L,3851L,3947L,4091L,4139L,4283L,4523L,5003L,5051L,5099L,5147L,5387L,5483L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142401Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142401.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142401Inst : IEnumerable<long>
{
public static readonly long[] Value=A142401.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142401.Bytes);
public long this[int i]=>Value[i];

public static A142401Inst Instance=new A142401Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142400
{
public static readonly long[] Value={ 7L,103L,151L,199L,439L,487L,631L,727L,823L,919L,967L,1063L,1303L,1399L,1447L,1543L,1783L,1831L,1879L,2311L,2503L,2551L,2647L,2791L,2887L,3079L,3271L,3319L,3463L,3511L,3559L,3607L,3847L,3943L,4231L,4327L,4423L,4519L,4567L,4663L,4759L,4903L,4951L,4999L,5431L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142400Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142400.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142400Inst : IEnumerable<long>
{
public static readonly long[] Value=A142400.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142400.Bytes);
public long this[int i]=>Value[i];

public static A142400Inst Instance=new A142400Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142399
{
public static readonly long[] Value={ 5L,53L,101L,149L,197L,293L,389L,677L,773L,821L,1013L,1061L,1109L,1301L,1493L,1637L,1733L,1877L,1973L,2069L,2213L,2309L,2357L,2549L,2693L,2741L,2789L,2837L,3221L,3413L,3461L,3557L,3701L,3797L,3989L,4133L,4229L,4373L,4421L,4517L,5189L,5237L,5333L,5381L,5477L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142399Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142399.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142399Inst : IEnumerable<long>
{
public static readonly long[] Value=A142399.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142399.Bytes);
public long this[int i]=>Value[i];

public static A142399Inst Instance=new A142399Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142398
{
public static readonly long[] Value={ 97L,193L,241L,337L,433L,577L,673L,769L,1009L,1153L,1201L,1249L,1297L,1489L,1777L,1873L,2017L,2113L,2161L,2593L,2689L,2833L,3121L,3169L,3217L,3313L,3361L,3457L,3697L,3793L,3889L,4129L,4177L,4273L,4513L,4561L,4657L,4801L,4993L,5233L,5281L,5521L,5569L,5857L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142398Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142398.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142398Inst : IEnumerable<long>
{
public static readonly long[] Value=A142398.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142398.Bytes);
public long this[int i]=>Value[i];

public static A142398Inst Instance=new A142398Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142397
{
public static readonly long[] Value={ 281L,563L,751L,1033L,1409L,1597L,1879L,1973L,2161L,2819L,3571L,3853L,3947L,4229L,4793L,5639L,5827L,6203L,6673L,7237L,7331L,8647L,8741L,8929L,9587L,10151L,10433L,10903L,11279L,11467L,12689L,13159L,13441L,13723L,14851L,15227L,15791L,16073L,17107L,17389L,17483L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142397Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142397.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142397Inst : IEnumerable<long>
{
public static readonly long[] Value=A142397.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142397.Bytes);
public long this[int i]=>Value[i];

public static A142397Inst Instance=new A142397Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142396
{
public static readonly long[] Value={ 139L,233L,421L,797L,1361L,1549L,1831L,2113L,2207L,2677L,3617L,4463L,4651L,4933L,5309L,5591L,5779L,6343L,6719L,6907L,7001L,7283L,7753L,8317L,8599L,8693L,9257L,9539L,10009L,10103L,10667L,10949L,11701L,12547L,12641L,12829L,12923L,13487L,14051L,14897L,15461L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142396Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142396.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142396Inst : IEnumerable<long>
{
public static readonly long[] Value=A142396.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142396.Bytes);
public long this[int i]=>Value[i];

public static A142396Inst Instance=new A142396Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142395
{
public static readonly long[] Value={ 373L,467L,937L,1031L,1783L,1877L,2347L,2441L,3851L,4133L,4603L,5167L,5261L,5449L,6389L,6577L,7517L,8081L,8269L,8363L,9209L,9397L,9491L,9679L,10243L,10337L,12781L,13063L,13627L,13721L,15131L,15319L,15413L,15601L,16447L,16729L,16823L,17011L,17293L,17387L,17669L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142395Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142395.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142395Inst : IEnumerable<long>
{
public static readonly long[] Value=A142395.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142395.Bytes);
public long this[int i]=>Value[i];

public static A142395Inst Instance=new A142395Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142394
{
public static readonly long[] Value={ 43L,137L,419L,607L,701L,983L,1171L,1453L,2017L,2111L,2393L,2957L,3709L,3803L,4273L,4649L,4931L,5119L,5683L,6247L,6529L,7187L,8221L,8597L,9067L,9161L,9349L,9631L,10007L,10289L,10477L,10853L,11699L,11887L,11981L,12263L,12451L,13109L,13297L,14143L,14519L,15083L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142394Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142394.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142394Inst : IEnumerable<long>
{
public static readonly long[] Value=A142394.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142394.Bytes);
public long this[int i]=>Value[i];

public static A142394Inst Instance=new A142394Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142393
{
public static readonly long[] Value={ 89L,277L,653L,1123L,1217L,1499L,2063L,2251L,2909L,3191L,3943L,4507L,4789L,6011L,6199L,6481L,6763L,6857L,7703L,8737L,8831L,9677L,10429L,10711L,10993L,11087L,11369L,11839L,11933L,12497L,12967L,13249L,13907L,14753L,15787L,15881L,16069L,16633L,17291L,17573L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142393Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142393.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142393Inst : IEnumerable<long>
{
public static readonly long[] Value=A142393.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142393.Bytes);
public long this[int i]=>Value[i];

public static A142393Inst Instance=new A142393Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142392
{
public static readonly long[] Value={ 41L,229L,887L,1451L,1733L,2203L,2297L,2579L,2767L,2861L,3049L,3331L,3613L,3989L,4177L,4271L,5023L,5399L,5869L,6151L,6997L,7561L,7937L,8219L,8501L,8689L,8783L,8971L,9629L,9817L,10099L,10193L,10663L,11321L,12073L,12637L,12919L,13577L,13859L,14423L,15269L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142392Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142392.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142392Inst : IEnumerable<long>
{
public static readonly long[] Value=A142392.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142392.Bytes);
public long this[int i]=>Value[i];

public static A142392Inst Instance=new A142392Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142327
{
public static readonly long[] Value={ 29L,389L,479L,569L,659L,839L,929L,1019L,1109L,1289L,1559L,2099L,2459L,2549L,2729L,2819L,2909L,2999L,3089L,3359L,3449L,3539L,3719L,3989L,4079L,4259L,4349L,4799L,4889L,5519L,5879L,6329L,6599L,6689L,6779L,6869L,6959L,7229L,7499L,7589L,7949L,8039L,8219L,8669L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142327Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142327.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142327Inst : IEnumerable<long>
{
public static readonly long[] Value=A142327.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142327.Bytes);
public long this[int i]=>Value[i];

public static A142327Inst Instance=new A142327Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142326
{
public static readonly long[] Value={ 73L,163L,433L,523L,613L,883L,1063L,1153L,1423L,1693L,1783L,1873L,2053L,2143L,2503L,2593L,2683L,2953L,3313L,3583L,3673L,3853L,3943L,4483L,4663L,4933L,5023L,5113L,5563L,5653L,5743L,5923L,6373L,6553L,6733L,6823L,7723L,7993L,8263L,8353L,8443L,8623L,8713L,8803L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142326Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142326.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142326Inst : IEnumerable<long>
{
public static readonly long[] Value=A142326.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142326.Bytes);
public long this[int i]=>Value[i];

public static A142326Inst Instance=new A142326Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142325
{
public static readonly long[] Value={ 71L,251L,431L,521L,701L,881L,971L,1061L,1151L,1511L,1601L,1871L,2141L,2411L,2591L,2861L,3041L,3221L,3491L,3581L,3671L,3761L,3851L,4211L,4391L,4481L,4751L,4931L,5021L,5381L,5471L,5651L,5741L,6011L,6101L,6551L,6911L,7001L,7451L,7541L,7901L,8081L,8171L,9161L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142325Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142325.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142325Inst : IEnumerable<long>
{
public static readonly long[] Value=A142325.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142325.Bytes);
public long this[int i]=>Value[i];

public static A142325Inst Instance=new A142325Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142324
{
public static readonly long[] Value={ 23L,113L,293L,383L,563L,653L,743L,1013L,1103L,1193L,1283L,1373L,1553L,1733L,1823L,1913L,2003L,2273L,2543L,2633L,2903L,3083L,3533L,3623L,3803L,4073L,4253L,4523L,4703L,4793L,4973L,5153L,5333L,5693L,5783L,6053L,6143L,6323L,6863L,7043L,7583L,7673L,7853L,8123L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142324Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142324.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142324Inst : IEnumerable<long>
{
public static readonly long[] Value=A142324.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142324.Bytes);
public long this[int i]=>Value[i];

public static A142324Inst Instance=new A142324Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142323
{
public static readonly long[] Value={ 67L,157L,337L,607L,787L,877L,967L,1237L,1327L,1597L,1777L,1867L,2137L,2677L,2767L,2857L,3037L,3217L,3307L,3847L,4027L,4297L,4567L,4657L,5107L,5197L,5557L,5647L,5737L,5827L,6007L,6277L,6367L,6547L,6637L,6907L,6997L,7177L,7537L,7717L,8167L,8527L,8707L,8887L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142323Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142323.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142323Inst : IEnumerable<long>
{
public static readonly long[] Value=A142323.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142323.Bytes);
public long this[int i]=>Value[i];

public static A142323Inst Instance=new A142323Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142322
{
public static readonly long[] Value={ 19L,109L,199L,379L,739L,829L,919L,1009L,1279L,1459L,1549L,1999L,2089L,2179L,2269L,2539L,2719L,3079L,3169L,3259L,3529L,3709L,3889L,4159L,4339L,4519L,4789L,4969L,5059L,5419L,5689L,5779L,5869L,6229L,6679L,6949L,7039L,7129L,7219L,7309L,7489L,7669L,7759L,8209L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142322Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142322.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142322Inst : IEnumerable<long>
{
public static readonly long[] Value=A142322.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142322.Bytes);
public long this[int i]=>Value[i];

public static A142322Inst Instance=new A142322Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142321
{
public static readonly long[] Value={ 17L,107L,197L,467L,557L,647L,827L,1097L,1187L,1277L,1367L,1637L,1907L,1997L,2087L,2267L,2357L,2447L,2897L,3167L,3257L,3347L,3527L,3617L,3797L,4157L,4337L,4517L,4787L,4877L,4967L,5147L,5237L,5417L,5507L,5867L,6047L,6317L,6857L,6947L,7127L,7307L,7487L,7577L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142321Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142321.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142321Inst : IEnumerable<long>
{
public static readonly long[] Value=A142321.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142321.Bytes);
public long this[int i]=>Value[i];

public static A142321Inst Instance=new A142321Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142320
{
public static readonly long[] Value={ 61L,151L,241L,331L,421L,601L,691L,1051L,1231L,1321L,1861L,1951L,2131L,2221L,2311L,2671L,2851L,3121L,3301L,3391L,3571L,3931L,4021L,4111L,4201L,4561L,4651L,4831L,5011L,5101L,5281L,5641L,5821L,6091L,6271L,6361L,6451L,6991L,7351L,7621L,8161L,8431L,8521L,8971L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142320Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142320.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142320Inst : IEnumerable<long>
{
public static readonly long[] Value=A142320.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142320.Bytes);
public long this[int i]=>Value[i];

public static A142320Inst Instance=new A142320Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142319
{
public static readonly long[] Value={ 59L,149L,239L,419L,509L,599L,1049L,1229L,1319L,1409L,1499L,1949L,2039L,2129L,2309L,2399L,2579L,2939L,3119L,3209L,3299L,3389L,3659L,3929L,4019L,4289L,4649L,4919L,5009L,5099L,5189L,5279L,5639L,6089L,6269L,6359L,6449L,6719L,6899L,7079L,7349L,7529L,8069L,8429L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142319Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142319.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142319Inst : IEnumerable<long>
{
public static readonly long[] Value=A142319.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142319.Bytes);
public long this[int i]=>Value[i];

public static A142319Inst Instance=new A142319Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142318
{
public static readonly long[] Value={ 13L,103L,193L,283L,373L,463L,643L,733L,823L,1093L,1453L,1543L,1723L,1993L,2083L,2713L,2803L,3163L,3253L,3343L,3433L,3613L,3793L,4153L,4243L,4423L,4513L,4603L,4783L,5233L,5323L,5413L,5503L,5683L,5953L,6043L,6133L,6673L,6763L,7213L,7393L,7573L,7753L,7933L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142318Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142318.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142318Inst : IEnumerable<long>
{
public static readonly long[] Value=A142318.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142318.Bytes);
public long this[int i]=>Value[i];

public static A142318Inst Instance=new A142318Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142317
{
public static readonly long[] Value={ 11L,101L,191L,281L,461L,641L,821L,911L,1091L,1181L,1361L,1451L,1721L,1811L,1901L,2081L,2351L,2441L,2531L,2621L,2711L,2801L,3251L,3701L,3881L,4241L,4421L,4691L,4871L,5051L,5231L,5501L,5591L,5861L,6131L,6221L,6311L,6491L,6581L,6761L,7121L,7211L,7481L,7841L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142317Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142317.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142317Inst : IEnumerable<long>
{
public static readonly long[] Value=A142317.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142317.Bytes);
public long this[int i]=>Value[i];

public static A142317Inst Instance=new A142317Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142316
{
public static readonly long[] Value={ 53L,233L,503L,593L,683L,773L,863L,953L,1223L,1493L,1583L,2213L,2393L,2663L,2753L,2843L,3023L,3203L,3833L,3923L,4013L,4283L,4373L,4463L,4643L,4733L,5003L,5273L,5813L,5903L,6173L,6263L,6353L,6803L,6983L,7253L,7433L,7523L,7703L,7793L,7883L,8243L,8423L,8513L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142316Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142316.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142316Inst : IEnumerable<long>
{
public static readonly long[] Value=A142316.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142316.Bytes);
public long this[int i]=>Value[i];

public static A142316Inst Instance=new A142316Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142315
{
public static readonly long[] Value={ 7L,97L,277L,367L,457L,547L,727L,907L,997L,1087L,1447L,1627L,1987L,2347L,2437L,2617L,2707L,2797L,2887L,3067L,3517L,3607L,3697L,3877L,3967L,4057L,4327L,4507L,4597L,4957L,5227L,5407L,5857L,6037L,6217L,6397L,6577L,7027L,7207L,7297L,7477L,7927L,8017L,8287L,8377L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142315Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142315.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142315Inst : IEnumerable<long>
{
public static readonly long[] Value=A142315.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142315.Bytes);
public long this[int i]=>Value[i];

public static A142315Inst Instance=new A142315Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142314
{
public static readonly long[] Value={ 139L,229L,409L,499L,769L,859L,1039L,1129L,1399L,1489L,1579L,1669L,1759L,2029L,2389L,2659L,2749L,3019L,3109L,3469L,3559L,3739L,3919L,4099L,4549L,4639L,4729L,4909L,4999L,5179L,5449L,6079L,6529L,6619L,6709L,7069L,7159L,7699L,7789L,7879L,8059L,8329L,8419L,8599L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142314Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142314.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142314Inst : IEnumerable<long>
{
public static readonly long[] Value=A142314.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142314.Bytes);
public long this[int i]=>Value[i];

public static A142314Inst Instance=new A142314Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142313
{
public static readonly long[] Value={ 2L,47L,137L,227L,317L,587L,677L,857L,947L,1217L,1307L,1487L,1667L,1847L,2027L,2207L,2297L,2477L,2657L,2837L,2927L,3467L,3557L,3917L,4007L,4457L,4547L,4637L,4817L,5087L,5717L,5807L,5897L,5987L,6257L,6977L,7247L,7517L,7607L,7877L,8147L,8237L,8597L,8867L,9137L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142313Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142313.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142313Inst : IEnumerable<long>
{
public static readonly long[] Value=A142313.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142313.Bytes);
public long this[int i]=>Value[i];

public static A142313Inst Instance=new A142313Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142312
{
public static readonly long[] Value={ 181L,271L,541L,631L,811L,991L,1171L,1531L,1621L,1801L,2161L,2251L,2341L,2521L,2791L,2971L,3061L,3331L,3511L,3691L,4051L,4231L,4591L,4861L,4951L,5581L,5851L,6121L,6211L,6301L,6481L,6571L,6661L,6841L,7561L,7741L,8011L,8101L,8191L,8461L,8641L,8731L,8821L,9001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142312Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142312.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142312Inst : IEnumerable<long>
{
public static readonly long[] Value=A142312.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142312.Bytes);
public long this[int i]=>Value[i];

public static A142312Inst Instance=new A142312Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142263
{
public static readonly long[] Value={ 229L,401L,487L,659L,1433L,1777L,1949L,2207L,2293L,2551L,3067L,3583L,4013L,4099L,4271L,4357L,4787L,5303L,5647L,6163L,6421L,6679L,7109L,7883L,9001L,9173L,9431L,9689L,10463L,10979L,11839L,12011L,12097L,12269L,12527L,12613L,13043L,13903L,14419L,14591L,15107L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142263Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142263.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142263Inst : IEnumerable<long>
{
public static readonly long[] Value=A142263.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142263.Bytes);
public long this[int i]=>Value[i];

public static A142263Inst Instance=new A142263Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142262
{
public static readonly long[] Value={ 13L,271L,443L,701L,787L,1217L,1303L,1733L,2593L,2851L,3023L,3109L,3539L,3797L,4657L,5087L,5431L,5689L,5861L,7151L,7237L,7753L,8011L,8269L,8527L,8699L,9043L,9473L,9817L,10247L,10333L,11279L,12569L,13171L,13687L,13859L,14461L,14633L,14891L,15149L,15493L,15923L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142262Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142262.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142262Inst : IEnumerable<long>
{
public static readonly long[] Value=A142262.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142262.Bytes);
public long this[int i]=>Value[i];

public static A142262Inst Instance=new A142262Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142261
{
public static readonly long[] Value={ 227L,313L,571L,743L,829L,1087L,1259L,1861L,2377L,2549L,3323L,3581L,4441L,4871L,4957L,5387L,5903L,6247L,6763L,7193L,7451L,7537L,8053L,8311L,8741L,8999L,9257L,9343L,9601L,9859L,10289L,10891L,11149L,11321L,11579L,11923L,12611L,12697L,13127L,13729L,13901L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142261Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142261.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142261Inst : IEnumerable<long>
{
public static readonly long[] Value=A142261.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142261.Bytes);
public long this[int i]=>Value[i];

public static A142261Inst Instance=new A142261Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142260
{
public static readonly long[] Value={ 11L,97L,269L,613L,1129L,1301L,1559L,2161L,2333L,2591L,2677L,3623L,3709L,3881L,3967L,4139L,4397L,4483L,4999L,5171L,6203L,6547L,6719L,6977L,7321L,8009L,8353L,8783L,9041L,9127L,9643L,9901L,10159L,10331L,10589L,10847L,11621L,12653L,12739L,12911L,13513L,14029L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142260Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142260.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142260Inst : IEnumerable<long>
{
public static readonly long[] Value=A142260.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142260.Bytes);
public long this[int i]=>Value[i];

public static A142260Inst Instance=new A142260Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142259
{
public static readonly long[] Value={ 53L,139L,311L,397L,569L,827L,1171L,1429L,1601L,2203L,2633L,2719L,3407L,3923L,4783L,5471L,5557L,5987L,6073L,6761L,7019L,7621L,7793L,7879L,9341L,9857L,10459L,10631L,10889L,11491L,12007L,12437L,12781L,12953L,13297L,13469L,14071L,14243L,14759L,15017L,15361L,15619L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142259Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142259.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142259Inst : IEnumerable<long>
{
public static readonly long[] Value=A142259.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142259.Bytes);
public long this[int i]=>Value[i];

public static A142259Inst Instance=new A142259Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142258
{
public static readonly long[] Value={ 181L,353L,439L,1213L,1471L,1901L,1987L,2417L,2503L,3019L,3191L,3449L,3793L,4051L,4481L,4567L,5857L,6029L,6287L,6373L,6803L,7577L,8093L,8179L,8609L,8867L,10243L,10501L,11447L,12049L,12479L,12823L,13339L,13597L,14543L,14629L,14887L,15661L,15919L,16091L,16349L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142258Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142258.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142258Inst : IEnumerable<long>
{
public static readonly long[] Value=A142258.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142258.Bytes);
public long this[int i]=>Value[i];

public static A142258Inst Instance=new A142258Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142257
{
public static readonly long[] Value={ 137L,223L,653L,739L,911L,997L,1427L,2029L,2287L,2459L,2803L,3061L,3319L,3491L,4007L,4093L,4523L,5039L,5297L,5641L,5813L,6329L,6673L,7103L,7877L,7963L,8221L,8737L,9511L,9769L,9941L,10457L,10973L,11059L,11317L,11489L,11833L,12263L,13037L,13381L,13553L,14327L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142257Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142257.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142257Inst : IEnumerable<long>
{
public static readonly long[] Value=A142257.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142257.Bytes);
public long this[int i]=>Value[i];

public static A142257Inst Instance=new A142257Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142256
{
public static readonly long[] Value={ 7L,179L,523L,953L,1039L,1297L,2243L,3361L,3533L,3877L,4049L,4651L,4909L,5081L,5167L,5683L,6113L,6199L,7489L,7919L,8263L,8521L,8693L,8779L,8951L,9209L,9467L,9811L,10069L,10499L,11273L,11617L,11789L,12391L,12821L,12907L,13337L,13681L,14197L,14369L,14627L,14713L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142256Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142256.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142256Inst : IEnumerable<long>
{
public static readonly long[] Value=A142256.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142256.Bytes);
public long this[int i]=>Value[i];

public static A142256Inst Instance=new A142256Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142255
{
public static readonly long[] Value={ 307L,479L,823L,1511L,1597L,2027L,2113L,2371L,2543L,2801L,2887L,3833L,3919L,4091L,4177L,4349L,4951L,5209L,5381L,5639L,5897L,7187L,7703L,7789L,8219L,8563L,8821L,9337L,9767L,10111L,10369L,10627L,10799L,11057L,11831L,12347L,12433L,13121L,13723L,14153L,14411L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142255Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142255.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142255Inst : IEnumerable<long>
{
public static readonly long[] Value=A142255.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142255.Bytes);
public long this[int i]=>Value[i];

public static A142255Inst Instance=new A142255Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142254
{
public static readonly long[] Value={ 5L,263L,349L,521L,607L,1123L,1381L,1553L,1811L,2069L,2671L,2843L,3187L,3359L,3617L,4133L,4219L,4391L,4649L,4993L,5939L,6197L,6971L,7057L,7229L,7487L,7573L,8089L,8863L,9293L,9551L,10067L,11443L,11701L,11959L,12647L,13163L,13249L,13421L,13679L,14281L,14797L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142254Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142254.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142254Inst : IEnumerable<long>
{
public static readonly long[] Value=A142254.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142254.Bytes);
public long this[int i]=>Value[i];

public static A142254Inst Instance=new A142254Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142253
{
public static readonly long[] Value={ 47L,563L,821L,907L,1423L,2111L,2713L,2971L,3229L,3659L,3917L,4003L,4261L,4519L,4691L,5981L,6067L,6841L,7013L,7529L,7873L,8389L,8647L,8819L,9421L,9679L,9851L,10453L,10711L,10883L,11399L,11657L,11743L,12517L,12689L,13033L,13291L,13463L,13721L,13807L,14323L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142253Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142253.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142253Inst : IEnumerable<long>
{
public static readonly long[] Value=A142253.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142253.Bytes);
public long this[int i]=>Value[i];

public static A142253Inst Instance=new A142253Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142252
{
public static readonly long[] Value={ 3L,89L,347L,433L,691L,863L,1637L,1723L,2153L,2239L,2411L,2927L,3271L,3529L,3701L,4217L,4561L,4733L,5077L,5507L,5851L,6367L,6883L,7829L,8087L,8431L,8689L,8861L,9377L,9463L,9721L,10151L,10667L,10753L,11527L,11699L,12043L,12301L,12473L,13591L,13763L,14107L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142252Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142252.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142252Inst : IEnumerable<long>
{
public static readonly long[] Value=A142252.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142252.Bytes);
public long this[int i]=>Value[i];

public static A142252Inst Instance=new A142252Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142251
{
public static readonly long[] Value={ 2L,131L,389L,647L,733L,991L,1163L,1249L,2281L,2539L,2711L,2797L,2969L,3313L,3571L,4001L,4259L,4517L,4603L,4861L,5119L,5807L,6151L,6323L,6581L,7699L,8387L,8731L,9161L,9419L,9677L,10193L,10709L,11311L,11483L,11827L,12343L,12601L,13633L,14149L,14321L,14407L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142251Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142251.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142251Inst : IEnumerable<long>
{
public static readonly long[] Value=A142251.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142251.Bytes);
public long this[int i]=>Value[i];

public static A142251Inst Instance=new A142251Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142250
{
public static readonly long[] Value={ 173L,431L,947L,1033L,1291L,1549L,1721L,1979L,2237L,2753L,3011L,3527L,3613L,4129L,4817L,4903L,5333L,5419L,5591L,5849L,6451L,6709L,6967L,7741L,8171L,8429L,9203L,9461L,9547L,9719L,10321L,10837L,11353L,11783L,12041L,13159L,13331L,13417L,13933L,14449L,14621L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142250Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142250.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142250Inst : IEnumerable<long>
{
public static readonly long[] Value=A142250.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142250.Bytes);
public long this[int i]=>Value[i];

public static A142250Inst Instance=new A142250Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142249
{
public static readonly long[] Value={ -1L,-1L,1L,-1L,2L,-1L,3L,3L,-1L,4L,19L,4L,-1L,5L,80L,65L,5L,-1L,6L,286L,566L,181L,6L,-1L,7L,945L,3710L,2905L,455L,7L,-1L,8L,2997L,20756L,31781L,12636L,1079L,8L,-1L,9L,9294L,105299L,278304L,218559L,49754L,2469L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142249Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142249.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142249Inst : IEnumerable<long>
{
public static readonly long[] Value=A142249.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142249.Bytes);
public long this[int i]=>Value[i];

public static A142249Inst Instance=new A142249Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142248
{
public static readonly long[] Value={ 1L,3L,7L,11L,17L,29L,47L,75L,123L,199L,321L,521L,843L,1363L,2207L,3571L,5777L,9349L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142248Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142248.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142248Inst : IEnumerable<long>
{
public static readonly long[] Value=A142248.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142248.Bytes);
public long this[int i]=>Value[i];

public static A142248Inst Instance=new A142248Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142135
{
public static readonly long[] Value={ 137L,211L,359L,433L,877L,1321L,1543L,1913L,1987L,2357L,2579L,2801L,3023L,3319L,3467L,3541L,3911L,4133L,4651L,4799L,5021L,6131L,6353L,6427L,6871L,7019L,7537L,7759L,7907L,8573L,8647L,9091L,9239L,9461L,10867L,11311L,11681L,11903L,12347L,12421L,12569L,12791L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142135Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142135.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142135Inst : IEnumerable<long>
{
public static readonly long[] Value=A142135.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142135.Bytes);
public long this[int i]=>Value[i];

public static A142135Inst Instance=new A142135Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142134
{
public static readonly long[] Value={ 173L,617L,691L,839L,1061L,1283L,1579L,1801L,1949L,2393L,2467L,2689L,2837L,3947L,4021L,4243L,4391L,4909L,5279L,5501L,6389L,6833L,6907L,7129L,7351L,7499L,7573L,8017L,8387L,8461L,8609L,8831L,9127L,9349L,9497L,9719L,9941L,10163L,10459L,10607L,10903L,11273L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142134Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142134.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142134Inst : IEnumerable<long>
{
public static readonly long[] Value=A142134.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142134.Bytes);
public long this[int i]=>Value[i];

public static A142134Inst Instance=new A142134Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142133
{
public static readonly long[] Value={ 61L,283L,431L,653L,727L,1097L,1171L,1319L,2207L,2281L,2503L,3169L,3391L,3539L,3613L,3761L,4057L,4649L,4723L,4871L,5167L,5981L,6203L,6277L,6869L,7757L,8053L,8423L,8719L,8867L,8941L,9311L,9533L,9829L,10273L,10939L,11087L,11161L,11383L,11827L,12049L,12197L,12641L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142133Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142133.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142133Inst : IEnumerable<long>
{
public static readonly long[] Value=A142133.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142133.Bytes);
public long this[int i]=>Value[i];

public static A142133Inst Instance=new A142133Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142132
{
public static readonly long[] Value={ 23L,97L,467L,541L,911L,1429L,1873L,2243L,2539L,2687L,2909L,3797L,4019L,4093L,4241L,4463L,4759L,5351L,5573L,5647L,5869L,6091L,7127L,7349L,7793L,7867L,8089L,8237L,8311L,8681L,9199L,9421L,9643L,9791L,10457L,10531L,10753L,11197L,11789L,11863L,12011L,12899L,12973L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142132Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142132.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142132Inst : IEnumerable<long>
{
public static readonly long[] Value=A142132.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142132.Bytes);
public long this[int i]=>Value[i];

public static A142132Inst Instance=new A142132Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142131
{
public static readonly long[] Value={ 59L,281L,503L,577L,947L,1021L,1613L,2131L,2797L,3019L,3167L,3389L,3463L,3833L,3907L,4129L,4721L,4943L,5387L,5683L,6053L,6571L,6719L,6793L,7237L,7459L,7607L,7681L,7829L,8273L,9013L,9161L,9679L,9901L,10271L,10567L,10789L,10937L,11159L,11677L,12269L,12343L,12491L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142131Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142131.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142131Inst : IEnumerable<long>
{
public static readonly long[] Value=A142131.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142131.Bytes);
public long this[int i]=>Value[i];

public static A142131Inst Instance=new A142131Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142130
{
public static readonly long[] Value={ 317L,613L,761L,983L,1279L,1427L,1723L,1871L,2389L,2833L,3203L,3499L,3943L,4091L,4831L,5867L,6089L,6163L,6311L,6607L,6829L,6977L,7643L,7717L,8087L,8161L,8753L,9049L,9419L,10159L,10529L,10973L,11047L,11491L,12157L,12379L,12527L,12601L,12823L,13267L,13711L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142130Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142130.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142130Inst : IEnumerable<long>
{
public static readonly long[] Value=A142130.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142130.Bytes);
public long this[int i]=>Value[i];

public static A142130Inst Instance=new A142130Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142129
{
public static readonly long[] Value={ 131L,353L,797L,1019L,1093L,1759L,1907L,2129L,2203L,2351L,2647L,3313L,3461L,4127L,4201L,4349L,4423L,4793L,5237L,5903L,6199L,6421L,6569L,6791L,7013L,7309L,7457L,7753L,7901L,8123L,8419L,8641L,8863L,9011L,9677L,9973L,10343L,10639L,10861L,11083L,11527L,11897L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142129Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142129.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142129Inst : IEnumerable<long>
{
public static readonly long[] Value=A142129.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142129.Bytes);
public long this[int i]=>Value[i];

public static A142129Inst Instance=new A142129Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142128
{
public static readonly long[] Value={ 19L,167L,241L,389L,463L,907L,1129L,1277L,1499L,1721L,2017L,2239L,2609L,2683L,3571L,3719L,3793L,4903L,5051L,5273L,5347L,5569L,5717L,5791L,5939L,6679L,6827L,7789L,7937L,8011L,8233L,8677L,9343L,9491L,9787L,10009L,10453L,10601L,11119L,11489L,11933L,12007L,12377L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142128Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142128.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142128Inst : IEnumerable<long>
{
public static readonly long[] Value=A142128.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142128.Bytes);
public long this[int i]=>Value[i];

public static A142128Inst Instance=new A142128Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142127
{
public static readonly long[] Value={ 277L,499L,647L,1091L,1609L,1831L,1979L,2053L,2423L,2719L,3089L,3163L,3533L,3607L,4051L,4273L,4421L,4643L,5087L,5309L,5531L,5827L,6197L,6271L,6863L,7159L,7307L,7529L,7603L,8269L,8713L,8861L,9157L,9601L,9749L,10193L,10267L,10711L,10859L,11821L,11969L,12043L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142127Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142127.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142127Inst : IEnumerable<long>
{
public static readonly long[] Value=A142127.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142127.Bytes);
public long this[int i]=>Value[i];

public static A142127Inst Instance=new A142127Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142126
{
public static readonly long[] Value={ 17L,239L,313L,461L,683L,757L,1201L,1423L,1571L,1867L,2089L,2237L,2311L,2459L,2903L,3347L,3643L,4013L,4457L,4679L,5197L,5419L,5641L,6011L,6529L,6899L,7121L,7417L,7639L,8009L,8231L,8527L,8971L,9341L,9859L,10007L,10303L,11117L,11783L,12227L,12301L,12671L,12893L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142126Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142126.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142126Inst : IEnumerable<long>
{
public static readonly long[] Value=A142126.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142126.Bytes);
public long this[int i]=>Value[i];

public static A142126Inst Instance=new A142126Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142125
{
public static readonly long[] Value={ 53L,127L,349L,571L,719L,941L,1163L,1237L,1459L,1607L,2273L,2347L,2791L,2939L,3457L,4049L,4271L,4493L,4567L,4789L,4937L,5011L,5233L,5381L,6047L,6121L,6269L,6343L,6491L,7823L,8563L,8933L,9007L,9377L,10487L,10709L,11597L,12041L,12263L,12781L,13003L,13151L,13669L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142125Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142125.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142125Inst : IEnumerable<long>
{
public static readonly long[] Value=A142125.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142125.Bytes);
public long this[int i]=>Value[i];

public static A142125Inst Instance=new A142125Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142124
{
public static readonly long[] Value={ 89L,163L,311L,607L,829L,977L,1051L,2087L,2161L,2309L,2383L,2531L,2753L,3049L,3271L,3863L,4159L,4603L,4751L,4973L,5417L,5639L,5861L,6379L,6823L,6971L,7193L,7489L,7933L,8081L,8377L,8599L,8747L,8821L,8969L,9043L,9413L,9857L,9931L,10079L,10301L,10597L,11411L,11633L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142124Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142124.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142124Inst : IEnumerable<long>
{
public static readonly long[] Value=A142124.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142124.Bytes);
public long this[int i]=>Value[i];

public static A142124Inst Instance=new A142124Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142123
{
public static readonly long[] Value={ 199L,347L,421L,569L,643L,1013L,1087L,1531L,1753L,1901L,2789L,3011L,3307L,3529L,3677L,4639L,4787L,4861L,5009L,5231L,5527L,5749L,5897L,6563L,6637L,7229L,7451L,7673L,8117L,8191L,8783L,9227L,9967L,10337L,10559L,10781L,11003L,11299L,11447L,11743L,12113L,12409L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142123Inst : IEnumerable<long>
{
public static readonly long[] Value=A142123.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142123.Bytes);
public long this[int i]=>Value[i];

public static A142123Inst Instance=new A142123Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142122
{
public static readonly long[] Value={ 13L,383L,457L,827L,1049L,1123L,1493L,1567L,1789L,2011L,2381L,2677L,3121L,3343L,3491L,4157L,4231L,5119L,5563L,5711L,6007L,6229L,6451L,6599L,6673L,7043L,7487L,7561L,8597L,8819L,8893L,9041L,9337L,9781L,9929L,10151L,10891L,11113L,11261L,11483L,11779L,11927L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142122Inst : IEnumerable<long>
{
public static readonly long[] Value=A142122.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142122.Bytes);
public long this[int i]=>Value[i];

public static A142122Inst Instance=new A142122Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142121
{
public static readonly long[] Value={ 197L,271L,419L,641L,863L,937L,1307L,1381L,1973L,2269L,2417L,2713L,2861L,3083L,3527L,3823L,4637L,4933L,5081L,5303L,5821L,6043L,6709L,6857L,7079L,7523L,8263L,8707L,8929L,9151L,9521L,9743L,9817L,10039L,10631L,10853L,11149L,11519L,11593L,12037L,12703L,13147L,13591L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142121Inst : IEnumerable<long>
{
public static readonly long[] Value=A142121.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142121.Bytes);
public long this[int i]=>Value[i];

public static A142121Inst Instance=new A142121Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142120
{
public static readonly long[] Value={ 11L,233L,307L,677L,751L,1787L,1861L,2083L,2749L,2897L,2971L,3119L,3637L,4007L,4229L,4451L,4673L,4969L,5413L,5783L,5857L,6079L,6301L,6449L,6967L,7411L,7559L,8447L,8521L,8669L,9187L,9631L,10223L,10667L,10889L,11777L,12073L,12517L,12739L,13109L,13183L,13331L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142120Inst : IEnumerable<long>
{
public static readonly long[] Value=A142120.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142120.Bytes);
public long this[int i]=>Value[i];

public static A142120Inst Instance=new A142120Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142071
{
public static readonly long[] Value={ 0L,1L,0L,1L,1L,0L,1L,3L,2L,0L,1L,7L,12L,6L,0L,1L,15L,50L,60L,24L,0L,1L,31L,180L,390L,360L,120L,0L,1L,63L,602L,2100L,3360L,2520L,720L,0L,1L,127L,1932L,10206L,25200L,31920L,20160L,5040L,0L,1L,255L,6050L,46620L,166824L,317520L,332640L,181440L,40320L,0L,1L,511L,18660L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142071Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142071.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142071Inst : IEnumerable<long>
{
public static readonly long[] Value=A142071.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142071.Bytes);
public long this[int i]=>Value[i];

public static A142071Inst Instance=new A142071Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142070
{
public static readonly long[] Value={ 1L,-1L,2L,2L,-7L,6L,-6L,29L,-46L,24L,24L,-146L,329L,-326L,120L,-120L,874L,-2521L,3604L,-2556L,720L,720L,-6084L,21244L,-39271L,40564L,-22212L,5040L,-5040L,48348L,-197380L,444849L,-598116L,479996L,-212976L,40320L,40320L,-432144L,2014172L,-5335212L,8788569L,-9223012L,6023772L,-2239344L,362880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142070Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142070.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142070Inst : IEnumerable<long>
{
public static readonly long[] Value=A142070.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142070.Bytes);
public long this[int i]=>Value[i];

public static A142070Inst Instance=new A142070Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142069
{
public static readonly long[] Value={ 3L,7L,2L,6L,1L,5L,0L,4L,8L,3L,7L,2L,6L,1L,5L,0L,4L,8L,3L,7L,2L,6L,1L,5L,0L,4L,8L,3L,7L,2L,6L,1L,5L,0L,4L,8L,3L,7L,2L,6L,1L,5L,0L,4L,8L,3L,7L,2L,6L,1L,5L,0L,4L,8L,3L,7L,2L,6L,1L,5L,0L,4L,8L,3L,7L,2L,6L,1L,5L,0L,4L,8L,3L,7L,2L,6L,1L,5L,0L,4L,8L,3L,7L,2L,6L,1L,5L,0L,4L,8L,3L,7L,2L,6L,1L,5L,0L,4L,8L,3L,7L,2L,6L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142069Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142069.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142069Inst : IEnumerable<long>
{
public static readonly long[] Value=A142069.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142069.Bytes);
public long this[int i]=>Value[i];

public static A142069Inst Instance=new A142069Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142068
{
public static readonly long[] Value={ 131L,197L,263L,461L,593L,659L,857L,1187L,1319L,1451L,1583L,1847L,1913L,1979L,2111L,2243L,2309L,2441L,2837L,2903L,2969L,3167L,3299L,3761L,4091L,4157L,4289L,4421L,4751L,4817L,5081L,5147L,5279L,5477L,5741L,5807L,5939L,6203L,6269L,6599L,6863L,7127L,7193L,7457L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142068Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142068.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142068Inst : IEnumerable<long>
{
public static readonly long[] Value=A142068.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142068.Bytes);
public long this[int i]=>Value[i];

public static A142068Inst Instance=new A142068Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142067
{
public static readonly long[] Value={ 31L,97L,163L,229L,691L,757L,823L,1021L,1087L,1153L,1483L,1549L,1747L,1879L,2011L,2143L,2341L,2473L,2539L,2671L,2803L,3001L,3067L,3331L,3463L,3529L,3727L,3793L,4057L,4519L,4651L,4783L,5113L,5179L,5443L,5641L,5839L,6037L,6301L,6367L,6763L,6829L,6961L,7027L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142067Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142067.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142067Inst : IEnumerable<long>
{
public static readonly long[] Value=A142067.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142067.Bytes);
public long this[int i]=>Value[i];

public static A142067Inst Instance=new A142067Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142066
{
public static readonly long[] Value={ 29L,227L,293L,359L,491L,557L,821L,887L,953L,1019L,1151L,1217L,1283L,1481L,1613L,1811L,1877L,2141L,2207L,2273L,2339L,2801L,2999L,3329L,3461L,3527L,3593L,3659L,3923L,3989L,4253L,4451L,4517L,4583L,4649L,5309L,5441L,5507L,5573L,5639L,5903L,6101L,6299L,6563L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142066Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142066.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142066Inst : IEnumerable<long>
{
public static readonly long[] Value=A142066.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142066.Bytes);
public long this[int i]=>Value[i];

public static A142066Inst Instance=new A142066Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142065
{
public static readonly long[] Value={ 61L,127L,193L,457L,523L,787L,853L,919L,1051L,1117L,1249L,1381L,1447L,1579L,1777L,2239L,2371L,2437L,2503L,2767L,2833L,3163L,3229L,3361L,3559L,3691L,3823L,3889L,4021L,4153L,4219L,4483L,4549L,4813L,5011L,5077L,5209L,5407L,5737L,5869L,6067L,6133L,6199L,6397L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142065Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142065.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142065Inst : IEnumerable<long>
{
public static readonly long[] Value=A142065.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142065.Bytes);
public long this[int i]=>Value[i];

public static A142065Inst Instance=new A142065Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142064
{
public static readonly long[] Value={ 59L,191L,257L,389L,521L,587L,653L,719L,983L,1049L,1181L,1511L,1709L,1907L,1973L,2039L,2237L,2633L,2699L,2897L,2963L,3359L,3491L,3557L,3623L,3821L,4019L,4217L,4283L,4349L,4481L,4547L,4679L,4877L,4943L,5009L,5273L,5471L,5669L,5801L,5867L,6131L,6197L,6263L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142064Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142064.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142064Inst : IEnumerable<long>
{
public static readonly long[] Value=A142064.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142064.Bytes);
public long this[int i]=>Value[i];

public static A142064Inst Instance=new A142064Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142063
{
public static readonly long[] Value={ 157L,223L,421L,487L,619L,751L,883L,1213L,1279L,1543L,1609L,1741L,1873L,2137L,2203L,2269L,2467L,2731L,2797L,3061L,3259L,3391L,3457L,3853L,3919L,4051L,4447L,4513L,4909L,5107L,5437L,5503L,5569L,5701L,6163L,6229L,6361L,6427L,6691L,6823L,7219L,7351L,7417L,7549L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142063Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142063.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142063Inst : IEnumerable<long>
{
public static readonly long[] Value=A142063.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142063.Bytes);
public long this[int i]=>Value[i];

public static A142063Inst Instance=new A142063Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142062
{
public static readonly long[] Value={ 23L,89L,353L,419L,617L,683L,881L,947L,1013L,1277L,1409L,1607L,1871L,2003L,2069L,2267L,2333L,2399L,2531L,2663L,2729L,2861L,2927L,3191L,3257L,3323L,3389L,3719L,3851L,3917L,4049L,4643L,4973L,5039L,5171L,5237L,5303L,5501L,5897L,6029L,6359L,6491L,6689L,7019L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142062Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142062.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142062Inst : IEnumerable<long>
{
public static readonly long[] Value=A142062.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142062.Bytes);
public long this[int i]=>Value[i];

public static A142062Inst Instance=new A142062Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142061
{
public static readonly long[] Value={ 53L,251L,317L,383L,449L,647L,911L,977L,1109L,1307L,1373L,1439L,1571L,1637L,1901L,2099L,2297L,2693L,2957L,3023L,3089L,3221L,3617L,3881L,3947L,4013L,4079L,4211L,4409L,4673L,4871L,4937L,5003L,5333L,5399L,5531L,5861L,5927L,6257L,6323L,6389L,6521L,6653L,6719L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142061Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142061.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142061Inst : IEnumerable<long>
{
public static readonly long[] Value=A142061.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142061.Bytes);
public long this[int i]=>Value[i];

public static A142061Inst Instance=new A142061Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142060
{
public static readonly long[] Value={ 19L,151L,283L,349L,547L,613L,811L,877L,1009L,1471L,1669L,1801L,1867L,1933L,1999L,2131L,2593L,2659L,2791L,2857L,3121L,3187L,3253L,3319L,3517L,3583L,3847L,4111L,4177L,4243L,4441L,4507L,4639L,4903L,4969L,5101L,5167L,5233L,5431L,5563L,5827L,6091L,6421L,6553L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142060Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142060.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142060Inst : IEnumerable<long>
{
public static readonly long[] Value=A142060.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142060.Bytes);
public long this[int i]=>Value[i];

public static A142060Inst Instance=new A142060Inst();

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