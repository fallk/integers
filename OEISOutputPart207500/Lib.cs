using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A258162
{
public static readonly long[] Value={ 5L,7L,4L,0L,3L,8L,8L,8L,0L,7L,2L,2L,9L,4L,7L,4L,2L,8L,0L,0L,1L,9L,5L,7L,1L,6L,8L,8L,1L,0L,2L,4L,6L,1L,4L,6L,2L,9L,6L,1L,0L,1L,3L,0L,0L,7L,4L,5L,4L,8L,7L,3L,3L,3L,1L,4L,2L,5L,4L,0L,2L,4L,5L,1L,2L,3L,8L,8L,8L,4L,3L,8L,7L,1L,7L,7L,1L,2L,5L,0L,2L,6L,1L,0L,6L,2L,6L,2L,1L,6L,6L,6L,2L,8L,7L,2L,3L,3L,0L,5L,1L,5L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258162Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258162.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258162Inst : IEnumerable<long>
{
public static readonly long[] Value=A258162.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258162.Bytes);
public long this[int i]=>Value[i];

public static A258162Inst Instance=new A258162Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258163
{
public static readonly long[] Value={ 2L,3L,3L,8L,9L,5L,1L,4L,4L,6L,5L,5L,1L,6L,8L,0L,1L,6L,1L,9L,6L,0L,0L,5L,5L,9L,1L,0L,5L,0L,5L,9L,1L,4L,0L,6L,5L,9L,0L,0L,7L,5L,2L,7L,6L,8L,3L,1L,9L,8L,4L,6L,4L,6L,6L,7L,7L,8L,5L,4L,5L,2L,0L,5L,4L,5L,6L,3L,6L,4L,7L,9L,5L,2L,5L,5L,8L,0L,1L,4L,8L,8L,8L,1L,0L,1L,7L,7L,7L,0L,4L,0L,3L,1L,5L,9L,8L,2L,6L,4L,8L,6L,5L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258163Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258163.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258163Inst : IEnumerable<long>
{
public static readonly long[] Value=A258163.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258163.Bytes);
public long this[int i]=>Value[i];

public static A258163Inst Instance=new A258163Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258164
{
public static readonly long[] Value={ 1L,1L,8L,2L,9L,8L,7L,9L,3L,1L,8L,4L,5L,5L,1L,2L,5L,8L,7L,5L,4L,1L,6L,7L,2L,9L,0L,7L,2L,9L,2L,9L,6L,4L,4L,8L,4L,9L,0L,2L,9L,2L,8L,5L,2L,9L,0L,1L,0L,8L,2L,0L,6L,5L,7L,4L,7L,3L,4L,1L,1L,0L,4L,6L,0L,5L,3L,5L,5L,7L,2L,1L,9L,9L,6L,5L,6L,3L,2L,6L,3L,5L,3L,9L,0L,1L,6L,7L,9L,8L,8L,4L,3L,9L,3L,4L,7L,8L,8L,6L,4L,5L,5L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258164Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258164.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258164Inst : IEnumerable<long>
{
public static readonly long[] Value=A258164.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258164.Bytes);
public long this[int i]=>Value[i];

public static A258164Inst Instance=new A258164Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258165
{
public static readonly long[] Value={ 3L,5L,9L,11L,17L,19L,23L,25L,29L,37L,41L,47L,49L,53L,59L,61L,67L,71L,79L,83L,89L,97L,101L,103L,107L,109L,113L,131L,137L,139L,149L,151L,163L,167L,169L,173L,179L,181L,191L,193L,197L,199L,223L,227L,229L,233L,239L,251L,257L,263L,269L,271L,277L,281L,283L,289L,293L,311L,313L,317L,331L,337L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258165Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258165.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258165Inst : IEnumerable<long>
{
public static readonly long[] Value=A258165.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258165.Bytes);
public long this[int i]=>Value[i];

public static A258165Inst Instance=new A258165Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258166
{
public static readonly long[] Value={ 1730L,2031L,2032L,3682L,4655L,5445L,5836L,9756L,10607L,11496L,11497L,11576L,17724L,17951L,18935L,18936L,20948L,21488L,21489L,22519L,26310L,26311L,27436L,42326L,42423L,46644L,50738L,50851L,61950L,62130L,65569L,66123L,66903L,69229L,70682L,71253L,74661L,75184L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258166Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258166.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258166Inst : IEnumerable<long>
{
public static readonly long[] Value=A258166.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258166.Bytes);
public long this[int i]=>Value[i];

public static A258166Inst Instance=new A258166Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258167
{
public static readonly long[] Value={ 231L,729L,818L,911L,1730L,1731L,2031L,2032L,2033L,2788L,3420L,3682L,3683L,3685L,3796L,4265L,4486L,4655L,4656L,4657L,4692L,5206L,5207L,5445L,5446L,5783L,5836L,5837L,5840L,6051L,6063L,8758L,9756L,9757L,9954L,9979L,10003L,10006L,10123L,10303L,10321L,10416L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258167Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258167.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258167Inst : IEnumerable<long>
{
public static readonly long[] Value=A258167.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258167.Bytes);
public long this[int i]=>Value[i];

public static A258167Inst Instance=new A258167Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258168
{
public static readonly long[] Value={ 3L,4L,3L,4L,5L,4L,4L,4L,4L,7L,4L,5L,6L,4L,5L,5L,4L,5L,4L,3L,5L,6L,4L,6L,5L,6L,5L,5L,3L,6L,6L,7L,3L,7L,5L,8L,8L,5L,5L,9L,5L,4L,6L,7L,4L,7L,5L,6L,7L,5L,4L,5L,4L,7L,8L,6L,6L,8L,4L,8L,7L,5L,8L,7L,4L,7L,5L,7L,4L,6L,6L,13L,7L,7L,6L,8L,4L,10L,10L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258168Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258168.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258168Inst : IEnumerable<long>
{
public static readonly long[] Value=A258168.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258168.Bytes);
public long this[int i]=>Value[i];

public static A258168Inst Instance=new A258168Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258169
{
public static readonly BigInteger[] Value={ 1L,2L,16L,32768L,72057594037927936L,BigInteger.Parse("822752278660603021077484591278675252491367932816789931674304512") };
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
public class A258169Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258169.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258169Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258169.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A258169.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258169Inst Instance=new A258169Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258170
{
public static readonly long[] Value={ 0L,0L,1L,0L,2L,1L,0L,3L,3L,1L,0L,4L,8L,6L,1L,0L,5L,15L,25L,10L,1L,0L,6L,36L,91L,65L,15L,1L,0L,7L,63L,301L,350L,140L,21L,1L,0L,8L,136L,972L,1702L,1050L,266L,28L,1L,0L,9L,261L,3027L,7770L,6951L,2646L,462L,36L,1L,0L,10L,530L,9355L,34115L,42526L,22827L,5880L,750L,45L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258170Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258170.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258170Inst : IEnumerable<long>
{
public static readonly long[] Value=A258170.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258170.Bytes);
public long this[int i]=>Value[i];

public static A258170Inst Instance=new A258170Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258171
{
public static readonly long[] Value={ 0L,1L,3L,7L,19L,56L,214L,883L,4163L,21163L,116039L,678580L,4213848L,27644449L,190900217L,1382958677L,10480146333L,82864869820L,682076827740L,5832742205075L,51724158351527L,474869816158547L,4506715739125923L,44152005855084368L,445958869299027638L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258171Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258171.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258171Inst : IEnumerable<long>
{
public static readonly long[] Value=A258171.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258171.Bytes);
public long this[int i]=>Value[i];

public static A258171Inst Instance=new A258171Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258172
{
public static readonly BigInteger[] Value={ 1L,1L,5L,40L,434L,5901L,95997L,1812525L,38875265L,932135347L,24678938063L,714385754446L,22428656766320L,758632387171075L,27489135956517315L,1061913384743418360L,BigInteger.Parse("43550536908458238570"),BigInteger.Parse("1889211624465639489675"),BigInteger.Parse("86406059558668152123975"),BigInteger.Parse("4154647501527354507485040") };
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
public class A258172Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258172.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258172Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258172.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A258172.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258172Inst Instance=new A258172Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258173
{
public static readonly ulong[] Value={ 1L,1L,3L,12L,58L,321L,1975L,13265L,96073L,743753L,6113769L,53086314L,484861924L,4641853003L,46441475253L,484327870652L,5252981412262L,59132909030463L,689642443691329L,8319172260103292L,103645882500123026L,1331832693574410475L,17629142345935969713UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258173Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258173.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258173Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A258173.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258173.Bytes);
public ulong this[int i]=>Value[i];

public static A258173Inst Instance=new A258173Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258174
{
public static readonly BigInteger[] Value={ 1L,1L,7L,84L,1486L,35753L,1111931L,43150593L,2035666985L,114412223081L,7538224510181L,574552299138202L,50096579094908148L,4949493445607316419L,BigInteger.Parse("549534510282406667069"),BigInteger.Parse("68071071679372210762156"),BigInteger.Parse("9347203754680124767253730"),BigInteger.Parse("1414740620049957735248175695") };
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
public class A258174Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258174.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258174Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258174.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A258174.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258174Inst Instance=new A258174Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258175
{
public static readonly BigInteger[] Value={ 1L,2L,12L,114L,1448L,22770L,424164L,9095450L,220023184L,5914998594L,174682531260L,5614908340866L,194967208057272L,7267467723747218L,289270983756577620L,12239218862861690250UL,BigInteger.Parse("548301077168477951520"),BigInteger.Parse("25918121712918957399426"),BigInteger.Parse("1288797080051656060595820") };
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
public class A258175Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258175.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258175Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258175.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A258175.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258175Inst Instance=new A258175Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258176
{
public static readonly BigInteger[] Value={ 1L,1L,7L,142L,9354L,2503597L,3260627607L,24105227716863L,1028836978599566213L,BigInteger.Parse("290383808553140390346475"),BigInteger.Parse("511963364817949502725911280781"),BigInteger.Parse("6704846980724405836568589845161191576"),BigInteger.Parse("584709361918378923208855262622537662297053728") };
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
public class A258176Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258176.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258176Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258176.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A258176.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258176Inst Instance=new A258176Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258177
{
public static readonly BigInteger[] Value={ 1L,1L,5L,112L,15312L,22928885L,475971133797L,164769697242392241L,BigInteger.Parse("1674694178196441599627207"),BigInteger.Parse("434453335415659344048321288040053"),BigInteger.Parse("2772047111897899211702422870954450438220795"),BigInteger.Parse("919691726760748842849028933552012720445531166591469510") };
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
public class A258177Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258177.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258177Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258177.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A258177.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258177Inst Instance=new A258177Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258178
{
public static readonly BigInteger[] Value={ 1L,1L,13L,414L,24324L,2279209L,311524201L,58467947511L,14424374692879L,4525566110365523L,1759527523008436279L,BigInteger.Parse("830255082140922306224"),BigInteger.Parse("467382831980334193769718"),BigInteger.Parse("309419146352957449765072455"),BigInteger.Parse("237980526477430552734199922151"),BigInteger.Parse("210427994109788912088395561755374") };
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
public class A258178Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258178.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258178Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258178.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A258178.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258178Inst Instance=new A258178Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258179
{
public static readonly BigInteger[] Value={ 1L,1L,5L,34L,312L,3649L,52161L,889843L,17796555L,411120395L,10838039407L,322752018060L,10762432731362L,398802951148255L,16312276452291935L,732189190349581890L,BigInteger.Parse("35876807697443520000"),BigInteger.Parse("1910107567584518883891"),BigInteger.Parse("110035833179472385285367"),BigInteger.Parse("6832792252684597270659486") };
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
public class A258179Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258179.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258179Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258179.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A258179.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258179Inst Instance=new A258179Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258180
{
public static readonly BigInteger[] Value={ 1L,1L,4L,33L,517L,15326L,852912L,91023697L,19716262702L,8794395041567L,8016790849841585L,15556074485786226848UL,BigInteger.Parse("64891787190080888991273"),BigInteger.Parse("561815453349204340865790817"),BigInteger.Parse("10402242033224422585780623039909"),BigInteger.Parse("423787530114579490372987256671625678") };
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
public class A258180Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258180.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258180Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258180.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A258180.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258180Inst Instance=new A258180Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258181
{
public static readonly BigInteger[] Value={ 1L,1L,5L,89L,5933L,1540161L,1584150165L,6497470064169L,106497075348688637L,BigInteger.Parse("6980195689972655145233"),BigInteger.Parse("1829876050804408046228327525"),BigInteger.Parse("1918781572083632396857805205324025"),BigInteger.Parse("8047973452254281276702044410544321359565"),BigInteger.Parse("135022681866797995009325363468217320506328688097") };
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
public class A258181Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258181.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258181Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258181.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A258181.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258181Inst Instance=new A258181Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258182
{
public static readonly BigInteger[] Value={ 7L,43L,4167L,857143L,909091L,1443299L,4166667L,92857143L,2205882353L,2792792793L,1046511627907L,5737704918033L,19083969465649L,53947368421053L,55882352941177L,772727272727273L,2962962962962962963L,5806451612903225807L,BigInteger.Parse("263888888888888888889") };
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
public class A258182Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258182.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258182Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258182.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A258182.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258182Inst Instance=new A258182Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258183
{
public static readonly long[] Value={ 7L,9L,49L,111L,1090909L,28571427L,111111111L,3333333327L,25641025641L,10576923076923L,59090909090909L,2631578947368421L,4827586206896549L,8947368421052631L,18644067796610169L,111111111111111111L,812499999999999999L,1889250814332247557L,9189189189189189189L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258183Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258183.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258183Inst : IEnumerable<long>
{
public static readonly long[] Value=A258183.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258183.Bytes);
public long this[int i]=>Value[i];

public static A258183Inst Instance=new A258183Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258184
{
public static readonly long[] Value={ 1L,3L,7L,61L,167L,801L,1143L,2001L,6001L,8001L,125001L,25000001L,181818181819L,2500000000001L,16666666666667L,45000000000001L,640000000000001L,1142857142857143L,4000000000000001L,37500000000000001L,153846153846153847L,937500000000000001L,2881355932203389831L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258184Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258184.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258184Inst : IEnumerable<long>
{
public static readonly long[] Value=A258184.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258184.Bytes);
public long this[int i]=>Value[i];

public static A258184Inst Instance=new A258184Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258185
{
public static readonly long[] Value={ 2L,3L,5L,11L,17L,29L,71L,101L,149L,197L,269L,419L,523L,599L,617L,641L,683L,761L,857L,997L,1061L,1063L,1091L,1151L,1201L,1277L,1289L,1409L,1531L,1571L,1607L,1753L,1789L,1987L,2027L,2039L,2111L,2129L,2161L,2267L,2309L,2339L,2503L,2687L,2753L,2999L,3049L,3067L,3257L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258185Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258185.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258185Inst : IEnumerable<long>
{
public static readonly long[] Value=A258185.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258185.Bytes);
public long this[int i]=>Value[i];

public static A258185Inst Instance=new A258185Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258186
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,2L,2L,3L,3L,6L,6L,7L,7L,10L,10L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258186Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258186.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258186Inst : IEnumerable<long>
{
public static readonly long[] Value=A258186.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258186.Bytes);
public long this[int i]=>Value[i];

public static A258186Inst Instance=new A258186Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258187
{
public static readonly long[] Value={ 3L,4L,5L,6L,7L,8L,9L,11L,12L,13L,14L,15L,17L,18L,19L,20L,21L,23L,24L,25L,27L,29L,30L,31L,32L,33L,35L,37L,38L,39L,41L,42L,43L,44L,45L,47L,48L,49L,51L,53L,54L,55L,57L,59L,60L,61L,62L,63L,65L,67L,68L,69L,71L,72L,73L,74L,75L,77L,79L,80L,81L,83L,84L,85L,87L,89L,90L,91L,93L,95L,97L,98L,99L,101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258187Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258187.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258187Inst : IEnumerable<long>
{
public static readonly long[] Value=A258187.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258187.Bytes);
public long this[int i]=>Value[i];

public static A258187Inst Instance=new A258187Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258188
{
public static readonly long[] Value={ 21L,42L,63L,14L,35L,56L,7L,28L,49L,210L,511L,112L,413L,714L,315L,616L,217L,518L,119L,420L,721L,322L,623L,224L,525L,126L,427L,728L,329L,630L,231L,532L,133L,434L,735L,336L,637L,238L,539L,140L,441L,742L,343L,644L,245L,546L,147L,448L,749L,350L,651L,252L,553L,154L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258188Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258188.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258188Inst : IEnumerable<long>
{
public static readonly long[] Value=A258188.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258188.Bytes);
public long this[int i]=>Value[i];

public static A258188Inst Instance=new A258188Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258189
{
public static readonly long[] Value={ 10101L,11111L,101121L,220212L,222001L,1022011L,1111221L,2010002L,2101001L,2121001L,10101022L,10122201L,10201001L,10212111L,11111112L,11121201L,12010221L,20210202L,21121121L,100001111L,101010101L,102112011L,110020001L,112112001L,12000211L,122000101L,201201201L,202212002L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258189Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258189.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258189Inst : IEnumerable<long>
{
public static readonly long[] Value=A258189.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258189.Bytes);
public long this[int i]=>Value[i];

public static A258189Inst Instance=new A258189Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258190
{
public static readonly long[] Value={ 11L,3L,7L,19L,211L,13L,17L,419L,421L,23L,127L,29L,31L,233L,37L,139L,41L,43L,47L,149L,151L,53L,157L,59L,61L,163L,67L,269L,71L,73L,277L,79L,181L,83L,487L,89L,191L,193L,97L,199L,101L,103L,107L,109L,2111L,113L,1117L,3119L,3121L,1123L,4127L,1129L,131L,4133L,137L,4139L,2141L,2143L,5147L,11149L,1151L,1153L,4157L,4159L,2161L,1163L,167L,3169L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258190Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258190.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258190Inst : IEnumerable<long>
{
public static readonly long[] Value=A258190.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258190.Bytes);
public long this[int i]=>Value[i];

public static A258190Inst Instance=new A258190Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258191
{
public static readonly BigInteger[] Value={ 1L,11L,293L,487L,129952159L,13084761625L,8277192566411L,576489266167410341L,BigInteger.Parse("2154341459717480222819111"),BigInteger.Parse("1562388737113054944319018297"),BigInteger.Parse("4507453407946726622146977923716952747"),BigInteger.Parse("46170199302621715634236277404186409941"),BigInteger.Parse("20107953791404084220109855379873778475523352268948164789") };
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
public class A258191Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258191.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258191Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258191.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A258191.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258191Inst Instance=new A258191Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258192
{
public static readonly BigInteger[] Value={ 6L,420L,72072L,760760L,1266697832400L,783333734619744L,3002950101013562700L,BigInteger.Parse("1253414030788528596187200"),BigInteger.Parse("27809824888100301666382826331840"),BigInteger.Parse("118802724769051077369996224554510800"),BigInteger.Parse("2005396188718644499811084404372455793370133120") };
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
public class A258192Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258192.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258192Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258192.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A258192.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258192Inst Instance=new A258192Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258193
{
public static readonly long[] Value={ 0L,0L,0L,0L,3L,3L,11L,0L,5L,3L,3L,17L,7L,23L,53L,29L,13L,5L,5L,3L,11L,3L,3L,823L,13L,7L,7L,457L,109L,109L,233L,2267L,17L,59L,151L,5L,19L,5L,5L,3L,113L,11L,11L,3L,23L,3L,3L,71L,43L,13L,13L,7L,179L,7L,7L,193L,29L,2137L,863L,443L,31L,5498157739L,977L,163L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258193Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258193.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258193Inst : IEnumerable<long>
{
public static readonly long[] Value=A258193.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258193.Bytes);
public long this[int i]=>Value[i];

public static A258193Inst Instance=new A258193Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258194
{
public static readonly long[] Value={ 1L,2L,3L,4L,8L,82L,107L,166L,178L,250L,298L,359L,490L,503L,514L,597L,634L,647L,730L,740L,756L,759L,850L,866L,908L,922L,928L,980L,1043L,1079L,1224L,1361L,1377L,1462L,1463L,1480L,1484L,1518L,1564L,1582L,1702L,1724L,1732L,1822L,1882L,1885L,1935L,1955L,1970L,2198L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258194Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258194.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258194Inst : IEnumerable<long>
{
public static readonly long[] Value=A258194.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258194.Bytes);
public long this[int i]=>Value[i];

public static A258194Inst Instance=new A258194Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258195
{
public static readonly long[] Value={ 3L,5L,7L,17L,19L,23L,11L,13L,53L,37L,47L,43L,29L,61L,31L,41L,83L,79L,73L,103L,137L,109L,113L,151L,149L,139L,193L,157L,167L,71L,199L,229L,179L,181L,223L,191L,107L,173L,97L,269L,241L,101L,59L,233L,197L,227L,251L,263L,89L,211L,239L,131L,293L,67L,307L,379L,277L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258195Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258195.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258195Inst : IEnumerable<long>
{
public static readonly long[] Value=A258195.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258195.Bytes);
public long this[int i]=>Value[i];

public static A258195Inst Instance=new A258195Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258196
{
public static readonly long[] Value={ 1L,0L,-1L,-2L,-1L,2L,0L,2L,0L,0L,1L,0L,2L,-2L,-1L,0L,-2L,-2L,0L,0L,0L,0L,2L,0L,-1L,0L,2L,0L,0L,2L,-1L,2L,0L,2L,0L,0L,-2L,-2L,0L,0L,0L,-2L,-2L,0L,1L,0L,0L,-2L,2L,0L,-2L,2L,-1L,0L,0L,-2L,2L,2L,2L,0L,0L,0L,2L,0L,2L,0L,0L,0L,0L,0L,-1L,-2L,-2L,2L,0L,-2L,0L,2L,-2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258196Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258196.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258196Inst : IEnumerable<long>
{
public static readonly long[] Value=A258196.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258196.Bytes);
public long this[int i]=>Value[i];

public static A258196Inst Instance=new A258196Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258197
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,0L,1L,1L,0L,0L,4L,5L,4L,0L,0L,1L,7L,7L,1L,0L,0L,5L,8L,24L,8L,5L,0L,0L,1L,10L,12L,12L,10L,1L,0L,0L,12L,32L,92L,59L,92L,32L,12L,0L,0L,6L,60L,124L,165L,165L,124L,60L,6L,0L,0L,7L,39L,244L,247L,456L,247L,244L,39L,7L,0L,0L,1L,16L,103L,371L,493L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258197Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258197.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258197Inst : IEnumerable<long>
{
public static readonly long[] Value=A258197.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258197.Bytes);
public long this[int i]=>Value[i];

public static A258197Inst Instance=new A258197Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258198
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,4L,4L,4L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258198Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258198.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258198Inst : IEnumerable<long>
{
public static readonly long[] Value=A258198.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258198.Bytes);
public long this[int i]=>Value[i];

public static A258198Inst Instance=new A258198Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258199
{
public static readonly long[] Value={ 0L,1L,1L,1L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,18L,18L,18L,18L,18L,18L,18L,18L,18L,18L,18L,18L,18L,18L,18L,18L,18L,18L,18L,18L,18L,18L,18L,18L,18L,18L,18L,18L,18L,18L,18L,18L,18L,18L,18L,18L,18L,18L,18L,18L,18L,18L,18L,18L,18L,18L,18L,18L,18L,18L,18L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258199Inst : IEnumerable<long>
{
public static readonly long[] Value=A258199.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258199.Bytes);
public long this[int i]=>Value[i];

public static A258199Inst Instance=new A258199Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258200
{
public static readonly long[] Value={ 3L,19L,3L,19L,3L,19L,3L,19L,3L,13L,6L,3L,7L,6L,6L,3L,7L,6L,6L,3L,13L,6L,3L,3L,10L,6L,3L,3L,10L,6L,3L,3L,16L,3L,3L,16L,3L,3L,19L,3L,7L,12L,3L,19L,3L,7L,12L,3L,19L,3L,19L,3L,19L,3L,19L,3L,13L,6L,3L,7L,6L,6L,3L,7L,6L,6L,3L,13L,6L,3L,3L,10L,6L,3L,3L,10L,6L,3L,3L,16L,3L,3L,16L,3L,3L,19L,3L,7L,12L,3L,19L,3L,19L,3L,19L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258200Inst : IEnumerable<long>
{
public static readonly long[] Value=A258200.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258200.Bytes);
public long this[int i]=>Value[i];

public static A258200Inst Instance=new A258200Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258201
{
public static readonly long[] Value={ 0L,1L,-3L,-3L,1L,-4L,-3L,0L,-7L,-3L,0L,-226L,-3L,0L,0L,-3L,0L,-3L,-3L,0L,-3L,-3L,0L,1L,-3L,-3L,1L,-4L,-3L,0L,-7L,-3L,0L,-76L,-3L,0L,0L,-3L,0L,-3L,-3L,0L,-3L,-3L,0L,1L,-3L,-3L,1L,-4L,-3L,0L,-7L,-3L,0L,-46L,-3L,0L,-7L,-3L,0L,-3L,-3L,0L,-3L,-3L,0L,1L,-3L,-3L,1L,-4L,-3L,0L,-6L,-3L,0L,-33L,-3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258201Inst : IEnumerable<long>
{
public static readonly long[] Value=A258201.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258201.Bytes);
public long this[int i]=>Value[i];

public static A258201Inst Instance=new A258201Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258202
{
public static readonly long[] Value={ 121L,143L,476L,498L,831L,853L,1076L,1186L,1208L,1541L,1563L,1786L,1896L,1918L,2251L,2273L,2606L,2628L,2961L,2983L,3316L,3338L,3561L,3671L,3693L,4026L,4048L,4381L,4403L,4736L,4758L,5091L,5113L,5336L,5446L,5468L,5801L,5823L,6156L,6178L,6511L,6533L,6866L,6888L,7221L,7243L,7576L,7598L,7821L,7931L,7953L,8286L,8308L,8641L,8663L,8996L,9018L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258202Inst : IEnumerable<long>
{
public static readonly long[] Value=A258202.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258202.Bytes);
public long this[int i]=>Value[i];

public static A258202Inst Instance=new A258202Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258203
{
public static readonly long[] Value={ 1L,4L,23L,26L,45L,48L,67L,70L,89L,92L,105L,111L,114L,127L,133L,136L,149L,155L,158L,171L,177L,180L,183L,193L,199L,202L,205L,215L,221L,224L,227L,243L,246L,249L,265L,268L,271L,290L,293L,300L,312L,315L,334L,337L,344L,356L,359L,378L,381L,400L,403L,422L,425L,444L,447L,460L,466L,469L,482L,488L,491L,504L,510L,513L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258203Inst : IEnumerable<long>
{
public static readonly long[] Value=A258203.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258203.Bytes);
public long this[int i]=>Value[i];

public static A258203Inst Instance=new A258203Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258204
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,1L,3L,3L,16L,23L,80L,183L,563L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258204Inst : IEnumerable<long>
{
public static readonly long[] Value=A258204.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258204.Bytes);
public long this[int i]=>Value[i];

public static A258204Inst Instance=new A258204Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258205
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,1L,3L,1L,8L,5L,20L,11L,61L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258205Inst : IEnumerable<long>
{
public static readonly long[] Value=A258205.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258205.Bytes);
public long this[int i]=>Value[i];

public static A258205Inst Instance=new A258205Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258206
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,1L,3L,2L,12L,14L,50L,97L,312L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258206Inst : IEnumerable<long>
{
public static readonly long[] Value=A258206.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258206.Bytes);
public long this[int i]=>Value[i];

public static A258206Inst Instance=new A258206Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258207
{
public static readonly long[] Value={ 1L,3L,1L,5L,3L,1L,7L,7L,3L,1L,9L,9L,7L,3L,1L,11L,13L,9L,7L,3L,1L,13L,15L,13L,9L,7L,3L,1L,15L,19L,15L,13L,9L,7L,3L,1L,17L,21L,21L,15L,13L,9L,7L,3L,1L,19L,25L,25L,21L,15L,13L,9L,7L,3L,1L,21L,27L,27L,25L,21L,15L,13L,9L,7L,3L,1L,23L,31L,31L,31L,25L,21L,15L,13L,9L,7L,3L,1L,25L,33L,33L,33L,31L,25L,21L,15L,13L,9L,7L,3L,1L,27L,37L,37L,37L,33L,31L,25L,21L,15L,13L,9L,7L,3L,1L,29L,39L,43L,43L,37L,33L,31L,25L,21L,15L,13L,9L,7L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258207Inst : IEnumerable<long>
{
public static readonly long[] Value=A258207.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258207.Bytes);
public long this[int i]=>Value[i];

public static A258207Inst Instance=new A258207Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258208
{
public static readonly long[] Value={ 1L,1L,3L,1L,3L,5L,1L,3L,7L,7L,1L,3L,7L,9L,9L,1L,3L,7L,9L,13L,11L,1L,3L,7L,9L,13L,15L,13L,1L,3L,7L,9L,13L,15L,19L,15L,1L,3L,7L,9L,13L,15L,21L,21L,17L,1L,3L,7L,9L,13L,15L,21L,25L,25L,19L,1L,3L,7L,9L,13L,15L,21L,25L,27L,27L,21L,1L,3L,7L,9L,13L,15L,21L,25L,31L,31L,31L,23L,1L,3L,7L,9L,13L,15L,21L,25L,31L,33L,33L,33L,25L,1L,3L,7L,9L,13L,15L,21L,25L,31L,33L,37L,37L,37L,27L,1L,3L,7L,9L,13L,15L,21L,25L,31L,33L,37L,43L,43L,39L,29L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258208Inst : IEnumerable<long>
{
public static readonly long[] Value=A258208.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258208.Bytes);
public long this[int i]=>Value[i];

public static A258208Inst Instance=new A258208Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258209
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,6L,7L,8L,12L,14L,15L,16L,24L,26L,28L,30L,31L,32L,48L,52L,56L,58L,60L,62L,63L,64L,96L,100L,104L,106L,112L,118L,120L,122L,124L,126L,127L,128L,192L,200L,208L,212L,224L,228L,234L,236L,240L,246L,248L,250L,252L,254L,255L,256L,384L,392L,400L,416L,420L,424L,426L,448L,460L,466L,472L,474L,480L,484L,490L,494L,496L,502L,504L,506L,508L,510L,511L,512L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258209Inst : IEnumerable<long>
{
public static readonly long[] Value=A258209.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258209.Bytes);
public long this[int i]=>Value[i];

public static A258209Inst Instance=new A258209Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258210
{
public static readonly long[] Value={ 1L,-1L,-2L,0L,1L,4L,0L,0L,-2L,-4L,2L,0L,0L,-2L,0L,0L,1L,4L,4L,0L,-4L,0L,0L,0L,0L,-3L,-4L,0L,0L,4L,0L,0L,-2L,0L,2L,0L,4L,-2L,0L,0L,2L,4L,0L,0L,0L,-8L,0L,0L,0L,-1L,-6L,0L,2L,4L,0L,0L,0L,0L,2L,0L,0L,-2L,0L,0L,1L,8L,0L,0L,-4L,0L,0L,0L,4L,-2L,-4L,0L,0L,0L,0L,0L,-4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258210Inst : IEnumerable<long>
{
public static readonly long[] Value=A258210.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258210.Bytes);
public long this[int i]=>Value[i];

public static A258210Inst Instance=new A258210Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258211
{
public static readonly long[] Value={ 18L,50L,54L,90L,98L,126L,150L,162L,198L,234L,242L,250L,270L,294L,306L,338L,342L,350L,378L,414L,450L,486L,490L,522L,550L,558L,578L,594L,630L,650L,666L,686L,702L,722L,726L,738L,750L,774L,810L,846L,850L,882L,918L,950L,954L,990L,1014L,1026L,1050L,1058L,1062L,1078L,1098L,1134L,1150L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258211Inst : IEnumerable<long>
{
public static readonly long[] Value=A258211.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258211.Bytes);
public long this[int i]=>Value[i];

public static A258211Inst Instance=new A258211Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258212
{
public static readonly long[] Value={ 0L,1L,3L,2L,6L,4L,11L,8L,7L,19L,5L,12L,14L,32L,9L,21L,24L,20L,53L,16L,13L,15L,33L,35L,40L,87L,10L,22L,25L,27L,55L,58L,66L,54L,142L,17L,37L,42L,45L,34L,36L,41L,88L,90L,95L,108L,231L,29L,23L,26L,28L,56L,59L,61L,67L,69L,74L,144L,147L,155L,176L,143L,375L,18L,38L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258212Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258212.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258212Inst : IEnumerable<long>
{
public static readonly long[] Value=A258212.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258212.Bytes);
public long this[int i]=>Value[i];

public static A258212Inst Instance=new A258212Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258213
{
public static readonly long[] Value={ 1L,1L,2L,6L,12L,72L,144L,1440L,2880L,43200L,86400L,1814400L,3628800L,101606400L,203212800L,7315660800L,14631321600L,658409472000L,1316818944000L,72425041920000L,144850083840000L,9560105533440000L,19120211066880000L,1491376463216640000L,2982752926433280000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258213Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258213.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258213Inst : IEnumerable<long>
{
public static readonly long[] Value=A258213.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258213.Bytes);
public long this[int i]=>Value[i];

public static A258213Inst Instance=new A258213Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258214
{
public static readonly long[] Value={ 43L,257L,12113L,84131L,96137L,168143L,372167L,32041181L,120409349L,139129379L,292681547L,410881643L,516961727L,528529733L,863041937L,966289991L,10629611033L,10670891039L,11902811093L,16307291279L,21112091459L,25058891597L,29618411723L,31933691789L,35006411873L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258214Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258214.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258214Inst : IEnumerable<long>
{
public static readonly long[] Value=A258214.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258214.Bytes);
public long this[int i]=>Value[i];

public static A258214Inst Instance=new A258214Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258215
{
public static readonly long[] Value={ 0L,1L,3L,2L,4L,6L,3L,5L,5L,7L,9L,4L,6L,8L,6L,8L,8L,10L,12L,5L,7L,7L,9L,11L,7L,9L,11L,9L,11L,11L,13L,15L,6L,8L,10L,8L,10L,10L,12L,14L,8L,10L,10L,12L,14L,10L,12L,14L,12L,14L,14L,16L,18L,7L,9L,9L,11L,13L,9L,11L,13L,11L,13L,13L,15L,17L,9L,11L,13L,11L,13L,13L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258215Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258215.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258215Inst : IEnumerable<long>
{
public static readonly long[] Value=A258215.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258215.Bytes);
public long this[int i]=>Value[i];

public static A258215Inst Instance=new A258215Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258216
{
public static readonly long[] Value={ 1L,1L,2L,6L,24L,120L,480L,3600L,30240L,151200L,1693440L,20321280L,121927680L,1828915200L,28740096000L,201180672000L,3793692672000L,73977007104000L,591816056832000L,13463815292928000L,314155690168320000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258216Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258216.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258216Inst : IEnumerable<long>
{
public static readonly long[] Value=A258216.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258216.Bytes);
public long this[int i]=>Value[i];

public static A258216Inst Instance=new A258216Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258217
{
public static readonly long[] Value={ 14L,21L,35L,42L,56L,63L,7L,84L,91L,105L,112L,126L,133L,140L,154L,161L,175L,182L,196L,203L,210L,224L,231L,245L,252L,266L,273L,28L,294L,301L,315L,322L,336L,343L,350L,364L,371L,385L,392L,406L,413L,420L,434L,441L,455L,462L,476L,483L,49L,504L,511L,525L,532L,546L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258217Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258217.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258217Inst : IEnumerable<long>
{
public static readonly long[] Value=A258217.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258217.Bytes);
public long this[int i]=>Value[i];

public static A258217Inst Instance=new A258217Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258218
{
public static readonly long[] Value={ 3L,14L,22L,30L,38L,46L,0L,248L,70L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258218Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258218.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258218Inst : IEnumerable<long>
{
public static readonly long[] Value=A258218.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258218.Bytes);
public long this[int i]=>Value[i];

public static A258218Inst Instance=new A258218Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258219
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,4L,1L,3L,10L,25L,1L,4L,18L,74L,208L,1L,5L,28L,153L,706L,2146L,1L,6L,40L,268L,1638L,8162L,26368L,1L,7L,54L,425L,3172L,20898L,110410L,375733L,1L,8L,70L,630L,5500L,44164L,307908L,1708394L,6092032L,1L,9L,88L,889L,8838L,82850L,702844L,5134293L,29752066L,110769550L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258219Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258219.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258219Inst : IEnumerable<long>
{
public static readonly long[] Value=A258219.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258219.Bytes);
public long this[int i]=>Value[i];

public static A258219Inst Instance=new A258219Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258220
{
public static readonly long[] Value={ 1L,1L,1L,4L,6L,1L,25L,49L,15L,1L,208L,498L,217L,28L,1L,2146L,6016L,3360L,635L,45L,1L,26368L,84042L,56728L,13997L,1475L,66L,1L,375733L,1332661L,1046619L,316281L,43974L,2954L,91L,1L,6092032L,23660034L,21053089L,7479444L,1283817L,114576L,5334L,120L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258220Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258220.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258220Inst : IEnumerable<long>
{
public static readonly long[] Value=A258220.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258220.Bytes);
public long this[int i]=>Value[i];

public static A258220Inst Instance=new A258220Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258221
{
public static readonly BigInteger[] Value={ 1L,2L,11L,90L,952L,12203L,182677L,3118314L,59688447L,1265193199L,29408221404L,743677646836L,20325564686926L,597051775012306L,18758388926380409L,627712133246362442L,BigInteger.Parse("22288938527631882996"),BigInteger.Parse("837033514431748421053"),BigInteger.Parse("33146037056721682537319"),BigInteger.Parse("1380365444443138768970878") };
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
public class A258221Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258221.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258221Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258221.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A258221.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258221Inst Instance=new A258221Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258222
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,1L,3L,10L,5L,1L,4L,24L,74L,14L,1L,5L,44L,297L,706L,42L,1L,6L,70L,764L,4896L,8162L,132L,1L,7L,102L,1565L,17924L,100278L,110410L,429L,1L,8L,140L,2790L,47650L,527844L,2450304L,1708394L,1430L,1L,9L,184L,4529L,104454L,1831250L,18685164L,69533397L,29752066L,4862L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258222Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258222.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258222Inst : IEnumerable<long>
{
public static readonly long[] Value=A258222.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258222.Bytes);
public long this[int i]=>Value[i];

public static A258222Inst Instance=new A258222Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258223
{
public static readonly long[] Value={ 1L,1L,1L,2L,8L,3L,5L,69L,77L,15L,14L,692L,1749L,890L,105L,42L,8120L,41998L,41909L,12039L,945L,132L,110278L,1114808L,1944225L,1018865L,186594L,10395L,429L,1707965L,33058519L,94833341L,80595226L,25798856L,3260067L,135135L,1430L,29750636L,1093994697L,4979407614L,6439957299L,3201618970L,687652446L,63390060L,2027025L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258223Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258223.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258223Inst : IEnumerable<long>
{
public static readonly long[] Value=A258223.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258223.Bytes);
public long this[int i]=>Value[i];

public static A258223Inst Instance=new A258223Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258224
{
public static readonly BigInteger[] Value={ 1L,2L,13L,166L,3450L,105053L,4385297L,239389538L,16497800177L,1396841773631L,142194450687440L,17100401655609460L,2394468068218870494L,BigInteger.Parse("385647096554809325098"),BigInteger.Parse("70702689662684594772871"),BigInteger.Parse("14623755150209185924416598"),BigInteger.Parse("3385915623744083331349813602") };
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
public class A258224Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258224.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258224Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258224.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A258224.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258224Inst Instance=new A258224Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258225
{
public static readonly long[] Value={ 7L,4L,1L,8L,5L,2L,9L,6L,3L,70L,37L,104L,71L,38L,105L,72L,39L,106L,73L,40L,107L,74L,41L,108L,75L,42L,109L,76L,43L,10L,77L,44L,11L,78L,45L,12L,79L,46L,13L,80L,47L,14L,81L,48L,15L,82L,49L,16L,83L,50L,17L,84L,51L,18L,85L,52L,19L,86L,53L,20L,87L,54L,21L,88L,55L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258225Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258225.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258225Inst : IEnumerable<long>
{
public static readonly long[] Value=A258225.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258225.Bytes);
public long this[int i]=>Value[i];

public static A258225Inst Instance=new A258225Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258226
{
public static readonly long[] Value={ 3L,6L,9L,2L,5L,8L,1L,4L,7L,30L,33L,36L,39L,42L,45L,48L,51L,54L,57L,60L,63L,66L,69L,72L,75L,78L,81L,84L,87L,90L,93L,96L,99L,102L,105L,108L,11L,14L,17L,20L,23L,26L,29L,32L,35L,38L,41L,44L,47L,50L,53L,56L,59L,62L,65L,68L,71L,74L,77L,80L,83L,86L,89L,92L,95L,98L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258226Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258226.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258226Inst : IEnumerable<long>
{
public static readonly long[] Value=A258226.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258226.Bytes);
public long this[int i]=>Value[i];

public static A258226Inst Instance=new A258226Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258227
{
public static readonly long[] Value={ 12L,3L,45L,6L,78L,9L,1011L,12L,1314L,15L,1617L,18L,192L,0L,2L,12L,2L,2L,32L,4L,2L,52L,6L,2L,72L,8L,2L,930L,3L,132L,3L,3L,3L,435L,3L,6L,3L,738L,3L,9L,4041L,42L,4L,34L,4L,4L,54L,6L,4L,74L,8L,4L,950L,5L,15L,25L,35L,45L,5L,5L,65L,75L,85L,960L,6L,16L,2L,6L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258227Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258227.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258227Inst : IEnumerable<long>
{
public static readonly long[] Value=A258227.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258227.Bytes);
public long this[int i]=>Value[i];

public static A258227Inst Instance=new A258227Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258228
{
public static readonly long[] Value={ 1L,1L,-2L,0L,1L,-4L,0L,0L,-2L,4L,2L,0L,0L,2L,0L,0L,1L,-4L,4L,0L,-4L,0L,0L,0L,0L,3L,-4L,0L,0L,-4L,0L,0L,-2L,0L,2L,0L,4L,2L,0L,0L,2L,-4L,0L,0L,0L,8L,0L,0L,0L,1L,-6L,0L,2L,-4L,0L,0L,0L,0L,2L,0L,0L,2L,0L,0L,1L,-8L,0L,0L,-4L,0L,0L,0L,4L,2L,-4L,0L,0L,0L,0L,0L,-4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258228Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258228.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258228Inst : IEnumerable<long>
{
public static readonly long[] Value=A258228.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258228.Bytes);
public long this[int i]=>Value[i];

public static A258228Inst Instance=new A258228Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258229
{
public static readonly BigInteger[] Value={ 1L,5L,41L,188L,20777L,126661L,375407075L,4551271607L,2186878968457691L,405572061653677013L,BigInteger.Parse("579868609560670025014303"),BigInteger.Parse("756499881167742750802544581"),BigInteger.Parse("90137667815984749912207449629"),BigInteger.Parse("12095883009361301429642260272492831583"),BigInteger.Parse("83142433646555338064479023776802561123293") };
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
public class A258229Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258229.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258229Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258229.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A258229.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258229Inst Instance=new A258229Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258230
{
public static readonly BigInteger[] Value={ 2L,12L,105L,495L,55440L,340340L,1012647636L,12304749600L,5920545668637600L,1098951951860282520L,BigInteger.Parse("1572101004939647757775200"),BigInteger.Parse("2051717579526635495717258016"),BigInteger.Parse("244523633377266327241371614400"),BigInteger.Parse("32818916025992059215981780272862841200") };
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
public class A258230Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258230.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258230Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258230.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A258230.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258230Inst Instance=new A258230Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258231
{
public static readonly long[] Value={ 1L,4762L,4832L,10376L,10493L,11205L,12385L,14829L,23506L,24605L,26394L,34196L,36215L,48302L,49827L,68474L,71205L,72576L,74528L,79286L,79603L,79836L,94583L,94867L,96123L,98376L,100469L,100496L,100498L,100499L,100946L,102245L,102953L,103265L,103479L,103756L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258231Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258231.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258231Inst : IEnumerable<long>
{
public static readonly long[] Value=A258231.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258231.Bytes);
public long this[int i]=>Value[i];

public static A258231Inst Instance=new A258231Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258232
{
public static readonly long[] Value={ 3L,6L,8L,4L,1L,2L,5L,3L,5L,9L,3L,1L,4L,3L,3L,6L,5L,2L,3L,2L,1L,3L,1L,6L,5L,9L,7L,3L,2L,7L,8L,5L,1L,0L,1L,5L,0L,1L,4L,2L,4L,1L,3L,0L,3L,9L,2L,8L,8L,1L,9L,9L,6L,8L,3L,0L,3L,6L,1L,5L,8L,0L,6L,6L,8L,2L,8L,1L,4L,7L,3L,0L,0L,8L,8L,9L,0L,3L,4L,3L,9L,2L,9L,8L,9L,0L,6L,3L,4L,4L,2L,4L,2L,4L,1L,4L,9L,9L,2L,1L,7L,6L,7L,1L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258232Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258232.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258232Inst : IEnumerable<long>
{
public static readonly long[] Value=A258232.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258232.Bytes);
public long this[int i]=>Value[i];

public static A258232Inst Instance=new A258232Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258233
{
public static readonly long[] Value={ 0L,1L,1L,3L,6L,7L,11L,15L,16L,25L,30L,32L,42L,40L,44L,52L,63L,71L,76L,87L,82L,97L,102L,113L,127L,137L,136L,143L,154L,154L,186L,200L,204L,215L,234L,249L,251L,262L,272L,284L,309L,324L,345L,334L,349L,359L,406L,414L,431L,447L,441L,489L,487L,511L,508L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258233Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258233.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258233Inst : IEnumerable<long>
{
public static readonly long[] Value=A258233.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258233.Bytes);
public long this[int i]=>Value[i];

public static A258233Inst Instance=new A258233Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258234
{
public static readonly long[] Value={ 5L,4L,0L,0L,8L,7L,1L,9L,0L,4L,1L,1L,8L,1L,5L,4L,1L,5L,2L,4L,6L,6L,0L,9L,1L,1L,1L,9L,1L,0L,4L,2L,7L,0L,0L,5L,2L,0L,2L,9L,4L,3L,7L,7L,1L,0L,1L,9L,1L,6L,7L,0L,5L,7L,0L,9L,3L,1L,7L,0L,6L,0L,1L,4L,4L,8L,4L,4L,8L,5L,1L,5L,9L,5L,0L,7L,5L,8L,1L,7L,7L,8L,9L,8L,8L,7L,4L,7L,9L,2L,0L,0L,0L,0L,6L,2L,0L,6L,2L,7L,7L,6L,7L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258234Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258234.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258234Inst : IEnumerable<long>
{
public static readonly long[] Value=A258234.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258234.Bytes);
public long this[int i]=>Value[i];

public static A258234Inst Instance=new A258234Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258235
{
public static readonly long[] Value={ 0L,2L,1L,7L,3L,5L,20L,10L,15L,8L,54L,4L,6L,23L,28L,41L,21L,143L,9L,11L,13L,16L,18L,57L,62L,75L,109L,55L,376L,31L,36L,44L,49L,22L,24L,26L,29L,42L,146L,151L,164L,198L,287L,144L,986L,12L,14L,17L,19L,65L,70L,78L,83L,96L,112L,117L,130L,56L,58L,60L,63L,76L,110L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258235Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258235.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258235Inst : IEnumerable<long>
{
public static readonly long[] Value=A258235.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258235.Bytes);
public long this[int i]=>Value[i];

public static A258235Inst Instance=new A258235Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258236
{
public static readonly long[] Value={ 0L,2L,1L,3L,5L,3L,5L,2L,4L,6L,4L,6L,8L,6L,8L,4L,6L,8L,6L,8L,3L,5L,7L,5L,7L,9L,7L,9L,5L,7L,9L,7L,9L,11L,9L,11L,7L,9L,11L,9L,11L,5L,7L,9L,7L,9L,11L,9L,11L,7L,9L,11L,9L,11L,4L,6L,8L,6L,8L,10L,8L,10L,6L,8L,10L,8L,10L,12L,10L,12L,8L,10L,12L,10L,12L,6L,8L,10L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258236Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258236.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258236Inst : IEnumerable<long>
{
public static readonly long[] Value=A258236.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258236.Bytes);
public long this[int i]=>Value[i];

public static A258236Inst Instance=new A258236Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258237
{
public static readonly long[] Value={ 0L,1L,2L,4L,3L,7L,5L,11L,8L,16L,6L,12L,24L,9L,18L,17L,35L,14L,13L,25L,26L,50L,10L,19L,21L,38L,36L,72L,15L,28L,27L,31L,52L,51L,55L,103L,20L,22L,37L,39L,41L,45L,73L,74L,79L,147L,32L,29L,56L,53L,59L,65L,106L,104L,113L,209L,23L,42L,40L,46L,76L,75L,80L,84L,93L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258237Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258237.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258237Inst : IEnumerable<long>
{
public static readonly long[] Value=A258237.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258237.Bytes);
public long this[int i]=>Value[i];

public static A258237Inst Instance=new A258237Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258238
{
public static readonly long[] Value={ 0L,1L,2L,4L,3L,5L,7L,4L,6L,8L,10L,5L,7L,9L,9L,11L,6L,8L,8L,10L,12L,10L,12L,14L,7L,9L,9L,11L,11L,13L,15L,11L,13L,15L,17L,8L,10L,12L,10L,12L,14L,12L,14L,16L,18L,12L,14L,16L,16L,18L,9L,11L,11L,13L,15L,11L,13L,15L,17L,13L,15L,17L,17L,19L,21L,13L,15L,17L,19L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258238Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258238.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258238Inst : IEnumerable<long>
{
public static readonly long[] Value=A258238.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258238.Bytes);
public long this[int i]=>Value[i];

public static A258238Inst Instance=new A258238Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258239
{
public static readonly long[] Value={ 0L,3L,1L,13L,6L,4L,47L,2L,17L,23L,14L,163L,5L,7L,10L,51L,61L,81L,48L,559L,27L,37L,15L,18L,20L,24L,167L,177L,211L,279L,164L,1911L,8L,11L,54L,64L,71L,85L,95L,129L,49L,52L,62L,82L,563L,573L,607L,723L,955L,560L,6527L,30L,40L,16L,19L,21L,25L,28L,38L,170L,180L,187L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258239Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258239.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258239Inst : IEnumerable<long>
{
public static readonly long[] Value=A258239.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258239.Bytes);
public long this[int i]=>Value[i];

public static A258239Inst Instance=new A258239Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258240
{
public static readonly long[] Value={ 0L,2L,4L,1L,3L,5L,3L,5L,7L,9L,5L,7L,9L,2L,4L,6L,8L,4L,6L,8L,6L,8L,10L,4L,6L,8L,10L,6L,8L,10L,8L,10L,12L,14L,10L,12L,14L,6L,8L,10L,8L,10L,12L,14L,10L,12L,14L,3L,5L,7L,9L,5L,7L,9L,7L,9L,11L,13L,9L,11L,13L,5L,7L,9L,7L,9L,11L,13L,9L,11L,13L,7L,9L,11L,13L,9L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258240Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258240.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258240Inst : IEnumerable<long>
{
public static readonly long[] Value=A258240.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258240.Bytes);
public long this[int i]=>Value[i];

public static A258240Inst Instance=new A258240Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258241
{
public static readonly long[] Value={ 0L,1L,3L,2L,6L,4L,5L,12L,7L,8L,10L,22L,15L,19L,13L,39L,9L,11L,24L,27L,23L,34L,69L,14L,16L,17L,20L,48L,60L,40L,41L,43L,121L,31L,36L,25L,28L,29L,35L,72L,76L,84L,105L,70L,71L,211L,18L,21L,45L,51L,64L,42L,44L,49L,50L,55L,61L,62L,126L,147L,183L,122L,124L,133L,367L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258241Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258241.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258241Inst : IEnumerable<long>
{
public static readonly long[] Value=A258241.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258241.Bytes);
public long this[int i]=>Value[i];

public static A258241Inst Instance=new A258241Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258242
{
public static readonly long[] Value={ 0L,1L,3L,2L,4L,4L,3L,5L,5L,7L,5L,7L,4L,6L,8L,6L,8L,8L,10L,6L,8L,10L,5L,7L,7L,9L,11L,7L,9L,9L,11L,9L,11L,13L,7L,9L,9L,11L,11L,6L,8L,8L,10L,8L,10L,10L,12L,14L,8L,10L,10L,10L,12L,12L,14L,10L,12L,12L,14L,16L,8L,10L,10L,12L,10L,12L,14L,12L,14L,7L,9L,9L,9L,11L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258242Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258242.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258242Inst : IEnumerable<long>
{
public static readonly long[] Value=A258242.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258242.Bytes);
public long this[int i]=>Value[i];

public static A258242Inst Instance=new A258242Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258243
{
public static readonly long[] Value={ 0L,2L,1L,8L,3L,5L,24L,10L,16L,9L,67L,4L,6L,29L,46L,25L,27L,184L,19L,11L,13L,17L,70L,76L,81L,127L,68L,502L,7L,32L,38L,48L,54L,26L,28L,30L,47L,187L,192L,209L,222L,347L,185L,1367L,12L,14L,18L,20L,21L,84L,89L,106L,133L,149L,69L,71L,73L,77L,78L,82L,128L,130L,505L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258243Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258243.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258243Inst : IEnumerable<long>
{
public static readonly long[] Value=A258243.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258243.Bytes);
public long this[int i]=>Value[i];

public static A258243Inst Instance=new A258243Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258244
{
public static readonly long[] Value={ 0L,2L,1L,3L,5L,3L,5L,7L,2L,4L,4L,6L,8L,6L,8L,10L,4L,6L,8L,6L,8L,8L,10L,12L,3L,5L,7L,5L,7L,5L,7L,9L,7L,9L,11L,9L,11L,13L,7L,9L,9L,11L,13L,11L,13L,15L,5L,7L,7L,9L,11L,9L,11L,13L,7L,9L,11L,9L,11L,9L,11L,13L,11L,13L,15L,13L,15L,4L,6L,8L,6L,8L,10L,8L,10L,12L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258244Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258244.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258244Inst : IEnumerable<long>
{
public static readonly long[] Value=A258244.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258244.Bytes);
public long this[int i]=>Value[i];

public static A258244Inst Instance=new A258244Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258245
{
public static readonly long[] Value={ 0L,3L,1L,12L,6L,4L,40L,2L,15L,21L,13L,128L,5L,7L,9L,43L,50L,69L,41L,405L,25L,31L,14L,16L,18L,22L,131L,138L,160L,219L,129L,1275L,8L,10L,53L,59L,72L,81L,100L,42L,44L,47L,51L,70L,408L,414L,436L,505L,691L,406L,4008L,34L,17L,19L,23L,26L,28L,32L,141L,150L,163L,169L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258245Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258245.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258245Inst : IEnumerable<long>
{
public static readonly long[] Value=A258245.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258245.Bytes);
public long this[int i]=>Value[i];

public static A258245Inst Instance=new A258245Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258246
{
public static readonly long[] Value={ 0L,2L,4L,1L,3L,5L,3L,5L,7L,5L,7L,9L,2L,4L,6L,4L,6L,8L,6L,8L,10L,4L,6L,8L,10L,6L,8L,10L,8L,10L,12L,6L,8L,10L,8L,10L,12L,10L,12L,14L,3L,5L,7L,5L,7L,9L,11L,7L,9L,11L,5L,7L,9L,7L,9L,11L,9L,11L,13L,7L,9L,11L,9L,11L,13L,11L,13L,15L,17L,5L,7L,9L,7L,9L,11L,9L,11L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258246Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258246.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258246Inst : IEnumerable<long>
{
public static readonly long[] Value=A258246.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258246.Bytes);
public long this[int i]=>Value[i];

public static A258246Inst Instance=new A258246Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258247
{
public static readonly long[] Value={ 0L,2L,1L,8L,3L,5L,25L,11L,16L,9L,73L,4L,6L,28L,33L,48L,26L,209L,19L,10L,12L,14L,17L,76L,82L,96L,138L,74L,593L,7L,36L,42L,50L,56L,27L,29L,31L,34L,49L,212L,217L,234L,274L,393L,210L,1680L,13L,15L,18L,20L,22L,84L,90L,98L,104L,121L,144L,161L,75L,77L,79L,83L,97L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258247Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258247.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258247Inst : IEnumerable<long>
{
public static readonly long[] Value=A258247.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258247.Bytes);
public long this[int i]=>Value[i];

public static A258247Inst Instance=new A258247Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258248
{
public static readonly long[] Value={ 0L,2L,1L,3L,5L,3L,5L,7L,2L,4L,6L,4L,6L,8L,6L,8L,4L,6L,8L,6L,8L,10L,8L,10L,12L,3L,5L,7L,5L,7L,9L,7L,9L,5L,7L,9L,7L,9L,11L,9L,11L,13L,7L,9L,11L,9L,11L,13L,5L,7L,7L,9L,11L,9L,11L,13L,7L,9L,11L,9L,11L,13L,11L,13L,15L,9L,11L,11L,13L,15L,13L,15L,17L,4L,6L,8L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258248Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258248.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258248Inst : IEnumerable<long>
{
public static readonly long[] Value=A258248.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258248.Bytes);
public long this[int i]=>Value[i];

public static A258248Inst Instance=new A258248Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258249
{
public static readonly long[] Value={ 2L,7L,3L,11L,43L,5L,13L,17L,47L,19L,23L,61L,29L,41L,59L,31L,53L,67L,71L,79L,37L,83L,73L,101L,89L,103L,127L,97L,107L,113L,131L,139L,109L,151L,149L,137L,163L,157L,173L,197L,167L,179L,181L,191L,193L,223L,227L,199L,233L,211L,229L,239L,241L,263L,251L,269L,257L,271L,277L,281L,283L,311L,293L,307L,317L,331L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258249Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258249.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258249Inst : IEnumerable<long>
{
public static readonly long[] Value=A258249.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258249.Bytes);
public long this[int i]=>Value[i];

public static A258249Inst Instance=new A258249Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258250
{
public static readonly long[] Value={ 70L,836L,4030L,5830L,7192L,7912L,10792L,17272L,45356L,83312L,91388L,113072L,254012L,388076L,786208L,1713592L,4145216L,4559552L,4632896L,9928792L,11547352L,13086016L,15126992L,17999992L,29465852L,29581424L,34869056L,37111168L,38546576L,74899952L,89283592L,95327216L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258250Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258250.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258250Inst : IEnumerable<long>
{
public static readonly long[] Value=A258250.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258250.Bytes);
public long this[int i]=>Value[i];

public static A258250Inst Instance=new A258250Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258251
{
public static readonly long[] Value={ 1L,4L,5L,9L,12L,13L,22L,23L,24L,26L,32L,33L,36L,37L,38L,49L,50L,51L,56L,58L,60L,61L,72L,74L,78L,79L,80L,86L,87L,105L,123L,124L,125L,126L,127L,130L,131L,132L,133L,134L,136L,138L,140L,141L,153L,156L,157L,158L,160L,168L,170L,192L,196L,197L,198L,200L,202L,204L,205L,206L,207L,217L,224L,232L,233L,234L,241L,246L,247L,249L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258251Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258251.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258251Inst : IEnumerable<long>
{
public static readonly long[] Value=A258251.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258251.Bytes);
public long this[int i]=>Value[i];

public static A258251Inst Instance=new A258251Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258252
{
public static readonly long[] Value={ 1L,2L,6L,3L,4L,12L,15L,10L,14L,35L,5L,30L,42L,7L,8L,24L,18L,9L,33L,88L,40L,60L,84L,63L,99L,22L,26L,143L,11L,154L,238L,51L,21L,28L,20L,55L,66L,78L,91L,56L,72L,90L,110L,132L,156L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258252Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258252.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258252Inst : IEnumerable<long>
{
public static readonly long[] Value=A258252.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258252.Bytes);
public long this[int i]=>Value[i];

public static A258252Inst Instance=new A258252Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258253
{
public static readonly long[] Value={ 1L,2L,4L,5L,11L,3L,14L,15L,18L,8L,29L,6L,46L,9L,7L,47L,73L,17L,134L,35L,33L,26L,153L,16L,96L,27L,154L,34L,292L,12L,269L,185L,19L,85L,10L,49L,240L,86L,69L,21L,535L,13L,536L,64L,50L,271L,408L,48L,213L,114L,32L,63L,616L,131L,36L,40L,109L,580L,763L,22L,1010L,270L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258253Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258253.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258253Inst : IEnumerable<long>
{
public static readonly long[] Value=A258253.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258253.Bytes);
public long this[int i]=>Value[i];

public static A258253Inst Instance=new A258253Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258254
{
public static readonly long[] Value={ 1L,2L,3L,1L,4L,3L,5L,2L,7L,5L,5L,6L,7L,1L,8L,6L,9L,3L,11L,8L,5L,12L,7L,9L,11L,2L,13L,11L,11L,14L,17L,3L,7L,4L,5L,11L,6L,13L,7L,8L,9L,10L,11L,12L,13L,1L,16L,12L,9L,15L,7L,20L,13L,19L,6L,17L,11L,16L,5L,14L,9L,13L,4L,11L,7L,17L,10L,13L,3L,23L,20L,17L,17L,12L,19L,7L,16L,9L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258254Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258254.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258254Inst : IEnumerable<long>
{
public static readonly long[] Value=A258254.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258254.Bytes);
public long this[int i]=>Value[i];

public static A258254Inst Instance=new A258254Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258255
{
public static readonly long[] Value={ 1L,4L,14L,46L,153L,535L,1855L,6449L,22460L,81237L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258255Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258255.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258255Inst : IEnumerable<long>
{
public static readonly long[] Value=A258255.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258255.Bytes);
public long this[int i]=>Value[i];

public static A258255Inst Instance=new A258255Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258256
{
public static readonly long[] Value={ 1L,1L,1L,0L,1L,2L,0L,0L,1L,4L,2L,0L,0L,2L,0L,0L,1L,2L,4L,0L,2L,0L,0L,0L,0L,3L,2L,0L,0L,2L,0L,0L,1L,0L,2L,0L,4L,2L,0L,0L,2L,2L,0L,0L,0L,8L,0L,0L,0L,1L,3L,0L,2L,2L,0L,0L,0L,0L,2L,0L,0L,2L,0L,0L,1L,4L,0L,0L,2L,0L,0L,0L,4L,2L,2L,0L,0L,0L,0L,0L,2L,4L,2L,0L,0L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258256Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258256.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258256Inst : IEnumerable<long>
{
public static readonly long[] Value=A258256.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258256.Bytes);
public long this[int i]=>Value[i];

public static A258256Inst Instance=new A258256Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258257
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,1L,2L,1L,1L,1L,2L,1L,1L,2L,1L,1L,1L,1L,2L,2L,2L,1L,2L,1L,1L,1L,1L,3L,2L,2L,1L,2L,1L,2L,2L,1L,1L,1L,2L,5L,1L,2L,1L,2L,1L,1L,3L,1L,1L,2L,3L,1L,1L,1L,1L,2L,1L,1L,3L,2L,1L,2L,4L,2L,3L,1L,1L,2L,3L,6L,1L,1L,3L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258257Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258257.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258257Inst : IEnumerable<long>
{
public static readonly long[] Value=A258257.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258257.Bytes);
public long this[int i]=>Value[i];

public static A258257Inst Instance=new A258257Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258258
{
public static readonly long[] Value={ 1L,16L,40L,75L,52L,82L,166L,178L,147L,217L,334L,247L,481L,634L,457L,516L,921L,646L,1047L,1132L,822L,787L,2110L,1351L,1537L,1542L,1402L,1192L,1666L,1696L,2137L,1759L,1876L,2271L,1792L,2712L,2587L,3216L,3909L,2782L,3007L,2956L,4242L,3397L,3682L,4039L,3607L,3601L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258258Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258258.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258258Inst : IEnumerable<long>
{
public static readonly long[] Value=A258258.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258258.Bytes);
public long this[int i]=>Value[i];

public static A258258Inst Instance=new A258258Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258259
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,1L,0L,1L,1L,3L,2L,5L,4L,8L,8L,13L,13L,21L,21L,31L,33L,46L,49L,67L,72L,95L,104L,134L,146L,186L,203L,253L,279L,343L,378L,461L,507L,611L,675L,806L,889L,1055L,1163L,1369L,1512L,1768L,1950L,2270L,2502L,2896L,3193L,3678L,4051L,4649L,5117L,5847L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258259Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258259.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258259Inst : IEnumerable<long>
{
public static readonly long[] Value=A258259.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258259.Bytes);
public long this[int i]=>Value[i];

public static A258259Inst Instance=new A258259Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258260
{
public static readonly long[] Value={ 0L,1L,2L,-1L,0L,1L,-2L,-1L,0L,4L,2L,-1L,0L,1L,-2L,-1L,0L,1L,8L,-1L,0L,1L,-2L,-1L,0L,1L,2L,-4L,0L,1L,-2L,-1L,0L,1L,2L,-1L,0L,1L,-2L,-1L,0L,1L,2L,-1L,0L,4L,-2L,-1L,0L,1L,2L,-1L,0L,1L,-8L,-1L,0L,1L,2L,-1L,0L,1L,-2L,-4L,0L,1L,2L,-1L,0L,1L,-2L,-1L,0L,1L,2L,-1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258260Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258260.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258260Inst : IEnumerable<long>
{
public static readonly long[] Value=A258260.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258260.Bytes);
public long this[int i]=>Value[i];

public static A258260Inst Instance=new A258260Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258261
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,17L,19L,29L,31L,37L,47L,59L,61L,67L,79L,89L,107L,131L,149L,151L,157L,191L,197L,199L,227L,229L,241L,271L,277L,281L,311L,317L,367L,389L,397L,409L,421L,431L,457L,479L,499L,509L,521L,541L,547L,557L,571L,617L,631L,659L,661L,677L,691L,701L,719L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258261Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258261.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258261Inst : IEnumerable<long>
{
public static readonly long[] Value=A258261.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258261.Bytes);
public long this[int i]=>Value[i];

public static A258261Inst Instance=new A258261Inst();

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