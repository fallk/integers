using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A019849
{
public static readonly long[] Value={ 6L,4L,2L,7L,8L,7L,6L,0L,9L,6L,8L,6L,5L,3L,9L,3L,2L,6L,3L,2L,2L,6L,4L,3L,4L,0L,9L,9L,0L,7L,2L,6L,3L,4L,3L,2L,9L,0L,7L,5L,5L,9L,8L,8L,4L,2L,0L,5L,6L,8L,1L,7L,9L,0L,3L,2L,4L,9L,7L,7L,2L,5L,4L,6L,7L,1L,1L,1L,2L,8L,3L,6L,2L,4L,0L,9L,5L,8L,6L,3L,9L,7L,1L,0L,4L,8L,8L,2L,2L,7L,7L,1L,7L,5L,9L,4L,3L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019849Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019849.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019849Inst : IEnumerable<long>
{
public static readonly long[] Value=A019849.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019849.Bytes);
public long this[int i]=>Value[i];

public static A019849Inst Instance=new A019849Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019850
{
public static readonly long[] Value={ 6L,5L,6L,0L,5L,9L,0L,2L,8L,9L,9L,0L,5L,0L,7L,2L,8L,4L,7L,8L,2L,4L,9L,5L,9L,6L,4L,0L,2L,3L,4L,1L,9L,2L,4L,7L,5L,1L,9L,4L,0L,1L,6L,9L,7L,8L,7L,0L,3L,4L,9L,7L,8L,9L,8L,1L,0L,2L,3L,4L,1L,5L,4L,6L,5L,4L,5L,6L,7L,4L,6L,3L,7L,9L,7L,7L,2L,5L,6L,2L,3L,6L,8L,3L,7L,8L,7L,4L,2L,6L,3L,9L,4L,2L,7L,1L,4L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019850Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019850.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019850Inst : IEnumerable<long>
{
public static readonly long[] Value=A019850.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019850.Bytes);
public long this[int i]=>Value[i];

public static A019850Inst Instance=new A019850Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019851
{
public static readonly long[] Value={ 6L,6L,9L,1L,3L,0L,6L,0L,6L,3L,5L,8L,8L,5L,8L,2L,1L,3L,8L,2L,6L,2L,7L,3L,3L,3L,0L,6L,8L,6L,7L,8L,0L,4L,7L,3L,5L,9L,9L,5L,8L,3L,2L,1L,8L,9L,5L,9L,7L,9L,5L,6L,7L,6L,8L,1L,7L,4L,5L,3L,3L,5L,2L,2L,8L,7L,9L,6L,6L,6L,0L,1L,7L,1L,0L,6L,4L,3L,8L,9L,7L,1L,4L,6L,1L,5L,4L,9L,2L,3L,3L,6L,0L,0L,9L,0L,0L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019851Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019851.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019851Inst : IEnumerable<long>
{
public static readonly long[] Value=A019851.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019851.Bytes);
public long this[int i]=>Value[i];

public static A019851Inst Instance=new A019851Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019852
{
public static readonly long[] Value={ 6L,8L,1L,9L,9L,8L,3L,6L,0L,0L,6L,2L,4L,9L,8L,5L,0L,0L,4L,4L,2L,2L,2L,5L,7L,8L,4L,7L,1L,1L,1L,2L,5L,5L,8L,0L,3L,4L,0L,4L,3L,3L,8L,0L,2L,7L,6L,1L,9L,4L,3L,4L,0L,2L,8L,7L,8L,3L,0L,7L,8L,5L,3L,0L,6L,7L,5L,3L,6L,8L,8L,1L,8L,7L,4L,9L,5L,5L,7L,2L,1L,6L,1L,4L,0L,0L,2L,2L,3L,8L,6L,8L,2L,0L,0L,3L,7L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019852Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019852.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019852Inst : IEnumerable<long>
{
public static readonly long[] Value=A019852.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019852.Bytes);
public long this[int i]=>Value[i];

public static A019852Inst Instance=new A019852Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019853
{
public static readonly long[] Value={ 6L,9L,4L,6L,5L,8L,3L,7L,0L,4L,5L,8L,9L,9L,7L,2L,8L,6L,6L,5L,6L,4L,0L,6L,2L,9L,9L,4L,2L,2L,6L,8L,6L,2L,2L,9L,9L,1L,9L,8L,1L,3L,5L,2L,5L,9L,8L,6L,1L,8L,6L,2L,3L,3L,7L,8L,9L,6L,2L,3L,6L,9L,0L,3L,0L,3L,8L,1L,7L,4L,8L,0L,7L,1L,9L,1L,4L,7L,2L,7L,2L,1L,2L,8L,7L,4L,9L,5L,6L,3L,5L,0L,8L,6L,2L,0L,8L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019853Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019853.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019853Inst : IEnumerable<long>
{
public static readonly long[] Value=A019853.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019853.Bytes);
public long this[int i]=>Value[i];

public static A019853Inst Instance=new A019853Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019854
{
public static readonly BigInteger[] Value={ 1L,22L,333L,4334L,52325L,606606L,6874477L,76908238L,854115189L,9445967630L,104219612861L,1148348383182L,12643672205893L,139152654913294L,1531118871452685L,16844976107996366L,185310900907951637L,2038517655246870798L,BigInteger.Parse("22424284493969261149"),BigInteger.Parse("246670690224670294990") };
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
public class A019854Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019854.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019854Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A019854.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019854.Bytes);
public BigInteger this[int i]=>Value[i];

public static A019854Inst Instance=new A019854Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019855
{
public static readonly long[] Value={ 7L,1L,9L,3L,3L,9L,8L,0L,0L,3L,3L,8L,6L,5L,1L,1L,3L,9L,3L,5L,6L,0L,5L,4L,6L,7L,4L,4L,5L,6L,7L,1L,1L,9L,0L,8L,2L,3L,0L,6L,8L,4L,5L,5L,8L,9L,4L,1L,9L,6L,5L,7L,7L,1L,2L,8L,0L,2L,1L,4L,0L,3L,4L,3L,1L,5L,4L,8L,0L,6L,9L,1L,0L,7L,1L,5L,4L,3L,9L,4L,6L,0L,2L,0L,0L,4L,3L,9L,5L,5L,7L,7L,8L,0L,4L,2L,2L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019855Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019855.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019855Inst : IEnumerable<long>
{
public static readonly long[] Value=A019855.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019855.Bytes);
public long this[int i]=>Value[i];

public static A019855Inst Instance=new A019855Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019856
{
public static readonly long[] Value={ 7L,3L,1L,3L,5L,3L,7L,0L,1L,6L,1L,9L,1L,7L,0L,4L,8L,3L,2L,8L,7L,5L,4L,3L,6L,0L,8L,2L,7L,5L,6L,2L,2L,4L,0L,3L,3L,7L,8L,3L,9L,6L,5L,4L,4L,7L,6L,2L,5L,3L,7L,8L,4L,4L,2L,2L,1L,1L,6L,8L,7L,9L,4L,4L,4L,6L,6L,5L,9L,3L,1L,3L,4L,7L,3L,2L,6L,9L,7L,1L,8L,4L,9L,0L,7L,6L,2L,1L,0L,8L,9L,2L,0L,6L,4L,4L,4L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019856Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019856.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019856Inst : IEnumerable<long>
{
public static readonly long[] Value=A019856.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019856.Bytes);
public long this[int i]=>Value[i];

public static A019856Inst Instance=new A019856Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019857
{
public static readonly long[] Value={ 7L,4L,3L,1L,4L,4L,8L,2L,5L,4L,7L,7L,3L,9L,4L,2L,3L,5L,0L,1L,4L,6L,9L,7L,0L,4L,8L,9L,7L,4L,2L,5L,6L,9L,7L,7L,1L,8L,9L,1L,1L,3L,8L,7L,3L,4L,9L,8L,0L,2L,6L,3L,8L,6L,0L,4L,0L,1L,2L,3L,6L,7L,0L,5L,4L,7L,7L,7L,0L,3L,4L,4L,4L,2L,1L,1L,1L,9L,1L,2L,5L,4L,1L,4L,1L,6L,4L,0L,5L,4L,2L,4L,8L,0L,8L,3L,8L,0L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019857Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019857.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019857Inst : IEnumerable<long>
{
public static readonly long[] Value=A019857.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019857.Bytes);
public long this[int i]=>Value[i];

public static A019857Inst Instance=new A019857Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019858
{
public static readonly long[] Value={ 7L,5L,4L,7L,0L,9L,5L,8L,0L,2L,2L,2L,7L,7L,1L,9L,9L,7L,9L,4L,2L,9L,8L,4L,2L,1L,9L,5L,6L,1L,0L,1L,5L,5L,5L,8L,0L,4L,8L,5L,3L,7L,9L,7L,4L,6L,4L,4L,8L,9L,7L,4L,3L,6L,0L,4L,1L,3L,2L,2L,6L,8L,8L,3L,4L,9L,6L,1L,8L,4L,0L,1L,7L,2L,8L,5L,9L,5L,3L,1L,6L,7L,5L,3L,0L,6L,4L,3L,8L,3L,0L,4L,6L,9L,2L,4L,7L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019858Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019858.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019858Inst : IEnumerable<long>
{
public static readonly long[] Value=A019858.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019858.Bytes);
public long this[int i]=>Value[i];

public static A019858Inst Instance=new A019858Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019859
{
public static readonly long[] Value={ 7L,6L,6L,0L,4L,4L,4L,4L,3L,1L,1L,8L,9L,7L,8L,0L,3L,5L,2L,0L,2L,3L,9L,2L,6L,5L,0L,5L,5L,5L,4L,1L,6L,6L,7L,3L,9L,3L,5L,8L,3L,2L,4L,5L,7L,0L,8L,0L,3L,9L,5L,2L,4L,5L,8L,5L,4L,0L,4L,5L,2L,8L,4L,6L,4L,2L,1L,5L,5L,3L,8L,8L,8L,5L,6L,8L,7L,4L,7L,2L,3L,5L,2L,8L,2L,2L,9L,2L,7L,6L,6L,8L,0L,5L,4L,8L,4L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019859Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019859.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019859Inst : IEnumerable<long>
{
public static readonly long[] Value=A019859.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019859.Bytes);
public long this[int i]=>Value[i];

public static A019859Inst Instance=new A019859Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019860
{
public static readonly long[] Value={ 7L,7L,7L,1L,4L,5L,9L,6L,1L,4L,5L,6L,9L,7L,0L,8L,7L,9L,9L,7L,9L,9L,3L,7L,7L,4L,3L,6L,7L,2L,4L,0L,3L,8L,4L,9L,0L,9L,2L,0L,6L,5L,3L,7L,6L,4L,5L,1L,8L,0L,6L,0L,1L,6L,7L,9L,7L,0L,0L,8L,3L,3L,5L,0L,8L,1L,3L,9L,0L,7L,0L,4L,9L,3L,0L,3L,9L,8L,7L,3L,7L,0L,3L,1L,5L,4L,2L,1L,1L,0L,3L,9L,7L,5L,3L,7L,3L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019860Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019860.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019860Inst : IEnumerable<long>
{
public static readonly long[] Value=A019860.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019860.Bytes);
public long this[int i]=>Value[i];

public static A019860Inst Instance=new A019860Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019861
{
public static readonly long[] Value={ 7L,8L,8L,0L,1L,0L,7L,5L,3L,6L,0L,6L,7L,2L,1L,9L,5L,6L,6L,9L,3L,9L,7L,7L,7L,8L,7L,8L,3L,5L,8L,5L,1L,6L,6L,6L,6L,4L,1L,6L,9L,6L,7L,8L,8L,4L,7L,5L,4L,2L,8L,7L,3L,8L,5L,4L,1L,3L,3L,4L,3L,0L,9L,3L,9L,1L,4L,2L,9L,7L,3L,7L,7L,0L,5L,7L,6L,8L,1L,3L,2L,5L,6L,1L,4L,4L,4L,4L,1L,9L,1L,7L,5L,2L,9L,7L,9L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019861Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019861.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019861Inst : IEnumerable<long>
{
public static readonly long[] Value=A019861.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019861.Bytes);
public long this[int i]=>Value[i];

public static A019861Inst Instance=new A019861Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019862
{
public static readonly long[] Value={ 7L,9L,8L,6L,3L,5L,5L,1L,0L,0L,4L,7L,2L,9L,2L,8L,4L,6L,2L,8L,4L,0L,0L,0L,8L,0L,4L,0L,6L,8L,9L,3L,6L,2L,4L,4L,2L,6L,6L,2L,6L,7L,6L,3L,4L,4L,9L,8L,7L,7L,1L,5L,8L,0L,3L,3L,5L,6L,5L,2L,8L,3L,7L,8L,0L,5L,0L,0L,2L,4L,1L,1L,3L,3L,4L,5L,0L,3L,0L,1L,9L,4L,7L,9L,0L,9L,8L,6L,4L,5L,7L,0L,5L,6L,7L,0L,1L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019862Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019862.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019862Inst : IEnumerable<long>
{
public static readonly long[] Value=A019862.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019862.Bytes);
public long this[int i]=>Value[i];

public static A019862Inst Instance=new A019862Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019863
{
public static readonly long[] Value={ 8L,0L,9L,0L,1L,6L,9L,9L,4L,3L,7L,4L,9L,4L,7L,4L,2L,4L,1L,0L,2L,2L,9L,3L,4L,1L,7L,1L,8L,2L,8L,1L,9L,0L,5L,8L,8L,6L,0L,1L,5L,4L,5L,8L,9L,9L,0L,2L,8L,8L,1L,4L,3L,1L,0L,6L,7L,7L,2L,4L,3L,1L,1L,3L,5L,2L,6L,3L,0L,2L,3L,1L,4L,0L,9L,4L,5L,1L,2L,2L,4L,8L,5L,3L,6L,0L,3L,6L,0L,2L,0L,9L,4L,6L,9L,5L,5L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019863Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019863.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019863Inst : IEnumerable<long>
{
public static readonly long[] Value=A019863.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019863.Bytes);
public long this[int i]=>Value[i];

public static A019863Inst Instance=new A019863Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019864
{
public static readonly long[] Value={ 8L,1L,9L,1L,5L,2L,0L,4L,4L,2L,8L,8L,9L,9L,1L,7L,8L,9L,6L,8L,4L,4L,8L,8L,3L,8L,5L,9L,1L,6L,8L,4L,3L,4L,3L,1L,8L,9L,0L,0L,1L,1L,4L,6L,9L,0L,2L,6L,1L,6L,2L,0L,0L,8L,2L,5L,7L,5L,5L,5L,0L,4L,1L,2L,5L,4L,1L,8L,8L,5L,5L,8L,4L,5L,4L,6L,9L,3L,0L,8L,0L,7L,5L,2L,9L,6L,2L,4L,5L,2L,8L,0L,8L,4L,6L,1L,3L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019864Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019864.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019864Inst : IEnumerable<long>
{
public static readonly long[] Value=A019864.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019864.Bytes);
public long this[int i]=>Value[i];

public static A019864Inst Instance=new A019864Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019865
{
public static readonly long[] Value={ 8L,2L,9L,0L,3L,7L,5L,7L,2L,5L,5L,5L,0L,4L,1L,6L,9L,2L,0L,0L,6L,3L,3L,6L,8L,4L,1L,5L,0L,1L,6L,4L,2L,0L,2L,6L,3L,2L,9L,0L,7L,0L,2L,1L,2L,1L,6L,5L,6L,2L,5L,3L,4L,4L,8L,9L,4L,5L,7L,9L,6L,6L,8L,3L,2L,3L,9L,7L,1L,9L,0L,0L,0L,3L,2L,1L,2L,5L,7L,7L,7L,0L,7L,8L,9L,4L,3L,6L,5L,6L,5L,6L,4L,1L,4L,9L,6L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019865Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019865.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019865Inst : IEnumerable<long>
{
public static readonly long[] Value=A019865.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019865.Bytes);
public long this[int i]=>Value[i];

public static A019865Inst Instance=new A019865Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019866
{
public static readonly long[] Value={ 8L,3L,8L,6L,7L,0L,5L,6L,7L,9L,4L,5L,4L,2L,4L,0L,2L,9L,6L,3L,7L,5L,9L,0L,9L,4L,1L,8L,0L,4L,5L,4L,7L,8L,9L,4L,0L,3L,9L,5L,0L,0L,2L,6L,5L,0L,9L,5L,9L,2L,3L,8L,2L,4L,9L,2L,2L,0L,1L,2L,9L,0L,2L,9L,2L,2L,6L,3L,5L,1L,6L,9L,5L,3L,4L,3L,8L,0L,6L,7L,7L,5L,1L,3L,4L,7L,3L,9L,8L,3L,9L,2L,2L,9L,7L,4L,5L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019866Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019866.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019866Inst : IEnumerable<long>
{
public static readonly long[] Value=A019866.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019866.Bytes);
public long this[int i]=>Value[i];

public static A019866Inst Instance=new A019866Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019867
{
public static readonly long[] Value={ 8L,4L,8L,0L,4L,8L,0L,9L,6L,1L,5L,6L,4L,2L,5L,9L,7L,0L,3L,8L,6L,1L,7L,6L,1L,7L,8L,6L,9L,0L,3L,8L,6L,4L,4L,8L,7L,2L,8L,7L,1L,2L,0L,5L,5L,9L,5L,6L,2L,4L,5L,3L,5L,9L,0L,5L,1L,8L,6L,1L,9L,6L,1L,1L,2L,8L,3L,1L,3L,2L,3L,1L,5L,9L,6L,4L,2L,4L,9L,2L,2L,8L,4L,8L,0L,4L,8L,5L,2L,9L,0L,4L,4L,7L,2L,7L,6L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019867Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019867.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019867Inst : IEnumerable<long>
{
public static readonly long[] Value=A019867.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019867.Bytes);
public long this[int i]=>Value[i];

public static A019867Inst Instance=new A019867Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019868
{
public static readonly long[] Value={ 8L,5L,7L,1L,6L,7L,3L,0L,0L,7L,0L,2L,1L,1L,2L,2L,8L,7L,4L,6L,5L,2L,1L,7L,9L,8L,0L,1L,4L,4L,7L,6L,3L,3L,1L,4L,3L,8L,4L,0L,5L,3L,6L,6L,4L,8L,0L,6L,0L,7L,0L,6L,3L,5L,7L,4L,4L,0L,0L,5L,6L,4L,5L,7L,5L,1L,4L,7L,9L,0L,2L,3L,1L,9L,7L,6L,8L,1L,9L,4L,0L,5L,4L,9L,6L,5L,9L,1L,1L,0L,9L,9L,7L,3L,4L,2L,5L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019868Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019868.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019868Inst : IEnumerable<long>
{
public static readonly long[] Value=A019868.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019868.Bytes);
public long this[int i]=>Value[i];

public static A019868Inst Instance=new A019868Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019869
{
public static readonly long[] Value={ 1L,23L,367L,5075L,65551L,817643L,10013527L,121451315L,1465540351L,17637184763L,211960186087L,2545454874755L,30557298487951L,366759842503883L,4401557777453047L,52821361851453395L,633872505937432351L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019869Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019869.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019869Inst : IEnumerable<long>
{
public static readonly long[] Value=A019869.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019869.Bytes);
public long this[int i]=>Value[i];

public static A019869Inst Instance=new A019869Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019901
{
public static readonly long[] Value={ 0L,5L,2L,4L,0L,7L,7L,7L,9L,2L,8L,3L,0L,4L,1L,2L,0L,4L,0L,3L,8L,8L,0L,5L,8L,2L,4L,4L,7L,3L,9L,8L,4L,3L,7L,4L,9L,5L,3L,4L,2L,4L,9L,2L,7L,8L,0L,9L,9L,4L,7L,3L,8L,4L,4L,7L,3L,4L,4L,4L,9L,1L,5L,3L,5L,3L,0L,3L,6L,1L,6L,0L,8L,9L,3L,7L,3L,8L,0L,8L,0L,4L,5L,2L,6L,2L,7L,7L,9L,3L,2L,1L,8L,4L,0L,4L,7L,0L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019901Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019901.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019901Inst : IEnumerable<long>
{
public static readonly long[] Value=A019901.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019901.Bytes);
public long this[int i]=>Value[i];

public static A019901Inst Instance=new A019901Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019902
{
public static readonly long[] Value={ 0L,6L,9L,9L,2L,6L,8L,1L,1L,9L,4L,3L,5L,1L,0L,4L,1L,3L,6L,6L,6L,9L,2L,1L,0L,6L,0L,3L,2L,3L,1L,8L,1L,7L,5L,5L,9L,6L,7L,9L,3L,0L,2L,4L,5L,9L,6L,8L,6L,8L,0L,6L,0L,9L,6L,9L,8L,3L,7L,2L,4L,9L,7L,8L,7L,8L,3L,5L,7L,0L,0L,0L,5L,9L,0L,3L,7L,6L,6L,7L,2L,6L,0L,4L,5L,4L,4L,3L,4L,6L,7L,8L,6L,8L,7L,1L,8L,2L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019902Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019902.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019902Inst : IEnumerable<long>
{
public static readonly long[] Value=A019902.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019902.Bytes);
public long this[int i]=>Value[i];

public static A019902Inst Instance=new A019902Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019903
{
public static readonly long[] Value={ 0L,8L,7L,4L,8L,8L,6L,6L,3L,5L,2L,5L,9L,2L,4L,0L,0L,5L,2L,2L,2L,0L,1L,8L,6L,6L,9L,4L,3L,4L,9L,6L,1L,4L,5L,8L,1L,1L,9L,4L,5L,4L,2L,7L,6L,3L,6L,8L,1L,0L,8L,2L,2L,9L,1L,4L,5L,2L,3L,6L,6L,6L,2L,2L,2L,1L,6L,4L,1L,4L,2L,7L,3L,0L,2L,6L,1L,2L,8L,4L,1L,6L,1L,9L,1L,2L,3L,7L,3L,2L,3L,7L,0L,0L,6L,4L,0L,9L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019903Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019903.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019903Inst : IEnumerable<long>
{
public static readonly long[] Value=A019903.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019903.Bytes);
public long this[int i]=>Value[i];

public static A019903Inst Instance=new A019903Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019904
{
public static readonly long[] Value={ 1L,0L,5L,1L,0L,4L,2L,3L,5L,2L,6L,5L,6L,7L,6L,4L,6L,2L,5L,1L,1L,5L,0L,2L,3L,8L,0L,1L,3L,9L,8L,8L,1L,9L,1L,5L,2L,5L,0L,2L,4L,6L,6L,4L,9L,5L,4L,5L,6L,8L,6L,8L,8L,2L,8L,7L,8L,6L,6L,1L,5L,6L,8L,1L,8L,3L,7L,8L,1L,9L,1L,0L,8L,1L,0L,6L,1L,4L,4L,1L,6L,7L,9L,7L,9L,3L,7L,5L,0L,4L,6L,7L,4L,7L,7L,0L,2L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019904Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019904.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019904Inst : IEnumerable<long>
{
public static readonly long[] Value=A019904.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019904.Bytes);
public long this[int i]=>Value[i];

public static A019904Inst Instance=new A019904Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019905
{
public static readonly long[] Value={ 1L,2L,2L,7L,8L,4L,5L,6L,0L,9L,0L,2L,9L,0L,4L,5L,9L,1L,1L,3L,4L,2L,3L,1L,1L,3L,6L,0L,5L,2L,8L,5L,9L,5L,9L,5L,2L,8L,2L,3L,0L,7L,7L,0L,4L,6L,6L,0L,7L,7L,4L,7L,5L,9L,4L,6L,4L,3L,5L,5L,1L,6L,7L,5L,5L,1L,4L,0L,7L,7L,0L,0L,1L,6L,7L,2L,9L,5L,9L,4L,3L,9L,8L,7L,1L,0L,0L,1L,7L,2L,4L,3L,7L,9L,5L,4L,4L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019905Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019905.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019905Inst : IEnumerable<long>
{
public static readonly long[] Value=A019905.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019905.Bytes);
public long this[int i]=>Value[i];

public static A019905Inst Instance=new A019905Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019906
{
public static readonly long[] Value={ 1L,4L,0L,5L,4L,0L,8L,3L,4L,7L,0L,2L,3L,9L,1L,4L,4L,6L,8L,3L,8L,1L,1L,7L,6L,9L,3L,4L,3L,2L,8L,1L,4L,1L,3L,5L,6L,7L,3L,1L,8L,7L,2L,7L,5L,1L,7L,4L,7L,7L,2L,3L,7L,4L,8L,9L,5L,3L,6L,0L,3L,6L,1L,7L,1L,2L,0L,5L,3L,2L,3L,2L,6L,4L,5L,7L,7L,9L,3L,4L,7L,8L,6L,6L,3L,6L,7L,9L,6L,7L,0L,3L,7L,7L,9L,3L,6L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019906Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019906.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019906Inst : IEnumerable<long>
{
public static readonly long[] Value=A019906.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019906.Bytes);
public long this[int i]=>Value[i];

public static A019906Inst Instance=new A019906Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019907
{
public static readonly long[] Value={ 1L,5L,8L,3L,8L,4L,4L,4L,0L,3L,2L,4L,5L,3L,6L,2L,9L,3L,8L,3L,8L,8L,8L,3L,0L,9L,2L,6L,9L,4L,3L,6L,6L,4L,1L,1L,4L,3L,3L,9L,1L,6L,2L,1L,6L,0L,7L,3L,7L,3L,3L,2L,9L,7L,2L,3L,1L,7L,4L,0L,9L,9L,5L,0L,3L,5L,6L,5L,7L,6L,3L,7L,1L,4L,2L,7L,1L,3L,9L,8L,0L,9L,5L,9L,8L,2L,0L,6L,8L,6L,7L,1L,1L,6L,7L,6L,8L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019907Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019907.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019907Inst : IEnumerable<long>
{
public static readonly long[] Value=A019907.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019907.Bytes);
public long this[int i]=>Value[i];

public static A019907Inst Instance=new A019907Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019908
{
public static readonly long[] Value={ 1L,7L,6L,3L,2L,6L,9L,8L,0L,7L,0L,8L,4L,6L,4L,9L,7L,3L,4L,7L,1L,0L,9L,0L,3L,8L,6L,8L,6L,8L,6L,1L,8L,9L,8L,6L,1L,2L,1L,6L,3L,3L,0L,6L,2L,3L,4L,8L,0L,9L,8L,6L,6L,0L,2L,0L,5L,3L,6L,3L,9L,8L,3L,8L,3L,5L,4L,4L,6L,9L,0L,8L,9L,1L,7L,7L,5L,8L,6L,2L,5L,4L,9L,8L,6L,5L,1L,3L,3L,5L,0L,8L,0L,3L,2L,4L,4L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019908Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019908.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019908Inst : IEnumerable<long>
{
public static readonly long[] Value=A019908.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019908.Bytes);
public long this[int i]=>Value[i];

public static A019908Inst Instance=new A019908Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019909
{
public static readonly long[] Value={ 1L,9L,4L,3L,8L,0L,3L,0L,9L,1L,3L,7L,7L,1L,8L,4L,8L,4L,2L,4L,3L,1L,9L,4L,2L,2L,4L,9L,7L,6L,8L,2L,4L,9L,5L,5L,1L,8L,3L,7L,8L,0L,1L,5L,2L,2L,1L,4L,6L,6L,3L,8L,6L,1L,3L,2L,3L,3L,6L,3L,3L,6L,3L,4L,3L,2L,5L,4L,1L,0L,5L,2L,9L,5L,4L,7L,3L,3L,9L,7L,2L,3L,8L,9L,6L,9L,2L,0L,8L,8L,9L,7L,6L,7L,3L,3L,1L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019909Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019909.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019909Inst : IEnumerable<long>
{
public static readonly long[] Value=A019909.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019909.Bytes);
public long this[int i]=>Value[i];

public static A019909Inst Instance=new A019909Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019910
{
public static readonly long[] Value={ 2L,1L,2L,5L,5L,6L,5L,6L,1L,6L,7L,0L,0L,2L,2L,1L,2L,5L,2L,5L,9L,5L,9L,1L,6L,6L,0L,5L,7L,0L,0L,8L,1L,9L,5L,7L,4L,1L,8L,5L,3L,4L,5L,4L,5L,7L,4L,8L,6L,9L,2L,0L,0L,9L,3L,9L,5L,4L,4L,4L,9L,5L,1L,9L,5L,2L,3L,5L,0L,4L,2L,2L,9L,1L,5L,6L,8L,9L,7L,1L,2L,2L,6L,5L,6L,4L,5L,0L,1L,4L,1L,9L,7L,1L,9L,3L,5L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019910Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019910.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019910Inst : IEnumerable<long>
{
public static readonly long[] Value=A019910.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019910.Bytes);
public long this[int i]=>Value[i];

public static A019910Inst Instance=new A019910Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019911
{
public static readonly long[] Value={ 2L,3L,0L,8L,6L,8L,1L,9L,1L,1L,2L,5L,5L,6L,3L,1L,1L,1L,7L,4L,8L,1L,4L,5L,6L,1L,3L,4L,7L,4L,4L,5L,3L,0L,6L,4L,8L,3L,3L,1L,2L,4L,5L,8L,4L,8L,5L,4L,3L,5L,1L,5L,0L,3L,2L,4L,3L,9L,0L,4L,1L,3L,3L,8L,0L,3L,9L,3L,5L,5L,5L,4L,2L,5L,7L,1L,5L,0L,8L,0L,3L,1L,6L,1L,8L,3L,6L,5L,6L,5L,8L,2L,0L,9L,2L,0L,8L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019911Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019911.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019911Inst : IEnumerable<long>
{
public static readonly long[] Value=A019911.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019911.Bytes);
public long this[int i]=>Value[i];

public static A019911Inst Instance=new A019911Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019912
{
public static readonly long[] Value={ 2L,4L,9L,3L,2L,8L,0L,0L,2L,8L,4L,3L,1L,8L,0L,6L,9L,1L,6L,2L,4L,0L,3L,9L,9L,3L,7L,8L,0L,4L,8L,6L,2L,1L,6L,7L,7L,6L,8L,8L,4L,6L,2L,4L,2L,4L,5L,9L,4L,2L,5L,8L,5L,7L,1L,8L,7L,9L,5L,9L,3L,8L,0L,0L,4L,7L,7L,0L,4L,7L,3L,1L,7L,6L,9L,7L,0L,9L,1L,4L,2L,3L,7L,6L,3L,8L,3L,4L,0L,9L,0L,5L,5L,8L,1L,3L,3L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019912Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019912.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019912Inst : IEnumerable<long>
{
public static readonly long[] Value=A019912.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019912.Bytes);
public long this[int i]=>Value[i];

public static A019912Inst Instance=new A019912Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019913
{
public static readonly long[] Value={ 2L,6L,7L,9L,4L,9L,1L,9L,2L,4L,3L,1L,1L,2L,2L,7L,0L,6L,4L,7L,2L,5L,5L,3L,6L,5L,8L,4L,9L,4L,1L,2L,7L,6L,3L,3L,0L,5L,7L,1L,9L,4L,7L,4L,6L,1L,8L,9L,6L,1L,9L,3L,7L,1L,9L,4L,4L,1L,9L,3L,0L,2L,0L,5L,4L,8L,0L,6L,6L,9L,8L,3L,0L,9L,1L,1L,9L,9L,9L,6L,2L,9L,1L,8L,8L,5L,3L,8L,1L,3L,2L,4L,2L,7L,5L,1L,4L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019913Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019913.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019913Inst : IEnumerable<long>
{
public static readonly long[] Value=A019913.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019913.Bytes);
public long this[int i]=>Value[i];

public static A019913Inst Instance=new A019913Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019914
{
public static readonly long[] Value={ 2L,8L,6L,7L,4L,5L,3L,8L,5L,7L,5L,8L,8L,0L,7L,9L,4L,0L,0L,4L,2L,7L,5L,8L,0L,6L,2L,7L,3L,2L,6L,6L,9L,9L,1L,2L,4L,2L,2L,3L,4L,7L,1L,1L,0L,2L,4L,5L,8L,5L,1L,6L,5L,6L,7L,2L,1L,3L,7L,9L,4L,8L,6L,0L,4L,2L,0L,9L,3L,8L,6L,5L,5L,2L,5L,4L,7L,8L,1L,9L,9L,3L,8L,5L,8L,5L,3L,4L,7L,3L,7L,9L,4L,7L,6L,3L,3L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019914Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019914.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019914Inst : IEnumerable<long>
{
public static readonly long[] Value=A019914.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019914.Bytes);
public long this[int i]=>Value[i];

public static A019914Inst Instance=new A019914Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019915
{
public static readonly long[] Value={ 3L,0L,5L,7L,3L,0L,6L,8L,1L,4L,5L,8L,6L,6L,0L,3L,5L,5L,7L,3L,4L,5L,4L,1L,9L,5L,8L,9L,9L,6L,5L,5L,0L,7L,1L,6L,1L,4L,6L,2L,5L,0L,2L,2L,1L,3L,8L,7L,1L,1L,6L,6L,9L,3L,6L,7L,0L,6L,8L,0L,5L,5L,7L,2L,1L,0L,0L,8L,7L,4L,0L,7L,7L,8L,1L,3L,3L,7L,4L,3L,6L,8L,2L,6L,8L,2L,5L,1L,6L,0L,2L,3L,5L,6L,3L,2L,0L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019915Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019915.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019915Inst : IEnumerable<long>
{
public static readonly long[] Value=A019915.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019915.Bytes);
public long this[int i]=>Value[i];

public static A019915Inst Instance=new A019915Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019916
{
public static readonly long[] Value={ 3L,2L,4L,9L,1L,9L,6L,9L,6L,2L,3L,2L,9L,0L,6L,3L,2L,6L,1L,5L,5L,8L,7L,1L,4L,1L,2L,2L,1L,5L,1L,3L,4L,4L,6L,4L,9L,5L,4L,9L,0L,3L,4L,7L,1L,5L,2L,1L,4L,7L,5L,1L,0L,0L,3L,0L,7L,8L,0L,4L,7L,1L,9L,1L,3L,6L,6L,7L,2L,9L,0L,0L,9L,6L,0L,7L,4L,4L,9L,4L,8L,3L,2L,2L,6L,8L,7L,7L,3L,5L,4L,4L,6L,9L,6L,5L,0L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019916Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019916.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019916Inst : IEnumerable<long>
{
public static readonly long[] Value=A019916.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019916.Bytes);
public long this[int i]=>Value[i];

public static A019916Inst Instance=new A019916Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019933
{
public static readonly long[] Value={ 7L,0L,0L,2L,0L,7L,5L,3L,8L,2L,0L,9L,7L,0L,9L,7L,7L,9L,4L,5L,8L,5L,2L,2L,7L,1L,9L,4L,4L,4L,8L,3L,2L,6L,5L,1L,8L,5L,2L,8L,5L,8L,0L,4L,4L,5L,6L,7L,8L,4L,2L,8L,6L,9L,2L,2L,0L,5L,6L,8L,1L,4L,9L,8L,5L,5L,5L,4L,7L,5L,9L,3L,3L,2L,7L,0L,0L,9L,2L,5L,5L,2L,8L,8L,5L,3L,1L,6L,4L,9L,3L,1L,9L,0L,4L,7L,5L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019933Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019933.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019933Inst : IEnumerable<long>
{
public static readonly long[] Value=A019933.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019933.Bytes);
public long this[int i]=>Value[i];

public static A019933Inst Instance=new A019933Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019934
{
public static readonly long[] Value={ 7L,2L,6L,5L,4L,2L,5L,2L,8L,0L,0L,5L,3L,6L,0L,8L,8L,5L,8L,9L,5L,4L,6L,6L,7L,5L,7L,4L,8L,0L,6L,1L,8L,7L,4L,9L,6L,1L,6L,0L,9L,2L,3L,9L,2L,9L,6L,5L,2L,0L,8L,4L,6L,2L,7L,5L,0L,0L,6L,6L,3L,2L,7L,3L,4L,5L,7L,4L,9L,3L,9L,1L,8L,4L,5L,6L,8L,3L,0L,8L,8L,4L,2L,0L,5L,7L,7L,5L,2L,2L,2L,1L,6L,1L,4L,0L,0L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019934Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019934.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019934Inst : IEnumerable<long>
{
public static readonly long[] Value=A019934.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019934.Bytes);
public long this[int i]=>Value[i];

public static A019934Inst Instance=new A019934Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019935
{
public static readonly long[] Value={ 7L,5L,3L,5L,5L,4L,0L,5L,0L,1L,0L,2L,7L,9L,4L,1L,5L,7L,0L,7L,3L,9L,5L,6L,4L,4L,8L,6L,2L,1L,5L,9L,2L,5L,9L,5L,0L,6L,1L,3L,4L,7L,0L,7L,5L,0L,9L,5L,9L,1L,9L,7L,0L,2L,7L,6L,4L,9L,7L,6L,7L,1L,0L,4L,3L,1L,7L,2L,8L,6L,0L,9L,2L,5L,1L,6L,4L,6L,4L,9L,9L,9L,2L,0L,7L,8L,9L,3L,8L,9L,1L,7L,5L,9L,0L,4L,6L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019935Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019935.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019935Inst : IEnumerable<long>
{
public static readonly long[] Value=A019935.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019935.Bytes);
public long this[int i]=>Value[i];

public static A019935Inst Instance=new A019935Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019936
{
public static readonly long[] Value={ 7L,8L,1L,2L,8L,5L,6L,2L,6L,5L,0L,6L,7L,1L,7L,3L,9L,7L,0L,6L,2L,9L,4L,9L,9L,7L,1L,9L,6L,2L,2L,6L,6L,8L,5L,6L,5L,8L,5L,4L,5L,9L,4L,0L,0L,3L,5L,1L,6L,0L,7L,6L,6L,6L,3L,2L,4L,3L,7L,2L,3L,3L,6L,0L,4L,5L,0L,1L,2L,5L,5L,2L,2L,4L,2L,9L,1L,8L,0L,5L,4L,5L,3L,3L,0L,7L,5L,2L,2L,5L,7L,8L,0L,8L,1L,4L,5L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019936Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019936.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019936Inst : IEnumerable<long>
{
public static readonly long[] Value=A019936.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019936.Bytes);
public long this[int i]=>Value[i];

public static A019936Inst Instance=new A019936Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019937
{
public static readonly long[] Value={ 8L,0L,9L,7L,8L,4L,0L,3L,3L,1L,9L,5L,0L,0L,7L,1L,4L,8L,0L,3L,6L,9L,9L,1L,3L,7L,4L,2L,3L,5L,7L,7L,1L,2L,2L,5L,2L,1L,6L,5L,5L,6L,4L,9L,2L,5L,8L,0L,5L,9L,2L,5L,1L,7L,6L,3L,0L,3L,6L,9L,3L,0L,4L,9L,3L,9L,0L,5L,6L,4L,5L,5L,5L,1L,6L,3L,6L,0L,7L,8L,9L,5L,9L,1L,8L,3L,8L,6L,7L,5L,6L,6L,9L,9L,6L,6L,7L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019937Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019937.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019937Inst : IEnumerable<long>
{
public static readonly long[] Value=A019937.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019937.Bytes);
public long this[int i]=>Value[i];

public static A019937Inst Instance=new A019937Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019938
{
public static readonly long[] Value={ 8L,3L,9L,0L,9L,9L,6L,3L,1L,1L,7L,7L,2L,8L,0L,0L,1L,1L,7L,6L,3L,1L,2L,7L,2L,9L,8L,1L,2L,3L,1L,8L,1L,3L,6L,4L,6L,8L,7L,4L,3L,4L,2L,8L,3L,0L,1L,2L,3L,4L,6L,5L,3L,3L,2L,4L,4L,1L,0L,2L,0L,3L,9L,2L,3L,2L,5L,1L,8L,3L,2L,8L,0L,5L,5L,0L,3L,4L,5L,2L,1L,7L,6L,0L,8L,0L,6L,7L,2L,4L,1L,1L,3L,1L,2L,8L,8L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019938Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019938.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019938Inst : IEnumerable<long>
{
public static readonly long[] Value=A019938.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019938.Bytes);
public long this[int i]=>Value[i];

public static A019938Inst Instance=new A019938Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019939
{
public static readonly long[] Value={ 8L,6L,9L,2L,8L,6L,7L,3L,7L,8L,1L,6L,2L,2L,6L,6L,6L,2L,2L,0L,0L,0L,9L,5L,6L,3L,8L,7L,0L,3L,9L,4L,2L,0L,9L,0L,6L,6L,8L,0L,9L,0L,4L,9L,7L,7L,8L,2L,4L,5L,4L,8L,3L,9L,8L,3L,5L,7L,3L,1L,9L,6L,4L,3L,9L,8L,3L,4L,5L,1L,2L,6L,0L,9L,5L,9L,5L,6L,3L,9L,5L,9L,9L,8L,4L,9L,5L,7L,2L,3L,8L,0L,4L,2L,5L,1L,5L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019939Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019939.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019939Inst : IEnumerable<long>
{
public static readonly long[] Value=A019939.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019939.Bytes);
public long this[int i]=>Value[i];

public static A019939Inst Instance=new A019939Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019940
{
public static readonly long[] Value={ 9L,0L,0L,4L,0L,4L,0L,4L,4L,2L,9L,7L,8L,3L,9L,9L,4L,5L,1L,2L,0L,4L,7L,7L,2L,0L,3L,8L,8L,5L,3L,7L,1L,7L,0L,2L,0L,7L,6L,4L,6L,6L,2L,1L,1L,2L,9L,9L,4L,8L,5L,2L,8L,2L,4L,2L,7L,0L,7L,9L,0L,8L,3L,9L,2L,2L,4L,0L,1L,7L,1L,4L,2L,5L,2L,5L,0L,2L,5L,3L,1L,8L,6L,2L,6L,3L,1L,1L,5L,9L,8L,6L,6L,3L,3L,8L,2L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019940Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019940.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019940Inst : IEnumerable<long>
{
public static readonly long[] Value=A019940.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019940.Bytes);
public long this[int i]=>Value[i];

public static A019940Inst Instance=new A019940Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019941
{
public static readonly long[] Value={ 9L,3L,2L,5L,1L,5L,0L,8L,6L,1L,3L,7L,6L,6L,1L,7L,0L,5L,6L,1L,2L,1L,8L,5L,6L,2L,7L,4L,2L,6L,1L,8L,6L,6L,5L,4L,3L,5L,3L,5L,3L,7L,2L,9L,9L,4L,9L,4L,0L,2L,3L,4L,3L,4L,5L,9L,6L,1L,3L,9L,2L,5L,8L,0L,5L,3L,7L,1L,3L,3L,4L,7L,5L,3L,6L,5L,8L,3L,0L,8L,3L,5L,1L,8L,8L,1L,7L,3L,8L,7L,7L,4L,9L,3L,2L,5L,1L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019941Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019941.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019941Inst : IEnumerable<long>
{
public static readonly long[] Value=A019941.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019941.Bytes);
public long this[int i]=>Value[i];

public static A019941Inst Instance=new A019941Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019942
{
public static readonly long[] Value={ 9L,6L,5L,6L,8L,8L,7L,7L,4L,8L,0L,7L,0L,7L,4L,0L,4L,5L,9L,5L,8L,0L,2L,7L,2L,9L,9L,7L,0L,0L,6L,8L,1L,3L,9L,3L,2L,1L,1L,5L,8L,9L,8L,1L,7L,0L,8L,3L,1L,0L,9L,4L,6L,2L,4L,4L,1L,1L,6L,1L,9L,0L,7L,3L,8L,9L,5L,7L,9L,8L,4L,2L,4L,9L,5L,6L,3L,8L,0L,0L,1L,1L,5L,9L,8L,7L,2L,6L,6L,3L,1L,0L,9L,5L,3L,0L,6L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019942Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019942.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019942Inst : IEnumerable<long>
{
public static readonly long[] Value=A019942.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019942.Bytes);
public long this[int i]=>Value[i];

public static A019942Inst Instance=new A019942Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019943
{
public static readonly ulong[] Value={ 1L,21L,298L,3570L,38971L,401751L,3988468L,38583300L,366449941L,3434404281L,31873887838L,293663563830L,2690806228111L,24553315831611L,223338364450408L,2026585451393160L,18355202849805481L,166009125098571741L,1499772036736668178L,13537796780062999290UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019943Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019943.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019943Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A019943.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019943.Bytes);
public ulong this[int i]=>Value[i];

public static A019943Inst Instance=new A019943Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019944
{
public static readonly long[] Value={ 1L,0L,3L,5L,5L,3L,0L,3L,1L,3L,7L,9L,0L,5L,6L,9L,5L,0L,6L,9L,5L,8L,8L,3L,2L,5L,5L,1L,2L,4L,8L,1L,3L,2L,0L,2L,4L,9L,6L,9L,9L,3L,8L,4L,1L,2L,6L,5L,2L,3L,3L,9L,9L,6L,3L,4L,5L,1L,1L,0L,2L,0L,7L,3L,7L,7L,0L,2L,8L,4L,9L,1L,0L,8L,6L,9L,7L,5L,5L,9L,9L,8L,5L,9L,0L,9L,0L,1L,7L,0L,2L,4L,9L,9L,6L,5L,0L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019944Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019944.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019944Inst : IEnumerable<long>
{
public static readonly long[] Value=A019944.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019944.Bytes);
public long this[int i]=>Value[i];

public static A019944Inst Instance=new A019944Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019945
{
public static readonly long[] Value={ 1L,0L,7L,2L,3L,6L,8L,7L,1L,0L,0L,2L,4L,6L,8L,2L,5L,3L,2L,9L,4L,6L,0L,2L,7L,7L,4L,8L,0L,7L,2L,5L,5L,0L,1L,6L,6L,2L,8L,9L,3L,9L,7L,7L,9L,1L,4L,3L,1L,3L,8L,4L,6L,5L,3L,9L,9L,2L,8L,8L,4L,2L,5L,3L,8L,1L,0L,4L,2L,7L,3L,4L,8L,7L,1L,7L,3L,3L,6L,4L,2L,8L,7L,2L,7L,9L,0L,6L,0L,8L,1L,3L,2L,3L,0L,6L,8L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019945Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019945.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019945Inst : IEnumerable<long>
{
public static readonly long[] Value=A019945.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019945.Bytes);
public long this[int i]=>Value[i];

public static A019945Inst Instance=new A019945Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019946
{
public static readonly long[] Value={ 1L,1L,1L,0L,6L,1L,2L,5L,1L,4L,8L,2L,9L,1L,9L,2L,8L,7L,0L,1L,4L,3L,4L,8L,1L,9L,6L,4L,1L,6L,5L,1L,3L,5L,5L,3L,2L,5L,7L,6L,9L,5L,9L,5L,1L,0L,3L,9L,0L,8L,5L,9L,0L,4L,8L,1L,8L,4L,4L,0L,2L,2L,2L,0L,2L,8L,9L,9L,6L,5L,5L,3L,5L,8L,7L,3L,7L,3L,1L,3L,6L,5L,4L,5L,8L,5L,0L,6L,1L,6L,9L,2L,1L,5L,8L,7L,8L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019946Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019946.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019946Inst : IEnumerable<long>
{
public static readonly long[] Value=A019946.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019946.Bytes);
public long this[int i]=>Value[i];

public static A019946Inst Instance=new A019946Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019947
{
public static readonly long[] Value={ 1L,1L,5L,0L,3L,6L,8L,4L,0L,7L,2L,2L,1L,0L,0L,9L,5L,5L,5L,8L,7L,6L,3L,3L,1L,0L,2L,5L,5L,6L,9L,5L,7L,0L,3L,6L,2L,0L,1L,4L,4L,6L,5L,0L,4L,8L,1L,3L,1L,9L,9L,9L,5L,8L,9L,6L,2L,6L,4L,5L,2L,6L,8L,7L,8L,2L,2L,4L,5L,1L,5L,9L,1L,3L,8L,7L,5L,1L,5L,0L,9L,1L,7L,3L,1L,2L,3L,1L,6L,5L,7L,8L,7L,9L,8L,3L,8L,9L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019947Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019947.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019947Inst : IEnumerable<long>
{
public static readonly long[] Value=A019947.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019947.Bytes);
public long this[int i]=>Value[i];

public static A019947Inst Instance=new A019947Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019948
{
public static readonly long[] Value={ 1L,1L,9L,1L,7L,5L,3L,5L,9L,2L,5L,9L,4L,2L,0L,9L,9L,5L,8L,7L,0L,5L,3L,0L,8L,0L,7L,1L,8L,6L,0L,4L,1L,9L,3L,3L,6L,9L,3L,0L,7L,0L,0L,4L,0L,7L,7L,0L,8L,5L,4L,3L,8L,5L,3L,6L,5L,4L,8L,3L,0L,0L,0L,6L,9L,0L,3L,4L,1L,2L,1L,4L,5L,8L,9L,0L,5L,5L,1L,7L,7L,2L,7L,5L,8L,1L,0L,9L,3L,9L,4L,2L,7L,3L,7L,7L,7L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019948Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019948.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019948Inst : IEnumerable<long>
{
public static readonly long[] Value=A019948.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019948.Bytes);
public long this[int i]=>Value[i];

public static A019948Inst Instance=new A019948Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019981
{
public static readonly long[] Value={ 8L,1L,4L,4L,3L,4L,6L,4L,2L,7L,9L,7L,4L,5L,9L,4L,0L,2L,3L,8L,2L,5L,6L,6L,1L,3L,9L,4L,9L,7L,9L,6L,9L,5L,7L,5L,2L,3L,2L,2L,5L,5L,0L,1L,8L,0L,6L,8L,0L,4L,4L,4L,6L,6L,0L,0L,1L,0L,3L,3L,3L,3L,3L,1L,9L,8L,6L,1L,7L,2L,8L,6L,9L,3L,5L,0L,0L,0L,3L,7L,4L,0L,2L,8L,6L,1L,7L,5L,5L,6L,6L,3L,6L,2L,7L,6L,1L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019981Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019981.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019981Inst : IEnumerable<long>
{
public static readonly long[] Value=A019981.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019981.Bytes);
public long this[int i]=>Value[i];

public static A019981Inst Instance=new A019981Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019982
{
public static readonly long[] Value={ 9L,5L,1L,4L,3L,6L,4L,4L,5L,4L,2L,2L,2L,5L,8L,4L,9L,2L,9L,6L,8L,3L,9L,7L,1L,4L,5L,4L,9L,4L,5L,6L,8L,2L,4L,6L,6L,6L,4L,8L,7L,6L,8L,1L,4L,5L,1L,5L,0L,6L,5L,9L,2L,2L,7L,3L,1L,1L,2L,6L,4L,8L,9L,1L,4L,6L,9L,8L,1L,0L,6L,9L,9L,9L,9L,7L,1L,6L,7L,4L,9L,4L,2L,7L,3L,5L,4L,2L,3L,1L,2L,1L,7L,3L,9L,3L,7L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019982Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019982.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019982Inst : IEnumerable<long>
{
public static readonly long[] Value=A019982.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019982.Bytes);
public long this[int i]=>Value[i];

public static A019982Inst Instance=new A019982Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019983
{
public static readonly long[] Value={ 1L,1L,4L,3L,0L,0L,5L,2L,3L,0L,2L,7L,6L,1L,3L,4L,3L,0L,6L,7L,2L,1L,0L,8L,5L,5L,5L,4L,9L,1L,6L,2L,8L,9L,0L,3L,0L,1L,3L,7L,0L,2L,1L,0L,7L,9L,7L,7L,4L,7L,6L,0L,8L,8L,3L,5L,5L,7L,7L,0L,5L,6L,6L,3L,9L,9L,7L,2L,1L,2L,8L,2L,6L,0L,6L,6L,4L,5L,0L,2L,8L,2L,9L,9L,7L,8L,8L,4L,3L,3L,8L,6L,3L,3L,3L,5L,2L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019983Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019983.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019983Inst : IEnumerable<long>
{
public static readonly long[] Value=A019983.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019983.Bytes);
public long this[int i]=>Value[i];

public static A019983Inst Instance=new A019983Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019984
{
public static readonly long[] Value={ 1L,4L,3L,0L,0L,6L,6L,6L,2L,5L,6L,7L,1L,1L,9L,2L,7L,9L,1L,0L,1L,2L,8L,0L,5L,3L,3L,4L,7L,5L,8L,6L,3L,4L,9L,8L,8L,1L,0L,3L,6L,2L,6L,8L,0L,1L,2L,6L,8L,3L,7L,0L,5L,1L,7L,3L,6L,6L,6L,6L,1L,3L,0L,0L,3L,2L,6L,1L,6L,0L,4L,7L,5L,3L,3L,1L,2L,1L,5L,3L,1L,7L,5L,5L,4L,6L,9L,2L,7L,3L,7L,3L,0L,3L,3L,8L,6L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019984Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019984.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019984Inst : IEnumerable<long>
{
public static readonly long[] Value=A019984.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019984.Bytes);
public long this[int i]=>Value[i];

public static A019984Inst Instance=new A019984Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019985
{
public static readonly long[] Value={ 1L,9L,0L,8L,1L,1L,3L,6L,6L,8L,7L,7L,2L,8L,2L,1L,1L,0L,6L,3L,4L,0L,6L,7L,4L,8L,7L,3L,4L,3L,6L,5L,3L,4L,9L,3L,0L,8L,2L,5L,0L,9L,6L,1L,2L,1L,8L,1L,1L,1L,2L,6L,5L,8L,3L,9L,0L,9L,5L,9L,7L,4L,6L,9L,8L,2L,9L,2L,6L,5L,7L,5L,6L,0L,8L,8L,8L,0L,7L,3L,0L,6L,8L,9L,9L,9L,7L,1L,2L,4L,1L,7L,5L,6L,6L,2L,8L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019985Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019985.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019985Inst : IEnumerable<long>
{
public static readonly long[] Value=A019985.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019985.Bytes);
public long this[int i]=>Value[i];

public static A019985Inst Instance=new A019985Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019986
{
public static readonly long[] Value={ 2L,8L,6L,3L,6L,2L,5L,3L,2L,8L,2L,9L,1L,5L,6L,0L,3L,5L,5L,0L,7L,5L,6L,5L,0L,9L,3L,2L,0L,9L,4L,6L,4L,2L,5L,0L,7L,7L,9L,5L,1L,7L,1L,0L,3L,2L,3L,1L,5L,2L,0L,2L,5L,5L,9L,7L,8L,3L,8L,1L,9L,6L,0L,8L,9L,7L,1L,3L,5L,6L,2L,0L,4L,0L,8L,1L,1L,3L,6L,5L,3L,4L,9L,8L,0L,9L,3L,6L,9L,2L,6L,5L,7L,6L,2L,7L,9L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019986Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019986.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019986Inst : IEnumerable<long>
{
public static readonly long[] Value=A019986.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019986.Bytes);
public long this[int i]=>Value[i];

public static A019986Inst Instance=new A019986Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019987
{
public static readonly long[] Value={ 5L,7L,2L,8L,9L,9L,6L,1L,6L,3L,0L,7L,5L,9L,4L,2L,4L,6L,8L,7L,2L,7L,8L,1L,4L,7L,5L,3L,7L,1L,1L,2L,5L,7L,7L,9L,8L,0L,2L,1L,7L,5L,2L,2L,2L,3L,5L,1L,4L,3L,9L,2L,6L,4L,7L,2L,5L,8L,1L,1L,0L,3L,6L,0L,6L,5L,2L,9L,2L,2L,8L,9L,3L,6L,4L,7L,9L,1L,9L,3L,0L,6L,7L,2L,4L,1L,6L,2L,8L,2L,2L,0L,6L,8L,3L,8L,8L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019987Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019987.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019987Inst : IEnumerable<long>
{
public static readonly long[] Value=A019987.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019987.Bytes);
public long this[int i]=>Value[i];

public static A019987Inst Instance=new A019987Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019988
{
public static readonly long[] Value={ 1L,2L,5L,16L,55L,222L,950L,4265L,19591L,91678L,434005L,2073783L,9979772L,48315186L,235088794L,1148891118L,5636168859L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019988Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019988.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019988Inst : IEnumerable<long>
{
public static readonly long[] Value=A019988.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019988.Bytes);
public long this[int i]=>Value[i];

public static A019988Inst Instance=new A019988Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019989
{
public static readonly long[] Value={ 2L,5L,6L,8L,14L,15L,16L,18L,20L,23L,24L,26L,35L,41L,42L,43L,45L,47L,48L,49L,52L,54L,56L,59L,60L,62L,68L,69L,70L,72L,74L,77L,78L,80L,91L,98L,104L,105L,107L,116L,122L,123L,124L,126L,128L,129L,130L,133L,135L,137L,140L,141L,142L,144L,146L,147L,148L,154L,156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019989Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019989.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019989Inst : IEnumerable<long>
{
public static readonly long[] Value=A019989.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019989.Bytes);
public long this[int i]=>Value[i];

public static A019989Inst Instance=new A019989Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019990
{
public static readonly long[] Value={ 1L,3L,4L,7L,9L,11L,12L,13L,19L,21L,22L,25L,27L,29L,32L,33L,34L,36L,38L,39L,40L,46L,55L,57L,58L,61L,63L,65L,66L,67L,73L,75L,76L,79L,81L,83L,86L,87L,89L,95L,96L,97L,99L,101L,102L,103L,106L,108L,110L,113L,114L,115L,117L,119L,120L,121L,127L,136L,138L,139L,145L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019990Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019990.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019990Inst : IEnumerable<long>
{
public static readonly long[] Value=A019990.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019990.Bytes);
public long this[int i]=>Value[i];

public static A019990Inst Instance=new A019990Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019991
{
public static readonly long[] Value={ 10L,17L,28L,30L,31L,37L,44L,50L,51L,53L,64L,71L,82L,84L,85L,88L,90L,92L,93L,94L,100L,109L,111L,112L,118L,125L,131L,132L,134L,143L,149L,150L,151L,153L,155L,158L,159L,161L,172L,179L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019991Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019991.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019991Inst : IEnumerable<long>
{
public static readonly long[] Value=A019991.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019991.Bytes);
public long this[int i]=>Value[i];

public static A019991Inst Instance=new A019991Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019992
{
public static readonly long[] Value={ 5L,21L,88L,368L,1538L,6427L,26857L,112229L,468978L,1959746L,8189306L,34221135L,143001871L,597570335L,2497102330L,10434788478L,43604464772L,182212543365L,761422279419L,3181800093939L,13295975323332L,55560674643076L,232174661258332L,970201922073653L,4054239874815929L,16941690784755705L,70795240417122020L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019992Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019992.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019992Inst : IEnumerable<long>
{
public static readonly long[] Value=A019992.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019992.Bytes);
public long this[int i]=>Value[i];

public static A019992Inst Instance=new A019992Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019993
{
public static readonly long[] Value={ 1L,2L,6L,74L,76L,479L,658L,749L,1029L,1722L,3693L,5431L,17081L,26611L,89702L,93902L,132726L,140759L,144429L,154292L,928663L,1178463L,1625140L,2053165L,2690949L,2935639L,3643165L,8402288L,11566624L,11599521L,54349600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019993Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019993.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019993Inst : IEnumerable<long>
{
public static readonly long[] Value=A019993.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019993.Bytes);
public long this[int i]=>Value[i];

public static A019993Inst Instance=new A019993Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019994
{
public static readonly long[] Value={ 2L,21L,929L,3380L,44668L,45653L,90314L,442076L,1511645L,2108657L,6512625L,59305467L,268601019L,418467213L,680269244L,712120382L,838792718L,1067470406L,1095301586L,53830654373L,62793395990L,137694158842L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019994Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019994.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019994Inst : IEnumerable<long>
{
public static readonly long[] Value=A019994.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019994.Bytes);
public long this[int i]=>Value[i];

public static A019994Inst Instance=new A019994Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019995
{
public static readonly long[] Value={ 1L,2L,5L,8L,10L,27L,31L,37L,38L,102L,110L,126L,219L,245L,309L,389L,474L,648L,653L,719L,979L,4642L,8745L,17984L,27374L,33806L,47578L,63375L,155060L,214982L,222936L,774303L,1212989L,1314605L,1914365L,2148329L,4213072L,7179881L,27679209L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019995Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019995.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019995Inst : IEnumerable<long>
{
public static readonly long[] Value=A019995.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019995.Bytes);
public long this[int i]=>Value[i];

public static A019995Inst Instance=new A019995Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019996
{
public static readonly long[] Value={ 2L,24L,39L,104L,388L,578L,669L,2746L,2819L,3013L,5169L,17398L,19094L,21359L,23116L,24950L,48267L,48487L,105621L,215513L,4706574L,16400064L,106043719L,137338247L,243888200L,478287113L,673135223L,3077440133L,6453969104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019996Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019996.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019996Inst : IEnumerable<long>
{
public static readonly long[] Value=A019996.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019996.Bytes);
public long this[int i]=>Value[i];

public static A019996Inst Instance=new A019996Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020061
{
public static readonly long[] Value={ 1L,0L,1L,3L,11L,55L,318L,2133L,16430L,142945L,1386569L,14836294L,173584649L,2204525051L,30201993205L,443969300123L,6970318011936L,116404310799338L,2060356301148292L,38528662831473069L,759014657780019468L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020061Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020061.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020061Inst : IEnumerable<long>
{
public static readonly long[] Value=A020061.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020061.Bytes);
public long this[int i]=>Value[i];

public static A020061Inst Instance=new A020061Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020062
{
public static readonly long[] Value={ 1L,0L,0L,0L,2L,12L,67L,425L,3102L,25750L,239483L,2466677L,27873456L,342843514L,4559818740L,65205407994L,997642742321L,16261576699844L,281325276907303L,5148252567403658L,99361274550890613L,2017033873383079453L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020062Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020062.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020062Inst : IEnumerable<long>
{
public static readonly long[] Value=A020062.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020062.Bytes);
public long this[int i]=>Value[i];

public static A020062Inst Instance=new A020062Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020063
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,2L,14L,91L,648L,5252L,47801L,482796L,5359035L,64844332L,849460756L,11977396665L,180858689641L,2911824903229L,49792205845228L,901238925798638L,17213663482753993L,345994636003355264L,7300486819670796087L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020063Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020063.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020063Inst : IEnumerable<long>
{
public static readonly long[] Value=A020063.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020063.Bytes);
public long this[int i]=>Value[i];

public static A020063Inst Instance=new A020063Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020064
{
public static readonly long[] Value={ 1L,0L,1L,4L,18L,92L,543L,3741L,29513L,262341L,2594261L,28248627L,335844792L,4328666215L,60120364100L,895125421053L,14222548356738L,240203038913807L,4296965473902563L,81164903395937306L,1614279745319197538L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020064Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020064.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020064Inst : IEnumerable<long>
{
public static readonly long[] Value=A020064.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020064.Bytes);
public long this[int i]=>Value[i];

public static A020064Inst Instance=new A020064Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020065
{
public static readonly long[] Value={ 1L,0L,1L,3L,14L,69L,400L,2714L,21115L,185345L,1812263L,19532170L,230045568L,2939471157L,40499380396L,598490843642L,9442855533026L,158430131720783L,2816535675036146L,52888281009012092L,1046012668844905826L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020065Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020065.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020065Inst : IEnumerable<long>
{
public static readonly long[] Value=A020065.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020065.Bytes);
public long this[int i]=>Value[i];

public static A020065Inst Instance=new A020065Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020066
{
public static readonly long[] Value={ 1L,0L,0L,2L,7L,35L,198L,1302L,9843L,84216L,804738L,8494460L,98158213L,1232430908L,16706285646L,243169268856L,3782633071103L,62623591954942L,1099391947653437L,20399828362013787L,398929976857158503L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020066Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020066.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020066Inst : IEnumerable<long>
{
public static readonly long[] Value=A020066.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020066.Bytes);
public long this[int i]=>Value[i];

public static A020066Inst Instance=new A020066Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020067
{
public static readonly long[] Value={ 1L,0L,0L,1L,5L,24L,130L,842L,6274L,52988L,500442L,5226841L,59818300L,744405515L,10008118594L,144561713037L,2232675345794L,36715105686390L,640474621418148L,11813198572823622L,229701083360459334L,4696111037591613052L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020067Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020067.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020067Inst : IEnumerable<long>
{
public static readonly long[] Value=A020067.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020067.Bytes);
public long this[int i]=>Value[i];

public static A020067Inst Instance=new A020067Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020068
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,8L,42L,266L,1927L,15844L,146122L,1493700L,16762639L,204876708L,2708925368L,38526938568L,586465620430L,9513775620309L,163848357905335L,2985681188497227L,57391427290002261L,1160582196308934615L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020068Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020068.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020068Inst : IEnumerable<long>
{
public static readonly long[] Value=A020068.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020068.Bytes);
public long this[int i]=>Value[i];

public static A020068Inst Instance=new A020068Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020069
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,3L,17L,104L,740L,6005L,54717L,553253L,6147263L,74450193L,976124760L,13774204958L,208143541601L,3353423725801L,57380805974819L,1039230152655057L,19860842917407765L,399423618672311729L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020069Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020069.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020069Inst : IEnumerable<long>
{
public static readonly long[] Value=A020069.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020069.Bytes);
public long this[int i]=>Value[i];

public static A020069Inst Instance=new A020069Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020070
{
public static readonly long[] Value={ 1L,0L,1L,4L,18L,89L,523L,3598L,28341L,251531L,2483877L,27012163L,320769440L,4129906548L,57302453360L,852373993744L,13531437150692L,228343001917931L,4081631159283027L,77040788131467135L,1531185664112909314L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020070Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020070.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020070Inst : IEnumerable<long>
{
public static readonly long[] Value=A020070.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020070.Bytes);
public long this[int i]=>Value[i];

public static A020070Inst Instance=new A020070Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020071
{
public static readonly long[] Value={ 1L,0L,1L,2L,9L,44L,251L,1665L,12700L,109544L,1054363L,11202616L,130230419L,1644159040L,22401666926L,327624378797L,5119130918712L,85105551523594L,1499985345603353L,27937227061862467L,548268081089050917L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020071Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020071.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020071Inst : IEnumerable<long>
{
public static readonly long[] Value=A020071.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020071.Bytes);
public long this[int i]=>Value[i];

public static A020071Inst Instance=new A020071Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020072
{
public static readonly long[] Value={ 1L,0L,0L,1L,4L,18L,97L,619L,4569L,38269L,358778L,3722325L,42341447L,523975411L,7008171124L,100742459918L,1548915321245L,25363488385398L,440690610696307L,8097689971544644L,156892743198677492L,3196689642673053918L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020072Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020072.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020072Inst : IEnumerable<long>
{
public static readonly long[] Value=A020072.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020072.Bytes);
public long this[int i]=>Value[i];

public static A020072Inst Instance=new A020072Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020073
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,3L,19L,120L,861L,7000L,63875L,646742L,7195012L,87239530L,1145018831L,16173391001L,244622538902L,3944538439805L,67550220781671L,1224347751667801L,23415650750646695L,471239971356764753L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020073Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020073.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020073Inst : IEnumerable<long>
{
public static readonly long[] Value=A020073.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020073.Bytes);
public long this[int i]=>Value[i];

public static A020073Inst Instance=new A020073Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020074
{
public static readonly long[] Value={ 1L,0L,1L,4L,17L,85L,499L,3422L,26888L,238157L,2347553L,25487720L,302211542L,3885576978L,53842995267L,799953072548L,12684970150410L,213832353964066L,3818434892215473L,72004772253206072L,1429809049027949159L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020074Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020074.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020074Inst : IEnumerable<long>
{
public static readonly long[] Value=A020074.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020074.Bytes);
public long this[int i]=>Value[i];

public static A020074Inst Instance=new A020074Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020075
{
public static readonly long[] Value={ 1L,0L,1L,3L,12L,58L,332L,2232L,17225L,150103L,1458149L,15623031L,183012659L,2326875239L,31911431853L,469553925838L,7378704548888L,123329776031414L,2184698889699346L,40885079221516335L,806020133224179176L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020075Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020075.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020075Inst : IEnumerable<long>
{
public static readonly long[] Value=A020075.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020075.Bytes);
public long this[int i]=>Value[i];

public static A020075Inst Instance=new A020075Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020076
{
public static readonly long[] Value={ 1L,0L,0L,2L,8L,37L,210L,1380L,10450L,89574L,857351L,9063434L,104876887L,1318452295L,17893281147L,260730668150L,4059948975490L,67279154450985L,1182190856781603L,21954973054515489L,429690186924088870L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020076Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020076.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020076Inst : IEnumerable<long>
{
public static readonly long[] Value=A020076.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020076.Bytes);
public long this[int i]=>Value[i];

public static A020076Inst Instance=new A020076Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020109
{
public static readonly long[] Value={ 1L,1L,2L,5L,19L,93L,544L,3742L,29514L,262342L,2594262L,28248628L,335844793L,4328666216L,60120364101L,895125421054L,14222548356739L,240203038913808L,4296965473902564L,81164903395937307L,1614279745319197539L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020109Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020109.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020109Inst : IEnumerable<long>
{
public static readonly long[] Value=A020109.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020109.Bytes);
public long this[int i]=>Value[i];

public static A020109Inst Instance=new A020109Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020110
{
public static readonly long[] Value={ 1L,1L,2L,4L,15L,70L,401L,2715L,21116L,185346L,1812264L,19532171L,230045569L,2939471158L,40499380397L,598490843643L,9442855533027L,158430131720784L,2816535675036147L,52888281009012093L,1046012668844905827L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020110Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020110.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020110Inst : IEnumerable<long>
{
public static readonly long[] Value=A020110.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020110.Bytes);
public long this[int i]=>Value[i];

public static A020110Inst Instance=new A020110Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020111
{
public static readonly long[] Value={ 1L,1L,1L,3L,8L,36L,199L,1303L,9844L,84217L,804739L,8494461L,98158214L,1232430909L,16706285647L,243169268857L,3782633071104L,62623591954943L,1099391947653438L,20399828362013788L,398929976857158504L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020111Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020111.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020111Inst : IEnumerable<long>
{
public static readonly long[] Value=A020111.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020111.Bytes);
public long this[int i]=>Value[i];

public static A020111Inst Instance=new A020111Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020112
{
public static readonly long[] Value={ 1L,1L,1L,2L,6L,25L,131L,843L,6275L,52989L,500443L,5226842L,59818301L,744405516L,10008118595L,144561713038L,2232675345795L,36715105686391L,640474621418149L,11813198572823623L,229701083360459335L,4696111037591613053L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020112Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020112.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020112Inst : IEnumerable<long>
{
public static readonly long[] Value=A020112.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020112.Bytes);
public long this[int i]=>Value[i];

public static A020112Inst Instance=new A020112Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020113
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1L,2L,9L,43L,267L,1928L,15845L,146123L,1493701L,16762640L,204876709L,2708925369L,38526938569L,586465620431L,9513775620310L,163848357905336L,2985681188497228L,57391427290002262L,1160582196308934616L,BigInteger.Parse("24630133277222945727"),BigInteger.Parse("547336295049398793928") };
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
public class A020113Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020113.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020113Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A020113.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A020113.Bytes);
public BigInteger this[int i]=>Value[i];

public static A020113Inst Instance=new A020113Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020114
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,4L,18L,105L,741L,6006L,54718L,553254L,6147264L,74450194L,976124761L,13774204959L,208143541602L,3353423725802L,57380805974820L,1039230152655058L,19860842917407766L,399423618672311730L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020114Inst : IEnumerable<long>
{
public static readonly long[] Value=A020114.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020114.Bytes);
public long this[int i]=>Value[i];

public static A020114Inst Instance=new A020114Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020115
{
public static readonly long[] Value={ 1L,1L,2L,5L,19L,90L,524L,3599L,28342L,251532L,2483878L,27012164L,320769441L,4129906549L,57302453361L,852373993745L,13531437150693L,228343001917932L,4081631159283028L,77040788131467136L,1531185664112909315L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020115Inst : IEnumerable<long>
{
public static readonly long[] Value=A020115.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020115.Bytes);
public long this[int i]=>Value[i];

public static A020115Inst Instance=new A020115Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020116
{
public static readonly long[] Value={ 1L,1L,2L,3L,10L,45L,252L,1666L,12701L,109545L,1054364L,11202617L,130230420L,1644159041L,22401666927L,327624378798L,5119130918713L,85105551523595L,1499985345603354L,27937227061862468L,548268081089050918L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020116Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020116.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020116Inst : IEnumerable<long>
{
public static readonly long[] Value=A020116.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020116.Bytes);
public long this[int i]=>Value[i];

public static A020116Inst Instance=new A020116Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020117
{
public static readonly long[] Value={ 1L,1L,1L,2L,5L,19L,98L,620L,4570L,38270L,358779L,3722326L,42341448L,523975412L,7008171125L,100742459919L,1548915321246L,25363488385399L,440690610696308L,8097689971544645L,156892743198677493L,3196689642673053919L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020117Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020117.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020117Inst : IEnumerable<long>
{
public static readonly long[] Value=A020117.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020117.Bytes);
public long this[int i]=>Value[i];

public static A020117Inst Instance=new A020117Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020118
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,4L,20L,121L,862L,7001L,63876L,646743L,7195013L,87239531L,1145018832L,16173391002L,244622538903L,3944538439806L,67550220781672L,1224347751667802L,23415650750646696L,471239971356764754L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020118Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020118.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020118Inst : IEnumerable<long>
{
public static readonly long[] Value=A020118.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020118.Bytes);
public long this[int i]=>Value[i];

public static A020118Inst Instance=new A020118Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020119
{
public static readonly long[] Value={ 1L,1L,2L,5L,18L,86L,500L,3423L,26889L,238158L,2347554L,25487721L,302211543L,3885576979L,53842995268L,799953072549L,12684970150411L,213832353964067L,3818434892215474L,72004772253206073L,1429809049027949160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020119Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020119.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020119Inst : IEnumerable<long>
{
public static readonly long[] Value=A020119.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020119.Bytes);
public long this[int i]=>Value[i];

public static A020119Inst Instance=new A020119Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020120
{
public static readonly long[] Value={ 1L,1L,2L,4L,13L,59L,333L,2233L,17226L,150104L,1458150L,15623032L,183012660L,2326875240L,31911431854L,469553925839L,7378704548889L,123329776031415L,2184698889699347L,40885079221516336L,806020133224179177L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020120Inst : IEnumerable<long>
{
public static readonly long[] Value=A020120.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020120.Bytes);
public long this[int i]=>Value[i];

public static A020120Inst Instance=new A020120Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020121
{
public static readonly long[] Value={ 1L,1L,1L,3L,9L,38L,211L,1381L,10451L,89575L,857352L,9063435L,104876888L,1318452296L,17893281148L,260730668151L,4059948975491L,67279154450986L,1182190856781604L,21954973054515490L,429690186924088871L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020121Inst : IEnumerable<long>
{
public static readonly long[] Value=A020121.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020121.Bytes);
public long this[int i]=>Value[i];

public static A020121Inst Instance=new A020121Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020122
{
public static readonly long[] Value={ 1L,1L,1L,2L,6L,23L,123L,788L,5853L,49331L,465113L,4850461L,55433830L,688963307L,9251792973L,133490155744L,2059562402903L,33835668047687L,589707357402531L,10867464157846630L,211139303638163097L,4313274345751046121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020122Inst : IEnumerable<long>
{
public static readonly long[] Value=A020122.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020122.Bytes);
public long this[int i]=>Value[i];

public static A020122Inst Instance=new A020122Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020123
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,12L,63L,393L,2863L,23715L,220205L,2264966L,25561752L,314044379L,4172303890L,59604341273L,911094930877L,14837831731420L,256482519928832L,4689966078698629L,90449345803473559L,1834829586299035049L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020123Inst : IEnumerable<long>
{
public static readonly long[] Value=A020123.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020123.Bytes);
public long this[int i]=>Value[i];

public static A020123Inst Instance=new A020123Inst();

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