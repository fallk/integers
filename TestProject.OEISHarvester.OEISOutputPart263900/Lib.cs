using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A021712
{
public static readonly long[] Value={ 0L,0L,1L,4L,1L,2L,4L,2L,9L,3L,7L,8L,5L,3L,1L,0L,7L,3L,4L,4L,6L,3L,2L,7L,6L,8L,3L,6L,1L,5L,8L,1L,9L,2L,0L,9L,0L,3L,9L,5L,4L,8L,0L,2L,2L,5L,9L,8L,8L,7L,0L,0L,5L,6L,4L,9L,7L,1L,7L,5L,1L,4L,1L,2L,4L,2L,9L,3L,7L,8L,5L,3L,1L,0L,7L,3L,4L,4L,6L,3L,2L,7L,6L,8L,3L,6L,1L,5L,8L,1L,9L,2L,0L,9L,0L,3L,9L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021712Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021712.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021712Inst : IEnumerable<long>
{
public static readonly long[] Value=A021712.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021712.Bytes);
public long this[int i]=>Value[i];

public static A021712Inst Instance=new A021712Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021713
{
public static readonly long[] Value={ 0L,0L,1L,4L,1L,0L,4L,3L,7L,2L,3L,5L,5L,4L,3L,0L,1L,8L,3L,3L,5L,6L,8L,4L,0L,6L,2L,0L,5L,9L,2L,3L,8L,3L,6L,3L,8L,9L,2L,8L,0L,6L,7L,7L,0L,0L,9L,8L,7L,3L,0L,6L,0L,6L,4L,8L,8L,0L,1L,1L,2L,8L,3L,4L,9L,7L,8L,8L,4L,3L,4L,4L,1L,4L,6L,6L,8L,5L,4L,7L,2L,4L,9L,6L,4L,7L,3L,9L,0L,6L,9L,1L,1L,1L,4L,2L,4L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021713Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021713.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021713Inst : IEnumerable<long>
{
public static readonly long[] Value=A021713.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021713.Bytes);
public long this[int i]=>Value[i];

public static A021713Inst Instance=new A021713Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021714
{
public static readonly long[] Value={ 1L,25L,428L,6278L,84879L,1092243L,13601506L,165488176L,1979095877L,23357343581L,272803757304L,3159571375194L,36342586372795L,415641464948839L,4730786270092622L,53625950549096132L,605758471885400433L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021714Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021714.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021714Inst : IEnumerable<long>
{
public static readonly long[] Value=A021714.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021714.Bytes);
public long this[int i]=>Value[i];

public static A021714Inst Instance=new A021714Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021715
{
public static readonly long[] Value={ 0L,0L,1L,4L,0L,6L,4L,6L,9L,7L,6L,0L,9L,0L,0L,1L,4L,0L,6L,4L,6L,9L,7L,6L,0L,9L,0L,0L,1L,4L,0L,6L,4L,6L,9L,7L,6L,0L,9L,0L,0L,1L,4L,0L,6L,4L,6L,9L,7L,6L,0L,9L,0L,0L,1L,4L,0L,6L,4L,6L,9L,7L,6L,0L,9L,0L,0L,1L,4L,0L,6L,4L,6L,9L,7L,6L,0L,9L,0L,0L,1L,4L,0L,6L,4L,6L,9L,7L,6L,0L,9L,0L,0L,1L,4L,0L,6L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021715Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021715.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021715Inst : IEnumerable<long>
{
public static readonly long[] Value=A021715.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021715.Bytes);
public long this[int i]=>Value[i];

public static A021715Inst Instance=new A021715Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021716
{
public static readonly long[] Value={ 0L,0L,1L,4L,0L,4L,4L,9L,4L,3L,8L,2L,0L,2L,2L,4L,7L,1L,9L,1L,0L,1L,1L,2L,3L,5L,9L,5L,5L,0L,5L,6L,1L,7L,9L,7L,7L,5L,2L,8L,0L,8L,9L,8L,8L,7L,6L,4L,0L,4L,4L,9L,4L,3L,8L,2L,0L,2L,2L,4L,7L,1L,9L,1L,0L,1L,1L,2L,3L,5L,9L,5L,5L,0L,5L,6L,1L,7L,9L,7L,7L,5L,2L,8L,0L,8L,9L,8L,8L,7L,6L,4L,0L,4L,4L,9L,4L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021716Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021716.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021716Inst : IEnumerable<long>
{
public static readonly long[] Value=A021716.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021716.Bytes);
public long this[int i]=>Value[i];

public static A021716Inst Instance=new A021716Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021717
{
public static readonly long[] Value={ 0L,0L,1L,4L,0L,2L,5L,2L,4L,5L,4L,4L,1L,7L,9L,5L,2L,3L,1L,4L,1L,6L,5L,4L,9L,7L,8L,9L,6L,2L,1L,3L,1L,8L,3L,7L,3L,0L,7L,1L,5L,2L,8L,7L,5L,1L,7L,5L,3L,1L,5L,5L,6L,8L,0L,2L,2L,4L,4L,0L,3L,9L,2L,7L,0L,6L,8L,7L,2L,3L,7L,0L,2L,6L,6L,4L,7L,9L,6L,6L,3L,3L,9L,4L,1L,0L,9L,3L,9L,6L,9L,1L,4L,4L,4L,6L,0L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021717Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021717.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021717Inst : IEnumerable<long>
{
public static readonly long[] Value=A021717.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021717.Bytes);
public long this[int i]=>Value[i];

public static A021717Inst Instance=new A021717Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021718
{
public static readonly long[] Value={ 0L,0L,1L,4L,0L,0L,5L,6L,0L,2L,2L,4L,0L,8L,9L,6L,3L,5L,8L,5L,4L,3L,4L,1L,7L,3L,6L,6L,9L,4L,6L,7L,7L,8L,7L,1L,1L,4L,8L,4L,5L,9L,3L,8L,3L,7L,5L,3L,5L,0L,1L,4L,0L,0L,5L,6L,0L,2L,2L,4L,0L,8L,9L,6L,3L,5L,8L,5L,4L,3L,4L,1L,7L,3L,6L,6L,9L,4L,6L,7L,7L,8L,7L,1L,1L,4L,8L,4L,5L,9L,3L,8L,3L,7L,5L,3L,5L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021718Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021718.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021718Inst : IEnumerable<long>
{
public static readonly long[] Value=A021718.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021718.Bytes);
public long this[int i]=>Value[i];

public static A021718Inst Instance=new A021718Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021719
{
public static readonly long[] Value={ 0L,0L,1L,3L,9L,8L,6L,0L,1L,3L,9L,8L,6L,0L,1L,3L,9L,8L,6L,0L,1L,3L,9L,8L,6L,0L,1L,3L,9L,8L,6L,0L,1L,3L,9L,8L,6L,0L,1L,3L,9L,8L,6L,0L,1L,3L,9L,8L,6L,0L,1L,3L,9L,8L,6L,0L,1L,3L,9L,8L,6L,0L,1L,3L,9L,8L,6L,0L,1L,3L,9L,8L,6L,0L,1L,3L,9L,8L,6L,0L,1L,3L,9L,8L,6L,0L,1L,3L,9L,8L,6L,0L,1L,3L,9L,8L,6L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021719Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021719.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021719Inst : IEnumerable<long>
{
public static readonly long[] Value=A021719.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021719.Bytes);
public long this[int i]=>Value[i];

public static A021719Inst Instance=new A021719Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021720
{
public static readonly long[] Value={ 0L,0L,1L,3L,9L,6L,6L,4L,8L,0L,4L,4L,6L,9L,2L,7L,3L,7L,4L,3L,0L,1L,6L,7L,5L,9L,7L,7L,6L,5L,3L,6L,3L,1L,2L,8L,4L,9L,1L,6L,2L,0L,1L,1L,1L,7L,3L,1L,8L,4L,3L,5L,7L,5L,4L,1L,8L,9L,9L,4L,4L,1L,3L,4L,0L,7L,8L,2L,1L,2L,2L,9L,0L,5L,0L,2L,7L,9L,3L,2L,9L,6L,0L,8L,9L,3L,8L,5L,4L,7L,4L,8L,6L,0L,3L,3L,5L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021720Inst : IEnumerable<long>
{
public static readonly long[] Value=A021720.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021720.Bytes);
public long this[int i]=>Value[i];

public static A021720Inst Instance=new A021720Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021721
{
public static readonly long[] Value={ 0L,0L,1L,3L,9L,4L,7L,0L,0L,1L,3L,9L,4L,7L,0L,0L,1L,3L,9L,4L,7L,0L,0L,1L,3L,9L,4L,7L,0L,0L,1L,3L,9L,4L,7L,0L,0L,1L,3L,9L,4L,7L,0L,0L,1L,3L,9L,4L,7L,0L,0L,1L,3L,9L,4L,7L,0L,0L,1L,3L,9L,4L,7L,0L,0L,1L,3L,9L,4L,7L,0L,0L,1L,3L,9L,4L,7L,0L,0L,1L,3L,9L,4L,7L,0L,0L,1L,3L,9L,4L,7L,0L,0L,1L,3L,9L,4L,7L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021721Inst : IEnumerable<long>
{
public static readonly long[] Value=A021721.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021721.Bytes);
public long this[int i]=>Value[i];

public static A021721Inst Instance=new A021721Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021722
{
public static readonly long[] Value={ 0L,0L,1L,3L,9L,2L,7L,5L,7L,6L,6L,0L,1L,6L,7L,1L,3L,0L,9L,1L,9L,2L,2L,0L,0L,5L,5L,7L,1L,0L,3L,0L,6L,4L,0L,6L,6L,8L,5L,2L,3L,6L,7L,6L,8L,8L,0L,2L,2L,2L,8L,4L,1L,2L,2L,5L,6L,2L,6L,7L,4L,0L,9L,4L,7L,0L,7L,5L,2L,0L,8L,9L,1L,3L,6L,4L,9L,0L,2L,5L,0L,6L,9L,6L,3L,7L,8L,8L,3L,0L,0L,8L,3L,5L,6L,5L,4L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021722Inst : IEnumerable<long>
{
public static readonly long[] Value=A021722.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021722.Bytes);
public long this[int i]=>Value[i];

public static A021722Inst Instance=new A021722Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021723
{
public static readonly long[] Value={ 0L,0L,1L,3L,9L,0L,8L,2L,0L,5L,8L,4L,1L,4L,4L,6L,4L,5L,3L,4L,0L,7L,5L,1L,0L,4L,3L,1L,1L,5L,4L,3L,8L,1L,0L,8L,4L,8L,4L,0L,0L,5L,5L,6L,3L,2L,8L,2L,3L,3L,6L,5L,7L,8L,5L,8L,1L,3L,6L,3L,0L,0L,4L,1L,7L,2L,4L,6L,1L,7L,5L,2L,4L,3L,3L,9L,3L,6L,0L,2L,2L,2L,5L,3L,1L,2L,9L,3L,4L,6L,3L,1L,4L,3L,2L,5L,4L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021723Inst : IEnumerable<long>
{
public static readonly long[] Value=A021723.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021723.Bytes);
public long this[int i]=>Value[i];

public static A021723Inst Instance=new A021723Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021724
{
public static readonly long[] Value={ 1L,26L,465L,7150L,101621L,1378026L,18123145L,233349350L,2958918141L,37094306626L,461004657425L,5690785933950L,69876732453061L,854393804284826L,10411455807073305L,126524771262956950L,1534170271000826381L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021724Inst : IEnumerable<long>
{
public static readonly long[] Value=A021724.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021724.Bytes);
public long this[int i]=>Value[i];

public static A021724Inst Instance=new A021724Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021725
{
public static readonly long[] Value={ 0L,0L,1L,3L,8L,6L,9L,6L,2L,5L,5L,2L,0L,1L,1L,0L,9L,5L,7L,0L,0L,4L,1L,6L,0L,8L,8L,7L,6L,5L,6L,0L,3L,3L,2L,8L,7L,1L,0L,1L,2L,4L,8L,2L,6L,6L,2L,9L,6L,8L,0L,9L,9L,8L,6L,1L,3L,0L,3L,7L,4L,4L,7L,9L,8L,8L,9L,0L,4L,2L,9L,9L,5L,8L,3L,9L,1L,1L,2L,3L,4L,3L,9L,6L,6L,7L,1L,2L,8L,9L,8L,7L,5L,1L,7L,3L,3L,7L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021725Inst : IEnumerable<long>
{
public static readonly long[] Value=A021725.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021725.Bytes);
public long this[int i]=>Value[i];

public static A021725Inst Instance=new A021725Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021726
{
public static readonly long[] Value={ 0L,0L,1L,3L,8L,5L,0L,4L,1L,5L,5L,1L,2L,4L,6L,5L,3L,7L,3L,9L,6L,1L,2L,1L,8L,8L,3L,6L,5L,6L,5L,0L,9L,6L,9L,5L,2L,9L,0L,8L,5L,8L,7L,2L,5L,7L,6L,1L,7L,7L,2L,8L,5L,3L,1L,8L,5L,5L,9L,5L,5L,6L,7L,8L,6L,7L,0L,3L,6L,0L,1L,1L,0L,8L,0L,3L,3L,2L,4L,0L,9L,9L,7L,2L,2L,9L,9L,1L,6L,8L,9L,7L,5L,0L,6L,9L,2L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021726Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021726.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021726Inst : IEnumerable<long>
{
public static readonly long[] Value=A021726.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021726.Bytes);
public long this[int i]=>Value[i];

public static A021726Inst Instance=new A021726Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021727
{
public static readonly long[] Value={ 0L,0L,1L,3L,8L,3L,1L,2L,5L,8L,6L,4L,4L,5L,3L,6L,6L,5L,2L,8L,3L,5L,4L,0L,8L,0L,2L,2L,1L,3L,0L,0L,1L,3L,8L,3L,1L,2L,5L,8L,6L,4L,4L,5L,3L,6L,6L,5L,2L,8L,3L,5L,4L,0L,8L,0L,2L,2L,1L,3L,0L,0L,1L,3L,8L,3L,1L,2L,5L,8L,6L,4L,4L,5L,3L,6L,6L,5L,2L,8L,3L,5L,4L,0L,8L,0L,2L,2L,1L,3L,0L,0L,1L,3L,8L,3L,1L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021727Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021727.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021727Inst : IEnumerable<long>
{
public static readonly long[] Value=A021727.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021727.Bytes);
public long this[int i]=>Value[i];

public static A021727Inst Instance=new A021727Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021728
{
public static readonly long[] Value={ 0L,0L,1L,3L,8L,1L,2L,1L,5L,4L,6L,9L,6L,1L,3L,2L,5L,9L,6L,6L,8L,5L,0L,8L,2L,8L,7L,2L,9L,2L,8L,1L,7L,6L,7L,9L,5L,5L,8L,0L,1L,1L,0L,4L,9L,7L,2L,3L,7L,5L,6L,9L,0L,6L,0L,7L,7L,3L,4L,8L,0L,6L,6L,2L,9L,8L,3L,4L,2L,5L,4L,1L,4L,3L,6L,4L,6L,4L,0L,8L,8L,3L,9L,7L,7L,9L,0L,0L,5L,5L,2L,4L,8L,6L,1L,8L,7L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021728Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021728.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021728Inst : IEnumerable<long>
{
public static readonly long[] Value=A021728.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021728.Bytes);
public long this[int i]=>Value[i];

public static A021728Inst Instance=new A021728Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021729
{
public static readonly long[] Value={ 0L,0L,1L,3L,7L,9L,3L,1L,0L,3L,4L,4L,8L,2L,7L,5L,8L,6L,2L,0L,6L,8L,9L,6L,5L,5L,1L,7L,2L,4L,1L,3L,7L,9L,3L,1L,0L,3L,4L,4L,8L,2L,7L,5L,8L,6L,2L,0L,6L,8L,9L,6L,5L,5L,1L,7L,2L,4L,1L,3L,7L,9L,3L,1L,0L,3L,4L,4L,8L,2L,7L,5L,8L,6L,2L,0L,6L,8L,9L,6L,5L,5L,1L,7L,2L,4L,1L,3L,7L,9L,3L,1L,0L,3L,4L,4L,8L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021729Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021729.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021729Inst : IEnumerable<long>
{
public static readonly long[] Value=A021729.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021729.Bytes);
public long this[int i]=>Value[i];

public static A021729Inst Instance=new A021729Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021730
{
public static readonly long[] Value={ 0L,0L,1L,3L,7L,7L,4L,1L,0L,4L,6L,8L,3L,1L,9L,5L,5L,9L,2L,2L,8L,6L,5L,0L,1L,3L,7L,7L,4L,1L,0L,4L,6L,8L,3L,1L,9L,5L,5L,9L,2L,2L,8L,6L,5L,0L,1L,3L,7L,7L,4L,1L,0L,4L,6L,8L,3L,1L,9L,5L,5L,9L,2L,2L,8L,6L,5L,0L,1L,3L,7L,7L,4L,1L,0L,4L,6L,8L,3L,1L,9L,5L,5L,9L,2L,2L,8L,6L,5L,0L,1L,3L,7L,7L,4L,1L,0L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021730Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021730.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021730Inst : IEnumerable<long>
{
public static readonly long[] Value=A021730.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021730.Bytes);
public long this[int i]=>Value[i];

public static A021730Inst Instance=new A021730Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021731
{
public static readonly long[] Value={ 0L,0L,1L,3L,7L,5L,5L,1L,5L,8L,1L,8L,4L,3L,1L,9L,1L,1L,9L,6L,6L,9L,8L,7L,6L,2L,0L,3L,5L,7L,6L,3L,4L,1L,1L,2L,7L,9L,2L,2L,9L,7L,1L,1L,1L,4L,1L,6L,7L,8L,1L,2L,9L,2L,9L,8L,4L,8L,6L,9L,3L,2L,5L,9L,9L,7L,2L,4L,8L,9L,6L,8L,3L,6L,3L,1L,3L,6L,1L,7L,6L,0L,6L,6L,0L,2L,4L,7L,5L,9L,2L,8L,4L,7L,3L,1L,7L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021731Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021731.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021731Inst : IEnumerable<long>
{
public static readonly long[] Value=A021731.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021731.Bytes);
public long this[int i]=>Value[i];

public static A021731Inst Instance=new A021731Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021732
{
public static readonly long[] Value={ 0L,0L,1L,3L,7L,3L,6L,2L,6L,3L,7L,3L,6L,2L,6L,3L,7L,3L,6L,2L,6L,3L,7L,3L,6L,2L,6L,3L,7L,3L,6L,2L,6L,3L,7L,3L,6L,2L,6L,3L,7L,3L,6L,2L,6L,3L,7L,3L,6L,2L,6L,3L,7L,3L,6L,2L,6L,3L,7L,3L,6L,2L,6L,3L,7L,3L,6L,2L,6L,3L,7L,3L,6L,2L,6L,3L,7L,3L,6L,2L,6L,3L,7L,3L,6L,2L,6L,3L,7L,3L,6L,2L,6L,3L,7L,3L,6L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021732Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021732.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021732Inst : IEnumerable<long>
{
public static readonly long[] Value=A021732.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021732.Bytes);
public long this[int i]=>Value[i];

public static A021732Inst Instance=new A021732Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021733
{
public static readonly long[] Value={ 0L,0L,1L,3L,7L,1L,7L,4L,2L,1L,1L,2L,4L,8L,2L,8L,5L,3L,2L,2L,3L,5L,9L,3L,9L,6L,4L,3L,3L,4L,7L,0L,5L,0L,7L,5L,4L,4L,5L,8L,1L,6L,1L,8L,6L,5L,5L,6L,9L,2L,7L,2L,9L,7L,6L,6L,8L,0L,3L,8L,4L,0L,8L,7L,7L,9L,1L,4L,9L,5L,1L,9L,8L,9L,0L,2L,6L,0L,6L,3L,1L,0L,0L,1L,3L,7L,1L,7L,4L,2L,1L,1L,2L,4L,8L,2L,8L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021733Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021733.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021733Inst : IEnumerable<long>
{
public static readonly long[] Value=A021733.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021733.Bytes);
public long this[int i]=>Value[i];

public static A021733Inst Instance=new A021733Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021734
{
public static readonly long[] Value={ 1L,27L,502L,8022L,118363L,1663809L,22644784L,301210524L,3938740405L,50831269671L,649205557546L,8222000492706L,103410878533327L,1293146143620813L,16092125344053988L,199423591976817768L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021734Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021734.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021734Inst : IEnumerable<long>
{
public static readonly long[] Value=A021734.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021734.Bytes);
public long this[int i]=>Value[i];

public static A021734Inst Instance=new A021734Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021735
{
public static readonly long[] Value={ 0L,0L,1L,3L,6L,7L,9L,8L,9L,0L,5L,6L,0L,8L,7L,5L,5L,1L,2L,9L,9L,5L,8L,9L,6L,0L,3L,2L,8L,3L,1L,7L,3L,7L,3L,4L,6L,1L,0L,1L,2L,3L,1L,1L,9L,0L,1L,5L,0L,4L,7L,8L,7L,9L,6L,1L,6L,9L,6L,3L,0L,6L,4L,2L,9L,5L,4L,8L,5L,6L,3L,6L,1L,1L,4L,9L,1L,1L,0L,8L,0L,7L,1L,1L,3L,5L,4L,3L,0L,9L,1L,6L,5L,5L,2L,6L,6L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021735Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021735.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021735Inst : IEnumerable<long>
{
public static readonly long[] Value=A021735.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021735.Bytes);
public long this[int i]=>Value[i];

public static A021735Inst Instance=new A021735Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021736
{
public static readonly long[] Value={ 0L,0L,1L,3L,6L,6L,1L,2L,0L,2L,1L,8L,5L,7L,9L,2L,3L,4L,9L,7L,2L,6L,7L,7L,5L,9L,5L,6L,2L,8L,4L,1L,5L,3L,0L,0L,5L,4L,6L,4L,4L,8L,0L,8L,7L,4L,3L,1L,6L,9L,3L,9L,8L,9L,0L,7L,1L,0L,3L,8L,2L,5L,1L,3L,6L,6L,1L,2L,0L,2L,1L,8L,5L,7L,9L,2L,3L,4L,9L,7L,2L,6L,7L,7L,5L,9L,5L,6L,2L,8L,4L,1L,5L,3L,0L,0L,5L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021736Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021736.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021736Inst : IEnumerable<long>
{
public static readonly long[] Value=A021736.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021736.Bytes);
public long this[int i]=>Value[i];

public static A021736Inst Instance=new A021736Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021737
{
public static readonly long[] Value={ 0L,0L,1L,3L,6L,4L,2L,5L,6L,4L,8L,0L,2L,1L,8L,2L,8L,1L,0L,3L,6L,8L,3L,4L,9L,2L,4L,9L,6L,5L,8L,9L,3L,5L,8L,7L,9L,9L,4L,5L,4L,2L,9L,7L,4L,0L,7L,9L,1L,2L,6L,8L,7L,5L,8L,5L,2L,6L,6L,0L,3L,0L,0L,1L,3L,6L,4L,2L,5L,6L,4L,8L,0L,2L,1L,8L,2L,8L,1L,0L,3L,6L,8L,3L,4L,9L,2L,4L,9L,6L,5L,8L,9L,3L,5L,8L,7L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021737Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021737.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021737Inst : IEnumerable<long>
{
public static readonly long[] Value=A021737.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021737.Bytes);
public long this[int i]=>Value[i];

public static A021737Inst Instance=new A021737Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021738
{
public static readonly long[] Value={ 0L,0L,1L,3L,6L,2L,3L,9L,7L,8L,2L,0L,1L,6L,3L,4L,8L,7L,7L,3L,8L,4L,1L,9L,6L,1L,8L,5L,2L,8L,6L,1L,0L,3L,5L,4L,2L,2L,3L,4L,3L,3L,2L,4L,2L,5L,0L,6L,8L,1L,1L,9L,8L,9L,1L,0L,0L,8L,1L,7L,4L,3L,8L,6L,9L,2L,0L,9L,8L,0L,9L,2L,6L,4L,3L,0L,5L,1L,7L,7L,1L,1L,1L,7L,1L,6L,6L,2L,1L,2L,5L,3L,4L,0L,5L,9L,9L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021738Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021738.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021738Inst : IEnumerable<long>
{
public static readonly long[] Value=A021738.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021738.Bytes);
public long this[int i]=>Value[i];

public static A021738Inst Instance=new A021738Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021739
{
public static readonly long[] Value={ 0L,0L,1L,3L,6L,0L,5L,4L,4L,2L,1L,7L,6L,8L,7L,0L,7L,4L,8L,2L,9L,9L,3L,1L,9L,7L,2L,7L,8L,9L,1L,1L,5L,6L,4L,6L,2L,5L,8L,5L,0L,3L,4L,0L,1L,3L,6L,0L,5L,4L,4L,2L,1L,7L,6L,8L,7L,0L,7L,4L,8L,2L,9L,9L,3L,1L,9L,7L,2L,7L,8L,9L,1L,1L,5L,6L,4L,6L,2L,5L,8L,5L,0L,3L,4L,0L,1L,3L,6L,0L,5L,4L,4L,2L,1L,7L,6L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021739Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021739.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021739Inst : IEnumerable<long>
{
public static readonly long[] Value=A021739.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021739.Bytes);
public long this[int i]=>Value[i];

public static A021739Inst Instance=new A021739Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021740
{
public static readonly long[] Value={ 0L,0L,1L,3L,5L,8L,6L,9L,5L,6L,5L,2L,1L,7L,3L,9L,1L,3L,0L,4L,3L,4L,7L,8L,2L,6L,0L,8L,6L,9L,5L,6L,5L,2L,1L,7L,3L,9L,1L,3L,0L,4L,3L,4L,7L,8L,2L,6L,0L,8L,6L,9L,5L,6L,5L,2L,1L,7L,3L,9L,1L,3L,0L,4L,3L,4L,7L,8L,2L,6L,0L,8L,6L,9L,5L,6L,5L,2L,1L,7L,3L,9L,1L,3L,0L,4L,3L,4L,7L,8L,2L,6L,0L,8L,6L,9L,5L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021740Inst : IEnumerable<long>
{
public static readonly long[] Value=A021740.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021740.Bytes);
public long this[int i]=>Value[i];

public static A021740Inst Instance=new A021740Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021837
{
public static readonly long[] Value={ 0L,0L,1L,2L,0L,0L,4L,8L,0L,1L,9L,2L,0L,7L,6L,8L,3L,0L,7L,3L,2L,2L,9L,2L,9L,1L,7L,1L,6L,6L,8L,6L,6L,7L,4L,6L,6L,9L,8L,6L,7L,9L,4L,7L,1L,7L,8L,8L,7L,1L,5L,4L,8L,6L,1L,9L,4L,4L,7L,7L,7L,9L,1L,1L,1L,6L,4L,4L,6L,5L,7L,8L,6L,3L,1L,4L,5L,2L,5L,8L,1L,0L,3L,2L,4L,1L,2L,9L,6L,5L,1L,8L,6L,0L,7L,4L,4L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021837Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021837.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021837Inst : IEnumerable<long>
{
public static readonly long[] Value=A021837.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021837.Bytes);
public long this[int i]=>Value[i];

public static A021837Inst Instance=new A021837Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021838
{
public static readonly long[] Value={ 0L,0L,1L,1L,9L,9L,0L,4L,0L,7L,6L,7L,3L,8L,6L,0L,9L,1L,1L,2L,7L,0L,9L,8L,3L,2L,1L,3L,4L,2L,9L,2L,5L,6L,5L,9L,4L,7L,2L,4L,2L,2L,0L,6L,2L,3L,5L,0L,1L,1L,9L,9L,0L,4L,0L,7L,6L,7L,3L,8L,6L,0L,9L,1L,1L,2L,7L,0L,9L,8L,3L,2L,1L,3L,4L,2L,9L,2L,5L,6L,5L,9L,4L,7L,2L,4L,2L,2L,0L,6L,2L,3L,5L,0L,1L,1L,9L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021838Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021838.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021838Inst : IEnumerable<long>
{
public static readonly long[] Value=A021838.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021838.Bytes);
public long this[int i]=>Value[i];

public static A021838Inst Instance=new A021838Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021839
{
public static readonly long[] Value={ 0L,0L,1L,1L,9L,7L,6L,0L,4L,7L,9L,0L,4L,1L,9L,1L,6L,1L,6L,7L,6L,6L,4L,6L,7L,0L,6L,5L,8L,6L,8L,2L,6L,3L,4L,7L,3L,0L,5L,3L,8L,9L,2L,2L,1L,5L,5L,6L,8L,8L,6L,2L,2L,7L,5L,4L,4L,9L,1L,0L,1L,7L,9L,6L,4L,0L,7L,1L,8L,5L,6L,2L,8L,7L,4L,2L,5L,1L,4L,9L,7L,0L,0L,5L,9L,8L,8L,0L,2L,3L,9L,5L,2L,0L,9L,5L,8L,0L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021839Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021839.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021839Inst : IEnumerable<long>
{
public static readonly long[] Value=A021839.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021839.Bytes);
public long this[int i]=>Value[i];

public static A021839Inst Instance=new A021839Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021840
{
public static readonly long[] Value={ 0L,0L,1L,1L,9L,6L,1L,7L,2L,2L,4L,8L,8L,0L,3L,8L,2L,7L,7L,5L,1L,1L,9L,6L,1L,7L,2L,2L,4L,8L,8L,0L,3L,8L,2L,7L,7L,5L,1L,1L,9L,6L,1L,7L,2L,2L,4L,8L,8L,0L,3L,8L,2L,7L,7L,5L,1L,1L,9L,6L,1L,7L,2L,2L,4L,8L,8L,0L,3L,8L,2L,7L,7L,5L,1L,1L,9L,6L,1L,7L,2L,2L,4L,8L,8L,0L,3L,8L,2L,7L,7L,5L,1L,1L,9L,6L,1L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021840Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021840.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021840Inst : IEnumerable<long>
{
public static readonly long[] Value=A021840.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021840.Bytes);
public long this[int i]=>Value[i];

public static A021840Inst Instance=new A021840Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021841
{
public static readonly long[] Value={ 0L,0L,1L,1L,9L,4L,7L,4L,3L,1L,3L,0L,2L,2L,7L,0L,0L,1L,1L,9L,4L,7L,4L,3L,1L,3L,0L,2L,2L,7L,0L,0L,1L,1L,9L,4L,7L,4L,3L,1L,3L,0L,2L,2L,7L,0L,0L,1L,1L,9L,4L,7L,4L,3L,1L,3L,0L,2L,2L,7L,0L,0L,1L,1L,9L,4L,7L,4L,3L,1L,3L,0L,2L,2L,7L,0L,0L,1L,1L,9L,4L,7L,4L,3L,1L,3L,0L,2L,2L,7L,0L,0L,1L,1L,9L,4L,7L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021841Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021841.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021841Inst : IEnumerable<long>
{
public static readonly long[] Value=A021841.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021841.Bytes);
public long this[int i]=>Value[i];

public static A021841Inst Instance=new A021841Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021842
{
public static readonly long[] Value={ 0L,0L,1L,1L,9L,3L,3L,1L,7L,4L,2L,2L,4L,3L,4L,3L,6L,7L,5L,4L,1L,7L,6L,6L,1L,0L,9L,7L,8L,5L,2L,0L,2L,8L,6L,3L,9L,6L,1L,8L,1L,3L,8L,4L,2L,4L,8L,2L,1L,0L,0L,2L,3L,8L,6L,6L,3L,4L,8L,4L,4L,8L,6L,8L,7L,3L,5L,0L,8L,3L,5L,3L,2L,2L,1L,9L,5L,7L,0L,4L,0L,5L,7L,2L,7L,9L,2L,3L,6L,2L,7L,6L,8L,4L,9L,6L,4L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021842Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021842.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021842Inst : IEnumerable<long>
{
public static readonly long[] Value=A021842.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021842.Bytes);
public long this[int i]=>Value[i];

public static A021842Inst Instance=new A021842Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021843
{
public static readonly long[] Value={ 0L,0L,1L,1L,9L,1L,8L,9L,5L,1L,1L,3L,2L,3L,0L,0L,3L,5L,7L,5L,6L,8L,5L,3L,3L,9L,6L,9L,0L,1L,0L,7L,2L,7L,0L,5L,6L,0L,1L,9L,0L,7L,0L,3L,2L,1L,8L,1L,1L,6L,8L,0L,5L,7L,2L,1L,0L,9L,6L,5L,4L,3L,5L,0L,4L,1L,7L,1L,6L,3L,2L,8L,9L,6L,3L,0L,5L,1L,2L,5L,1L,4L,8L,9L,8L,6L,8L,8L,9L,1L,5L,3L,7L,5L,4L,4L,6L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021843Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021843.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021843Inst : IEnumerable<long>
{
public static readonly long[] Value=A021843.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021843.Bytes);
public long this[int i]=>Value[i];

public static A021843Inst Instance=new A021843Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021844
{
public static readonly long[] Value={ 1L,23L,363L,4963L,63539L,787731L,9609811L,116281811L,1401253587L,16850623699L,202422366419L,2430363281619L,29172151056595L,350112652220627L,4201633221810387L,50421288464357587L,605065606114711763L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021844Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021844.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021844Inst : IEnumerable<long>
{
public static readonly long[] Value=A021844.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021844.Bytes);
public long this[int i]=>Value[i];

public static A021844Inst Instance=new A021844Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021845
{
public static readonly long[] Value={ 0L,0L,1L,1L,8L,9L,0L,6L,0L,6L,4L,2L,0L,9L,2L,7L,4L,6L,7L,3L,0L,0L,8L,3L,2L,3L,4L,2L,4L,4L,9L,4L,6L,4L,9L,2L,2L,7L,1L,1L,0L,5L,8L,2L,6L,3L,9L,7L,1L,4L,6L,2L,5L,4L,4L,5L,8L,9L,7L,7L,4L,0L,7L,8L,4L,7L,8L,0L,0L,2L,3L,7L,8L,1L,2L,1L,2L,8L,4L,1L,8L,5L,4L,9L,3L,4L,6L,0L,1L,6L,6L,4L,6L,8L,4L,8L,9L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021845Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021845.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021845Inst : IEnumerable<long>
{
public static readonly long[] Value=A021845.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021845.Bytes);
public long this[int i]=>Value[i];

public static A021845Inst Instance=new A021845Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021846
{
public static readonly long[] Value={ 0L,0L,1L,1L,8L,7L,6L,4L,8L,4L,5L,6L,0L,5L,7L,0L,0L,7L,1L,2L,5L,8L,9L,0L,7L,3L,6L,3L,4L,2L,0L,4L,2L,7L,5L,5L,3L,4L,4L,4L,1L,8L,0L,5L,2L,2L,5L,6L,5L,3L,2L,0L,6L,6L,5L,0L,8L,3L,1L,3L,5L,3L,9L,1L,9L,2L,3L,9L,9L,0L,4L,9L,8L,8L,1L,2L,3L,5L,1L,5L,4L,3L,9L,4L,2L,9L,9L,2L,8L,7L,4L,1L,0L,9L,2L,6L,3L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021846Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021846.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021846Inst : IEnumerable<long>
{
public static readonly long[] Value=A021846.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021846.Bytes);
public long this[int i]=>Value[i];

public static A021846Inst Instance=new A021846Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021847
{
public static readonly long[] Value={ 0L,0L,1L,1L,8L,6L,2L,3L,9L,6L,2L,0L,4L,0L,3L,3L,2L,1L,4L,7L,0L,9L,3L,7L,1L,2L,9L,3L,0L,0L,1L,1L,8L,6L,2L,3L,9L,6L,2L,0L,4L,0L,3L,3L,2L,1L,4L,7L,0L,9L,3L,7L,1L,2L,9L,3L,0L,0L,1L,1L,8L,6L,2L,3L,9L,6L,2L,0L,4L,0L,3L,3L,2L,1L,4L,7L,0L,9L,3L,7L,1L,2L,9L,3L,0L,0L,1L,1L,8L,6L,2L,3L,9L,6L,2L,0L,4L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021847Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021847.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021847Inst : IEnumerable<long>
{
public static readonly long[] Value=A021847.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021847.Bytes);
public long this[int i]=>Value[i];

public static A021847Inst Instance=new A021847Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021848
{
public static readonly long[] Value={ 0L,0L,1L,1L,8L,4L,8L,3L,4L,1L,2L,3L,2L,2L,2L,7L,4L,8L,8L,1L,5L,1L,6L,5L,8L,7L,6L,7L,7L,7L,2L,5L,1L,1L,8L,4L,8L,3L,4L,1L,2L,3L,2L,2L,2L,7L,4L,8L,8L,1L,5L,1L,6L,5L,8L,7L,6L,7L,7L,7L,2L,5L,1L,1L,8L,4L,8L,3L,4L,1L,2L,3L,2L,2L,2L,7L,4L,8L,8L,1L,5L,1L,6L,5L,8L,7L,6L,7L,7L,7L,2L,5L,1L,1L,8L,4L,8L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021848Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021848.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021848Inst : IEnumerable<long>
{
public static readonly long[] Value=A021848.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021848.Bytes);
public long this[int i]=>Value[i];

public static A021848Inst Instance=new A021848Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021849
{
public static readonly long[] Value={ 0L,0L,1L,1L,8L,3L,4L,3L,1L,9L,5L,2L,6L,6L,2L,7L,2L,1L,8L,9L,3L,4L,9L,1L,1L,2L,4L,2L,6L,0L,3L,5L,5L,0L,2L,9L,5L,8L,5L,7L,9L,8L,8L,1L,6L,5L,6L,8L,0L,4L,7L,3L,3L,7L,2L,7L,8L,1L,0L,6L,5L,0L,8L,8L,7L,5L,7L,3L,9L,6L,4L,4L,9L,7L,0L,4L,1L,4L,2L,0L,1L,1L,8L,3L,4L,3L,1L,9L,5L,2L,6L,6L,2L,7L,2L,1L,8L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021849Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021849.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021849Inst : IEnumerable<long>
{
public static readonly long[] Value=A021849.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021849.Bytes);
public long this[int i]=>Value[i];

public static A021849Inst Instance=new A021849Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021850
{
public static readonly long[] Value={ 0L,0L,1L,1L,8L,2L,0L,3L,3L,0L,9L,6L,9L,2L,6L,7L,1L,3L,9L,4L,7L,9L,9L,0L,5L,4L,3L,7L,3L,5L,2L,2L,4L,5L,8L,6L,2L,8L,8L,4L,1L,6L,0L,7L,5L,6L,5L,0L,1L,1L,8L,2L,0L,3L,3L,0L,9L,6L,9L,2L,6L,7L,1L,3L,9L,4L,7L,9L,9L,0L,5L,4L,3L,7L,3L,5L,2L,2L,4L,5L,8L,6L,2L,8L,8L,4L,1L,6L,0L,7L,5L,6L,5L,0L,1L,1L,8L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021850Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021850.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021850Inst : IEnumerable<long>
{
public static readonly long[] Value=A021850.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021850.Bytes);
public long this[int i]=>Value[i];

public static A021850Inst Instance=new A021850Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021851
{
public static readonly long[] Value={ 0L,0L,1L,1L,8L,0L,6L,3L,7L,5L,4L,4L,2L,7L,3L,9L,0L,7L,9L,1L,0L,2L,7L,1L,5L,4L,6L,6L,3L,5L,1L,8L,2L,9L,9L,8L,8L,1L,9L,3L,6L,2L,4L,5L,5L,7L,2L,6L,0L,9L,2L,0L,8L,9L,7L,2L,8L,4L,5L,3L,3L,6L,4L,8L,1L,7L,0L,0L,1L,1L,8L,0L,6L,3L,7L,5L,4L,4L,2L,7L,3L,9L,0L,7L,9L,1L,0L,2L,7L,1L,5L,4L,6L,6L,3L,5L,1L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021851Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021851.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021851Inst : IEnumerable<long>
{
public static readonly long[] Value=A021851.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021851.Bytes);
public long this[int i]=>Value[i];

public static A021851Inst Instance=new A021851Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021852
{
public static readonly long[] Value={ 0L,0L,1L,1L,7L,9L,2L,4L,5L,2L,8L,3L,0L,1L,8L,8L,6L,7L,9L,2L,4L,5L,2L,8L,3L,0L,1L,8L,8L,6L,7L,9L,2L,4L,5L,2L,8L,3L,0L,1L,8L,8L,6L,7L,9L,2L,4L,5L,2L,8L,3L,0L,1L,8L,8L,6L,7L,9L,2L,4L,5L,2L,8L,3L,0L,1L,8L,8L,6L,7L,9L,2L,4L,5L,2L,8L,3L,0L,1L,8L,8L,6L,7L,9L,2L,4L,5L,2L,8L,3L,0L,1L,8L,8L,6L,7L,9L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021852Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021852.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021852Inst : IEnumerable<long>
{
public static readonly long[] Value=A021852.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021852.Bytes);
public long this[int i]=>Value[i];

public static A021852Inst Instance=new A021852Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021869
{
public static readonly long[] Value={ 0L,0L,1L,1L,5L,6L,0L,6L,9L,3L,6L,4L,1L,6L,1L,8L,4L,9L,7L,1L,0L,9L,8L,2L,6L,5L,8L,9L,5L,9L,5L,3L,7L,5L,7L,2L,2L,5L,4L,3L,3L,5L,2L,6L,0L,1L,1L,5L,6L,0L,6L,9L,3L,6L,4L,1L,6L,1L,8L,4L,9L,7L,1L,0L,9L,8L,2L,6L,5L,8L,9L,5L,9L,5L,3L,7L,5L,7L,2L,2L,5L,4L,3L,3L,5L,2L,6L,0L,1L,1L,5L,6L,0L,6L,9L,3L,6L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021869Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021869.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021869Inst : IEnumerable<long>
{
public static readonly long[] Value=A021869.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021869.Bytes);
public long this[int i]=>Value[i];

public static A021869Inst Instance=new A021869Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021870
{
public static readonly long[] Value={ 0L,0L,1L,1L,5L,4L,7L,3L,4L,4L,1L,1L,0L,8L,5L,4L,5L,0L,3L,4L,6L,4L,2L,0L,3L,2L,3L,3L,2L,5L,6L,3L,5L,1L,0L,3L,9L,2L,6L,0L,9L,6L,9L,9L,7L,6L,9L,0L,5L,3L,1L,1L,7L,7L,8L,2L,9L,0L,9L,9L,3L,0L,7L,1L,5L,9L,3L,5L,3L,3L,4L,8L,7L,2L,9L,7L,9L,2L,1L,4L,7L,8L,0L,6L,0L,0L,4L,6L,1L,8L,9L,3L,7L,6L,4L,4L,3L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021870Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021870.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021870Inst : IEnumerable<long>
{
public static readonly long[] Value=A021870.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021870.Bytes);
public long this[int i]=>Value[i];

public static A021870Inst Instance=new A021870Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021871
{
public static readonly long[] Value={ 0L,0L,1L,1L,5L,3L,4L,0L,2L,5L,3L,7L,4L,8L,5L,5L,8L,2L,4L,6L,8L,2L,8L,1L,4L,3L,0L,2L,1L,9L,1L,4L,6L,4L,8L,2L,1L,2L,2L,2L,6L,0L,6L,6L,8L,9L,7L,3L,4L,7L,1L,7L,4L,1L,6L,3L,7L,8L,3L,1L,6L,0L,3L,2L,2L,9L,5L,2L,7L,1L,0L,4L,9L,5L,9L,6L,3L,0L,9L,1L,1L,1L,8L,8L,0L,0L,4L,6L,1L,3L,6L,1L,0L,1L,4L,9L,9L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021871Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021871.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021871Inst : IEnumerable<long>
{
public static readonly long[] Value=A021871.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021871.Bytes);
public long this[int i]=>Value[i];

public static A021871Inst Instance=new A021871Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021872
{
public static readonly long[] Value={ 0L,0L,1L,1L,5L,2L,0L,7L,3L,7L,3L,2L,7L,1L,8L,8L,9L,4L,0L,0L,9L,2L,1L,6L,5L,8L,9L,8L,6L,1L,7L,5L,1L,1L,5L,2L,0L,7L,3L,7L,3L,2L,7L,1L,8L,8L,9L,4L,0L,0L,9L,2L,1L,6L,5L,8L,9L,8L,6L,1L,7L,5L,1L,1L,5L,2L,0L,7L,3L,7L,3L,2L,7L,1L,8L,8L,9L,4L,0L,0L,9L,2L,1L,6L,5L,8L,9L,8L,6L,1L,7L,5L,1L,1L,5L,2L,0L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021872Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021872.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021872Inst : IEnumerable<long>
{
public static readonly long[] Value=A021872.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021872.Bytes);
public long this[int i]=>Value[i];

public static A021872Inst Instance=new A021872Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021873
{
public static readonly long[] Value={ 0L,0L,1L,1L,5L,0L,7L,4L,7L,9L,8L,6L,1L,9L,1L,0L,2L,4L,1L,6L,5L,7L,0L,7L,7L,1L,0L,0L,1L,1L,5L,0L,7L,4L,7L,9L,8L,6L,1L,9L,1L,0L,2L,4L,1L,6L,5L,7L,0L,7L,7L,1L,0L,0L,1L,1L,5L,0L,7L,4L,7L,9L,8L,6L,1L,9L,1L,0L,2L,4L,1L,6L,5L,7L,0L,7L,7L,1L,0L,0L,1L,1L,5L,0L,7L,4L,7L,9L,8L,6L,1L,9L,1L,0L,2L,4L,1L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021873Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021873.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021873Inst : IEnumerable<long>
{
public static readonly long[] Value=A021873.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021873.Bytes);
public long this[int i]=>Value[i];

public static A021873Inst Instance=new A021873Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021874
{
public static readonly long[] Value={ 1L,22L,325L,4070L,46781L,511742L,5430405L,56516790L,580744461L,5916830062L,59935396885L,604729235110L,6084941584541L,61113049957982L,612976296281765L,6142684971387030L,61517309500479021L,615806336417543502L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021874Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021874.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021874Inst : IEnumerable<long>
{
public static readonly long[] Value=A021874.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021874.Bytes);
public long this[int i]=>Value[i];

public static A021874Inst Instance=new A021874Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021875
{
public static readonly long[] Value={ 0L,0L,1L,1L,4L,8L,1L,0L,5L,6L,2L,5L,7L,1L,7L,5L,6L,6L,0L,1L,6L,0L,7L,3L,4L,7L,8L,7L,6L,0L,0L,4L,5L,9L,2L,4L,2L,2L,5L,0L,2L,8L,7L,0L,2L,6L,4L,0L,6L,4L,2L,9L,3L,9L,1L,5L,0L,4L,0L,1L,8L,3L,6L,9L,6L,9L,0L,0L,1L,1L,4L,8L,1L,0L,5L,6L,2L,5L,7L,1L,7L,5L,6L,6L,0L,1L,6L,0L,7L,3L,4L,7L,8L,7L,6L,0L,0L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021875Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021875.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021875Inst : IEnumerable<long>
{
public static readonly long[] Value=A021875.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021875.Bytes);
public long this[int i]=>Value[i];

public static A021875Inst Instance=new A021875Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021876
{
public static readonly long[] Value={ 0L,0L,1L,1L,4L,6L,7L,8L,8L,9L,9L,0L,8L,2L,5L,6L,8L,8L,0L,7L,3L,3L,9L,4L,4L,9L,5L,4L,1L,2L,8L,4L,4L,0L,3L,6L,6L,9L,7L,2L,4L,7L,7L,0L,6L,4L,2L,2L,0L,1L,8L,3L,4L,8L,6L,2L,3L,8L,5L,3L,2L,1L,1L,0L,0L,9L,1L,7L,4L,3L,1L,1L,9L,2L,6L,6L,0L,5L,5L,0L,4L,5L,8L,7L,1L,5L,5L,9L,6L,3L,3L,0L,2L,7L,5L,2L,2L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021876Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021876.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021876Inst : IEnumerable<long>
{
public static readonly long[] Value=A021876.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021876.Bytes);
public long this[int i]=>Value[i];

public static A021876Inst Instance=new A021876Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021877
{
public static readonly long[] Value={ 0L,0L,1L,1L,4L,5L,4L,7L,5L,3L,7L,2L,2L,7L,9L,4L,9L,5L,9L,9L,0L,8L,3L,6L,1L,9L,7L,0L,2L,1L,7L,6L,4L,0L,3L,2L,0L,7L,3L,3L,1L,0L,4L,2L,3L,8L,2L,5L,8L,8L,7L,7L,4L,3L,4L,1L,3L,5L,1L,6L,6L,0L,9L,3L,9L,2L,8L,9L,8L,0L,5L,2L,6L,9L,1L,8L,6L,7L,1L,2L,4L,8L,5L,6L,8L,1L,5L,5L,7L,8L,4L,6L,5L,0L,6L,3L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021877Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021877.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021877Inst : IEnumerable<long>
{
public static readonly long[] Value=A021877.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021877.Bytes);
public long this[int i]=>Value[i];

public static A021877Inst Instance=new A021877Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021878
{
public static readonly long[] Value={ 0L,0L,1L,1L,4L,4L,1L,6L,4L,7L,5L,9L,7L,2L,5L,4L,0L,0L,4L,5L,7L,6L,6L,5L,9L,0L,3L,8L,9L,0L,1L,6L,0L,1L,8L,3L,0L,6L,6L,3L,6L,1L,5L,5L,6L,0L,6L,4L,0L,7L,3L,2L,2L,6L,5L,4L,4L,6L,2L,2L,4L,2L,5L,6L,2L,9L,2L,9L,0L,6L,1L,7L,8L,4L,8L,9L,7L,0L,2L,5L,1L,7L,1L,6L,2L,4L,7L,1L,3L,9L,5L,8L,8L,1L,0L,0L,6L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021878Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021878.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021878Inst : IEnumerable<long>
{
public static readonly long[] Value=A021878.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021878.Bytes);
public long this[int i]=>Value[i];

public static A021878Inst Instance=new A021878Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021879
{
public static readonly long[] Value={ 0L,0L,1L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021879Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021879.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021879Inst : IEnumerable<long>
{
public static readonly long[] Value=A021879.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021879.Bytes);
public long this[int i]=>Value[i];

public static A021879Inst Instance=new A021879Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021880
{
public static readonly long[] Value={ 0L,0L,1L,1L,4L,1L,5L,5L,2L,5L,1L,1L,4L,1L,5L,5L,2L,5L,1L,1L,4L,1L,5L,5L,2L,5L,1L,1L,4L,1L,5L,5L,2L,5L,1L,1L,4L,1L,5L,5L,2L,5L,1L,1L,4L,1L,5L,5L,2L,5L,1L,1L,4L,1L,5L,5L,2L,5L,1L,1L,4L,1L,5L,5L,2L,5L,1L,1L,4L,1L,5L,5L,2L,5L,1L,1L,4L,1L,5L,5L,2L,5L,1L,1L,4L,1L,5L,5L,2L,5L,1L,1L,4L,1L,5L,5L,2L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021880Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021880.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021880Inst : IEnumerable<long>
{
public static readonly long[] Value=A021880.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021880.Bytes);
public long this[int i]=>Value[i];

public static A021880Inst Instance=new A021880Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021881
{
public static readonly long[] Value={ 0L,0L,1L,1L,4L,0L,2L,5L,0L,8L,5L,5L,1L,8L,8L,1L,4L,1L,3L,9L,1L,1L,0L,6L,0L,4L,3L,3L,2L,9L,5L,3L,2L,4L,9L,7L,1L,4L,9L,3L,7L,2L,8L,6L,2L,0L,2L,9L,6L,4L,6L,5L,2L,2L,2L,3L,4L,8L,9L,1L,6L,7L,6L,1L,6L,8L,7L,5L,7L,1L,2L,6L,5L,6L,7L,8L,4L,4L,9L,2L,5L,8L,8L,3L,6L,9L,4L,4L,1L,2L,7L,7L,0L,8L,0L,9L,5L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021881Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021881.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021881Inst : IEnumerable<long>
{
public static readonly long[] Value=A021881.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021881.Bytes);
public long this[int i]=>Value[i];

public static A021881Inst Instance=new A021881Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021882
{
public static readonly long[] Value={ 0L,0L,1L,1L,3L,8L,9L,5L,2L,1L,6L,4L,0L,0L,9L,1L,1L,1L,6L,1L,7L,3L,1L,2L,0L,7L,2L,8L,9L,2L,9L,3L,8L,4L,9L,6L,5L,8L,3L,1L,4L,3L,5L,0L,7L,9L,7L,2L,6L,6L,5L,1L,4L,8L,0L,6L,3L,7L,8L,1L,3L,2L,1L,1L,8L,4L,5L,1L,0L,2L,5L,0L,5L,6L,9L,4L,7L,6L,0L,8L,2L,0L,0L,4L,5L,5L,5L,8L,0L,8L,6L,5L,6L,0L,3L,6L,4L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021882Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021882.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021882Inst : IEnumerable<long>
{
public static readonly long[] Value=A021882.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021882.Bytes);
public long this[int i]=>Value[i];

public static A021882Inst Instance=new A021882Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021883
{
public static readonly long[] Value={ 0L,0L,1L,1L,3L,7L,6L,5L,6L,4L,2L,7L,7L,5L,8L,8L,1L,6L,8L,3L,7L,3L,1L,5L,1L,3L,0L,8L,3L,0L,4L,8L,9L,1L,9L,2L,2L,6L,3L,9L,3L,6L,2L,9L,1L,2L,4L,0L,0L,4L,5L,5L,0L,6L,2L,5L,7L,1L,1L,0L,3L,5L,2L,6L,7L,3L,4L,9L,2L,6L,0L,5L,2L,3L,3L,2L,1L,9L,5L,6L,7L,6L,9L,0L,5L,5L,7L,4L,5L,1L,6L,4L,9L,6L,0L,1L,8L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021883Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021883.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021883Inst : IEnumerable<long>
{
public static readonly long[] Value=A021883.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021883.Bytes);
public long this[int i]=>Value[i];

public static A021883Inst Instance=new A021883Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021884
{
public static readonly long[] Value={ 1L,23L,358L,4758L,58419L,686541L,7864936L,88727036L,991573957L,11016698979L,121950785034L,1346833901634L,14852822151415L,163644677778137L,1801937252261452L,19834231783445352L,218267009404507593L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021884Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021884.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021884Inst : IEnumerable<long>
{
public static readonly long[] Value=A021884.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021884.Bytes);
public long this[int i]=>Value[i];

public static A021884Inst Instance=new A021884Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022013
{
public static readonly long[] Value={ 88793L,284723L,855713L,1146773L,6560993L,69156533L,74266253L,218033723L,261672773L,302542763L,964669613L,1340301863L,1400533223L,1422475913L,1837160183L,1962038783L,2117861723L,2249363093L,2272018733L,2558211563L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022013Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022013.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022013Inst : IEnumerable<long>
{
public static readonly long[] Value=A022013.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022013.Bytes);
public long this[int i]=>Value[i];

public static A022013Inst Instance=new A022013Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022014
{
public static readonly long[] Value={ 0L,1L,3L,9L,27L,81L,240L,711L,2094L,6152L,18012L,52613L,153297L,445772L,1293780L,3748820L,10845935L,31336532L,90426198L,260644262L,750502831L,2158961013L,6205225334L,17820505454L,51139664497L,146654181925L,420291420558L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022014Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022014.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022014Inst : IEnumerable<long>
{
public static readonly long[] Value=A022014.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022014.Bytes);
public long this[int i]=>Value[i];

public static A022014Inst Instance=new A022014Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022015
{
public static readonly long[] Value={ 2L,6L,19L,61L,197L,633L,2036L,6548L,21061L,67737L,217861L,700699L,2253638L,7248306L,23312507L,74979305L,241153657L,775615161L,2494587424L,8023265560L,25804984685L,82995786381L,266936820209L,858540765611L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022015Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022015.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022015Inst : IEnumerable<long>
{
public static readonly long[] Value=A022015.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022015.Bytes);
public long this[int i]=>Value[i];

public static A022015Inst Instance=new A022015Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022016
{
public static readonly long[] Value={ 1L,1L,4L,12L,47L,174L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022016Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022016.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022016Inst : IEnumerable<long>
{
public static readonly long[] Value=A022016.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022016.Bytes);
public long this[int i]=>Value[i];

public static A022016Inst Instance=new A022016Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022017
{
public static readonly long[] Value={ 1L,3L,8L,29L,103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022017Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022017.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022017Inst : IEnumerable<long>
{
public static readonly long[] Value=A022017.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022017.Bytes);
public long this[int i]=>Value[i];

public static A022017Inst Instance=new A022017Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022018
{
public static readonly long[] Value={ 2L,16L,129L,1040L,8385L,67604L,545057L,4394520L,35430801L,285660700L,2303138321L,18569044064L,149712848033L,1207059275044L,9731910872129L,78463494859944L,632611632651505L,5100428912583468L,41122188953879473L,331547494013013232L,2673100425407651457L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022018Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022018.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022018Inst : IEnumerable<long>
{
public static readonly long[] Value=A022018.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022018.Bytes);
public long this[int i]=>Value[i];

public static A022018Inst Instance=new A022018Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022019
{
public static readonly long[] Value={ 2L,32L,513L,8224L,131841L,2113576L,33883265L,543191088L,8708032065L,139600638008L,2237972711489L,35877499765312L,575161163852417L,9220552339712072L,147816978601123073L,2369690920646861904L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022019Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022019.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022019Inst : IEnumerable<long>
{
public static readonly long[] Value=A022019.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022019.Bytes);
public long this[int i]=>Value[i];

public static A022019Inst Instance=new A022019Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022020
{
public static readonly long[] Value={ 3L,9L,28L,88L,277L,872L,2746L,8648L,27236L,85778L,270153L,850832L,2679649L,8439409L,26579461L,83710572L,263641910L,830325909L,2615066456L,8236010096L,25938867499L,81693057596L,257287858063L,810314166891L,2552040558803L,8037513448351L,25313713063685L,79724167578475L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022020Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022020.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022020Inst : IEnumerable<long>
{
public static readonly long[] Value=A022020.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022020.Bytes);
public long this[int i]=>Value[i];

public static A022020Inst Instance=new A022020Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022021
{
public static readonly long[] Value={ 5L,20L,81L,329L,1337L,5434L,22086L,89767L,364852L,1482917L,6027219L,24497237L,99567416L,404685244L,1644816681L,6685249720L,27171759829L,110437838993L,448867366641L,1824392026070L,7415121953942L,30138277741915L,122495056843392L,497873139253657L,2023572780632275L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022021Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022021.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022021Inst : IEnumerable<long>
{
public static readonly long[] Value=A022021.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022021.Bytes);
public long this[int i]=>Value[i];

public static A022021Inst Instance=new A022021Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022022
{
public static readonly BigInteger[] Value={ 5L,45L,406L,3664L,33067L,298425L,2693244L,24306152L,219359637L,1979690177L,17866428166L,161242026212L,1455186832835L,13132858524565L,118522219370436L,1069646525028644L,9653410934956277L,87120689404042085L,786252089896134534L,7095815621924558952L,BigInteger.Parse("64038747861388870507") };
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
public class A022022Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022022.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022022Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A022022.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022022.Bytes);
public BigInteger this[int i]=>Value[i];

public static A022022Inst Instance=new A022022Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022023
{
public static readonly long[] Value={ 6L,30L,151L,761L,3836L,19337L,97477L,491378L,2477019L,12486565L,62944332L,317300149L,1599498817L,8063016906L,40645382751L,204891935393L,1032852992092L,5206575364849L,26246162074765L,132305973770306L,666949729466899L,3362069972805741L,16948075698414380L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022023Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022023.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022023Inst : IEnumerable<long>
{
public static readonly long[] Value=A022023.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022023.Bytes);
public long this[int i]=>Value[i];

public static A022023Inst Instance=new A022023Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022024
{
public static readonly BigInteger[] Value={ 6L,66L,727L,8009L,88232L,972018L,10708349L,117969769L,1299627646L,14317498734L,157730385799L,1737655093709L,19143078927992L,210891949829430L,2323315631208341L,25595076182769253L,281971126093205254L,3106367622527151978L,BigInteger.Parse("34221659288246953735"),BigInteger.Parse("377006879658404795777") };
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
public class A022024Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022024.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022024Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A022024.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022024.Bytes);
public BigInteger this[int i]=>Value[i];

public static A022024Inst Instance=new A022024Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022025
{
public static readonly BigInteger[] Value={ 6L,102L,1735L,29513L,502028L,8539699L,145263729L,2470994700L,42032617843L,714991805825L,12162299391068L,206885624804179L,3519208035780561L,59863150041598764L,1018296359995701043L,17321632357467588641UL,BigInteger.Parse("294647962336362325244"),BigInteger.Parse("5012080843035687303187") };
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
public class A022025Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022025.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022025Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A022025.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022025.Bytes);
public BigInteger this[int i]=>Value[i];

public static A022025Inst Instance=new A022025Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022026
{
public static readonly long[] Value={ 2L,15L,112L,836L,6240L,46576L,347648L,2594880L,19368448L,144568064L,1079070720L,8054293504L,60118065152L,448727347200L,3349346516992L,24999862747136L,186601515909120L,1392812676284416L,10396095346638848L,77597512067973120L,579195715157229568L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022026Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022026.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022026Inst : IEnumerable<long>
{
public static readonly long[] Value=A022026.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022026.Bytes);
public long this[int i]=>Value[i];

public static A022026Inst Instance=new A022026Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022027
{
public static readonly ulong[] Value={ 2L,16L,127L,1008L,8000L,63492L,503904L,3999232L,31739888L,251903488L,1999230976L,15866888256L,125927492096L,999423012864L,7931916549888L,62951622430720L,499615287394304L,3965194632954880L,31469750573916160L,249759543441752064L,1982215569002196992L,15731845549721911296UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022027Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022027.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022027Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A022027.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022027.Bytes);
public ulong this[int i]=>Value[i];

public static A022027Inst Instance=new A022027Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022028
{
public static readonly BigInteger[] Value={ 2L,32L,511L,8160L,130304L,2080776L,33227136L,530591744L,8472821696L,135299330048L,2160544546816L,34500930175488L,550932488167424L,8797635454304256L,140486159827464192L,2243371097334087680L,BigInteger.Parse("35823556473710968832"),BigInteger.Parse("572053014300755787776"),BigInteger.Parse("9134901260033419902976") };
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
public class A022028Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022028.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022028Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A022028.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022028.Bytes);
public BigInteger this[int i]=>Value[i];

public static A022028Inst Instance=new A022028Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022029
{
public static readonly long[] Value={ 4L,13L,42L,135L,433L,1388L,4449L,14260L,45706L,146496L,469546L,1504979L,4823727L,15460908L,49554976L,158832563L,509086778L,1631714194L,5229935889L,16762880107L,53728029453L,172207945799L,551957272549L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022029Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022029.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022029Inst : IEnumerable<long>
{
public static readonly long[] Value=A022029.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022029.Bytes);
public long this[int i]=>Value[i];

public static A022029Inst Instance=new A022029Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022030
{
public static readonly long[] Value={ 4L,16L,63L,249L,984L,3889L,15370L,60745L,240075L,948819L,3749901L,14820274L,58572352L,231488326L,914882931L,3615779646L,14290202610L,56477415835L,223208766625L,882160643536L,3486455360919L,13779090092886L,54457408494633L,215225339261149L,850608722312629L,3361756570848769L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022030Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022030.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022030Inst : IEnumerable<long>
{
public static readonly long[] Value=A022030.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022030.Bytes);
public long this[int i]=>Value[i];

public static A022030Inst Instance=new A022030Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022031
{
public static readonly long[] Value={ 4L,17L,72L,304L,1283L,5414L,22845L,96397L,406757L,1716352L,7242319L,30559689L,128949662L,544115986L,2295951781L,9687997993L,40879475731L,172495033261L,727860031657L,3071278144467L,12959565068034L,54684179957837L,230745362360740L,973653116715681L,4108426630946045L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022031Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022031.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022031Inst : IEnumerable<long>
{
public static readonly long[] Value=A022031.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022031.Bytes);
public long this[int i]=>Value[i];

public static A022031Inst Instance=new A022031Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022032
{
public static readonly long[] Value={ 5L,26L,135L,700L,3629L,18813L,97527L,505582L,2620947L,13587040L,70435478L,365138879L,1892887004L,9812762803L,50869551972L,263708740319L,1367071205166L,7086923541985L,36738748574433L,190454382472052L,987319198674433L,5118281802804775L,26533271760636405L,137548993480193164L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022032Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022032.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022032Inst : IEnumerable<long>
{
public static readonly long[] Value=A022032.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022032.Bytes);
public long this[int i]=>Value[i];

public static A022032Inst Instance=new A022032Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022033
{
public static readonly long[] Value={ 1L,19L,236L,2426L,22407L,193305L,1591402L,12667072L,98321333L,748601711L,5614533288L,41608696038L,305407826179L,2224262385637L,16095911708294L,115865978983724L,830420169903345L,5930044765743483L,42217703190306820L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022033Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022033.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022033Inst : IEnumerable<long>
{
public static readonly long[] Value=A022033.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022033.Bytes);
public long this[int i]=>Value[i];

public static A022033Inst Instance=new A022033Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022034
{
public static readonly long[] Value={ 6L,31L,160L,825L,4253L,21924L,113017L,582596L,3003248L,15481566L,79806558L,411398091L,2120732851L,10932252540L,56355115894L,290507292601L,1497547928268L,7719771085196L,39794963809107L,205140687086569L,1057488120864155L,5451288779669969L,28101071561042234L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022034Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022034.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022034Inst : IEnumerable<long>
{
public static readonly long[] Value=A022034.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022034.Bytes);
public long this[int i]=>Value[i];

public static A022034Inst Instance=new A022034Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022035
{
public static readonly long[] Value={ 6L,37L,228L,1404L,8645L,53230L,327753L,2018073L,12425877L,76509828L,471093813L,2900665005L,17860258910L,109970936934L,677123832923L,4169253239949L,25671334745061L,158066058755653L,973259831585207L,5992650839998179L,36898537188819414L,227195290202341077L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022035Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022035.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022035Inst : IEnumerable<long>
{
public static readonly long[] Value=A022035.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022035.Bytes);
public long this[int i]=>Value[i];

public static A022035Inst Instance=new A022035Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022036
{
public static readonly long[] Value={ 7L,43L,264L,1620L,9940L,60989L,374211L,2296051L,14087908L,86439348L,530366956L,3254178965L,19966705347L,122509956183L,751685824132L,4612127828672L,28298688661016L,173632607265289L,1065359694467895L,6536740399587511L,40107557356899000L,246088426157852600L,1509927741297161799L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022036Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022036.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022036Inst : IEnumerable<long>
{
public static readonly long[] Value=A022036.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022036.Bytes);
public long this[int i]=>Value[i];

public static A022036Inst Instance=new A022036Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022037
{
public static readonly long[] Value={ 7L,50L,357L,2548L,18185L,129785L,926265L,6610678L,47179871L,336718900L,2403135388L,17150981703L,122405160710L,873595670959L,6234781212586L,44497126143199L,317572368218278L,2266488148722385L,16175741476249015L,115444950574278036L,823921217624950245L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022037Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022037.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022037Inst : IEnumerable<long>
{
public static readonly long[] Value=A022037.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022037.Bytes);
public long this[int i]=>Value[i];

public static A022037Inst Instance=new A022037Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022038
{
public static readonly long[] Value={ 8L,57L,406L,2891L,20585L,146572L,1043641L,7431068L,52911654L,376748420L,2682572954L,19100803803L,136004020087L,968393459804L,6895280686492L,49096671672207L,349584488128334L,2489156803863966L,17723617050044085L,126197996385357735L,898571338272012057L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022038Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022038.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022038Inst : IEnumerable<long>
{
public static readonly long[] Value=A022038.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022038.Bytes);
public long this[int i]=>Value[i];

public static A022038Inst Instance=new A022038Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022039
{
public static readonly long[] Value={ 8L,65L,528L,4288L,34823L,282798L,2296605L,18650749L,151462893L,1230031456L,9989096027L,81121534697L,658788680558L,5350028537458L,43447627739097L,352838558325161L,2865404964997647L,23269978350457597L,188975694202166613L,1534673236964508227L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022039Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022039.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022039Inst : IEnumerable<long>
{
public static readonly long[] Value=A022039.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022039.Bytes);
public long this[int i]=>Value[i];

public static A022039Inst Instance=new A022039Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022040
{
public static readonly long[] Value={ 16L,36L,80L,177L,391L,863L,1904L,4200L,9264L,20433L,45067L,99399L,219232L,483532L,1066464L,2352161L,5187855L,11442175L,25236512L,55660880L,122763936L,270764385L,597189651L,1317143239L,2905050864L,6407291380L,14131726000L,31168502865L,68744297111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022040Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022040.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022040Inst : IEnumerable<long>
{
public static readonly long[] Value=A022040.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022040.Bytes);
public long this[int i]=>Value[i];

public static A022040Inst Instance=new A022040Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022041
{
public static readonly long[] Value={ 2L,6L,19L,61L,196L,630L,2026L,6516L,20957L,67403L,216786L,697242L,2242518L,7212542L,23197478L,74609338L,239963729L,771787993L,2482278087L,7983674995L,25677649398L,82586237418L,265619586324L,854304141280L,2747672247776L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022041Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022041.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022041Inst : IEnumerable<long>
{
public static readonly long[] Value=A022041.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022041.Bytes);
public long this[int i]=>Value[i];

public static A022041Inst Instance=new A022041Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022042
{
public static readonly long[] Value={ 1L,220L,5302L,33528L,116380L,339064L,719400L,1538416L,2624182L,4763220L,7217144L,11676280L,16317048L,25022184L,32503680L,47430768L,59759260L,82927856L,101189550L,137904360L,161928184L,215389680L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022042Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022042.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022042Inst : IEnumerable<long>
{
public static readonly long[] Value=A022042.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022042.Bytes);
public long this[int i]=>Value[i];

public static A022042Inst Instance=new A022042Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022043
{
public static readonly long[] Value={ 1L,264L,7944L,64416L,253704L,825264L,1938336L,4437312L,8118024L,15653352L,24832944L,42517728L,61903776L,98021616L,133522752L,201364416L,259776264L,374842512L,471023592L,653690400L,793078704L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022043Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022043.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022043Inst : IEnumerable<long>
{
public static readonly long[] Value=A022043.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022043.Bytes);
public long this[int i]=>Value[i];

public static A022043Inst Instance=new A022043Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022044
{
public static readonly long[] Value={ 1L,312L,11466L,116688L,535704L,1899664L,5043376L,12066912L,24443978L,48210760L,83323344L,145532816L,227110416L,363737712L,531517376L,800145632L,1104376728L,1594656544L,2114015514L,2931991920L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022044Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022044.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022044Inst : IEnumerable<long>
{
public static readonly long[] Value=A022044.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022044.Bytes);
public long this[int i]=>Value[i];

public static A022044Inst Instance=new A022044Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022061
{
public static readonly long[] Value={ 1L,1740L,438540L,38099040L,1521151500L,32592806520L,420775407200L,3655476494400L,23690038522380L,123233778584940L,538518903906552L,2045337982427040L,6914885182908000L,21207036616238520L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022061Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022061.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022061Inst : IEnumerable<long>
{
public static readonly long[] Value=A022061.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022061.Bytes);
public long this[int i]=>Value[i];

public static A022061Inst Instance=new A022061Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022062
{
public static readonly long[] Value={ 1L,1860L,503502L,47229864L,2046701220L,47775740520L,671636175480L,6309132101904L,43733123309262L,241275541236780L,1111479953165352L,4426891212365160L,15633379938039144L,49899492947343864L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022062Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022062.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022062Inst : IEnumerable<long>
{
public static readonly long[] Value=A022062.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022062.Bytes);
public long this[int i]=>Value[i];

public static A022062Inst Instance=new A022062Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022063
{
public static readonly long[] Value={ 1L,1984L,575424L,58115328L,2724906944L,69079796864L,1054968628480L,10706472186368L,79395777333184L,464573878394560L,2256126097001600L,9423431444080384L,34759556728866048L,115474354635222656L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022063Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022063.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022063Inst : IEnumerable<long>
{
public static readonly long[] Value=A022063.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022063.Bytes);
public long this[int i]=>Value[i];

public static A022063Inst Instance=new A022063Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022064
{
public static readonly long[] Value={ 1L,0L,0L,0L,22L,0L,0L,0L,220L,0L,0L,2048L,1320L,0L,0L,0L,5302L,0L,0L,22528L,15224L,0L,0L,0L,33528L,0L,0L,112640L,63360L,0L,0L,0L,116380L,0L,0L,360448L,209550L,0L,0L,0L,339064L,0L,0L,901120L,491768L,0L,0L,0L,719400L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022064Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022064.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022064Inst : IEnumerable<long>
{
public static readonly long[] Value=A022064.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022064.Bytes);
public long this[int i]=>Value[i];

public static A022064Inst Instance=new A022064Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022065
{
public static readonly long[] Value={ 1L,24L,264L,5856L,7944L,75024L,64416L,403392L,253704L,1423032L,825264L,3865248L,1938336L,8911056L,4437312L,18305856L,8118024L,34076592L,15653352L,59426400L,24832944L,98427648L,42517728L,154472256L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022065Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022065.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022065Inst : IEnumerable<long>
{
public static readonly long[] Value=A022065.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022065.Bytes);
public long this[int i]=>Value[i];

public static A022065Inst Instance=new A022065Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022066
{
public static readonly long[] Value={ 1L,0L,0L,0L,26L,0L,0L,0L,312L,0L,0L,0L,2288L,8192L,0L,0L,11466L,0L,0L,0L,41808L,106496L,0L,0L,116688L,0L,0L,0L,265408L,638976L,0L,0L,535704L,0L,0L,0L,1031914L,2449408L,0L,0L,1899664L,0L,0L,0L,3214224L,7135232L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022066Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022066.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022066Inst : IEnumerable<long>
{
public static readonly long[] Value=A022066.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022066.Bytes);
public long this[int i]=>Value[i];

public static A022066Inst Instance=new A022066Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022067
{
public static readonly long[] Value={ 1L,0L,28L,0L,364L,0L,2912L,16384L,16044L,0L,64792L,229376L,200928L,0L,503360L,1490944L,1089452L,0L,2186940L,6193152L,4196920L,0L,7544992L,19382272L,12547808L,0L,19975256L,50692096L,31553344L,0L,48484800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022067Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022067.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022067Inst : IEnumerable<long>
{
public static readonly long[] Value=A022067.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022067.Bytes);
public long this[int i]=>Value[i];

public static A022067Inst Instance=new A022067Inst();

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