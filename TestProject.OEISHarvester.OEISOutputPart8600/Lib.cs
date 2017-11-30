using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A140196
{
public static readonly BigInteger[] Value={ 1L,5L,21L,175L,2665L,69147L,3183841L,259010439L,36989095651L,9310549716061L,4127913626714981L,3221885485823007739L,BigInteger.Parse("4428893445413111685241"),BigInteger.Parse("10721218357954583752212691"),BigInteger.Parse("45702135675375111739043639093") };
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
public class A140196Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140196.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140196Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A140196.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140196.Bytes);
public BigInteger this[int i]=>Value[i];

public static A140196Inst Instance=new A140196Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140195
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,2L,1L,2L,1L,1L,2L,2L,1L,1L,2L,2L,1L,2L,2L,4L,1L,2L,2L,4L,1L,1L,1L,1L,2L,2L,2L,2L,1L,2L,1L,2L,2L,4L,2L,4L,1L,1L,2L,2L,2L,2L,4L,4L,1L,2L,2L,4L,2L,4L,4L,8L,1L,1L,1L,1L,1L,1L,1L,1L,2L,3L,2L,3L,2L,3L,2L,3L,1L,2L,2L,3L,1L,2L,2L,3L,2L,4L,4L,7L,2L,4L,4L,7L,1L,1L,1L,2L,2L,2L,2L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140195Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140195.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140195Inst : IEnumerable<long>
{
public static readonly long[] Value=A140195.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140195.Bytes);
public long this[int i]=>Value[i];

public static A140195Inst Instance=new A140195Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140194
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,2L,3L,1L,1L,1L,1L,1L,2L,1L,3L,1L,1L,1L,1L,2L,3L,3L,5L,1L,1L,1L,2L,1L,1L,1L,3L,1L,1L,2L,3L,1L,1L,3L,5L,1L,2L,1L,3L,1L,3L,1L,5L,2L,3L,3L,5L,3L,5L,5L,10L,1L,1L,1L,1L,1L,1L,2L,3L,1L,1L,1L,1L,1L,2L,3L,5L,1L,1L,1L,1L,2L,3L,3L,5L,1L,1L,1L,2L,3L,5L,5L,9L,1L,1L,2L,3L,1L,1L,3L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140194Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140194.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140194Inst : IEnumerable<long>
{
public static readonly long[] Value=A140194.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140194.Bytes);
public long this[int i]=>Value[i];

public static A140194Inst Instance=new A140194Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140193
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,2L,2L,1L,1L,1L,1L,2L,2L,3L,3L,1L,1L,2L,2L,1L,1L,3L,3L,2L,2L,3L,3L,3L,3L,6L,6L,1L,1L,1L,1L,2L,2L,3L,3L,1L,1L,2L,2L,3L,3L,5L,5L,2L,2L,3L,3L,3L,3L,6L,6L,3L,3L,5L,5L,6L,6L,11L,11L,1L,1L,2L,2L,1L,1L,3L,3L,2L,2L,3L,3L,3L,3L,6L,6L,1L,1L,3L,3L,2L,2L,5L,5L,3L,3L,6L,6L,5L,5L,11L,11L,2L,2L,3L,3L,3L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140193Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140193.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140193Inst : IEnumerable<long>
{
public static readonly long[] Value=A140193.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140193.Bytes);
public long this[int i]=>Value[i];

public static A140193Inst Instance=new A140193Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140192
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,2L,1L,1L,2L,2L,1L,2L,2L,4L,1L,1L,1L,1L,2L,3L,2L,3L,1L,2L,2L,3L,2L,4L,4L,7L,1L,1L,1L,2L,1L,2L,1L,3L,2L,2L,3L,4L,2L,4L,3L,7L,1L,1L,2L,3L,2L,3L,3L,6L,2L,3L,4L,6L,4L,7L,7L,13L,1L,2L,1L,2L,1L,3L,2L,4L,1L,2L,2L,4L,1L,3L,3L,7L,2L,3L,2L,3L,3L,6L,4L,7L,2L,4L,4L,7L,3L,7L,7L,14L,1L,2L,1L,3L,2L,4L,3L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140192Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140192.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140192Inst : IEnumerable<long>
{
public static readonly long[] Value=A140192.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140192.Bytes);
public long this[int i]=>Value[i];

public static A140192Inst Instance=new A140192Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140191
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,2L,3L,1L,2L,1L,3L,2L,3L,3L,6L,1L,1L,2L,3L,1L,2L,3L,5L,2L,3L,3L,6L,3L,5L,6L,11L,1L,2L,1L,3L,2L,3L,3L,6L,1L,3L,2L,5L,3L,6L,5L,11L,2L,3L,3L,6L,3L,5L,6L,11L,3L,6L,5L,11L,6L,11L,11L,22L,1L,1L,2L,3L,1L,2L,3L,5L,2L,3L,3L,6L,3L,5L,6L,11L,1L,2L,3L,5L,2L,5L,5L,10L,3L,5L,6L,11L,5L,10L,11L,21L,2L,3L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140191Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140191.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140191Inst : IEnumerable<long>
{
public static readonly long[] Value=A140191.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140191.Bytes);
public long this[int i]=>Value[i];

