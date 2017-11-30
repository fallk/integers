using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A077175
{
public static readonly BigInteger[] Value={ 2L,6L,60L,5040L,384384L,36628200L,5967561600L,1220096908800L,350804594649600L,97292707463952000L,BigInteger.Parse("42873948150095462400"),BigInteger.Parse("21336925409736330240000"),BigInteger.Parse("11640487097965528951948800"),BigInteger.Parse("7998487694738166709923840000") };
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
public class A077175Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077175.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077175Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A077175.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077175.Bytes);
public BigInteger this[int i]=>Value[i];

public static A077175Inst Instance=new A077175Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077176
{
public static readonly BigInteger[] Value={ 2L,6L,30L,210L,6006L,67830L,690690L,35303730L,3383531970L,29248649430L,1846079805570L,220495674290430L,15231748284963210L,328001307608664690L,BigInteger.Parse("58030069605260142390"),BigInteger.Parse("4938238739984380540710"),BigInteger.Parse("182365421703667931839110") };
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
public class A077176Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077176.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077176Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A077176.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077176.Bytes);
public BigInteger this[int i]=>Value[i];

public static A077176Inst Instance=new A077176Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077177
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,2L,3L,5L,8L,17L,34L,59L,111L,213L,396L,746L,1413L,2690L,5147L,9826L,18885L,36269L,69952L,134949L,260743L,504636L,978311L,1899832L,3692980L,7190329L,13994206L,27279898L,53195986L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077177Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077177.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077177Inst : IEnumerable<long>
{
public static readonly long[] Value=A077177.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077177.Bytes);
public long this[int i]=>Value[i];

