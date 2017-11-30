using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A021853
{
public static readonly long[] Value={ 0L,0L,1L,1L,7L,7L,8L,5L,6L,3L,0L,1L,5L,3L,1L,2L,1L,3L,1L,9L,1L,9L,9L,0L,5L,7L,7L,1L,4L,9L,5L,8L,7L,7L,5L,0L,2L,9L,4L,4L,6L,4L,0L,7L,5L,3L,8L,2L,8L,0L,3L,2L,9L,7L,9L,9L,7L,6L,4L,4L,2L,8L,7L,3L,9L,6L,9L,3L,7L,5L,7L,3L,6L,1L,6L,0L,1L,8L,8L,4L,5L,7L,0L,0L,8L,2L,4L,4L,9L,9L,4L,1L,1L,0L,7L,1L,8L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021853Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021853.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021853Inst : IEnumerable<long>
{
public static readonly long[] Value=A021853.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021853.Bytes);
public long this[int i]=>Value[i];

public static A021853Inst Instance=new A021853Inst();

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

public static class A021885
{
public static readonly long[] Value={ 0L,0L,1L,1L,3L,5L,0L,7L,3L,7L,7L,9L,7L,9L,5L,6L,8L,6L,7L,1L,9L,6L,3L,6L,7L,7L,6L,3L,9L,0L,4L,6L,5L,3L,8L,0L,2L,4L,9L,7L,1L,6L,2L,3L,1L,5L,5L,5L,0L,5L,1L,0L,7L,8L,3L,2L,0L,0L,9L,0L,8L,0L,5L,9L,0L,2L,3L,8L,3L,6L,5L,4L,9L,3L,7L,5L,7L,0L,9L,4L,2L,1L,1L,1L,2L,3L,7L,2L,3L,0L,4L,1L,9L,9L,7L,7L,2L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021885Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021885.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021885Inst : IEnumerable<long>
{
public static readonly long[] Value=A021885.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021885.Bytes);
public long this[int i]=>Value[i];

public static A021885Inst Instance=new A021885Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021918
{
public static readonly long[] Value={ 0L,0L,1L,0L,9L,4L,0L,9L,1L,9L,0L,3L,7L,1L,9L,9L,1L,2L,4L,7L,2L,6L,4L,7L,7L,0L,2L,4L,0L,7L,0L,0L,2L,1L,8L,8L,1L,8L,3L,8L,0L,7L,4L,3L,9L,8L,2L,4L,9L,4L,5L,2L,9L,5L,4L,0L,4L,8L,1L,4L,0L,0L,4L,3L,7L,6L,3L,6L,7L,6L,1L,4L,8L,7L,9L,6L,4L,9L,8L,9L,0L,5L,9L,0L,8L,0L,9L,6L,2L,8L,0L,0L,8L,7L,5L,2L,7L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021918Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021918.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021918Inst : IEnumerable<long>
{
public static readonly long[] Value=A021918.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021918.Bytes);
public long this[int i]=>Value[i];

public static A021918Inst Instance=new A021918Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021919
{
public static readonly long[] Value={ 0L,0L,1L,0L,9L,2L,8L,9L,6L,1L,7L,4L,8L,6L,3L,3L,8L,7L,9L,7L,8L,1L,4L,2L,0L,7L,6L,5L,0L,2L,7L,3L,2L,2L,4L,0L,4L,3L,7L,1L,5L,8L,4L,6L,9L,9L,4L,5L,3L,5L,5L,1L,9L,1L,2L,5L,6L,8L,3L,0L,6L,0L,1L,0L,9L,2L,8L,9L,6L,1L,7L,4L,8L,6L,3L,3L,8L,7L,9L,7L,8L,1L,4L,2L,0L,7L,6L,5L,0L,2L,7L,3L,2L,2L,4L,0L,4L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021919Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021919.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021919Inst : IEnumerable<long>
{
public static readonly long[] Value=A021919.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021919.Bytes);
public long this[int i]=>Value[i];

public static A021919Inst Instance=new A021919Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021920
{
public static readonly long[] Value={ 0L,0L,1L,0L,9L,1L,7L,0L,3L,0L,5L,6L,7L,6L,8L,5L,5L,8L,9L,5L,1L,9L,6L,5L,0L,6L,5L,5L,0L,2L,1L,8L,3L,4L,0L,6L,1L,1L,3L,5L,3L,7L,1L,1L,7L,9L,0L,3L,9L,3L,0L,1L,3L,1L,0L,0L,4L,3L,6L,6L,8L,1L,2L,2L,2L,7L,0L,7L,4L,2L,3L,5L,8L,0L,7L,8L,6L,0L,2L,6L,2L,0L,0L,8L,7L,3L,3L,6L,2L,4L,4L,5L,4L,1L,4L,8L,4L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021920Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021920.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021920Inst : IEnumerable<long>
{
public static readonly long[] Value=A021920.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021920.Bytes);
public long this[int i]=>Value[i];

public static A021920Inst Instance=new A021920Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021921
{
public static readonly long[] Value={ 0L,0L,1L,0L,9L,0L,5L,1L,2L,5L,4L,0L,8L,9L,4L,2L,2L,0L,2L,8L,3L,5L,3L,3L,2L,6L,0L,6L,3L,2L,4L,9L,7L,2L,7L,3L,7L,1L,8L,6L,4L,7L,7L,6L,4L,4L,4L,9L,2L,9L,1L,1L,6L,6L,8L,4L,8L,4L,1L,8L,7L,5L,6L,8L,1L,5L,7L,0L,3L,3L,8L,0L,5L,8L,8L,8L,7L,6L,7L,7L,2L,0L,8L,2L,8L,7L,8L,9L,5L,3L,1L,0L,7L,9L,6L,0L,7L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021921Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021921.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021921Inst : IEnumerable<long>
{
public static readonly long[] Value=A021921.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021921.Bytes);
public long this[int i]=>Value[i];

public static A021921Inst Instance=new A021921Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021922
{
public static readonly long[] Value={ 0L,0L,1L,0L,8L,9L,3L,2L,4L,6L,1L,8L,7L,3L,6L,3L,8L,3L,4L,4L,2L,2L,6L,5L,7L,9L,5L,2L,0L,6L,9L,7L,1L,6L,7L,7L,5L,5L,9L,9L,1L,2L,8L,5L,4L,0L,3L,0L,5L,0L,1L,0L,8L,9L,3L,2L,4L,6L,1L,8L,7L,3L,6L,3L,8L,3L,4L,4L,2L,2L,6L,5L,7L,9L,5L,2L,0L,6L,9L,7L,1L,6L,7L,7L,5L,5L,9L,9L,1L,2L,8L,5L,4L,0L,3L,0L,5L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021922Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021922.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021922Inst : IEnumerable<long>
{
public static readonly long[] Value=A021922.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021922.Bytes);
public long this[int i]=>Value[i];

public static A021922Inst Instance=new A021922Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021923
{
public static readonly long[] Value={ 0L,0L,1L,0L,8L,8L,1L,3L,9L,2L,8L,1L,8L,2L,8L,0L,7L,3L,9L,9L,3L,4L,7L,1L,1L,6L,4L,3L,0L,9L,0L,3L,1L,5L,5L,6L,0L,3L,9L,1L,7L,3L,0L,1L,4L,1L,4L,5L,8L,1L,0L,6L,6L,3L,7L,6L,4L,9L,6L,1L,9L,1L,5L,1L,2L,5L,1L,3L,6L,0L,1L,7L,4L,1L,0L,2L,2L,8L,5L,0L,9L,2L,4L,9L,1L,8L,3L,8L,9L,5L,5L,3L,8L,6L,2L,8L,9L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021923Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021923.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021923Inst : IEnumerable<long>
{
public static readonly long[] Value=A021923.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021923.Bytes);
public long this[int i]=>Value[i];

public static A021923Inst Instance=new A021923Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021924
{
public static readonly long[] Value={ 1L,24L,389L,5364L,68025L,821808L,9633613L,110741388L,1256415809L,14127007752L,157849954197L,1755978039972L,19472809159753L,215457395996256L,2380083675784541L,26261340423891516L,289518110311522257L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021924Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021924.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021924Inst : IEnumerable<long>
{
public static readonly long[] Value=A021924.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021924.Bytes);
public long this[int i]=>Value[i];

public static A021924Inst Instance=new A021924Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021925
{
public static readonly long[] Value={ 0L,0L,1L,0L,8L,5L,7L,7L,6L,3L,3L,0L,0L,7L,6L,0L,0L,4L,3L,4L,3L,1L,0L,5L,3L,2L,0L,3L,0L,4L,0L,1L,7L,3L,7L,2L,4L,2L,1L,2L,8L,1L,2L,1L,6L,0L,6L,9L,4L,8L,9L,6L,8L,5L,1L,2L,4L,8L,6L,4L,2L,7L,7L,9L,5L,8L,7L,4L,0L,4L,9L,9L,4L,5L,7L,1L,1L,1L,8L,3L,4L,9L,6L,1L,9L,9L,7L,8L,2L,8L,4L,4L,7L,3L,3L,9L,8L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021925Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021925.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021925Inst : IEnumerable<long>
{
public static readonly long[] Value=A021925.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021925.Bytes);
public long this[int i]=>Value[i];

public static A021925Inst Instance=new A021925Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021926
{
public static readonly long[] Value={ 0L,0L,1L,0L,8L,4L,5L,9L,8L,6L,9L,8L,4L,8L,1L,5L,6L,1L,8L,2L,2L,1L,2L,5L,8L,1L,3L,4L,4L,9L,0L,2L,3L,8L,6L,1L,1L,7L,1L,3L,6L,6L,5L,9L,4L,3L,6L,0L,0L,8L,6L,7L,6L,7L,8L,9L,5L,8L,7L,8L,5L,2L,4L,9L,4L,5L,7L,7L,0L,0L,6L,5L,0L,7L,5L,9L,2L,1L,9L,0L,8L,8L,9L,3L,7L,0L,9L,3L,2L,7L,5L,4L,8L,8L,0L,6L,9L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021926Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021926.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021926Inst : IEnumerable<long>
{
public static readonly long[] Value=A021926.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021926.Bytes);
public long this[int i]=>Value[i];

public static A021926Inst Instance=new A021926Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021927
{
public static readonly long[] Value={ 0L,0L,1L,0L,8L,3L,4L,2L,3L,6L,1L,8L,6L,3L,4L,8L,8L,6L,2L,4L,0L,5L,2L,0L,0L,4L,3L,3L,3L,6L,9L,4L,4L,7L,4L,5L,3L,9L,5L,4L,4L,9L,6L,2L,0L,8L,0L,1L,7L,3L,3L,4L,7L,7L,7L,8L,9L,8L,1L,5L,8L,1L,7L,9L,8L,4L,8L,3L,2L,0L,6L,9L,3L,3L,9L,1L,1L,1L,5L,9L,2L,6L,3L,2L,7L,1L,9L,3L,9L,3L,2L,8L,2L,7L,7L,3L,5L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021927Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021927.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021927Inst : IEnumerable<long>
{
public static readonly long[] Value=A021927.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021927.Bytes);
public long this[int i]=>Value[i];

public static A021927Inst Instance=new A021927Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021928
{
public static readonly long[] Value={ 0L,0L,1L,0L,8L,2L,2L,5L,1L,0L,8L,2L,2L,5L,1L,0L,8L,2L,2L,5L,1L,0L,8L,2L,2L,5L,1L,0L,8L,2L,2L,5L,1L,0L,8L,2L,2L,5L,1L,0L,8L,2L,2L,5L,1L,0L,8L,2L,2L,5L,1L,0L,8L,2L,2L,5L,1L,0L,8L,2L,2L,5L,1L,0L,8L,2L,2L,5L,1L,0L,8L,2L,2L,5L,1L,0L,8L,2L,2L,5L,1L,0L,8L,2L,2L,5L,1L,0L,8L,2L,2L,5L,1L,0L,8L,2L,2L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021928Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021928.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021928Inst : IEnumerable<long>
{
public static readonly long[] Value=A021928.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021928.Bytes);
public long this[int i]=>Value[i];

public static A021928Inst Instance=new A021928Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021929
{
public static readonly long[] Value={ 0L,0L,1L,0L,8L,1L,0L,8L,1L,0L,8L,1L,0L,8L,1L,0L,8L,1L,0L,8L,1L,0L,8L,1L,0L,8L,1L,0L,8L,1L,0L,8L,1L,0L,8L,1L,0L,8L,1L,0L,8L,1L,0L,8L,1L,0L,8L,1L,0L,8L,1L,0L,8L,1L,0L,8L,1L,0L,8L,1L,0L,8L,1L,0L,8L,1L,0L,8L,1L,0L,8L,1L,0L,8L,1L,0L,8L,1L,0L,8L,1L,0L,8L,1L,0L,8L,1L,0L,8L,1L,0L,8L,1L,0L,8L,1L,0L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021929Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021929.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021929Inst : IEnumerable<long>
{
public static readonly long[] Value=A021929.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021929.Bytes);
public long this[int i]=>Value[i];

public static A021929Inst Instance=new A021929Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021930
{
public static readonly long[] Value={ 0L,0L,1L,0L,7L,9L,9L,1L,3L,6L,0L,6L,9L,1L,1L,4L,4L,7L,0L,8L,4L,2L,3L,3L,2L,6L,1L,3L,3L,9L,0L,9L,2L,8L,7L,2L,5L,7L,0L,1L,9L,4L,3L,8L,4L,4L,4L,9L,2L,4L,4L,0L,6L,0L,4L,7L,5L,1L,6L,1L,9L,8L,7L,0L,4L,1L,0L,3L,6L,7L,1L,7L,0L,6L,2L,6L,3L,4L,9L,8L,9L,2L,0L,0L,8L,6L,3L,9L,3L,0L,8L,8L,5L,5L,2L,9L,1L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021930Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021930.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021930Inst : IEnumerable<long>
{
public static readonly long[] Value=A021930.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021930.Bytes);
public long this[int i]=>Value[i];

public static A021930Inst Instance=new A021930Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021931
{
public static readonly long[] Value={ 0L,0L,1L,0L,7L,8L,7L,4L,8L,6L,5L,1L,5L,6L,4L,1L,8L,5L,5L,4L,4L,7L,6L,8L,0L,6L,9L,0L,3L,9L,9L,1L,3L,7L,0L,0L,1L,0L,7L,8L,7L,4L,8L,6L,5L,1L,5L,6L,4L,1L,8L,5L,5L,4L,4L,7L,6L,8L,0L,6L,9L,0L,3L,9L,9L,1L,3L,7L,0L,0L,1L,0L,7L,8L,7L,4L,8L,6L,5L,1L,5L,6L,4L,1L,8L,5L,5L,4L,4L,7L,6L,8L,0L,6L,9L,0L,3L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021931Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021931.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021931Inst : IEnumerable<long>
{
public static readonly long[] Value=A021931.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021931.Bytes);
public long this[int i]=>Value[i];

public static A021931Inst Instance=new A021931Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021932
{
public static readonly long[] Value={ 0L,0L,1L,0L,7L,7L,5L,8L,6L,2L,0L,6L,8L,9L,6L,5L,5L,1L,7L,2L,4L,1L,3L,7L,9L,3L,1L,0L,3L,4L,4L,8L,2L,7L,5L,8L,6L,2L,0L,6L,8L,9L,6L,5L,5L,1L,7L,2L,4L,1L,3L,7L,9L,3L,1L,0L,3L,4L,4L,8L,2L,7L,5L,8L,6L,2L,0L,6L,8L,9L,6L,5L,5L,1L,7L,2L,4L,1L,3L,7L,9L,3L,1L,0L,3L,4L,4L,8L,2L,7L,5L,8L,6L,2L,0L,6L,8L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021932Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021932.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021932Inst : IEnumerable<long>
{
public static readonly long[] Value=A021932.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021932.Bytes);
public long this[int i]=>Value[i];

public static A021932Inst Instance=new A021932Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021933
{
public static readonly long[] Value={ 0L,0L,1L,0L,7L,6L,4L,2L,6L,2L,6L,4L,8L,0L,0L,8L,6L,1L,1L,4L,1L,0L,1L,1L,8L,4L,0L,6L,8L,8L,9L,1L,2L,8L,0L,9L,4L,7L,2L,5L,5L,1L,1L,3L,0L,2L,4L,7L,5L,7L,8L,0L,4L,0L,9L,0L,4L,1L,9L,8L,0L,6L,2L,4L,3L,2L,7L,2L,3L,3L,5L,8L,4L,4L,9L,9L,4L,6L,1L,7L,8L,6L,8L,6L,7L,5L,9L,9L,5L,6L,9L,4L,2L,9L,4L,9L,4L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021933Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021933.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021933Inst : IEnumerable<long>
{
public static readonly long[] Value=A021933.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021933.Bytes);
public long this[int i]=>Value[i];

public static A021933Inst Instance=new A021933Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021950
{
public static readonly long[] Value={ 0L,0L,1L,0L,5L,7L,0L,8L,2L,4L,5L,2L,4L,3L,1L,2L,8L,9L,6L,4L,0L,5L,9L,1L,9L,6L,6L,1L,7L,3L,3L,6L,1L,5L,2L,2L,1L,9L,8L,7L,3L,1L,5L,0L,1L,0L,5L,7L,0L,8L,2L,4L,5L,2L,4L,3L,1L,2L,8L,9L,6L,4L,0L,5L,9L,1L,9L,6L,6L,1L,7L,3L,3L,6L,1L,5L,2L,2L,1L,9L,8L,7L,3L,1L,5L,0L,1L,0L,5L,7L,0L,8L,2L,4L,5L,2L,4L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021950Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021950.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021950Inst : IEnumerable<long>
{
public static readonly long[] Value=A021950.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021950.Bytes);
public long this[int i]=>Value[i];

public static A021950Inst Instance=new A021950Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021951
{
public static readonly long[] Value={ 0L,0L,1L,0L,5L,5L,9L,6L,6L,2L,0L,9L,0L,8L,1L,3L,0L,9L,3L,9L,8L,0L,9L,9L,2L,6L,0L,8L,2L,3L,6L,5L,3L,6L,4L,3L,0L,8L,3L,4L,2L,1L,3L,3L,0L,5L,1L,7L,4L,2L,3L,4L,4L,2L,4L,4L,9L,8L,4L,1L,6L,0L,5L,0L,6L,8L,6L,3L,7L,8L,0L,3L,5L,9L,0L,2L,8L,5L,1L,1L,0L,8L,7L,6L,4L,5L,1L,9L,5L,3L,5L,3L,7L,4L,8L,6L,8L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021951Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021951.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021951Inst : IEnumerable<long>
{
public static readonly long[] Value=A021951.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021951.Bytes);
public long this[int i]=>Value[i];

public static A021951Inst Instance=new A021951Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021952
{
public static readonly long[] Value={ 0L,0L,1L,0L,5L,4L,8L,5L,2L,3L,2L,0L,6L,7L,5L,1L,0L,5L,4L,8L,5L,2L,3L,2L,0L,6L,7L,5L,1L,0L,5L,4L,8L,5L,2L,3L,2L,0L,6L,7L,5L,1L,0L,5L,4L,8L,5L,2L,3L,2L,0L,6L,7L,5L,1L,0L,5L,4L,8L,5L,2L,3L,2L,0L,6L,7L,5L,1L,0L,5L,4L,8L,5L,2L,3L,2L,0L,6L,7L,5L,1L,0L,5L,4L,8L,5L,2L,3L,2L,0L,6L,7L,5L,1L,0L,5L,4L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021952Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021952.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021952Inst : IEnumerable<long>
{
public static readonly long[] Value=A021952.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021952.Bytes);
public long this[int i]=>Value[i];

public static A021952Inst Instance=new A021952Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021953
{
public static readonly long[] Value={ 0L,0L,1L,0L,5L,3L,7L,4L,0L,7L,7L,9L,7L,6L,8L,1L,7L,7L,0L,2L,8L,4L,5L,1L,0L,0L,1L,0L,5L,3L,7L,4L,0L,7L,7L,9L,7L,6L,8L,1L,7L,7L,0L,2L,8L,4L,5L,1L,0L,0L,1L,0L,5L,3L,7L,4L,0L,7L,7L,9L,7L,6L,8L,1L,7L,7L,0L,2L,8L,4L,5L,1L,0L,0L,1L,0L,5L,3L,7L,4L,0L,7L,7L,9L,7L,6L,8L,1L,7L,7L,0L,2L,8L,4L,5L,1L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021953Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021953.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021953Inst : IEnumerable<long>
{
public static readonly long[] Value=A021953.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021953.Bytes);
public long this[int i]=>Value[i];

public static A021953Inst Instance=new A021953Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021954
{
public static readonly long[] Value={ 1L,24L,387L,5278L,65793L,776412L,8835919L,98027226L,1067371965L,11457966520L,121639285131L,1279935023094L,13371252146617L,138859728185748L,1434922500247623L,14766153399643282L,151413895297559349L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021954Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021954.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021954Inst : IEnumerable<long>
{
public static readonly long[] Value=A021954.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021954.Bytes);
public long this[int i]=>Value[i];

public static A021954Inst Instance=new A021954Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021955
{
public static readonly long[] Value={ 0L,0L,1L,0L,5L,1L,5L,2L,4L,7L,1L,0L,8L,3L,0L,7L,0L,4L,5L,2L,1L,5L,5L,6L,2L,5L,6L,5L,7L,2L,0L,2L,9L,4L,4L,2L,6L,9L,1L,9L,0L,3L,2L,5L,9L,7L,2L,6L,6L,0L,3L,5L,7L,5L,1L,8L,4L,0L,1L,6L,8L,2L,4L,3L,9L,5L,3L,7L,3L,2L,9L,1L,2L,7L,2L,3L,4L,4L,9L,0L,0L,1L,0L,5L,1L,5L,2L,4L,7L,1L,0L,8L,3L,0L,7L,0L,4L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021955Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021955.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021955Inst : IEnumerable<long>
{
public static readonly long[] Value=A021955.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021955.Bytes);
public long this[int i]=>Value[i];

public static A021955Inst Instance=new A021955Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021956
{
public static readonly long[] Value={ 0L,0L,1L,0L,5L,0L,4L,2L,0L,1L,6L,8L,0L,6L,7L,2L,2L,6L,8L,9L,0L,7L,5L,6L,3L,0L,2L,5L,2L,1L,0L,0L,8L,4L,0L,3L,3L,6L,1L,3L,4L,4L,5L,3L,7L,8L,1L,5L,1L,2L,6L,0L,5L,0L,4L,2L,0L,1L,6L,8L,0L,6L,7L,2L,2L,6L,8L,9L,0L,7L,5L,6L,3L,0L,2L,5L,2L,1L,0L,0L,8L,4L,0L,3L,3L,6L,1L,3L,4L,4L,5L,3L,7L,8L,1L,5L,1L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021956Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021956.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021956Inst : IEnumerable<long>
{
public static readonly long[] Value=A021956.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021956.Bytes);
public long this[int i]=>Value[i];

public static A021956Inst Instance=new A021956Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021957
{
public static readonly long[] Value={ 0L,0L,1L,0L,4L,9L,3L,1L,7L,9L,4L,3L,3L,3L,6L,8L,3L,1L,0L,5L,9L,8L,1L,1L,1L,2L,2L,7L,7L,0L,1L,9L,9L,3L,7L,0L,4L,0L,9L,2L,3L,3L,9L,9L,7L,9L,0L,1L,3L,6L,4L,1L,1L,3L,3L,2L,6L,3L,3L,7L,8L,8L,0L,3L,7L,7L,7L,5L,4L,4L,5L,9L,6L,0L,1L,2L,5L,9L,1L,8L,1L,5L,3L,2L,0L,0L,4L,1L,9L,7L,2L,7L,1L,7L,7L,3L,3L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021957Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021957.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021957Inst : IEnumerable<long>
{
public static readonly long[] Value=A021957.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021957.Bytes);
public long this[int i]=>Value[i];

public static A021957Inst Instance=new A021957Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021958
{
public static readonly long[] Value={ 0L,0L,1L,0L,4L,8L,2L,1L,8L,0L,2L,9L,3L,5L,0L,1L,0L,4L,8L,2L,1L,8L,0L,2L,9L,3L,5L,0L,1L,0L,4L,8L,2L,1L,8L,0L,2L,9L,3L,5L,0L,1L,0L,4L,8L,2L,1L,8L,0L,2L,9L,3L,5L,0L,1L,0L,4L,8L,2L,1L,8L,0L,2L,9L,3L,5L,0L,1L,0L,4L,8L,2L,1L,8L,0L,2L,9L,3L,5L,0L,1L,0L,4L,8L,2L,1L,8L,0L,2L,9L,3L,5L,0L,1L,0L,4L,8L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021958Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021958.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021958Inst : IEnumerable<long>
{
public static readonly long[] Value=A021958.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021958.Bytes);
public long this[int i]=>Value[i];

public static A021958Inst Instance=new A021958Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021959
{
public static readonly long[] Value={ 0L,0L,1L,0L,4L,7L,1L,2L,0L,4L,1L,8L,8L,4L,8L,1L,6L,7L,5L,3L,9L,2L,6L,7L,0L,1L,5L,7L,0L,6L,8L,0L,6L,2L,8L,2L,7L,2L,2L,5L,1L,3L,0L,8L,9L,0L,0L,5L,2L,3L,5L,6L,0L,2L,0L,9L,4L,2L,4L,0L,8L,3L,7L,6L,9L,6L,3L,3L,5L,0L,7L,8L,5L,3L,4L,0L,3L,1L,4L,1L,3L,6L,1L,2L,5L,6L,5L,4L,4L,5L,0L,2L,6L,1L,7L,8L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021959Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021959.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021959Inst : IEnumerable<long>
{
public static readonly long[] Value=A021959.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021959.Bytes);
public long this[int i]=>Value[i];

public static A021959Inst Instance=new A021959Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021960
{
public static readonly long[] Value={ 0L,0L,1L,0L,4L,6L,0L,2L,5L,1L,0L,4L,6L,0L,2L,5L,1L,0L,4L,6L,0L,2L,5L,1L,0L,4L,6L,0L,2L,5L,1L,0L,4L,6L,0L,2L,5L,1L,0L,4L,6L,0L,2L,5L,1L,0L,4L,6L,0L,2L,5L,1L,0L,4L,6L,0L,2L,5L,1L,0L,4L,6L,0L,2L,5L,1L,0L,4L,6L,0L,2L,5L,1L,0L,4L,6L,0L,2L,5L,1L,0L,4L,6L,0L,2L,5L,1L,0L,4L,6L,0L,2L,5L,1L,0L,4L,6L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021960Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021960.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021960Inst : IEnumerable<long>
{
public static readonly long[] Value=A021960.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021960.Bytes);
public long this[int i]=>Value[i];

public static A021960Inst Instance=new A021960Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021961
{
public static readonly long[] Value={ 0L,0L,1L,0L,4L,4L,9L,3L,2L,0L,7L,9L,4L,1L,4L,8L,3L,8L,0L,3L,5L,5L,2L,7L,6L,9L,0L,7L,0L,0L,1L,0L,4L,4L,9L,3L,2L,0L,7L,9L,4L,1L,4L,8L,3L,8L,0L,3L,5L,5L,2L,7L,6L,9L,0L,7L,0L,0L,1L,0L,4L,4L,9L,3L,2L,0L,7L,9L,4L,1L,4L,8L,3L,8L,0L,3L,5L,5L,2L,7L,6L,9L,0L,7L,0L,0L,1L,0L,4L,4L,9L,3L,2L,0L,7L,9L,4L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021961Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021961.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021961Inst : IEnumerable<long>
{
public static readonly long[] Value=A021961.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021961.Bytes);
public long this[int i]=>Value[i];

public static A021961Inst Instance=new A021961Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021962
{
public static readonly long[] Value={ 0L,0L,1L,0L,4L,3L,8L,4L,1L,3L,3L,6L,1L,1L,6L,9L,1L,0L,2L,2L,9L,6L,4L,5L,0L,9L,3L,9L,4L,5L,7L,2L,0L,2L,5L,0L,5L,2L,1L,9L,2L,0L,6L,6L,8L,0L,5L,8L,4L,5L,5L,1L,1L,4L,8L,2L,2L,5L,4L,6L,9L,7L,2L,8L,6L,0L,1L,2L,5L,2L,6L,0L,9L,6L,0L,3L,3L,4L,0L,2L,9L,2L,2L,7L,5L,5L,7L,4L,1L,1L,2L,7L,3L,4L,8L,6L,4L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021962Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021962.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021962Inst : IEnumerable<long>
{
public static readonly long[] Value=A021962.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021962.Bytes);
public long this[int i]=>Value[i];

public static A021962Inst Instance=new A021962Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021963
{
public static readonly long[] Value={ 0L,0L,1L,0L,4L,2L,7L,5L,2L,8L,6L,7L,5L,7L,0L,3L,8L,5L,8L,1L,8L,5L,6L,1L,0L,0L,1L,0L,4L,2L,7L,5L,2L,8L,6L,7L,5L,7L,0L,3L,8L,5L,8L,1L,8L,5L,6L,1L,0L,0L,1L,0L,4L,2L,7L,5L,2L,8L,6L,7L,5L,7L,0L,3L,8L,5L,8L,1L,8L,5L,6L,1L,0L,0L,1L,0L,4L,2L,7L,5L,2L,8L,6L,7L,5L,7L,0L,3L,8L,5L,8L,1L,8L,5L,6L,1L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021963Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021963.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021963Inst : IEnumerable<long>
{
public static readonly long[] Value=A021963.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021963.Bytes);
public long this[int i]=>Value[i];

public static A021963Inst Instance=new A021963Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021964
{
public static readonly long[] Value={ 1L,25L,422L,6050L,79563L,993675L,12002224L,141692500L,1645717205L,18887136125L,214818117306L,2426541462150L,27263857999327L,305049644712175L,3401871310224068L,37837512809631800L,419965002207076329L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021964Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021964.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021964Inst : IEnumerable<long>
{
public static readonly long[] Value=A021964.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021964.Bytes);
public long this[int i]=>Value[i];

public static A021964Inst Instance=new A021964Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021965
{
public static readonly long[] Value={ 0L,0L,1L,0L,4L,0L,5L,8L,2L,7L,2L,6L,3L,2L,6L,7L,4L,2L,9L,7L,6L,0L,6L,6L,5L,9L,7L,2L,9L,4L,4L,8L,4L,9L,1L,1L,5L,5L,0L,4L,6L,8L,2L,6L,2L,2L,2L,6L,8L,4L,7L,0L,3L,4L,3L,3L,9L,2L,2L,9L,9L,6L,8L,7L,8L,2L,5L,1L,8L,2L,1L,0L,1L,9L,7L,7L,1L,0L,7L,1L,8L,0L,0L,2L,0L,8L,1L,1L,6L,5L,4L,5L,2L,6L,5L,3L,4L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021965Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021965.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021965Inst : IEnumerable<long>
{
public static readonly long[] Value=A021965.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021965.Bytes);
public long this[int i]=>Value[i];

public static A021965Inst Instance=new A021965Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021982
{
public static readonly long[] Value={ 0L,0L,1L,0L,2L,2L,4L,9L,4L,8L,8L,7L,5L,2L,5L,5L,6L,2L,3L,7L,2L,1L,8L,8L,1L,3L,9L,0L,5L,9L,3L,0L,4L,7L,0L,3L,4L,7L,6L,4L,8L,2L,6L,1L,7L,5L,8L,6L,9L,1L,2L,0L,6L,5L,4L,3L,9L,6L,7L,2L,8L,0L,1L,6L,3L,5L,9L,9L,1L,8L,2L,0L,0L,4L,0L,8L,9L,9L,7L,9L,5L,5L,0L,1L,0L,2L,2L,4L,9L,4L,8L,8L,7L,5L,2L,5L,5L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021982Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021982.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021982Inst : IEnumerable<long>
{
public static readonly long[] Value=A021982.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021982.Bytes);
public long this[int i]=>Value[i];

public static A021982Inst Instance=new A021982Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021983
{
public static readonly long[] Value={ 0L,0L,1L,0L,2L,1L,4L,5L,0L,4L,5L,9L,6L,5L,2L,7L,0L,6L,8L,4L,3L,7L,1L,8L,0L,7L,9L,6L,7L,3L,1L,3L,5L,8L,5L,2L,9L,1L,1L,1L,3L,3L,8L,1L,0L,0L,1L,0L,2L,1L,4L,5L,0L,4L,5L,9L,6L,5L,2L,7L,0L,6L,8L,4L,3L,7L,1L,8L,0L,7L,9L,6L,7L,3L,1L,3L,5L,8L,5L,2L,9L,1L,1L,1L,3L,3L,8L,1L,0L,0L,1L,0L,2L,1L,4L,5L,0L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021983Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021983.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021983Inst : IEnumerable<long>
{
public static readonly long[] Value=A021983.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021983.Bytes);
public long this[int i]=>Value[i];

public static A021983Inst Instance=new A021983Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021984
{
public static readonly long[] Value={ 1L,26L,457L,6822L,93333L,1210938L,15168529L,185357774L,2224062445L,26316305730L,307996949481L,3573147901206L,41156463852037L,471239561238602L,5368820120200513L,60908872219620318L,688516109116593309L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021984Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021984.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021984Inst : IEnumerable<long>
{
public static readonly long[] Value=A021984.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021984.Bytes);
public long this[int i]=>Value[i];

public static A021984Inst Instance=new A021984Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021985
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,9L,3L,6L,7L,9L,9L,1L,8L,4L,5L,0L,5L,6L,0L,6L,5L,2L,3L,9L,5L,5L,1L,4L,7L,8L,0L,8L,3L,5L,8L,8L,1L,7L,5L,3L,3L,1L,2L,9L,4L,5L,9L,7L,3L,4L,9L,6L,4L,3L,2L,2L,1L,2L,0L,2L,8L,5L,4L,2L,3L,0L,3L,7L,7L,1L,6L,6L,1L,5L,6L,9L,8L,2L,6L,7L,0L,7L,4L,4L,1L,3L,8L,6L,3L,4L,0L,4L,6L,8L,9L,0L,9L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021985Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021985.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021985Inst : IEnumerable<long>
{
public static readonly long[] Value=A021985.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021985.Bytes);
public long this[int i]=>Value[i];

public static A021985Inst Instance=new A021985Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021986
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,8L,3L,2L,9L,9L,3L,8L,9L,0L,0L,2L,0L,3L,6L,6L,5L,9L,8L,7L,7L,8L,0L,0L,4L,0L,7L,3L,3L,1L,9L,7L,5L,5L,6L,0L,0L,8L,1L,4L,6L,6L,3L,9L,5L,1L,1L,2L,0L,1L,6L,2L,9L,3L,2L,7L,9L,0L,2L,2L,4L,0L,3L,2L,5L,8L,6L,5L,5L,8L,0L,4L,4L,8L,0L,6L,5L,1L,7L,3L,1L,1L,6L,0L,8L,9L,6L,1L,3L,0L,3L,4L,6L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021986Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021986.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021986Inst : IEnumerable<long>
{
public static readonly long[] Value=A021986.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021986.Bytes);
public long this[int i]=>Value[i];

public static A021986Inst Instance=new A021986Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021987
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,7L,2L,9L,3L,9L,9L,7L,9L,6L,5L,4L,1L,2L,0L,0L,4L,0L,6L,9L,1L,7L,5L,9L,9L,1L,8L,6L,1L,6L,4L,8L,0L,1L,6L,2L,7L,6L,7L,0L,3L,9L,6L,7L,4L,4L,6L,5L,9L,2L,0L,6L,5L,1L,0L,6L,8L,1L,5L,8L,6L,9L,7L,8L,6L,3L,6L,8L,2L,6L,0L,4L,2L,7L,2L,6L,3L,4L,7L,9L,1L,4L,5L,4L,7L,3L,0L,4L,1L,7L,0L,9L,0L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021987Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021987.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021987Inst : IEnumerable<long>
{
public static readonly long[] Value=A021987.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021987.Bytes);
public long this[int i]=>Value[i];

public static A021987Inst Instance=new A021987Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021988
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,6L,2L,6L,0L,1L,6L,2L,6L,0L,1L,6L,2L,6L,0L,1L,6L,2L,6L,0L,1L,6L,2L,6L,0L,1L,6L,2L,6L,0L,1L,6L,2L,6L,0L,1L,6L,2L,6L,0L,1L,6L,2L,6L,0L,1L,6L,2L,6L,0L,1L,6L,2L,6L,0L,1L,6L,2L,6L,0L,1L,6L,2L,6L,0L,1L,6L,2L,6L,0L,1L,6L,2L,6L,0L,1L,6L,2L,6L,0L,1L,6L,2L,6L,0L,1L,6L,2L,6L,0L,1L,6L,2L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021988Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021988.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021988Inst : IEnumerable<long>
{
public static readonly long[] Value=A021988.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021988.Bytes);
public long this[int i]=>Value[i];

public static A021988Inst Instance=new A021988Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021989
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,5L,2L,2L,8L,4L,2L,6L,3L,9L,5L,9L,3L,9L,0L,8L,6L,2L,9L,4L,4L,1L,6L,2L,4L,3L,6L,5L,4L,8L,2L,2L,3L,3L,5L,0L,2L,5L,3L,8L,0L,7L,1L,0L,6L,5L,9L,8L,9L,8L,4L,7L,7L,1L,5L,7L,3L,6L,0L,4L,0L,6L,0L,9L,1L,3L,7L,0L,5L,5L,8L,3L,7L,5L,6L,3L,4L,5L,1L,7L,7L,6L,6L,4L,9L,7L,4L,6L,1L,9L,2L,8L,9L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021989Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021989.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021989Inst : IEnumerable<long>
{
public static readonly long[] Value=A021989.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021989.Bytes);
public long this[int i]=>Value[i];

public static A021989Inst Instance=new A021989Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021990
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,4L,1L,9L,8L,7L,8L,2L,9L,6L,1L,4L,6L,0L,4L,4L,6L,2L,4L,7L,4L,6L,4L,5L,0L,3L,0L,4L,2L,5L,9L,6L,3L,4L,8L,8L,8L,4L,3L,8L,1L,3L,3L,8L,7L,4L,2L,3L,9L,3L,5L,0L,9L,1L,2L,7L,7L,8L,9L,0L,4L,6L,6L,5L,3L,1L,4L,4L,0L,1L,6L,2L,2L,7L,1L,8L,0L,5L,2L,7L,3L,8L,3L,3L,6L,7L,1L,3L,9L,9L,5L,9L,4L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021990Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021990.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021990Inst : IEnumerable<long>
{
public static readonly long[] Value=A021990.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021990.Bytes);
public long this[int i]=>Value[i];

public static A021990Inst Instance=new A021990Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021991
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,3L,1L,7L,1L,2L,2L,5L,9L,3L,7L,1L,8L,3L,3L,8L,3L,9L,9L,1L,8L,9L,4L,6L,3L,0L,1L,9L,2L,5L,0L,2L,5L,3L,2L,9L,2L,8L,0L,6L,4L,8L,4L,2L,9L,5L,8L,4L,5L,9L,9L,7L,9L,7L,3L,6L,5L,7L,5L,4L,8L,1L,2L,5L,6L,3L,3L,2L,3L,2L,0L,1L,6L,2L,1L,0L,7L,3L,9L,6L,1L,4L,9L,9L,4L,9L,3L,4L,1L,4L,3L,8L,7L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021991Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021991.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021991Inst : IEnumerable<long>
{
public static readonly long[] Value=A021991.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021991.Bytes);
public long this[int i]=>Value[i];

public static A021991Inst Instance=new A021991Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021992
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,2L,1L,4L,5L,7L,4L,8L,9L,8L,7L,8L,5L,4L,2L,5L,1L,0L,1L,2L,1L,4L,5L,7L,4L,8L,9L,8L,7L,8L,5L,4L,2L,5L,1L,0L,1L,2L,1L,4L,5L,7L,4L,8L,9L,8L,7L,8L,5L,4L,2L,5L,1L,0L,1L,2L,1L,4L,5L,7L,4L,8L,9L,8L,7L,8L,5L,4L,2L,5L,1L,0L,1L,2L,1L,4L,5L,7L,4L,8L,9L,8L,7L,8L,5L,4L,2L,5L,1L,0L,1L,2L,1L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021992Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021992.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021992Inst : IEnumerable<long>
{
public static readonly long[] Value=A021992.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021992.Bytes);
public long this[int i]=>Value[i];

public static A021992Inst Instance=new A021992Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021993
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,1L,1L,2L,2L,3L,4L,5L,8L,0L,3L,8L,4L,2L,2L,6L,4L,9L,1L,4L,0L,5L,4L,6L,0L,0L,6L,0L,6L,6L,7L,3L,4L,0L,7L,4L,8L,2L,3L,0L,5L,3L,5L,8L,9L,4L,8L,4L,3L,2L,7L,6L,0L,3L,6L,4L,0L,0L,4L,0L,4L,4L,4L,8L,9L,3L,8L,3L,2L,1L,5L,3L,6L,9L,0L,5L,9L,6L,5L,6L,2L,1L,8L,4L,0L,2L,4L,2L,6L,6L,9L,3L,6L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021993Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021993.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021993Inst : IEnumerable<long>
{
public static readonly long[] Value=A021993.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021993.Bytes);
public long this[int i]=>Value[i];

public static A021993Inst Instance=new A021993Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021994
{
public static readonly long[] Value={ 1L,27L,495L,7735L,111111L,1517607L,20059495L,259217895L,3295741671L,41400518887L,515323813095L,6369067214055L,78280643507431L,957886180955367L,11679819118040295L,142009680313898215L,1722634678467548391L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021994Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021994.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021994Inst : IEnumerable<long>
{
public static readonly long[] Value=A021994.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021994.Bytes);
public long this[int i]=>Value[i];

public static A021994Inst Instance=new A021994Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021995
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,9L,0L,8L,1L,7L,3L,5L,6L,2L,0L,5L,8L,5L,2L,6L,7L,4L,0L,6L,6L,5L,9L,9L,3L,9L,4L,5L,5L,0L,9L,5L,8L,6L,2L,7L,6L,4L,8L,8L,3L,9L,5L,5L,6L,0L,0L,4L,0L,3L,6L,3L,2L,6L,9L,4L,2L,4L,8L,2L,3L,4L,1L,0L,6L,9L,6L,2L,6L,6L,3L,9L,7L,5L,7L,8L,2L,0L,3L,8L,3L,4L,5L,1L,0L,5L,9L,5L,3L,5L,8L,2L,2L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021995Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021995.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021995Inst : IEnumerable<long>
{
public static readonly long[] Value=A021995.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021995.Bytes);
public long this[int i]=>Value[i];

public static A021995Inst Instance=new A021995Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021996
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,8L,0L,6L,4L,5L,1L,6L,1L,2L,9L,0L,3L,2L,2L,5L,8L,0L,6L,4L,5L,1L,6L,1L,2L,9L,0L,3L,2L,2L,5L,8L,0L,6L,4L,5L,1L,6L,1L,2L,9L,0L,3L,2L,2L,5L,8L,0L,6L,4L,5L,1L,6L,1L,2L,9L,0L,3L,2L,2L,5L,8L,0L,6L,4L,5L,1L,6L,1L,2L,9L,0L,3L,2L,2L,5L,8L,0L,6L,4L,5L,1L,6L,1L,2L,9L,0L,3L,2L,2L,5L,8L,0L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021996Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021996.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021996Inst : IEnumerable<long>
{
public static readonly long[] Value=A021996.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021996.Bytes);
public long this[int i]=>Value[i];

public static A021996Inst Instance=new A021996Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021997
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,7L,0L,4L,9L,3L,4L,5L,4L,1L,7L,9L,2L,5L,4L,7L,8L,3L,4L,8L,4L,3L,9L,0L,7L,3L,5L,1L,4L,6L,0L,2L,2L,1L,5L,5L,0L,8L,5L,5L,9L,9L,1L,9L,4L,3L,6L,0L,5L,2L,3L,6L,6L,5L,6L,5L,9L,6L,1L,7L,3L,2L,1L,2L,4L,8L,7L,4L,1L,1L,8L,8L,3L,1L,8L,2L,2L,7L,5L,9L,3L,1L,5L,2L,0L,6L,4L,4L,5L,1L,1L,5L,8L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021997Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021997.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021997Inst : IEnumerable<long>
{
public static readonly long[] Value=A021997.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021997.Bytes);
public long this[int i]=>Value[i];

public static A021997Inst Instance=new A021997Inst();

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

public static class A022046
{
public static readonly long[] Value={ 1L,420L,21870L,331240L,2128260L,8972712L,29822520L,80027280L,193511790L,409172940L,825736296L,1509537960L,2698852520L,4472616120L,7347537600L,11335886864L,17520853380L,25553816400L,37658603350L,52706867640L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022046Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022046.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022046Inst : IEnumerable<long>
{
public static readonly long[] Value=A022046.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022046.Bytes);
public long this[int i]=>Value[i];

public static A022046Inst Instance=new A022046Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022047
{
public static readonly long[] Value={ 1L,480L,29152L,525952L,3994080L,18626112L,67978880L,197120256L,509145568L,1143441760L,2428524096L,4658843520L,8705492608L,15000919872L,25593401600L,40864033536L,65187410400L,98098623936L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022047Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022047.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022047Inst : IEnumerable<long>
{
public static readonly long[] Value=A022047.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022047.Bytes);
public long this[int i]=>Value[i];

public static A022047Inst Instance=new A022047Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022048
{
public static readonly long[] Value={ 1L,544L,38114L,808384L,7213984L,37569728L,149405248L,470966912L,1291650786L,3101265120L,6883061184L,13967503552L,27036220096L,48877735232L,85898222336L,142979339392L,233808578464L,365627715968L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022048Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022048.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022048Inst : IEnumerable<long>
{
public static readonly long[] Value=A022048.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022048.Bytes);
public long this[int i]=>Value[i];

public static A022048Inst Instance=new A022048Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022049
{
public static readonly long[] Value={ 1L,612L,48996L,1207680L,12573540L,73617480L,318102912L,1090632960L,3176573796L,8148505828L,18918517320L,40578145920L,81375600000L,154398101832L,279331331328L,484986858240L,812932819812L,1320330798792L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022049Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022049.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022049Inst : IEnumerable<long>
{
public static readonly long[] Value=A022049.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022049.Bytes);
public long this[int i]=>Value[i];

public static A022049Inst Instance=new A022049Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022050
{
public static readonly long[] Value={ 1L,684L,62054L,1759704L,21210156L,140116184L,658369608L,2449182384L,7597766246L,20748447108L,50601708504L,114223115480L,238352317656L,472600643976L,883678139136L,1594639240368L,2749536787500L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022050Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022050.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022050Inst : IEnumerable<long>
{
public static readonly long[] Value=A022050.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022050.Bytes);
public long this[int i]=>Value[i];

public static A022050Inst Instance=new A022050Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022051
{
public static readonly long[] Value={ 1L,760L,77560L,2508000L,34729720L,259114704L,1327461600L,5341699520L,17701924600L,51294999960L,131880275664L,312126610080L,680432137440L,1404010658960L,2724593155520L,5089580732736L,9062110326520L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022051Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022051.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022051Inst : IEnumerable<long>
{
public static readonly long[] Value=A022051.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022051.Bytes);
public long this[int i]=>Value[i];

public static A022051Inst Instance=new A022051Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022052
{
public static readonly long[] Value={ 1L,840L,95802L,3504816L,55350120L,465944304L,2610853840L,11337146784L,40208417466L,123411903160L,335056780464L,830096613360L,1893781702512L,4058779021584L,8190877926720L,15805879161632L,29122237029480L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022052Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022052.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022052Inst : IEnumerable<long>
{
public static readonly long[] Value=A022052.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022052.Bytes);
public long this[int i]=>Value[i];

public static A022052Inst Instance=new A022052Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022053
{
public static readonly long[] Value={ 1L,924L,117084L,4812192L,86075484L,815677016L,5012882336L,23460347328L,89096422492L,289559673084L,830202403800L,2153312518240L,5140361517984L,11444537517336L,24015334687168L,47873378766400L,91281903219804L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022053Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022053.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022053Inst : IEnumerable<long>
{
public static readonly long[] Value=A022053.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022053.Bytes);
public long this[int i]=>Value[i];

public static A022053Inst Instance=new A022053Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022054
{
public static readonly long[] Value={ 1L,1012L,141726L,6503112L,130905236L,1392036360L,9401213016L,47412641232L,192747766686L,663612939132L,2007831887432L,5456890474248L,13617909938952L,31527898462552L,68719323996224L,141662701280848L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022054Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022054.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022054Inst : IEnumerable<long>
{
public static readonly long[] Value=A022054.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022054.Bytes);
public long this[int i]=>Value[i];

public static A022054Inst Instance=new A022054Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022055
{
public static readonly long[] Value={ 1L,1104L,170064L,8662720L,195082320L,2319457632L,17231109824L,93703589760L,407488018512L,1487286966928L,4744779429216L,13523760003648L,35250721087168L,84944161233120L,192127452262272L,409984511707776L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022055Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022055.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022055Inst : IEnumerable<long>
{
public static readonly long[] Value=A022055.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022055.Bytes);
public long this[int i]=>Value[i];

public static A022055Inst Instance=new A022055Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022056
{
public static readonly long[] Value={ 1L,1200L,202450L,11389600L,285385200L,3779134240L,30885301600L,181284196800L,842726826450L,3262594952400L,10968671291040L,32802221530400L,89267475949600L,223991253535200L,525491835433600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022056Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022056.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022056Inst : IEnumerable<long>
{
public static readonly long[] Value=A022056.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022056.Bytes);
public long this[int i]=>Value[i];

public static A022056Inst Instance=new A022056Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022057
{
public static readonly long[] Value={ 1L,1300L,239252L,14797120L,410468500L,6030043240L,54177864000L,343594659200L,1706685733012L,7010460268500L,24832297608040L,77924078814400L,221394909419840L,578472382307304L,1407681394953600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022057Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022057.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022057Inst : IEnumerable<long>
{
public static readonly long[] Value=A022057.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022057.Bytes);
public long this[int i]=>Value[i];

public static A022057Inst Instance=new A022057Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022058
{
public static readonly long[] Value={ 1L,1404L,280854L,19014840L,581257404L,9436118328L,93086496360L,638406025200L,3387901252374L,14765641285044L,55108831380408L,181434042582840L,538265644820280L,1464212332875816L,3696677780664960L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022058Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022058.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022058Inst : IEnumerable<long>
{
public static readonly long[] Value=A022058.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022058.Bytes);
public long this[int i]=>Value[i];

public static A022058Inst Instance=new A022058Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022059
{
public static readonly long[] Value={ 1L,1512L,327656L,24189984L,811401192L,14500933104L,156797510688L,1163495873088L,6597606440936L,30505974273096L,119983597365744L,414352982942304L,1283861585339424L,3635198568784944L,9523977599887936L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022059Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022059.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022059Inst : IEnumerable<long>
{
public static readonly long[] Value=A022059.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022059.Bytes);
public long this[int i]=>Value[i];

public static A022059Inst Instance=new A022059Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A022060
{
public static readonly long[] Value={ 1L,1624L,380074L,30488976L,1117791544L,21911472464L,259172461296L,2081117152992L,12613606876714L,61865177248552L,256462892399504L,928859670458448L,3006249397711056L,8858986222461872L,24088488255932096L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A022060Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A022060.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A022060Inst : IEnumerable<long>
{
public static readonly long[] Value=A022060.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A022060.Bytes);
public long this[int i]=>Value[i];

public static A022060Inst Instance=new A022060Inst();

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

}