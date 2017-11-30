using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A110641
{
public static readonly long[] Value={ 1L,3L,5L,8L,7L,7L,7L,9L,8L,8L,5L,6L,10L,1L,5L,5L,4L,6L,8L,2L,3L,6L,2L,2L,6L,2L,4L,4L,3L,6L,4L,3L,10L,3L,10L,6L,5L,6L,10L,2L,8L,10L,9L,1L,5L,9L,2L,10L,7L,2L,10L,3L,5L,2L,7L,3L,2L,7L,7L,7L,10L,5L,5L,9L,1L,4L,4L,9L,9L,2L,7L,4L,2L,2L,7L,7L,5L,10L,4L,5L,2L,8L,2L,7L,1L,2L,3L,6L,6L,4L,4L,10L,5L,1L,2L,10L,1L,8L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110641Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110641.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110641Inst : IEnumerable<long>
{
public static readonly long[] Value=A110641.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110641.Bytes);
public long this[int i]=>Value[i];

public static A110641Inst Instance=new A110641Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110642
{
public static readonly long[] Value={ 1L,2L,3L,2L,5L,8L,8L,4L,7L,2L,7L,4L,7L,2L,9L,6L,8L,8L,8L,8L,5L,8L,6L,2L,10L,4L,1L,4L,5L,6L,5L,10L,4L,4L,6L,10L,8L,4L,2L,8L,3L,10L,6L,10L,2L,8L,2L,6L,6L,4L,2L,10L,4L,8L,4L,10L,3L,2L,6L,2L,4L,2L,3L,8L,10L,10L,3L,6L,10L,10L,6L,8L,5L,8L,6L,4L,10L,2L,2L,4L,8L,2L,10L,4L,9L,6L,1L,6L,5L,10L,9L,8L,2L,8L,10L,4L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110642Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110642.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110642Inst : IEnumerable<long>
{
public static readonly long[] Value=A110642.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110642.Bytes);
public long this[int i]=>Value[i];

public static A110642Inst Instance=new A110642Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110643
{
public static readonly long[] Value={ 1L,5L,10L,5L,10L,3L,5L,10L,10L,10L,5L,5L,5L,5L,5L,8L,10L,10L,5L,10L,7L,10L,5L,10L,5L,7L,5L,5L,10L,10L,7L,10L,10L,5L,5L,9L,5L,5L,5L,10L,8L,10L,10L,10L,10L,8L,5L,5L,10L,10L,5L,10L,10L,10L,5L,6L,5L,5L,10L,5L,10L,10L,5L,10L,10L,1L,5L,5L,10L,10L,5L,5L,5L,10L,5L,5L,10L,5L,5L,10L,4L,10L,10L,5L,5L,6L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110643Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110643.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110643Inst : IEnumerable<long>
{
public static readonly long[] Value=A110643.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110643.Bytes);
public long this[int i]=>Value[i];

public static A110643Inst Instance=new A110643Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110644
{
public static readonly long[] Value={ 1L,1L,7L,4L,9L,5L,5L,1L,5L,5L,11L,11L,9L,5L,11L,4L,8L,10L,10L,8L,10L,5L,11L,6L,1L,7L,1L,11L,5L,10L,1L,9L,4L,3L,9L,6L,8L,1L,6L,3L,4L,8L,2L,4L,4L,8L,10L,2L,4L,11L,1L,7L,11L,9L,11L,5L,2L,1L,4L,7L,9L,3L,2L,5L,8L,1L,8L,7L,4L,3L,2L,3L,5L,9L,1L,9L,5L,4L,1L,4L,6L,8L,5L,6L,9L,7L,4L,4L,5L,4L,6L,4L,10L,6L,6L,9L,9L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110644Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110644.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110644Inst : IEnumerable<long>
{
public static readonly long[] Value=A110644.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110644.Bytes);
public long this[int i]=>Value[i];

public static A110644Inst Instance=new A110644Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110645
{
public static readonly long[] Value={ 1L,6L,12L,2L,8L,9L,2L,7L,12L,2L,3L,4L,9L,10L,12L,9L,2L,5L,12L,9L,8L,10L,1L,9L,7L,2L,9L,4L,11L,1L,10L,5L,4L,1L,12L,2L,9L,4L,5L,11L,12L,12L,9L,5L,12L,5L,3L,12L,1L,4L,6L,2L,10L,11L,5L,1L,6L,10L,12L,9L,11L,9L,9L,5L,3L,3L,7L,2L,6L,7L,5L,9L,5L,10L,12L,5L,5L,4L,4L,2L,1L,8L,7L,11L,7L,6L,1L,2L,5L,10L,9L,8L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110645Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110645.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110645Inst : IEnumerable<long>
{
public static readonly long[] Value=A110645.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110645.Bytes);
public long this[int i]=>Value[i];

public static A110645Inst Instance=new A110645Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110646
{
public static readonly long[] Value={ 1L,4L,6L,8L,12L,10L,2L,12L,8L,4L,9L,4L,2L,6L,7L,8L,12L,12L,2L,2L,3L,4L,4L,2L,9L,6L,10L,6L,12L,2L,9L,10L,2L,2L,5L,6L,12L,2L,9L,8L,8L,8L,10L,8L,1L,4L,9L,10L,7L,10L,2L,6L,9L,10L,4L,8L,11L,2L,1L,4L,10L,2L,5L,2L,4L,2L,1L,8L,12L,2L,2L,12L,9L,2L,4L,4L,5L,8L,11L,4L,12L,4L,12L,6L,9L,12L,5L,6L,12L,10L,5L,12L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110646Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110646.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110646Inst : IEnumerable<long>
{
public static readonly long[] Value=A110646.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110646.Bytes);
public long this[int i]=>Value[i];

public static A110646Inst Instance=new A110646Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110647
{
public static readonly long[] Value={ 1L,9L,12L,6L,12L,9L,12L,6L,6L,2L,6L,12L,8L,3L,12L,9L,6L,12L,2L,3L,3L,7L,9L,9L,12L,3L,3L,2L,12L,6L,3L,9L,3L,4L,6L,3L,9L,6L,3L,10L,6L,9L,12L,9L,12L,9L,9L,6L,2L,9L,12L,5L,3L,6L,12L,9L,6L,9L,12L,6L,8L,6L,12L,10L,9L,12L,1L,9L,3L,9L,12L,6L,7L,12L,12L,2L,9L,3L,9L,12L,12L,4L,9L,9L,11L,6L,6L,1L,9L,6L,10L,3L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110647Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110647.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110647Inst : IEnumerable<long>
{
public static readonly long[] Value=A110647.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110647.Bytes);
public long this[int i]=>Value[i];

public static A110647Inst Instance=new A110647Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110648
{
public static readonly long[] Value={ 1L,4L,4L,8L,6L,12L,8L,12L,12L,12L,10L,12L,2L,8L,12L,4L,8L,8L,4L,4L,9L,4L,4L,12L,2L,12L,6L,8L,7L,4L,8L,12L,12L,8L,12L,8L,2L,8L,2L,8L,3L,12L,4L,12L,4L,12L,2L,12L,9L,12L,6L,12L,10L,8L,6L,12L,12L,12L,2L,8L,9L,12L,10L,12L,2L,8L,2L,4L,5L,4L,6L,12L,12L,8L,2L,12L,9L,4L,8L,4L,8L,12L,8L,4L,10L,8L,8L,12L,1L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110648Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110648.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110648Inst : IEnumerable<long>
{
public static readonly long[] Value=A110648.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110648.Bytes);
public long this[int i]=>Value[i];

public static A110648Inst Instance=new A110648Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110649
{
public static readonly long[] Value={ 1L,6L,9L,4L,12L,6L,6L,12L,12L,8L,9L,12L,12L,6L,6L,10L,6L,12L,2L,6L,6L,12L,12L,12L,8L,12L,3L,4L,12L,12L,9L,6L,6L,4L,12L,12L,2L,6L,3L,6L,3L,6L,7L,6L,9L,8L,9L,12L,12L,12L,3L,12L,3L,6L,2L,6L,12L,2L,6L,6L,3L,12L,9L,4L,3L,12L,4L,12L,6L,2L,3L,12L,9L,6L,6L,6L,3L,6L,10L,6L,6L,6L,9L,6L,12L,12L,9L,2L,12L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110649Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110649.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110649Inst : IEnumerable<long>
{
public static readonly long[] Value=A110649.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110649.Bytes);
public long this[int i]=>Value[i];

public static A110649Inst Instance=new A110649Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110650
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,16L,2L,8L,9L,81L,3L,27L,16L,256L,4L,64L,25L,625L,5L,125L,36L,1296L,6L,216L,49L,2401L,7L,343L,64L,4096L,8L,512L,81L,6561L,9L,729L,100L,10000L,10L,1000L,121L,14641L,11L,1331L,144L,20736L,12L,1728L,169L,28561L,13L,2197L,196L,38416L,14L,2744L,225L,50625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110650Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110650.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110650Inst : IEnumerable<long>
{
public static readonly long[] Value=A110650.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110650.Bytes);
public long this[int i]=>Value[i];

public static A110650Inst Instance=new A110650Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110651
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,16L,8L,2L,9L,81L,27L,3L,16L,256L,64L,4L,25L,625L,125L,5L,36L,1296L,216L,6L,49L,2401L,343L,7L,64L,4096L,512L,8L,81L,6561L,729L,9L,100L,10000L,1000L,10L,121L,14641L,1331L,11L,144L,20736L,1728L,12L,169L,28561L,2197L,13L,196L,38416L,2744L,14L,225L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110651Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110651.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110651Inst : IEnumerable<long>
{
public static readonly long[] Value=A110651.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110651.Bytes);
public long this[int i]=>Value[i];

public static A110651Inst Instance=new A110651Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110652
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,8L,16L,2L,9L,27L,81L,3L,16L,64L,256L,4L,25L,125L,625L,5L,36L,216L,1296L,6L,49L,343L,2401L,7L,64L,512L,4096L,8L,81L,729L,6561L,9L,100L,1000L,10000L,10L,121L,1331L,14641L,11L,144L,1728L,20736L,12L,169L,2197L,28561L,13L,196L,2744L,38416L,14L,225L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110652Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110652.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110652Inst : IEnumerable<long>
{
public static readonly long[] Value=A110652.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110652.Bytes);
public long this[int i]=>Value[i];

public static A110652Inst Instance=new A110652Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110653
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,8L,2L,16L,9L,27L,3L,81L,16L,64L,4L,256L,25L,125L,5L,625L,36L,216L,6L,1296L,49L,343L,7L,2401L,64L,512L,8L,4096L,81L,729L,9L,6561L,100L,1000L,10L,10000L,121L,1331L,11L,14641L,144L,1728L,12L,20736L,169L,2197L,13L,28561L,196L,2744L,14L,38416L,225L,3375L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110653Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110653.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110653Inst : IEnumerable<long>
{
public static readonly long[] Value=A110653.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110653.Bytes);
public long this[int i]=>Value[i];

public static A110653Inst Instance=new A110653Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110654
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,3L,3L,4L,4L,5L,5L,6L,6L,7L,7L,8L,8L,9L,9L,10L,10L,11L,11L,12L,12L,13L,13L,14L,14L,15L,15L,16L,16L,17L,17L,18L,18L,19L,19L,20L,20L,21L,21L,22L,22L,23L,23L,24L,24L,25L,25L,26L,26L,27L,27L,28L,28L,29L,29L,30L,30L,31L,31L,32L,32L,33L,33L,34L,34L,35L,35L,36L,36L,37L,37L,38L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110654Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110654.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110654Inst : IEnumerable<long>
{
public static readonly long[] Value=A110654.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110654.Bytes);
public long this[int i]=>Value[i];

public static A110654Inst Instance=new A110654Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110655
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,2L,2L,2L,2L,3L,3L,3L,3L,4L,4L,4L,4L,5L,5L,5L,5L,6L,6L,6L,6L,7L,7L,7L,7L,8L,8L,8L,8L,9L,9L,9L,9L,10L,10L,10L,10L,11L,11L,11L,11L,12L,12L,12L,12L,13L,13L,13L,13L,14L,14L,14L,14L,15L,15L,15L,15L,16L,16L,16L,16L,17L,17L,17L,17L,18L,18L,18L,18L,19L,19L,19L,19L,20L,20L,20L,20L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110655Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110655.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110655Inst : IEnumerable<long>
{
public static readonly long[] Value=A110655.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110655.Bytes);
public long this[int i]=>Value[i];

public static A110655Inst Instance=new A110655Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110656
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,2L,2L,2L,3L,3L,3L,3L,3L,3L,3L,3L,4L,4L,4L,4L,4L,4L,4L,4L,5L,5L,5L,5L,5L,5L,5L,5L,6L,6L,6L,6L,6L,6L,6L,6L,7L,7L,7L,7L,7L,7L,7L,7L,8L,8L,8L,8L,8L,8L,8L,8L,9L,9L,9L,9L,9L,9L,9L,9L,10L,10L,10L,10L,10L,10L,10L,10L,11L,11L,11L,11L,11L,11L,11L,11L,12L,12L,12L,12L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110656Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110656.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110656Inst : IEnumerable<long>
{
public static readonly long[] Value=A110656.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110656.Bytes);
public long this[int i]=>Value[i];

public static A110656Inst Instance=new A110656Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110657
{
public static readonly long[] Value={ 0L,1L,2L,0L,1L,2L,3L,1L,2L,3L,4L,2L,3L,4L,5L,3L,4L,5L,6L,4L,5L,6L,7L,5L,6L,7L,8L,6L,7L,8L,9L,7L,8L,9L,10L,8L,9L,10L,11L,9L,10L,11L,12L,10L,11L,12L,13L,11L,12L,13L,14L,12L,13L,14L,15L,13L,14L,15L,16L,14L,15L,16L,17L,15L,16L,17L,18L,16L,17L,18L,19L,17L,18L,19L,20L,18L,19L,20L,21L,19L,20L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110657Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110657.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110657Inst : IEnumerable<long>
{
public static readonly long[] Value=A110657.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110657.Bytes);
public long this[int i]=>Value[i];

public static A110657Inst Instance=new A110657Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110658
{
public static readonly long[] Value={ 1L,0L,2L,1L,0L,2L,1L,0L,2L,1L,3L,2L,1L,3L,2L,1L,3L,2L,4L,3L,2L,4L,3L,2L,4L,3L,5L,4L,3L,5L,4L,3L,5L,4L,6L,5L,4L,6L,5L,4L,6L,5L,7L,6L,5L,7L,6L,5L,7L,6L,8L,7L,6L,8L,7L,6L,8L,7L,9L,8L,7L,9L,8L,7L,9L,8L,10L,9L,8L,10L,9L,8L,10L,9L,11L,10L,9L,11L,10L,9L,11L,10L,12L,11L,10L,12L,11L,10L,12L,11L,13L,12L,11L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110658Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110658.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110658Inst : IEnumerable<long>
{
public static readonly long[] Value=A110658.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110658.Bytes);
public long this[int i]=>Value[i];

public static A110658Inst Instance=new A110658Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110659
{
public static readonly long[] Value={ 1L,0L,0L,2L,2L,1L,1L,3L,3L,2L,2L,4L,4L,3L,3L,5L,5L,4L,4L,6L,6L,5L,5L,7L,7L,6L,6L,8L,8L,7L,7L,9L,9L,8L,8L,10L,10L,9L,9L,11L,11L,10L,10L,12L,12L,11L,11L,13L,13L,12L,12L,14L,14L,13L,13L,15L,15L,14L,14L,16L,16L,15L,15L,17L,17L,16L,16L,18L,18L,17L,17L,19L,19L,18L,18L,20L,20L,19L,19L,21L,21L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110659Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110659.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110659Inst : IEnumerable<long>
{
public static readonly long[] Value=A110659.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110659.Bytes);
public long this[int i]=>Value[i];

public static A110659Inst Instance=new A110659Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110660
{
public static readonly long[] Value={ 0L,0L,2L,2L,6L,6L,12L,12L,20L,20L,30L,30L,42L,42L,56L,56L,72L,72L,90L,90L,110L,110L,132L,132L,156L,156L,182L,182L,210L,210L,240L,240L,272L,272L,306L,306L,342L,342L,380L,380L,420L,420L,462L,462L,506L,506L,552L,552L,600L,600L,650L,650L,702L,702L,756L,756L,812L,812L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110660Inst : IEnumerable<long>
{
public static readonly long[] Value=A110660.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110660.Bytes);
public long this[int i]=>Value[i];

public static A110660Inst Instance=new A110660Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110661
{
public static readonly long[] Value={ 1L,3L,2L,5L,4L,2L,8L,7L,5L,3L,10L,9L,7L,5L,2L,14L,13L,11L,9L,6L,4L,16L,15L,13L,11L,8L,6L,2L,20L,19L,17L,15L,12L,10L,6L,4L,23L,22L,20L,18L,15L,13L,9L,7L,3L,27L,26L,24L,22L,19L,17L,13L,11L,7L,4L,29L,28L,26L,24L,21L,19L,15L,13L,9L,6L,2L,35L,34L,32L,30L,27L,25L,21L,19L,15L,12L,8L,6L,37L,36L,34L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110661Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110661.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110661Inst : IEnumerable<long>
{
public static readonly long[] Value=A110661.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110661.Bytes);
public long this[int i]=>Value[i];

public static A110661Inst Instance=new A110661Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110662
{
public static readonly long[] Value={ 1L,4L,3L,8L,7L,4L,15L,14L,11L,7L,21L,20L,17L,13L,6L,33L,32L,29L,25L,18L,12L,41L,40L,37L,33L,26L,20L,8L,56L,55L,52L,48L,41L,35L,23L,15L,69L,68L,65L,61L,54L,48L,36L,28L,13L,87L,86L,83L,79L,72L,66L,54L,46L,31L,18L,99L,98L,95L,91L,84L,78L,66L,58L,43L,30L,12L,127L,126L,123L,119L,112L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110662Inst : IEnumerable<long>
{
public static readonly long[] Value=A110662.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110662.Bytes);
public long this[int i]=>Value[i];

public static A110662Inst Instance=new A110662Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110663
{
public static readonly long[] Value={ 1L,2L,1L,4L,3L,2L,6L,5L,4L,2L,10L,9L,8L,6L,4L,12L,11L,10L,8L,6L,2L,18L,17L,16L,14L,12L,8L,6L,22L,21L,20L,18L,16L,12L,10L,4L,28L,27L,26L,24L,22L,18L,16L,10L,6L,32L,31L,30L,28L,26L,22L,20L,14L,10L,4L,42L,41L,40L,38L,36L,32L,30L,24L,20L,14L,10L,46L,45L,44L,42L,40L,36L,34L,28L,24L,18L,14L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110663Inst : IEnumerable<long>
{
public static readonly long[] Value=A110663.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110663.Bytes);
public long this[int i]=>Value[i];

public static A110663Inst Instance=new A110663Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110664
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,1L,4L,4L,3L,2L,5L,5L,4L,3L,1L,7L,7L,6L,5L,3L,2L,8L,8L,7L,6L,4L,3L,1L,11L,11L,10L,9L,7L,6L,4L,3L,13L,13L,12L,11L,9L,8L,6L,5L,2L,15L,15L,14L,13L,11L,10L,8L,7L,4L,2L,16L,16L,15L,14L,12L,11L,9L,8L,5L,3L,1L,19L,19L,18L,17L,15L,14L,12L,11L,8L,6L,4L,3L,20L,20L,19L,18L,16L,15L,13L,12L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110664Inst : IEnumerable<long>
{
public static readonly long[] Value=A110664.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110664.Bytes);
public long this[int i]=>Value[i];

public static A110664Inst Instance=new A110664Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110665
{
public static readonly long[] Value={ 0L,1L,0L,-3L,-4L,0L,6L,7L,0L,-9L,-10L,0L,12L,13L,0L,-15L,-16L,0L,18L,19L,0L,-21L,-22L,0L,24L,25L,0L,-27L,-28L,0L,30L,31L,0L,-33L,-34L,0L,36L,37L,0L,-39L,-40L,0L,42L,43L,0L,-45L,-46L,0L,48L,49L,0L,-51L,-52L,0L,54L,55L,0L,-57L,-58L,0L,60L,61L,0L,-63L,-64L,0L,66L,67L,0L,-69L,-70L,0L,72L,73L,0L,-75L,-76L,0L,78L,79L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110665Inst : IEnumerable<long>
{
public static readonly long[] Value=A110665.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110665.Bytes);
public long this[int i]=>Value[i];

public static A110665Inst Instance=new A110665Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110666
{
public static readonly long[] Value={ 0L,1L,1L,-2L,-6L,-6L,0L,7L,7L,-2L,-12L,-12L,0L,13L,13L,-2L,-18L,-18L,0L,19L,19L,-2L,-24L,-24L,0L,25L,25L,-2L,-30L,-30L,0L,31L,31L,-2L,-36L,-36L,0L,37L,37L,-2L,-42L,-42L,0L,43L,43L,-2L,-48L,-48L,0L,49L,49L,-2L,-54L,-54L,0L,55L,55L,-2L,-60L,-60L,0L,61L,61L,-2L,-66L,-66L,0L,67L,67L,-2L,-72L,-72L,0L,73L,73L,-2L,-78L,-78L,0L,79L,79L,-2L,-84L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110666Inst : IEnumerable<long>
{
public static readonly long[] Value=A110666.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110666.Bytes);
public long this[int i]=>Value[i];

public static A110666Inst Instance=new A110666Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110667
{
public static readonly long[] Value={ 0L,1L,2L,0L,-6L,-12L,-12L,-5L,2L,0L,-12L,-24L,-24L,-11L,2L,0L,-18L,-36L,-36L,-17L,2L,0L,-24L,-48L,-48L,-23L,2L,0L,-30L,-60L,-60L,-29L,2L,0L,-36L,-72L,-72L,-35L,2L,0L,-42L,-84L,-84L,-41L,2L,0L,-48L,-96L,-96L,-47L,2L,0L,-54L,-108L,-108L,-53L,2L,0L,-60L,-120L,-120L,-59L,2L,0L,-66L,-132L,-132L,-65L,2L,0L,-72L,-144L,-144L,-71L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110667Inst : IEnumerable<long>
{
public static readonly long[] Value=A110667.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110667.Bytes);
public long this[int i]=>Value[i];

public static A110667Inst Instance=new A110667Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110668
{
public static readonly long[] Value={ 0L,1L,3L,3L,-3L,-15L,-27L,-32L,-30L,-30L,-42L,-66L,-90L,-101L,-99L,-99L,-117L,-153L,-189L,-206L,-204L,-204L,-228L,-276L,-324L,-347L,-345L,-345L,-375L,-435L,-495L,-524L,-522L,-522L,-558L,-630L,-702L,-737L,-735L,-735L,-777L,-861L,-945L,-986L,-984L,-984L,-1032L,-1128L,-1224L,-1271L,-1269L,-1269L,-1323L,-1431L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110668Inst : IEnumerable<long>
{
public static readonly long[] Value=A110668.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110668.Bytes);
public long this[int i]=>Value[i];

public static A110668Inst Instance=new A110668Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110669
{
public static readonly long[] Value={ 0L,1L,4L,7L,4L,-11L,-38L,-70L,-100L,-130L,-172L,-238L,-328L,-429L,-528L,-627L,-744L,-897L,-1086L,-1292L,-1496L,-1700L,-1928L,-2204L,-2528L,-2875L,-3220L,-3565L,-3940L,-4375L,-4870L,-5394L,-5916L,-6438L,-6996L,-7626L,-8328L,-9065L,-9800L,-10535L,-11312L,-12173L,-13118L,-14104L,-15088L,-16072L,-17104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110669Inst : IEnumerable<long>
{
public static readonly long[] Value=A110669.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110669.Bytes);
public long this[int i]=>Value[i];

public static A110669Inst Instance=new A110669Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110670
{
public static readonly long[] Value={ 0L,1L,5L,12L,16L,5L,-33L,-103L,-203L,-333L,-505L,-743L,-1071L,-1500L,-2028L,-2655L,-3399L,-4296L,-5382L,-6674L,-8170L,-9870L,-11798L,-14002L,-16530L,-19405L,-22625L,-26190L,-30130L,-34505L,-39375L,-44769L,-50685L,-57123L,-64119L,-71745L,-80073L,-89138L,-98938L,-109473L,-120785L,-132958L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110670Inst : IEnumerable<long>
{
public static readonly long[] Value=A110670.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110670.Bytes);
public long this[int i]=>Value[i];

public static A110670Inst Instance=new A110670Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110671
{
public static readonly long[] Value={ 0L,1L,6L,18L,34L,39L,6L,-97L,-300L,-633L,-1138L,-1881L,-2952L,-4452L,-6480L,-9135L,-12534L,-16830L,-22212L,-28886L,-37056L,-46926L,-58724L,-72726L,-89256L,-108661L,-131286L,-157476L,-187606L,-222111L,-261486L,-306255L,-356940L,-414063L,-478182L,-549927L,-630000L,-719138L,-818076L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110671Inst : IEnumerable<long>
{
public static readonly long[] Value=A110671.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110671.Bytes);
public long this[int i]=>Value[i];

public static A110671Inst Instance=new A110671Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110672
{
public static readonly long[] Value={ 0L,1L,7L,25L,59L,98L,104L,7L,-293L,-926L,-2064L,-3945L,-6897L,-11349L,-17829L,-26964L,-39498L,-56328L,-78540L,-107426L,-144482L,-191408L,-250132L,-322858L,-412114L,-520775L,-652061L,-809537L,-997143L,-1219254L,-1480740L,-1786995L,-2143935L,-2557998L,-3036180L,-3586107L,-4216107L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110672Inst : IEnumerable<long>
{
public static readonly long[] Value=A110672.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110672.Bytes);
public long this[int i]=>Value[i];

public static A110672Inst Instance=new A110672Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110673
{
public static readonly long[] Value={ 23L,37L,47L,53L,67L,79L,83L,89L,93L,97L,113L,117L,119L,121L,123L,127L,131L,143L,145L,157L,163L,167L,173L,185L,187L,203L,205L,207L,211L,215L,217L,219L,223L,233L,245L,247L,251L,257L,263L,277L,287L,289L,293L,297L,299L,301L,303L,307L,317L,321L,323L,325L,327L,331L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110673Inst : IEnumerable<long>
{
public static readonly long[] Value=A110673.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110673.Bytes);
public long this[int i]=>Value[i];

public static A110673Inst Instance=new A110673Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110674
{
public static readonly long[] Value={ 3L,7L,9L,19L,21L,27L,43L,49L,87L,91L,151L,157L,169L,181L,183L,189L,211L,213L,219L,247L,259L,283L,289L,301L,333L,339L,351L,361L,379L,393L,399L,423L,427L,433L,447L,457L,489L,493L,499L,531L,543L,547L,553L,559L,573L,577L,637L,639L,651L,661L,667L,673L,687L,703L,711L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110674Inst : IEnumerable<long>
{
public static readonly long[] Value=A110674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110674.Bytes);
public long this[int i]=>Value[i];

public static A110674Inst Instance=new A110674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110675
{
public static readonly long[] Value={ 9L,47L,69L,89L,93L,123L,141L,147L,167L,177L,203L,219L,239L,243L,249L,251L,263L,273L,281L,287L,293L,309L,317L,321L,327L,333L,351L,377L,383L,387L,443L,477L,501L,503L,509L,527L,533L,537L,543L,567L,573L,579L,593L,599L,611L,617L,621L,629L,653L,659L,663L,683L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110675Inst : IEnumerable<long>
{
public static readonly long[] Value=A110675.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110675.Bytes);
public long this[int i]=>Value[i];

public static A110675Inst Instance=new A110675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110676
{
public static readonly long[] Value={ 1L,2L,2L,3L,3L,4L,3L,6L,3L,5L,4L,5L,5L,9L,3L,4L,9L,3L,6L,10L,6L,7L,6L,11L,5L,11L,10L,5L,10L,9L,3L,12L,6L,10L,9L,5L,6L,13L,9L,6L,11L,6L,10L,16L,4L,4L,6L,9L,6L,11L,8L,4L,10L,10L,5L,13L,10L,7L,11L,6L,6L,21L,4L,23L,8L,6L,8L,15L,15L,7L,12L,7L,8L,19L,8L,13L,14L,5L,6L,20L,6L,10L,13L,12L,7L,9L,9L,6L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110676Inst : IEnumerable<long>
{
public static readonly long[] Value=A110676.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110676.Bytes);
public long this[int i]=>Value[i];

public static A110676Inst Instance=new A110676Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110677
{
public static readonly long[] Value={ 1L,23L,31L,37L,41L,49L,67L,83L,97L,103L,119L,131L,133L,163L,199L,203L,217L,221L,233L,251L,257L,263L,277L,283L,301L,307L,311L,313L,331L,373L,383L,391L,397L,401L,419L,427L,431L,433L,439L,469L,481L,497L,509L,511L,527L,593L,601L,611L,619L,641L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110677Inst : IEnumerable<long>
{
public static readonly long[] Value=A110677.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110677.Bytes);
public long this[int i]=>Value[i];

public static A110677Inst Instance=new A110677Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110678
{
public static readonly long[] Value={ 72L,70L,66L,60L,52L,42L,30L,16L,0L,-18L,-38L,-60L,-84L,-110L,-138L,-168L,-200L,-234L,-270L,-308L,-348L,-390L,-434L,-480L,-528L,-578L,-630L,-684L,-740L,-798L,-858L,-920L,-984L,-1050L,-1118L,-1188L,-1260L,-1334L,-1410L,-1488L,-1568L,-1650L,-1734L,-1820L,-1908L,-1998L,-2090L,-2184L,-2280L,-2378L,-2478L,-2580L,-2684L,-2790L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110678Inst : IEnumerable<long>
{
public static readonly long[] Value=A110678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110678.Bytes);
public long this[int i]=>Value[i];

public static A110678Inst Instance=new A110678Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110679
{
public static readonly long[] Value={ 1L,2L,11L,44L,189L,798L,3383L,14328L,60697L,257114L,1089155L,4613732L,19544085L,82790070L,350704367L,1485607536L,6293134513L,26658145586L,112925716859L,478361013020L,2026369768941L,8583840088782L,36361730124071L,154030760585064L,652484772464329L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110679Inst : IEnumerable<long>
{
public static readonly long[] Value=A110679.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110679.Bytes);
public long this[int i]=>Value[i];

public static A110679Inst Instance=new A110679Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110680
{
public static readonly long[] Value={ 9L,21L,43L,49L,61L,63L,69L,73L,87L,109L,127L,147L,159L,169L,171L,201L,207L,213L,217L,229L,241L,261L,289L,291L,331L,339L,357L,369L,381L,397L,409L,469L,471L,483L,487L,507L,519L,549L,591L,607L,621L,639L,663L,669L,697L,703L,711L,717L,729L,747L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110680Inst : IEnumerable<long>
{
public static readonly long[] Value=A110680.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110680.Bytes);
public long this[int i]=>Value[i];

public static A110680Inst Instance=new A110680Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110681
{
public static readonly long[] Value={ 1L,2L,1L,6L,4L,1L,20L,16L,6L,1L,72L,64L,30L,8L,1L,272L,260L,140L,48L,10L,1L,1064L,1072L,636L,256L,70L,12L,1L,4272L,4480L,2856L,1288L,420L,96L,14L,1L,17504L,18944L,12768L,6272L,2320L,640L,126L,16L,1L,72896L,80928L,57024L,29952L,12192L,3852L,924L,160L,18L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110681Inst : IEnumerable<long>
{
public static readonly long[] Value=A110681.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110681.Bytes);
public long this[int i]=>Value[i];

public static A110681Inst Instance=new A110681Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110682
{
public static readonly long[] Value={ 1L,2L,1L,10L,4L,1L,66L,24L,6L,1L,498L,172L,42L,8L,1L,4066L,1360L,326L,64L,10L,1L,34970L,11444L,2706L,536L,90L,12L,1L,312066L,100520L,23526L,4672L,810L,120L,14L,1L,2862562L,911068L,211546L,42024L,7410L,1156L,154L,16L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110682Inst : IEnumerable<long>
{
public static readonly long[] Value=A110682.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110682.Bytes);
public long this[int i]=>Value[i];

public static A110682Inst Instance=new A110682Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110683
{
public static readonly long[] Value={ 1L,-7L,21L,-79L,279L,-997L,3561L,-12781L,45951L,-165355L,595143L,-2142025L,7709073L,-27743437L,99840687L,-359294443L,1292981391L,-4653011185L,16744655841L,-60258539413L,216850840215L,-780375582475L,2808317778903L,-10106221816681L,36369003278769L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110683Inst : IEnumerable<long>
{
public static readonly long[] Value=A110683.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110683.Bytes);
public long this[int i]=>Value[i];

public static A110683Inst Instance=new A110683Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110684
{
public static readonly long[] Value={ 1L,2L,-10L,41L,-148L,530L,-1885L,6734L,-24142L,86765L,-312160L,1123478L,-4043605L,14553002L,-52373938L,188479877L,-678279820L,2440905218L,-8784007861L,31610747846L,-113756727046L,409373349485L,-1473201380488L,5301572336126L,-19078633636789L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110684Inst : IEnumerable<long>
{
public static readonly long[] Value=A110684.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110684.Bytes);
public long this[int i]=>Value[i];

public static A110684Inst Instance=new A110684Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110685
{
public static readonly long[] Value={ -1L,2L,0L,-13L,60L,-220L,765L,-2662L,9384L,-33457L,120048L,-431896L,1554957L,-5598250L,20151564L,-72527377L,261011940L,-939300196L,3380216661L,-12164232958L,43774972368L,-157531648801L,566904871752L,-2040106024480L,7341678056925L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110685Inst : IEnumerable<long>
{
public static readonly long[] Value=A110685.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110685.Bytes);
public long this[int i]=>Value[i];

public static A110685Inst Instance=new A110685Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110686
{
public static readonly long[] Value={ -1L,-4L,14L,-49L,158L,-538L,1877L,-6688L,24026L,-86557L,311882L,-1123270L,4043813L,-14554252L,52377062L,-188485501L,678287318L,-2440910842L,8784002237L,-31610714104L,113756642690L,-409373197645L,1473201178034L,-5301572184286L,19078633788629L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110686Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110686.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110686Inst : IEnumerable<long>
{
public static readonly long[] Value=A110686.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110686.Bytes);
public long this[int i]=>Value[i];

public static A110686Inst Instance=new A110686Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110687
{
public static readonly long[] Value={ 1L,-8L,28L,-100L,358L,-1276L,4558L,-16342L,58732L,-211306L,760498L,-2737168L,9851098L,-35452510L,127584124L,-459135130L,1652275834L,-5945992576L,21397667026L,-77003195254L,277109379628L,-997226422690L,3588693361378L,-12914539595584L,46475225095450L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110687Inst : IEnumerable<long>
{
public static readonly long[] Value=A110687.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110687.Bytes);
public long this[int i]=>Value[i];

public static A110687Inst Instance=new A110687Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110688
{
public static readonly long[] Value={ -1L,1L,-4L,19L,-73L,262L,-931L,3319L,-11884L,42679L,-153505L,552430L,-1988311L,7156123L,-25754188L,92683315L,-333539317L,1200299014L,-4319477491L,15544370887L,-55939087228L,201306503071L,-724436520553L,2607011250526L,-9381785144287L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110688Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110688.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110688Inst : IEnumerable<long>
{
public static readonly long[] Value=A110688.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110688.Bytes);
public long this[int i]=>Value[i];

public static A110688Inst Instance=new A110688Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110689
{
public static readonly long[] Value={ 1L,3L,-18L,63L,-207L,696L,-2415L,8565L,-30714L,110583L,-398439L,1435152L,-5167083L,18598065L,-66931314L,240862563L,-866772819L,3119198160L,-11224913079L,40394716341L,-145367356794L,523129840335L,-1882574375679L,6774773362320L,-24380205972915L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110689Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110689.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110689Inst : IEnumerable<long>
{
public static readonly long[] Value=A110689.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110689.Bytes);
public long this[int i]=>Value[i];

public static A110689Inst Instance=new A110689Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110690
{
public static readonly long[] Value={ 1L,22L,193L,1045L,4180L,13566L,37764L,93456L,210705L,440440L,864721L,1610401L,2866864L,4908580L,8123280L,13046616L,20404233L,31162242L,46587145L,68316325L,98440276L,139597810L,195085540L,268983000L,366294825L,493111476L,656790057L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110690Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110690.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110690Inst : IEnumerable<long>
{
public static readonly long[] Value=A110690.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110690.Bytes);
public long this[int i]=>Value[i];

public static A110690Inst Instance=new A110690Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110691
{
public static readonly long[] Value={ 1L,45L,632L,4825L,25227L,101822L,340416L,986094L,2551725L,6028099L,13209768L,27179087L,53000311L,98685900L,176508416L,304743564L,509943033L,829849833L,1317083800L,2043740853L,3107066435L,4636381354L,6801456960L,9822556250L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110691Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110691.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110691Inst : IEnumerable<long>
{
public static readonly long[] Value=A110691.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110691.Bytes);
public long this[int i]=>Value[i];

public static A110691Inst Instance=new A110691Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110692
{
public static readonly long[] Value={ 1L,29L,275L,1498L,5846L,18250L,48546L,114480L,245751L,489247L,915629L,1627418L,2768740L,4536884L,7195828L,11091888L,16671645L,24502305L,35294647L,49928714L,69482402L,95263102L,128842550L,172095040L,227239155L,296883171L,384074289L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110692Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110692.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110692Inst : IEnumerable<long>
{
public static readonly long[] Value=A110692.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110692.Bytes);
public long this[int i]=>Value[i];

public static A110692Inst Instance=new A110692Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110693
{
public static readonly long[] Value={ 1L,36L,448L,3175L,15786L,61446L,199872L,566676L,1441275L,3356782L,7268976L,14805583L,28621684L,52892100L,93977088L,161303616L,268510869L,434915472L,687359200L,1062509679L,1609692766L,2394343930L,3502175040L,5044162500L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110693Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110693.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110693Inst : IEnumerable<long>
{
public static readonly long[] Value=A110693.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110693.Bytes);
public long this[int i]=>Value[i];

public static A110693Inst Instance=new A110693Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110694
{
public static readonly long[] Value={ 1L,19L,142L,664L,2330L,6726L,16848L,37884L,78243L,150865L,274846L,477412L,796276L,1282412L,2003280L,3046536L,4524261L,6577743L,9382846L,13156000L,18160846L,24715570L,33200960L,44069220L,57853575L,75178701L,96772014L,123475852L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110694Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110694.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110694Inst : IEnumerable<long>
{
public static readonly long[] Value=A110694.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110694.Bytes);
public long this[int i]=>Value[i];

public static A110694Inst Instance=new A110694Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110695
{
public static readonly BigInteger[] Value={ 1L,9L,341L,14859L,671509L,31816259L,1575219491L,80813149559L,4262996933909L,229858972288659L,12613108252122091L,702092835479959559L,BigInteger.Parse("39548041458039952291"),BigInteger.Parse("2250117073947022121799"),BigInteger.Parse("129122621276859925669799") };
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
public class A110695Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110695.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110695Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A110695.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A110695.Bytes);
public BigInteger this[int i]=>Value[i];

public static A110695Inst Instance=new A110695Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110696
{
public static readonly BigInteger[] Value={ 1L,28L,1456L,66178L,3014128L,143076778L,7087202890L,363641489638L,19183237689328L,1034361829223578L,56758935931548706L,3159417013205183638L,BigInteger.Parse("177966175592478108106"),BigInteger.Parse("10125526670502832205398"),BigInteger.Parse("581051793331857091649398") };
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
public class A110696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110696Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A110696.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A110696.Bytes);
public BigInteger this[int i]=>Value[i];

public static A110696Inst Instance=new A110696Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110697
{
public static readonly BigInteger[] Value={ 2L,35L,1547L,67319L,3028619L,143266535L,7089761447L,363676815215L,19183734561419L,1034368920790919L,56759038335333047L,3159418506105987215L,BigInteger.Parse("177966197529849012647"),BigInteger.Parse("10125526995020242083599"),BigInteger.Parse("581051798159881757979599") };
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
public class A110697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110697Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A110697.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A110697.Bytes);
public BigInteger this[int i]=>Value[i];

public static A110697Inst Instance=new A110697Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110698
{
public static readonly BigInteger[] Value={ 9L,104L,3724L,152978L,6772428L,318919354L,15762420826L,808272767014L,42631956711628L,2298618088718378L,126131492134695474L,7020934326396461014L,BigInteger.Parse("395480502329858803674"),BigInteger.Parse("22501172037539767125398") };
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
public class A110698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110698Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A110698.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A110698.Bytes);
public BigInteger this[int i]=>Value[i];

public static A110698Inst Instance=new A110698Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110699
{
public static readonly long[] Value={ 2L,2L,3L,5L,5L,9L,7L,9L,10L,11L,12L,13L,13L,17L,16L,17L,17L,19L,19L,21L,22L,24L,24L,25L,26L,28L,28L,29L,30L,33L,31L,33L,34L,35L,36L,38L,38L,40L,40L,41L,42L,44L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,56L,56L,57L,59L,59L,60L,61L,61L,65L,64L,65L,66L,67L,68L,69L,70L,72L,72L,73L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110699Inst : IEnumerable<long>
{
public static readonly long[] Value=A110699.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110699.Bytes);
public long this[int i]=>Value[i];

public static A110699Inst Instance=new A110699Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110700
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,3L,0L,1L,1L,1L,1L,1L,0L,3L,1L,1L,0L,1L,0L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,3L,0L,1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,2L,1L,1L,1L,0L,3L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,0L,2L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110700Inst : IEnumerable<long>
{
public static readonly long[] Value=A110700.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110700.Bytes);
public long this[int i]=>Value[i];

public static A110700Inst Instance=new A110700Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110701
{
public static readonly long[] Value={ 9L,21L,30L,42L,65L,70L,99L,105L,117L,133L,135L,154L,175L,180L,225L,231L,275L,285L,341L,342L,345L,364L,385L,414L,440L,450L,455L,481L,495L,540L,546L,567L,630L,645L,675L,693L,744L,750L,765L,825L,833L,936L,945L,990L,1035L,1045L,1140L,1161L,1170L,1176L,1178L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110701Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110701.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110701Inst : IEnumerable<long>
{
public static readonly long[] Value=A110701.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110701.Bytes);
public long this[int i]=>Value[i];

public static A110701Inst Instance=new A110701Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110702
{
public static readonly long[] Value={ 5L,15L,21L,33L,54L,54L,85L,90L,100L,117L,110L,135L,153L,161L,204L,195L,252L,261L,315L,308L,315L,315L,351L,385L,405L,418L,414L,450L,455L,476L,510L,533L,595L,609L,637L,650L,705L,693L,684L,777L,792L,870L,884L,931L,986L,999L,1071L,1105L,1121L,1110L,1125L,1210L,1230L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110702Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110702.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110702Inst : IEnumerable<long>
{
public static readonly long[] Value=A110702.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110702.Bytes);
public long this[int i]=>Value[i];

public static A110702Inst Instance=new A110702Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110703
{
public static readonly long[] Value={ 3L,15L,27L,30L,42L,75L,90L,105L,135L,147L,165L,243L,252L,270L,273L,315L,363L,375L,378L,420L,462L,495L,507L,612L,660L,675L,693L,735L,750L,780L,810L,855L,858L,867L,945L,1050L,1083L,1155L,1170L,1215L,1287L,1323L,1365L,1470L,1485L,1518L,1587L,1785L,1815L,1875L,1950L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110703Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110703.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110703Inst : IEnumerable<long>
{
public static readonly long[] Value=A110703.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110703.Bytes);
public long this[int i]=>Value[i];

public static A110703Inst Instance=new A110703Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110704
{
public static readonly BigInteger[] Value={ 43L,4243L,424243L,42424243L,4242424243L,4242424242424243L,BigInteger.Parse("424242424242424242424242424242424243"),BigInteger.Parse("42424242424242424242424242424242424242424242424243") };
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
public class A110704Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110704.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110704Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A110704.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A110704.Bytes);
public BigInteger this[int i]=>Value[i];

public static A110704Inst Instance=new A110704Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110705
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,7L,17L,24L,59L,199L,743L,2558L,4896L,5539L,6192L,10977L,27679L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110705Inst : IEnumerable<long>
{
public static readonly long[] Value=A110705.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110705.Bytes);
public long this[int i]=>Value[i];

public static A110705Inst Instance=new A110705Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110706
{
public static readonly long[] Value={ 6L,30L,174L,1092L,7188L,48852L,339720L,2403588L,17236524L,124948668L,913820460L,6732898800L,49918950240L,372104853600L,2786716100592L,20955408717396L,158149624268220L,1197390368733804L,9091866006950892L,69214297980023256L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110706Inst : IEnumerable<long>
{
public static readonly long[] Value=A110706.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110706.Bytes);
public long this[int i]=>Value[i];

public static A110706Inst Instance=new A110706Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110707
{
public static readonly long[] Value={ 6L,24L,132L,804L,5196L,34872L,240288L,1688244L,12040188L,86892384L,633162360L,4650680640L,34390540320L,255773538240L,1911730760832L,14350853162676L,108139250403804L,817629606524112L,6200696697358344L,47152195812692664L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110707Inst : IEnumerable<long>
{
public static readonly long[] Value=A110707.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110707.Bytes);
public long this[int i]=>Value[i];

public static A110707Inst Instance=new A110707Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110708
{
public static readonly long[] Value={ 0L,1L,-1L,0L,2L,8L,-64L,-112L,2064L,8192L,-157056L,-599808L,16072704L,80010240L,-2484268032L,-13537247232L,506459129856L,3160676007936L,-135526008225792L,-929451393220608L,45507663438741504L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110708Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110708.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110708Inst : IEnumerable<long>
{
public static readonly long[] Value=A110708.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110708.Bytes);
public long this[int i]=>Value[i];

public static A110708Inst Instance=new A110708Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110709
{
public static readonly BigInteger[] Value={ 1L,323L,93749L,1959551L,46118407L,1207959551L,37661140520651L,1390911669927935L,55123269399790045L,2333521433367183359L,BigInteger.Parse("105094533691406249999"),BigInteger.Parse("5017514388048998039551"),BigInteger.Parse("13456471561751415850795007"),BigInteger.Parse("751799469150919163867112019") };
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
public class A110709Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110709.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110709Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A110709.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A110709.Bytes);
public BigInteger this[int i]=>Value[i];

public static A110709Inst Instance=new A110709Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110710
{
public static readonly long[] Value={ 1L,2L,5L,16L,70L,348L,1948L,11444L,70380L,445944L,2896590L,19186740L,129186596L,881808728L,6089851874L,42482906040L,298976142764L,2120377458900L,15141289233972L,108784152585236L,785869931659980L,5705406374249272L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110710Inst : IEnumerable<long>
{
public static readonly long[] Value=A110710.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110710.Bytes);
public long this[int i]=>Value[i];

public static A110710Inst Instance=new A110710Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110711
{
public static readonly long[] Value={ 0L,6L,42L,288L,1992L,13980L,99432L,715344L,5196336L,38056284L,280658100L,2082218160L,15528409920L,116331315360L,874985339760L,6604555554720L,50010373864416L,379760762209692L,2891169309592548L,22062102167330592L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110711Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110711.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110711Inst : IEnumerable<long>
{
public static readonly long[] Value=A110711.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110711.Bytes);
public long this[int i]=>Value[i];

public static A110711Inst Instance=new A110711Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110712
{
public static readonly long[] Value={ 1L,-3L,2L,-1L,5L,-6L,6L,-7L,7L,-15L,12L,-2L,12L,-18L,10L,-9L,16L,-21L,20L,-5L,12L,-36L,22L,-14L,25L,-36L,20L,-6L,30L,-30L,32L,-23L,24L,-48L,30L,-7L,36L,-60L,24L,-35L,42L,-36L,42L,-12L,35L,-66L,46L,-18L,43L,-75L,32L,-12L,52L,-60L,60L,-42L,40L,-90L,60L,-10L,62L,-96L,42L,-41L,60L,-72L,66L,-16L,44L,-90L,72L,-49L,72L,-108L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110712Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110712.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110712Inst : IEnumerable<long>
{
public static readonly long[] Value=A110712.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110712.Bytes);
public long this[int i]=>Value[i];

public static A110712Inst Instance=new A110712Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110713
{
public static readonly long[] Value={ 1L,3L,10L,25L,91L,196L,750L,1485L,3025L,5566L,23387L,38402L,163268L,284376L,500004L,795549L,3575781L,5657839L,25413850L,40027130L,66010230L,105164280L,490429875L,713491350L,1232253906L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110713Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110713.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110713Inst : IEnumerable<long>
{
public static readonly long[] Value=A110713.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110713.Bytes);
public long this[int i]=>Value[i];

public static A110713Inst Instance=new A110713Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110714
{
public static readonly BigInteger[] Value={ 2L,23L,91011L,34353637L,4344454647L,646566676869L,567891011L,BigInteger.Parse("10541055105610571058105910601061"),BigInteger.Parse("291292293294295296297298299"),BigInteger.Parse("130131132133134135136137138139"),BigInteger.Parse("811812813814815816817818819820821"),BigInteger.Parse("216621672168216921702171217221732174217521762177"),BigInteger.Parse("851852853854855856857858859860861862863"),BigInteger.Parse("8485868788899091929394959697"),BigInteger.Parse("285286287288289290291292293294295296297298299"),BigInteger.Parse("746747748749750751752753754755756757758759760761") };
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
public class A110714Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110714.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110714Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A110714.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A110714.Bytes);
public BigInteger this[int i]=>Value[i];

public static A110714Inst Instance=new A110714Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110715
{
public static readonly BigInteger[] Value={ 2L,223L,22391011L,2239101134353637L,BigInteger.Parse("22391011343536374344454647"),BigInteger.Parse("22391011343536374344454647646566676869"),BigInteger.Parse("22391011343536374344454647646566676869567891011"),BigInteger.Parse("2239101134353637434445464764656667686956789101110541055105610571058105910601061"),BigInteger.Parse("2239101134353637434445464764656667686956789101110541055105610571058105910601061291292293294295296297298299") };
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
public class A110715Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110715.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110715Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A110715.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A110715.Bytes);
public BigInteger this[int i]=>Value[i];

public static A110715Inst Instance=new A110715Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110716
{
public static readonly BigInteger[] Value={ 3L,67L,123L,60616263L,153154155156157L,787980818283L,41424344454647L,BigInteger.Parse("9969979989991000100110021003"),656667686970717273L,BigInteger.Parse("384385386387388389390391392393"),BigInteger.Parse("229230231232233234235236237238239") };
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
public class A110716Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110716.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110716Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A110716.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A110716.Bytes);
public BigInteger this[int i]=>Value[i];

public static A110716Inst Instance=new A110716Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110717
{
public static readonly BigInteger[] Value={ 3L,367L,367123L,36712360616263L,BigInteger.Parse("36712360616263153154155156157"),BigInteger.Parse("36712360616263153154155156157787980818283"),BigInteger.Parse("3671236061626315315415515615778798081828341424344454647") };
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
public class A110717Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110717.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110717Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A110717.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A110717.Bytes);
public BigInteger this[int i]=>Value[i];

public static A110717Inst Instance=new A110717Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110718
{
public static readonly BigInteger[] Value={ 7L,1011L,123L,30313233L,127128129130131L,363738394041L,78910111213L,BigInteger.Parse("11661167116811691170117111721173"),BigInteger.Parse("251252253254255256257258259"),BigInteger.Parse("168169170171172173174175176177"),BigInteger.Parse("439440441442443444445446447448449") };
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
public class A110718Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110718.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110718Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A110718.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A110718.Bytes);
public BigInteger this[int i]=>Value[i];

public static A110718Inst Instance=new A110718Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110719
{
public static readonly BigInteger[] Value={ 7L,71011L,71011123L,7101112330313233L,BigInteger.Parse("7101112330313233127128129130131"),BigInteger.Parse("7101112330313233127128129130131363738394041"),BigInteger.Parse("710111233031323312712812913013136373839404178910111213") };
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
public class A110719Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110719.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110719Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A110719.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A110719.Bytes);
public BigInteger this[int i]=>Value[i];

public static A110719Inst Instance=new A110719Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110720
{
public static readonly BigInteger[] Value={ 5L,23L,353637L,18192021L,7576777879L,67891011L,71727374757677L,BigInteger.Parse("12121213121412151216121712181219"),5678910111213L,BigInteger.Parse("1194119511961197119811991200120112021203") };
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
public class A110720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110720Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A110720.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A110720.Bytes);
public BigInteger this[int i]=>Value[i];

public static A110720Inst Instance=new A110720Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110721
{
public static readonly BigInteger[] Value={ 5L,523L,523353637L,52335363718192021L,BigInteger.Parse("523353637181920217576777879"),BigInteger.Parse("52335363718192021757677787967891011"),BigInteger.Parse("5233536371819202175767778796789101171727374757677") };
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
public class A110721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110721Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A110721.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A110721.Bytes);
public BigInteger this[int i]=>Value[i];

public static A110721Inst Instance=new A110721Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110722
{
public static readonly long[] Value={ 0L,121L,484L,1089L,1936L,3025L,4356L,5929L,7744L,9801L,110110L,1234321L,2578752L,4143403L,5928274L,7933365L,10158676L,12604207L,15269958L,18155929L,440440L,2578752L,4937284L,7516036L,10315008L,13334200L,16573612L,20033244L,23713096L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110722Inst : IEnumerable<long>
{
public static readonly long[] Value=A110722.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110722.Bytes);
public long this[int i]=>Value[i];

public static A110722Inst Instance=new A110722Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110723
{
public static readonly long[] Value={ 0L,1L,4L,9L,16L,25L,36L,49L,64L,81L,910L,10201L,21312L,34243L,48994L,65565L,83956L,104167L,126198L,150049L,3640L,21312L,40804L,62116L,85248L,110200L,136972L,165564L,195976L,228208L,8190L,34243L,62116L,91809L,123322L,156655L,191808L,228781L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110723Inst : IEnumerable<long>
{
public static readonly long[] Value=A110723.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110723.Bytes);
public long this[int i]=>Value[i];

public static A110723Inst Instance=new A110723Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110724
{
public static readonly long[] Value={ 0L,22L,44L,66L,88L,110L,132L,154L,176L,198L,1111L,2222L,3333L,4444L,5555L,6666L,7777L,8888L,9999L,11110L,2222L,3333L,4444L,5555L,6666L,7777L,8888L,9999L,11110L,12221L,3333L,4444L,5555L,6666L,7777L,8888L,9999L,11110L,12221L,13332L,4444L,5555L,6666L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110724Inst : IEnumerable<long>
{
public static readonly long[] Value=A110724.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110724.Bytes);
public long this[int i]=>Value[i];

public static A110724Inst Instance=new A110724Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110725
{
public static readonly long[] Value={ 0L,2L,4L,6L,8L,10L,12L,14L,16L,18L,101L,202L,303L,404L,505L,606L,707L,808L,909L,1010L,202L,303L,404L,505L,606L,707L,808L,909L,1010L,1111L,303L,404L,505L,606L,707L,808L,909L,1010L,1111L,1212L,404L,505L,606L,707L,808L,909L,1010L,1111L,1212L,1313L,505L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110725Inst : IEnumerable<long>
{
public static readonly long[] Value=A110725.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110725.Bytes);
public long this[int i]=>Value[i];

public static A110725Inst Instance=new A110725Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110726
{
public static readonly long[] Value={ 891L,0L,891L,1782L,2673L,3564L,4455L,5346L,6237L,7128L,1782L,891L,0L,891L,1782L,2673L,3564L,4455L,5346L,6237L,2673L,1782L,891L,0L,891L,1782L,2673L,3564L,4455L,5346L,3564L,2673L,1782L,891L,0L,891L,1782L,2673L,3564L,4455L,4455L,3564L,2673L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110726Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110726.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110726Inst : IEnumerable<long>
{
public static readonly long[] Value=A110726.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110726.Bytes);
public long this[int i]=>Value[i];

public static A110726Inst Instance=new A110726Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110727
{
public static readonly long[] Value={ 81L,0L,81L,162L,243L,324L,405L,486L,567L,648L,162L,81L,0L,81L,162L,243L,324L,405L,486L,567L,243L,162L,81L,0L,81L,162L,243L,324L,405L,486L,324L,243L,162L,81L,0L,81L,162L,243L,324L,405L,405L,324L,243L,162L,81L,0L,81L,162L,243L,324L,486L,405L,324L,243L,162L,81L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110727Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110727.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110727Inst : IEnumerable<long>
{
public static readonly long[] Value=A110727.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110727.Bytes);
public long this[int i]=>Value[i];

public static A110727Inst Instance=new A110727Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110728
{
public static readonly long[] Value={ 1L,1L,2L,6L,24L,30L,18L,63L,72L,81L,90L,99L,216L,117L,126L,135L,144L,153L,162L,171L,180L,189L,396L,414L,216L,225L,234L,243L,252L,261L,270L,279L,576L,594L,612L,315L,324L,333L,342L,351L,360L,369L,756L,774L,792L,810L,414L,423L,432L,441L,450L,459L,936L,954L,972L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110728Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110728.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110728Inst : IEnumerable<long>
{
public static readonly long[] Value=A110728.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110728.Bytes);
public long this[int i]=>Value[i];

public static A110728Inst Instance=new A110728Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110729
{
public static readonly long[] Value={ 1L,1L,2L,6L,24L,720L,5040L,362880L,39916800L,479001600L,6227020800L,87178291200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110729Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110729.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110729Inst : IEnumerable<long>
{
public static readonly long[] Value=A110729.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110729.Bytes);
public long this[int i]=>Value[i];

public static A110729Inst Instance=new A110729Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110730
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,1L,2L,2L,3L,1L,1L,1L,1L,2L,2L,2L,3L,3L,4L,1L,1L,1L,1L,1L,2L,2L,2L,2L,3L,3L,3L,4L,4L,5L,1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,3L,3L,3L,3L,4L,4L,4L,5L,5L,6L,1L,1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,2L,3L,3L,3L,3L,3L,4L,4L,4L,4L,5L,5L,5L,6L,6L,7L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,2L,2L,3L,3L,3L,3L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110730Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110730.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110730Inst : IEnumerable<long>
{
public static readonly long[] Value=A110730.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110730.Bytes);
public long this[int i]=>Value[i];

public static A110730Inst Instance=new A110730Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110731
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1144L,1L,28L,1L,1L,28L,136L,1L,19L,1L,1L,1144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110731Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110731.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110731Inst : IEnumerable<long>
{
public static readonly long[] Value=A110731.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110731.Bytes);
public long this[int i]=>Value[i];

public static A110731Inst Instance=new A110731Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110732
{
public static readonly BigInteger[] Value={ 11L,22L,33L,44L,55L,66L,77L,88L,99L,1100L,1111L,0L,111111333333L,111111444444L,1155L,0L,BigInteger.Parse("11111111111111117777777777777777"),1188L,BigInteger.Parse("111111111111111111999999999999999999"),2200L,222222111111L,2222L,BigInteger.Parse("22222222222222222222223333333333333333333333"),0L,0L };
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
public class A110732Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110732.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110732Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A110732.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A110732.Bytes);
public BigInteger this[int i]=>Value[i];

public static A110732Inst Instance=new A110732Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110733
{
public static readonly BigInteger[] Value={ 11L,11L,11L,11L,11L,11L,11L,11L,11L,110L,101L,0L,8547025641L,7936531746L,77L,0L,BigInteger.Parse("653594771241830457516339869281"),66L,BigInteger.Parse("5847953216374269052631578947368421"),110L,10582005291L,101L,BigInteger.Parse("966183574879227053140144927536231884057971"),0L,0L };
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
public class A110733Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110733.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110733Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A110733.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A110733.Bytes);
public BigInteger this[int i]=>Value[i];

public static A110733Inst Instance=new A110733Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110734
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,100L,121L,132L,143L,154L,105L,176L,187L,108L,0L,200L,231L,242L,253L,264L,225L,286L,297L,0L,0L,300L,341L,352L,363L,374L,315L,396L,0L,0L,0L,400L,451L,462L,473L,484L,405L,0L,0L,0L,0L,500L,561L,572L,583L,594L,0L,0L,0L,0L,0L,600L,671L,682L,693L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110734Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110734.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110734Inst : IEnumerable<long>
{
public static readonly long[] Value=A110734.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110734.Bytes);
public long this[int i]=>Value[i];

public static A110734Inst Instance=new A110734Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110735
{
public static readonly long[] Value={ 110L,120L,132L,140L,150L,162L,175L,184L,198L,11000L,11011L,11028L,11037L,11046L,11055L,11168L,11271L,11088L,11096L,12000L,12012L,12122L,12236L,12048L,12050L,12064L,12177L,12180L,12093L,13200L,13113L,13024L,13035L,13940L,13055L,13068L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110735Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110735.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110735Inst : IEnumerable<long>
{
public static readonly long[] Value=A110735.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110735.Bytes);
public long this[int i]=>Value[i];

public static A110735Inst Instance=new A110735Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110736
{
public static readonly long[] Value={ 110L,60L,44L,35L,30L,27L,25L,23L,22L,1100L,1001L,919L,849L,789L,737L,698L,663L,616L,584L,600L,572L,551L,532L,502L,482L,464L,451L,435L,417L,440L,423L,407L,395L,410L,373L,363L,356L,347L,341L,350L,354L,334L,331L,326L,319L,308L,308L,306L,302L,300L,310L,289L,295L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110736Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110736.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110736Inst : IEnumerable<long>
{
public static readonly long[] Value=A110736.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110736.Bytes);
public long this[int i]=>Value[i];

public static A110736Inst Instance=new A110736Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110737
{
public static readonly BigInteger[] Value={ 1L,4L,21L,40L,1555L,3906L,299593L,3280L,87381L,435848050L,67546215517L,61035156L,61054982558011L,328114698808274L,76861433640456465L,21523360L,BigInteger.Parse("128583032925805678351"),953674316406L,BigInteger.Parse("275941052631578947368421"),1743392200L };
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
public class A110737Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110737.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110737Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A110737.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A110737.Bytes);
public BigInteger this[int i]=>Value[i];

public static A110737Inst Instance=new A110737Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110738
{
public static readonly long[] Value={ 1L,3L,4L,3L,6L,5L,8L,3L,4L,9L,12L,5L,14L,13L,16L,3L,18L,5L,20L,3L,4L,21L,24L,5L,6L,25L,4L,13L,30L,11L,32L,3L,34L,33L,36L,5L,38L,37L,16L,3L,42L,5L,44L,21L,16L,45L,48L,5L,8L,9L,52L,5L,54L,5L,16L,13L,7L,57L,60L,7L,62L,61L,4L,3L,66L,23L,68L,13L,70L,29L,72L,5L,74L,73L,16L,37L,78L,17L,80L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110738Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110738.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110738Inst : IEnumerable<long>
{
public static readonly long[] Value=A110738.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110738.Bytes);
public long this[int i]=>Value[i];

public static A110738Inst Instance=new A110738Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110739
{
public static readonly BigInteger[] Value={ 1L,2L,7L,10L,311L,651L,42799L,410L,9709L,43584805L,6140565047L,5086263L,4696537119847L,23436764200591L,5124095576030431L,1345210L,7563707819165039903L,52981906467L,BigInteger.Parse("14523213296398891966759"),87169610L };
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
public class A110739Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110739.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110739Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A110739.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A110739.Bytes);
public BigInteger this[int i]=>Value[i];

public static A110739Inst Instance=new A110739Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A110740
{
public static readonly long[] Value={ 1L,3L,9L,27L,69L,1053L,1599L,2511L,8167L,21371L,73323L,225681L,313401L,362703L,371321L,1896939L,2735667L,3426273L,3795093L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A110740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A110740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A110740Inst : IEnumerable<long>
{
public static readonly long[] Value=A110740.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A110740.Bytes);
public long this[int i]=>Value[i];

public static A110740Inst Instance=new A110740Inst();

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