public static A140191Inst Instance=new A140191Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140190
{
public static readonly long[] Value={ 1L,1L,3L,5L,9L,15L,27L,44L,71L,113L,176L,271L,413L,621L,927L,1375L,2004L,2924L,4213L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140190Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140190.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140190Inst : IEnumerable<long>
{
public static readonly long[] Value=A140190.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140190.Bytes);
public long this[int i]=>Value[i];

public static A140190Inst Instance=new A140190Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140189
{
public static readonly long[] Value={ 1L,1L,2L,3L,7L,9L,16L,22L,42L,57L,90L,124L,204L,275L,413L,562L,866L,1161L,1685L,2264L,3308L,4407L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140189Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140189.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140189Inst : IEnumerable<long>
{
public static readonly long[] Value=A140189.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140189.Bytes);
public long this[int i]=>Value[i];

public static A140189Inst Instance=new A140189Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140188
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,2L,3L,1L,1L,1L,3L,3L,1L,1L,2L,4L,5L,3L,1L,1L,1L,5L,6L,5L,3L,1L,1L,5L,8L,10L,9L,5L,3L,1L,1L,2L,10L,14L,12L,9L,5L,3L,1L,1L,2L,13L,21L,20L,15L,9L,5L,3L,1L,1L,1L,13L,24L,29L,23L,15L,9L,5L,3L,1L,1L,5L,20L,39L,42L,37L,27L,15L,9L,5L,3L,1L,1L,1L,19L,43L,58L,53L,40L,27L,15L,9L,5L,3L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140188Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140188.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140188Inst : IEnumerable<long>
{
public static readonly long[] Value=A140188.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140188.Bytes);
public long this[int i]=>Value[i];

public static A140188Inst Instance=new A140188Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140187
{
public static readonly long[] Value={ 1L,2L,3L,3L,5L,3L,6L,3L,10L,5L,6L,3L,13L,3L,6L,5L,24L,3L,13L,3L,13L,6L,6L,3L,33L,5L,6L,10L,12L,3L,14L,3L,75L,5L,6L,5L,34L,3L,6L,6L,32L,3L,17L,3L,12L,9L,6L,3L,99L,5L,13L,5L,13L,3L,33L,6L,30L,6L,6L,3L,39L,3L,6L,12L,342L,5L,14L,3L,13L,5L,14L,3L,104L,3L,6L,10L,12L,5L,17L,3L,98L,25L,6L,3L,43L,5L,6L,5L,29L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140187Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140187.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140187Inst : IEnumerable<long>
{
public static readonly long[] Value=A140187.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140187.Bytes);
public long this[int i]=>Value[i];

public static A140187Inst Instance=new A140187Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140186
{
public static readonly long[] Value={ 2L,1L,2L,2L,1L,2L,3L,5L,2L,2L,2L,5L,2L,2L,3L,15L,1L,5L,2L,5L,3L,2L,3L,15L,3L,2L,6L,4L,2L,4L,7L,51L,1L,4L,3L,14L,1L,2L,4L,14L,1L,6L,4L,4L,3L,3L,6L,52L,2L,5L,2L,7L,1L,15L,4L,13L,3L,2L,2L,13L,4L,2L,18L,267L,1L,4L,3L,5L,1L,9L,7L,50L,2L,2L,4L,4L,2L,6L,8L,52L,15L,2L,3L,15L,1L,2L,3L,14L,1L,10L,3L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140186Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140186.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140186Inst : IEnumerable<long>
{
public static readonly long[] Value=A140186.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140186.Bytes);
public long this[int i]=>Value[i];

public static A140186Inst Instance=new A140186Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140185
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,2L,1L,6L,3L,2L,1L,6L,1L,2L,1L,17L,1L,6L,1L,6L,2L,2L,1L,17L,3L,2L,6L,5L,1L,4L,1L,57L,1L,2L,1L,19L,1L,2L,2L,16L,1L,6L,1L,5L,3L,2L,1L,58L,3L,6L,1L,6L,1L,17L,2L,15L,2L,2L,1L,14L,1L,2L,5L,284L,1L,4L,1L,6L,1L,4L,1L,61L,1L,2L,4L,5L,1L,6L,1L,58L,18L,2L,1L,17L,1L,2L,1L,14L,1L,12L,1L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140185Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140185.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140185Inst : IEnumerable<long>
{
public static readonly long[] Value=A140185.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140185.Bytes);
public long this[int i]=>Value[i];

public static A140185Inst Instance=new A140185Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140184
{
public static readonly long[] Value={ 1L,14L,60L,360L,1904L,10528L,57280L,313472L,1711872L,9355776L,51117056L,279316480L,1526198272L,8339333120L,45566902272L,248982306816L,1360464379904L,7433716105216L,40618579197952L,221944046157824L,1212724817166336L,6626451640025088L,36207605093236736L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140184Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140184.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140184Inst : IEnumerable<long>
{
public static readonly long[] Value=A140184.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140184.Bytes);
public long this[int i]=>Value[i];

public static A140184Inst Instance=new A140184Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140071
{
public static readonly long[] Value={ 1L,3L,1L,9L,4L,1L,27L,13L,7L,1L,81L,40L,34L,8L,1L,243L,121L,142L,42L,11L,1L,729L,364L,547L,184L,75L,12L,1L,2187L,1093L,2005L,731L,409L,87L,15L,1L,6561L,3280L,7108L,2736L,1958L,496L,132L,16L,1L,19683L,9841L,24604L,9844L,8610L,2454L,892L,148L,19L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140071Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140071.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140071Inst : IEnumerable<long>
{
public static readonly long[] Value=A140071.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140071.Bytes);
public long this[int i]=>Value[i];

public static A140071Inst Instance=new A140071Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140070
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,1L,1L,13L,5L,1L,1L,40L,18L,8L,1L,1L,121L,58L,42L,9L,1L,1L,364L,179L,184L,51L,12L,1L,1L,1093L,543L,731L,235L,87L,13L,1L,1L,3280L,1636L,2736L,966L,496L,100L,16L,1L,1L,9841L,4916L,9844L,3702L,2454L,596L,148L,17L,1L,1L,29524L,14757L,34448L,13546L,11064L,3050L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140070Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140070.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140070Inst : IEnumerable<long>
{
public static readonly long[] Value=A140070.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140070.Bytes);
public long this[int i]=>Value[i];

public static A140070Inst Instance=new A140070Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140069
{
public static readonly long[] Value={ 1L,2L,1L,4L,3L,1L,8L,7L,5L,1L,16L,15L,17L,6L,1L,32L,31L,49L,23L,8L,1L,64L,63L,129L,72L,39L,9L,1L,128L,127L,321L,201L,150L,48L,11L,1L,256L,255L,769L,522L,501L,198L,70L,12L,1L,512L,511L,1793L,1291L,1524L,699L,338L,82L,14L,1L,1024L,1023L,4097L,3084L,4339L,2223L,1375L,420L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140069Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140069.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140069Inst : IEnumerable<long>
{
public static readonly long[] Value=A140069.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140069.Bytes);
public long this[int i]=>Value[i];

public static A140069Inst Instance=new A140069Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140068
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,7L,4L,1L,1L,15L,11L,6L,1L,1L,31L,26L,23L,7L,1L,1L,63L,57L,72L,30L,9L,1L,1L,127L,120L,201L,102L,48L,10L,1L,1L,255L,247L,522L,303L,198L,58L,12L,1L,1L,511L,502L,1291L,825L,699L,256L,82L,13L,1L,1L,1023L,1013L,3084L,2116L,2223L,955L,420L,95L,15L,1L,1L,2047L,2036L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140068Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140068.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140068Inst : IEnumerable<long>
{
public static readonly long[] Value=A140068.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140068.Bytes);
public long this[int i]=>Value[i];

public static A140068Inst Instance=new A140068Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140067
{
public static readonly long[] Value={ 1L,2L,4L,6L,8L,12L,16L,18L,24L,30L,36L,42L,48L,60L,72L,84L,90L,96L,108L,120L,144L,168L,180L,192L,210L,216L,240L,252L,264L,288L,300L,312L,324L,336L,360L,384L,396L,408L,420L,432L,468L,480L,504L,528L,540L,576L,600L,648L,660L,672L,720L,756L,780L,792L,816L,840L,900L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140067Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140067.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140067Inst : IEnumerable<long>
{
public static readonly long[] Value=A140067.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140067.Bytes);
public long this[int i]=>Value[i];

public static A140067Inst Instance=new A140067Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140066
{
public static readonly long[] Value={ 1L,3L,10L,22L,39L,61L,88L,120L,157L,199L,246L,298L,355L,417L,484L,556L,633L,715L,802L,894L,991L,1093L,1200L,1312L,1429L,1551L,1678L,1810L,1947L,2089L,2236L,2388L,2545L,2707L,2874L,3046L,3223L,3405L,3592L,3784L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140066Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140066.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140066Inst : IEnumerable<long>
{
public static readonly long[] Value=A140066.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140066.Bytes);
public long this[int i]=>Value[i];

public static A140066Inst Instance=new A140066Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140065
{
public static readonly long[] Value={ 1L,3L,12L,28L,51L,81L,118L,162L,213L,271L,336L,408L,487L,573L,666L,766L,873L,987L,1108L,1236L,1371L,1513L,1662L,1818L,1981L,2151L,2328L,2512L,2703L,2901L,3106L,3318L,3537L,3763L,3996L,4236L,4483L,4737L,4998L,5266L,5541L,5823L,6112L,6408L,6711L,7021L,7338L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140065Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140065.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140065Inst : IEnumerable<long>
{
public static readonly long[] Value=A140065.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140065.Bytes);
public long this[int i]=>Value[i];

public static A140065Inst Instance=new A140065Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140064
{
public static readonly long[] Value={ 1L,3L,14L,34L,63L,101L,148L,204L,269L,343L,426L,518L,619L,729L,848L,976L,1113L,1259L,1414L,1578L,1751L,1933L,2124L,2324L,2533L,2751L,2978L,3214L,3459L,3713L,3976L,4248L,4529L,4819L,5118L,5426L,5743L,6069L,6404L,6748L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140064Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140064.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140064Inst : IEnumerable<long>
{
public static readonly long[] Value=A140064.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140064.Bytes);
public long this[int i]=>Value[i];

public static A140064Inst Instance=new A140064Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140063
{
public static readonly long[] Value={ 1L,4L,14L,31L,55L,86L,124L,169L,221L,280L,346L,419L,499L,586L,680L,781L,889L,1004L,1126L,1255L,1391L,1534L,1684L,1841L,2005L,2176L,2354L,2539L,2731L,2930L,3136L,3349L,3569L,3796L,4030L,4271L,4519L,4774L,5036L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140063Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140063.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140063Inst : IEnumerable<long>
{
public static readonly long[] Value=A140063.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140063.Bytes);
public long this[int i]=>Value[i];

public static A140063Inst Instance=new A140063Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140062
{
public static readonly long[] Value={ 1L,102L,304L,708L,1516L,3132L,6364L,12828L,25756L,51612L,103324L,206748L,413596L,827292L,1654684L,3309468L,6619036L,13238172L,26476444L,52952988L,105906076L,211812252L,423624604L,847249308L,1694498716L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140062Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140062.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140062Inst : IEnumerable<long>
{
public static readonly long[] Value=A140062.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140062.Bytes);
public long this[int i]=>Value[i];

public static A140062Inst Instance=new A140062Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140061
{
public static readonly long[] Value={ 1L,3L,2L,5L,4L,3L,9L,8L,6L,4L,11L,10L,9L,8L,5L,17L,16L,15L,12L,10L,6L,21L,20L,18L,16L,15L,12L,7L,29L,28L,27L,24L,20L,18L,14L,8L,33L,32L,30L,28L,25L,24L,21L,16L,9L,41L,40L,39L,36L,35L,30L,28L,24L,18L,10L,47L,46L,45L,44L,40L,36L,35L,32L,27L,20L,11L,57L,56L,54L,52L,50L,48L,42L,40L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140061Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140061.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140061Inst : IEnumerable<long>
{
public static readonly long[] Value=A140061.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140061.Bytes);
public long this[int i]=>Value[i];

public static A140061Inst Instance=new A140061Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140060
{
public static readonly long[] Value={ 1L,2L,2L,3L,2L,4L,4L,3L,5L,4L,3L,6L,6L,6L,4L,7L,6L,6L,4L,8L,8L,6L,4L,9L,8L,6L,4L,10L,10L,9L,8L,5L,11L,10L,9L,8L,5L,12L,12L,12L,12L,10L,6L,13L,12L,12L,12L,10L,6L,14L,14L,12L,12L,10L,6L,15L,14L,12L,12L,10L,6L,16L,16L,15L,12L,10L,6L,17L,16L,15L,12L,10L,6L,18L,18L,18L,16L,15L,12L,7L,19L,18L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140060Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140060.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140060Inst : IEnumerable<long>
{
public static readonly long[] Value=A140060.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140060.Bytes);
public long this[int i]=>Value[i];

public static A140060Inst Instance=new A140060Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140059
{
public static readonly long[] Value={ 1L,1L,0L,1L,0L,-1L,1L,-3L,-3L,9L,1L,-4L,-20L,32L,96L,1L,-10L,-25L,250L,125L,-1250L,1L,-12L,-93L,576L,2592L,-5184L,-19440L,1L,-21L,-98L,0L,2058L,2401L,50421L,16807L,352947L,1L,-24L,-272L,3840L,24064L,-147456L,-753664L,1572864L,7340032L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140059Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140059.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140059Inst : IEnumerable<long>
{
public static readonly long[] Value=A140059.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140059.Bytes);
public long this[int i]=>Value[i];

public static A140059Inst Instance=new A140059Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140058
{
public static readonly long[] Value={ 25L,26L,27L,28L,29L,35L,36L,37L,38L,39L,45L,46L,47L,48L,49L,55L,56L,57L,58L,59L,65L,66L,67L,68L,69L,75L,76L,77L,78L,79L,85L,86L,87L,88L,89L,95L,96L,97L,98L,99L,105L,106L,107L,108L,109L,115L,116L,117L,118L,119L,125L,126L,127L,128L,129L,135L,136L,137L,138L,139L,145L,146L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140058Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140058.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140058Inst : IEnumerable<long>
{
public static readonly long[] Value=A140058.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140058.Bytes);
public long this[int i]=>Value[i];

public static A140058Inst Instance=new A140058Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140057
{
public static readonly long[] Value={ 1L,22L,122L,221L,333L,1221L,1333L,3331L,4444L,13331L,14444L,22122L,22333L,33322L,44441L,55555L,122122L,122333L,133322L,144441L,155555L,221221L,221333L,223331L,224444L,333122L,333221L,444422L,555551L,666666L,1221221L,1221333L,1223331L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140057Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140057.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140057Inst : IEnumerable<long>
{
public static readonly long[] Value=A140057.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140057.Bytes);
public long this[int i]=>Value[i];

public static A140057Inst Instance=new A140057Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A140056
{
public static readonly long[] Value={ -3L,-2L,-1L,-1L,-2L,-1L,-1L,-1L,-1L,-1L,0L,-1L,-1L,-1L,0L,0L,-1L,-1L,-1L,0L,0L,0L,-1L,-1L,-1L,0L,0L,0L,0L,-1L,-1L,-1L,0L,0L,0L,0L,0L,-1L,-1L,-1L,0L,0L,0L,0L,0L,0L,-1L,-1L,-1L,0L,0L,0L,0L,0L,0L,0L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A140056Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A140056.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A140056Inst : IEnumerable<long>
{
public static readonly long[] Value=A140056.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A140056.Bytes);
public long this[int i]=>Value[i];

public static A140056Inst Instance=new A140056Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139943
{
public static readonly long[] Value={ 3L,131L,167L,227L,311L,419L,479L,503L,719L,839L,887L,983L,1091L,1151L,1319L,1559L,1571L,1847L,1907L,1931L,1979L,2063L,2267L,2351L,2411L,2579L,2663L,2819L,2999L,3023L,3083L,3167L,3191L,3359L,3407L,3491L,3779L,3947L,4007L,4091L,4451L,4583L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139943Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139943.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139943Inst : IEnumerable<long>
{
public static readonly long[] Value=A139943.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139943.Bytes);
public long this[int i]=>Value[i];

public static A139943Inst Instance=new A139943Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139942
{
public static readonly long[] Value={ 2L,179L,191L,239L,263L,359L,443L,491L,599L,659L,863L,1019L,1103L,1283L,1583L,1607L,1619L,1667L,1787L,1871L,2027L,2039L,2087L,2423L,2447L,2531L,2699L,2711L,2843L,3011L,3119L,3299L,3347L,3467L,3623L,3719L,3851L,4127L,4139L,4271L,4463L,4523L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139942Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139942.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139942Inst : IEnumerable<long>
{
public static readonly long[] Value=A139942.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139942.Bytes);
public long this[int i]=>Value[i];

public static A139942Inst Instance=new A139942Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139941
{
public static readonly long[] Value={ 19L,79L,199L,379L,571L,619L,631L,751L,919L,1171L,1279L,1399L,1459L,1471L,1579L,1699L,1759L,1831L,1951L,1999L,2011L,2131L,2179L,2251L,2311L,2551L,2659L,2719L,2731L,2851L,3079L,3271L,3319L,3331L,3391L,3511L,3559L,3631L,3691L,3931L,4099L,4111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139941Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139941.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139941Inst : IEnumerable<long>
{
public static readonly long[] Value=A139941.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139941.Bytes);
public long this[int i]=>Value[i];

public static A139941Inst Instance=new A139941Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139940
{
public static readonly long[] Value={ 23L,83L,107L,227L,263L,383L,467L,503L,563L,743L,827L,983L,1103L,1187L,1307L,1367L,1487L,1523L,1583L,1607L,1667L,1847L,1907L,2087L,2207L,2687L,2843L,2903L,2963L,3023L,3323L,3467L,3863L,3947L,4007L,4127L,4283L,4523L,4643L,4703L,4943L,4967L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139940Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139940.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139940Inst : IEnumerable<long>
{
public static readonly long[] Value=A139940.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139940.Bytes);
public long this[int i]=>Value[i];

public static A139940Inst Instance=new A139940Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139939
{
public static readonly long[] Value={ 37L,97L,157L,313L,337L,373L,433L,457L,613L,733L,757L,937L,1033L,1213L,1597L,1693L,1753L,1873L,1993L,2113L,2137L,2437L,2593L,2713L,2797L,2857L,2917L,3217L,3253L,3373L,3457L,3517L,3697L,3733L,3793L,4093L,4177L,4297L,4357L,4513L,4597L,4657L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139939Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139939.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139939Inst : IEnumerable<long>
{
public static readonly long[] Value=A139939.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139939.Bytes);
public long this[int i]=>Value[i];

public static A139939Inst Instance=new A139939Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139938
{
public static readonly long[] Value={ 59L,71L,131L,179L,239L,311L,491L,599L,719L,1151L,1319L,1439L,1451L,1499L,1511L,1559L,1619L,1871L,1979L,2099L,2111L,2339L,2531L,2579L,2699L,2819L,2879L,2939L,2999L,3251L,3359L,3371L,3491L,3659L,3719L,3911L,4079L,4211L,4259L,4271L,4451L,4751L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139938Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139938.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139938Inst : IEnumerable<long>
{
public static readonly long[] Value=A139938.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139938.Bytes);
public long this[int i]=>Value[i];

public static A139938Inst Instance=new A139938Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139937
{
public static readonly long[] Value={ 5L,89L,149L,281L,389L,401L,521L,569L,641L,701L,881L,941L,1049L,1109L,1229L,1601L,1709L,1721L,1901L,1949L,2069L,2081L,2549L,2609L,2621L,2729L,2909L,3041L,3089L,3329L,3449L,3461L,3701L,3881L,3929L,3989L,4001L,4229L,4289L,4421L,4481L,5021L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139937Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139937.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139937Inst : IEnumerable<long>
{
public static readonly long[] Value=A139937.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139937.Bytes);
public long this[int i]=>Value[i];

public static A139937Inst Instance=new A139937Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139936
{
public static readonly long[] Value={ 3L,127L,163L,223L,307L,463L,487L,547L,607L,823L,883L,967L,1087L,1327L,1543L,1567L,1783L,1867L,1987L,2083L,2143L,2203L,2347L,2467L,2647L,2707L,2887L,3067L,3163L,3187L,3307L,3343L,3463L,3583L,3643L,3727L,3847L,4003L,4027L,4327L,4363L,4447L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139936Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139936.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139936Inst : IEnumerable<long>
{
public static readonly long[] Value=A139936.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139936.Bytes);
public long this[int i]=>Value[i];

public static A139936Inst Instance=new A139936Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139935
{
public static readonly long[] Value={ 2L,173L,197L,233L,257L,317L,353L,593L,653L,857L,1013L,1097L,1277L,1373L,1553L,1613L,1637L,1697L,1733L,1913L,1973L,2237L,2393L,2417L,2477L,2657L,2693L,2753L,2837L,2957L,3137L,3413L,3617L,3797L,4073L,4133L,4217L,4337L,4373L,4397L,4457L,4493L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139935Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139935.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139935Inst : IEnumerable<long>
{
public static readonly long[] Value=A139935.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139935.Bytes);
public long this[int i]=>Value[i];

public static A139935Inst Instance=new A139935Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139934
{
public static readonly long[] Value={ 37L,103L,157L,223L,367L,397L,463L,487L,727L,757L,823L,1087L,1093L,1213L,1237L,1303L,1423L,1453L,1543L,1567L,1783L,2143L,2293L,2557L,2677L,2797L,2887L,3037L,3463L,3613L,3727L,3733L,3853L,3877L,3943L,4093L,4327L,4357L,4423L,4447L,4783L,4933L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139934Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139934.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139934Inst : IEnumerable<long>
{
public static readonly long[] Value=A139934.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139934.Bytes);
public long this[int i]=>Value[i];

public static A139934Inst Instance=new A139934Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139933
{
public static readonly long[] Value={ 11L,41L,131L,281L,491L,569L,659L,761L,809L,1019L,1091L,1289L,1361L,1451L,1481L,1601L,1619L,1811L,1889L,1931L,1979L,2081L,2129L,2339L,2411L,2441L,2459L,2609L,2801L,2939L,2969L,3011L,3209L,3251L,3299L,3329L,3449L,3539L,3659L,3761L,3779L,3929L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139933Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139933.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139933Inst : IEnumerable<long>
{
public static readonly long[] Value=A139933.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139933.Bytes);
public long this[int i]=>Value[i];

public static A139933Inst Instance=new A139933Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139932
{
public static readonly long[] Value={ 43L,73L,193L,283L,307L,337L,457L,523L,547L,673L,787L,937L,1033L,1297L,1627L,1657L,1723L,1777L,1867L,1987L,1993L,2593L,2617L,2683L,2713L,2833L,2857L,3163L,3187L,3307L,3313L,3643L,3673L,3907L,4003L,4153L,4177L,4243L,4297L,4363L,4483L,4507L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139932Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139932.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139932Inst : IEnumerable<long>
{
public static readonly long[] Value=A139932.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139932.Bytes);
public long this[int i]=>Value[i];

public static A139932Inst Instance=new A139932Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139931
{
public static readonly long[] Value={ 61L,79L,109L,151L,271L,349L,439L,541L,919L,1069L,1231L,1381L,1399L,1429L,1471L,1669L,1759L,1789L,1861L,1999L,2221L,2239L,2389L,2551L,2719L,2749L,2791L,3079L,3109L,3181L,3229L,3319L,3511L,3541L,3559L,3709L,4021L,4111L,4231L,4549L,4639L,4759L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139931Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139931.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139931Inst : IEnumerable<long>
{
public static readonly long[] Value=A139931.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139931.Bytes);
public long this[int i]=>Value[i];

public static A139931Inst Instance=new A139931Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139930
{
public static readonly long[] Value={ 5L,71L,191L,269L,311L,389L,509L,599L,719L,839L,911L,1061L,1109L,1181L,1301L,1439L,1511L,1709L,1871L,1901L,2039L,2069L,2381L,2399L,2621L,2711L,2861L,2909L,3191L,3221L,3359L,3389L,3701L,3719L,3821L,4079L,4229L,4271L,4349L,4679L,4799L,4871L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139930Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139930.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139930Inst : IEnumerable<long>
{
public static readonly long[] Value=A139930.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139930.Bytes);
public long this[int i]=>Value[i];

public static A139930Inst Instance=new A139930Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139929
{
public static readonly long[] Value={ 3L,113L,137L,257L,353L,443L,467L,587L,617L,683L,947L,977L,1193L,1307L,1433L,1523L,1697L,1787L,1907L,2003L,2027L,2267L,2297L,2633L,2753L,2777L,2843L,2897L,2963L,3083L,3257L,3323L,3347L,3617L,3833L,3947L,4073L,4217L,4283L,4337L,4547L,4643L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139929Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139929.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139929Inst : IEnumerable<long>
{
public static readonly long[] Value=A139929.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139929.Bytes);
public long this[int i]=>Value[i];

public static A139929Inst Instance=new A139929Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139928
{
public static readonly long[] Value={ 2L,167L,173L,197L,263L,293L,503L,557L,677L,743L,887L,1223L,1487L,1493L,1583L,1613L,1733L,1823L,1847L,1877L,1997L,2063L,2087L,2207L,2213L,2477L,2543L,2837L,2903L,3167L,3407L,3527L,3533L,3797L,3863L,4127L,4133L,4157L,4253L,4373L,4397L,4463L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139928Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139928.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139928Inst : IEnumerable<long>
{
public static readonly long[] Value=A139928.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139928.Bytes);
public long this[int i]=>Value[i];

public static A139928Inst Instance=new A139928Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139879
{
public static readonly long[] Value={ 17L,41L,89L,257L,353L,521L,593L,761L,857L,881L,929L,1049L,1097L,1193L,1217L,1361L,1433L,1553L,1601L,1697L,1721L,1889L,2273L,2393L,2441L,2609L,2729L,2777L,2897L,3041L,3209L,3449L,3617L,3881L,4049L,4073L,4217L,4241L,4289L,4409L,4457L,4721L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139879Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139879.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139879Inst : IEnumerable<long>
{
public static readonly long[] Value=A139879.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139879.Bytes);
public long this[int i]=>Value[i];

public static A139879Inst Instance=new A139879Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139878
{
public static readonly long[] Value={ 23L,71L,191L,239L,263L,359L,431L,599L,743L,863L,911L,1031L,1103L,1367L,1439L,1583L,1607L,1871L,2039L,2087L,2111L,2207L,2423L,2447L,2543L,2591L,2711L,2879L,2927L,3119L,3623L,3719L,3767L,4127L,4271L,4391L,4463L,4799L,4943L,4967L,5231L,5279L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139878Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139878.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139878Inst : IEnumerable<long>
{
public static readonly long[] Value=A139878.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139878.Bytes);
public long this[int i]=>Value[i];

public static A139878Inst Instance=new A139878Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139877
{
public static readonly long[] Value={ 29L,53L,149L,197L,317L,389L,557L,653L,701L,821L,1061L,1229L,1373L,1493L,1709L,1733L,1877L,1901L,1997L,2069L,2213L,2237L,2333L,2381L,2549L,2741L,2837L,2909L,3221L,3389L,3413L,3557L,3581L,3677L,3917L,4013L,4229L,4253L,4349L,4397L,4421L,4517L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139877Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139877.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139877Inst : IEnumerable<long>
{
public static readonly long[] Value=A139877.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139877.Bytes);
public long this[int i]=>Value[i];

public static A139877Inst Instance=new A139877Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139876
{
public static readonly long[] Value={ 7L,31L,103L,199L,223L,271L,367L,439L,607L,727L,1039L,1063L,1231L,1279L,1399L,1447L,1543L,1567L,1783L,1879L,1951L,2239L,2287L,2383L,2551L,2719L,2791L,2887L,3079L,3391L,3463L,3559L,3583L,3631L,3727L,3919L,3967L,4231L,4423L,4567L,4591L,4639L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139876Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139876.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139876Inst : IEnumerable<long>
{
public static readonly long[] Value=A139876.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139876.Bytes);
public long this[int i]=>Value[i];

public static A139876Inst Instance=new A139876Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139875
{
public static readonly long[] Value={ 43L,67L,163L,211L,331L,379L,499L,547L,571L,739L,883L,907L,1051L,1171L,1579L,1723L,1747L,2011L,2083L,2179L,2251L,2347L,2683L,2731L,2851L,3019L,3067L,3187L,3259L,3571L,3691L,3739L,3907L,3931L,4027L,4099L,4243L,4363L,4603L,5107L,5419L,5443L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139875Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139875.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139875Inst : IEnumerable<long>
{
public static readonly long[] Value=A139875.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139875.Bytes);
public long this[int i]=>Value[i];

public static A139875Inst Instance=new A139875Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139874
{
public static readonly long[] Value={ 3L,59L,83L,131L,227L,251L,419L,467L,563L,587L,971L,1091L,1259L,1307L,1427L,1571L,1811L,1907L,1931L,1979L,2099L,2243L,2267L,2411L,2579L,2819L,2939L,3083L,3251L,3323L,3491L,3659L,3779L,3923L,3947L,4091L,4259L,4283L,4451L,4787L,4931L,5003L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139874Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139874.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139874Inst : IEnumerable<long>
{
public static readonly long[] Value=A139874.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139874.Bytes);
public long this[int i]=>Value[i];

public static A139874Inst Instance=new A139874Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139873
{
public static readonly long[] Value={ 13L,73L,193L,277L,337L,373L,457L,613L,673L,733L,853L,877L,937L,997L,1033L,1117L,1297L,1597L,1657L,1693L,1777L,1933L,1993L,2053L,2437L,2593L,2617L,2713L,2833L,2857L,2917L,3253L,3313L,3373L,3517L,3637L,3673L,4153L,4177L,4297L,4597L,4813L,4957L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139873Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139873.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139873Inst : IEnumerable<long>
{
public static readonly long[] Value=A139873.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139873.Bytes);
public long this[int i]=>Value[i];

public static A139873Inst Instance=new A139873Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139872
{
public static readonly long[] Value={ 11L,59L,71L,179L,191L,251L,311L,419L,599L,719L,839L,911L,971L,1259L,1439L,1499L,1511L,1571L,1871L,2039L,2099L,2399L,2531L,2579L,2699L,2711L,2819L,3191L,3359L,3371L,3491L,3719L,3851L,4019L,4079L,4139L,4211L,4271L,4679L,4691L,4799L,4871L,4931L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139872Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139872.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139872Inst : IEnumerable<long>
{
public static readonly long[] Value=A139872.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139872.Bytes);
public long this[int i]=>Value[i];

public static A139872Inst Instance=new A139872Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139871
{
public static readonly long[] Value={ 19L,79L,139L,151L,211L,271L,439L,571L,739L,811L,919L,1051L,1231L,1399L,1459L,1471L,1531L,1579L,1759L,1999L,2131L,2239L,2251L,2371L,2551L,2659L,2719L,2791L,2851L,3079L,3319L,3511L,3559L,3571L,3691L,3739L,4099L,4111L,4219L,4231L,4639L,4759L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139871Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139871.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139871Inst : IEnumerable<long>
{
public static readonly long[] Value=A139871.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139871.Bytes);
public long this[int i]=>Value[i];

public static A139871Inst Instance=new A139871Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139870
{
public static readonly long[] Value={ 29L,41L,101L,149L,281L,461L,569L,701L,761L,809L,821L,941L,1229L,1289L,1361L,1481L,1601L,1889L,1949L,2081L,2129L,2141L,2309L,2441L,2549L,2609L,2741L,2789L,2801L,2969L,3209L,3329L,3449L,3461L,3581L,3761L,3929L,3989L,4001L,4241L,4289L,4421L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139870Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139870.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139870Inst : IEnumerable<long>
{
public static readonly long[] Value=A139870.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139870.Bytes);
public long this[int i]=>Value[i];

public static A139870Inst Instance=new A139870Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139869
{
public static readonly long[] Value={ 5L,53L,113L,137L,257L,317L,353L,617L,653L,773L,797L,977L,1013L,1193L,1277L,1373L,1433L,1637L,1697L,1973L,2237L,2297L,2333L,2357L,2633L,2693L,2753L,2777L,2897L,2957L,3257L,3413L,3557L,3617L,3677L,3833L,3917L,4013L,4073L,4217L,4337L,4493L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139869Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139869.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139869Inst : IEnumerable<long>
{
public static readonly long[] Value=A139869.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139869.Bytes);
public long this[int i]=>Value[i];

public static A139869Inst Instance=new A139869Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139868
{
public static readonly long[] Value={ 3L,67L,103L,163L,223L,367L,463L,487L,643L,727L,823L,883L,907L,1087L,1123L,1303L,1423L,1483L,1543L,1567L,1747L,1783L,2083L,2143L,2203L,2347L,2467L,2707L,2803L,2887L,3067L,3463L,3547L,3727L,3943L,4027L,4327L,4423L,4447L,4603L,4723L,4783L,4987L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139868Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139868.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139868Inst : IEnumerable<long>
{
public static readonly long[] Value=A139868.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139868.Bytes);
public long this[int i]=>Value[i];

public static A139868Inst Instance=new A139868Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139867
{
public static readonly long[] Value={ 2L,83L,107L,167L,227L,263L,347L,503L,563L,743L,827L,887L,1163L,1187L,1223L,1283L,1427L,1487L,1583L,1667L,1823L,1847L,2063L,2087L,2207L,2243L,2543L,2903L,3167L,3203L,3407L,3467L,3527L,3803L,3863L,3923L,4127L,4463L,4523L,4583L,4703L,4787L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139867Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139867.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139867Inst : IEnumerable<long>
{
public static readonly long[] Value=A139867.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139867.Bytes);
public long this[int i]=>Value[i];

public static A139867Inst Instance=new A139867Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139866
{
public static readonly long[] Value={ 13L,41L,89L,97L,173L,181L,241L,257L,269L,293L,409L,433L,509L,521L,601L,661L,677L,773L,797L,829L,857L,941L,1021L,1097L,1153L,1181L,1193L,1237L,1249L,1321L,1361L,1433L,1553L,1609L,1637L,1693L,1741L,1777L,1861L,1889L,2029L,2089L,2141L,2161L,2273L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139866Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139866.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139866Inst : IEnumerable<long>
{
public static readonly long[] Value=A139866.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139866.Bytes);
public long this[int i]=>Value[i];

public static A139866Inst Instance=new A139866Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139865
{
public static readonly long[] Value={ 7L,19L,47L,83L,131L,139L,199L,251L,271L,283L,311L,367L,419L,467L,479L,503L,587L,619L,643L,647L,691L,719L,727L,859L,1151L,1223L,1259L,1279L,1483L,1487L,1531L,1543L,1559L,1567L,1783L,1811L,1847L,1867L,1879L,1907L,1987L,2063L,2099L,2239L,2243L,2267L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139865Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139865.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139865Inst : IEnumerable<long>
{
public static readonly long[] Value=A139865.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139865.Bytes);
public long this[int i]=>Value[i];

public static A139865Inst Instance=new A139865Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139864
{
public static readonly long[] Value={ 2L,67L,71L,79L,107L,127L,151L,179L,211L,331L,379L,431L,487L,547L,599L,659L,683L,743L,751L,827L,863L,907L,911L,991L,1019L,1171L,1283L,1367L,1439L,1471L,1523L,1579L,1663L,1667L,1723L,1747L,2003L,2027L,2083L,2111L,2143L,2179L,2207L,2311L,2339L,2347L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139864Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139864.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139864Inst : IEnumerable<long>
{
public static readonly long[] Value=A139864.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139864.Bytes);
public long this[int i]=>Value[i];

public static A139864Inst Instance=new A139864Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139799
{
public static readonly long[] Value={ 2L,6L,10L,12L,14L,15L,18L,20L,22L,24L,26L,28L,30L,33L,34L,38L,42L,44L,45L,46L,50L,51L,54L,56L,58L,60L,62L,66L,69L,70L,72L,74L,76L,78L,82L,86L,87L,90L,91L,92L,94L,95L,96L,98L,102L,105L,106L,108L,110L,114L,118L,120L,122L,123L,124L,126L,130L,132L,134L,138L,140L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139799Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139799.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139799Inst : IEnumerable<long>
{
public static readonly long[] Value=A139799.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139799.Bytes);
public long this[int i]=>Value[i];

public static A139799Inst Instance=new A139799Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139798
{
public static readonly long[] Value={ 8L,38L,111L,256L,511L,924L,1554L,2472L,3762L,5522L,7865L,10920L,14833L,19768L,25908L,33456L,42636L,53694L,66899L,82544L,100947L,122452L,147430L,176280L,209430L,247338L,290493L,339416L,394661L,456816L,526504L,604384L,691152L,787542L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139798Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139798.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139798Inst : IEnumerable<long>
{
public static readonly long[] Value=A139798.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139798.Bytes);
public long this[int i]=>Value[i];

public static A139798Inst Instance=new A139798Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139797
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,1L,3L,4L,10L,18L,39L,75L,153L,302L,608L,1212L,2429L,4853L,9711L,19416L,38838L,77670L,155347L,310687L,621381L,1242754L,2485516L,4971024L,9942057L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139797Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139797.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139797Inst : IEnumerable<long>
{
public static readonly long[] Value=A139797.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139797.Bytes);
public long this[int i]=>Value[i];

public static A139797Inst Instance=new A139797Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139796
{
public static readonly long[] Value={ 1L,1L,2L,5L,9L,28L,48L,165L,275L,1001L,1638L,6188L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139796Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139796.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139796Inst : IEnumerable<long>
{
public static readonly long[] Value=A139796.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139796.Bytes);
public long this[int i]=>Value[i];

public static A139796Inst Instance=new A139796Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139795
{
public static readonly long[] Value={ 1L,3L,7L,7L,13L,13L,19L,19L,31L,31L,31L,31L,43L,43L,43L,43L,61L,61L,61L,61L,67L,67L,67L,67L,91L,91L,91L,91L,91L,91L,91L,91L,121L,121L,121L,121L,127L,127L,127L,127L,151L,151L,151L,151L,151L,151L,151L,151L,211L,211L,211L,211L,211L,211L,211L,211L,211L,211L,211L,211L,211L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139795Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139795.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139795Inst : IEnumerable<long>
{
public static readonly long[] Value=A139795.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139795.Bytes);
public long this[int i]=>Value[i];

public static A139795Inst Instance=new A139795Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139794
{
public static readonly long[] Value={ 3L,4L,5L,5L,12L,13L,8L,15L,17L,20L,21L,29L,12L,35L,37L,9L,40L,41L,28L,45L,53L,11L,60L,61L,48L,55L,73L,39L,80L,89L,65L,72L,97L,20L,99L,101L,60L,91L,109L,15L,112L,113L,88L,105L,137L,51L,140L,149L,85L,132L,157L,52L,165L,173L,19L,180L,181L,95L,168L,193L,28L,195L,197L,60L,221L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139794Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139794.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139794Inst : IEnumerable<long>
{
public static readonly long[] Value=A139794.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139794.Bytes);
public long this[int i]=>Value[i];

public static A139794Inst Instance=new A139794Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139793
{
public static readonly long[] Value={ 0L,11L,23L,36L,41L,56L,63L,71L,89L,99L,11L,23L,36L,41L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139793Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139793.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139793Inst : IEnumerable<long>
{
public static readonly long[] Value=A139793.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139793.Bytes);
public long this[int i]=>Value[i];

public static A139793Inst Instance=new A139793Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139792
{
public static readonly BigInteger[] Value={ 1L,11L,171L,2731L,43691L,699051L,11184811L,178956971L,2863311531L,45812984491L,733007751851L,11728124029611L,187649984473771L,3002399751580331L,48038396025285291L,768614336404564651L,12297829382473034411UL,BigInteger.Parse("196765270119568550571"),BigInteger.Parse("3148244321913096809131") };
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
public class A139792Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139792.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139792Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A139792.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139792.Bytes);
public BigInteger this[int i]=>Value[i];

public static A139792Inst Instance=new A139792Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139791
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,8L,9L,11L,14L,15L,18L,20L,21L,23L,26L,29L,30L,33L,35L,36L,39L,41L,44L,48L,50L,51L,53L,54L,56L,63L,65L,68L,69L,74L,75L,78L,81L,83L,86L,89L,90L,95L,96L,98L,99L,105L,111L,113L,114L,116L,119L,120L,125L,128L,131L,134L,135L,138L,140L,141L,146L,153L,155L,156L,158L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139791Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139791.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139791Inst : IEnumerable<long>
{
public static readonly long[] Value=A139791.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139791.Bytes);
public long this[int i]=>Value[i];

public static A139791Inst Instance=new A139791Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139790
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,9L,7L,-7L,-57L,-199L,-569L,-1479L,-3641L,-8647L,-20025L,-45511L,-101945L,-225735L,-495161L,-1077703L,-2330169L,-5009863L,-10718777L,-22835655L,-48467513L,-102527431L,-216239673L,-454848967L,-954437177L,-1998352839L,-4175662649L,-8709239239L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139790Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139790.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139790Inst : IEnumerable<long>
{
public static readonly long[] Value=A139790.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139790.Bytes);
public long this[int i]=>Value[i];

public static A139790Inst Instance=new A139790Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139789
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,2L,3L,3L,4L,4L,4L,4L,5L,5L,6L,6L,6L,6L,6L,7L,7L,7L,8L,8L,8L,9L,9L,10L,10L,11L,11L,12L,12L,12L,12L,12L,12L,12L,13L,13L,13L,13L,13L,13L,14L,14L,14L,14L,15L,15L,16L,16L,16L,16L,16L,16L,16L,16L,16L,17L,17L,17L,17L,18L,18L,19L,19L,19L,19L,19L,20L,20L,20L,20L,20L,21L,21L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139789Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139789.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139789Inst : IEnumerable<long>
{
public static readonly long[] Value=A139789.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139789.Bytes);
public long this[int i]=>Value[i];

public static A139789Inst Instance=new A139789Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139788
{
public static readonly long[] Value={ 1L,7L,3L,9L,5L,1L,7L,3L,9L,5L,1L,7L,3L,9L,5L,1L,7L,3L,9L,5L,1L,7L,3L,9L,5L,1L,7L,3L,9L,5L,1L,7L,3L,9L,5L,1L,7L,3L,9L,5L,1L,7L,3L,9L,5L,1L,7L,3L,9L,5L,1L,7L,3L,9L,5L,1L,7L,3L,9L,5L,1L,7L,3L,9L,5L,1L,7L,3L,9L,5L,1L,7L,3L,9L,5L,1L,7L,3L,9L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139788Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139788.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139788Inst : IEnumerable<long>
{
public static readonly long[] Value=A139788.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139788.Bytes);
public long this[int i]=>Value[i];

public static A139788Inst Instance=new A139788Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139787
{
public static readonly long[] Value={ 9L,15L,21L,25L,33L,49L,51L,69L,87L,93L,111L,115L,129L,133L,141L,159L,169L,201L,205L,219L,235L,237L,259L,267L,289L,303L,319L,321L,327L,339L,361L,391L,393L,415L,427L,451L,489L,511L,517L,519L,529L,535L,537L,553L,559L,579L,583L,591L,655L,679L,685L,699L,717L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139787Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139787.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139787Inst : IEnumerable<long>
{
public static readonly long[] Value=A139787.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139787.Bytes);
public long this[int i]=>Value[i];

public static A139787Inst Instance=new A139787Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139786
{
public static readonly long[] Value={ 0L,1L,13L,127L,1105L,1255L,24337L,263671L,725953L,42823L,40610545L,163341463L,780593185L,5464152295L,51309760081L,45711664183L,2200721587585L,12583941205639L,3454291215793L,430419865184215L,3012939056289505L,10122098073837607L,92791637157241105L,517919756258420599L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139786Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139786.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139786Inst : IEnumerable<long>
{
public static readonly long[] Value=A139786.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139786.Bytes);
public long this[int i]=>Value[i];

public static A139786Inst Instance=new A139786Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139785
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,2L,4L,11L,19L,38L,76L,163L,315L,630L,1260L,2563L,5083L,10166L,20332L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139785Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139785.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139785Inst : IEnumerable<long>
{
public static readonly long[] Value=A139785.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139785.Bytes);
public long this[int i]=>Value[i];

public static A139785Inst Instance=new A139785Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139784
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,2L,4L,8L,19L,38L,76L,152L,315L,630L,1260L,2520L,5083L,10166L,20332L,40664L,81499L,162998L,325996L,651992L,1304667L,2609334L,5218668L,10437336L,20877403L,41754806L,83509612L,167019224L,334049371L,668098742L,1336197484L,2672394968L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139784Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139784.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139784Inst : IEnumerable<long>
{
public static readonly long[] Value=A139784.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139784.Bytes);
public long this[int i]=>Value[i];

public static A139784Inst Instance=new A139784Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139751
{
public static readonly long[] Value={ 2L,3L,5L,7L,2L,3L,5L,7L,5L,7L,11L,13L,11L,13L,17L,17L,19L,23L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139751Inst : IEnumerable<long>
{
public static readonly long[] Value=A139751.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139751.Bytes);
public long this[int i]=>Value[i];

public static A139751Inst Instance=new A139751Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139750
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,12L,14L,16L,20L,21L,23L,29L,30L,32L,34L,38L,41L,43L,45L,47L,50L,56L,61L,65L,70L,72L,74L,76L,78L,83L,89L,92L,98L,101L,110L,111L,113L,115L,120L,122L,131L,133L,137L,139L,140L,146L,153L,155L,160L,164L,182L,186L,188L,191L,193L,199L,200L,201L,203L,205L,210L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139750Inst : IEnumerable<long>
{
public static readonly long[] Value=A139750.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139750.Bytes);
public long this[int i]=>Value[i];

public static A139750Inst Instance=new A139750Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139749
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,12L,14L,16L,21L,23L,27L,29L,32L,34L,38L,41L,43L,47L,54L,56L,61L,65L,67L,74L,83L,87L,89L,92L,98L,101L,102L,104L,106L,110L,111L,113L,115L,119L,120L,122L,126L,128L,131L,133L,137L,139L,140L,142L,146L,153L,155L,160L,164L,166L,173L,179L,182L,186L,188L,191L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139749Inst : IEnumerable<long>
{
public static readonly long[] Value=A139749.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139749.Bytes);
public long this[int i]=>Value[i];

public static A139749Inst Instance=new A139749Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139748
{
public static readonly long[] Value={ 0L,0L,0L,1L,4L,10L,20L,35L,57L,93L,165L,330L,715L,1574L,3381L,6995L,13990L,27370L,53143L,103702L,204820L,409640L,826045L,1669801L,3368259L,6765175L,13530350L,26985675L,53774932L,107232053L,214146295L,428292590L,857417220L,1717012749L,3437550076L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139748Inst : IEnumerable<long>
{
public static readonly long[] Value=A139748.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139748.Bytes);
public long this[int i]=>Value[i];

public static A139748Inst Instance=new A139748Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139747
{
public static readonly BigInteger[] Value={ 0L,2L,40L,602L,8080L,102002L,1240120L,14704202L,171312160L,1970527202L,22450640200L,253930611002L,2855998840240L,31980846315602L,356873041128280L,3971357037321002L,44096709674720320L,488769846799627202L,5409822678195232360L,BigInteger.Parse("59808238730741554202") };
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
public class A139747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139747Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A139747.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139747.Bytes);
public BigInteger this[int i]=>Value[i];

public static A139747Inst Instance=new A139747Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139746
{
public static readonly BigInteger[] Value={ 0L,3L,57L,819L,10545L,128283L,1509417L,17390019L,197581665L,2223729963L,24863682777L,276721736019L,3069708899985L,33972956330043L,375351787072137L,4142063797326819L,45668254886861505L,503195228685608523L,5541902914982749497L,BigInteger.Parse("61014975260338690419") };
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
public class A139746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139746Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A139746.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139746.Bytes);
public BigInteger this[int i]=>Value[i];

public static A139746Inst Instance=new A139746Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139745
{
public static readonly BigInteger[] Value={ 0L,4L,72L,988L,12240L,144244L,1653912L,18663628L,208594080L,2317594084L,25654949352L,283334343868L,3124587089520L,34425823133524L,379071610510392L,4172500607905708L,45916496933002560L,505214397985306564L,5558288899894321032L,BigInteger.Parse("61147691553229173148") };
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
public class A139745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139745Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A139745.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139745.Bytes);
public BigInteger this[int i]=>Value[i];

public static A139745Inst Instance=new A139745Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139744
{
public static readonly BigInteger[] Value={ 0L,5L,85L,1115L,13345L,153275L,1724905L,19207235L,212679265L,2347869995L,25876958425L,284948873555L,3136251594385L,34509651449915L,379671469419145L,4176777984431075L,45946908753664705L,505430101839849035L,5559815753535563065L,BigInteger.Parse("61158481088674535795") };
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
public class A139744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139744Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A139744.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139744.Bytes);
public BigInteger this[int i]=>Value[i];

public static A139744Inst Instance=new A139744Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139743
{
public static readonly BigInteger[] Value={ 0L,6L,96L,1206L,14016L,157926L,1755936L,19409046L,213968256L,2355994566L,25927658976L,285262842486L,3138184236096L,34521491440806L,379743730067616L,4177217651837526L,45949577275681536L,505446265559840646L,5559913498794965856L,BigInteger.Parse("61159071374928218166") };
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
public class A139743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139743Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A139743.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139743.Bytes);
public BigInteger this[int i]=>Value[i];

public static A139743Inst Instance=new A139743Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139742
{
public static readonly BigInteger[] Value={ 0L,7L,105L,1267L,14385L,160027L,1767465L,19470787L,214293345L,2357685547L,25936376025L,285307476307L,3138411599505L,34522645035067L,379749565147785L,4177247095673827L,45949725568604865L,505447011319424587L,5559917244772754745L,BigInteger.Parse("61159090173536639347") };
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
public class A139742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139742Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A139742.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139742.Bytes);
public BigInteger this[int i]=>Value[i];

public static A139742Inst Instance=new A139742Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139741
{
public static readonly BigInteger[] Value={ 0L,8L,112L,1304L,14560L,160808L,1770832L,19484984L,214352320L,2357928008L,25937365552L,285311493464L,3138427845280L,34522710549608L,379749828800272L,4177248155066744L,45949729820525440L,505447028370153608L,5559917313104810992L,BigInteger.Parse("61159090447252284824") };
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
public class A139741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139741Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A139741.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139741.Bytes);
public BigInteger this[int i]=>Value[i];

public static A139741Inst Instance=new A139741Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139740
{
public static readonly BigInteger[] Value={ 0L,9L,117L,1323L,14625L,161019L,1771497L,19487043L,214358625L,2357947179L,25937423577L,285311668563L,3138428372625L,34522712135739L,379749833566857L,4177248169382883L,45949729863506625L,505447028499162699L,5559917313491969337L,BigInteger.Parse("61159090448414022003") };
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
public class A139740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139740Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A139740.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139740.Bytes);
public BigInteger this[int i]=>Value[i];

public static A139740Inst Instance=new A139740Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139739
{
public static readonly long[] Value={ 0L,1L,19L,271L,3439L,40951L,468559L,434062L,13906558L,225159022L,3026431198L,5856821173L,152711390557L,2374402515013L,8492830180156L,176435471621404L,734899055740795L,16614091501667155L,99432188218005274L,544037976289055377L,2738676327544569592L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139739Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139739.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139739Inst : IEnumerable<long>
{
public static readonly long[] Value=A139739.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139739.Bytes);
public long this[int i]=>Value[i];

public static A139739Inst Instance=new A139739Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139738
{
public static readonly long[] Value={ 0L,2L,36L,488L,1808L,1696L,213568L,1611392L,16113920L,60475904L,336323584L,5510719488L,37927325696L,104395350016L,3242976755712L,14837581512704L,148375815127040L,920808197849088L,9208081978490880L,56052022765944832L,848750603811160064L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139738Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139738.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139738Inst : IEnumerable<long>
{
public static readonly long[] Value=A139738.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139738.Bytes);
public long this[int i]=>Value[i];

public static A139738Inst Instance=new A139738Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139737
{
public static readonly long[] Value={ 0L,3L,2L,314L,396L,15965L,58808L,117484L,1998383L,31513432L,113366285L,1133662850L,3427321528L,20431928079L,301208291197L,3012082911970L,30120829119700L,201509499488197L,154050882984314L,3168922427753589L,20290329092162747L,202903290921627470L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139737Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139737.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139737Inst : IEnumerable<long>
{
public static readonly long[] Value=A139737.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139737.Bytes);
public long this[int i]=>Value[i];

public static A139737Inst Instance=new A139737Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139736
{
public static readonly long[] Value={ 0L,4L,28L,136L,928L,6688L,20224L,202240L,902656L,2308096L,23080960L,230809600L,856907776L,8569077760L,7326613504L,386722791424L,1986487975936L,14222659944448L,40666642776064L,406666427760640L,410505837543424L,4105058375434240L,41050583754342400L,410505837543424000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139736Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139736.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139736Inst : IEnumerable<long>
{
public static readonly long[] Value=A139736.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139736.Bytes);
public long this[int i]=>Value[i];

public static A139736Inst Instance=new A139736Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139655
{
public static readonly long[] Value={ 281L,401L,449L,569L,641L,809L,1009L,1129L,1201L,1289L,1409L,1481L,1801L,2081L,2129L,2521L,2689L,2801L,2969L,3049L,3089L,3329L,3361L,3529L,3761L,3889L,3929L,4001L,4201L,4481L,4561L,4649L,4729L,5009L,5209L,5441L,5569L,5849L,5881L,6329L,6449L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139655Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139655.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139655Inst : IEnumerable<long>
{
public static readonly long[] Value=A139655.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139655.Bytes);
public long this[int i]=>Value[i];

public static A139655Inst Instance=new A139655Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139654
{
public static readonly long[] Value={ 277L,337L,373L,673L,757L,1093L,1117L,1213L,1297L,1381L,1429L,1453L,1621L,1873L,1933L,2053L,2389L,2473L,2521L,2557L,2713L,2857L,3301L,3613L,3637L,4057L,4657L,4729L,4813L,4957L,4993L,5209L,5581L,5737L,5749L,5821L,6133L,6217L,6301L,6421L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139654Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139654.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139654Inst : IEnumerable<long>
{
public static readonly long[] Value=A139654.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139654.Bytes);
public long this[int i]=>Value[i];

public static A139654Inst Instance=new A139654Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139653
{
public static readonly long[] Value={ 257L,269L,317L,353L,397L,449L,509L,577L,653L,829L,929L,1013L,1021L,1061L,1093L,1153L,1181L,1237L,1277L,1301L,1373L,1409L,1453L,1549L,1637L,1697L,1741L,1973L,2017L,2237L,2281L,2293L,2341L,2377L,2381L,2473L,2557L,2677L,2693L,2753L,2861L,2953L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139653Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139653.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139653Inst : IEnumerable<long>
{
public static readonly long[] Value=A139653.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139653.Bytes);
public long this[int i]=>Value[i];

public static A139653Inst Instance=new A139653Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139652
{
public static readonly long[] Value={ 233L,241L,257L,281L,313L,353L,401L,457L,521L,593L,673L,761L,857L,929L,937L,953L,977L,1009L,1049L,1097L,1153L,1193L,1217L,1289L,1321L,1553L,1601L,1657L,1753L,1889L,1913L,2017L,2081L,2089L,2113L,2137L,2153L,2297L,2377L,2441L,2609L,2617L,2633L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139652Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139652.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139652Inst : IEnumerable<long>
{
public static readonly long[] Value=A139652.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139652.Bytes);
public long this[int i]=>Value[i];

public static A139652Inst Instance=new A139652Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139651
{
public static readonly long[] Value={ 211L,331L,379L,499L,571L,739L,1009L,1051L,1129L,1171L,1201L,1579L,1801L,2011L,2179L,2251L,2521L,2689L,2731L,2851L,3019L,3049L,3259L,3361L,3529L,3571L,3691L,3739L,3889L,3931L,4099L,4201L,4561L,4729L,5209L,5419L,5569L,5779L,5881L,6091L,6211L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139651Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139651.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139651Inst : IEnumerable<long>
{
public static readonly long[] Value=A139651.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139651.Bytes);
public long this[int i]=>Value[i];

public static A139651Inst Instance=new A139651Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139650
{
public static readonly long[] Value={ 191L,199L,239L,271L,311L,359L,479L,631L,719L,761L,769L,809L,881L,919L,929L,1031L,1049L,1151L,1201L,1279L,1289L,1489L,1559L,1601L,1721L,1759L,1831L,1871L,1879L,1999L,2039L,2129L,2239L,2281L,2399L,2441L,2551L,2591L,2609L,2671L,2791L,2969L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139650Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139650.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139650Inst : IEnumerable<long>
{
public static readonly long[] Value=A139650.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139650.Bytes);
public long this[int i]=>Value[i];

public static A139650Inst Instance=new A139650Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A139649
{
public static readonly long[] Value={ 181L,193L,241L,277L,373L,433L,577L,661L,709L,733L,757L,829L,853L,877L,997L,1069L,1201L,1237L,1549L,1597L,1609L,1621L,1657L,1669L,1693L,1777L,1789L,1933L,1993L,2113L,2269L,2293L,2377L,2389L,2557L,2617L,2677L,2749L,2833L,2857L,2917L,2953L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A139649Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A139649.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A139649Inst : IEnumerable<long>
{
public static readonly long[] Value=A139649.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A139649.Bytes);
public long this[int i]=>Value[i];

public static A139649Inst Instance=new A139649Inst();

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