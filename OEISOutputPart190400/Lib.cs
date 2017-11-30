using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A242017
{
public static readonly long[] Value={ 3L,3L,5L,3L,3L,5L,3L,17L,3L,5L,3L,3L,5L,3L,17L,3L,5L,3L,97L,3L,5L,3L,17L,3L,5L,3L,641L,3L,5L,3L,17L,3L,5L,3L,257L,3L,5L,3L,17L,3L,5L,3L,193L,3L,5L,3L,17L,3L,5L,3L,257L,3L,5L,3L,17L,3L,5L,3L,274177L,3L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242017Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242017.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242017Inst : IEnumerable<long>
{
public static readonly long[] Value=A242017.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242017.Bytes);
public long this[int i]=>Value[i];

public static A242017Inst Instance=new A242017Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242018
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,1L,0L,1L,1L,1L,0L,1L,0L,1L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,0L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242018Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242018.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242018Inst : IEnumerable<long>
{
public static readonly long[] Value=A242018.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242018.Bytes);
public long this[int i]=>Value[i];

public static A242018Inst Instance=new A242018Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242019
{
public static readonly BigInteger[] Value={ 1L,1L,33L,3409L,728575L,265362370L,147228369351L,115651594418010L,122167455441632423L,BigInteger.Parse("167035663137431205196"),BigInteger.Parse("287018982366654934570328"),BigInteger.Parse("605456750773492887086145669"),BigInteger.Parse("1538306721887736189212800143193"),BigInteger.Parse("4633572348321634923252339927247392") };
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
public class A242019Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242019.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242019Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A242019.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242019.Bytes);
public BigInteger this[int i]=>Value[i];

public static A242019Inst Instance=new A242019Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242020
{
public static readonly long[] Value={ 2L,4L,7L,26L,27308L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242020Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242020.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242020Inst : IEnumerable<long>
{
public static readonly long[] Value=A242020.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242020.Bytes);
public long this[int i]=>Value[i];

public static A242020Inst Instance=new A242020Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242021
{
public static readonly long[] Value={ 7L,2L,7L,4L,5L,0L,9L,1L,3L,2L,4L,0L,0L,2L,2L,8L,1L,4L,3L,2L,6L,6L,1L,7L,2L,3L,5L,5L,6L,4L,5L,2L,0L,4L,5L,2L,5L,9L,0L,1L,7L,1L,0L,3L,5L,2L,0L,2L,1L,2L,7L,7L,5L,3L,0L,7L,1L,5L,6L,6L,8L,3L,9L,8L,7L,1L,8L,4L,1L,5L,0L,8L,8L,2L,8L,1L,4L,5L,2L,4L,2L,4L,7L,5L,3L,2L,9L,3L,1L,6L,3L,1L,0L,9L,1L,0L,3L,1L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242021Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242021.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242021Inst : IEnumerable<long>
{
public static readonly long[] Value=A242021.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242021.Bytes);
public long this[int i]=>Value[i];

public static A242021Inst Instance=new A242021Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242022
{
public static readonly long[] Value={ 7L,8L,9L,6L,4L,1L,8L,5L,0L,5L,3L,0L,7L,6L,8L,5L,6L,3L,9L,0L,1L,5L,4L,7L,2L,6L,7L,0L,6L,6L,4L,1L,4L,0L,1L,8L,9L,9L,0L,8L,2L,9L,5L,5L,3L,5L,9L,2L,6L,8L,3L,8L,9L,3L,5L,2L,3L,6L,5L,3L,8L,7L,9L,4L,6L,2L,2L,3L,6L,9L,5L,8L,7L,4L,9L,0L,3L,0L,1L,9L,3L,4L,9L,7L,8L,8L,9L,0L,8L,4L,0L,7L,7L,8L,4L,2L,9L,4L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242022Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242022.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242022Inst : IEnumerable<long>
{
public static readonly long[] Value=A242022.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242022.Bytes);
public long this[int i]=>Value[i];

public static A242022Inst Instance=new A242022Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242023
{
public static readonly long[] Value={ 8L,4L,7L,3L,7L,6L,4L,4L,4L,5L,8L,4L,9L,1L,6L,5L,6L,8L,0L,1L,8L,0L,9L,4L,5L,5L,3L,3L,2L,8L,3L,1L,6L,8L,4L,5L,0L,8L,2L,6L,7L,0L,9L,6L,6L,1L,9L,4L,8L,3L,4L,7L,9L,8L,5L,2L,8L,4L,2L,6L,9L,7L,0L,4L,5L,5L,2L,6L,2L,5L,6L,9L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242023Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242023.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242023Inst : IEnumerable<long>
{
public static readonly long[] Value=A242023.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242023.Bytes);
public long this[int i]=>Value[i];

public static A242023Inst Instance=new A242023Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242024
{
public static readonly long[] Value={ 8L,1L,7L,7L,6L,6L,1L,6L,6L,7L,1L,9L,3L,4L,3L,7L,1L,3L,0L,0L,6L,7L,8L,5L,4L,5L,7L,4L,9L,8L,1L,1L,8L,8L,1L,6L,9L,0L,6L,0L,0L,1L,6L,1L,2L,3L,2L,3L,0L,6L,3L,0L,4L,9L,4L,4L,8L,1L,6L,0L,1L,1L,3L,9L,2L,0L,7L,2L,3L,4L,6L,3L,6L,3L,6L,3L,3L,6L,5L,8L,7L,2L,7L,0L,3L,5L,9L,9L,2L,3L,9L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242024Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242024.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242024Inst : IEnumerable<long>
{
public static readonly long[] Value=A242024.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242024.Bytes);
public long this[int i]=>Value[i];

public static A242024Inst Instance=new A242024Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242025
{
public static readonly BigInteger[] Value={ 5L,17L,29L,41L,2729L,8737L,65537L,74897L,174761L,715827881L,153722867280912929L,BigInteger.Parse("302379100949042568368129") };
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
public class A242025Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242025.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242025Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A242025.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242025.Bytes);
public BigInteger this[int i]=>Value[i];

public static A242025Inst Instance=new A242025Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242026
{
public static readonly long[] Value={ 0L,12L,48L,240L,960L,4032L,16128L,65280L,261120L,1047552L,4190208L,16773120L,67092480L,268419072L,1073676288L,4294901760L,17179607040L,68719214592L,274876858368L,1099510579200L,4398042316800L,17592181850112L,70368727400448L,281474959933440L,1125899839733760L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242026Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242026.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242026Inst : IEnumerable<long>
{
public static readonly long[] Value=A242026.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242026.Bytes);
public long this[int i]=>Value[i];

public static A242026Inst Instance=new A242026Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242027
{
public static readonly long[] Value={ 1L,0L,1L,0L,4L,0L,24L,3L,0L,206L,50L,0L,2300L,825L,0L,31742L,14794L,120L,0L,522466L,294987L,6090L,0L,9996478L,6547946L,232792L,0L,218088504L,160994565L,8337420L,0L,5344652492L,4355845868L,299350440L,151200L,0L,145386399554L,128831993037L,11074483860L,18794160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242027Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242027.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242027Inst : IEnumerable<long>
{
public static readonly long[] Value=A242027.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242027.Bytes);
public long this[int i]=>Value[i];

public static A242027Inst Instance=new A242027Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242028
{
public static readonly long[] Value={ 3L,4L,6L,9L,36L,54L,96L,216L,576L,1296L,69984L,236196L,393216L,497664L,28697814L,31850496L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242028Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242028.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242028Inst : IEnumerable<long>
{
public static readonly long[] Value=A242028.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242028.Bytes);
public long this[int i]=>Value[i];

public static A242028Inst Instance=new A242028Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242029
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,0L,3L,2L,1L,2L,3L,1L,4L,2L,1L,2L,5L,2L,3L,2L,1L,4L,5L,1L,4L,2L,3L,4L,3L,0L,5L,6L,3L,2L,3L,0L,5L,6L,3L,3L,4L,2L,5L,2L,3L,4L,5L,2L,5L,4L,1L,6L,7L,0L,3L,2L,3L,6L,7L,3L,4L,4L,3L,2L,3L,2L,9L,6L,1L,2L,5L,4L,7L,4L,1L,4L,7L,2L,3L,4L,3L,6L,7L,1L,6L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242029Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242029.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242029Inst : IEnumerable<long>
{
public static readonly long[] Value=A242029.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242029.Bytes);
public long this[int i]=>Value[i];

public static A242029Inst Instance=new A242029Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242030
{
public static readonly long[] Value={ 3L,8L,4L,3L,8L,5L,14L,8L,6L,4L,3L,8L,7L,20L,11L,32L,17L,50L,26L,14L,8L,8L,5L,14L,8L,9L,26L,14L,8L,10L,6L,4L,3L,8L,11L,32L,17L,50L,26L,14L,8L,12L,7L,20L,11L,32L,17L,50L,26L,14L,8L,13L,38L,20L,11L,32L,17L,50L,26L,14L,8L,14L,8L,15L,44L,23L,68L,35L,104L,53L,158L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242030Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242030.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242030Inst : IEnumerable<long>
{
public static readonly long[] Value=A242030.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242030.Bytes);
public long this[int i]=>Value[i];

public static A242030Inst Instance=new A242030Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242031
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,51L,52L,53L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242031Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242031.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242031Inst : IEnumerable<long>
{
public static readonly long[] Value=A242031.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242031.Bytes);
public long this[int i]=>Value[i];

public static A242031Inst Instance=new A242031Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242096
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,0L,2L,0L,2L,0L,3L,0L,3L,0L,4L,0L,4L,0L,4L,0L,4L,0L,5L,0L,5L,0L,6L,0L,6L,0L,6L,0L,6L,0L,7L,0L,7L,0L,8L,0L,8L,0L,8L,0L,8L,0L,9L,0L,9L,0L,9L,0L,9L,0L,9L,0L,9L,0L,10L,0L,10L,0L,11L,0L,11L,0L,11L,0L,11L,0L,11L,0L,11L,0L,12L,0L,12L,0L,12L,0L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242096Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242096.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242096Inst : IEnumerable<long>
{
public static readonly long[] Value=A242096.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242096.Bytes);
public long this[int i]=>Value[i];

public static A242096Inst Instance=new A242096Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242097
{
public static readonly long[] Value={ 4L,9L,94L,46L,121L,961L,982L,4L,526L,9L,169L,6511L,5221L,9481L,1042L,6313L,4633L,1843L,1273L,94L,1405L,9235L,46L,9886L,6937L,4069L,10201L,61801L,94411L,18811L,121L,44521L,96721L,52231L,65431L,42931L,67351L,52651L,92161L,48361L,961L,16171L,98671L,65971L,96781L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242097Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242097.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242097Inst : IEnumerable<long>
{
public static readonly long[] Value=A242097.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242097.Bytes);
public long this[int i]=>Value[i];

public static A242097Inst Instance=new A242097Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242098
{
public static readonly long[] Value={ 11L,14L,18L,19L,22L,23L,27L,28L,32L,33L,38L,39L,41L,44L,45L,47L,51L,52L,54L,58L,59L,61L,66L,67L,69L,71L,74L,75L,77L,79L,83L,84L,86L,88L,92L,93L,95L,97L,102L,103L,105L,107L,112L,113L,115L,117L,123L,124L,126L,128L,134L,135L,137L,139L,146L,147L,149L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242098Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242098.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242098Inst : IEnumerable<long>
{
public static readonly long[] Value=A242098.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242098.Bytes);
public long this[int i]=>Value[i];

public static A242098Inst Instance=new A242098Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242099
{
public static readonly BigInteger[] Value={ 1L,2L,3L,8L,18L,84L,387L,2670L,20373L,182796L,1816325L,19973962L,239523846L,3113717784L,43589470208L,653840410004L,10461400104968L,177843770847822L,3201186945761289L,60822551319191028L,1216451005946790780L,BigInteger.Parse("25545471110008012860"),BigInteger.Parse("562000363929678643211") };
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
public class A242099Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242099.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242099Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A242099.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242099.Bytes);
public BigInteger this[int i]=>Value[i];

public static A242099Inst Instance=new A242099Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242100
{
public static readonly long[] Value={ 6L,10L,12L,18L,20L,24L,30L,34L,36L,40L,42L,48L,56L,66L,68L,72L,80L,84L,90L,96L,108L,110L,130L,132L,136L,144L,150L,156L,160L,182L,192L,210L,222L,240L,246L,252L,258L,260L,264L,270L,272L,288L,306L,320L,324L,342L,350L,380L,384L,392L,420L,462L,506L,514L,516L,520L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242100Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242100.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242100Inst : IEnumerable<long>
{
public static readonly long[] Value=A242100.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242100.Bytes);
public long this[int i]=>Value[i];

public static A242100Inst Instance=new A242100Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242101
{
public static readonly long[] Value={ 1L,2L,4L,6L,8L,12L,16L,24L,32L,44L,58L,80L,104L,138L,180L,236L,302L,390L,496L,634L,800L,1010L,1264L,1586L,1970L,2448L,3024L,3734L,4582L,5622L,6862L,8372L,10168L,12336L,14912L,18010L,21672L,26052L,31226L,37384L,44632L,53226L,63318L,75238L,89202L,105630L,124832L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242101Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242101.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242101Inst : IEnumerable<long>
{
public static readonly long[] Value=A242101.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242101.Bytes);
public long this[int i]=>Value[i];

public static A242101Inst Instance=new A242101Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242102
{
public static readonly long[] Value={ 1713L,2319L,2923L,4341L,6159L,7167L,8983L,103101L,151149L,157151L,163157L,167163L,173167L,191181L,197193L,233229L,257251L,277271L,283281L,311307L,337331L,367359L,373367L,421419L,431421L,439433L,449443L,463461L,467463L,479467L,487479L,509503L,521509L,547541L,557547L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242102Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242102.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242102Inst : IEnumerable<long>
{
public static readonly long[] Value=A242102.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242102.Bytes);
public long this[int i]=>Value[i];

public static A242102Inst Instance=new A242102Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242103
{
public static readonly long[] Value={ 7L,9L,11L,14L,29L,76L,121L,199L,329L,521L,659L,1364L,3571L,4523L,7307L,9349L,24476L,64079L,167761L,212533L,439204L,1149851L,3010349L,7881196L,20633239L,54018521L,141422324L,370248451L,969323029L,2537720636L,6643838879L,17393796001L,45537549124L,119218851371L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242103Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242103.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242103Inst : IEnumerable<long>
{
public static readonly long[] Value=A242103.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242103.Bytes);
public long this[int i]=>Value[i];

public static A242103Inst Instance=new A242103Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242104
{
public static readonly long[] Value={ 3L,5L,17L,11L,3L,5L,17L,7L,17L,47L,2L,7L,37L,17L,67L,29L,13L,11L,3L,7L,19L,89L,97L,19L,23L,43L,5L,5L,5L,23L,2L,5L,3L,5L,13L,11L,23L,7L,11L,13L,2L,7L,13L,13L,2L,2L,5L,5L,5L,19L,23L,53L,43L,47L,3L,3L,17L,19L,5L,23L,3L,7L,29L,3L,7L,5L,2L,7L,3L,19L,5L,5L,23L,23L,3L,13L,19L,13L,3L,2L,89L,7L,3L,7L,2L,17L,7L,131L,2L,5L,13L,17L,13L,13L,17L,2L,5L,19L,7L,5L,3L,5L,43L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242104Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242104.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242104Inst : IEnumerable<long>
{
public static readonly long[] Value=A242104.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242104.Bytes);
public long this[int i]=>Value[i];

public static A242104Inst Instance=new A242104Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242105
{
public static readonly BigInteger[] Value={ 1L,2L,7L,44L,428L,5802L,102322L,2239844L,58849332L,1810039960L,63930543419L,2553881719348L,113979459829296L,5625823639358928L,304505544257483550L,17944306197698666740UL,BigInteger.Parse("1144180970802458374244"),BigInteger.Parse("78517953136289477587608"),BigInteger.Parse("5771772521253777092098050") };
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
public class A242105Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242105.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242105Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A242105.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242105.Bytes);
public BigInteger this[int i]=>Value[i];

public static A242105Inst Instance=new A242105Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242106
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,4L,3L,1L,0L,1L,17L,121L,269L,241L,100L,24L,3L,1L,0L,1L,172L,15239L,316622L,1951089L,4820228L,5769214L,3768929L,1451594L,347251L,53628L,5645L,451L,37L,3L,1L,0L,1L,2811L,10802952L,3316523460L,170309112972L,2577666563670L,15839885888526L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242106Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242106.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242106Inst : IEnumerable<long>
{
public static readonly long[] Value=A242106.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242106.Bytes);
public long this[int i]=>Value[i];

public static A242106Inst Instance=new A242106Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242107
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,-1L,2L,-3L,1L,-5L,-7L,-13L,-16L,11L,-57L,131L,-113L,389L,670L,2311L,3983L,9L,23647L,-81511L,140576L,-484247L,-833503L,-5751815L,-14871471L,-17124617L,-147165662L,710017141L,-2273917871L,9644648819L,11396432249L,204006839259L,808162720720L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242107Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242107.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242107Inst : IEnumerable<long>
{
public static readonly long[] Value=A242107.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242107.Bytes);
public long this[int i]=>Value[i];

public static A242107Inst Instance=new A242107Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242108
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,1L,2L,3L,1L,5L,7L,13L,16L,11L,57L,131L,113L,389L,670L,2311L,3983L,9L,23647L,81511L,140576L,484247L,833503L,5751815L,14871471L,17124617L,147165662L,710017141L,2273917871L,9644648819L,11396432249L,204006839259L,808162720720L,2405317965859L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242108Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242108.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242108Inst : IEnumerable<long>
{
public static readonly long[] Value=A242108.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242108.Bytes);
public long this[int i]=>Value[i];

public static A242108Inst Instance=new A242108Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242109
{
public static readonly long[] Value={ 2L,2917L,13457L,15377L,15877L,21317L,78401L,147457L,190097L,215297L,217157L,287297L,401957L,414737L,577601L,1299601L,1308737L,1313317L,1378277L,1547537L,1623077L,1664101L,1731857L,1742401L,1822501L,1887877L,1976837L,2044901L,2390117L,2421137L,2446097L,2483777L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242109Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242109.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242109Inst : IEnumerable<long>
{
public static readonly long[] Value=A242109.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242109.Bytes);
public long this[int i]=>Value[i];

public static A242109Inst Instance=new A242109Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242110
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,6L,8L,11L,13L,21L,23L,33L,39L,54L,63L,88L,98L,132L,157L,200L,237L,303L,356L,440L,526L,643L,767L,931L,1103L,1317L,1581L,1860L,2215L,2615L,3100L,3631L,4302L,4999L,5907L,6865L,8059L,9322L,10950L,12613L,14744L,16988L,19756L,22694L,26344L,30192L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242110Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242110.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242110Inst : IEnumerable<long>
{
public static readonly long[] Value=A242110.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242110.Bytes);
public long this[int i]=>Value[i];

public static A242110Inst Instance=new A242110Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242111
{
public static readonly long[] Value={ 1L,1L,3L,1L,4L,2L,2L,2L,5L,1L,5L,2L,2L,2L,7L,1L,4L,2L,2L,3L,4L,1L,6L,2L,2L,3L,4L,1L,4L,2L,3L,2L,8L,1L,4L,2L,3L,2L,4L,1L,5L,4L,2L,2L,7L,1L,4L,3L,2L,3L,5L,1L,8L,2L,2L,2L,4L,1L,11L,3L,2L,3L,4L,2L,4L,2L,2L,2L,5L,2L,6L,3L,2L,2L,7L,1L,7L,2L,2L,2L,7L,1L,5L,2L,2L,3L,6L,1L,4L,2L,2L,3L,7L,1L,5L,4L,3L,2L,4L,1L,4L,2L,3L,3L,5L,1L,4L,3L,3L,3L,4L,1L,8L,4L,2L,2L,4L,1L,6L,2L,3L,2L,5L,1L,6L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242111Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242111.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242111Inst : IEnumerable<long>
{
public static readonly long[] Value=A242111.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242111.Bytes);
public long this[int i]=>Value[i];

public static A242111Inst Instance=new A242111Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242240
{
public static readonly BigInteger[] Value={ 0L,1L,0L,0L,0L,12L,0L,0L,0L,3024L,0L,0L,0L,4390848L,0L,0L,0L,21224560896L,0L,0L,0L,257991277243392L,0L,0L,0L,6628234834692624384L,0L,0L,0L,BigInteger.Parse("319729080846260095008768"),0L,0L,0L,BigInteger.Parse("26571747463798134334265819136"),0L,0L,0L,BigInteger.Parse("3564202847752289659513902717468672"),0L,0L,0L };
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
public class A242240Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242240.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242240Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A242240.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242240.Bytes);
public BigInteger this[int i]=>Value[i];

public static A242240Inst Instance=new A242240Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242241
{
public static readonly long[] Value={ 1L,5L,7L,41L,11L,13L,266681L,17L,19L,178939L,23L,18500393L,40799043101L,29L,31L,619L,601L,8821L,86364397717734821L,421950627598601L,2621L,295831L,47L,2237L,157L,53L,307L,7741L,6823L,61L,205883L,487L,67L,21767149L,71L,73L,149L,2004383L,79L,34033L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242241Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242241.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242241Inst : IEnumerable<long>
{
public static readonly long[] Value=A242241.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242241.Bytes);
public long this[int i]=>Value[i];

public static A242241Inst Instance=new A242241Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242242
{
public static readonly long[] Value={ 1L,0L,2L,5L,2L,2L,3L,2L,5L,2L,3L,2L,6L,3L,5L,2L,2L,2L,2L,7L,5L,3L,2L,3L,5L,2L,5L,2L,6L,3L,3L,2L,3L,2L,2L,6L,5L,2L,5L,2L,2L,2L,19L,5L,2L,3L,2L,3L,2L,6L,3L,7L,7L,6L,3L,5L,2L,6L,5L,3L,3L,2L,5L,17L,10L,2L,3L,10L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242242Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242242.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242242Inst : IEnumerable<long>
{
public static readonly long[] Value=A242242.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242242.Bytes);
public long this[int i]=>Value[i];

public static A242242Inst Instance=new A242242Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242243
{
public static readonly long[] Value={ 15L,33L,187L,309L,559L,1411L,1897L,2263L,2869L,3543L,6979L,10717L,11559L,11995L,22353L,32953L,39009L,54529L,57363L,58333L,66313L,77011L,80383L,113917L,120759L,124969L,147079L,158011L,167701L,175983L,177673L,237661L,241581L,253519L,299767L,310813L,376387L,381309L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242243Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242243.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242243Inst : IEnumerable<long>
{
public static readonly long[] Value=A242243.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242243.Bytes);
public long this[int i]=>Value[i];

public static A242243Inst Instance=new A242243Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242244
{
public static readonly long[] Value={ 11L,17L,53L,73L,79L,83L,97L,251L,269L,281L,379L,389L,433L,461L,601L,631L,691L,739L,827L,929L,947L,983L,1033L,1087L,1187L,1303L,1423L,1483L,1531L,1637L,1709L,1847L,1879L,2447L,2473L,2683L,2833L,2843L,3301L,3463L,3557L,3719L,3727L,3779L,3833L,3907L,3931L,4157L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242244Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242244.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242244Inst : IEnumerable<long>
{
public static readonly long[] Value=A242244.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242244.Bytes);
public long this[int i]=>Value[i];

public static A242244Inst Instance=new A242244Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242245
{
public static readonly long[] Value={ 1L,3L,8L,15L,15L,30L,71L,105L,24L,51L,117L,180L,206L,315L,744L,945L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242245Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242245.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242245Inst : IEnumerable<long>
{
public static readonly long[] Value=A242245.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242245.Bytes);
public long this[int i]=>Value[i];

public static A242245Inst Instance=new A242245Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242246
{
public static readonly long[] Value={ 0L,1L,1L,1L,0L,-1L,0L,1L,0L,-3L,0L,5L,0L,-691L,0L,35L,0L,-3617L,0L,43867L,0L,-1222277L,0L,854513L,0L,-1181820455L,0L,76977927L,0L,-23749461029L,0L,8615641276005L,0L,-84802531453387L,0L,90219075042845L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242246Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242246.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242246Inst : IEnumerable<long>
{
public static readonly long[] Value=A242246.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242246.Bytes);
public long this[int i]=>Value[i];

public static A242246Inst Instance=new A242246Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242247
{
public static readonly long[] Value={ 2L,4L,8L,10L,14L,22L,22L,28L,32L,38L,46L,49L,49L,58L,58L,68L,74L,74L,82L,82L,87L,94L,94L,98L,112L,116L,121L,128L,136L,146L,146L,146L,155L,155L,164L,166L,184L,184L,184L,200L,206L,206L,221L,221L,224L,238L,244L,265L,265L,268L,268L,268L,286L,286L,286L,286L,344L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242247Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242247.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242247Inst : IEnumerable<long>
{
public static readonly long[] Value=A242247.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242247.Bytes);
public long this[int i]=>Value[i];

public static A242247Inst Instance=new A242247Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242248
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,1L,3L,1L,1L,2L,1L,2L,2L,1L,6L,2L,10L,3L,2L,3L,5L,2L,10L,12L,3L,6L,7L,15L,3L,9L,3L,8L,18L,5L,18L,3L,7L,7L,24L,20L,26L,4L,13L,10L,15L,5L,4L,3L,35L,5L,19L,19L,3L,19L,36L,37L,38L,5L,10L,15L,16L,34L,7L,16L,6L,36L,4L,4L,44L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242248Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242248.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242248Inst : IEnumerable<long>
{
public static readonly long[] Value=A242248.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242248.Bytes);
public long this[int i]=>Value[i];

public static A242248Inst Instance=new A242248Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242249
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,0L,0L,1L,1L,0L,0L,1L,2L,2L,0L,0L,1L,3L,7L,4L,0L,0L,1L,4L,15L,26L,9L,0L,0L,1L,5L,26L,82L,107L,20L,0L,0L,1L,6L,40L,188L,495L,458L,48L,0L,0L,1L,7L,57L,360L,1499L,3144L,2058L,115L,0L,0L,1L,8L,77L,614L,3570L,12628L,20875L,9498L,286L,0L,0L,1L,9L,100L,966L,7284L,37476L,111064L,142773L,44947L,719L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242249Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242249.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242249Inst : IEnumerable<long>
{
public static readonly long[] Value=A242249.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242249.Bytes);
public long this[int i]=>Value[i];

public static A242249Inst Instance=new A242249Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242250
{
public static readonly long[] Value={ 1L,0L,3L,5L,8L,11L,5L,13L,21L,10L,12L,22L,24L,34L,13L,31L,18L,6L,41L,11L,14L,53L,8L,6L,26L,3L,12L,5L,47L,10L,45L,10L,5L,32L,12L,6L,24L,3L,15L,3L,6L,41L,19L,10L,8L,30L,3L,67L,5L,35L,20L,13L,99L,19L,7L,7L,3L,118L,5L,15L,22L,3L,73L,59L,91L,8L,137L,46L,20L,55L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242250Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242250.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242250Inst : IEnumerable<long>
{
public static readonly long[] Value=A242250.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242250.Bytes);
public long this[int i]=>Value[i];

public static A242250Inst Instance=new A242250Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242251
{
public static readonly long[] Value={ 1L,4L,6L,16L,25L,18L,28L,40L,45L,30L,11L,72L,13L,84L,105L,64L,119L,126L,57L,140L,273L,220L,23L,240L,225L,52L,405L,196L,174L,390L,93L,160L,363L,476L,455L,288L,37L,152L,429L,520L,656L,714L,172L,308L,585L,184L,517L,624L,735L,600L,612L,208L,848L,756L,605L,1288L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242251Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242251.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242251Inst : IEnumerable<long>
{
public static readonly long[] Value=A242251.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242251.Bytes);
public long this[int i]=>Value[i];

public static A242251Inst Instance=new A242251Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242252
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,0L,1L,1L,1L,1L,0L,0L,0L,1L,1L,1L,1L,1L,0L,0L,0L,1L,0L,1L,1L,1L,0L,1L,1L,0L,0L,1L,1L,1L,0L,1L,1L,0L,0L,1L,1L,0L,1L,1L,1L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,0L,0L,0L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242252Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242252.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242252Inst : IEnumerable<long>
{
public static readonly long[] Value=A242252.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242252.Bytes);
public long this[int i]=>Value[i];

public static A242252Inst Instance=new A242252Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242253
{
public static readonly long[] Value={ 1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,2L,2L,2L,2L,2L,2L,2L,3L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,2L,2L,2L,2L,2L,2L,2L,3L,2L,2L,2L,2L,2L,2L,3L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,2L,3L,2L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242253Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242253.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242253Inst : IEnumerable<long>
{
public static readonly long[] Value=A242253.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242253.Bytes);
public long this[int i]=>Value[i];

public static A242253Inst Instance=new A242253Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242254
{
public static readonly long[] Value={ 3L,4L,6L,8L,11L,14L,18L,21L,27L,29L,34L,35L,36L,42L,43L,44L,46L,50L,53L,54L,58L,61L,62L,65L,69L,70L,81L,82L,83L,84L,90L,99L,102L,105L,107L,110L,114L,116L,117L,121L,126L,128L,139L,141L,142L,143L,145L,146L,149L,153L,158L,172L,173L,174L,176L,177L,178L,179L,183L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242254Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242254.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242254Inst : IEnumerable<long>
{
public static readonly long[] Value=A242254.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242254.Bytes);
public long this[int i]=>Value[i];

public static A242254Inst Instance=new A242254Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242255
{
public static readonly long[] Value={ 5L,7L,13L,19L,31L,43L,61L,73L,103L,109L,139L,149L,151L,181L,191L,193L,199L,229L,241L,251L,271L,283L,293L,313L,347L,349L,419L,421L,431L,433L,463L,523L,557L,571L,587L,601L,619L,641L,643L,661L,701L,719L,797L,811L,821L,823L,829L,839L,859L,883L,929L,1021L,1031L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242255Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242255.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242255Inst : IEnumerable<long>
{
public static readonly long[] Value=A242255.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242255.Bytes);
public long this[int i]=>Value[i];

public static A242255Inst Instance=new A242255Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242400
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,9L,0L,9L,9L,0L,0L,0L,0L,0L,9L,27L,36L,36L,0L,0L,0L,27L,27L,36L,27L,36L,36L,0L,0L,0L,0L,0L,9L,0L,9L,9L,0L,0L,0L,0L,0L,9L,27L,36L,36L,81L,81L,81L,108L,108L,117L,108L,117L,117L,0L,0L,0L,0L,0L,9L,0L,9L,9L,81L,81L,81L,81L,81L,90L,108L,117L,117L,81L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242400Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242400.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242400Inst : IEnumerable<long>
{
public static readonly long[] Value=A242400.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242400.Bytes);
public long this[int i]=>Value[i];

public static A242400Inst Instance=new A242400Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242401
{
public static readonly long[] Value={ 2L,5L,7L,8L,11L,12L,13L,14L,17L,18L,19L,20L,22L,23L,24L,26L,27L,29L,30L,31L,32L,33L,34L,35L,37L,38L,39L,40L,41L,42L,43L,44L,46L,47L,48L,50L,51L,52L,53L,54L,56L,57L,58L,59L,60L,61L,62L,63L,65L,67L,68L,69L,70L,71L,72L,73L,74L,75L,76L,77L,79L,80L,82L,83L,84L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242401Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242401.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242401Inst : IEnumerable<long>
{
public static readonly long[] Value=A242401.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242401.Bytes);
public long this[int i]=>Value[i];

public static A242401Inst Instance=new A242401Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242402
{
public static readonly long[] Value={ 3L,1L,9L,6L,2L,2L,0L,6L,1L,6L,5L,8L,2L,5L,4L,1L,0L,9L,3L,9L,8L,0L,5L,2L,7L,4L,0L,3L,4L,0L,3L,7L,2L,0L,3L,4L,1L,5L,9L,9L,0L,8L,1L,1L,1L,1L,6L,2L,0L,2L,2L,2L,0L,4L,6L,8L,4L,2L,2L,7L,0L,3L,6L,4L,2L,3L,2L,3L,3L,3L,1L,1L,7L,2L,9L,7L,6L,1L,5L,2L,4L,5L,1L,1L,2L,6L,2L,7L,0L,0L,2L,1L,7L,5L,2L,2L,0L,9L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242402Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242402.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242402Inst : IEnumerable<long>
{
public static readonly long[] Value=A242402.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242402.Bytes);
public long this[int i]=>Value[i];

public static A242402Inst Instance=new A242402Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242403
{
public static readonly long[] Value={ 2L,5L,2L,6L,6L,0L,2L,5L,9L,0L,0L,8L,8L,8L,2L,9L,2L,2L,1L,5L,5L,0L,6L,2L,7L,1L,4L,3L,2L,7L,8L,9L,4L,1L,4L,1L,8L,2L,5L,2L,1L,9L,3L,3L,9L,6L,2L,9L,7L,8L,4L,6L,1L,3L,0L,1L,6L,8L,6L,2L,1L,7L,2L,2L,9L,2L,2L,8L,0L,5L,4L,8L,4L,4L,7L,6L,6L,3L,2L,5L,6L,6L,9L,5L,9L,1L,4L,2L,4L,4L,7L,9L,3L,8L,6L,8L,8L,9L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242403Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242403.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242403Inst : IEnumerable<long>
{
public static readonly long[] Value=A242403.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242403.Bytes);
public long this[int i]=>Value[i];

public static A242403Inst Instance=new A242403Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242404
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,5L,1L,1L,1L,12L,1L,5L,1L,23L,12L,1L,1L,5L,1L,12L,37L,57L,1L,5L,1L,80L,1L,23L,1L,26L,1L,1L,167L,138L,23L,5L,1L,173L,288L,12L,1L,62L,1L,57L,12L,255L,1L,5L,1L,12L,682L,80L,1L,5L,464L,23L,971L,408L,1L,26L,1L,467L,37L,1L,1289L,226L,1L,138L,1773L,55L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242404Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242404.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242404Inst : IEnumerable<long>
{
public static readonly long[] Value=A242404.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242404.Bytes);
public long this[int i]=>Value[i];

public static A242404Inst Instance=new A242404Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242405
{
public static readonly long[] Value={ 1L,-6L,15L,-24L,39L,-72L,123L,-192L,294L,-456L,693L,-1008L,1452L,-2100L,2991L,-4176L,5781L,-7992L,10950L,-14808L,19908L,-26688L,35541L,-46944L,61692L,-80826L,105366L,-136536L,176208L,-226728L,290565L,-370704L,471318L,-597600L,755217L,-950976L,1193988L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242405Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242405.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242405Inst : IEnumerable<long>
{
public static readonly long[] Value=A242405.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242405.Bytes);
public long this[int i]=>Value[i];

public static A242405Inst Instance=new A242405Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242406
{
public static readonly long[] Value={ 2L,3L,2L,1L,2L,8L,5L,0L,3L,8L,0L,3L,2L,4L,3L,1L,6L,5L,7L,1L,9L,2L,4L,9L,3L,5L,5L,4L,7L,6L,6L,6L,7L,8L,2L,7L,1L,4L,1L,8L,1L,3L,9L,1L,0L,3L,9L,3L,6L,7L,1L,7L,3L,4L,8L,5L,7L,1L,7L,8L,5L,2L,1L,9L,0L,4L,8L,9L,1L,4L,6L,4L,9L,7L,8L,1L,7L,8L,7L,7L,6L,9L,1L,5L,9L,8L,7L,8L,1L,4L,9L,5L,5L,3L,6L,6L,9L,2L,4L,7L,9L,6L,0L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242406Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242406.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242406Inst : IEnumerable<long>
{
public static readonly long[] Value=A242406.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242406.Bytes);
public long this[int i]=>Value[i];

public static A242406Inst Instance=new A242406Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242407
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,6L,9L,10L,11L,12L,13L,18L,19L,20L,27L,28L,29L,30L,31L,33L,36L,37L,38L,39L,40L,54L,55L,56L,57L,58L,60L,81L,82L,83L,84L,85L,87L,90L,91L,92L,93L,94L,99L,100L,101L,108L,109L,110L,111L,112L,114L,117L,118L,119L,120L,121L,162L,163L,164L,165L,166L,168L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242407Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242407.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242407Inst : IEnumerable<long>
{
public static readonly long[] Value=A242407.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242407.Bytes);
public long this[int i]=>Value[i];

public static A242407Inst Instance=new A242407Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242408
{
public static readonly long[] Value={ 5L,7L,8L,14L,15L,16L,17L,21L,22L,23L,24L,25L,26L,32L,34L,35L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,59L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L,72L,73L,74L,75L,76L,77L,78L,79L,80L,86L,88L,89L,95L,96L,97L,98L,102L,103L,104L,105L,106L,107L,113L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242408Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242408.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242408Inst : IEnumerable<long>
{
public static readonly long[] Value=A242408.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242408.Bytes);
public long this[int i]=>Value[i];

public static A242408Inst Instance=new A242408Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242409
{
public static readonly long[] Value={ 1L,1L,1L,3L,2L,3L,3L,4L,4L,8L,5L,3L,6L,6L,6L,13L,9L,7L,13L,13L,7L,13L,9L,8L,19L,13L,11L,22L,17L,22L,27L,19L,20L,33L,26L,14L,24L,19L,16L,38L,26L,17L,42L,35L,36L,60L,34L,38L,56L,56L,55L,56L,60L,42L,67L,46L,31L,57L,52L,62L,52L,65L,48L,86L,99L,50L,95L,78L,77L,128L,104L,90L,142L,127L,114L,161L,110L,113L,184L,155L,122L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242409Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242409.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242409Inst : IEnumerable<long>
{
public static readonly long[] Value=A242409.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242409.Bytes);
public long this[int i]=>Value[i];

public static A242409Inst Instance=new A242409Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242410
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,29L,31L,33L,34L,37L,38L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,57L,58L,59L,60L,61L,62L,63L,64L,67L,68L,71L,73L,77L,79L,81L,82L,83L,84L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242410Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242410.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242410Inst : IEnumerable<long>
{
public static readonly long[] Value=A242410.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242410.Bytes);
public long this[int i]=>Value[i];

public static A242410Inst Instance=new A242410Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242411
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,0L,0L,0L,2L,0L,1L,0L,3L,1L,0L,0L,1L,0L,2L,2L,4L,0L,1L,0L,5L,0L,3L,0L,1L,0L,0L,3L,6L,1L,1L,0L,7L,4L,2L,0L,2L,0L,4L,1L,8L,0L,1L,0L,2L,5L,5L,0L,1L,2L,3L,6L,9L,0L,1L,0L,10L,2L,0L,3L,3L,0L,6L,7L,1L,0L,1L,0L,11L,1L,7L,1L,4L,0L,2L,0L,12L,0L,2L,4L,13L,8L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242411Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242411.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242411Inst : IEnumerable<long>
{
public static readonly long[] Value=A242411.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242411.Bytes);
public long this[int i]=>Value[i];

public static A242411Inst Instance=new A242411Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242412
{
public static readonly long[] Value={ 15L,23L,39L,63L,95L,135L,183L,239L,303L,375L,455L,543L,639L,743L,855L,975L,1103L,1239L,1383L,1535L,1695L,1863L,2039L,2223L,2415L,2615L,2823L,3039L,3263L,3495L,3735L,3983L,4239L,4503L,4775L,5055L,5343L,5639L,5943L,6255L,6575L,6903L,7239L,7583L,7935L,8295L,8663L,9039L,9423L,9815L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242412Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242412.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242412Inst : IEnumerable<long>
{
public static readonly long[] Value=A242412.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242412.Bytes);
public long this[int i]=>Value[i];

public static A242412Inst Instance=new A242412Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242413
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,11L,12L,13L,16L,17L,18L,19L,21L,23L,24L,25L,27L,29L,30L,31L,32L,36L,37L,41L,43L,47L,48L,49L,53L,54L,59L,60L,61L,63L,64L,65L,67L,70L,71L,72L,73L,79L,81L,83L,89L,90L,96L,97L,101L,103L,107L,108L,109L,113L,120L,121L,125L,127L,128L,131L,133L,137L,139L,140L,144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242413Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242413.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242413Inst : IEnumerable<long>
{
public static readonly long[] Value=A242413.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242413.Bytes);
public long this[int i]=>Value[i];

public static A242413Inst Instance=new A242413Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242414
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,13L,14L,15L,16L,17L,19L,21L,22L,23L,25L,26L,27L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,41L,42L,43L,46L,47L,49L,51L,53L,55L,57L,58L,59L,61L,62L,64L,65L,66L,67L,69L,70L,71L,73L,74L,77L,78L,79L,81L,82L,83L,85L,86L,87L,89L,90L,91L,93L,94L,95L,97L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242414Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242414.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242414Inst : IEnumerable<long>
{
public static readonly long[] Value=A242414.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242414.Bytes);
public long this[int i]=>Value[i];

public static A242414Inst Instance=new A242414Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242415
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,15L,11L,12L,13L,35L,10L,16L,17L,18L,19L,45L,21L,77L,23L,24L,25L,143L,27L,175L,29L,30L,31L,32L,55L,221L,14L,36L,37L,323L,91L,135L,41L,105L,43L,539L,20L,437L,47L,48L,49L,75L,187L,1573L,53L,54L,33L,875L,247L,667L,59L,60L,61L,899L,63L,64L,65L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242415Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242415.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242415Inst : IEnumerable<long>
{
public static readonly long[] Value=A242415.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242415.Bytes);
public long this[int i]=>Value[i];

public static A242415Inst Instance=new A242415Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242512
{
public static readonly long[] Value={ 1L,1L,2L,9L,32L,85L,240L,588L,1512L,3564L,8700L,19965L,47124L,105963L,244244L,540540L,1224080L,2674984L,5974956L,12924522L,28553200L,61250490L,134104432L,285689624L,620826672L,1314933000L,2839363800L,5984393805L,12852021420L,26973910215L,57655813500L,120569654700L,256649540640L,535009931280L,1134692142540L,2358818719950L,4986548028000L,10340761857030L,21796919253120L,45102668144040L,94821703158000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242512Inst : IEnumerable<long>
{
public static readonly long[] Value=A242512.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242512.Bytes);
public long this[int i]=>Value[i];

public static A242512Inst Instance=new A242512Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242513
{
public static readonly long[] Value={ 1L,1L,2L,12L,54L,100L,330L,1050L,3024L,8736L,23220L,62700L,158004L,406692L,986986L,2452450L,5788640L,14002560L,32357052L,76640148L,174174520L,405623400L,909582212L,2089064516L,4633556448L,10519464000L,23120533800L,51977741400L,113365499940L,252725219460L,547593359850L,1211884139250L,2610998927040L,5741708459520L,12309472580460L,26917328938500L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242513Inst : IEnumerable<long>
{
public static readonly long[] Value=A242513.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242513.Bytes);
public long this[int i]=>Value[i];

public static A242513Inst Instance=new A242513Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242514
{
public static readonly long[] Value={ 1L,12L,54L,54L,54L,54L,85L,240L,240L,588L,1512L,1512L,3564L,8700L,8700L,19965L,47124L,47124L,105963L,244244L,244244L,540540L,1224080L,1224080L,2674984L,5974956L,5974956L,12924522L,28553200L,28553200L,61250490L,134104432L,134104432L,285689624L,620826672L,620826672L,1314933000L,2839363800L,2839363800L,5984393805L,12852021420L,12852021420L,26973910215L,57655813500L,57655813500L,120569654700L,256649540640L,256649540640L,535009931280L,1134692142540L,1134692142540L,2358818719950L,4986548028000L,4986548028000L,10340761857030L,21796919253120L,21796919253120L,45102668144040L,94821703158000L,94821703158000L,195825873726600L,410720543218440L,410720543218440L,846739738410930L,1772108740270440L,1772108740270440L,3647615648094990L,7618942347630120L,7618942347630120L,15660031688889048L,32650847564232672L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242514Inst : IEnumerable<long>
{
public static readonly long[] Value=A242514.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242514.Bytes);
public long this[int i]=>Value[i];

public static A242514Inst Instance=new A242514Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242515
{
public static readonly long[] Value={ 44L,70L,72L,74L,105L,111L,112L,132L,137L,140L,147L,154L,163L,170L,182L,193L,202L,207L,209L,235L,245L,248L,252L,258L,262L,273L,285L,312L,315L,317L,322L,329L,331L,336L,345L,347L,349L,359L,369L,372L,377L,384L,392L,397L,403L,404L,422L,427L,437L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242515Inst : IEnumerable<long>
{
public static readonly long[] Value=A242515.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242515.Bytes);
public long this[int i]=>Value[i];

public static A242515Inst Instance=new A242515Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242516
{
public static readonly long[] Value={ 1L,2L,3L,8L,12L,24L,40L,60L,144L,240L,360L,720L,1008L,1680L,2520L,5760L,8064L,13440L,20160L,51840L,72576L,120960L,181440L,518400L,725760L,1209600L,1814400L,3628800L,5702400L,7983360L,13305600L,19958400L,43545600L,68428800L,95800320L,159667200L,239500800L,479001600L,566092800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242516Inst : IEnumerable<long>
{
public static readonly long[] Value=A242516.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242516.Bytes);
public long this[int i]=>Value[i];

public static A242516Inst Instance=new A242516Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242517
{
public static readonly long[] Value={ 31L,619L,2791L,4801L,15331L,33829L,40129L,63421L,69151L,98731L,127291L,142789L,143569L,149971L,151849L,176599L,184969L,201829L,210601L,225289L,231841L,243589L,250951L,271279L,273271L,277549L,280591L,392269L,405439L,441799L,472711L,510709L,530599L,568441L,578689L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242517Inst : IEnumerable<long>
{
public static readonly long[] Value=A242517.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242517.Bytes);
public long this[int i]=>Value[i];

public static A242517Inst Instance=new A242517Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242518
{
public static readonly long[] Value={ 201829L,2739721L,6108679L,7883329L,9260131L,9309721L,9917389L,14488249L,15386491L,15876481L,16685299L,16967191L,18145279L,20566969L,20869129L,21150991L,23194909L,25510189L,28406929L,34669909L,35039311L,36795169L,37912141L,39083521L,39805639L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242518Inst : IEnumerable<long>
{
public static readonly long[] Value=A242518.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242518.Bytes);
public long this[int i]=>Value[i];

public static A242518Inst Instance=new A242518Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242519
{
public static readonly long[] Value={ 0L,1L,1L,1L,4L,8L,14L,32L,142L,426L,1204L,3747L,9374L,26306L,77700L,219877L,1169656L,4736264L,17360564L,69631372L,242754286L,891384309L,3412857926L,12836957200L,42721475348L,152125749587L,549831594988L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242519Inst : IEnumerable<long>
{
public static readonly long[] Value=A242519.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242519.Bytes);
public long this[int i]=>Value[i];

public static A242519Inst Instance=new A242519Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242520
{
public static readonly long[] Value={ 1L,1L,2L,3L,27L,165L,676L,3584L,19108L,80754L,386776L,1807342L,8218582L,114618650L,1410831012L,12144300991L,126350575684L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242520Inst : IEnumerable<long>
{
public static readonly long[] Value=A242520.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242520.Bytes);
public long this[int i]=>Value[i];

public static A242520Inst Instance=new A242520Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242521
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,2L,4L,6L,9L,42L,231L,1052L,3818L,10086L,27892L,90076L,310301L,993680L,4663558L,22038882L,162588454L,1246422151L,8655752023L,58951670318L,347675502245L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242521Inst : IEnumerable<long>
{
public static readonly long[] Value=A242521.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242521.Bytes);
public long this[int i]=>Value[i];

public static A242521Inst Instance=new A242521Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242522
{
public static readonly BigInteger[] Value={ 0L,0L,0L,0L,1L,5L,33L,245L,2053L,19137L,196705L,2212037L,27029085L,356723177L,5058388153L,76712450925L,1239124984693L,21241164552785L,385159565775633L,7365975246680597L,148182892455224845L,3128251523599365177L,BigInteger.Parse("69149857480654157545"),BigInteger.Parse("1597343462243140957757") };
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
public class A242522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242522Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A242522.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242522.Bytes);
public BigInteger this[int i]=>Value[i];

public static A242522Inst Instance=new A242522Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242523
{
public static readonly BigInteger[] Value={ 0L,0L,0L,0L,0L,0L,1L,11L,125L,1351L,15330L,184846L,2382084L,32795170L,481379278L,7513591430L,124363961357L,2176990766569L,40199252548280L,781143277669538L,15937382209774353L,340696424417421213L,7616192835573406931L,BigInteger.Parse("177723017354688250713"),BigInteger.Parse("4321711817908214684734") };
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
public class A242523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242523Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A242523.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242523.Bytes);
public BigInteger this[int i]=>Value[i];

public static A242523Inst Instance=new A242523Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242524
{
public static readonly BigInteger[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,1L,24L,504L,8320L,131384L,2070087L,33465414L,561681192L,9842378284L,180447203232L,3462736479324L,69517900171056L,1458720714556848L,31955023452174314L,729874911380470641L,17359562438053760533UL,BigInteger.Parse("429391730229931885360") };
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
public class A242524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242524Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A242524.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242524.Bytes);
public BigInteger this[int i]=>Value[i];

public static A242524Inst Instance=new A242524Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242525
{
public static readonly long[] Value={ 1L,1L,1L,3L,6L,10L,17L,31L,57L,104L,188L,340L,616L,1117L,2025L,3670L,6651L,12054L,21847L,39596L,71764L,130065L,235730L,427238L,774328L,1403395L,2543518L,4609881L,8354965L,15142569L,27444447L,49740415L,90149708L,163387657L,296124381L,536696900L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242525Inst : IEnumerable<long>
{
public static readonly long[] Value=A242525.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242525.Bytes);
public long this[int i]=>Value[i];

public static A242525Inst Instance=new A242525Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242526
{
public static readonly long[] Value={ 1L,1L,1L,3L,12L,36L,90L,214L,521L,1335L,3473L,9016L,23220L,59428L,152052L,389636L,999776L,2566517L,6586825L,16899574L,43352560L,111213798L,285319258L,732016006L,1878072638L,4818362046L,12361809384L,31714901077L,81366445061L,208750870961L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242526Inst : IEnumerable<long>
{
public static readonly long[] Value=A242526.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242526.Bytes);
public long this[int i]=>Value[i];

public static A242526Inst Instance=new A242526Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242527
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,1L,2L,6L,6L,22L,80L,504L,840L,6048L,3888L,37524L,72976L,961776L,661016L,11533030L,7544366L,133552142L,208815294L,5469236592L,6429567323L,153819905698L,182409170334L,4874589558919L,7508950009102L,209534365631599L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242527Inst : IEnumerable<long>
{
public static readonly long[] Value=A242527.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242527.Bytes);
public long this[int i]=>Value[i];

public static A242527Inst Instance=new A242527Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242592
{
public static readonly long[] Value={ 6L,22L,26L,33L,39L,55L,62L,77L,93L,143L,187L,202L,226L,262L,303L,339L,341L,393L,505L,622L,626L,707L,781L,933L,939L,1111L,1177L,1243L,1313L,1441L,1469L,1661L,1717L,1991L,2042L,2062L,2066L,2206L,2402L,2426L,2446L,2462L,2602L,2642L,3063L,3093L,3099L,3131L,3309L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242592Inst : IEnumerable<long>
{
public static readonly long[] Value=A242592.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242592.Bytes);
public long this[int i]=>Value[i];

public static A242592Inst Instance=new A242592Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242593
{
public static readonly long[] Value={ 1L,2L,4L,6L,2L,10L,4L,2L,16L,10L,4L,2L,26L,20L,12L,4L,2L,42L,40L,26L,14L,4L,2L,68L,76L,58L,32L,16L,4L,2L,110L,142L,120L,78L,38L,18L,4L,2L,178L,260L,244L,172L,100L,44L,20L,4L,2L,288L,470L,482L,374L,232L,124L,50L,22L,4L,2L,466L,840L,936L,784L,534L,300L,150L,56L,24L,4L,2L,754L,1488L,1788L,1612L,1176L,726L,376L,178L,62L,26L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242593Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242593.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242593Inst : IEnumerable<long>
{
public static readonly long[] Value=A242593.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242593.Bytes);
public long this[int i]=>Value[i];

public static A242593Inst Instance=new A242593Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242594
{
public static readonly long[] Value={ 1L,6L,11L,16L,21L,26L,31L,36L,41L,46L,99L,104L,109L,114L,119L,124L,129L,134L,139L,144L,197L,202L,207L,212L,217L,222L,227L,232L,237L,242L,295L,300L,305L,310L,315L,320L,325L,330L,335L,393L,398L,403L,408L,413L,418L,423L,428L,433L,491L,496L,501L,506L,511L,516L,521L,526L,531L,584L,589L,594L,599L,604L,609L,614L,619L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242594Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242594.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242594Inst : IEnumerable<long>
{
public static readonly long[] Value=A242594.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242594.Bytes);
public long this[int i]=>Value[i];

public static A242594Inst Instance=new A242594Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242595
{
public static readonly long[] Value={ 1L,1L,2L,0L,4L,2L,3L,0L,6L,4L,10L,0L,12L,3L,4L,0L,8L,6L,18L,0L,6L,10L,11L,0L,20L,12L,18L,0L,28L,4L,5L,0L,10L,8L,12L,0L,36L,18L,12L,0L,20L,6L,14L,0L,12L,11L,23L,0L,21L,20L,8L,0L,52L,18L,20L,0L,18L,28L,58L,0L,60L,5L,6L,0L,12L,10L,66L,0L,22L,12L,35L,0L,9L,36L,20L,0L,30L,12L,39L,0L,54L,20L,82L,0L,8L,14L,28L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242595Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242595.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242595Inst : IEnumerable<long>
{
public static readonly long[] Value=A242595.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242595.Bytes);
public long this[int i]=>Value[i];

public static A242595Inst Instance=new A242595Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242596
{
public static readonly BigInteger[] Value={ 1L,9L,83L,1337L,33497L,5587L,136919L,35054939L,946522553L,946538429L,114531943709L,458129108861L,77423915447309L,38711978428267L,9677996861569L,19820539601545337L,5728136204565261593L,1909378773465525731L,BigInteger.Parse("689285743475945831291"),BigInteger.Parse("344642873149232707087") };
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
public class A242596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242596Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A242596.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242596.Bytes);
public BigInteger this[int i]=>Value[i];

public static A242596Inst Instance=new A242596Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242597
{
public static readonly BigInteger[] Value={ 1L,8L,72L,1152L,28800L,4800L,117600L,30105600L,812851200L,812851200L,98354995200L,393419980800L,66487976755200L,33243988377600L,8310997094400L,17020922049331200L,4919046472256716800L,1639682157418905600L,BigInteger.Parse("591925258828224921600"),BigInteger.Parse("295962629414112460800"),BigInteger.Parse("295962629414112460800") };
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
public class A242597Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242597.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242597Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A242597.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242597.Bytes);
public BigInteger this[int i]=>Value[i];

public static A242597Inst Instance=new A242597Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242598
{
public static readonly long[] Value={ 1L,2L,1L,2L,5L,1L,2L,14L,10L,1L,2L,30L,58L,17L,1L,2L,55L,258L,167L,26L,1L,2L,91L,978L,1247L,386L,37L,1L,2L,140L,3330L,7862L,4306L,772L,50L,1L,2L,204L,10498L,44150L,40146L,11972L,1394L,65L,1L,2L,285L,31234L,227858L,330450L,153722L,28610L,2333L,82L,1L,2L,385L,88834L,1102658L,2480850L,1728722L,482210L,61133L,3682L,101L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242598Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242598.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242598Inst : IEnumerable<long>
{
public static readonly long[] Value=A242598.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242598.Bytes);
public long this[int i]=>Value[i];

public static A242598Inst Instance=new A242598Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242599
{
public static readonly long[] Value={ 4L,2L,6L,4L,0L,8L,8L,0L,6L,1L,6L,2L,0L,9L,6L,1L,8L,2L,0L,9L,2L,0L,3L,6L,9L,9L,5L,4L,2L,6L,8L,7L,7L,3L,1L,5L,6L,7L,1L,1L,7L,3L,6L,1L,0L,4L,3L,3L,4L,2L,0L,5L,0L,4L,2L,7L,8L,9L,2L,2L,0L,6L,3L,0L,5L,8L,2L,0L,7L,6L,4L,2L,5L,9L,4L,3L,1L,8L,5L,3L,6L,5L,4L,8L,3L,9L,7L,0L,1L,3L,1L,6L,1L,5L,1L,5L,0L,8L,7L,0L,6L,5L,8L,5L,8L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242599Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242599.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242599Inst : IEnumerable<long>
{
public static readonly long[] Value=A242599.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242599.Bytes);
public long this[int i]=>Value[i];

public static A242599Inst Instance=new A242599Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242600
{
public static readonly long[] Value={ 5L,4L,2L,1L,9L,1L,2L,1L,6L,4L,5L,0L,6L,9L,3L,3L,7L,8L,3L,4L,0L,5L,0L,1L,5L,3L,1L,0L,4L,2L,6L,4L,3L,6L,9L,5L,6L,7L,9L,3L,7L,6L,7L,8L,5L,4L,5L,8L,0L,6L,9L,9L,3L,9L,6L,8L,6L,5L,7L,2L,6L,7L,7L,4L,0L,3L,1L,0L,5L,3L,1L,5L,3L,7L,7L,7L,9L,9L,4L,4L,3L,0L,4L,0L,9L,2L,4L,2L,8L,6L,7L,0L,4L,7L,0L,9L,2L,8L,4L,5L,9L,3L,7L,3L,0L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242600Inst : IEnumerable<long>
{
public static readonly long[] Value=A242600.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242600.Bytes);
public long this[int i]=>Value[i];

public static A242600Inst Instance=new A242600Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242601
{
public static readonly long[] Value={ 0L,0L,1L,1L,-1L,-1L,2L,2L,-2L,-2L,3L,3L,-3L,-3L,4L,4L,-4L,-4L,5L,5L,-5L,-5L,6L,6L,-6L,-6L,7L,7L,-7L,-7L,8L,8L,-8L,-8L,9L,9L,-9L,-9L,10L,10L,-10L,-10L,11L,11L,-11L,-11L,12L,12L,-12L,-12L,13L,13L,-13L,-13L,14L,14L,-14L,-14L,15L,15L,-15L,-15L,16L,16L,-16L,-16L,17L,17L,-17L,-17L,18L,18L,-18L,-18L,19L,19L,-19L,-19L,20L,20L,-20L,-20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242601Inst : IEnumerable<long>
{
public static readonly long[] Value=A242601.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242601.Bytes);
public long this[int i]=>Value[i];

public static A242601Inst Instance=new A242601Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242602
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,1L,-1L,-1L,-1L,2L,2L,2L,-2L,-2L,-2L,3L,3L,3L,-3L,-3L,-3L,4L,4L,4L,-4L,-4L,-4L,5L,5L,5L,-5L,-5L,-5L,6L,6L,6L,-6L,-6L,-6L,7L,7L,7L,-7L,-7L,-7L,8L,8L,8L,-8L,-8L,-8L,9L,9L,9L,-9L,-9L,-9L,10L,10L,10L,-10L,-10L,-10L,11L,11L,11L,-11L,-11L,-11L,12L,12L,12L,-12L,-12L,-12L,13L,13L,13L,-13L,-13L,-13L,14L,14L,14L,-14L,-14L,-14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242602Inst : IEnumerable<long>
{
public static readonly long[] Value=A242602.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242602.Bytes);
public long this[int i]=>Value[i];

public static A242602Inst Instance=new A242602Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242603
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,1L,8L,9L,10L,11L,12L,13L,2L,15L,16L,17L,18L,19L,20L,3L,22L,23L,24L,25L,26L,27L,4L,29L,30L,31L,32L,33L,34L,5L,36L,37L,38L,39L,40L,41L,6L,43L,44L,45L,46L,47L,48L,1L,50L,51L,52L,53L,54L,55L,8L,57L,58L,59L,60L,61L,62L,9L,64L,65L,66L,67L,68L,69L,10L,71L,72L,73L,74L,75L,76L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242603Inst : IEnumerable<long>
{
public static readonly long[] Value=A242603.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242603.Bytes);
public long this[int i]=>Value[i];

public static A242603Inst Instance=new A242603Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242604
{
public static readonly long[] Value={ 0L,9L,56L,195L,504L,1085L,2064L,3591L,5840L,9009L,13320L,19019L,26376L,35685L,47264L,61455L,78624L,99161L,123480L,152019L,185240L,223629L,267696L,317975L,375024L,439425L,511784L,592731L,682920L,783029L,893760L,1015839L,1150016L,1297065L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242604Inst : IEnumerable<long>
{
public static readonly long[] Value=A242604.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242604.Bytes);
public long this[int i]=>Value[i];

public static A242604Inst Instance=new A242604Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242605
{
public static readonly long[] Value={ 33L,55L,85L,91L,93L,115L,118L,119L,141L,142L,143L,158L,201L,202L,203L,205L,213L,214L,215L,217L,218L,295L,298L,299L,301L,302L,323L,326L,391L,393L,411L,413L,445L,451L,511L,514L,535L,542L,551L,622L,633L,685L,694L,695L,697L,745L,763L,778L,791L,799L,815L,842L,843L,865L,898L,921L,922L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242605Inst : IEnumerable<long>
{
public static readonly long[] Value=A242605.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242605.Bytes);
public long this[int i]=>Value[i];

public static A242605Inst Instance=new A242605Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242606
{
public static readonly long[] Value={ 1309L,1442L,1885L,2013L,2091L,2665L,2694L,2714L,3243L,3422L,3655L,3729L,3854L,3855L,4430L,4431L,4503L,4921L,5034L,5035L,5133L,5282L,5678L,5795L,5882L,5883L,5943L,5954L,6054L,6061L,6094L,6213L,6302L,6303L,6305L,6306L,6477L,6851L,6853L,6873L,6985L,7202L,7257L,7334L,7383L,7682L,7730L,7802L,7842L,7922L,7953L,8238L,8239L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242606Inst : IEnumerable<long>
{
public static readonly long[] Value=A242606.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242606.Bytes);
public long this[int i]=>Value[i];

public static A242606Inst Instance=new A242606Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242607
{
public static readonly long[] Value={ 27962L,37145L,39234L,42182L,50138L,51986L,58562L,62643L,64074L,83082L,84774L,89089L,95642L,120783L,123486L,133903L,134826L,146165L,149606L,153543L,159182L,166495L,170751L,176754L,177122L,178086L,178087L,179330L,180782L,203433L,207974L,211562L,212583L,214489L,219063L,219894L,219963L,225069L,228135L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242607Inst : IEnumerable<long>
{
public static readonly long[] Value=A242607.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242607.Bytes);
public long this[int i]=>Value[i];

public static A242607Inst Instance=new A242607Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242672
{
public static readonly long[] Value={ 3L,8L,6L,9L,5L,1L,9L,2L,4L,1L,3L,9L,7L,9L,9L,9L,4L,9L,5L,6L,9L,4L,1L,6L,7L,2L,7L,8L,7L,7L,9L,0L,8L,3L,4L,3L,2L,1L,9L,4L,6L,0L,6L,4L,3L,2L,5L,1L,9L,6L,9L,3L,3L,4L,4L,0L,4L,3L,9L,6L,0L,8L,9L,1L,1L,7L,0L,5L,9L,6L,2L,9L,9L,7L,8L,9L,8L,0L,3L,1L,5L,6L,0L,7L,0L,3L,6L,0L,6L,6L,7L,6L,1L,8L,4L,9L,3L,0L,8L,7L,1L,9L,7L,5L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242672Inst : IEnumerable<long>
{
public static readonly long[] Value=A242672.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242672.Bytes);
public long this[int i]=>Value[i];

public static A242672Inst Instance=new A242672Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242673
{
public static readonly long[] Value={ 8L,0L,4L,3L,5L,2L,2L,6L,2L,8L,4L,5L,6L,3L,7L,5L,8L,4L,6L,5L,4L,6L,3L,8L,5L,8L,7L,7L,8L,4L,0L,7L,0L,5L,5L,1L,0L,4L,2L,7L,1L,6L,9L,8L,5L,7L,8L,6L,6L,4L,2L,1L,5L,8L,6L,5L,6L,5L,4L,4L,7L,8L,2L,7L,2L,0L,9L,1L,3L,6L,5L,8L,9L,2L,1L,0L,1L,3L,1L,9L,3L,6L,3L,1L,4L,4L,6L,7L,4L,3L,4L,6L,3L,8L,1L,5L,2L,9L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242673Inst : IEnumerable<long>
{
public static readonly long[] Value=A242673.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242673.Bytes);
public long this[int i]=>Value[i];

public static A242673Inst Instance=new A242673Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242674
{
public static readonly long[] Value={ 5L,8L,0L,1L,6L,4L,2L,2L,3L,9L,2L,0L,8L,5L,5L,3L,4L,6L,4L,2L,6L,0L,0L,8L,3L,2L,3L,5L,7L,2L,9L,9L,7L,2L,7L,6L,6L,3L,3L,0L,8L,8L,6L,3L,8L,1L,1L,1L,1L,0L,1L,4L,0L,4L,3L,1L,6L,8L,7L,4L,1L,1L,7L,9L,2L,1L,6L,6L,1L,3L,8L,7L,7L,9L,6L,9L,2L,9L,2L,4L,9L,1L,8L,4L,5L,9L,3L,1L,5L,2L,6L,8L,4L,4L,7L,0L,3L,4L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242674Inst : IEnumerable<long>
{
public static readonly long[] Value=A242674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242674.Bytes);
public long this[int i]=>Value[i];

public static A242674Inst Instance=new A242674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242675
{
public static readonly long[] Value={ 2L,29L,89L,101L,281L,269L,641L,461L,701L,761L,1049L,941L,1109L,1601L,1361L,2621L,2309L,1889L,2441L,2141L,2609L,3929L,3701L,3461L,3449L,5849L,4241L,4289L,5081L,8669L,7589L,5381L,6569L,9941L,8861L,7229L,7829L,8501L,8069L,8609L,9749L,10601L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242675Inst : IEnumerable<long>
{
public static readonly long[] Value=A242675.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242675.Bytes);
public long this[int i]=>Value[i];

public static A242675Inst Instance=new A242675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242676
{
public static readonly BigInteger[] Value={ 1L,6L,13068L,150917976L,5056995703824L,371384787345228000L,BigInteger.Parse("50779532534302850198976"),BigInteger.Parse("11616723683566425573507775872"),BigInteger.Parse("4123257155075936045020928754053376"),BigInteger.Parse("2146734309994687055429549444238169536000"),BigInteger.Parse("1569808063009967047226374755685187772671339520") };
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
public class A242676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242676Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A242676.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242676.Bytes);
public BigInteger this[int i]=>Value[i];

public static A242676Inst Instance=new A242676Inst();

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