public static A077177Inst Instance=new A077177Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077178
{
public static readonly long[] Value={ 1L,3L,2L,3L,4L,3L,1L,2L,1L,1L,6L,7L,2L,5L,3L,1L,2L,1L,8L,1L,2L,4L,1L,9L,3L,1L,1L,18L,1L,1L,29L,4L,1L,5L,2L,167L,1L,62L,4L,2L,1L,3L,3L,27L,1L,9L,1L,46L,1L,3L,2L,2L,1L,1L,3L,2L,10L,73L,1L,11L,1L,2L,1L,1L,18L,1L,4L,1L,4L,6L,1L,4L,4L,1L,6L,1L,1L,1L,2L,1L,7L,8L,4L,1L,3L,1L,4L,28L,2L,1L,6L,2L,10L,3L,1L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077178Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077178.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077178Inst : IEnumerable<long>
{
public static readonly long[] Value=A077178.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077178.Bytes);
public long this[int i]=>Value[i];

public static A077178Inst Instance=new A077178Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077179
{
public static readonly long[] Value={ 2L,4L,6L,3L,5L,7L,8L,9L,10L,12L,11L,13L,17L,19L,23L,14L,15L,16L,18L,20L,21L,29L,31L,37L,41L,43L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077179Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077179.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077179Inst : IEnumerable<long>
{
public static readonly long[] Value=A077179.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077179.Bytes);
public long this[int i]=>Value[i];

public static A077179Inst Instance=new A077179Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077180
{
public static readonly long[] Value={ 12L,12L,12345L,1234567891011L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077180Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077180.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077180Inst : IEnumerable<long>
{
public static readonly long[] Value=A077180.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077180.Bytes);
public long this[int i]=>Value[i];

public static A077180Inst Instance=new A077180Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077181
{
public static readonly long[] Value={ 6L,4L,2469L,176366841573L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077181Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077181.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077181Inst : IEnumerable<long>
{
public static readonly long[] Value=A077181.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077181.Bytes);
public long this[int i]=>Value[i];

public static A077181Inst Instance=new A077181Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077182
{
public static readonly long[] Value={ 2L,2L,5L,11L,106L,11L,21L,27L,33L,31L,46L,21L,3L,19L,8L,83L,104L,352L,11L,37L,79L,19L,71L,102L,18L,80L,21L,11L,49L,13L,7L,21L,79L,35L,381L,35L,60L,452L,237L,234L,48L,138L,184L,105L,64L,98L,36L,606L,511L,315L,230L,206L,318L,227L,979L,388L,33L,343L,174L,19L,268L,111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077182Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077182.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077182Inst : IEnumerable<long>
{
public static readonly long[] Value=A077182.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077182.Bytes);
public long this[int i]=>Value[i];

public static A077182Inst Instance=new A077182Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077183
{
public static readonly long[] Value={ 0L,2L,0L,2L,14L,15L,9L,5L,16L,4L,25L,21L,40L,67L,78L,66L,25L,111L,161L,49L,30L,15L,27L,20L,63L,98L,102L,3L,99L,92L,296L,71L,22L,367L,4L,48L,50L,91L,45L,241L,137L,258L,23L,28L,212L,40L,96L,408L,456L,110L,16L,731L,403L,667L,90L,130L,111L,458L,146L,18L,577L,276L,708L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077183Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077183.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077183Inst : IEnumerable<long>
{
public static readonly long[] Value=A077183.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077183.Bytes);
public long this[int i]=>Value[i];

public static A077183Inst Instance=new A077183Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077184
{
public static readonly long[] Value={ 0L,2L,0L,2L,14L,15L,9L,5L,16L,4L,25L,21L,40L,67L,78L,66L,25L,111L,161L,49L,30L,15L,27L,20L,63L,98L,102L,3L,99L,92L,296L,71L,22L,367L,4L,48L,50L,91L,45L,241L,137L,258L,23L,28L,212L,40L,96L,408L,456L,110L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077184Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077184.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077184Inst : IEnumerable<long>
{
public static readonly long[] Value=A077184.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077184.Bytes);
public long this[int i]=>Value[i];

public static A077184Inst Instance=new A077184Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077185
{
public static readonly BigInteger[] Value={ 0L,7L,0L,3L,128465555544332211L,11647163162383665717UL,58097313L,2859L,BigInteger.Parse("702235353091782071927"),149L,BigInteger.Parse("814268458452231668262948810358418956591"),BigInteger.Parse("5730248154490578733002999666333") };
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
public class A077185Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077185.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077185Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A077185.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077185.Bytes);
public BigInteger this[int i]=>Value[i];

public static A077185Inst Instance=new A077185Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077186
{
public static readonly long[] Value={ 0L,12321L,0L,12345654321L,121L,12345654321L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077186Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077186.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077186Inst : IEnumerable<long>
{
public static readonly long[] Value=A077186.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077186.Bytes);
public long this[int i]=>Value[i];

public static A077186Inst Instance=new A077186Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077187
{
public static readonly long[] Value={ 0L,3L,0L,6L,2L,6L,109L,103L,100001L,1006L,17L,3L,5L,103L,1000002L,100012L,1019L,1002L,1001L,16L,8L,105L,1036L,104L,1002L,4L,100000000009L,100004L,52L,156L,10000000012L,1062L,8L,1002L,28L,102L,1011L,1000062L,30L,10001L,118L,52L,43L,10058L,34L,47L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077187Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077187.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077187Inst : IEnumerable<long>
{
public static readonly long[] Value=A077187.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077187.Bytes);
public long this[int i]=>Value[i];

public static A077187Inst Instance=new A077187Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077188
{
public static readonly long[] Value={ 0L,4107L,0L,1763664903L,11L,949665717L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077188Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077188.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077188Inst : IEnumerable<long>
{
public static readonly long[] Value=A077188.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077188.Bytes);
public long this[int i]=>Value[i];

public static A077188Inst Instance=new A077188Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077189
{
public static readonly long[] Value={ 1L,12321L,0L,12345654321L,12321L,121L,12345654321L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077189Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077189.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077189Inst : IEnumerable<long>
{
public static readonly long[] Value=A077189.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077189.Bytes);
public long this[int i]=>Value[i];

public static A077189Inst Instance=new A077189Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077190
{
public static readonly long[] Value={ 1L,4107L,0L,1763664903L,1369L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077190Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077190.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077190Inst : IEnumerable<long>
{
public static readonly long[] Value=A077190.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077190.Bytes);
public long this[int i]=>Value[i];

public static A077190Inst Instance=new A077190Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077191
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,1L,4L,2L,2L,1L,5L,1L,2L,1L,11L,1L,5L,1L,5L,2L,2L,1L,13L,2L,2L,4L,4L,1L,4L,1L,35L,1L,2L,1L,14L,1L,2L,2L,12L,1L,6L,1L,4L,2L,2L,1L,42L,2L,5L,1L,5L,1L,13L,2L,11L,2L,2L,1L,13L,1L,2L,4L,146L,1L,4L,1L,5L,1L,4L,1L,45L,1L,2L,3L,4L,1L,6L,1L,42L,12L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077191Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077191.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077191Inst : IEnumerable<long>
{
public static readonly long[] Value=A077191.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077191.Bytes);
public long this[int i]=>Value[i];

public static A077191Inst Instance=new A077191Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077192
{
public static readonly long[] Value={ 8L,90L,92L,98L,992L,998L,9992L,9998L,99992L,99998L,999992L,999994L,999998L,9999992L,9999998L,99999992L,99999998L,999999992L,999999998L,9999999992L,9999999998L,99999999992L,99999999998L,999999999992L,999999999994L,999999999998L,9999999999992L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077192Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077192.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077192Inst : IEnumerable<long>
{
public static readonly long[] Value=A077192.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077192.Bytes);
public long this[int i]=>Value[i];

public static A077192Inst Instance=new A077192Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077193
{
public static readonly long[] Value={ 1L,1L,6L,6L,24L,360L,720L,5040L,362880L,1814400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077193Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077193.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077193Inst : IEnumerable<long>
{
public static readonly long[] Value=A077193.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077193.Bytes);
public long this[int i]=>Value[i];

public static A077193Inst Instance=new A077193Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077194
{
public static readonly long[] Value={ 1L,10L,3L,100L,10L,12L,1001L,1000L,9L,10L,11L,12L,1001L,10010L,30L,10000L,100000001L,18L,1000000001L,100L,21L,110L,100000000001L,120L,100L,10010L,27L,100100L,100000000000001L,30L,10000011L,100000L,33L,1000000010L,10010L,36L,111L,10000000010L,10101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077194Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077194.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077194Inst : IEnumerable<long>
{
public static readonly long[] Value=A077194.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077194.Bytes);
public long this[int i]=>Value[i];

public static A077194Inst Instance=new A077194Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077195
{
public static readonly BigInteger[] Value={ 1L,5L,1L,25L,2L,2L,143L,125L,1L,1L,1L,1L,77L,715L,2L,625L,5882353L,1L,52631579L,5L,1L,5L,4347826087L,5L,4L,385L,1L,3575L,3448275862069L,1L,322581L,3125L,1L,29411765L,286L,1L,3L,263157895L,259L,25L,1L,5L,2327907L,25L,1L,21739130435L,BigInteger.Parse("2127659574468085106383"),25L };
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
public class A077195Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077195.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077195Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A077195.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077195.Bytes);
public BigInteger this[int i]=>Value[i];

public static A077195Inst Instance=new A077195Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077196
{
public static readonly long[] Value={ 1L,1L,3L,1L,1L,3L,2L,1L,9L,1L,2L,3L,2L,2L,3L,1L,2L,9L,2L,1L,3L,2L,2L,3L,1L,2L,9L,2L,2L,3L,3L,1L,6L,2L,2L,9L,3L,2L,3L,1L,5L,3L,3L,2L,9L,2L,2L,3L,2L,1L,3L,2L,3L,9L,2L,2L,3L,2L,2L,3L,2L,3L,9L,1L,2L,6L,3L,2L,3L,2L,3L,9L,2L,3L,3L,2L,2L,3L,4L,1L,9L,5L,3L,3L,2L,3L,3L,2L,2L,9L,2L,2L,3L,2L,2L,3L,2L,2L,18L,1L,2L,3L,2L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077196Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077196.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077196Inst : IEnumerable<long>
{
public static readonly long[] Value=A077196.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077196.Bytes);
public long this[int i]=>Value[i];

public static A077196Inst Instance=new A077196Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077197
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,2L,2L,2L,2L,4L,2L,2L,2L,2L,2L,4L,2L,6L,2L,2L,4L,10L,2L,4L,2L,6L,2L,6L,2L,4L,4L,4L,4L,2L,2L,6L,6L,2L,4L,4L,2L,6L,4L,2L,10L,22L,4L,6L,4L,8L,2L,12L,6L,4L,2L,6L,6L,28L,4L,4L,4L,6L,8L,4L,4L,10L,8L,10L,2L,12L,2L,6L,6L,4L,6L,4L,2L,12L,8L,18L,4L,40L,2L,16L,6L,6L,4L,10L,2L,6L,10L,4L,22L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077197Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077197.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077197Inst : IEnumerable<long>
{
public static readonly long[] Value=A077197.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077197.Bytes);
public long this[int i]=>Value[i];

public static A077197Inst Instance=new A077197Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077198
{
public static readonly long[] Value={ 1L,2L,2L,6L,2L,2L,2L,4L,12L,6L,2L,6L,6L,2L,2L,30L,6L,12L,4L,6L,8L,6L,2L,4L,30L,6L,4L,6L,4L,6L,8L,6L,4L,18L,4L,12L,18L,4L,6L,12L,6L,8L,10L,6L,12L,6L,4L,30L,18L,30L,6L,42L,18L,4L,6L,4L,4L,12L,4L,6L,30L,8L,12L,126L,6L,12L,16L,6L,8L,12L,6L,12L,36L,18L,30L,12L,8L,6L,4L,30L,110L,6L,6L,24L,18L,10L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077198Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077198.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077198Inst : IEnumerable<long>
{
public static readonly long[] Value=A077198.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077198.Bytes);
public long this[int i]=>Value[i];

public static A077198Inst Instance=new A077198Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077199
{
public static readonly long[] Value={ 2L,3L,2L,2L,2L,5L,3L,2L,2L,3L,2L,2L,2L,3L,2L,3L,2L,3L,2L,2L,2L,7L,3L,2L,5L,3L,2L,2L,2L,3L,2L,2L,2L,3L,2L,2L,2L,3L,2L,2L,2L,5L,3L,2L,2L,5L,6L,3L,2L,3L,2L,3L,2L,3L,2L,2L,2L,3L,2L,2L,5L,3L,2L,2L,2L,3L,2L,2L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077199Inst : IEnumerable<long>
{
public static readonly long[] Value=A077199.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077199.Bytes);
public long this[int i]=>Value[i];

public static A077199Inst Instance=new A077199Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077200
{
public static readonly long[] Value={ 0L,1L,2L,5L,2L,4L,4L,23L,16L,4L,2L,6L,4L,1L,6L,65L,2L,2L,4L,8L,1L,4L,6L,16L,24L,7L,98L,16L,2L,12L,6L,211L,1L,1L,3L,64L,4L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077200Inst : IEnumerable<long>
{
public static readonly long[] Value=A077200.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077200.Bytes);
public long this[int i]=>Value[i];

public static A077200Inst Instance=new A077200Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077201
{
public static readonly long[] Value={ 1L,3L,5L,49L,11L,22L,17L,16983563041L,529L,38L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077201Inst : IEnumerable<long>
{
public static readonly long[] Value=A077201.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077201.Bytes);
public long this[int i]=>Value[i];

public static A077201Inst Instance=new A077201Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077202
{
public static readonly long[] Value={ 1L,1L,3L,1L,7L,1L,9L,7L,3L,7L,9L,11L,3L,11L,17L,3L,13L,1L,27L,1L,37L,3L,17L,9L,19L,1L,39L,7L,19L,3L,31L,19L,7L,27L,7L,33L,7L,39L,11L,23L,3L,47L,9L,29L,3L,49L,1L,49L,9L,37L,9L,41L,9L,47L,21L,1L,51L,13L,19L,9L,53L,23L,9L,67L,3L,53L,33L,13L,21L,11L,29L,17L,21L,13L,27L,11L,51L,19L,13L,61L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077202Inst : IEnumerable<long>
{
public static readonly long[] Value=A077202.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077202.Bytes);
public long this[int i]=>Value[i];

public static A077202Inst Instance=new A077202Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077203
{
public static readonly long[] Value={ 2L,23L,307L,7001L,10007L,700001L,1000003L,30000001L,100000007L,7000000001L,10000000019L,900000000013L,3000000000013L,30000000000011L,100000000000031L,1000000000000037L,70000000000000003L,300000000000000011L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077203Inst : IEnumerable<long>
{
public static readonly long[] Value=A077203.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077203.Bytes);
public long this[int i]=>Value[i];

public static A077203Inst Instance=new A077203Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077204
{
public static readonly long[] Value={ 1L,16L,625L,5041L,10201L,100489L,9006001L,10004569L,900060001L,1000014129L,90000600001L,100000147984L,4000004000001L,10000002149284L,400000040000001L,1000000025191729L,90000000600000001L,100000000621806289L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077204Inst : IEnumerable<long>
{
public static readonly long[] Value=A077204.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077204.Bytes);
public long this[int i]=>Value[i];

public static A077204Inst Instance=new A077204Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077205
{
public static readonly long[] Value={ 1L,4L,25L,71L,101L,317L,3001L,3163L,30001L,31623L,300001L,316228L,2000001L,3162278L,20000001L,31622777L,300000001L,316227767L,3000000001L,3162277661L,10000000001L,31622776602L,200000000001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077205Inst : IEnumerable<long>
{
public static readonly long[] Value=A077205.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077205.Bytes);
public long this[int i]=>Value[i];

public static A077205Inst Instance=new A077205Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077206
{
public static readonly long[] Value={ 1L,15L,528L,8001L,10011L,100128L,8006001L,10001628L,800060001L,1000006281L,10000020331L,100000404505L,5000002655781L,10000002437316L,600000012076636L,6000000109431328L,80000000600000001L,100000000447232406L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077206Inst : IEnumerable<long>
{
public static readonly long[] Value=A077206.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077206.Bytes);
public long this[int i]=>Value[i];

public static A077206Inst Instance=new A077206Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077207
{
public static readonly long[] Value={ 1L,5L,32L,126L,141L,447L,4001L,4472L,40001L,44721L,141421L,447214L,3162278L,4472136L,34641016L,109544512L,400000001L,447213596L,3464101616L,10954451150L,31622776602L,77459666925L,316227766017L,774596669241L,1414213562373L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077207Inst : IEnumerable<long>
{
public static readonly long[] Value=A077207.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077207.Bytes);
public long this[int i]=>Value[i];

public static A077207Inst Instance=new A077207Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077208
{
public static readonly long[] Value={ 2L,21L,11L,13L,3L,31L,14L,41L,15L,5L,51L,17L,7L,71L,19L,91L,101L,102L,22L,23L,33L,34L,42L,26L,6L,61L,103L,35L,53L,37L,73L,38L,82L,29L,93L,39L,94L,43L,301L,105L,55L,57L,74L,46L,62L,201L,106L,65L,58L,83L,302L,202L,203L,303L,305L,59L,95L,501L,107L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077208Inst : IEnumerable<long>
{
public static readonly long[] Value=A077208.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077208.Bytes);
public long this[int i]=>Value[i];

public static A077208Inst Instance=new A077208Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077209
{
public static readonly long[] Value={ 2L,21L,101L,102L,201L,1001L,1002L,2001L,10001L,10002L,20001L,100001L,100002L,200001L,1000001L,1000002L,2000001L,10000001L,10000002L,20000001L,100000001L,100000002L,200000001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077209Inst : IEnumerable<long>
{
public static readonly long[] Value=A077209.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077209.Bytes);
public long this[int i]=>Value[i];

public static A077209Inst Instance=new A077209Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077210
{
public static readonly long[] Value={ 2L,3L,7L,22L,89L,446L,2677L,18741L,149929L,1349363L,13493631L,148429942L,1781159305L,23155070969L,324170993567L,4862564903506L,77801038456097L,1322617653753653L,23807117767565755L,452335237583749354L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077210Inst : IEnumerable<long>
{
public static readonly long[] Value=A077210.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077210.Bytes);
public long this[int i]=>Value[i];

public static A077210Inst Instance=new A077210Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077211
{
public static readonly long[] Value={ 1L,4L,9L,36L,169L,900L,5476L,38416L,308025L,2775556L,27762361L,305410576L,3664970521L,47644848729L,667028291524L,10005429354496L,160086894977025L,2721477270128400L,48986590869089316L,930745227141407161L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077211Inst : IEnumerable<long>
{
public static readonly long[] Value=A077211.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077211.Bytes);
public long this[int i]=>Value[i];

public static A077211Inst Instance=new A077211Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077212
{
public static readonly long[] Value={ 1L,2L,3L,6L,13L,30L,74L,196L,555L,1666L,5269L,17476L,60539L,218277L,816718L,3163136L,12652545L,52167780L,221329146L,964751381L,4314499339L,19771519807L,92736648099L,444749340320L,2178817894447L,10894089472236L,55549174801758L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077212Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077212.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077212Inst : IEnumerable<long>
{
public static readonly long[] Value=A077212.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077212.Bytes);
public long this[int i]=>Value[i];

public static A077212Inst Instance=new A077212Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077213
{
public static readonly long[] Value={ 2L,3L,7L,23L,97L,487L,2927L,20507L,164057L,1476523L,14765237L,162417611L,1949011333L,25337147347L,354720062861L,5320800943001L,85132815088031L,1447257856496689L,26050641416940457L,494962186921868723L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077213Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077213.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077213Inst : IEnumerable<long>
{
public static readonly long[] Value=A077213.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077213.Bytes);
public long this[int i]=>Value[i];

public static A077213Inst Instance=new A077213Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077214
{
public static readonly long[] Value={ 1L,2L,9L,10L,11L,12L,13L,14L,17L,18L,19L,20L,21L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,37L,38L,41L,42L,43L,44L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L,72L,73L,74L,75L,77L,78L,79L,80L,81L,82L,83L,84L,85L,88L,89L,90L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077214Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077214.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077214Inst : IEnumerable<long>
{
public static readonly long[] Value=A077214.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077214.Bytes);
public long this[int i]=>Value[i];

public static A077214Inst Instance=new A077214Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077215
{
public static readonly long[] Value={ 1L,1L,4L,3L,16L,4L,32L,9L,8L,64L,5L,256L,16L,7L,8L,128L,32L,4L,256L,8L,8L,16L,32L,64L,512L,8L,17L,16L,27L,32L,2048L,256L,64L,23L,1024L,25L,64L,128L,8L,64L,64L,9L,256L,64L,8L,9L,4096L,1024L,64L,4L,16L,16L,16L,256L,2048L,16L,64L,27L,128L,16L,47L,2048L,8192L,8L,8L,8L,32768L,128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077215Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077215.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077215Inst : IEnumerable<long>
{
public static readonly long[] Value=A077215.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077215.Bytes);
public long this[int i]=>Value[i];

public static A077215Inst Instance=new A077215Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077216
{
public static readonly long[] Value={ 2L,5L,3L,19L,7L,13L,23L,47L,31L,89L,139L,113L,199L,293L,631L,317L,1069L,509L,2503L,1129L,1759L,2039L,887L,1951L,4027L,3967L,2477L,2971L,3271L,6917L,4831L,5591L,10799L,5119L,14107L,9973L,1327L,39461L,16381L,20809L,11743L,15683L,61169L,52391L,33247L,45439L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077216Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077216.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077216Inst : IEnumerable<long>
{
public static readonly long[] Value=A077216.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077216.Bytes);
public long this[int i]=>Value[i];

public static A077216Inst Instance=new A077216Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077217
{
public static readonly long[] Value={ 2L,5L,17L,29L,35L,41L,101L,137L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077217Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077217.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077217Inst : IEnumerable<long>
{
public static readonly long[] Value=A077217.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077217.Bytes);
public long this[int i]=>Value[i];

public static A077217Inst Instance=new A077217Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077218
{
public static readonly long[] Value={ 0L,2L,2L,7L,3L,8L,3L,7L,14L,3L,15L,8L,3L,8L,15L,14L,4L,16L,8L,5L,13L,11L,14L,21L,10L,3L,9L,5L,10L,36L,12L,16L,3L,26L,4L,16L,17L,8L,16L,15L,5L,26L,7L,9L,4L,33L,30L,12L,4L,10L,14L,6L,29L,20L,14L,15L,5L,17L,10L,3L,28L,40L,9L,5L,9L,42L,16L,27L,4L,14L,13L,22L,17L,18L,8L,19L,22L,11L,23L,27L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077218Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077218.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077218Inst : IEnumerable<long>
{
public static readonly long[] Value=A077218.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077218.Bytes);
public long this[int i]=>Value[i];

public static A077218Inst Instance=new A077218Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077219
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,2L,3L,3L,3L,4L,4L,5L,5L,5L,6L,6L,6L,7L,7L,7L,8L,9L,8L,9L,9L,10L,10L,11L,11L,12L,12L,12L,12L,12L,13L,14L,14L,14L,14L,15L,15L,16L,16L,16L,16L,17L,17L,18L,18L,18L,19L,20L,19L,20L,20L,20L,21L,22L,22L,23L,22L,23L,23L,23L,24L,25L,25L,25L,25L,26L,26L,27L,27L,27L,27L,28L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077219Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077219.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077219Inst : IEnumerable<long>
{
public static readonly long[] Value=A077219.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077219.Bytes);
public long this[int i]=>Value[i];

public static A077219Inst Instance=new A077219Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077220
{
public static readonly long[] Value={ 1L,2L,4L,6L,9L,12L,3L,7L,8L,13L,15L,21L,24L,31L,5L,10L,11L,17L,19L,26L,29L,16L,20L,25L,30L,36L,42L,49L,56L,22L,14L,41L,37L,18L,27L,28L,38L,40L,51L,54L,66L,39L,52L,53L,67L,69L,84L,87L,33L,45L,46L,32L,23L,43L,35L,70L,50L,55L,65L,71L,34L,44L,47L,58L,62L,74L,79L,57L,48L,72L,64L,89L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077220Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077220.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077220Inst : IEnumerable<long>
{
public static readonly long[] Value=A077220.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077220.Bytes);
public long this[int i]=>Value[i];

public static A077220Inst Instance=new A077220Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077221
{
public static readonly long[] Value={ 0L,1L,8L,17L,32L,49L,72L,97L,128L,161L,200L,241L,288L,337L,392L,449L,512L,577L,648L,721L,800L,881L,968L,1057L,1152L,1249L,1352L,1457L,1568L,1681L,1800L,1921L,2048L,2177L,2312L,2449L,2592L,2737L,2888L,3041L,3200L,3361L,3528L,3697L,3872L,4049L,4232L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077221Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077221.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077221Inst : IEnumerable<long>
{
public static readonly long[] Value=A077221.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077221.Bytes);
public long this[int i]=>Value[i];

public static A077221Inst Instance=new A077221Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077222
{
public static readonly long[] Value={ 1L,8L,17L,32L,49L,72L,9L,16L,33L,48L,73L,96L,25L,24L,57L,64L,105L,120L,169L,56L,65L,104L,121L,168L,193L,248L,41L,40L,81L,88L,137L,152L,209L,80L,89L,136L,153L,208L,233L,128L,97L,192L,249L,112L,113L,176L,185L,256L,273L,352L,177L,184L,257L,272L,353L,376L,465L,160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077222Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077222.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077222Inst : IEnumerable<long>
{
public static readonly long[] Value=A077222.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077222.Bytes);
public long this[int i]=>Value[i];

public static A077222Inst Instance=new A077222Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077223
{
public static readonly long[] Value={ 1L,2L,3L,4L,7L,6L,5L,8L,9L,10L,11L,12L,17L,14L,15L,16L,13L,18L,19L,20L,21L,22L,25L,26L,27L,24L,23L,28L,29L,30L,31L,34L,33L,32L,35L,36L,37L,40L,39L,38L,41L,42L,43L,44L,45L,46L,47L,48L,49L,52L,51L,50L,53L,54L,55L,56L,57L,58L,61L,62L,65L,64L,59L,60L,63L,66L,67L,70L,69L,68L,71L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077223Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077223.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077223Inst : IEnumerable<long>
{
public static readonly long[] Value=A077223.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077223.Bytes);
public long this[int i]=>Value[i];

public static A077223Inst Instance=new A077223Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077224
{
public static readonly long[] Value={ 1L,2L,4L,9L,13L,29L,33L,101L,105L,109L,157L,177L,253L,289L,301L,353L,409L,429L,465L,501L,533L,553L,589L,609L,681L,753L,877L,933L,965L,1153L,1477L,1905L,1977L,2101L,2125L,2229L,2305L,2405L,2605L,2657L,2801L,2913L,3305L,3381L,3489L,3565L,3777L,3781L,3881L,4029L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077224Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077224.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077224Inst : IEnumerable<long>
{
public static readonly long[] Value=A077224.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077224.Bytes);
public long this[int i]=>Value[i];

public static A077224Inst Instance=new A077224Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077225
{
public static readonly long[] Value={ 1L,3L,15L,17L,233L,291L,577L,723L,1455L,3615L,8117L,8835L,9505L,30833L,128773L,130827L,239595L,273435L,426891L,654135L,676297L,926117L,145553L,1662533L,2389517L,2762427L,2820927L,7994449L,8098527L,14319073L,16766835L,20506733L,27606617L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077225Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077225.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077225Inst : IEnumerable<long>
{
public static readonly long[] Value=A077225.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077225.Bytes);
public long this[int i]=>Value[i];

public static A077225Inst Instance=new A077225Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077226
{
public static readonly long[] Value={ 0L,3L,7L,4L,1L,8L,2L,5L,17L,13L,9L,6L,19L,21L,29L,27L,32L,10L,28L,25L,33L,12L,56L,11L,16L,36L,15L,41L,14L,23L,59L,51L,22L,61L,18L,20L,73L,69L,84L,58L,57L,62L,65L,81L,24L,26L,64L,89L,35L,100L,75L,78L,76L,109L,37L,116L,31L,30L,34L,111L,126L,92L,44L,98L,86L,124L,45L,121L,94L,99L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077226Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077226.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077226Inst : IEnumerable<long>
{
public static readonly long[] Value=A077226.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077226.Bytes);
public long this[int i]=>Value[i];

public static A077226Inst Instance=new A077226Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077227
{
public static readonly long[] Value={ 1L,0L,1L,0L,2L,1L,0L,1L,3L,1L,0L,0L,6L,4L,1L,0L,0L,7L,10L,5L,1L,0L,0L,6L,20L,15L,6L,1L,0L,0L,3L,31L,35L,21L,7L,1L,0L,0L,1L,40L,70L,56L,28L,8L,1L,0L,0L,0L,44L,121L,126L,84L,36L,9L,1L,0L,0L,0L,40L,185L,252L,210L,120L,45L,10L,1L,0L,0L,0L,31L,255L,456L,462L,330L,165L,55L,11L,1L,0L,0L,0L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077227Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077227.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077227Inst : IEnumerable<long>
{
public static readonly long[] Value=A077227.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077227.Bytes);
public long this[int i]=>Value[i];

public static A077227Inst Instance=new A077227Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077228
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,4L,4L,1L,1L,4L,10L,5L,1L,1L,4L,17L,15L,6L,1L,1L,4L,23L,35L,21L,7L,1L,1L,4L,26L,66L,56L,28L,8L,1L,1L,4L,27L,106L,126L,84L,36L,9L,1L,1L,4L,27L,150L,247L,210L,120L,45L,10L,1L,1L,4L,27L,190L,432L,462L,330L,165L,55L,11L,1L,1L,4L,27L,221L,687L,918L,792L,495L,220L,66L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077228Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077228.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077228Inst : IEnumerable<long>
{
public static readonly long[] Value=A077228.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077228.Bytes);
public long this[int i]=>Value[i];

public static A077228Inst Instance=new A077228Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077229
{
public static readonly long[] Value={ 1L,1L,1L,3L,5L,11L,23L,48L,98L,204L,421L,863L,1766L,3606L,7341L,14913L,30233L,61175L,123589L,249344L,502443L,1011366L,2033894L,4086975L,8206833L,16469875L,33035611L,66234372L,132745859L,265961487L,532717894L,1066778687L,2135822457L,4275459730L,8557335141L,17125445575L,34268965676L,68568213419L,137187103849L,274458924246L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077229Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077229.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077229Inst : IEnumerable<long>
{
public static readonly long[] Value=A077229.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077229.Bytes);
public long this[int i]=>Value[i];

public static A077229Inst Instance=new A077229Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077230
{
public static readonly BigInteger[] Value={ 2L,1L,-7L,5L,-787L,763L,-893209L,2885597L,-1153151299L,261937547L,-3997632829L,30141297349L,-4101190700056349L,2948796705108299L,-320676905674696783L,43360062621189833L,BigInteger.Parse("-5848606947453449297743"),BigInteger.Parse("1963629536423819469923"),BigInteger.Parse("-575654781675816234791672323") };
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
public class A077230Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077230.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077230Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A077230.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077230.Bytes);
public BigInteger this[int i]=>Value[i];

public static A077230Inst Instance=new A077230Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077231
{
public static readonly BigInteger[] Value={ 1L,6L,240L,448L,138240L,225280L,402554880L,1857945600L,1010722406400L,301234913280L,5859811786752L,55010477998080L,9141306387333120000L,7898088718655815680L,BigInteger.Parse("1017975879293416243200"),BigInteger.Parse("161212016644168089600") };
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
public class A077231Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077231.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077231Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A077231.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077231.Bytes);
public BigInteger this[int i]=>Value[i];

public static A077231Inst Instance=new A077231Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077232
{
public static readonly long[] Value={ 1L,2L,2L,5L,8L,3L,3L,10L,7L,18L,15L,4L,4L,17L,170L,9L,55L,197L,24L,5L,5L,26L,127L,70L,11L,1520L,17L,23L,35L,6L,6L,37L,25L,19L,32L,13L,3482L,199L,161L,24335L,48L,7L,7L,50L,649L,182L,485L,89L,15L,151L,99L,530L,31L,29718L,63L,8L,8L,65L,48842L,33L,7775L,251L,3480L,17L,1068L,43L,26L,57799L,351L,53L,80L,9L,9L,82L,55L,378L,10405L,28L,197L,500L,19L,1574L,1151L,12151L,2143295L,39L,49L,5604L,99L,10L,10L,101L,227528L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077232Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077232.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077232Inst : IEnumerable<long>
{
public static readonly long[] Value=A077232.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077232.Bytes);
public long this[int i]=>Value[i];

public static A077232Inst Instance=new A077232Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077233
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,1L,1L,3L,2L,5L,4L,1L,1L,4L,39L,2L,12L,42L,5L,1L,1L,5L,24L,13L,2L,273L,3L,4L,6L,1L,1L,6L,4L,3L,5L,2L,531L,30L,24L,3588L,7L,1L,1L,7L,90L,25L,66L,12L,2L,20L,13L,69L,4L,3805L,8L,1L,1L,8L,5967L,4L,936L,30L,413L,2L,125L,5L,3L,6630L,40L,6L,9L,1L,1L,9L,6L,41L,1122L,3L,21L,53L,2L,165L,120L,1260L,221064L,4L,5L,569L,10L,1L,1L,10L,22419L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077233Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077233.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077233Inst : IEnumerable<long>
{
public static readonly long[] Value=A077233.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077233.Bytes);
public long this[int i]=>Value[i];

public static A077233Inst Instance=new A077233Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077234
{
public static readonly long[] Value={ 2L,9L,34L,127L,474L,1769L,6602L,24639L,91954L,343177L,1280754L,4779839L,17838602L,66574569L,248459674L,927264127L,3460596834L,12915123209L,48199896002L,179884460799L,671337947194L,2505467327977L,9350531364714L,34896658130879L,130236101158802L,486047746504329L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077234Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077234.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077234Inst : IEnumerable<long>
{
public static readonly long[] Value=A077234.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077234.Bytes);
public long this[int i]=>Value[i];

public static A077234Inst Instance=new A077234Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077235
{
public static readonly long[] Value={ 5L,16L,59L,220L,821L,3064L,11435L,42676L,159269L,594400L,2218331L,8278924L,30897365L,115310536L,430344779L,1606068580L,5993929541L,22369649584L,83484668795L,311569025596L,1162791433589L,4339596708760L,16195595401451L,60442784897044L,225575544186725L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077235Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077235.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077235Inst : IEnumerable<long>
{
public static readonly long[] Value=A077235.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077235.Bytes);
public long this[int i]=>Value[i];

public static A077235Inst Instance=new A077235Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077300
{
public static readonly BigInteger[] Value={ 1234567891011L,12131L,4151L,6171819202122L,2324L,252L,6272L,829303132L,33343536373L,83940414243L,4445L,46474849505L,15253L,5455565758596061626L,364L,6566L,6768697071727374L,BigInteger.Parse("7576777879808182838485"),868L,78889909L,192939495L };
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
public class A077300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077300Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A077300.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077300.Bytes);
public BigInteger this[int i]=>Value[i];

public static A077300Inst Instance=new A077300Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077301
{
public static readonly long[] Value={ 123456L,789101112L,1314151617181920L,2122232L,42526272L,82930313233343536L,3738394041424L,344L,45464L,74849505152L,5354555657585960L,616L,26364656L,66768L,6970717273747576L,777879808L,1828384L,858687888L,9909192L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077301Inst : IEnumerable<long>
{
public static readonly long[] Value=A077301.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077301.Bytes);
public long this[int i]=>Value[i];

public static A077301Inst Instance=new A077301Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077302
{
public static readonly long[] Value={ 12345678L,91011121314151617L,18L,1920212223242526L,27L,2829303L,1323L,33435L,36L,3738394041424344L,45L,4647484950515253L,54L,5556575859606L,162L,63L,64656L,66768697071L,72L,7374757677787980L,81L,828L,384858L,687888L,990L,9192939495969798L,99L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077302Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077302.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077302Inst : IEnumerable<long>
{
public static readonly long[] Value=A077302.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077302.Bytes);
public long this[int i]=>Value[i];

public static A077302Inst Instance=new A077302Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077303
{
public static readonly BigInteger[] Value={ 2L,357111317192L,32931L,3741434753596L,16771737983899710L,110310L,710911312713L,BigInteger.Parse("11371391491511571631671731791811911931971992"),11223L,BigInteger.Parse("22722923323924125125726326927127728128329330"),7311313317L,BigInteger.Parse("33133734734935335936") };
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
public class A077303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077303Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A077303.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077303.Bytes);
public BigInteger this[int i]=>Value[i];

public static A077303Inst Instance=new A077303Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077304
{
public static readonly BigInteger[] Value={ 2357111317192L,32931L,374143475L,35L,961677173798L,38997101L,BigInteger.Parse("103107109113127131137139149151157163167173179181191193197199"),211223L,227229233239241L,251257263269L,27127728L,12832933073L,11313317331337L };
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
public class A077304Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077304.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077304Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A077304.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077304.Bytes);
public BigInteger this[int i]=>Value[i];

public static A077304Inst Instance=new A077304Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077305
{
public static readonly BigInteger[] Value={ 4L,6L,8910L,121415L,161820212224L,25262728303233343L,BigInteger.Parse("536383940424445464849505152"),5455565L,758606263L,6465666L,BigInteger.Parse("8697072747576777880818"),BigInteger.Parse("2848586878890919293949"),BigInteger.Parse("59698991001021041051061081101111121141151161171181191201") };
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
public class A077305Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077305.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077305Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A077305.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077305.Bytes);
public BigInteger this[int i]=>Value[i];

public static A077305Inst Instance=new A077305Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077306
{
public static readonly BigInteger[] Value={ 1L,12L,123L,3456L,12345L,123456L,3456789L,56789101112L,123456789L,12345678910L,BigInteger.Parse("910111213141516171819"),123456789101112L,BigInteger.Parse("45678910111213141516"),BigInteger.Parse("7891011121314151617181920"),BigInteger.Parse("123456789101112131415"),BigInteger.Parse("567891011121314151617181920") };
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
public class A077306Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077306.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077306Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A077306.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077306.Bytes);
public BigInteger this[int i]=>Value[i];

public static A077306Inst Instance=new A077306Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077307
{
public static readonly long[] Value={ 1L,1L,1L,5L,5L,5L,5L,5L,17L,17L,17L,29L,29L,29L,29L,29L,35L,35L,35L,35L,47L,47L,47L,47L,47L,71L,71L,71L,87L,87L,87L,87L,87L,99L,99L,99L,123L,123L,123L,123L,123L,147L,147L,147L,159L,159L,159L,159L,159L,167L,167L,167L,191L,191L,191L,191L,191L,239L,239L,239L,275L,275L,275L,275L,275L,281L,281L,281L,293L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077307Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077307.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077307Inst : IEnumerable<long>
{
public static readonly long[] Value=A077307.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077307.Bytes);
public long this[int i]=>Value[i];

public static A077307Inst Instance=new A077307Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077308
{
public static readonly long[] Value={ 1L,1L,1L,3L,1L,1L,3L,5L,1L,1L,9L,1L,4L,7L,1L,5L,23L,1L,14L,1L,9L,9L,13L,5L,1L,21L,1L,13L,12L,1L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077308Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077308.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077308Inst : IEnumerable<long>
{
public static readonly long[] Value=A077308.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077308.Bytes);
public long this[int i]=>Value[i];

public static A077308Inst Instance=new A077308Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077309
{
public static readonly BigInteger[] Value={ 1L,23L,345L,4567L,56789L,67891011L,78910111213L,89101112131415L,91011121314151617L,10111213141516171819UL,BigInteger.Parse("1112131415161718192021"),BigInteger.Parse("121314151617181920212223") };
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
public class A077309Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077309.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077309Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A077309.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077309.Bytes);
public BigInteger this[int i]=>Value[i];

public static A077309Inst Instance=new A077309Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077310
{
public static readonly BigInteger[] Value={ 2L,34L,45L,56L,678910L,78L,8910111213141516L,9101112L,1011121314151617L,11121314151617181920UL,12131415161718192021UL,1314151617181920L,BigInteger.Parse("14151617181920212223242526272829303132333435"),BigInteger.Parse("15161718192021222324252627282930"),1617181920L,17181920L,1819L,1920212223242526L };
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
public class A077310Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077310.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077310Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A077310.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077310.Bytes);
public BigInteger this[int i]=>Value[i];

public static A077310Inst Instance=new A077310Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077311
{
public static readonly BigInteger[] Value={ 2L,17L,15L,14L,135782L,13L,1272873030448788L,1137639L,112346812683513L,1112131415161718192L,1102855923792562911L,109512634765160L,BigInteger.Parse("1088585937070785555634040482525331010179495") };
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
public class A077311Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077311.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077311Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A077311.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077311.Bytes);
public BigInteger this[int i]=>Value[i];

public static A077311Inst Instance=new A077311Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077312
{
public static readonly long[] Value={ 2L,4L,5L,6L,10L,8L,16L,12L,17L,20L,21L,20L,35L,30L,20L,20L,19L,26L,22L,40L,41L,32L,40L,36L,50L,48L,53L,44L,54L,50L,141L,52L,44L,36L,55L,44L,1035L,90L,77L,60L,101L,62L,47L,76L,80L,88L,97L,68L,145L,100L,53L,148L,146L,80L,65L,76L,60L,108L,103L,80L,107L,102L,108L,104L,115L,98L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077312Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077312.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077312Inst : IEnumerable<long>
{
public static readonly long[] Value=A077312.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077312.Bytes);
public long this[int i]=>Value[i];

public static A077312Inst Instance=new A077312Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077313
{
public static readonly long[] Value={ 3L,7L,19L,31L,79L,127L,199L,499L,1249L,1279L,1999L,4999L,5119L,8191L,12799L,20479L,31249L,49999L,51199L,79999L,81919L,131071L,199999L,524287L,799999L,1249999L,1310719L,3124999L,3276799L,4999999L,7812499L,12499999L,19999999L,20479999L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077313Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077313.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077313Inst : IEnumerable<long>
{
public static readonly long[] Value=A077313.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077313.Bytes);
public long this[int i]=>Value[i];

public static A077313Inst Instance=new A077313Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077314
{
public static readonly long[] Value={ 3L,7L,13L,31L,97L,127L,223L,1567L,3583L,4801L,6271L,8191L,19207L,25087L,33613L,76831L,131071L,401407L,524287L,917503L,1229311L,1605631L,3764767L,6588343L,14680063L,184473631L,737894527L,2147483647L,2259801991L,2877292543L,3758096383L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077314Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077314.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077314Inst : IEnumerable<long>
{
public static readonly long[] Value=A077314.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077314.Bytes);
public long this[int i]=>Value[i];

public static A077314Inst Instance=new A077314Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077315
{
public static readonly long[] Value={ 3L,7L,31L,43L,127L,241L,967L,5323L,8191L,117127L,131071L,524287L,7496191L,10307263L,77948683L,253755391L,428717761L,738197503L,1714871047L,2147483647L,16240345087L,27437936767L,42218553343L,1965081755647L,2414538435583L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077315Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077315.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077315Inst : IEnumerable<long>
{
public static readonly long[] Value=A077315.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077315.Bytes);
public long this[int i]=>Value[i];

public static A077315Inst Instance=new A077315Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077348
{
public static readonly long[] Value={ 1L,5L,15L,6L,18L,19L,2L,7L,20L,21L,23L,24L,71L,72L,73L,8L,25L,26L,78L,79L,80L,27L,28L,84L,85L,86L,87L,88L,9L,29L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077348Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077348.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077348Inst : IEnumerable<long>
{
public static readonly long[] Value=A077348.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077348.Bytes);
public long this[int i]=>Value[i];

public static A077348Inst Instance=new A077348Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077349
{
public static readonly long[] Value={ 1L,15L,19L,21L,73L,80L,88L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077349Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077349.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077349Inst : IEnumerable<long>
{
public static readonly long[] Value=A077349.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077349.Bytes);
public long this[int i]=>Value[i];

public static A077349Inst Instance=new A077349Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077350
{
public static readonly BigInteger[] Value={ 1L,2L,361L,46L,519885601L,63L,729L,88L,9025L,1053L,BigInteger.Parse("110462212541120451001"),126L,13841287201L,1458L,15376L,168L,BigInteger.Parse("1771091617586207101953855861006509233214261761"),180L,BigInteger.Parse("19267699140703639475173287301067237020969"),2000L,210681L,228352L,2384185791015625L,2430L,25091827216L,2625536L,27225L,28480L };
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
public class A077350Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077350.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077350Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A077350.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077350.Bytes);
public BigInteger this[int i]=>Value[i];

public static A077350Inst Instance=new A077350Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077351
{
public static readonly long[] Value={ 1L,12L,0L,124L,15L,1236L,0L,1248L,0L,11250L,0L,0L,0L,21714L,11355L,112864L,0L,0L,0L,10122540L,0L,0L,0L,1122234648L,1525L,112632L,0L,11242784L,0L,10112335560L,0L,11223648L,0L,131274L,13755L,0L,0L,123918L,0L,10012245480L,0L,11122234746L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077351Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077351.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077351Inst : IEnumerable<long>
{
public static readonly long[] Value=A077351.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077351.Bytes);
public long this[int i]=>Value[i];

public static A077351Inst Instance=new A077351Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077352
{
public static readonly BigInteger[] Value={ 1L,6L,31L,156L,7801L,390051L,19502551L,9751275501L,4875637750501L,2437818875250501L,12189094376252505001UL,BigInteger.Parse("60945471881262525005001"),BigInteger.Parse("304727359406312625025005001"),BigInteger.Parse("1523636797031563125125025005001") };
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
public class A077352Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077352.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077352Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A077352.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077352.Bytes);
public BigInteger this[int i]=>Value[i];

public static A077352Inst Instance=new A077352Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077353
{
public static readonly BigInteger[] Value={ 1L,3L,61L,12201L,2440201L,4880402001L,97608040020001L,1952160800400020001L,BigInteger.Parse("390432160080004000200001"),BigInteger.Parse("780864320160008000400002000001"),BigInteger.Parse("1561728640320016000800004000002000001"),BigInteger.Parse("31234572806400320016000080000040000020000001") };
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
public class A077353Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077353.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077353Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A077353.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077353.Bytes);
public BigInteger this[int i]=>Value[i];

public static A077353Inst Instance=new A077353Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077354
{
public static readonly long[] Value={ 1L,7L,21L,43L,73L,115L,165L,227L,301L,381L,471L,569L,685L,809L,937L,1089L,1247L,1425L,1611L,1809L,2023L,2249L,2479L,2735L,2997L,3267L,3553L,3859L,4181L,4513L,4835L,5191L,5547L,5937L,6335L,6745L,7171L,7607L,8059L,8523L,9005L,9507L,10007L,10527L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077354Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077354.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077354Inst : IEnumerable<long>
{
public static readonly long[] Value=A077354.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077354.Bytes);
public long this[int i]=>Value[i];

public static A077354Inst Instance=new A077354Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077355
{
public static readonly long[] Value={ 0L,1L,4L,9L,16L,25L,36L,49L,64L,81L,100L,144L,196L,400L,441L,841L,900L,1369L,3364L,4096L,5041L,8649L,10000L,10816L,11449L,20164L,38416L,40000L,61009L,64009L,77841L,90000L,117649L,132496L,170569L,231361L,249001L,288369L,310249L,405769L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077355Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077355.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077355Inst : IEnumerable<long>
{
public static readonly long[] Value=A077355.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077355.Bytes);
public long this[int i]=>Value[i];

public static A077355Inst Instance=new A077355Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077356
{
public static readonly long[] Value={ 0L,1L,4L,9L,16L,25L,36L,49L,64L,81L,196L,225L,841L,1156L,1296L,1936L,2025L,3136L,4489L,6084L,6724L,8281L,10816L,11236L,12996L,13456L,15376L,15876L,17956L,18496L,21025L,24025L,27225L,30276L,30976L,33856L,34596L,37636L,38416L,41209L,42849L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077356Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077356.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077356Inst : IEnumerable<long>
{
public static readonly long[] Value=A077356.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077356.Bytes);
public long this[int i]=>Value[i];

public static A077356Inst Instance=new A077356Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077357
{
public static readonly long[] Value={ 0L,1L,4L,9L,16L,25L,36L,49L,64L,81L,196L,841L,10816L,38416L,132496L,405769L,3013696L,8003241L,10010896L,17106496L,82246761L,1021697296L,32747969296L,86925318561L,119013960256L,3495164855296L,4974001681009L,6323524974244L,60207636572164L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077357Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077357.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077357Inst : IEnumerable<long>
{
public static readonly long[] Value=A077357.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077357.Bytes);
public long this[int i]=>Value[i];

public static A077357Inst Instance=new A077357Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077358
{
public static readonly long[] Value={ 127L,131L,137L,139L,151L,157L,173L,179L,223L,227L,229L,233L,239L,251L,257L,271L,277L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077358Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077358.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077358Inst : IEnumerable<long>
{
public static readonly long[] Value=A077358.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077358.Bytes);
public long this[int i]=>Value[i];

public static A077358Inst Instance=new A077358Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077359
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,13L,17L,19L,23L,29L,31L,37L,41L,43L,47L,53L,59L,61L,67L,71L,73L,79L,83L,89L,97L,101L,103L,107L,109L,113L,127L,131L,137L,139L,149L,151L,157L,163L,167L,173L,179L,181L,191L,193L,197L,199L,223L,229L,233L,239L,263L,269L,283L,293L,307L,311L,317L,331L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077359Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077359.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077359Inst : IEnumerable<long>
{
public static readonly long[] Value=A077359.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077359.Bytes);
public long this[int i]=>Value[i];

public static A077359Inst Instance=new A077359Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077360
{
public static readonly long[] Value={ 127L,131L,137L,139L,151L,157L,173L,179L,223L,229L,233L,239L,331L,337L,421L,431L,433L,457L,523L,631L,677L,733L,739L,751L,773L,823L,829L,839L,853L,859L,937L,977L,1021L,1031L,1033L,1039L,1051L,1117L,1171L,1193L,1231L,1237L,1291L,1297L,1319L,1373L,1433L,1439L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077360Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077360.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077360Inst : IEnumerable<long>
{
public static readonly long[] Value=A077360.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077360.Bytes);
public long this[int i]=>Value[i];

public static A077360Inst Instance=new A077360Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077361
{
public static readonly long[] Value={ 0L,0L,127L,1021L,10037L,100057L,1000033L,10000079L,100000037L,1000000021L,10000000033L,100000000057L,1000000000039L,10000000000037L,100000000000031L,1000000000000037L,10000000000000079L,100000000000000021L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077361Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077361.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077361Inst : IEnumerable<long>
{
public static readonly long[] Value=A077361.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077361.Bytes);
public long this[int i]=>Value[i];

public static A077361Inst Instance=new A077361Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077362
{
public static readonly long[] Value={ 0L,0L,977L,9677L,99377L,998717L,9998777L,99999617L,999999017L,9999996437L,99999997397L,999999997277L,9999999986477L,99999999993317L,999999999997337L,9999999999990797L,99999999999998837L,999999999999995717L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077362Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077362.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077362Inst : IEnumerable<long>
{
public static readonly long[] Value=A077362.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077362.Bytes);
public long this[int i]=>Value[i];

public static A077362Inst Instance=new A077362Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077363
{
public static readonly BigInteger[] Value={ 1L,16L,196L,0L,10816L,132496L,3013696L,10010896L,0L,1021697296L,32747969296L,119013960256L,3495164855296L,60207636572164L,401377463841649L,0L,80921770503885441L,0L,0L,0L,BigInteger.Parse("174389521641325050256"),BigInteger.Parse("1436097534223509431296") };
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
public class A077363Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077363.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077363Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A077363.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077363.Bytes);
public BigInteger this[int i]=>Value[i];

public static A077363Inst Instance=new A077363Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077572
{
public static readonly long[] Value={ 4L,8L,9L,44L,88L,99L,333L,444L,666L,888L,999L,4444L,8888L,9999L,44444L,88888L,99999L,333333L,444444L,666666L,777777L,888888L,999999L,4444444L,8888888L,9999999L,44444444L,88888888L,99999999L,111111111L,222222222L,333333333L,444444444L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077572Inst : IEnumerable<long>
{
public static readonly long[] Value=A077572.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077572.Bytes);
public long this[int i]=>Value[i];

public static A077572Inst Instance=new A077572Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077573
{
public static readonly BigInteger[] Value={ 0L,111L,0L,111111L,11L,111111L,1111111111111111L,111111111111111111L,BigInteger.Parse("1111111111111111111111"),BigInteger.Parse("1111111111111111111111111111"),111111111111111L,111L,11111L,BigInteger.Parse("111111111111111111111"),BigInteger.Parse("1111111111111111111111111111111111111111111111") };
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
public class A077573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077573Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A077573.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077573.Bytes);
public BigInteger this[int i]=>Value[i];

public static A077573Inst Instance=new A077573Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077574
{
public static readonly long[] Value={ 0L,3L,0L,6L,2L,6L,16L,18L,22L,28L,15L,3L,5L,21L,46L,13L,58L,60L,33L,35L,8L,13L,41L,44L,96L,4L,34L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077574Inst : IEnumerable<long>
{
public static readonly long[] Value=A077574.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077574.Bytes);
public long this[int i]=>Value[i];

public static A077574Inst Instance=new A077574Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077575
{
public static readonly BigInteger[] Value={ 0L,37L,0L,15873L,1L,8547L,65359477124183L,5847953216374269L,BigInteger.Parse("48309178743961352657"),BigInteger.Parse("38314176245210727969348659"),3584229390681L,3L,271L,2583979328165374677L,BigInteger.Parse("23640661938534278959810874704491725768321513") };
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
public class A077575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077575Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A077575.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077575.Bytes);
public BigInteger this[int i]=>Value[i];

public static A077575Inst Instance=new A077575Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077576
{
public static readonly long[] Value={ 1L,23L,19L,263L,823L,678901L,50993L,1279L,211L,150866941L,353594393L,757819L,9012345678901L,213408443L,11904282563L,435503L,21339439879L,7403356241L,13212859242013L,27961L,205126079L,5201061865265117273L,54843374833199L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077576Inst : IEnumerable<long>
{
public static readonly long[] Value=A077576.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077576.Bytes);
public long this[int i]=>Value[i];

public static A077576Inst Instance=new A077576Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077577
{
public static readonly long[] Value={ 1L,11L,152L,1972L,2469L,113150L,335096L,11265432L,87668038L,678901234L,6171829405L,65751028806L,693257359915L,1675484929453L,45260082304526L,77160493132716L,4641249092228830L,25377167352537716L,123456784275503573L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077577Inst : IEnumerable<long>
{
public static readonly long[] Value=A077577.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077577.Bytes);
public long this[int i]=>Value[i];

public static A077577Inst Instance=new A077577Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077578
{
public static readonly BigInteger[] Value={ 1L,456L,12345L,90123456L,678901234567890L,1234567890123456L,BigInteger.Parse("45678901234567890123456"),BigInteger.Parse("901234567890123456789012345678901234567890123456") };
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
public class A077578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077578Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A077578.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077578.Bytes);
public BigInteger this[int i]=>Value[i];

public static A077578Inst Instance=new A077578Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

}