using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A248662
{
public static readonly long[] Value={ 120L,144L,180L,216L,240L,252L,288L,300L,336L,360L,420L,432L,480L,504L,540L,576L,600L,630L,648L,660L,672L,720L,756L,792L,810L,840L,864L,900L,960L,1008L,1050L,1080L,1120L,1152L,1176L,1200L,1260L,1296L,1320L,1344L,1350L,1400L,1440L,1500L,1512L,1560L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248662Inst : IEnumerable<long>
{
public static readonly long[] Value=A248662.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248662.Bytes);
public long this[int i]=>Value[i];

public static A248662Inst Instance=new A248662Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248663
{
public static readonly long[] Value={ 0L,1L,2L,0L,4L,3L,8L,1L,0L,5L,16L,2L,32L,9L,6L,0L,64L,1L,128L,4L,10L,17L,256L,3L,0L,33L,2L,8L,512L,7L,1024L,1L,18L,65L,12L,0L,2048L,129L,34L,5L,4096L,11L,8192L,16L,4L,257L,16384L,2L,0L,1L,66L,32L,32768L,3L,20L,9L,130L,513L,65536L,6L,131072L,1025L,8L,0L,36L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248663Inst : IEnumerable<long>
{
public static readonly long[] Value=A248663.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248663.Bytes);
public long this[int i]=>Value[i];

public static A248663Inst Instance=new A248663Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248664
{
public static readonly long[] Value={ 1L,2L,2L,5L,12L,9L,16L,68L,112L,64L,65L,420L,1125L,1375L,625L,326L,2910L,11124L,21600L,20736L,7776L,1957L,22652L,114611L,311787L,470596L,369754L,117649L,13700L,196872L,1254976L,4455424L,9342976L,11468800L,7602176L,2097152L,109601L,1895148L,14699961L,65045025L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248664Inst : IEnumerable<long>
{
public static readonly long[] Value=A248664.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248664.Bytes);
public long this[int i]=>Value[i];

public static A248664Inst Instance=new A248664Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248665
{
public static readonly long[] Value={ 1L,2L,2L,9L,12L,5L,64L,112L,68L,16L,625L,1375L,1125L,420L,65L,7776L,20736L,21600L,11124L,2910L,326L,117649L,369754L,470596L,311787L,114611L,22652L,1957L,2097152L,7602176L,11468800L,9342976L,4455424L,1254976L,196872L,13700L,43046721L,176969853L,309298662L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248665Inst : IEnumerable<long>
{
public static readonly long[] Value=A248665.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248665.Bytes);
public long this[int i]=>Value[i];

public static A248665Inst Instance=new A248665Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248666
{
public static readonly long[] Value={ 1L,2L,1L,4L,5L,2L,1L,4L,1L,10L,1L,4L,13L,2L,5L,4L,1L,2L,1L,20L,1L,2L,1L,4L,5L,26L,1L,4L,1L,10L,1L,4L,1L,2L,5L,4L,37L,2L,13L,20L,1L,2L,1L,4L,5L,2L,1L,4L,1L,10L,1L,52L,1L,2L,5L,4L,1L,2L,1L,20L,1L,2L,1L,4L,65L,2L,1L,4L,1L,10L,1L,4L,1L,74L,5L,4L,1L,26L,1L,20L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248666Inst : IEnumerable<long>
{
public static readonly long[] Value=A248666.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248666.Bytes);
public long this[int i]=>Value[i];

public static A248666Inst Instance=new A248666Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248667
{
public static readonly long[] Value={ 1L,3L,7L,9L,11L,17L,19L,21L,23L,27L,29L,31L,33L,41L,43L,47L,49L,51L,53L,57L,59L,61L,63L,67L,69L,71L,73L,77L,79L,81L,83L,87L,89L,93L,97L,99L,101L,103L,107L,109L,113L,119L,121L,123L,127L,129L,131L,133L,137L,139L,141L,147L,149L,151L,153L,157L,159L,161L,163L,167L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248667Inst : IEnumerable<long>
{
public static readonly long[] Value=A248667.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248667.Bytes);
public long this[int i]=>Value[i];

public static A248667Inst Instance=new A248667Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248668
{
public static readonly BigInteger[] Value={ 1L,4L,26L,260L,3610L,64472L,1409006L,36432076L,1087911890L,36844580000L,1395429571222L,58439837713556L,2681526361893626L,133783187672365480L,7210345924097089790L,BigInteger.Parse("417482356526745344732"),BigInteger.Parse("25844171201928905477026"),BigInteger.Parse("1703359919973405018460976") };
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
public class A248668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248668Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A248668.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A248668.Bytes);
public BigInteger this[int i]=>Value[i];

public static A248668Inst Instance=new A248668Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248669
{
public static readonly long[] Value={ 1L,2L,1L,5L,4L,1L,16L,17L,7L,1L,65L,84L,45L,11L,1L,326L,485L,309L,100L,16L,1L,1957L,3236L,2339L,909L,196L,22L,1L,13700L,24609L,19609L,8702L,2281L,350L,29L,1L,109601L,210572L,181481L,89225L,26950L,5081L,582L,37L,1L,986410L,2004749L,1843901L,984506L,331775L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248669Inst : IEnumerable<long>
{
public static readonly long[] Value=A248669.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248669.Bytes);
public long this[int i]=>Value[i];

public static A248669Inst Instance=new A248669Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248670
{
public static readonly long[] Value={ 1L,1L,2L,1L,4L,5L,1L,7L,17L,16L,1L,11L,45L,84L,65L,1L,16L,100L,309L,485L,326L,1L,22L,196L,909L,2339L,3236L,1957L,1L,29L,350L,2281L,8702L,19609L,24609L,13700L,1L,37L,582L,5081L,26950L,89225L,181481L,210572L,109601L,1L,46L,915L,10319L,72679L,331775L,984506L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248670Inst : IEnumerable<long>
{
public static readonly long[] Value=A248670.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248670.Bytes);
public long this[int i]=>Value[i];

public static A248670Inst Instance=new A248670Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248671
{
public static readonly long[] Value={ 1L,4L,5L,4L,7L,15L,9L,4L,5L,21L,13L,15L,15L,27L,27L,4L,19L,15L,21L,21L,35L,39L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248671Inst : IEnumerable<long>
{
public static readonly long[] Value=A248671.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248671.Bytes);
public long this[int i]=>Value[i];

public static A248671Inst Instance=new A248671Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248672
{
public static readonly long[] Value={ 2L,4L,1L,1L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248672Inst : IEnumerable<long>
{
public static readonly long[] Value=A248672.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248672.Bytes);
public long this[int i]=>Value[i];

public static A248672Inst Instance=new A248672Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248673
{
public static readonly long[] Value={ 2L,0L,1L,8L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248673Inst : IEnumerable<long>
{
public static readonly long[] Value=A248673.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248673.Bytes);
public long this[int i]=>Value[i];

public static A248673Inst Instance=new A248673Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248674
{
public static readonly long[] Value={ 1L,7L,9L,7L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248674Inst : IEnumerable<long>
{
public static readonly long[] Value=A248674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248674.Bytes);
public long this[int i]=>Value[i];

public static A248674Inst Instance=new A248674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248675
{
public static readonly long[] Value={ 2L,7L,7L,6L,8L,8L,9L,6L,0L,9L,4L,0L,7L,9L,7L,9L,7L,2L,6L,9L,8L,1L,2L,4L,5L,1L,6L,3L,6L,1L,7L,1L,8L,8L,0L,6L,1L,8L,5L,3L,8L,4L,9L,8L,3L,6L,6L,5L,0L,9L,6L,1L,3L,1L,1L,3L,2L,7L,0L,5L,7L,5L,0L,9L,5L,9L,6L,1L,1L,0L,3L,8L,8L,4L,9L,9L,5L,2L,2L,6L,7L,1L,0L,8L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248675Inst : IEnumerable<long>
{
public static readonly long[] Value=A248675.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248675.Bytes);
public long this[int i]=>Value[i];

public static A248675Inst Instance=new A248675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248676
{
public static readonly long[] Value={ 2L,7L,1L,9L,9L,0L,9L,2L,6L,5L,4L,9L,0L,8L,5L,3L,8L,3L,4L,2L,1L,3L,2L,2L,2L,8L,6L,5L,2L,2L,4L,5L,2L,5L,2L,1L,1L,9L,3L,3L,1L,0L,0L,7L,6L,0L,4L,8L,4L,7L,1L,6L,7L,2L,7L,5L,0L,8L,5L,8L,8L,5L,5L,8L,9L,5L,9L,7L,4L,1L,7L,4L,6L,6L,1L,0L,2L,9L,5L,5L,8L,4L,9L,5L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248676Inst : IEnumerable<long>
{
public static readonly long[] Value=A248676.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248676.Bytes);
public long this[int i]=>Value[i];

public static A248676Inst Instance=new A248676Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248677
{
public static readonly long[] Value={ 2L,7L,1L,8L,3L,0L,9L,6L,9L,7L,7L,0L,7L,2L,4L,5L,6L,1L,8L,3L,3L,0L,4L,0L,8L,2L,7L,6L,3L,6L,1L,8L,7L,3L,4L,7L,9L,6L,2L,8L,7L,6L,1L,1L,1L,3L,3L,9L,4L,8L,9L,6L,3L,4L,3L,2L,0L,6L,4L,4L,2L,4L,2L,6L,1L,7L,4L,1L,3L,1L,3L,5L,4L,3L,9L,1L,2L,8L,2L,4L,3L,8L,1L,9L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248677Inst : IEnumerable<long>
{
public static readonly long[] Value=A248677.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248677.Bytes);
public long this[int i]=>Value[i];

public static A248677Inst Instance=new A248677Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248678
{
public static readonly long[] Value={ 3L,0L,1L,0L,1L,4L,4L,8L,5L,3L,9L,9L,1L,0L,5L,2L,3L,2L,1L,9L,1L,1L,6L,4L,6L,1L,4L,8L,7L,6L,7L,7L,3L,2L,7L,6L,3L,9L,3L,1L,8L,3L,7L,7L,0L,2L,6L,1L,7L,5L,6L,1L,1L,0L,7L,9L,9L,7L,1L,8L,8L,1L,1L,9L,5L,6L,5L,8L,4L,9L,3L,9L,2L,1L,4L,0L,5L,0L,9L,3L,5L,7L,5L,6L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248678Inst : IEnumerable<long>
{
public static readonly long[] Value=A248678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248678.Bytes);
public long this[int i]=>Value[i];

public static A248678Inst Instance=new A248678Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248679
{
public static readonly long[] Value={ 1L,8L,0L,3L,4L,0L,2L,9L,9L,9L,1L,6L,7L,8L,2L,3L,8L,6L,9L,4L,4L,5L,0L,3L,0L,4L,8L,0L,4L,6L,7L,8L,6L,9L,4L,8L,3L,4L,5L,3L,1L,7L,1L,6L,0L,2L,8L,2L,7L,3L,9L,9L,4L,2L,3L,5L,8L,5L,9L,1L,4L,1L,2L,2L,9L,9L,0L,9L,4L,1L,6L,5L,0L,3L,9L,7L,3L,7L,8L,0L,1L,8L,7L,0L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248679Inst : IEnumerable<long>
{
public static readonly long[] Value=A248679.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248679.Bytes);
public long this[int i]=>Value[i];

public static A248679Inst Instance=new A248679Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248680
{
public static readonly long[] Value={ 6L,2L,0L,7L,2L,4L,8L,0L,5L,2L,6L,7L,5L,5L,8L,6L,2L,0L,5L,4L,2L,5L,0L,0L,8L,5L,5L,6L,0L,7L,7L,0L,3L,7L,8L,1L,6L,8L,0L,5L,3L,1L,8L,2L,2L,0L,7L,2L,4L,3L,7L,7L,9L,5L,6L,4L,9L,0L,0L,7L,6L,8L,3L,3L,4L,6L,2L,2L,7L,0L,2L,3L,0L,0L,2L,2L,5L,9L,0L,2L,4L,4L,9L,9L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248680Inst : IEnumerable<long>
{
public static readonly long[] Value=A248680.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248680.Bytes);
public long this[int i]=>Value[i];

public static A248680Inst Instance=new A248680Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248681
{
public static readonly long[] Value={ 1L,0L,6L,0L,9L,2L,6L,9L,2L,9L,5L,2L,5L,0L,4L,5L,2L,6L,7L,4L,9L,4L,0L,4L,7L,0L,0L,6L,2L,4L,4L,1L,3L,0L,8L,8L,0L,9L,2L,7L,1L,1L,9L,8L,6L,5L,9L,6L,9L,4L,7L,3L,4L,5L,7L,3L,6L,2L,0L,7L,4L,5L,3L,3L,4L,9L,8L,0L,4L,1L,0L,6L,6L,9L,8L,8L,5L,7L,2L,4L,9L,4L,8L,3L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248681Inst : IEnumerable<long>
{
public static readonly long[] Value=A248681.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248681.Bytes);
public long this[int i]=>Value[i];

public static A248681Inst Instance=new A248681Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248682
{
public static readonly long[] Value={ 2L,9L,4L,5L,5L,9L,9L,4L,3L,4L,8L,7L,4L,8L,6L,0L,3L,1L,1L,6L,3L,9L,1L,8L,0L,6L,7L,3L,4L,5L,9L,6L,9L,3L,9L,8L,4L,2L,5L,2L,5L,0L,3L,3L,3L,1L,6L,3L,7L,9L,9L,1L,6L,2L,2L,7L,2L,8L,7L,8L,6L,6L,0L,9L,2L,3L,3L,8L,8L,7L,2L,7L,2L,1L,1L,2L,3L,1L,4L,5L,6L,3L,2L,7L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248682Inst : IEnumerable<long>
{
public static readonly long[] Value=A248682.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248682.Bytes);
public long this[int i]=>Value[i];

public static A248682Inst Instance=new A248682Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248683
{
public static readonly long[] Value={ 2L,7L,3L,0L,2L,5L,6L,3L,7L,6L,9L,6L,3L,3L,6L,1L,3L,8L,5L,8L,0L,4L,9L,8L,3L,2L,7L,4L,4L,7L,7L,1L,9L,7L,6L,2L,7L,1L,9L,7L,1L,2L,4L,1L,6L,3L,0L,1L,5L,9L,6L,2L,6L,9L,3L,2L,7L,0L,5L,2L,5L,1L,6L,3L,7L,6L,0L,2L,6L,1L,9L,7L,5L,9L,1L,8L,6L,8L,3L,7L,1L,4L,6L,1L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248683Inst : IEnumerable<long>
{
public static readonly long[] Value=A248683.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248683.Bytes);
public long this[int i]=>Value[i];

public static A248683Inst Instance=new A248683Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248684
{
public static readonly long[] Value={ 2L,7L,1L,8L,7L,0L,2L,6L,4L,1L,9L,1L,0L,8L,5L,1L,4L,9L,7L,0L,8L,6L,7L,5L,2L,2L,0L,0L,2L,8L,7L,7L,5L,6L,6L,2L,1L,8L,3L,3L,6L,8L,3L,4L,7L,2L,3L,1L,0L,3L,5L,9L,5L,2L,9L,5L,3L,3L,5L,0L,8L,1L,7L,4L,0L,3L,4L,9L,4L,7L,0L,0L,8L,4L,4L,5L,0L,8L,3L,5L,1L,0L,9L,9L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248684Inst : IEnumerable<long>
{
public static readonly long[] Value=A248684.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248684.Bytes);
public long this[int i]=>Value[i];

public static A248684Inst Instance=new A248684Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248685
{
public static readonly long[] Value={ 2L,7L,1L,8L,2L,9L,1L,2L,2L,4L,2L,3L,9L,0L,5L,7L,3L,5L,4L,9L,9L,9L,2L,3L,6L,6L,9L,6L,8L,5L,8L,6L,5L,3L,7L,4L,9L,7L,8L,5L,2L,7L,3L,8L,7L,5L,9L,3L,5L,3L,5L,5L,7L,3L,1L,0L,3L,5L,4L,8L,0L,2L,5L,8L,5L,2L,4L,8L,6L,7L,0L,4L,8L,1L,6L,0L,6L,6L,5L,8L,2L,0L,8L,7L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248685Inst : IEnumerable<long>
{
public static readonly long[] Value=A248685.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248685.Bytes);
public long this[int i]=>Value[i];

public static A248685Inst Instance=new A248685Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248686
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,6L,1L,6L,12L,24L,1L,10L,30L,60L,120L,1L,20L,90L,180L,360L,720L,1L,35L,210L,630L,1260L,2520L,5040L,1L,70L,560L,2520L,5040L,10080L,20160L,40320L,1L,126L,1680L,7560L,22680L,45360L,90720L,181440L,362880L,1L,252L,4200L,25200L,113400L,226800L,453600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248686Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248686.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248686Inst : IEnumerable<long>
{
public static readonly long[] Value=A248686.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248686.Bytes);
public long this[int i]=>Value[i];

public static A248686Inst Instance=new A248686Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248687
{
public static readonly BigInteger[] Value={ 1L,3L,10L,43L,221L,1371L,9696L,78751L,712447L,7173853L,79106413L,952587175L,12397677007L,173864946685L,2609479384942L,41786786069887L,710577455524223L,12795789975272877L,243154034699436147L,4864103085730989101L,BigInteger.Parse("102153340062463300261"),BigInteger.Parse("2247608818115460466681") };
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
public class A248687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248687Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A248687.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A248687.Bytes);
public BigInteger this[int i]=>Value[i];

public static A248687Inst Instance=new A248687Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248688
{
public static readonly long[] Value={ 50L,40L,27L,36L,34L,24L,21L,4L,31L,24L,22L,25L,29L,36L,10L,13L,10L,42L,150L,31L,12L,8L,66L,52L,5L,48L,12L,14L,3L,9L,1L,4L,7L,3L,3L,3L,2L,14L,4L,28L,16L,24L,21L,28L,16L,16L,13L,6L,6L,4L,4L,5L,3L,6L,4L,3L,1L,13L,5L,5L,3L,5L,1L,1L,1L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248688Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248688.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248688Inst : IEnumerable<long>
{
public static readonly long[] Value=A248688.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248688.Bytes);
public long this[int i]=>Value[i];

public static A248688Inst Instance=new A248688Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248689
{
public static readonly long[] Value={ 1533L,1213L,859L,1288L,959L,658L,618L,85L,810L,695L,816L,719L,942L,822L,280L,406L,167L,1070L,2461L,915L,222L,117L,1292L,1364L,154L,1273L,357L,197L,73L,146L,21L,48L,105L,47L,56L,53L,38L,211L,55L,1071L,678L,1151L,879L,1007L,433L,437L,257L,149L,155L,104L,95L,89L,47L,113L,83L,46L,25L,303L,108L,105L,61L,105L,13L,14L,25L,404L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248689Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248689.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248689Inst : IEnumerable<long>
{
public static readonly long[] Value=A248689.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248689.Bytes);
public long this[int i]=>Value[i];

public static A248689Inst Instance=new A248689Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248690
{
public static readonly long[] Value={ 38262L,32685L,24541L,32896L,28352L,18854L,18966L,2574L,25048L,20600L,24513L,23517L,20365L,26069L,7440L,10480L,5633L,18098L,42704L,15038L,5579L,2658L,37036L,42654L,3411L,39401L,11602L,5174L,2033L,4216L,669L,1320L,3152L,1284L,1475L,1616L,1130L,6443L,1781L,23343L,14949L,25640L,18658L,24229L,9422L,9462L,6046L,3084L,3022L,2183L,1979L,1837L,1022L,2244L,1666L,896L,430L,6897L,2304L,2476L,1553L,2517L,298L,294L,608L,11952L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248690Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248690.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248690Inst : IEnumerable<long>
{
public static readonly long[] Value=A248690.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248690.Bytes);
public long this[int i]=>Value[i];

public static A248690Inst Instance=new A248690Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248691
{
public static readonly long[] Value={ 151839L,131764L,98919L,137870L,113983L,78363L,76833L,9999L,100194L,82477L,98688L,93612L,86607L,109280L,31701L,44697L,23736L,73238L,173948L,62668L,21968L,10540L,150959L,174337L,14165L,160026L,48436L,21119L,8357L,16985L,2818L,5087L,12716L,5421L,6209L,6640L,4400L,25547L,7124L,96630L,61319L,104286L,75497L,101700L,39285L,37936L,24958L,12646L,12822L,9029L,8418L,7542L,4275L,10062L,7246L,4067L,1817L,29322L,9432L,10587L,6937L,9849L,1204L,1250L,2811L,48240L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248691Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248691.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248691Inst : IEnumerable<long>
{
public static readonly long[] Value=A248691.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248691.Bytes);
public long this[int i]=>Value[i];

public static A248691Inst Instance=new A248691Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248692
{
public static readonly long[] Value={ 1L,2L,4L,4L,8L,8L,16L,8L,16L,16L,32L,16L,64L,32L,32L,16L,128L,32L,256L,32L,64L,64L,512L,32L,64L,128L,64L,64L,1024L,64L,2048L,32L,128L,256L,128L,64L,4096L,512L,256L,64L,8192L,128L,16384L,128L,128L,1024L,32768L,64L,256L,128L,512L,256L,65536L,128L,256L,128L,1024L,2048L,131072L,128L,262144L,4096L,256L,64L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248692Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248692.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248692Inst : IEnumerable<long>
{
public static readonly long[] Value=A248692.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248692.Bytes);
public long this[int i]=>Value[i];

public static A248692Inst Instance=new A248692Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248693
{
public static readonly long[] Value={ 24L,30L,36L,40L,48L,54L,60L,72L,80L,84L,90L,96L,100L,102L,108L,112L,120L,126L,132L,140L,144L,150L,156L,160L,162L,168L,176L,180L,192L,198L,200L,204L,208L,210L,216L,220L,224L,228L,234L,240L,252L,260L,264L,270L,272L,276L,280L,288L,294L,300L,306L,308L,312L,320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248693Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248693.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248693Inst : IEnumerable<long>
{
public static readonly long[] Value=A248693.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248693.Bytes);
public long this[int i]=>Value[i];

public static A248693Inst Instance=new A248693Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248694
{
public static readonly long[] Value={ 1575L,2835L,3465L,4095L,4725L,5355L,5775L,5985L,6435L,6615L,6825L,7245L,7875L,8085L,8505L,9135L,9765L,10395L,11025L,11655L,12285L,12705L,12915L,13545L,14175L,14805L,15015L,15435L,16065L,16695L,17325L,17955L,18585L,19215L,19305L,19635L,19845L,20475L,21105L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248694Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248694.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248694Inst : IEnumerable<long>
{
public static readonly long[] Value=A248694.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248694.Bytes);
public long this[int i]=>Value[i];

public static A248694Inst Instance=new A248694Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248695
{
public static readonly long[] Value={ 2L,9L,2L,4L,9L,9L,2L,7L,8L,7L,4L,3L,1L,2L,8L,5L,5L,1L,4L,5L,0L,0L,1L,5L,6L,0L,9L,4L,1L,7L,4L,4L,2L,4L,0L,1L,3L,2L,8L,9L,9L,8L,3L,9L,3L,1L,0L,2L,2L,9L,3L,1L,2L,1L,8L,0L,5L,0L,9L,4L,1L,3L,2L,9L,6L,8L,6L,9L,2L,5L,8L,8L,3L,7L,3L,3L,9L,2L,4L,9L,3L,5L,3L,5L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248695Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248695.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248695Inst : IEnumerable<long>
{
public static readonly long[] Value=A248695.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248695.Bytes);
public long this[int i]=>Value[i];

public static A248695Inst Instance=new A248695Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248696
{
public static readonly long[] Value={ 3L,3L,8L,9L,4L,9L,2L,8L,0L,1L,0L,9L,8L,9L,4L,2L,4L,2L,9L,7L,4L,5L,0L,7L,2L,3L,5L,0L,4L,8L,8L,6L,9L,7L,6L,8L,1L,1L,2L,5L,5L,2L,3L,0L,4L,2L,5L,0L,6L,4L,7L,4L,4L,9L,1L,6L,1L,2L,4L,9L,3L,0L,2L,1L,2L,6L,1L,4L,5L,1L,3L,6L,7L,4L,4L,4L,0L,0L,5L,4L,9L,7L,7L,4L,2L,9L,2L,3L,6L,5L,3L,3L,6L,3L,3L,7L,0L,9L,6L,5L,6L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248696Inst : IEnumerable<long>
{
public static readonly long[] Value=A248696.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248696.Bytes);
public long this[int i]=>Value[i];

public static A248696Inst Instance=new A248696Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248697
{
public static readonly long[] Value={ 17L,53L,107L,179L,269L,503L,647L,809L,1187L,1637L,1889L,2447L,2753L,3779L,4157L,4967L,5399L,5849L,6317L,6803L,7307L,7829L,8369L,10709L,11987L,12653L,13337L,14759L,15497L,16253L,17027L,19457L,26729L,29753L,31859L,32939L,35153L,38609L,42227L,44729L,47303L,52667L,55457L,61253L,65789L,68903L,70487L,72089L,73709L,75347L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248697Inst : IEnumerable<long>
{
public static readonly long[] Value=A248697.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248697.Bytes);
public long this[int i]=>Value[i];

public static A248697Inst Instance=new A248697Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248698
{
public static readonly long[] Value={ 0L,23L,166L,621L,1676L,3715L,7218L,12761L,21016L,32751L,48830L,70213L,97956L,133211L,177226L,231345L,297008L,375751L,469206L,579101L,707260L,855603L,1026146L,1221001L,1442376L,1692575L,1973998L,2289141L,2640596L,3031051L,3463290L,3940193L,4464736L,5039991L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248698Inst : IEnumerable<long>
{
public static readonly long[] Value=A248698.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248698.Bytes);
public long this[int i]=>Value[i];

public static A248698Inst Instance=new A248698Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248699
{
public static readonly long[] Value={ 2L,1L,5L,5L,6L,7L,10L,9L,12L,12L,14L,15L,17L,16L,20L,20L,21L,22L,25L,24L,27L,27L,29L,30L,32L,31L,35L,35L,36L,37L,40L,39L,42L,42L,44L,45L,47L,46L,50L,50L,51L,52L,55L,54L,57L,57L,59L,60L,62L,61L,65L,65L,66L,67L,70L,69L,72L,72L,74L,75L,77L,76L,80L,80L,81L,82L,85L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248699Inst : IEnumerable<long>
{
public static readonly long[] Value=A248699.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248699.Bytes);
public long this[int i]=>Value[i];

public static A248699Inst Instance=new A248699Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248700
{
public static readonly long[] Value={ 8L,14L,22L,102495L,130447L,173590L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248700Inst : IEnumerable<long>
{
public static readonly long[] Value=A248700.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248700.Bytes);
public long this[int i]=>Value[i];

public static A248700Inst Instance=new A248700Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248701
{
public static readonly long[] Value={ 3L,7L,359L,7853L,96401L,2812099L,294276293L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248701Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248701.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248701Inst : IEnumerable<long>
{
public static readonly long[] Value=A248701.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248701.Bytes);
public long this[int i]=>Value[i];

public static A248701Inst Instance=new A248701Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248702
{
public static readonly long[] Value={ 2L,3L,19L,43L,2687L,179819L,1107791L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248702Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248702.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248702Inst : IEnumerable<long>
{
public static readonly long[] Value=A248702.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248702.Bytes);
public long this[int i]=>Value[i];

public static A248702Inst Instance=new A248702Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248703
{
public static readonly long[] Value={ 23L,1439L,21433L,1130863L,19881311L,331542583L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248703Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248703.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248703Inst : IEnumerable<long>
{
public static readonly long[] Value=A248703.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248703.Bytes);
public long this[int i]=>Value[i];

public static A248703Inst Instance=new A248703Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248704
{
public static readonly long[] Value={ 3L,19L,1429L,25243L,340577L,1107791L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248704Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248704.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248704Inst : IEnumerable<long>
{
public static readonly long[] Value=A248704.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248704.Bytes);
public long this[int i]=>Value[i];

public static A248704Inst Instance=new A248704Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248705
{
public static readonly long[] Value={ 1L,8L,27L,64L,343L,729L,2744L,3375L,6859L,35937L,46656L,148877L,287496L,438976L,778688L,2985984L,3869893L,8489664L,34645976L,43986977L,58863869L,75686967L,398688256L,426957777L,485587656L,596947688L,835896888L,1693669888L,2548895896L,2954987875L,4758586568L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248705Inst : IEnumerable<long>
{
public static readonly long[] Value=A248705.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248705.Bytes);
public long this[int i]=>Value[i];

public static A248705Inst Instance=new A248705Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248706
{
public static readonly long[] Value={ 1L,8L,576L,48320L,5118400L,598123008L,75243589344L,9951304416768L,1366687981264320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248706Inst : IEnumerable<long>
{
public static readonly long[] Value=A248706.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248706.Bytes);
public long this[int i]=>Value[i];

public static A248706Inst Instance=new A248706Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248707
{
public static readonly BigInteger[] Value={ 3L,60L,1260L,27720L,630630L,14702688L,349188840L,8413788240L,205086088350L,5046360719400L,125149745841120L,3124367780788800L,78443948210518800L,1979201154850012800L,BigInteger.Parse("50151543548788717200"),BigInteger.Parse("1275619260617425959840"),BigInteger.Parse("32554866547007225016750") };
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
public class A248707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248707Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A248707.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A248707.Bytes);
public BigInteger this[int i]=>Value[i];

public static A248707Inst Instance=new A248707Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248708
{
public static readonly BigInteger[] Value={ 60L,12600L,2522520L,514594080L,107550162720L,22969641895200L,4995897112206000L,1103284402265073600L,BigInteger.Parse("246784661070292144800"),BigInteger.Parse("55803246694136969227200"),BigInteger.Parse("12736017918577260592084800"),BigInteger.Parse("2930174751896446667689440000"),BigInteger.Parse("678879630375093886522676256000") };
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
public class A248708Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248708.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248708Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A248708.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A248708.Bytes);
public BigInteger this[int i]=>Value[i];

public static A248708Inst Instance=new A248708Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248709
{
public static readonly BigInteger[] Value={ 12600L,37837800L,97772875200L,247365374256000L,629483036137956000L,BigInteger.Parse("1621828071329658192000"),BigInteger.Parse("4234824783966213204768000"),BigInteger.Parse("11198994141198650820008976000"),BigInteger.Parse("29959571750765218953790679280000"),BigInteger.Parse("80980722442318386832096206093840000") };
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
public class A248709Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248709.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248709Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A248709.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A248709.Bytes);
public BigInteger this[int i]=>Value[i];

public static A248709Inst Instance=new A248709Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248710
{
public static readonly BigInteger[] Value={ 37837800L,2053230379200L,86825246363856000L,BigInteger.Parse("3434459445168687936000"),BigInteger.Parse("133396980694935715950192000"),BigInteger.Parse("5173935293233776678844146912000"),BigInteger.Parse("201687837026151453996918852912960000"),BigInteger.Parse("7920886423528046052820994110450678080000"),BigInteger.Parse("313629810506083768747620025974652020366480000") };
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
public class A248710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248710Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A248710.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A248710.Bytes);
public BigInteger this[int i]=>Value[i];

public static A248710Inst Instance=new A248710Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248711
{
public static readonly long[] Value={ 100L,101L,110L,111L,121L,122L,132L,133L,143L,144L,154L,155L,165L,166L,176L,177L,187L,188L,198L,199L,200L,202L,211L,212L,220L,221L,231L,242L,253L,263L,264L,275L,284L,286L,297L,300L,303L,312L,313L,321L,330L,331L,341L,352L,362L,363L,374L,385L,393L,396L,400L,404L,413L,414L,422L,431L,440L,441L,451L,462L,473L,482L,484L,495L,500L,505L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248711Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248711.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248711Inst : IEnumerable<long>
{
public static readonly long[] Value=A248711.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248711.Bytes);
public long this[int i]=>Value[i];

public static A248711Inst Instance=new A248711Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248712
{
public static readonly long[] Value={ 2210L,3770L,4810L,4930L,5330L,6290L,6890L,6970L,7930L,9010L,9490L,10370L,10730L,11570L,11890L,12410L,12610L,12818L,13130L,14170L,14690L,15130L,15170L,15370L,16354L,16490L,17170L,17690L,17810L,18122L,18530L,19210L,19370L,19610L,20410L,21170L,21730L,22490L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248712Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248712.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248712Inst : IEnumerable<long>
{
public static readonly long[] Value=A248712.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248712.Bytes);
public long this[int i]=>Value[i];

public static A248712Inst Instance=new A248712Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248713
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,23L,7L,731173L,9L,25L,11L,31397L,13L,313L,1129L,16L,17L,29L,19L,59L,37L,211L,23L,731173L,25L,3251L,313L,47L,29L,547L,31L,313289L,311L,31397L,1129L,49L,37L,373L,313L,961L,41L,379L,43L,3137L,59L,223L,47L,479L,49L,71443L,317L,31123L,53L,239L,773L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248713Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248713.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248713Inst : IEnumerable<long>
{
public static readonly long[] Value=A248713.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248713.Bytes);
public long this[int i]=>Value[i];

public static A248713Inst Instance=new A248713Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248714
{
public static readonly long[] Value={ 3L,5L,7L,11L,17L,29L,23L,41L,29L,37L,89L,79L,89L,71L,439L,389L,163L,79L,151L,73L,89L,211L,113L,113L,419L,167L,139L,199L,173L,137L,487L,197L,401L,167L,739L,641L,461L,199L,223L,331L,379L,401L,293L,223L,251L,647L,593L,613L,317L,271L,257L,947L,331L,347L,593L,433L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248714Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248714.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248714Inst : IEnumerable<long>
{
public static readonly long[] Value=A248714.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248714.Bytes);
public long this[int i]=>Value[i];

public static A248714Inst Instance=new A248714Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248715
{
public static readonly long[] Value={ 1L,10L,12L,15L,17L,19L,21L,23L,31L,48L,50L,52L,54L,60L,62L,64L,67L,69L,71L,73L,75L,77L,89L,91L,93L,101L,118L,120L,122L,124L,126L,128L,138L,140L,142L,148L,150L,152L,154L,156L,159L,161L,163L,179L,181L,183L,185L,187L,195L,197L,199L,211L,220L,222L,224L,226L,228L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248715Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248715.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248715Inst : IEnumerable<long>
{
public static readonly long[] Value=A248715.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248715.Bytes);
public long this[int i]=>Value[i];

public static A248715Inst Instance=new A248715Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248716
{
public static readonly BigInteger[] Value={ 2L,3L,17L,27L,293L,791L,10583L,25685L,448303L,251411L,4503535L,6331107L,4436875097L,3335427631L,19619696071L,75379875277L,3019260651391L,16773385986619L,3047463007411973L,2732480436961811L,398377271835431771L,173581842021095897L,1716900426430701553L,BigInteger.Parse("35001773773285490879"),BigInteger.Parse("6684326532123939298051") };
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
public class A248716Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248716.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248716Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A248716.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A248716.Bytes);
public BigInteger this[int i]=>Value[i];

public static A248716Inst Instance=new A248716Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248717
{
public static readonly long[] Value={ 12331L,13231L,13651L,21331L,23131L,23552L,25545L,26553L,31231L,31651L,32131L,32552L,34355L,34531L,34554L,35354L,35453L,35631L,36156L,36231L,43531L,45353L,46431L,53631L,54353L,54885L,55245L,55296L,59652L,61599L,63231L,64431L,87973L,95274L,122553L,125918L,126531L,126535L,126553L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248717Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248717.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248717Inst : IEnumerable<long>
{
public static readonly long[] Value=A248717.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248717.Bytes);
public long this[int i]=>Value[i];

public static A248717Inst Instance=new A248717Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248718
{
public static readonly long[] Value={ 1512L,4346L,5112L,5769L,11215L,11512L,12115L,12313L,12511L,13213L,14346L,14512L,15112L,15211L,15412L,21115L,21313L,21511L,23113L,25111L,27369L,31213L,32113L,34135L,34535L,41346L,41512L,43135L,43535L,45112L,51112L,51211L,51412L,52111L,52569L,53435L,53534L,53958L,54112L,54533L,56925L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248718Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248718.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248718Inst : IEnumerable<long>
{
public static readonly long[] Value=A248718.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248718.Bytes);
public long this[int i]=>Value[i];

public static A248718Inst Instance=new A248718Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248719
{
public static readonly long[] Value={ 0L,1L,2L,5L,6L,18L,43L,52L,106L,383L,417L,663L,849L,971L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248719Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248719.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248719Inst : IEnumerable<long>
{
public static readonly long[] Value=A248719.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248719.Bytes);
public long this[int i]=>Value[i];

public static A248719Inst Instance=new A248719Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248720
{
public static readonly long[] Value={ 0L,32L,7776L,248832L,3200000L,24300000L,130691232L,550731776L,1934917632L,5904900000L,16105100000L,40074642432L,92389579776L,199690286432L,408410100000L,796262400000L,1488827973632L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248720Inst : IEnumerable<long>
{
public static readonly long[] Value=A248720.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248720.Bytes);
public long this[int i]=>Value[i];

public static A248720Inst Instance=new A248720Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248721
{
public static readonly long[] Value={ 4L,2L,1L,0L,9L,7L,6L,8L,6L,0L,3L,3L,4L,2L,3L,7L,7L,7L,2L,9L,5L,9L,9L,0L,8L,8L,7L,9L,6L,7L,7L,1L,3L,0L,4L,8L,9L,6L,1L,4L,4L,1L,3L,3L,6L,3L,2L,4L,1L,1L,5L,4L,0L,4L,6L,0L,5L,9L,2L,0L,7L,9L,6L,7L,1L,2L,7L,7L,1L,3L,7L,0L,4L,8L,8L,7L,3L,9L,8L,0L,2L,7L,5L,1L,9L,0L,3L,6L,8L,4L,7L,5L,8L,6L,5L,0L,7L,9L,5L,3L,9L,2L,8L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248721Inst : IEnumerable<long>
{
public static readonly long[] Value=A248721.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248721.Bytes);
public long this[int i]=>Value[i];

public static A248721Inst Instance=new A248721Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248722
{
public static readonly long[] Value={ 3L,0L,1L,7L,3L,3L,8L,5L,3L,5L,9L,7L,9L,7L,2L,4L,5L,7L,9L,4L,8L,1L,6L,2L,1L,5L,9L,3L,9L,3L,9L,9L,1L,1L,9L,2L,6L,2L,3L,0L,0L,9L,4L,3L,1L,5L,1L,7L,1L,5L,7L,7L,2L,0L,3L,9L,5L,7L,9L,1L,9L,2L,3L,3L,1L,8L,3L,7L,9L,8L,2L,5L,8L,9L,2L,0L,3L,4L,3L,3L,5L,2L,7L,5L,8L,5L,9L,4L,9L,2L,9L,7L,8L,7L,5L,8L,1L,6L,9L,6L,8L,3L,5L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248722Inst : IEnumerable<long>
{
public static readonly long[] Value=A248722.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248722.Bytes);
public long this[int i]=>Value[i];

public static A248722Inst Instance=new A248722Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248723
{
public static readonly long[] Value={ 2L,3L,4L,1L,4L,9L,1L,3L,0L,1L,3L,4L,8L,0L,9L,2L,0L,6L,4L,8L,5L,1L,1L,1L,6L,7L,2L,8L,1L,3L,8L,7L,2L,9L,1L,8L,5L,4L,6L,3L,6L,1L,0L,3L,4L,7L,8L,6L,5L,1L,3L,8L,9L,8L,5L,2L,2L,4L,2L,1L,3L,8L,6L,7L,1L,0L,2L,3L,8L,1L,9L,8L,6L,6L,2L,8L,7L,9L,2L,3L,2L,2L,5L,6L,7L,8L,8L,7L,9L,5L,0L,1L,8L,7L,8L,3L,9L,1L,2L,6L,6L,5L,5L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248723Inst : IEnumerable<long>
{
public static readonly long[] Value=A248723.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248723.Bytes);
public long this[int i]=>Value[i];

public static A248723Inst Instance=new A248723Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248724
{
public static readonly long[] Value={ 1L,9L,0L,9L,1L,0L,0L,6L,2L,4L,1L,0L,2L,6L,1L,5L,7L,8L,2L,0L,2L,1L,9L,9L,6L,4L,4L,4L,1L,7L,6L,9L,1L,1L,6L,8L,7L,6L,9L,2L,6L,8L,4L,7L,6L,0L,0L,8L,2L,6L,6L,4L,0L,8L,3L,3L,4L,7L,7L,1L,1L,0L,8L,6L,4L,0L,9L,9L,9L,6L,7L,5L,5L,8L,4L,6L,3L,0L,1L,4L,4L,0L,3L,8L,0L,0L,9L,1L,1L,6L,1L,6L,5L,9L,7L,0L,9L,1L,1L,9L,3L,4L,5L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248724Inst : IEnumerable<long>
{
public static readonly long[] Value=A248724.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248724.Bytes);
public long this[int i]=>Value[i];

public static A248724Inst Instance=new A248724Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248725
{
public static readonly long[] Value={ 1L,6L,0L,9L,6L,6L,1L,8L,4L,3L,1L,5L,0L,6L,2L,3L,9L,6L,8L,0L,5L,3L,0L,2L,5L,6L,4L,1L,4L,3L,6L,4L,2L,8L,8L,5L,5L,5L,0L,7L,4L,3L,8L,5L,6L,0L,2L,5L,3L,2L,8L,3L,4L,6L,3L,6L,0L,8L,3L,5L,9L,1L,8L,6L,4L,7L,8L,2L,3L,9L,4L,0L,8L,5L,8L,0L,0L,6L,3L,6L,9L,1L,7L,7L,9L,2L,3L,4L,5L,3L,1L,0L,0L,9L,3L,2L,5L,4L,0L,2L,5L,2L,9L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248725Inst : IEnumerable<long>
{
public static readonly long[] Value=A248725.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248725.Bytes);
public long this[int i]=>Value[i];

public static A248725Inst Instance=new A248725Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248726
{
public static readonly long[] Value={ 1L,3L,9L,0L,4L,5L,1L,1L,7L,6L,6L,2L,1L,8L,8L,1L,2L,9L,3L,5L,8L,7L,2L,8L,4L,7L,4L,3L,6L,9L,0L,8L,9L,0L,5L,2L,1L,3L,9L,3L,6L,2L,6L,4L,7L,0L,6L,7L,8L,1L,9L,6L,0L,9L,5L,5L,1L,0L,3L,5L,4L,9L,3L,4L,7L,9L,6L,7L,0L,2L,0L,1L,4L,5L,3L,6L,6L,6L,6L,0L,7L,9L,8L,8L,6L,3L,3L,7L,9L,8L,1L,3L,5L,7L,6L,5L,5L,0L,5L,7L,9L,9L,5L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248726Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248726.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248726Inst : IEnumerable<long>
{
public static readonly long[] Value=A248726.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248726.Bytes);
public long this[int i]=>Value[i];

public static A248726Inst Instance=new A248726Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248727
{
public static readonly long[] Value={ 1L,2L,1L,5L,5L,1L,16L,24L,10L,1L,65L,130L,84L,19L,1L,326L,815L,720L,265L,36L,1L,1957L,5871L,6605L,3425L,803L,69L,1L,13700L,47950L,65646L,44240L,15106L,2394L,134L,1L,109601L,438404L,707840L,589106L,267134L,63896L,7094L,263L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248727Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248727.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248727Inst : IEnumerable<long>
{
public static readonly long[] Value=A248727.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248727.Bytes);
public long this[int i]=>Value[i];

public static A248727Inst Instance=new A248727Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248728
{
public static readonly BigInteger[] Value={ 1L,3L,30L,3010L,18004327L,133978259344888L,BigInteger.Parse("233202632378520643600875145"),BigInteger.Parse("817400077628568283525440629036885986580578161120"),BigInteger.Parse("37560309092871894517794668078727801667246369744545646936224413217138060330481863103169") };
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
public class A248728Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248728.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248728Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A248728.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A248728.Bytes);
public BigInteger this[int i]=>Value[i];

public static A248728Inst Instance=new A248728Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248729
{
public static readonly long[] Value={ 1L,1L,2L,4L,8L,15L,27L,48L,86L,152L,266L,463L,806L,1400L,2429L,4212L,7301L,12651L,21918L,37969L,65771L,113926L,197332L,341797L,592018L,1025414L,1776077L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248729Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248729.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248729Inst : IEnumerable<long>
{
public static readonly long[] Value=A248729.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248729.Bytes);
public long this[int i]=>Value[i];

public static A248729Inst Instance=new A248729Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248730
{
public static readonly BigInteger[] Value={ 1L,7L,1958L,3163127352L,BigInteger.Parse("1606903190858354689128371"),BigInteger.Parse("8630901377559029573671524821295260243701883575513498104067") };
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
public class A248730Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248730.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248730Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A248730.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A248730.Bytes);
public BigInteger this[int i]=>Value[i];

public static A248730Inst Instance=new A248730Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248731
{
public static readonly long[] Value={ 1L,1L,4L,10L,25L,58L,135L,306L,690L,1550L,3474L,7776L,17398L,38912L,87022L,194598L,435148L,973034L,2175785L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248731Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248731.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248731Inst : IEnumerable<long>
{
public static readonly long[] Value=A248731.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248731.Bytes);
public long this[int i]=>Value[i];

public static A248731Inst Instance=new A248731Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248732
{
public static readonly BigInteger[] Value={ 1L,11L,17977L,15285151248481L,BigInteger.Parse("1398703012615213588677365804960180341"),BigInteger.Parse("3173477897288016617984809197028065610087051214582584606785402878333070481745149246796102615681") };
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
public class A248732Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248732.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248732Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A248732.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A248732.Bytes);
public BigInteger this[int i]=>Value[i];

public static A248732Inst Instance=new A248732Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248733
{
public static readonly long[] Value={ 1L,2L,5L,14L,37L,94L,236L,584L,1437L,3529L,8654L,21210L,51966L,127302L,311840L,763864L,1871094L,4583243L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248733Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248733.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248733Inst : IEnumerable<long>
{
public static readonly long[] Value=A248733.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248733.Bytes);
public long this[int i]=>Value[i];

public static A248733Inst Instance=new A248733Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248734
{
public static readonly BigInteger[] Value={ 1L,15L,173525L,175943559810422753L,BigInteger.Parse("229866006383458830949778967121025947053151071434926") };
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
public class A248734Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248734.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248734Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A248734.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A248734.Bytes);
public BigInteger this[int i]=>Value[i];

public static A248734Inst Instance=new A248734Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248735
{
public static readonly long[] Value={ 1L,2L,6L,18L,51L,140L,377L,1005L,2668L,7069L,18714L,49527L,131052L,346746L,917422L,2427289L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248735Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248735.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248735Inst : IEnumerable<long>
{
public static readonly long[] Value=A248735.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248735.Bytes);
public long this[int i]=>Value[i];

public static A248735Inst Instance=new A248735Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248736
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,1L,1L,3L,4L,3L,1L,2L,4L,7L,8L,4L,1L,2L,5L,10L,15L,15L,7L,1L,2L,6L,14L,25L,32L,27L,10L,1L,2L,7L,18L,37L,58L,67L,48L,15L,1L,2L,8L,22L,51L,94L,135L,138L,86L,22L,1L,2L,9L,27L,67L,140L,236L,306L,280L,152L,32L,1L,2L,10L,32L,86L,197L,377L,584L,690L,565L,266L,47L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248736Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248736.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248736Inst : IEnumerable<long>
{
public static readonly long[] Value=A248736.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248736.Bytes);
public long this[int i]=>Value[i];

public static A248736Inst Instance=new A248736Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248737
{
public static readonly long[] Value={ 0L,1L,2L,3L,2L,5L,2L,7L,2L,6L,1L,11L,3L,13L,5L,1L,7L,17L,6L,19L,2L,3L,2L,23L,2L,11L,2L,6L,1L,29L,3L,31L,5L,3L,7L,1L,3L,37L,11L,3L,8L,41L,2L,43L,2L,6L,1L,47L,3L,15L,1L,2L,1L,53L,3L,6L,1L,2L,1L,59L,3L,61L,5L,3L,7L,3L,1L,67L,11L,4L,1L,71L,3L,73L,5L,1L,7L,1L,6L,79L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248737Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248737.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248737Inst : IEnumerable<long>
{
public static readonly long[] Value=A248737.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248737.Bytes);
public long this[int i]=>Value[i];

public static A248737Inst Instance=new A248737Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248738
{
public static readonly long[] Value={ 3L,4L,6L,6L,90L,4L,6L,30L,6L,180L,6L,12L,30L,18L,12L,48L,60L,90L,24L,30L,18L,120L,12L,510L,10L,60L,36L,12L,60L,12L,12L,30L,12L,12L,30L,120L,24L,48L,18L,48L,690L,1020L,30L,14L,18L,420L,180L,18L,36L,540L,42L,1230L,150L,870L,36L,18L,330L,870L,18L,30L,18L,18L,18L,150L,30L,18L,30L,30L,60L,180L,24L,30L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248738Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248738.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248738Inst : IEnumerable<long>
{
public static readonly long[] Value=A248738.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248738.Bytes);
public long this[int i]=>Value[i];

public static A248738Inst Instance=new A248738Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248739
{
public static readonly long[] Value={ 0L,30L,59L,88L,117L,146L,175L,204L,233L,262L,291L,320L,349L,378L,407L,436L,465L,494L,523L,552L,581L,610L,639L,668L,697L,726L,755L,784L,813L,842L,872L,901L,930L,959L,988L,1017L,1046L,1075L,1104L,1133L,1162L,1191L,1220L,1249L,1278L,1307L,1336L,1365L,1394L,1423L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248739Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248739.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248739Inst : IEnumerable<long>
{
public static readonly long[] Value=A248739.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248739.Bytes);
public long this[int i]=>Value[i];

public static A248739Inst Instance=new A248739Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248740
{
public static readonly long[] Value={ 0L,1L,1L,2L,3L,5L,8L,13L,21L,34L,55L,89L,144L,233L,377L,610L,987L,597L,584L,181L,765L,946L,711L,657L,368L,25L,393L,418L,811L,229L,40L,269L,309L,578L,887L,465L,352L,817L,169L,986L,155L,141L,296L,437L,733L,170L,903L,73L,976L,49L,25L,74L,99L,173L,272L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248740Inst : IEnumerable<long>
{
public static readonly long[] Value=A248740.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248740.Bytes);
public long this[int i]=>Value[i];

public static A248740Inst Instance=new A248740Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248741
{
public static readonly long[] Value={ 0L,2L,4L,8L,9L,18L,32L,50L,64L,72L,98L,128L,162L,200L,242L,243L,288L,324L,338L,392L,450L,512L,576L,578L,625L,648L,722L,800L,882L,968L,1024L,1058L,1125L,1152L,1250L,1352L,1458L,1568L,1682L,1800L,1922L,1944L,2048L,2178L,2187L,2312L,2450L,2500L,2592L,2738L,2888L,3042L,3087L,3200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248741Inst : IEnumerable<long>
{
public static readonly long[] Value=A248741.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248741.Bytes);
public long this[int i]=>Value[i];

public static A248741Inst Instance=new A248741Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248742
{
public static readonly long[] Value={ 2L,5L,10L,17L,26L,37L,65L,82L,101L,122L,145L,197L,226L,257L,362L,401L,485L,577L,626L,677L,785L,842L,901L,1157L,1226L,1297L,1522L,1601L,1765L,1937L,2026L,2117L,2305L,2402L,2501L,2602L,2705L,2917L,3137L,3365L,3482L,3601L,3722L,3845L,4097L,4226L,4357L,4762L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248742Inst : IEnumerable<long>
{
public static readonly long[] Value=A248742.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248742.Bytes);
public long this[int i]=>Value[i];

public static A248742Inst Instance=new A248742Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248743
{
public static readonly long[] Value={ 3L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,2L,2L,3L,2L,2L,2L,2L,2L,2L,5L,2L,2L,2L,3L,3L,2L,2L,2L,2L,5L,2L,2L,2L,3L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,3L,3L,2L,2L,2L,3L,2L,2L,2L,47L,3L,3L,2L,2L,2L,2L,2L,2L,2L,11L,2L,23L,17L,2L,2L,2L,2L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248743Inst : IEnumerable<long>
{
public static readonly long[] Value=A248743.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248743.Bytes);
public long this[int i]=>Value[i];

public static A248743Inst Instance=new A248743Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248744
{
public static readonly BigInteger[] Value={ 1L,1L,6L,48L,488L,6130L,92592L,1642046L,33514112L,774478098L,19996371200L,570583424422L,17831721894912L,605743986163706L,22223926472824832L,875786473087350750L,BigInteger.Parse("36893467224629215232"),BigInteger.Parse("1654480168085245432354"),BigInteger.Parse("78692809748219369422848"),BigInteger.Parse("3956839189675526769415958") };
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
public class A248744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248744Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A248744.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A248744.Bytes);
public BigInteger this[int i]=>Value[i];

public static A248744Inst Instance=new A248744Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248745
{
public static readonly long[] Value={ 89L,227L,251L,257L,277L,281L,349L,409L,449L,499L,521L,557L,577L,587L,727L,757L,787L,821L,827L,857L,877L,881L,887L,991L,1117L,1129L,1171L,1187L,1259L,1289L,1423L,1447L,1453L,1471L,1483L,1543L,1553L,1559L,1583L,1621L,1669L,1721L,1741L,1747L,1777L,1847L,1889L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248745Inst : IEnumerable<long>
{
public static readonly long[] Value=A248745.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248745.Bytes);
public long this[int i]=>Value[i];

public static A248745Inst Instance=new A248745Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248746
{
public static readonly long[] Value={ 1L,2L,2L,4L,3L,6L,2L,3L,7L,13L,9L,5L,4L,22L,15L,26L,5L,3L,20L,39L,4L,12L,8L,51L,31L,60L,10L,18L,41L,8L,6L,7L,14L,11L,54L,105L,16L,4L,65L,121L,5L,35L,6L,17L,83L,10L,4L,45L,97L,9L,106L,48L,29L,209L,11L,221L,3L,59L,133L,28L,138L,66L,38L,25L,155L,294L,43L,6L,174L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248746Inst : IEnumerable<long>
{
public static readonly long[] Value=A248746.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248746.Bytes);
public long this[int i]=>Value[i];

public static A248746Inst Instance=new A248746Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248747
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248747Inst : IEnumerable<long>
{
public static readonly long[] Value=A248747.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248747.Bytes);
public long this[int i]=>Value[i];

public static A248747Inst Instance=new A248747Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248748
{
public static readonly long[] Value={ 1L,2L,4L,16L,48L,192L,704L,3072L,12032L,52736L,219136L,985088L,4218880L,19144704L,84066304L,387088384L,1725497344L,7989886976L,36128948224L,168658206720L,770103574528L,3611291549696L,16636941697024L,78453223194624L,363787840389120L,1721209150504960L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248748Inst : IEnumerable<long>
{
public static readonly long[] Value=A248748.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248748.Bytes);
public long this[int i]=>Value[i];

public static A248748Inst Instance=new A248748Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248749
{
public static readonly long[] Value={ 1L,5L,2L,9L,0L,8L,5L,5L,1L,3L,6L,3L,5L,7L,4L,6L,1L,2L,5L,1L,6L,0L,9L,9L,0L,5L,2L,3L,7L,9L,0L,2L,2L,5L,2L,1L,0L,6L,1L,9L,3L,6L,5L,0L,4L,9L,8L,3L,8L,9L,0L,9L,7L,4L,3L,1L,4L,0L,7L,7L,1L,1L,7L,6L,3L,2L,0L,2L,3L,9L,8L,1L,1L,5L,7L,9L,1L,8L,9L,4L,6L,2L,7L,7L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248749Inst : IEnumerable<long>
{
public static readonly long[] Value=A248749.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248749.Bytes);
public long this[int i]=>Value[i];

public static A248749Inst Instance=new A248749Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248750
{
public static readonly long[] Value={ 7L,4L,2L,9L,3L,4L,1L,3L,5L,8L,7L,8L,3L,2L,2L,8L,3L,9L,0L,9L,1L,4L,3L,1L,9L,3L,7L,9L,4L,7L,2L,6L,6L,2L,8L,1L,0L,9L,6L,2L,4L,2L,9L,9L,2L,0L,0L,1L,1L,8L,6L,5L,0L,5L,4L,7L,5L,8L,6L,9L,2L,0L,6L,2L,1L,9L,0L,5L,7L,7L,6L,3L,9L,5L,6L,8L,7L,8L,5L,4L,9L,0L,5L,9L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248750Inst : IEnumerable<long>
{
public static readonly long[] Value=A248750.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248750.Bytes);
public long this[int i]=>Value[i];

public static A248750Inst Instance=new A248750Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248751
{
public static readonly long[] Value={ 5L,2L,9L,0L,8L,5L,5L,1L,3L,6L,3L,5L,7L,4L,6L,1L,2L,5L,1L,6L,0L,9L,9L,0L,5L,2L,3L,7L,9L,0L,2L,2L,5L,2L,1L,0L,6L,1L,9L,3L,6L,5L,0L,4L,9L,8L,3L,8L,9L,0L,9L,7L,4L,3L,1L,4L,0L,7L,7L,1L,1L,7L,6L,3L,2L,0L,2L,3L,9L,8L,1L,1L,5L,7L,9L,1L,8L,9L,4L,6L,2L,7L,7L,1L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248751Inst : IEnumerable<long>
{
public static readonly long[] Value=A248751.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248751.Bytes);
public long this[int i]=>Value[i];

public static A248751Inst Instance=new A248751Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248752
{
public static readonly long[] Value={ 2L,5L,7L,0L,6L,5L,8L,6L,4L,1L,2L,1L,6L,7L,7L,1L,6L,0L,9L,0L,8L,5L,6L,8L,0L,6L,2L,0L,5L,2L,7L,3L,3L,7L,1L,8L,9L,0L,3L,7L,5L,7L,0L,0L,7L,9L,9L,8L,8L,1L,3L,4L,9L,4L,5L,2L,4L,1L,3L,0L,7L,9L,3L,7L,8L,0L,9L,4L,2L,2L,3L,6L,0L,4L,3L,1L,2L,1L,4L,5L,0L,9L,4L,0L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248752Inst : IEnumerable<long>
{
public static readonly long[] Value=A248752.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248752.Bytes);
public long this[int i]=>Value[i];

public static A248752Inst Instance=new A248752Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248753
{
public static readonly long[] Value={ 11L,1111L,12221L,23332L,34443L,45554L,56665L,67776L,78887L,89998L,101101L,111111L,121121L,131131L,141141L,151151L,161161L,171171L,181181L,191191L,1020201L,1121211L,1222221L,1323231L,1424241L,1525251L,1626261L,1727271L,1828281L,1929291L,2030302L,2131312L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248753Inst : IEnumerable<long>
{
public static readonly long[] Value=A248753.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248753.Bytes);
public long this[int i]=>Value[i];

public static A248753Inst Instance=new A248753Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248754
{
public static readonly long[] Value={ 11L,1111L,12221L,23332L,34443L,45554L,56665L,67776L,78887L,89998L,111111L,1222221L,2333332L,3444443L,4555554L,5666665L,6777776L,7888887L,8999998L,9101019L,11111111L,102020201L,112121211L,122222221L,132323231L,142424241L,152525251L,162626261L,172727271L,182828281L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248754Inst : IEnumerable<long>
{
public static readonly long[] Value=A248754.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248754.Bytes);
public long this[int i]=>Value[i];

public static A248754Inst Instance=new A248754Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248755
{
public static readonly long[] Value={ 2L,2L,1L,4L,3L,3L,4L,2L,5L,4L,6L,5L,4L,5L,11L,3L,15L,6L,5L,3L,5L,6L,11L,13L,5L,4L,9L,27L,11L,10L,8L,7L,23L,13L,20L,12L,14L,10L,41L,28L,12L,4L,36L,4L,15L,13L,27L,8L,15L,11L,13L,24L,5L,51L,8L,65L,36L,8L,13L,47L,36L,42L,31L,20L,13L,52L,42L,6L,87L,16L,30L,89L,15L,7L,36L,95L,6L,17L,34L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248755Inst : IEnumerable<long>
{
public static readonly long[] Value=A248755.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248755.Bytes);
public long this[int i]=>Value[i];

public static A248755Inst Instance=new A248755Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248756
{
public static readonly long[] Value={ 1L,1L,3L,2L,2L,3L,7L,3L,1L,2L,4L,4L,6L,7L,15L,4L,4L,5L,5L,1L,7L,1L,8L,5L,4L,5L,12L,7L,14L,15L,31L,7L,6L,1L,3L,1L,5L,6L,9L,1L,9L,10L,13L,1L,15L,1L,16L,6L,6L,7L,6L,2L,8L,9L,24L,6L,12L,13L,28L,15L,30L,31L,63L,11L,8L,9L,3L,1L,5L,6L,10L,1L,9L,10L,14L,1L,16L,17L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248756Inst : IEnumerable<long>
{
public static readonly long[] Value=A248756.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248756.Bytes);
public long this[int i]=>Value[i];

public static A248756Inst Instance=new A248756Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248757
{
public static readonly long[] Value={ 6L,10L,11L,28L,149L,172L,185L,754L,815L,1510L,1594L,3160L,3755L,10654L,12743L,71807L,155957L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248757Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248757.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248757Inst : IEnumerable<long>
{
public static readonly long[] Value=A248757.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248757.Bytes);
public long this[int i]=>Value[i];

public static A248757Inst Instance=new A248757Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248758
{
public static readonly long[] Value={ 0L,2L,3L,5L,6L,8L,9L,11L,12L,14L,15L,17L,18L,20L,21L,22L,24L,25L,27L,28L,30L,31L,33L,34L,36L,37L,39L,40L,42L,43L,44L,46L,47L,49L,50L,52L,53L,55L,56L,58L,59L,61L,62L,63L,65L,66L,68L,69L,71L,72L,74L,75L,77L,78L,80L,81L,83L,84L,85L,87L,88L,90L,91L,93L,94L,96L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248758Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248758.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248758Inst : IEnumerable<long>
{
public static readonly long[] Value=A248758.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248758.Bytes);
public long this[int i]=>Value[i];

public static A248758Inst Instance=new A248758Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248759
{
public static readonly long[] Value={ 1L,6L,9L,4L,6L,1L,0L,2L,9L,0L,3L,2L,0L,7L,4L,1L,2L,8L,6L,4L,6L,9L,2L,6L,7L,0L,5L,2L,9L,8L,9L,9L,6L,3L,3L,3L,1L,6L,9L,7L,1L,2L,4L,2L,9L,9L,3L,7L,7L,4L,0L,8L,0L,0L,4L,2L,0L,5L,5L,4L,0L,2L,5L,1L,0L,0L,6L,3L,6L,1L,1L,8L,6L,6L,1L,1L,6L,0L,3L,2L,1L,4L,0L,2L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248759Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248759.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248759Inst : IEnumerable<long>
{
public static readonly long[] Value=A248759.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248759.Bytes);
public long this[int i]=>Value[i];

public static A248759Inst Instance=new A248759Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248760
{
public static readonly long[] Value={ 3L,6L,8L,7L,3L,7L,8L,2L,0L,2L,9L,4L,6L,4L,9L,9L,0L,4L,0L,8L,9L,7L,7L,7L,2L,9L,6L,1L,6L,5L,7L,4L,0L,3L,4L,2L,0L,9L,8L,3L,7L,1L,9L,7L,8L,8L,1L,4L,6L,9L,8L,4L,9L,1L,0L,6L,8L,7L,8L,2L,5L,7L,4L,5L,8L,9L,0L,5L,9L,0L,1L,7L,3L,5L,7L,9L,6L,1L,9L,0L,0L,6L,7L,1L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248760Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248760.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248760Inst : IEnumerable<long>
{
public static readonly long[] Value=A248760.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248760.Bytes);
public long this[int i]=>Value[i];

public static A248760Inst Instance=new A248760Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248761
{
public static readonly long[] Value={ 2L,4L,6L,9L,5L,0L,6L,3L,1L,4L,5L,2L,1L,0L,4L,7L,5L,6L,2L,4L,7L,5L,6L,3L,6L,7L,4L,4L,6L,6L,0L,1L,5L,0L,2L,5L,7L,6L,8L,9L,7L,5L,6L,1L,8L,3L,9L,9L,4L,9L,6L,9L,1L,9L,9L,6L,7L,7L,9L,2L,5L,7L,0L,1L,9L,7L,1L,8L,3L,5L,4L,8L,8L,0L,0L,3L,4L,0L,8L,8L,3L,4L,0L,3L,8L,6L,6L,2L,5L,0L,8L,4L,1L,2L,0L,0L,7L,1L,3L,5L,1L,7L,2L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248761Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248761.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248761Inst : IEnumerable<long>
{
public static readonly long[] Value=A248761.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248761.Bytes);
public long this[int i]=>Value[i];

public static A248761Inst Instance=new A248761Inst();

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