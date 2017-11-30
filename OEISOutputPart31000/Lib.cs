using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A016677
{
public static readonly long[] Value={ 3L,9L,8L,8L,9L,8L,4L,0L,4L,6L,5L,6L,4L,2L,7L,4L,3L,8L,3L,6L,0L,2L,9L,6L,7L,8L,3L,2L,2L,2L,5L,7L,5L,3L,6L,8L,2L,0L,1L,7L,9L,7L,1L,8L,0L,7L,8L,2L,8L,5L,0L,3L,6L,0L,9L,3L,2L,4L,7L,6L,3L,0L,1L,0L,4L,0L,5L,8L,7L,6L,5L,0L,1L,6L,2L,5L,5L,2L,1L,6L,1L,6L,2L,2L,6L,7L,1L,0L,5L,9L,1L,4L,3L,7L,6L,1L,4L,9L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016677Inst : IEnumerable<long>
{
public static readonly long[] Value=A016677.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016677.Bytes);
public long this[int i]=>Value[i];

public static A016677Inst Instance=new A016677Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016676
{
public static readonly long[] Value={ 3L,9L,7L,0L,2L,9L,1L,9L,1L,3L,5L,5L,2L,1L,2L,1L,8L,3L,4L,1L,4L,4L,4L,6L,9L,1L,3L,9L,0L,2L,9L,0L,5L,7L,7L,7L,0L,3L,5L,9L,9L,7L,7L,7L,5L,2L,9L,1L,1L,2L,1L,7L,6L,0L,3L,0L,4L,8L,1L,2L,9L,4L,7L,0L,0L,1L,8L,0L,0L,4L,6L,3L,3L,9L,4L,3L,4L,8L,9L,8L,5L,8L,5L,3L,4L,6L,5L,9L,9L,4L,4L,4L,8L,5L,9L,2L,1L,2L,2L,9L,8L,4L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016676Inst : IEnumerable<long>
{
public static readonly long[] Value=A016676.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016676.Bytes);
public long this[int i]=>Value[i];

public static A016676Inst Instance=new A016676Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016675
{
public static readonly long[] Value={ 3L,9L,5L,1L,2L,4L,3L,7L,1L,8L,5L,8L,1L,4L,2L,7L,3L,5L,4L,8L,8L,7L,9L,5L,1L,6L,8L,4L,4L,8L,1L,6L,7L,1L,7L,4L,0L,9L,5L,6L,2L,6L,8L,2L,1L,3L,4L,8L,0L,7L,1L,7L,6L,2L,4L,6L,6L,0L,4L,0L,5L,5L,2L,9L,6L,5L,0L,2L,5L,1L,9L,1L,1L,2L,6L,3L,7L,9L,9L,6L,1L,0L,6L,1L,1L,3L,0L,1L,3L,1L,7L,4L,3L,3L,3L,2L,6L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016675Inst : IEnumerable<long>
{
public static readonly long[] Value=A016675.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016675.Bytes);
public long this[int i]=>Value[i];

public static A016675Inst Instance=new A016675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016674
{
public static readonly long[] Value={ 3L,9L,3L,1L,8L,2L,5L,6L,3L,2L,7L,2L,4L,3L,2L,5L,7L,7L,1L,6L,4L,4L,7L,7L,9L,8L,5L,4L,7L,9L,5L,6L,5L,2L,2L,4L,0L,2L,3L,5L,6L,9L,3L,5L,7L,0L,4L,0L,8L,4L,9L,4L,2L,3L,9L,0L,3L,1L,9L,3L,2L,0L,7L,1L,5L,1L,9L,7L,8L,6L,8L,6L,9L,0L,1L,9L,5L,4L,0L,2L,4L,7L,7L,8L,5L,7L,1L,0L,6L,2L,2L,8L,5L,1L,2L,3L,5L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016674Inst : IEnumerable<long>
{
public static readonly long[] Value=A016674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016674.Bytes);
public long this[int i]=>Value[i];

public static A016674Inst Instance=new A016674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016673
{
public static readonly long[] Value={ 3L,9L,1L,2L,0L,2L,3L,0L,0L,5L,4L,2L,8L,1L,4L,6L,0L,5L,8L,6L,1L,8L,7L,5L,0L,7L,8L,7L,9L,1L,0L,5L,5L,1L,8L,4L,7L,1L,2L,6L,7L,0L,2L,8L,4L,2L,8L,9L,7L,2L,9L,0L,6L,9L,7L,9L,4L,5L,9L,7L,5L,7L,9L,2L,4L,4L,1L,7L,5L,1L,5L,9L,7L,3L,8L,5L,0L,1L,0L,2L,4L,4L,8L,6L,6L,1L,3L,1L,0L,8L,3L,1L,8L,2L,7L,7L,7L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016673Inst : IEnumerable<long>
{
public static readonly long[] Value=A016673.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016673.Bytes);
public long this[int i]=>Value[i];

public static A016673Inst Instance=new A016673Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016672
{
public static readonly long[] Value={ 3L,8L,9L,1L,8L,2L,0L,2L,9L,8L,1L,1L,0L,6L,2L,6L,6L,1L,0L,2L,1L,0L,7L,0L,5L,4L,8L,6L,8L,8L,6L,3L,5L,9L,4L,5L,9L,2L,7L,4L,1L,6L,9L,4L,5L,9L,1L,6L,3L,7L,2L,2L,3L,7L,6L,9L,1L,8L,7L,8L,0L,2L,9L,9L,8L,7L,5L,1L,5L,9L,7L,2L,5L,5L,0L,4L,1L,3L,8L,5L,3L,5L,5L,7L,5L,3L,1L,6L,9L,9L,7L,1L,7L,5L,7L,4L,3L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016672Inst : IEnumerable<long>
{
public static readonly long[] Value=A016672.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016672.Bytes);
public long this[int i]=>Value[i];

public static A016672Inst Instance=new A016672Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016671
{
public static readonly long[] Value={ 3L,8L,7L,1L,2L,0L,1L,0L,1L,0L,9L,0L,7L,8L,9L,0L,9L,2L,9L,0L,6L,4L,1L,7L,3L,7L,2L,2L,7L,5L,5L,2L,3L,1L,9L,7L,6L,9L,4L,9L,4L,9L,1L,0L,9L,5L,2L,6L,3L,7L,7L,0L,4L,6L,8L,2L,1L,7L,4L,1L,4L,3L,7L,1L,6L,1L,1L,0L,6L,8L,7L,8L,1L,0L,9L,7L,3L,8L,7L,8L,2L,9L,2L,9L,7L,0L,6L,9L,0L,6L,2L,7L,9L,9L,4L,0L,6L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016671Inst : IEnumerable<long>
{
public static readonly long[] Value=A016671.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016671.Bytes);
public long this[int i]=>Value[i];

public static A016671Inst Instance=new A016671Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016670
{
public static readonly long[] Value={ 3L,8L,5L,0L,1L,4L,7L,6L,0L,1L,7L,1L,0L,0L,5L,8L,5L,8L,6L,8L,2L,0L,9L,5L,0L,6L,6L,9L,7L,7L,2L,1L,7L,3L,7L,0L,8L,8L,9L,6L,0L,5L,0L,5L,0L,2L,0L,2L,0L,2L,2L,4L,0L,3L,3L,2L,0L,0L,5L,0L,8L,3L,4L,6L,8L,0L,6L,8L,1L,8L,2L,1L,3L,5L,0L,5L,8L,0L,1L,0L,7L,2L,6L,1L,0L,6L,8L,9L,7L,5L,3L,4L,3L,4L,7L,4L,5L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016670Inst : IEnumerable<long>
{
public static readonly long[] Value=A016670.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016670.Bytes);
public long this[int i]=>Value[i];

public static A016670Inst Instance=new A016670Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016653
{
public static readonly long[] Value={ 3L,4L,0L,1L,1L,9L,7L,3L,8L,1L,6L,6L,2L,1L,5L,5L,3L,7L,5L,4L,1L,3L,2L,3L,6L,6L,9L,1L,6L,0L,6L,8L,8L,9L,9L,1L,2L,2L,4L,8L,5L,9L,2L,0L,4L,6L,4L,5L,1L,5L,2L,2L,4L,2L,7L,7L,6L,8L,0L,2L,2L,2L,3L,4L,6L,0L,5L,0L,6L,6L,9L,0L,2L,8L,9L,5L,9L,6L,1L,4L,4L,7L,1L,0L,9L,6L,1L,2L,9L,5L,9L,9L,0L,3L,3L,3L,0L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016653Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016653.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016653Inst : IEnumerable<long>
{
public static readonly long[] Value=A016653.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016653.Bytes);
public long this[int i]=>Value[i];

public static A016653Inst Instance=new A016653Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016652
{
public static readonly long[] Value={ 3L,3L,6L,7L,2L,9L,5L,8L,2L,9L,9L,8L,6L,4L,7L,4L,0L,2L,7L,1L,8L,3L,2L,7L,2L,0L,3L,2L,3L,6L,1L,9L,1L,1L,6L,0L,5L,4L,9L,4L,5L,1L,2L,9L,1L,3L,9L,2L,2L,7L,4L,4L,0L,7L,8L,9L,2L,1L,6L,7L,0L,3L,5L,1L,6L,4L,2L,7L,8L,0L,7L,8L,1L,1L,3L,7L,8L,5L,2L,3L,3L,3L,2L,9L,3L,3L,6L,7L,1L,1L,4L,8L,1L,7L,8L,5L,6L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016652Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016652.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016652Inst : IEnumerable<long>
{
public static readonly long[] Value=A016652.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016652.Bytes);
public long this[int i]=>Value[i];

public static A016652Inst Instance=new A016652Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016651
{
public static readonly long[] Value={ 3L,3L,3L,2L,2L,0L,4L,5L,1L,0L,1L,7L,5L,2L,0L,3L,9L,2L,3L,9L,3L,9L,8L,1L,6L,9L,8L,6L,3L,5L,9L,5L,3L,2L,8L,6L,5L,7L,8L,8L,0L,8L,4L,9L,9L,8L,3L,0L,2L,3L,7L,1L,6L,9L,6L,7L,0L,0L,7L,5L,0L,1L,6L,8L,9L,2L,4L,3L,6L,7L,1L,0L,6L,6L,9L,1L,4L,5L,8L,6L,9L,8L,9L,9L,9L,3L,8L,5L,1L,5L,2L,5L,8L,0L,7L,0L,8L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016651Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016651.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016651Inst : IEnumerable<long>
{
public static readonly long[] Value=A016651.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016651.Bytes);
public long this[int i]=>Value[i];

public static A016651Inst Instance=new A016651Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016650
{
public static readonly long[] Value={ 3L,2L,9L,5L,8L,3L,6L,8L,6L,6L,0L,0L,4L,3L,2L,9L,0L,7L,4L,1L,8L,5L,7L,3L,5L,7L,1L,0L,7L,6L,7L,5L,7L,7L,1L,1L,3L,9L,4L,2L,4L,7L,1L,6L,7L,3L,4L,6L,8L,2L,4L,8L,3L,5L,5L,2L,0L,4L,0L,8L,3L,0L,0L,0L,9L,1L,2L,4L,8L,2L,8L,7L,9L,6L,5L,5L,8L,2L,6L,9L,0L,0L,6L,2L,0L,8L,4L,7L,2L,6L,4L,4L,4L,1L,1L,9L,6L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016650Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016650.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016650Inst : IEnumerable<long>
{
public static readonly long[] Value=A016650.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016650.Bytes);
public long this[int i]=>Value[i];

public static A016650Inst Instance=new A016650Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016649
{
public static readonly long[] Value={ 3L,2L,5L,8L,0L,9L,6L,5L,3L,8L,0L,2L,1L,4L,8L,2L,0L,4L,5L,4L,7L,0L,7L,1L,9L,5L,6L,3L,0L,2L,3L,4L,9L,5L,1L,7L,2L,8L,8L,0L,7L,6L,8L,0L,7L,9L,1L,2L,0L,4L,6L,2L,3L,7L,0L,5L,3L,9L,7L,2L,5L,5L,2L,0L,1L,5L,6L,8L,5L,8L,2L,8L,9L,2L,9L,4L,1L,0L,4L,8L,9L,5L,0L,0L,5L,4L,3L,7L,9L,9L,0L,4L,3L,6L,9L,0L,8L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016649Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016649.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016649Inst : IEnumerable<long>
{
public static readonly long[] Value=A016649.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016649.Bytes);
public long this[int i]=>Value[i];

public static A016649Inst Instance=new A016649Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016648
{
public static readonly long[] Value={ 3L,2L,1L,8L,8L,7L,5L,8L,2L,4L,8L,6L,8L,2L,0L,0L,7L,4L,9L,2L,0L,1L,5L,1L,8L,6L,6L,6L,4L,5L,2L,3L,7L,5L,2L,7L,9L,0L,5L,1L,2L,0L,2L,7L,0L,8L,5L,3L,7L,0L,3L,5L,4L,4L,3L,8L,2L,5L,2L,9L,5L,7L,8L,2L,9L,4L,8L,3L,5L,7L,9L,7L,5L,4L,1L,5L,3L,1L,5L,5L,2L,9L,2L,6L,0L,2L,6L,7L,7L,5L,6L,1L,8L,6L,3L,5L,9L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016648Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016648.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016648Inst : IEnumerable<long>
{
public static readonly long[] Value=A016648.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016648.Bytes);
public long this[int i]=>Value[i];

public static A016648Inst Instance=new A016648Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016647
{
public static readonly long[] Value={ 3L,1L,7L,8L,0L,5L,3L,8L,3L,0L,3L,4L,7L,9L,4L,5L,6L,1L,9L,6L,4L,6L,9L,4L,1L,6L,0L,1L,2L,9L,7L,0L,5L,5L,4L,0L,8L,8L,7L,3L,9L,9L,0L,9L,6L,0L,9L,0L,3L,5L,1L,5L,2L,1L,4L,0L,9L,6L,7L,3L,4L,3L,6L,2L,1L,1L,7L,6L,7L,5L,1L,5L,9L,1L,2L,7L,6L,9L,3L,1L,1L,3L,6L,9L,1L,2L,0L,5L,7L,3L,5L,8L,0L,2L,9L,8L,8L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016647Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016647.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016647Inst : IEnumerable<long>
{
public static readonly long[] Value=A016647.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016647.Bytes);
public long this[int i]=>Value[i];

public static A016647Inst Instance=new A016647Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016646
{
public static readonly long[] Value={ 3L,1L,3L,5L,4L,9L,4L,2L,1L,5L,9L,2L,9L,1L,4L,9L,6L,9L,0L,8L,0L,6L,7L,5L,2L,8L,3L,1L,8L,1L,0L,1L,9L,6L,1L,1L,8L,4L,4L,2L,3L,8L,0L,3L,1L,4L,8L,4L,0L,4L,3L,5L,7L,4L,1L,9L,9L,8L,6L,3L,5L,3L,7L,7L,4L,8L,2L,9L,9L,3L,2L,4L,5L,9L,8L,4L,7L,9L,8L,2L,9L,8L,1L,9L,8L,4L,0L,1L,0L,9L,2L,1L,5L,2L,9L,9L,4L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016646Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016646.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016646Inst : IEnumerable<long>
{
public static readonly long[] Value=A016646.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016646.Bytes);
public long this[int i]=>Value[i];

public static A016646Inst Instance=new A016646Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016645
{
public static readonly long[] Value={ 3L,0L,9L,1L,0L,4L,2L,4L,5L,3L,3L,5L,8L,3L,1L,5L,8L,5L,3L,4L,7L,9L,1L,7L,5L,6L,9L,9L,4L,2L,3L,3L,0L,5L,8L,6L,7L,8L,9L,7L,2L,0L,6L,9L,8L,8L,2L,9L,7L,6L,7L,2L,4L,2L,9L,3L,3L,9L,2L,4L,7L,7L,1L,8L,6L,2L,3L,9L,6L,7L,2L,4L,5L,8L,8L,2L,9L,3L,1L,4L,2L,8L,6L,8L,0L,9L,1L,8L,0L,3L,4L,9L,9L,9L,0L,5L,3L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016645Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016645.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016645Inst : IEnumerable<long>
{
public static readonly long[] Value=A016645.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016645.Bytes);
public long this[int i]=>Value[i];

public static A016645Inst Instance=new A016645Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016644
{
public static readonly long[] Value={ 3L,0L,4L,4L,5L,2L,2L,4L,3L,7L,7L,2L,3L,4L,2L,2L,9L,9L,6L,5L,0L,0L,5L,9L,7L,9L,8L,0L,3L,6L,5L,7L,0L,5L,4L,3L,4L,2L,8L,4L,5L,7L,5L,2L,8L,7L,4L,0L,4L,6L,1L,0L,6L,4L,0L,1L,9L,4L,0L,8L,4L,4L,8L,3L,5L,7L,5L,0L,7L,4L,1L,5L,5L,9L,7L,0L,6L,7L,8L,2L,3L,4L,6L,6L,1L,2L,7L,4L,2L,5L,3L,4L,0L,1L,6L,0L,3L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016644Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016644.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016644Inst : IEnumerable<long>
{
public static readonly long[] Value=A016644.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016644.Bytes);
public long this[int i]=>Value[i];

public static A016644Inst Instance=new A016644Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016643
{
public static readonly long[] Value={ 2L,9L,9L,5L,7L,3L,2L,2L,7L,3L,5L,5L,3L,9L,9L,0L,9L,9L,3L,4L,3L,5L,2L,2L,3L,5L,7L,6L,1L,4L,2L,5L,4L,0L,7L,7L,5L,6L,7L,6L,6L,0L,1L,6L,2L,2L,9L,8L,9L,0L,2L,8L,2L,3L,0L,1L,5L,4L,0L,0L,7L,9L,1L,0L,4L,6L,0L,9L,6L,6L,2L,3L,1L,6L,4L,7L,0L,4L,7L,1L,9L,5L,8L,4L,1L,8L,6L,0L,5L,3L,2L,0L,8L,6L,0L,1L,6L,9L,8L,5L,8L,8L,3L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016643Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016643.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016643Inst : IEnumerable<long>
{
public static readonly long[] Value=A016643.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016643.Bytes);
public long this[int i]=>Value[i];

public static A016643Inst Instance=new A016643Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016642
{
public static readonly long[] Value={ 2L,9L,4L,4L,4L,3L,8L,9L,7L,9L,1L,6L,6L,4L,4L,0L,4L,6L,0L,0L,0L,9L,0L,2L,7L,4L,3L,1L,8L,8L,7L,8L,5L,3L,5L,3L,7L,2L,3L,7L,3L,7L,9L,2L,6L,1L,2L,9L,9L,1L,2L,8L,8L,1L,8L,5L,3L,7L,9L,6L,0L,2L,3L,6L,4L,0L,9L,2L,9L,2L,7L,0L,2L,0L,6L,4L,1L,9L,7L,2L,8L,8L,7L,1L,4L,1L,5L,8L,3L,8L,3L,8L,1L,5L,7L,3L,9L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016642Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016642.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016642Inst : IEnumerable<long>
{
public static readonly long[] Value=A016642.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016642.Bytes);
public long this[int i]=>Value[i];

public static A016642Inst Instance=new A016642Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016641
{
public static readonly long[] Value={ 2L,8L,9L,0L,3L,7L,1L,7L,5L,7L,8L,9L,6L,1L,6L,4L,6L,9L,2L,2L,0L,7L,7L,2L,2L,5L,9L,5L,3L,0L,3L,2L,2L,7L,9L,7L,7L,3L,7L,0L,4L,8L,1L,2L,5L,0L,0L,0L,5L,7L,5L,4L,1L,5L,7L,5L,9L,0L,0L,6L,8L,6L,7L,6L,7L,6L,8L,3L,8L,2L,2L,0L,8L,4L,0L,6L,9L,1L,2L,6L,4L,9L,3L,5L,3L,0L,9L,4L,8L,3L,6L,6L,2L,3L,8L,8L,2L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016641Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016641.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016641Inst : IEnumerable<long>
{
public static readonly long[] Value=A016641.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016641.Bytes);
public long this[int i]=>Value[i];

public static A016641Inst Instance=new A016641Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016640
{
public static readonly long[] Value={ 2L,8L,3L,3L,2L,1L,3L,3L,4L,4L,0L,5L,6L,2L,1L,6L,0L,8L,0L,2L,4L,9L,5L,3L,4L,6L,1L,7L,8L,7L,3L,1L,2L,6L,5L,3L,5L,5L,8L,8L,2L,0L,3L,0L,1L,2L,5L,8L,5L,7L,4L,4L,7L,8L,7L,2L,9L,7L,2L,3L,7L,7L,3L,7L,8L,8L,2L,2L,9L,2L,5L,7L,5L,8L,0L,0L,9L,3L,1L,2L,8L,0L,9L,1L,2L,0L,9L,4L,8L,6L,8L,0L,3L,7L,5L,0L,2L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016640Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016640.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016640Inst : IEnumerable<long>
{
public static readonly long[] Value=A016640.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016640.Bytes);
public long this[int i]=>Value[i];

public static A016640Inst Instance=new A016640Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016639
{
public static readonly long[] Value={ 2L,7L,7L,2L,5L,8L,8L,7L,2L,2L,2L,3L,9L,7L,8L,1L,2L,3L,7L,6L,6L,8L,9L,2L,8L,4L,8L,5L,8L,3L,2L,7L,0L,6L,2L,7L,2L,3L,0L,2L,0L,0L,0L,5L,3L,7L,4L,4L,1L,0L,2L,1L,0L,1L,6L,4L,8L,2L,7L,2L,0L,0L,3L,7L,9L,7L,3L,5L,7L,4L,4L,8L,7L,8L,7L,8L,7L,7L,8L,8L,6L,2L,4L,2L,3L,4L,5L,3L,3L,0L,7L,9L,8L,5L,6L,7L,4L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016639Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016639.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016639Inst : IEnumerable<long>
{
public static readonly long[] Value=A016639.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016639.Bytes);
public long this[int i]=>Value[i];

public static A016639Inst Instance=new A016639Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016638
{
public static readonly long[] Value={ 2L,7L,0L,8L,0L,5L,0L,2L,0L,1L,1L,0L,2L,2L,1L,0L,0L,6L,5L,9L,9L,6L,0L,0L,4L,5L,7L,0L,1L,4L,8L,7L,1L,3L,3L,4L,4L,1L,7L,3L,0L,9L,1L,9L,1L,2L,0L,9L,1L,2L,6L,7L,1L,7L,3L,6L,4L,7L,3L,4L,2L,2L,2L,5L,1L,1L,1L,6L,7L,3L,2L,8L,0L,9L,2L,6L,2L,6L,6L,7L,3L,1L,5L,0L,3L,7L,4L,9L,6L,3L,2L,9L,0L,6L,9L,1L,1L,6L,9L,9L,5L,8L,7L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016638Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016638.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016638Inst : IEnumerable<long>
{
public static readonly long[] Value=A016638.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016638.Bytes);
public long this[int i]=>Value[i];

public static A016638Inst Instance=new A016638Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016621
{
public static readonly long[] Value={ 3L,7L,9L,5L,4L,8L,9L,1L,8L,9L,1L,7L,2L,1L,9L,4L,5L,2L,8L,9L,0L,0L,5L,8L,3L,4L,1L,9L,2L,1L,1L,6L,7L,2L,6L,5L,1L,3L,2L,9L,1L,6L,0L,2L,5L,2L,7L,7L,2L,7L,0L,4L,1L,0L,9L,9L,8L,6L,0L,1L,7L,5L,6L,7L,7L,9L,4L,5L,6L,0L,2L,7L,0L,8L,0L,9L,7L,6L,1L,5L,3L,0L,8L,4L,1L,2L,0L,0L,2L,2L,4L,9L,5L,3L,0L,5L,7L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016621Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016621.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016621Inst : IEnumerable<long>
{
public static readonly long[] Value=A016621.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016621.Bytes);
public long this[int i]=>Value[i];

public static A016621Inst Instance=new A016621Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016620
{
public static readonly long[] Value={ 3L,7L,7L,2L,7L,6L,0L,9L,3L,8L,0L,9L,4L,6L,3L,8L,4L,0L,9L,1L,6L,1L,2L,8L,5L,1L,4L,7L,8L,2L,6L,2L,6L,0L,7L,4L,2L,0L,6L,6L,5L,0L,3L,3L,3L,7L,3L,8L,5L,2L,3L,8L,2L,7L,6L,5L,3L,5L,6L,8L,4L,6L,7L,5L,7L,8L,6L,8L,8L,1L,4L,5L,2L,3L,8L,6L,7L,6L,6L,5L,8L,4L,5L,6L,1L,1L,1L,9L,5L,4L,2L,6L,3L,5L,1L,6L,9L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016620Inst : IEnumerable<long>
{
public static readonly long[] Value=A016620.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016620.Bytes);
public long this[int i]=>Value[i];

public static A016620Inst Instance=new A016620Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016619
{
public static readonly long[] Value={ 3L,7L,4L,9L,5L,0L,4L,0L,7L,5L,9L,3L,0L,3L,7L,1L,1L,4L,5L,4L,3L,3L,0L,6L,1L,8L,2L,9L,6L,4L,1L,1L,3L,7L,6L,0L,7L,0L,3L,8L,3L,0L,4L,2L,3L,2L,4L,9L,4L,0L,0L,7L,2L,5L,5L,0L,8L,9L,2L,0L,5L,6L,1L,9L,8L,6L,3L,0L,7L,7L,9L,4L,1L,5L,3L,8L,8L,9L,4L,3L,2L,9L,9L,3L,6L,3L,6L,5L,4L,1L,9L,1L,3L,4L,2L,6L,3L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016619Inst : IEnumerable<long>
{
public static readonly long[] Value=A016619.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016619.Bytes);
public long this[int i]=>Value[i];

public static A016619Inst Instance=new A016619Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016618
{
public static readonly long[] Value={ 3L,7L,2L,5L,6L,9L,3L,4L,2L,7L,2L,3L,6L,6L,5L,2L,6L,1L,4L,0L,5L,8L,2L,4L,0L,1L,0L,1L,8L,3L,3L,1L,9L,3L,8L,8L,4L,9L,5L,3L,8L,1L,2L,9L,2L,2L,3L,0L,2L,9L,8L,1L,1L,1L,6L,0L,6L,7L,2L,6L,3L,4L,5L,3L,4L,4L,5L,1L,8L,5L,3L,6L,7L,9L,1L,9L,2L,9L,5L,8L,9L,0L,2L,3L,2L,5L,6L,3L,9L,6L,9L,9L,7L,4L,1L,5L,4L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016618Inst : IEnumerable<long>
{
public static readonly long[] Value=A016618.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016618.Bytes);
public long this[int i]=>Value[i];

public static A016618Inst Instance=new A016618Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016617
{
public static readonly long[] Value={ 3L,7L,0L,1L,3L,0L,1L,9L,7L,4L,1L,1L,2L,4L,9L,3L,4L,5L,6L,1L,6L,3L,7L,4L,8L,8L,2L,6L,2L,3L,1L,9L,2L,6L,2L,5L,0L,5L,1L,4L,4L,6L,2L,0L,9L,6L,9L,3L,0L,7L,4L,2L,5L,5L,2L,8L,1L,8L,0L,9L,7L,3L,2L,5L,0L,5L,6L,5L,8L,3L,5L,5L,0L,9L,0L,4L,7L,4L,1L,1L,5L,1L,8L,8L,8L,5L,9L,9L,6L,9L,2L,2L,5L,8L,5L,0L,9L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016617Inst : IEnumerable<long>
{
public static readonly long[] Value=A016617.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016617.Bytes);
public long this[int i]=>Value[i];

public static A016617Inst Instance=new A016617Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016616
{
public static readonly long[] Value={ 3L,6L,7L,6L,3L,0L,0L,6L,7L,1L,9L,0L,7L,0L,7L,6L,1L,8L,4L,7L,5L,5L,7L,1L,3L,4L,2L,0L,0L,2L,3L,2L,3L,4L,3L,5L,4L,0L,9L,8L,0L,4L,1L,0L,9L,0L,0L,6L,2L,3L,5L,4L,3L,7L,1L,2L,9L,1L,4L,9L,1L,1L,0L,8L,0L,6L,6L,4L,1L,2L,4L,3L,9L,1L,5L,4L,7L,3L,7L,5L,6L,2L,5L,4L,0L,0L,7L,7L,0L,3L,8L,7L,7L,7L,6L,6L,0L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016616Inst : IEnumerable<long>
{
public static readonly long[] Value=A016616.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016616.Bytes);
public long this[int i]=>Value[i];

public static A016616Inst Instance=new A016616Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016615
{
public static readonly long[] Value={ 3L,6L,5L,0L,6L,5L,8L,2L,4L,1L,2L,9L,3L,7L,3L,8L,5L,3L,9L,7L,5L,0L,0L,6L,4L,1L,9L,9L,9L,5L,0L,1L,3L,2L,4L,6L,1L,3L,8L,3L,2L,9L,1L,4L,4L,9L,1L,5L,9L,0L,2L,3L,1L,0L,9L,5L,5L,7L,2L,7L,7L,8L,4L,9L,5L,7L,4L,7L,5L,9L,8L,6L,4L,6L,9L,5L,6L,1L,1L,2L,6L,5L,2L,5L,6L,8L,4L,9L,8L,7L,9L,5L,9L,4L,0L,8L,7L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016615Inst : IEnumerable<long>
{
public static readonly long[] Value=A016615.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016615.Bytes);
public long this[int i]=>Value[i];

public static A016615Inst Instance=new A016615Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016614
{
public static readonly long[] Value={ 3L,6L,2L,4L,3L,4L,0L,9L,3L,2L,9L,7L,6L,3L,6L,5L,1L,3L,1L,1L,7L,9L,5L,3L,1L,7L,8L,1L,9L,1L,6L,7L,2L,4L,4L,1L,5L,6L,2L,3L,1L,9L,3L,1L,3L,1L,9L,9L,9L,5L,2L,9L,6L,4L,1L,4L,3L,9L,3L,1L,0L,1L,0L,7L,0L,9L,2L,4L,5L,8L,6L,4L,6L,6L,6L,4L,2L,2L,9L,7L,8L,0L,5L,2L,8L,0L,2L,0L,1L,8L,4L,0L,0L,3L,6L,7L,2L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016614Inst : IEnumerable<long>
{
public static readonly long[] Value=A016614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016614.Bytes);
public long this[int i]=>Value[i];

public static A016614Inst Instance=new A016614Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016613
{
public static readonly long[] Value={ 3L,5L,9L,7L,3L,1L,2L,2L,6L,0L,5L,8L,8L,4L,4L,5L,8L,1L,9L,6L,7L,4L,8L,7L,6L,7L,3L,5L,9L,8L,0L,3L,6L,6L,0L,0L,2L,8L,2L,9L,2L,5L,2L,7L,1L,0L,5L,1L,1L,3L,4L,2L,4L,1L,0L,4L,7L,5L,0L,1L,8L,8L,4L,7L,6L,6L,8L,3L,9L,6L,3L,5L,3L,9L,5L,0L,9L,0L,2L,5L,7L,7L,6L,7L,0L,4L,6L,5L,9L,9L,5L,8L,3L,8L,4L,4L,0L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016613Inst : IEnumerable<long>
{
public static readonly long[] Value=A016613.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016613.Bytes);
public long this[int i]=>Value[i];

public static A016613Inst Instance=new A016613Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016612
{
public static readonly long[] Value={ 3L,5L,6L,9L,5L,3L,2L,6L,9L,6L,4L,8L,1L,3L,7L,0L,1L,1L,1L,9L,1L,2L,2L,2L,2L,4L,1L,1L,0L,5L,4L,8L,5L,7L,5L,2L,8L,6L,8L,4L,0L,7L,6L,3L,9L,2L,3L,5L,0L,3L,1L,0L,8L,5L,4L,0L,0L,0L,7L,4L,5L,7L,9L,2L,5L,3L,3L,9L,5L,7L,8L,8L,4L,8L,5L,4L,5L,3L,5L,6L,5L,0L,3L,6L,0L,3L,7L,9L,9L,9L,7L,2L,7L,6L,2L,1L,6L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016612Inst : IEnumerable<long>
{
public static readonly long[] Value=A016612.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016612.Bytes);
public long this[int i]=>Value[i];

public static A016612Inst Instance=new A016612Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016611
{
public static readonly long[] Value={ 3L,5L,4L,0L,9L,5L,9L,3L,2L,4L,0L,3L,7L,3L,1L,4L,0L,7L,2L,7L,8L,4L,7L,6L,5L,9L,4L,7L,2L,7L,4L,5L,4L,5L,2L,5L,5L,0L,1L,4L,3L,7L,0L,7L,3L,8L,3L,0L,2L,9L,2L,9L,9L,3L,9L,6L,1L,2L,6L,4L,9L,7L,0L,1L,6L,2L,7L,0L,9L,3L,9L,1L,7L,2L,3L,3L,7L,1L,2L,5L,4L,9L,4L,6L,6L,1L,5L,3L,5L,1L,9L,9L,7L,0L,3L,0L,8L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016611Inst : IEnumerable<long>
{
public static readonly long[] Value=A016611.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016611.Bytes);
public long this[int i]=>Value[i];

public static A016611Inst Instance=new A016611Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016610
{
public static readonly long[] Value={ 3L,5L,1L,1L,5L,4L,5L,4L,3L,8L,8L,3L,1L,0L,2L,0L,7L,5L,0L,2L,5L,2L,8L,3L,9L,8L,7L,4L,9L,0L,5L,5L,4L,6L,1L,8L,2L,4L,9L,1L,4L,3L,2L,7L,6L,8L,8L,6L,1L,6L,4L,0L,0L,8L,3L,0L,1L,7L,1L,0L,4L,1L,2L,1L,2L,8L,1L,8L,7L,4L,8L,8L,3L,5L,5L,8L,3L,9L,2L,1L,8L,1L,0L,3L,3L,0L,5L,0L,8L,6L,0L,8L,2L,4L,6L,0L,6L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016610Inst : IEnumerable<long>
{
public static readonly long[] Value=A016610.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016610.Bytes);
public long this[int i]=>Value[i];

public static A016610Inst Instance=new A016610Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016609
{
public static readonly long[] Value={ 3L,4L,8L,1L,2L,4L,0L,0L,8L,9L,3L,3L,5L,6L,9L,1L,8L,0L,1L,2L,3L,7L,0L,1L,4L,6L,5L,3L,3L,3L,3L,3L,2L,9L,6L,7L,6L,2L,5L,5L,3L,6L,9L,1L,6L,4L,6L,6L,8L,4L,6L,9L,5L,8L,4L,2L,1L,1L,0L,1L,3L,3L,9L,2L,6L,4L,4L,2L,5L,0L,0L,3L,3L,0L,6L,2L,3L,7L,3L,2L,2L,8L,4L,2L,3L,8L,4L,5L,2L,1L,4L,5L,3L,7L,2L,5L,0L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016609Inst : IEnumerable<long>
{
public static readonly long[] Value=A016609.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016609.Bytes);
public long this[int i]=>Value[i];

public static A016609Inst Instance=new A016609Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016608
{
public static readonly long[] Value={ 3L,4L,4L,9L,9L,8L,7L,5L,4L,5L,8L,3L,1L,5L,8L,7L,3L,7L,8L,4L,7L,8L,6L,1L,1L,0L,9L,5L,8L,3L,0L,0L,5L,4L,5L,7L,0L,8L,5L,6L,5L,6L,5L,7L,1L,0L,8L,6L,7L,1L,0L,4L,8L,3L,7L,8L,0L,8L,0L,9L,8L,8L,0L,7L,7L,1L,9L,1L,7L,4L,8L,2L,7L,2L,1L,9L,5L,9L,2L,4L,8L,5L,9L,2L,9L,0L,2L,6L,6L,8L,1L,2L,1L,8L,9L,1L,7L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016608Inst : IEnumerable<long>
{
public static readonly long[] Value=A016608.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016608.Bytes);
public long this[int i]=>Value[i];

public static A016608Inst Instance=new A016608Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016607
{
public static readonly long[] Value={ 3L,4L,1L,7L,7L,2L,6L,6L,8L,3L,6L,1L,3L,3L,6L,5L,9L,3L,9L,3L,3L,4L,1L,5L,6L,9L,8L,1L,9L,6L,7L,4L,3L,8L,1L,7L,8L,2L,4L,0L,1L,8L,1L,6L,0L,8L,7L,2L,1L,0L,0L,5L,8L,0L,8L,8L,1L,6L,7L,0L,3L,6L,3L,6L,9L,2L,6L,0L,4L,6L,1L,8L,4L,8L,7L,5L,2L,5L,4L,0L,1L,5L,5L,7L,9L,5L,6L,5L,8L,7L,9L,1L,0L,3L,6L,8L,5L,0L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016607Inst : IEnumerable<long>
{
public static readonly long[] Value=A016607.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016607.Bytes);
public long this[int i]=>Value[i];

public static A016607Inst Instance=new A016607Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016606
{
public static readonly long[] Value={ 3L,3L,8L,4L,3L,9L,0L,2L,6L,3L,3L,4L,5L,7L,7L,4L,1L,4L,1L,1L,9L,8L,8L,1L,8L,2L,5L,2L,2L,6L,1L,5L,2L,1L,0L,5L,5L,9L,8L,7L,8L,4L,6L,6L,5L,4L,9L,7L,0L,1L,9L,9L,2L,7L,5L,3L,9L,1L,3L,5L,6L,6L,8L,7L,5L,6L,5L,8L,0L,6L,4L,9L,2L,2L,9L,5L,7L,3L,2L,7L,6L,1L,7L,5L,3L,4L,7L,6L,6L,3L,2L,8L,0L,6L,2L,1L,5L,0L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016606Inst : IEnumerable<long>
{
public static readonly long[] Value=A016606.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016606.Bytes);
public long this[int i]=>Value[i];

public static A016606Inst Instance=new A016606Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016589
{
public static readonly long[] Value={ 2L,5L,2L,5L,7L,2L,8L,6L,4L,4L,3L,0L,8L,2L,5L,5L,4L,3L,9L,7L,8L,4L,2L,8L,6L,5L,4L,4L,9L,9L,4L,1L,9L,8L,7L,1L,0L,9L,7L,5L,7L,0L,2L,5L,7L,4L,1L,7L,6L,7L,8L,0L,1L,8L,9L,7L,0L,4L,6L,1L,5L,7L,7L,3L,4L,5L,4L,9L,6L,4L,3L,5L,3L,4L,4L,5L,6L,2L,0L,8L,1L,3L,6L,5L,4L,4L,0L,4L,4L,2L,9L,1L,8L,9L,9L,4L,0L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016589Inst : IEnumerable<long>
{
public static readonly long[] Value=A016589.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016589.Bytes);
public long this[int i]=>Value[i];

public static A016589Inst Instance=new A016589Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016588
{
public static readonly long[] Value={ 2L,4L,4L,2L,3L,4L,7L,0L,3L,5L,3L,6L,9L,2L,0L,4L,3L,8L,1L,3L,8L,9L,5L,2L,0L,7L,1L,0L,3L,5L,2L,0L,1L,9L,5L,5L,0L,3L,6L,6L,8L,8L,0L,1L,8L,0L,4L,8L,0L,1L,8L,0L,4L,8L,7L,8L,7L,7L,9L,5L,5L,3L,6L,7L,9L,8L,9L,5L,9L,9L,6L,2L,4L,0L,1L,5L,1L,0L,3L,5L,8L,2L,5L,9L,2L,5L,3L,7L,7L,6L,5L,1L,5L,6L,5L,7L,6L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016588Inst : IEnumerable<long>
{
public static readonly long[] Value=A016588.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016588.Bytes);
public long this[int i]=>Value[i];

public static A016588Inst Instance=new A016588Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016587
{
public static readonly long[] Value={ 2L,3L,5L,1L,3L,7L,5L,2L,5L,7L,1L,6L,3L,4L,7L,7L,6L,8L,7L,0L,8L,3L,3L,6L,5L,8L,5L,8L,9L,0L,7L,5L,2L,8L,8L,6L,6L,2L,0L,9L,0L,7L,5L,1L,5L,3L,0L,4L,4L,3L,5L,5L,3L,8L,6L,0L,7L,3L,4L,0L,4L,4L,7L,4L,0L,8L,1L,6L,8L,0L,5L,3L,4L,0L,0L,0L,9L,8L,3L,5L,1L,9L,0L,5L,5L,4L,1L,0L,9L,2L,6L,4L,0L,5L,1L,8L,4L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016587Inst : IEnumerable<long>
{
public static readonly long[] Value=A016587.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016587.Bytes);
public long this[int i]=>Value[i];

public static A016587Inst Instance=new A016587Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016586
{
public static readonly long[] Value={ 2L,2L,5L,1L,2L,9L,1L,7L,9L,8L,6L,0L,6L,4L,9L,5L,1L,5L,0L,5L,9L,1L,7L,9L,5L,3L,1L,0L,4L,2L,9L,6L,7L,6L,9L,6L,9L,1L,6L,1L,8L,7L,9L,1L,2L,6L,9L,3L,8L,8L,7L,3L,5L,6L,4L,4L,1L,7L,2L,8L,0L,2L,2L,6L,9L,1L,5L,8L,9L,9L,0L,8L,0L,0L,9L,4L,5L,0L,2L,5L,7L,3L,1L,0L,8L,2L,9L,5L,0L,5L,6L,8L,1L,9L,3L,2L,1L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016586Inst : IEnumerable<long>
{
public static readonly long[] Value=A016586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016586.Bytes);
public long this[int i]=>Value[i];

public static A016586Inst Instance=new A016586Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016585
{
public static readonly long[] Value={ 2L,1L,4L,0L,0L,6L,6L,1L,6L,3L,4L,9L,6L,2L,7L,0L,7L,7L,0L,8L,3L,2L,3L,0L,2L,4L,9L,6L,4L,1L,4L,9L,4L,9L,9L,6L,7L,5L,1L,2L,7L,0L,2L,8L,7L,8L,2L,2L,5L,4L,8L,9L,5L,3L,3L,1L,7L,6L,5L,5L,7L,7L,2L,8L,3L,8L,8L,8L,9L,8L,9L,5L,3L,8L,3L,1L,2L,3L,6L,5L,6L,5L,3L,0L,6L,2L,3L,1L,5L,4L,1L,0L,4L,1L,0L,8L,4L,2L,5L,9L,9L,7L,6L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016585Inst : IEnumerable<long>
{
public static readonly long[] Value=A016585.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016585.Bytes);
public long this[int i]=>Value[i];

public static A016585Inst Instance=new A016585Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016584
{
public static readonly long[] Value={ 2L,0L,1L,4L,9L,0L,3L,0L,2L,0L,5L,4L,2L,2L,6L,4L,7L,5L,6L,5L,7L,8L,7L,7L,2L,4L,4L,8L,6L,9L,0L,5L,3L,6L,7L,7L,6L,0L,9L,7L,5L,9L,1L,7L,7L,7L,7L,3L,1L,0L,1L,1L,9L,1L,9L,5L,2L,6L,6L,6L,2L,2L,1L,5L,6L,1L,8L,2L,7L,9L,6L,5L,8L,9L,5L,6L,5L,7L,2L,0L,1L,5L,8L,9L,7L,8L,8L,6L,3L,0L,5L,9L,1L,0L,4L,9L,3L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016584Inst : IEnumerable<long>
{
public static readonly long[] Value=A016584.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016584.Bytes);
public long this[int i]=>Value[i];

public static A016584Inst Instance=new A016584Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016583
{
public static readonly long[] Value={ 1L,8L,7L,1L,8L,0L,2L,1L,7L,6L,9L,0L,1L,5L,9L,1L,4L,2L,6L,6L,3L,6L,2L,5L,5L,3L,2L,0L,1L,0L,7L,1L,4L,2L,0L,3L,6L,7L,2L,9L,7L,6L,7L,8L,1L,0L,3L,9L,9L,9L,5L,1L,8L,6L,2L,2L,9L,8L,3L,6L,5L,5L,0L,1L,1L,7L,0L,0L,7L,1L,0L,4L,5L,3L,5L,4L,7L,1L,5L,4L,6L,3L,7L,9L,3L,7L,1L,1L,3L,3L,6L,4L,4L,4L,0L,7L,0L,8L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016583Inst : IEnumerable<long>
{
public static readonly long[] Value=A016583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016583.Bytes);
public long this[int i]=>Value[i];

public static A016583Inst Instance=new A016583Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016582
{
public static readonly long[] Value={ 1L,7L,0L,4L,7L,4L,8L,0L,9L,2L,2L,3L,8L,4L,2L,5L,2L,3L,4L,6L,4L,4L,7L,1L,1L,4L,5L,6L,5L,0L,6L,9L,5L,2L,7L,3L,1L,7L,4L,6L,2L,0L,6L,7L,1L,9L,5L,7L,7L,1L,6L,1L,9L,2L,1L,0L,9L,7L,8L,8L,7L,6L,9L,9L,6L,3L,7L,1L,8L,0L,0L,0L,1L,9L,4L,3L,5L,4L,1L,9L,9L,7L,4L,6L,9L,1L,9L,1L,3L,8L,1L,0L,0L,6L,2L,1L,6L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016582Inst : IEnumerable<long>
{
public static readonly long[] Value=A016582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016582.Bytes);
public long this[int i]=>Value[i];

public static A016582Inst Instance=new A016582Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016581
{
public static readonly long[] Value={ 1L,5L,0L,4L,0L,7L,7L,3L,9L,6L,7L,7L,6L,2L,7L,4L,0L,7L,3L,3L,7L,3L,2L,5L,8L,3L,5L,2L,3L,8L,6L,8L,7L,4L,8L,4L,1L,2L,1L,9L,4L,8L,0L,9L,8L,1L,2L,8L,5L,2L,4L,3L,6L,4L,9L,3L,4L,8L,7L,0L,8L,6L,5L,7L,7L,8L,1L,5L,9L,4L,9L,6L,4L,4L,6L,7L,5L,2L,3L,2L,1L,8L,1L,4L,1L,3L,6L,8L,1L,8L,2L,6L,3L,1L,0L,4L,5L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016581Inst : IEnumerable<long>
{
public static readonly long[] Value=A016581.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016581.Bytes);
public long this[int i]=>Value[i];

public static A016581Inst Instance=new A016581Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016580
{
public static readonly long[] Value={ 1L,2L,5L,2L,7L,6L,2L,9L,6L,8L,4L,9L,5L,3L,6L,7L,9L,9L,5L,6L,8L,8L,1L,2L,0L,6L,2L,1L,9L,8L,5L,0L,0L,3L,1L,6L,1L,5L,6L,1L,5L,8L,4L,5L,9L,5L,2L,2L,1L,6L,0L,5L,9L,3L,4L,3L,3L,8L,7L,1L,0L,1L,4L,0L,4L,4L,4L,1L,8L,6L,2L,4L,0L,7L,8L,2L,3L,7L,4L,5L,5L,2L,1L,8L,1L,7L,9L,5L,1L,7L,1L,5L,9L,1L,4L,5L,2L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016580Inst : IEnumerable<long>
{
public static readonly long[] Value=A016580.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016580.Bytes);
public long this[int i]=>Value[i];

public static A016580Inst Instance=new A016580Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016579
{
public static readonly long[] Value={ 9L,1L,6L,2L,9L,0L,7L,3L,1L,8L,7L,4L,1L,5L,5L,0L,6L,5L,1L,8L,3L,5L,2L,7L,2L,1L,1L,7L,6L,8L,0L,1L,1L,0L,7L,1L,4L,5L,0L,1L,0L,1L,2L,1L,9L,9L,0L,8L,2L,6L,2L,4L,6L,7L,7L,9L,1L,9L,6L,7L,8L,8L,1L,9L,8L,0L,7L,8L,5L,3L,6L,5L,7L,3L,7L,9L,6L,3L,0L,4L,9L,0L,2L,4L,2L,7L,0L,5L,5L,1L,0L,9L,6L,7L,6L,0L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016579Inst : IEnumerable<long>
{
public static readonly long[] Value=A016579.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016579.Bytes);
public long this[int i]=>Value[i];

public static A016579Inst Instance=new A016579Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016578
{
public static readonly long[] Value={ 4L,0L,5L,4L,6L,5L,1L,0L,8L,1L,0L,8L,1L,6L,4L,3L,8L,1L,9L,7L,8L,0L,1L,3L,1L,1L,5L,4L,6L,4L,3L,4L,9L,1L,3L,6L,5L,7L,1L,9L,9L,0L,4L,2L,3L,4L,6L,2L,4L,9L,4L,1L,9L,7L,6L,1L,4L,0L,1L,4L,3L,2L,4L,1L,4L,4L,1L,0L,0L,6L,7L,1L,2L,4L,8L,9L,1L,4L,2L,5L,1L,2L,6L,7L,7L,5L,2L,4L,2L,7L,8L,1L,7L,3L,1L,3L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016578Inst : IEnumerable<long>
{
public static readonly long[] Value=A016578.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016578.Bytes);
public long this[int i]=>Value[i];

public static A016578Inst Instance=new A016578Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016577
{
public static readonly long[] Value={ 3L,1L,9L,4L,1L,31L,1L,1L,5L,7L,4L,2L,6L,2L,1L,5L,14L,2L,4L,1L,1L,3L,1L,22L,2L,3L,2L,2L,2L,1L,12L,2L,1L,1L,1L,1L,1L,2L,6L,2L,2L,4L,1L,7L,2L,1L,9L,27L,2L,1L,14L,6L,1L,4L,6L,2L,48L,2L,7L,17L,10L,1L,1L,4L,2L,2L,2L,2L,5L,7L,1L,19L,1L,1L,1L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016577Inst : IEnumerable<long>
{
public static readonly long[] Value=A016577.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016577.Bytes);
public long this[int i]=>Value[i];

public static A016577Inst Instance=new A016577Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016576
{
public static readonly long[] Value={ 3L,1L,7L,2L,3L,1L,10L,1L,1L,1L,6L,1L,5L,32L,2L,1L,1L,10L,1L,3L,1L,1L,2L,3L,1L,32L,1L,1L,3L,18L,1L,3L,2L,1L,8L,1L,3L,1L,60L,1L,1L,1L,2L,6L,2L,1L,4L,1L,159L,1L,3L,1L,1L,1L,1L,1L,1L,8L,1L,52L,1L,1L,2L,29L,1L,2L,22L,5L,11L,3L,3L,2L,1L,1L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016576Inst : IEnumerable<long>
{
public static readonly long[] Value=A016576.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016576.Bytes);
public long this[int i]=>Value[i];

public static A016576Inst Instance=new A016576Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016575
{
public static readonly long[] Value={ 3L,1L,6L,5L,1L,1L,4L,1L,5L,11L,1L,1L,3L,1L,2L,1L,2L,1L,1L,1L,19L,2L,1L,1L,1L,3L,2L,8L,5L,1L,1L,1L,1L,4L,6L,1L,1L,2L,191L,4L,1L,14L,1L,1L,1L,1L,17L,2L,4L,9L,1L,2L,2L,3L,1L,31L,2L,2L,1L,3L,3L,1L,21L,101L,2L,1L,1L,1L,3L,2L,2L,7L,6L,2L,6L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016575Inst : IEnumerable<long>
{
public static readonly long[] Value=A016575.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016575.Bytes);
public long this[int i]=>Value[i];

public static A016575Inst Instance=new A016575Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016574
{
public static readonly long[] Value={ 3L,1L,5L,4L,2L,1L,2L,7L,4L,1L,1L,12L,22L,1L,2L,2L,6L,16L,10L,1L,2L,129L,1L,1L,7L,1L,96L,1L,2L,3L,8L,1L,2L,1L,5L,5L,4L,1L,7L,2L,1L,1L,406L,1L,18L,1L,1L,2L,1L,17L,1L,2L,3L,15L,1L,1L,1L,1L,3L,6L,1L,1L,20L,1L,1L,1L,1L,5L,1L,11L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016574Inst : IEnumerable<long>
{
public static readonly long[] Value=A016574.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016574.Bytes);
public long this[int i]=>Value[i];

public static A016574Inst Instance=new A016574Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016573
{
public static readonly long[] Value={ 3L,1L,4L,2L,17L,6L,1L,2L,1L,4L,34L,1L,1L,1L,2L,5L,1L,4L,2L,1L,1L,2L,30L,2L,7L,4L,5L,2L,1L,2L,1L,2L,3L,1L,1L,1L,9L,6L,2L,5L,1L,7L,2L,1L,1L,1L,2L,1L,1L,4L,1L,3L,1L,13L,1L,5L,1L,7L,3L,1L,1L,1L,2L,37L,3L,1L,20L,1L,11L,1L,7L,1L,2L,1L,1L,18L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016573Inst : IEnumerable<long>
{
public static readonly long[] Value=A016573.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016573.Bytes);
public long this[int i]=>Value[i];

public static A016573Inst Instance=new A016573Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016572
{
public static readonly long[] Value={ 3L,1L,3L,1L,8L,14L,1L,3L,1L,9L,2L,9L,22L,59L,11L,1L,2L,3L,2L,5L,3L,3L,4L,1L,7L,1L,65L,1L,6L,1L,3L,1L,7L,1L,2L,2L,1L,30L,1L,1L,1L,1L,1L,50L,1L,1L,1L,1L,4L,13L,13L,4L,1L,23L,1L,2L,2L,8L,1L,2L,2L,3L,2L,2L,3L,1L,1L,1L,8L,1L,4L,1L,1L,3L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016572Inst : IEnumerable<long>
{
public static readonly long[] Value=A016572.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016572.Bytes);
public long this[int i]=>Value[i];

public static A016572Inst Instance=new A016572Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016571
{
public static readonly long[] Value={ 3L,1L,3L,2L,2L,60L,1L,26L,15L,1L,1L,4L,1L,1L,2L,2L,3L,1L,1L,1L,5L,1L,8L,2L,1L,1L,1L,4L,3L,21L,2L,1L,6L,1L,3L,1L,7L,6L,29L,1L,1L,14L,2L,19L,2L,3L,2L,2L,3L,2L,3L,1L,1L,1L,1L,4L,3L,1L,7L,1L,2L,4L,17L,5L,1L,3L,14L,2L,97L,1L,8L,3L,1L,9L,1L,5L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016571Inst : IEnumerable<long>
{
public static readonly long[] Value=A016571.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016571.Bytes);
public long this[int i]=>Value[i];

public static A016571Inst Instance=new A016571Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016570
{
public static readonly long[] Value={ 3L,1L,2L,1L,125L,3L,1L,1L,1L,1L,6L,1L,2L,1L,2L,1L,2L,1L,5L,20L,1L,1L,1L,2L,3L,6L,2L,1L,8L,19L,1L,62L,1L,1L,6L,2L,3L,6L,2L,6L,1L,1L,1L,1L,1L,5L,6L,7L,8L,3L,2L,8L,8L,1L,6L,3L,4L,1L,11L,1L,1L,1L,1L,3L,7L,4L,1L,2L,1L,4L,1L,2L,7L,1L,14L,22L,76L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016570Inst : IEnumerable<long>
{
public static readonly long[] Value=A016570.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016570.Bytes);
public long this[int i]=>Value[i];

public static A016570Inst Instance=new A016570Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016569
{
public static readonly long[] Value={ 3L,1L,2L,1L,1L,1L,4L,1L,1L,2L,11L,2L,5L,1L,3L,30L,1L,4L,1L,13L,2L,2L,2L,1L,1L,3L,4L,14L,13L,2L,1L,1L,1L,1L,1L,10L,1L,2L,1L,23L,1L,2L,2L,17L,1L,1L,3L,52L,1L,32L,1L,1L,1L,3L,2L,1L,2L,1L,1L,1L,8L,6L,1L,2L,1L,6L,1L,15L,2L,2L,1L,6L,3L,7L,35L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016569Inst : IEnumerable<long>
{
public static readonly long[] Value=A016569.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016569.Bytes);
public long this[int i]=>Value[i];

public static A016569Inst Instance=new A016569Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016568
{
public static readonly long[] Value={ 3L,1L,2L,2L,1L,6L,1L,50L,1L,1L,1L,45L,1L,3L,4L,1L,1L,5L,27L,1L,10L,1L,1L,1L,1L,18L,1L,27L,7L,1L,1L,1L,3L,1L,49L,2L,9L,1L,20L,1L,5L,2L,1L,1L,2L,7L,3L,1L,36L,1L,2L,6L,1L,3L,26L,1L,54L,18L,1L,9L,4L,3L,1L,1L,16L,1L,1L,4L,1L,5L,4L,2L,2L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016568Inst : IEnumerable<long>
{
public static readonly long[] Value=A016568.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016568.Bytes);
public long this[int i]=>Value[i];

public static A016568Inst Instance=new A016568Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016567
{
public static readonly long[] Value={ 3L,1L,2L,11L,5L,355L,1L,2L,1L,4L,2L,1L,1L,1L,2L,1L,2L,1L,1L,2L,8L,1L,2L,3L,2L,1L,3L,5L,4L,1L,11L,2L,3L,3L,1L,4L,2L,2L,1L,1L,15L,28L,5L,1L,2L,8L,2L,1L,6L,2L,6L,1L,13L,1L,1L,5L,8L,1L,2L,1L,5L,18L,1L,58L,2L,62L,1L,16L,5L,1L,1L,1L,1L,2L,5L,1L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016567Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016567.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016567Inst : IEnumerable<long>
{
public static readonly long[] Value=A016567.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016567.Bytes);
public long this[int i]=>Value[i];

public static A016567Inst Instance=new A016567Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016566
{
public static readonly long[] Value={ 3L,1L,1L,1L,6L,3L,1L,1L,1L,5L,3L,1L,1L,96L,1L,1L,2L,2L,3L,2L,3L,2L,32L,1L,1L,1L,10L,7L,2L,8L,2L,5L,11L,1L,1L,2L,3L,1L,3L,1L,6L,5L,11L,2L,6L,3L,3L,1L,1L,3L,1L,2L,1L,1L,2L,2L,8L,3L,1L,2L,1L,1L,1L,5L,6L,1L,4L,3L,187L,1L,3L,1L,6L,1L,1L,1L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016566Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016566.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016566Inst : IEnumerable<long>
{
public static readonly long[] Value=A016566.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016566.Bytes);
public long this[int i]=>Value[i];

public static A016566Inst Instance=new A016566Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016565
{
public static readonly long[] Value={ 3L,1L,1L,1L,1L,1L,23L,12L,11L,1L,15L,2L,15L,1L,1L,1L,1L,12L,1L,1L,1L,6L,2L,1L,2L,3L,1L,18L,1L,1L,3L,65L,26L,3L,3L,3L,1L,3L,101L,1L,1L,9L,1L,2L,3L,5L,1L,12L,2L,16L,1L,10L,1L,24L,5L,1L,1L,2L,3L,2L,6L,2L,10L,18L,1L,1L,2L,1L,25L,4L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016565Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016565.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016565Inst : IEnumerable<long>
{
public static readonly long[] Value=A016565.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016565.Bytes);
public long this[int i]=>Value[i];

public static A016565Inst Instance=new A016565Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016564
{
public static readonly long[] Value={ 3L,1L,1L,2L,14L,2L,13L,1L,2L,2L,1L,14L,1L,106L,2L,1L,3L,5L,1L,51L,1L,1L,2L,4L,1L,13L,1L,6L,1L,1L,18L,1L,2L,1L,1L,3L,33L,3L,1L,3L,1L,3L,5L,8L,1L,126L,1L,9L,1L,1L,16L,4L,1L,2L,1L,4L,7L,1L,1L,17L,1L,1L,3L,1L,2L,6L,1L,3L,1L,2L,1L,1L,2L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016564Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016564.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016564Inst : IEnumerable<long>
{
public static readonly long[] Value=A016564.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016564.Bytes);
public long this[int i]=>Value[i];

public static A016564Inst Instance=new A016564Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016563
{
public static readonly long[] Value={ 3L,1L,1L,3L,10L,2L,11L,3L,2L,4L,1L,4L,4L,2L,32L,1L,3L,1L,50L,3L,4L,1L,1L,3L,1L,1L,1L,3L,1L,3L,2L,3L,3L,17L,1L,4L,5L,3L,5L,1L,6L,3L,1L,5L,1L,10L,2L,1L,4L,3L,1L,3L,3L,1L,3L,2L,1L,2L,9L,26L,1L,1L,20L,1L,1L,5L,1L,1L,4L,1L,2L,5L,1L,3L,5L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016563Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016563.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016563Inst : IEnumerable<long>
{
public static readonly long[] Value=A016563.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016563.Bytes);
public long this[int i]=>Value[i];

public static A016563Inst Instance=new A016563Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016562
{
public static readonly long[] Value={ 3L,1L,1L,5L,1L,1L,1L,1L,10L,2L,5L,1L,7L,1L,32L,18L,2L,9L,1L,1L,1L,29L,1L,1L,2L,50L,1L,29L,1L,1L,10L,1L,1L,3L,1L,1L,1L,2L,1L,1L,1L,3L,2L,3L,1L,2L,3L,1L,1L,6L,2L,4L,1L,4L,1L,10L,1L,40L,4L,2L,3L,1L,1L,12L,2L,28L,17L,1L,2L,18L,7L,1L,1L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016562Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016562.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016562Inst : IEnumerable<long>
{
public static readonly long[] Value=A016562.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016562.Bytes);
public long this[int i]=>Value[i];

public static A016562Inst Instance=new A016562Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016561
{
public static readonly long[] Value={ 3L,1L,1L,21L,6L,1L,1L,21L,9L,2L,1L,1L,6L,1L,3L,102L,1L,1L,13L,1L,2L,1L,6L,1L,13L,5L,55L,1L,1L,1L,20L,1L,3L,1L,2L,8L,1L,2L,1L,1L,1L,6L,11L,2L,14L,1L,2L,1L,2L,1L,2L,4L,4L,3L,1L,4L,2L,23L,1L,1L,11L,10L,3L,2L,2L,9L,17L,5L,2L,1L,7L,3L,16L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016561Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016561.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016561Inst : IEnumerable<long>
{
public static readonly long[] Value=A016561.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016561.Bytes);
public long this[int i]=>Value[i];

public static A016561Inst Instance=new A016561Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016560
{
public static readonly long[] Value={ 3L,2L,12L,1L,4L,1L,3L,9L,13L,1L,1L,1L,1L,3L,1L,1L,1L,2L,2L,4L,52L,1L,1L,2L,1L,1L,2L,45L,1L,38L,60L,1L,1L,3L,100L,6L,28L,1L,3L,4L,2L,1L,91L,1L,165L,1L,5L,1L,3L,1L,1L,1L,18L,2L,1L,22L,1L,5L,5L,3L,2L,1L,1L,1L,3L,2L,4L,1L,3L,2L,1L,39L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016560Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016560.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016560Inst : IEnumerable<long>
{
public static readonly long[] Value=A016560.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016560.Bytes);
public long this[int i]=>Value[i];

public static A016560Inst Instance=new A016560Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016559
{
public static readonly long[] Value={ 3L,2L,4L,2L,200L,3L,2L,70L,51L,4L,2L,2L,7L,2L,12L,2L,1L,1L,1L,1L,1L,1L,1L,23L,80L,2L,2L,1L,7L,1L,2L,47L,1L,1L,1L,12L,1L,9L,2L,4L,1L,8L,1L,1L,1L,6L,1L,2L,2L,2L,4L,1L,11L,3L,7L,3L,1L,2L,1L,7L,1L,2L,1L,1L,2L,5L,1L,74L,1L,41L,22L,2L,21L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016559Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016559.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016559Inst : IEnumerable<long>
{
public static readonly long[] Value=A016559.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016559.Bytes);
public long this[int i]=>Value[i];

public static A016559Inst Instance=new A016559Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016558
{
public static readonly long[] Value={ 3L,2L,2L,1L,1L,5L,1L,30L,5L,1L,1L,1L,41L,1L,3L,1L,6L,8L,2L,1L,4L,2L,5L,3L,3L,376L,4L,2L,21L,4L,1L,1L,13L,13L,1L,1L,1L,15L,1L,1L,11L,2L,2L,3L,1L,5L,3L,1L,1L,4L,1L,1L,1L,3L,14L,1L,1L,1L,1L,3L,1L,4L,1L,1L,1L,2L,1L,5L,1L,1L,1L,1L,18L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016558Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016558.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016558Inst : IEnumerable<long>
{
public static readonly long[] Value=A016558.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016558.Bytes);
public long this[int i]=>Value[i];

public static A016558Inst Instance=new A016558Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016557
{
public static readonly long[] Value={ 3L,2L,1L,1L,1L,1L,25L,1L,2L,48L,1L,1L,1L,1L,1L,1L,18L,1L,60L,1L,2L,44L,1L,1L,8L,1L,1L,2L,2L,2L,1L,1L,1L,13L,157L,2L,6L,1L,1L,1L,8L,10L,4L,53L,1L,1L,1L,3L,2L,1L,2L,10L,6L,2L,1L,2L,1L,1L,1L,15L,1L,2L,2L,13L,2L,8L,2L,2L,1L,1L,2L,10L,1L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016557Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016557.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016557Inst : IEnumerable<long>
{
public static readonly long[] Value=A016557.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016557.Bytes);
public long this[int i]=>Value[i];

public static A016557Inst Instance=new A016557Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016556
{
public static readonly long[] Value={ 3L,2L,1L,6L,25L,1L,10L,1L,4L,2L,2L,3L,1L,1L,2L,2L,1L,40L,1L,2L,3L,1L,1L,2L,1L,1L,1L,4L,1L,2L,1L,1L,1L,1L,2L,2L,1L,1L,1L,5L,1L,1L,4L,1L,73L,1L,6L,1L,6L,2L,1L,11L,1L,13L,74L,1L,1L,14L,1L,5L,67L,1L,52L,1L,2L,1L,2L,3L,2L,3L,1L,2L,1L,1L,1L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016556Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016556.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016556Inst : IEnumerable<long>
{
public static readonly long[] Value=A016556.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016556.Bytes);
public long this[int i]=>Value[i];

public static A016556Inst Instance=new A016556Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016555
{
public static readonly long[] Value={ 3L,3L,5L,2L,7L,1L,2L,1L,2L,2L,1L,3L,1L,2L,10L,1L,23L,1L,1L,1L,1L,3L,1L,1L,1L,1L,4L,5L,2L,8L,2L,4L,1L,37L,2L,2L,2L,1L,2L,74L,1L,11L,2L,1L,3L,1L,6L,3L,1L,6L,136L,1L,3L,9L,1L,2L,6L,6L,12L,1L,1L,2L,1L,1L,1L,29L,1L,4L,3L,5L,2L,1L,6L,6L,1L,11L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016555Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016555.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016555Inst : IEnumerable<long>
{
public static readonly long[] Value=A016555.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016555.Bytes);
public long this[int i]=>Value[i];

public static A016555Inst Instance=new A016555Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016554
{
public static readonly long[] Value={ 3L,3L,1L,1L,1L,1L,4L,3L,1L,3L,1L,1L,2L,3L,4L,1L,4L,3L,1L,1L,4L,2L,1L,5L,6L,3L,4L,1L,7L,1L,1L,6L,2L,2L,19L,1L,4L,2L,13L,1L,3L,1L,51L,8L,1L,7L,3L,1L,64L,1L,1L,1L,1L,2L,1L,1L,2L,1L,10L,1L,1L,4L,1L,1L,1L,3L,15L,2L,1L,24L,38L,4L,1L,3L,4L,1L,186L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016554Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016554.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016554Inst : IEnumerable<long>
{
public static readonly long[] Value=A016554.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016554.Bytes);
public long this[int i]=>Value[i];

public static A016554Inst Instance=new A016554Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016553
{
public static readonly long[] Value={ 3L,4L,5L,3L,1L,2L,3L,3L,1L,5L,2L,16L,1L,90L,4L,1L,1L,2L,4L,18L,4L,2L,3L,3L,2L,1L,3L,1L,4L,1L,1L,2L,22L,138L,4L,14L,1L,1L,1L,6L,2L,1L,1L,8L,7L,1L,2L,1L,22L,2L,16L,3L,1L,1L,73L,1L,1L,1L,1L,1L,2L,9L,8L,2L,19L,3L,2L,1L,2L,1L,1L,63L,2L,2L,4L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016553Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016553.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016553Inst : IEnumerable<long>
{
public static readonly long[] Value=A016553.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016553.Bytes);
public long this[int i]=>Value[i];

public static A016553Inst Instance=new A016553Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016552
{
public static readonly long[] Value={ 3L,5L,29L,1L,17L,2L,7L,5L,1L,8L,9L,20L,1L,2L,1L,1L,1L,2L,4L,1L,4L,1L,4L,3L,1L,1L,1L,3L,1L,1L,1L,1L,5L,1L,22L,2L,2L,31L,2L,41L,1L,1L,1L,1L,2L,1L,7L,6L,3L,2L,3L,2L,1L,3L,1L,8L,1L,4L,1L,1L,1L,4L,20L,1L,1L,2L,1L,4L,1L,3L,4L,5L,1L,2L,1L,157L,1L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016552Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016552.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016552Inst : IEnumerable<long>
{
public static readonly long[] Value=A016552.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016552.Bytes);
public long this[int i]=>Value[i];

public static A016552Inst Instance=new A016552Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016551
{
public static readonly long[] Value={ 3L,6L,2L,1L,2L,2L,2L,2L,1L,1L,1L,2L,141L,2L,6L,19L,3L,4L,2L,3L,1L,4L,16L,1L,4L,3L,2L,6L,2L,1L,2L,12L,1L,1L,9L,18L,2L,1L,1L,12L,2L,1L,1L,2L,1L,13L,1L,3L,1L,6L,1L,3L,6L,1L,39L,2L,4L,2L,10L,2L,13L,2L,3L,2L,1L,2L,1L,4L,4L,3L,2L,3L,2L,1L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016551Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016551.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016551Inst : IEnumerable<long>
{
public static readonly long[] Value=A016551.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016551.Bytes);
public long this[int i]=>Value[i];

public static A016551Inst Instance=new A016551Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016550
{
public static readonly long[] Value={ 3L,8L,1L,4L,4L,16L,29L,1L,5L,2L,1L,54L,1L,18L,1L,1L,3L,16L,3L,1L,1L,1L,1L,24L,1L,2L,1L,2L,2L,1L,2L,1L,1L,1L,5L,8L,1L,2L,3L,7L,3L,1L,1L,12L,1L,2L,5L,1L,1L,3L,1L,4L,23L,186L,110L,20L,1L,7L,2L,121L,1L,5L,1L,1L,8L,1L,1L,1L,1L,1L,1L,5L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016550Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016550.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016550Inst : IEnumerable<long>
{
public static readonly long[] Value=A016550.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016550.Bytes);
public long this[int i]=>Value[i];

public static A016550Inst Instance=new A016550Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016549
{
public static readonly long[] Value={ 3L,14L,1L,2L,3L,1L,2L,703L,1L,1L,59L,1L,1L,1L,1L,3L,12L,30L,1L,3L,1L,1L,4L,2L,8L,1L,2L,8L,2L,1L,9L,7L,12L,4L,3L,1L,31L,24L,1L,9L,3L,8L,1L,1L,1L,47L,1L,15L,1L,7L,2L,1L,1L,15L,2L,3L,9L,2L,2L,54L,33L,1L,1L,2L,1L,3L,1L,2L,4L,1L,3L,1L,5L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016549Inst : IEnumerable<long>
{
public static readonly long[] Value=A016549.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016549.Bytes);
public long this[int i]=>Value[i];

public static A016549Inst Instance=new A016549Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016548
{
public static readonly long[] Value={ 3L,48L,1L,23L,1L,12L,1L,1L,19L,6L,1L,4L,15L,1440L,1L,1L,2L,1L,2L,1L,1L,1L,1L,2L,1L,5L,1L,2L,4L,1L,4L,1L,1L,4L,1L,1L,1L,26L,2L,1L,11L,4L,4L,1L,2L,1L,3L,3L,55L,26L,1L,22L,2L,1L,10L,1L,20L,5L,2L,336L,2L,1L,1L,3L,2L,1L,2L,2L,9L,1L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016548Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016548.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016548Inst : IEnumerable<long>
{
public static readonly long[] Value=A016548.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016548.Bytes);
public long this[int i]=>Value[i];

public static A016548Inst Instance=new A016548Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016547
{
public static readonly long[] Value={ 2L,1L,32L,1L,4L,132L,4L,2L,1L,3L,8L,4L,9L,20L,1L,1L,1L,2L,1L,4L,4L,1L,6L,2L,1L,7L,1L,24L,3L,1L,1L,11L,2L,8L,2L,1L,23L,1L,1L,2L,1L,17L,1L,6L,34L,2L,3L,1L,39L,2L,4L,1L,10L,9L,1L,5L,1L,33L,2L,4L,1L,4L,2L,2L,1L,14L,1L,2L,2L,1L,1L,5L,1L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016547Inst : IEnumerable<long>
{
public static readonly long[] Value=A016547.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016547.Bytes);
public long this[int i]=>Value[i];

public static A016547Inst Instance=new A016547Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016546
{
public static readonly long[] Value={ 2L,1L,11L,6L,4L,1L,5L,3L,3L,1L,1L,1L,3L,1L,1L,4L,2L,1L,5L,2L,2L,1L,12L,62L,2L,1L,1L,6L,5L,9L,1L,1L,1L,1L,1L,19L,1L,1L,1L,2L,1L,1L,1L,2L,8L,1L,73L,10L,1L,1L,1L,25L,1L,3L,10L,1L,1L,1L,1L,3L,2L,1L,9L,2L,3L,2L,4L,1L,11L,1L,1L,1L,3L,1L,6L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016546Inst : IEnumerable<long>
{
public static readonly long[] Value=A016546.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016546.Bytes);
public long this[int i]=>Value[i];

public static A016546Inst Instance=new A016546Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016545
{
public static readonly long[] Value={ 2L,1L,6L,3L,1L,8L,3L,1L,11L,3L,2L,3L,1L,1L,3L,6L,1L,950L,8L,1L,34L,1L,124L,2L,1L,2L,3L,1L,5L,1L,3L,1L,1L,5L,16L,7L,5L,2L,18L,1L,1L,11L,1L,1L,1L,4L,1L,2L,2L,4L,1L,1L,2L,12L,1L,1L,7L,1L,185L,2L,2L,38L,1L,8L,1L,710L,2L,1L,2L,1L,3L,2L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016545Inst : IEnumerable<long>
{
public static readonly long[] Value=A016545.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016545.Bytes);
public long this[int i]=>Value[i];

public static A016545Inst Instance=new A016545Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016544
{
public static readonly long[] Value={ 2L,1L,4L,11L,1L,2L,2L,1L,2L,4L,2L,1L,16L,1L,1L,18L,1L,1L,5L,1L,8L,1L,6L,2L,1L,1L,20L,14L,4L,2L,3L,5L,29L,5L,4L,4L,1L,15L,2L,2L,5L,1L,4L,654L,12L,1L,1L,1L,2L,8L,1L,2L,4L,1L,2L,6L,2L,1L,1L,4L,14L,1L,3L,1L,4L,1L,84L,1L,5L,2L,3L,1L,8L,20L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016544Inst : IEnumerable<long>
{
public static readonly long[] Value=A016544.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016544.Bytes);
public long this[int i]=>Value[i];

public static A016544Inst Instance=new A016544Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016543
{
public static readonly long[] Value={ 2L,1L,2L,1L,6L,13L,1L,2L,67L,4L,1L,1L,2L,2L,1L,3L,4L,1L,11L,2L,1L,2L,2L,1L,3L,18L,4L,4L,1L,1L,1L,1L,4L,7L,1L,3L,2L,1L,1L,1L,3L,2L,1L,1L,3L,1L,3L,1L,1L,1L,2L,8L,30L,108L,1L,1L,1L,4L,2L,8L,903L,3L,1L,2L,2L,8L,1L,1L,1L,5L,3L,1L,1L,1L,3L,126L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016543Inst : IEnumerable<long>
{
public static readonly long[] Value=A016543.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016543.Bytes);
public long this[int i]=>Value[i];

public static A016543Inst Instance=new A016543Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016542
{
public static readonly long[] Value={ 2L,1L,2L,14L,1L,1L,14L,13L,1L,86L,1L,19L,1L,5L,1L,1L,1L,5L,1L,2L,1L,1L,9L,1L,16L,1L,35L,7L,1L,2L,1L,1L,8L,1L,5L,4L,3L,2L,1L,1L,1L,7L,12L,12L,3L,1L,4L,2L,1L,1L,3L,2L,1L,4L,1L,3L,7L,1L,1L,1L,1L,4L,3L,1L,22L,1L,238L,2L,13L,1L,5L,1L,7L,6L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016542Inst : IEnumerable<long>
{
public static readonly long[] Value=A016542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016542.Bytes);
public long this[int i]=>Value[i];

public static A016542Inst Instance=new A016542Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016541
{
public static readonly long[] Value={ 2L,1L,1L,1L,1L,14L,3L,1L,2L,7L,6L,1L,1L,1L,1L,1L,4L,1L,1L,1L,13L,1L,1L,1L,1L,1L,202L,1L,1L,1L,8L,1L,1L,4L,1L,1L,1L,3L,4L,1L,6L,1L,18L,17L,1L,1L,1L,2L,10L,30L,1L,1L,1L,1L,1L,3L,15L,5L,5L,5L,4L,12L,1L,1L,1L,1L,1L,2L,2L,2L,1L,1L,6L,1L,12L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016541Inst : IEnumerable<long>
{
public static readonly long[] Value=A016541.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016541.Bytes);
public long this[int i]=>Value[i];

public static A016541Inst Instance=new A016541Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016540
{
public static readonly long[] Value={ 2L,1L,1L,9L,4L,1L,1L,1L,1L,2L,1L,1L,3L,8L,1L,31L,3L,1L,12L,1L,1L,5L,1L,4L,1L,7L,1L,4L,1L,1L,24L,111L,1L,2L,1L,1L,12L,6L,1L,4L,5L,1L,2L,3L,11L,1L,3L,1L,1L,45L,1L,1L,1L,1L,1L,2L,83L,1L,2L,2L,1L,1L,6L,1L,5L,9L,1L,4L,12L,1L,1L,4L,2L,2L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016540Inst : IEnumerable<long>
{
public static readonly long[] Value=A016540.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016540.Bytes);
public long this[int i]=>Value[i];

public static A016540Inst Instance=new A016540Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016539
{
public static readonly long[] Value={ 2L,2L,3L,1L,5L,9L,4L,2L,2L,4L,1L,1L,1L,9L,1L,1L,16L,2L,6L,1L,2L,2L,1L,5L,2L,4L,1L,2L,1L,3L,3L,7L,2L,1L,4L,4L,1L,1L,4L,2L,1L,4L,1L,3L,427L,5L,5L,15L,1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,4L,1L,1L,1L,1L,8L,2L,1L,2L,7L,13L,15L,2L,1L,8L,4L,1L,38L,1L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016539Inst : IEnumerable<long>
{
public static readonly long[] Value=A016539.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016539.Bytes);
public long this[int i]=>Value[i];

public static A016539Inst Instance=new A016539Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016538
{
public static readonly long[] Value={ 2L,2L,1L,5L,2L,30L,10L,2L,1L,1L,1L,1L,38L,1L,1L,1L,1L,6L,2L,2L,1L,26L,1L,1L,2L,2L,2L,1L,42L,2L,2L,1L,5L,2L,2L,7L,1L,1L,2L,5L,1L,1L,3L,1L,1L,1L,1L,1L,4L,1L,2L,2L,1L,1L,5L,2L,3L,1L,1L,1L,2L,9L,1L,1L,2L,1L,3L,2L,1L,1L,7L,2L,3L,2L,2L,2L,1L,21L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016538Inst : IEnumerable<long>
{
public static readonly long[] Value=A016538.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016538.Bytes);
public long this[int i]=>Value[i];

public static A016538Inst Instance=new A016538Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016537
{
public static readonly long[] Value={ 2L,3L,1L,47L,1L,1L,1L,2L,1L,1L,4L,4L,3L,3L,3L,1L,3L,20L,2L,7L,1L,1L,1L,1L,2L,3L,3L,1L,60L,1L,15L,1L,2L,2L,4L,10L,1L,1L,1L,1L,4L,1L,29L,2L,3L,1L,1L,1L,16L,1L,3L,1L,3L,7L,1L,1L,6L,1L,2L,1L,7L,2L,2L,3L,1L,4L,1L,8L,1L,20L,1L,1L,1L,1L,6L,1L,2L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016537Inst : IEnumerable<long>
{
public static readonly long[] Value=A016537.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016537.Bytes);
public long this[int i]=>Value[i];

public static A016537Inst Instance=new A016537Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016536
{
public static readonly long[] Value={ 2L,7L,7L,5L,1L,9L,1L,1L,2L,11L,4L,1L,1L,3L,1L,1L,14L,1L,2L,3L,1L,4L,1L,8L,2L,1L,1L,2L,2L,1L,1L,1L,2L,6L,2L,51L,1L,1L,25L,1L,2L,18L,1L,1L,3L,3L,3L,1L,1L,2L,3L,1L,3L,8L,5L,1L,2L,6L,14L,1L,9L,3L,1L,1L,7L,2L,1L,2L,33L,1L,1L,2L,3L,2L,1L,4L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016536Inst : IEnumerable<long>
{
public static readonly long[] Value=A016536.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016536.Bytes);
public long this[int i]=>Value[i];

public static A016536Inst Instance=new A016536Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016535
{
public static readonly long[] Value={ 2L,67L,9L,1L,19L,2L,5L,28L,1L,10L,2L,4L,3L,1L,76L,1L,1L,1L,9L,3L,2L,2L,1L,1L,1L,2L,1L,1L,20L,2L,2L,1L,8L,18L,6L,2L,1L,1L,16L,1L,6L,2L,1L,16L,7L,5L,2L,1L,1L,7L,11L,5L,12L,3L,1L,8L,1L,11L,32L,2L,1L,1L,6L,1L,4020L,13L,1L,10L,1L,1L,3L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016535Inst : IEnumerable<long>
{
public static readonly long[] Value=A016535.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016535.Bytes);
public long this[int i]=>Value[i];

public static A016535Inst Instance=new A016535Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016534
{
public static readonly long[] Value={ 1L,1L,6L,1L,4L,89L,1L,3L,1L,7L,1L,1L,2L,1L,1L,1L,3L,1L,1L,1L,4L,3L,2L,365L,1L,1L,3L,2L,1L,1L,5L,1L,3L,2L,1L,1L,3L,3L,1L,2L,1L,4L,6L,20L,2L,4L,5L,2L,1L,5L,4L,1L,12L,56L,4L,7L,1L,1L,3L,10L,4L,3L,2L,1L,1L,1L,1L,5L,1L,16L,1L,5L,7L,3L,3L,7L,1L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016534Inst : IEnumerable<long>
{
public static readonly long[] Value=A016534.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016534.Bytes);
public long this[int i]=>Value[i];

public static A016534Inst Instance=new A016534Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016533
{
public static readonly long[] Value={ 1L,1L,2L,2L,1L,1L,2L,2L,6L,6L,1L,3L,2L,1L,1L,1L,1L,2L,1L,1L,1L,1L,2L,1L,2L,4L,2L,1L,1L,3L,2L,73L,46L,3L,2L,3L,3L,4L,1L,3L,2L,6L,1L,1L,1L,1L,1L,8L,16L,1L,1L,2L,11L,1L,6L,1L,2L,3L,1L,16L,2L,6L,6L,1L,1L,3L,1L,1L,5L,14L,5L,1L,1L,2L,3L,4L,1L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016533Inst : IEnumerable<long>
{
public static readonly long[] Value=A016533.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016533.Bytes);
public long this[int i]=>Value[i];

public static A016533Inst Instance=new A016533Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016532
{
public static readonly long[] Value={ 1L,1L,1L,60L,1L,4L,2L,1L,2L,1L,3L,3L,2L,1L,4L,2L,3L,1L,2L,8L,2L,2L,4L,1L,1L,1L,1L,3L,10L,10L,2L,1L,354L,1L,12L,521L,1L,1L,1L,3L,1L,1L,16L,1L,21L,10L,5L,1L,2L,2L,3L,2L,1L,9L,9L,1L,9L,1L,12L,1L,10L,1L,1L,4L,1L,62L,2L,1L,1L,1L,5L,8L,10L,2L,2L,1L,1L,7L,5L,1L,1L,1L,1L,22L,2L,14L,28L,1L,284L,1L,49L,1L,41L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016532Inst : IEnumerable<long>
{
public static readonly long[] Value=A016532.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016532.Bytes);
public long this[int i]=>Value[i];

public static A016532Inst Instance=new A016532Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016531
{
public static readonly long[] Value={ 1L,3L,1L,21L,1L,6L,1L,2L,1L,2L,13L,1L,1L,1L,1L,2L,2L,16L,5L,1L,2L,5L,1L,1L,9L,3L,4L,1L,9L,24L,1L,1L,1L,1L,8L,4L,2L,1L,1L,4L,3L,1L,1L,6L,1L,5L,12L,1L,1L,137L,26L,1L,2L,2L,2L,1L,7L,2L,9L,1L,7L,1L,1L,2L,60L,2L,1L,2L,1L,9L,6L,1L,1L,6L,3L,2L,1L,54L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016531Inst : IEnumerable<long>
{
public static readonly long[] Value=A016531.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016531.Bytes);
public long this[int i]=>Value[i];

public static A016531Inst Instance=new A016531Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016530
{
public static readonly long[] Value={ 0L,1L,10L,1L,17L,1L,1L,3L,1L,48L,1L,9L,1L,1L,9L,1L,1L,2L,22L,2L,6L,2L,3L,1L,4L,3L,5L,107L,1L,3L,1L,2L,4L,4L,1L,1L,5L,3L,4L,109L,1L,4L,1L,18L,2L,1L,3L,3L,2L,1L,1L,1L,1L,1L,1L,1L,1L,3L,6L,1L,2L,6L,1L,1L,7L,1L,1L,1L,1L,79L,4L,1L,23L,1L,94L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016530Inst : IEnumerable<long>
{
public static readonly long[] Value=A016530.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016530.Bytes);
public long this[int i]=>Value[i];

public static A016530Inst Instance=new A016530Inst();

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