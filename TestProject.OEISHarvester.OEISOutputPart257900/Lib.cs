using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A184270
{
public static readonly BigInteger[] Value={ 36L,4150L,699252L,134223976L,27487816992L,5864063066500L,1286742755471400L,288230376353050816L,BigInteger.Parse("65588423374144427520"),BigInteger.Parse("15111572745224096425720"),BigInteger.Parse("3516875111606393874082104"),BigInteger.Parse("825293359523595646117352176"),BigInteger.Parse("195023169265881489687952047216") };
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
public class A184270Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184270.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184270Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184270.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A184270.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184270Inst Instance=new A184270Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184271
{
public static readonly long[] Value={ 2L,3L,3L,4L,7L,4L,6L,14L,14L,6L,8L,40L,64L,40L,8L,14L,108L,352L,352L,108L,14L,20L,362L,2192L,4156L,2192L,362L,20L,36L,1182L,14624L,52488L,52488L,14624L,1182L,36L,60L,4150L,99880L,699600L,1342208L,699600L,99880L,4150L,60L,108L,14602L,699252L,9587580L,35792568L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184271Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184271.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184271Inst : IEnumerable<long>
{
public static readonly long[] Value=A184271.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184271.Bytes);
public long this[int i]=>Value[i];

public static A184271Inst Instance=new A184271Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184272
{
public static readonly long[] Value={ 4L,76L,29184L,268447936L,45035996274688L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184272Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184272.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184272Inst : IEnumerable<long>
{
public static readonly long[] Value=A184272.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184272.Bytes);
public long this[int i]=>Value[i];

public static A184272Inst Instance=new A184272Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184273
{
public static readonly long[] Value={ 10L,76L,700L,8296L,104968L,1399176L,19175140L,268447816L,3817763740L,54975738736L,799645010860L,11728126132976L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184273Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184273.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184273Inst : IEnumerable<long>
{
public static readonly long[] Value=A184273.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184273.Bytes);
public long this[int i]=>Value[i];

public static A184273Inst Instance=new A184273Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184274
{
public static readonly long[] Value={ 24L,700L,29184L,1398500L,71582944L,3817765120L,209430787824L,11728124734500L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184274Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184274.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184274Inst : IEnumerable<long>
{
public static readonly long[] Value=A184274.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184274.Bytes);
public long this[int i]=>Value[i];

public static A184274Inst Instance=new A184274Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184275
{
public static readonly long[] Value={ 70L,8296L,1398500L,268447936L,54975633976L,11728126132976L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184275Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184275.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184275Inst : IEnumerable<long>
{
public static readonly long[] Value=A184275.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184275.Bytes);
public long this[int i]=>Value[i];

public static A184275Inst Instance=new A184275Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184276
{
public static readonly long[] Value={ 208L,104968L,71582944L,54975633976L,45035996274688L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184276Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184276.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184276Inst : IEnumerable<long>
{
public static readonly long[] Value=A184276.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184276.Bytes);
public long this[int i]=>Value[i];

public static A184276Inst Instance=new A184276Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184277
{
public static readonly long[] Value={ 4L,10L,10L,24L,76L,24L,70L,700L,700L,70L,208L,8296L,29184L,8296L,208L,700L,104968L,1398500L,1398500L,104968L,700L,2344L,1399176L,71582944L,268447936L,71582944L,1399176L,2344L,8230L,19175140L,3817765120L,54975633976L,54975633976L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184277Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184277.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184277Inst : IEnumerable<long>
{
public static readonly long[] Value=A184277.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184277.Bytes);
public long this[int i]=>Value[i];

public static A184277Inst Instance=new A184277Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184278
{
public static readonly long[] Value={ 3L,27L,2211L,2691711L,33891544611L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184278Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184278.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184278Inst : IEnumerable<long>
{
public static readonly long[] Value=A184278.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184278.Bytes);
public long this[int i]=>Value[i];

public static A184278Inst Instance=new A184278Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184279
{
public static readonly long[] Value={ 6L,27L,130L,855L,5934L,44487L,341802L,2691675L,21524542L,174348099L,1426419858L,11767964475L,97764131646L,817028814447L,6863038218842L,57906884938095L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184279Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184279.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184279Inst : IEnumerable<long>
{
public static readonly long[] Value=A184279.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184279.Bytes);
public long this[int i]=>Value[i];

public static A184279Inst Instance=new A184279Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184280
{
public static readonly long[] Value={ 11L,130L,2211L,44368L,956635L,21524790L,498112275L,11767920118L,282429542331L,6863038218842L,168456380815459L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184280Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184280.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184280Inst : IEnumerable<long>
{
public static readonly long[] Value=A184280.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184280.Bytes);
public long this[int i]=>Value[i];

public static A184280Inst Instance=new A184280Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184281
{
public static readonly long[] Value={ 24L,855L,44368L,2691711L,174342216L,11767964475L,817028472960L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184281Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184281.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184281Inst : IEnumerable<long>
{
public static readonly long[] Value=A184281.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184281.Bytes);
public long this[int i]=>Value[i];

public static A184281Inst Instance=new A184281Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184282
{
public static readonly long[] Value={ 51L,5934L,956635L,174342216L,33891544611L,6863038218842L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184282Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184282.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184282Inst : IEnumerable<long>
{
public static readonly long[] Value=A184282.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184282.Bytes);
public long this[int i]=>Value[i];

public static A184282Inst Instance=new A184282Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184283
{
public static readonly long[] Value={ 130L,44487L,21524790L,11767964475L,6863038218842L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184283Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184283.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184283Inst : IEnumerable<long>
{
public static readonly long[] Value=A184283.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184283.Bytes);
public long this[int i]=>Value[i];

public static A184283Inst Instance=new A184283Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184364
{
public static readonly long[] Value={ 2L,6L,4L,14L,14L,8L,30L,38L,30L,16L,62L,90L,86L,62L,32L,126L,200L,218L,182L,126L,64L,254L,428L,516L,474L,374L,254L,128L,510L,896L,1170L,1156L,986L,758L,510L,256L,1022L,1850L,2576L,2698L,2436L,2010L,1526L,1022L,512L,2046L,3786L,5554L,6118L,5770L,4996L,4058L,3062L,2046L,1024L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184364Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184364.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184364Inst : IEnumerable<long>
{
public static readonly long[] Value=A184364.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184364.Bytes);
public long this[int i]=>Value[i];

public static A184364Inst Instance=new A184364Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184365
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,-4L,0L,-6L,0L,0L,0L,0L,11L,0L,0L,14L,0L,0L,0L,0L,0L,0L,-21L,0L,0L,0L,-25L,0L,0L,0L,0L,0L,0L,0L,0L,34L,0L,0L,0L,0L,39L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-50L,0L,0L,0L,0L,0L,-56L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,69L,0L,0L,0L,0L,0L,0L,76L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-91L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184365Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184365.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184365Inst : IEnumerable<long>
{
public static readonly long[] Value=A184365.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184365.Bytes);
public long this[int i]=>Value[i];

public static A184365Inst Instance=new A184365Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184366
{
public static readonly long[] Value={ 1L,-2L,0L,0L,0L,0L,7L,0L,0L,0L,-21L,0L,0L,0L,0L,44L,0L,0L,0L,0L,0L,-78L,0L,0L,0L,0L,0L,0L,125L,0L,0L,0L,0L,0L,0L,0L,-187L,0L,0L,0L,0L,0L,0L,0L,0L,266L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-364L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,483L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-625L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,792L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184366Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184366.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184366Inst : IEnumerable<long>
{
public static readonly long[] Value=A184366.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184366.Bytes);
public long this[int i]=>Value[i];

public static A184366Inst Instance=new A184366Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184367
{
public static readonly BigInteger[] Value={ 21L,2755L,2167173L,10378244309L,301753233626727L,BigInteger.Parse("53293289955084658949"),BigInteger.Parse("57168347029530545962203193"),BigInteger.Parse("372482322079037724494019844619359") };
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
public class A184367Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184367.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184367Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184367.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A184367.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184367Inst Instance=new A184367Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184368
{
public static readonly long[] Value={ 21L,153L,1107L,8019L,58077L,420633L,3046491L,22064643L,159806277L,1157419449L,8382773187L,60713414163L,439725443661L,3184773389433L,23066169329547L,167059976482179L,1209955382858997L,8763272085493593L,63469230958692531L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184368Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184368.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184368Inst : IEnumerable<long>
{
public static readonly long[] Value=A184368.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184368.Bytes);
public long this[int i]=>Value[i];

public static A184368Inst Instance=new A184368Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184369
{
public static readonly BigInteger[] Value={ 153L,2755L,49235L,880781L,15754461L,281803871L,5040682279L,90163722073L,1612776998193L,28848073268443L,516011408652059L,9230001997285733L,165098940527912805L,2953158641948611223L,BigInteger.Parse("52823754874667184367") };
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
public class A184369Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184369.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184369Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184369.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A184369.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184369Inst Instance=new A184369Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184370
{
public static readonly BigInteger[] Value={ 1107L,49235L,2167173L,95528423L,4210059673L,185547841629L,8177524177277L,360402692568245L,15883791500540967L,700035935394350709L,BigInteger.Parse("30852225032929689819"),BigInteger.Parse("1359729896274471875219"),BigInteger.Parse("59926484677950059719491") };
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
public class A184370Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184370.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184370Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184370.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A184370.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184370Inst Instance=new A184370Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184371
{
public static readonly BigInteger[] Value={ 8019L,880781L,95528423L,10378244309L,1127256514575L,122443114867993L,13299774554091575L,1444622701339019869L,BigInteger.Parse("156915034606615850427"),BigInteger.Parse("17044123945719790186817"),BigInteger.Parse("1851334139596041020316331") };
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
public class A184371Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184371.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184371Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184371.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A184371.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184371Inst Instance=new A184371Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184372
{
public static readonly BigInteger[] Value={ 58077L,15754461L,4210059673L,1127256514575L,301753233626727L,80778452206783159L,BigInteger.Parse("21624059735461675335"),BigInteger.Parse("5788675585887326994869"),BigInteger.Parse("1549605510397241533259837"),BigInteger.Parse("414823258633731476239250435") };
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
public class A184372Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184372.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184372Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184372.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A184372.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184372Inst Instance=new A184372Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184373
{
public static readonly BigInteger[] Value={ 420633L,281803871L,185547841629L,122443114867993L,80778452206783159L,BigInteger.Parse("53293289955084658949"),BigInteger.Parse("35159890626610196979641"),BigInteger.Parse("23196517518911246631354055"),BigInteger.Parse("15303755709562804997482560737"),BigInteger.Parse("10096556166552290137769922123373") };
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
public class A184373Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184373.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184373Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184373.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A184373.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184373Inst Instance=new A184373Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184374
{
public static readonly BigInteger[] Value={ 3046491L,5040682279L,8177524177277L,13299774554091575L,BigInteger.Parse("21624059735461675335"),BigInteger.Parse("35159890626610196979641"),BigInteger.Parse("57168347029530545962203193"),BigInteger.Parse("92953139774330929595592449437"),BigInteger.Parse("151137575901032303453595440035363") };
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
public class A184374Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184374.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184374Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184374.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A184374.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184374Inst Instance=new A184374Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184375
{
public static readonly BigInteger[] Value={ 22064643L,90163722073L,360402692568245L,1444622701339019869L,BigInteger.Parse("5788675585887326994869"),BigInteger.Parse("23196517518911246631354055"),BigInteger.Parse("92953139774330929595592449437"),BigInteger.Parse("372482322079037724494019844619359") };
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
public class A184375Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184375.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184375Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184375.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A184375.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184375Inst Instance=new A184375Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184376
{
public static readonly long[] Value={ 21L,153L,153L,1107L,2755L,1107L,8019L,49235L,49235L,8019L,58077L,880781L,2167173L,880781L,58077L,420633L,15754461L,95528423L,95528423L,15754461L,420633L,3046491L,281803871L,4210059673L,10378244309L,4210059673L,281803871L,3046491L,22064643L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184376Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184376.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184376Inst : IEnumerable<long>
{
public static readonly long[] Value=A184376.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184376.Bytes);
public long this[int i]=>Value[i];

public static A184376Inst Instance=new A184376Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184377
{
public static readonly long[] Value={ 140L,1494L,8936L,38642L,207470L,890982L,3651098L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184377Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184377.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184377Inst : IEnumerable<long>
{
public static readonly long[] Value=A184377.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184377.Bytes);
public long this[int i]=>Value[i];

public static A184377Inst Instance=new A184377Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184378
{
public static readonly long[] Value={ 140L,545L,2174L,9113L,43295L,212747L,1096781L,6045233L,33958643L,194694395L,1141026791L,6726497945L,39885267065L,237890735825L,1421015749799L,8500910306963L,50929911923495L,305241246279617L,1830098075374121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184378Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184378.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184378Inst : IEnumerable<long>
{
public static readonly long[] Value=A184378.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184378.Bytes);
public long this[int i]=>Value[i];

public static A184378Inst Instance=new A184378Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184379
{
public static readonly long[] Value={ 545L,1494L,4281L,13616L,55386L,242370L,1165496L,6248040L,34487190L,195981866L,1145052186L,6737361360L,39912443060L,237978427224L,1421256784506L,8501521627826L,50931916877226L,305246808679080L,1830112280897396L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184379Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184379.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184379Inst : IEnumerable<long>
{
public static readonly long[] Value=A184379.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184379.Bytes);
public long this[int i]=>Value[i];

public static A184379Inst Instance=new A184379Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184428
{
public static readonly long[] Value={ 2L,7L,13L,21L,31L,44L,58L,74L,92L,112L,135L,159L,185L,213L,243L,275L,309L,346L,384L,424L,466L,510L,556L,604L,654L,706L,761L,817L,875L,935L,997L,1061L,1127L,1195L,1265L,1337L,1411L,1487L,1566L,1646L,1728L,1812L,1898L,1986L,2076L,2168L,2262L,2358L,2456L,2556L,2658L,2763L,2869L,2977L,3087L,3199L,3313L,3429L,3547L,3667L,3789L,3913L,4039L,4167L,4297L,4429L,4564L,4700L,4838L,4978L,5120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184428Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184428.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184428Inst : IEnumerable<long>
{
public static readonly long[] Value=A184428.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184428.Bytes);
public long this[int i]=>Value[i];

public static A184428Inst Instance=new A184428Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184429
{
public static readonly long[] Value={ 1L,3L,4L,6L,7L,9L,10L,11L,13L,14L,15L,17L,18L,19L,20L,22L,23L,24L,25L,27L,28L,29L,30L,32L,33L,34L,35L,36L,37L,39L,40L,41L,42L,43L,45L,46L,47L,48L,49L,50L,52L,53L,54L,55L,56L,57L,58L,60L,61L,62L,63L,64L,65L,66L,68L,69L,70L,71L,72L,73L,74L,76L,77L,78L,79L,80L,81L,82L,83L,85L,86L,87L,88L,89L,90L,91L,92L,93L,95L,96L,97L,98L,99L,100L,101L,102L,103L,105L,106L,107L,108L,109L,110L,111L,112L,113L,115L,116L,117L,118L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184429Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184429.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184429Inst : IEnumerable<long>
{
public static readonly long[] Value=A184429.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184429.Bytes);
public long this[int i]=>Value[i];

public static A184429Inst Instance=new A184429Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184430
{
public static readonly long[] Value={ 2L,5L,8L,12L,16L,21L,26L,31L,38L,44L,51L,59L,67L,75L,84L,94L,104L,114L,125L,137L,149L,161L,174L,188L,202L,216L,231L,246L,262L,279L,296L,313L,331L,349L,369L,388L,408L,428L,449L,470L,493L,515L,538L,561L,585L,609L,634L,660L,686L,712L,739L,766L,794L,822L,852L,881L,911L,941L,972L,1003L,1035L,1068L,1101L,1134L,1168L,1202L,1237L,1272L,1308L,1345L,1382L,1419L,1457L,1495L,1534L,1573L,1613L,1653L,1695L,1736L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184430Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184430.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184430Inst : IEnumerable<long>
{
public static readonly long[] Value=A184430.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184430.Bytes);
public long this[int i]=>Value[i];

public static A184430Inst Instance=new A184430Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184431
{
public static readonly long[] Value={ 1L,3L,4L,5L,7L,8L,9L,10L,11L,13L,14L,15L,16L,17L,18L,19L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L,72L,74L,75L,76L,77L,78L,79L,80L,81L,82L,83L,84L,85L,86L,87L,88L,89L,90L,91L,92L,93L,94L,95L,96L,97L,98L,99L,100L,102L,103L,104L,105L,106L,107L,108L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184431Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184431.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184431Inst : IEnumerable<long>
{
public static readonly long[] Value=A184431.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184431.Bytes);
public long this[int i]=>Value[i];

public static A184431Inst Instance=new A184431Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184432
{
public static readonly long[] Value={ 2L,6L,12L,20L,34L,50L,73L,101L,136L,179L,230L,289L,359L,438L,530L,633L,750L,879L,1023L,1181L,1356L,1546L,1755L,1981L,2226L,2490L,2775L,3080L,3408L,3758L,4132L,4529L,4951L,5398L,5872L,6372L,6901L,7457L,8044L,8660L,9307L,9985L,10696L,11439L,12218L,13029L,13877L,14760L,15680L,16637L,17633L,18667L,19742L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184432Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184432.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184432Inst : IEnumerable<long>
{
public static readonly long[] Value=A184432.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184432.Bytes);
public long this[int i]=>Value[i];

public static A184432Inst Instance=new A184432Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184433
{
public static readonly long[] Value={ 1L,1L,2L,10L,39L,436L,3818L,38560L,513211L,6729888L,94975257L,1514956607L,24870079005L,430238381615L,7946503640262L,151928007427027L,3024975882657404L,62893815171137570L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184433Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184433.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184433Inst : IEnumerable<long>
{
public static readonly long[] Value=A184433.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184433.Bytes);
public long this[int i]=>Value[i];

public static A184433Inst Instance=new A184433Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184434
{
public static readonly long[] Value={ 1L,1L,3L,5L,8L,17L,31L,63L,129L,244L,458L,860L,1544L,2721L,4734L,8044L,13423L,22097L,35750L,57052L,89944L,139918L,215240L,327754L,493888L,737327L,1091368L,1601767L,2332587L,3372198L,4840788L,6903176L,9783032L,13780976L,19302810L,26891801L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184434Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184434.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184434Inst : IEnumerable<long>
{
public static readonly long[] Value=A184434.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184434.Bytes);
public long this[int i]=>Value[i];

public static A184434Inst Instance=new A184434Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184435
{
public static readonly long[] Value={ 1L,1L,2L,5L,19L,51L,130L,359L,946L,2333L,5818L,14088L,33135L,76611L,173464L,384457L,837012L,1790715L,3766901L,7802712L,15923697L,32039816L,63611885L,124689752L,241431996L,462031599L,874300348L,1636607223L,3031814449L,5560277156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184435Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184435.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184435Inst : IEnumerable<long>
{
public static readonly long[] Value=A184435.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184435.Bytes);
public long this[int i]=>Value[i];

public static A184435Inst Instance=new A184435Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184436
{
public static readonly long[] Value={ 1L,1L,3L,10L,32L,116L,368L,1235L,4321L,13396L,40668L,124627L,362283L,1030513L,2887111L,7874749L,21054468L,55326873L,142607396L,361404953L,901518960L,2213631284L,5356287900L,12780944283L,30087543948L,69923248394L,160510425840L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184436Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184436.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184436Inst : IEnumerable<long>
{
public static readonly long[] Value=A184436.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184436.Bytes);
public long this[int i]=>Value[i];

public static A184436Inst Instance=new A184436Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184437
{
public static readonly long[] Value={ 1L,1L,5L,14L,39L,238L,915L,3532L,15165L,56094L,202714L,742339L,2571320L,8690976L,28962054L,93717076L,296850271L,923818730L,2815625489L,8428070046L,24812690100L,71831879744L,204732764217L,574966504528L,1591665305364L,4346329669253L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184437Inst : IEnumerable<long>
{
public static readonly long[] Value=A184437.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184437.Bytes);
public long this[int i]=>Value[i];

public static A184437Inst Instance=new A184437Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184438
{
public static readonly long[] Value={ 1L,1L,5L,15L,92L,436L,1993L,9478L,43638L,187235L,809030L,3365945L,13510461L,53274149L,204598179L,765394402L,2806261890L,10071367726L,35409883104L,122234932333L,414412164610L,1380949308381L,4527966672187L,14616894999438L,46485172533638L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184438Inst : IEnumerable<long>
{
public static readonly long[] Value=A184438.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184438.Bytes);
public long this[int i]=>Value[i];

public static A184438Inst Instance=new A184438Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184439
{
public static readonly long[] Value={ 1L,1L,5L,14L,101L,715L,3818L,19257L,109623L,541179L,2588583L,12533674L,57289175L,255004484L,1117915131L,4748188269L,19711864941L,80293980695L,319810672333L,1249298852482L,4793924733547L,18065184325915L,66940461343250L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184439Inst : IEnumerable<long>
{
public static readonly long[] Value=A184439.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184439.Bytes);
public long this[int i]=>Value[i];

public static A184439Inst Instance=new A184439Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184440
{
public static readonly long[] Value={ 1L,1L,3L,28L,146L,1160L,6805L,38560L,248861L,1376999L,7346823L,40066933L,205138785L,1021202011L,5016967826L,23832660309L,110581697393L,503553260431L,2240165792600L,9769058509321L,41836840405957L,175853358107466L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184440Inst : IEnumerable<long>
{
public static readonly long[] Value=A184440.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184440.Bytes);
public long this[int i]=>Value[i];

public static A184440Inst Instance=new A184440Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184441
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,1L,3L,2L,1L,1L,2L,5L,3L,1L,1L,3L,5L,8L,4L,1L,1L,5L,10L,19L,17L,5L,1L,1L,5L,14L,32L,51L,31L,6L,1L,1L,5L,15L,39L,116L,130L,63L,8L,1L,2L,3L,14L,92L,238L,368L,359L,129L,10L,1L,1L,5L,28L,101L,436L,915L,1235L,946L,244L,12L,1L,1L,10L,23L,146L,715L,1993L,3532L,4321L,2333L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184441Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184441.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184441Inst : IEnumerable<long>
{
public static readonly long[] Value=A184441.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184441.Bytes);
public long this[int i]=>Value[i];

public static A184441Inst Instance=new A184441Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184442
{
public static readonly long[] Value={ 2L,3L,2L,3L,5L,5L,5L,3L,5L,10L,5L,5L,8L,12L,6L,3L,7L,10L,7L,10L,12L,13L,9L,5L,16L,18L,11L,12L,11L,21L,14L,3L,9L,16L,23L,10L,16L,18L,18L,10L,16L,30L,14L,13L,22L,26L,14L,5L,22L,39L,15L,18L,22L,26L,26L,12L,20L,29L,19L,21L,21L,37L,27L,3L,35L,30L,22L,16L,29L,61L,23L,10L,25L,45L,34L,18L,30L,48L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184442Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184442.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184442Inst : IEnumerable<long>
{
public static readonly long[] Value=A184442.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184442.Bytes);
public long this[int i]=>Value[i];

public static A184442Inst Instance=new A184442Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184443
{
public static readonly long[] Value={ 2L,5L,5L,10L,14L,15L,14L,28L,23L,46L,36L,41L,49L,64L,62L,82L,82L,86L,110L,163L,92L,128L,145L,132L,196L,198L,138L,215L,217L,259L,231L,304L,210L,312L,333L,290L,353L,435L,283L,555L,404L,361L,455L,532L,477L,606L,551L,481L,511L,888L,477L,743L,709L,591L,813L,772L,664L,924L,818L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184443Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184443.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184443Inst : IEnumerable<long>
{
public static readonly long[] Value=A184443.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184443.Bytes);
public long this[int i]=>Value[i];

public static A184443Inst Instance=new A184443Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184524
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,7L,8L,9L,10L,12L,13L,14L,15L,16L,18L,19L,20L,21L,22L,24L,25L,26L,27L,28L,29L,31L,32L,33L,34L,35L,37L,38L,39L,40L,41L,43L,44L,45L,46L,47L,49L,50L,51L,52L,53L,55L,56L,57L,58L,59L,60L,62L,63L,64L,65L,66L,68L,69L,70L,71L,72L,74L,75L,76L,77L,78L,80L,81L,82L,83L,84L,86L,87L,88L,89L,90L,91L,93L,94L,95L,96L,97L,99L,100L,101L,102L,103L,105L,106L,107L,108L,109L,111L,112L,113L,114L,115L,117L,118L,119L,120L,121L,122L,124L,125L,126L,127L,128L,130L,131L,132L,133L,134L,136L,137L,138L,139L,140L,142L,143L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184524Inst : IEnumerable<long>
{
public static readonly long[] Value=A184524.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184524.Bytes);
public long this[int i]=>Value[i];

public static A184524Inst Instance=new A184524Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184525
{
public static readonly long[] Value={ 5L,11L,17L,23L,30L,36L,42L,48L,54L,61L,67L,73L,79L,85L,92L,98L,104L,110L,116L,123L,129L,135L,141L,147L,153L,160L,166L,172L,178L,184L,191L,197L,203L,209L,215L,222L,228L,234L,240L,246L,253L,259L,265L,271L,277L,284L,290L,296L,302L,308L,314L,321L,327L,333L,339L,345L,352L,358L,364L,370L,376L,383L,389L,395L,401L,407L,414L,420L,426L,432L,438L,445L,451L,457L,463L,469L,475L,482L,488L,494L,500L,506L,513L,519L,525L,531L,537L,544L,550L,556L,562L,568L,575L,581L,587L,593L,599L,606L,612L,618L,624L,630L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184525Inst : IEnumerable<long>
{
public static readonly long[] Value=A184525.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184525.Bytes);
public long this[int i]=>Value[i];

public static A184525Inst Instance=new A184525Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184526
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,7L,8L,9L,11L,12L,13L,14L,15L,17L,18L,19L,20L,21L,22L,24L,25L,26L,27L,28L,30L,31L,32L,33L,34L,36L,37L,38L,39L,40L,42L,43L,44L,45L,46L,48L,49L,50L,51L,52L,53L,55L,56L,57L,58L,59L,61L,62L,63L,64L,65L,67L,68L,69L,70L,71L,73L,74L,75L,76L,77L,79L,80L,81L,82L,83L,84L,86L,87L,88L,89L,90L,92L,93L,94L,95L,96L,98L,99L,100L,101L,102L,104L,105L,106L,107L,108L,110L,111L,112L,113L,114L,116L,117L,118L,119L,120L,121L,123L,124L,125L,126L,127L,129L,130L,131L,132L,133L,135L,136L,137L,138L,139L,141L,142L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184526Inst : IEnumerable<long>
{
public static readonly long[] Value=A184526.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184526.Bytes);
public long this[int i]=>Value[i];

public static A184526Inst Instance=new A184526Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184527
{
public static readonly long[] Value={ 4L,10L,16L,23L,29L,35L,41L,47L,54L,60L,66L,72L,78L,85L,91L,97L,103L,109L,115L,122L,128L,134L,140L,146L,153L,159L,165L,171L,177L,184L,190L,196L,202L,208L,215L,221L,227L,233L,239L,246L,252L,258L,264L,270L,276L,283L,289L,295L,301L,307L,314L,320L,326L,332L,338L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184527Inst : IEnumerable<long>
{
public static readonly long[] Value=A184527.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184527.Bytes);
public long this[int i]=>Value[i];

public static A184527Inst Instance=new A184527Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184528
{
public static readonly long[] Value={ 1L,2L,4L,5L,6L,7L,8L,10L,11L,12L,13L,14L,15L,17L,18L,19L,20L,21L,23L,24L,25L,26L,27L,29L,30L,31L,32L,33L,35L,36L,37L,38L,39L,41L,42L,43L,44L,45L,46L,48L,49L,50L,51L,52L,54L,55L,56L,57L,58L,60L,61L,62L,63L,64L,66L,67L,68L,69L,70L,72L,73L,74L,75L,76L,78L,79L,80L,81L,82L,83L,85L,86L,87L,88L,89L,91L,92L,93L,94L,95L,97L,98L,99L,100L,101L,103L,104L,105L,106L,107L,109L,110L,111L,112L,113L,114L,116L,117L,118L,119L,120L,122L,123L,124L,125L,126L,128L,129L,130L,131L,132L,134L,135L,136L,137L,138L,140L,141L,142L,143L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184528Inst : IEnumerable<long>
{
public static readonly long[] Value=A184528.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184528.Bytes);
public long this[int i]=>Value[i];

public static A184528Inst Instance=new A184528Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184529
{
public static readonly long[] Value={ 3L,9L,16L,22L,28L,34L,40L,47L,53L,59L,65L,71L,77L,84L,90L,96L,102L,108L,115L,121L,127L,133L,139L,146L,152L,158L,164L,170L,177L,183L,189L,195L,201L,208L,214L,220L,226L,232L,238L,245L,251L,257L,263L,269L,276L,282L,288L,294L,300L,307L,313L,319L,325L,331L,338L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184529Inst : IEnumerable<long>
{
public static readonly long[] Value=A184529.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184529.Bytes);
public long this[int i]=>Value[i];

public static A184529Inst Instance=new A184529Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184530
{
public static readonly long[] Value={ 1L,3L,4L,5L,6L,7L,8L,10L,11L,12L,13L,14L,16L,17L,18L,19L,20L,22L,23L,24L,25L,26L,28L,29L,30L,31L,32L,34L,35L,36L,37L,38L,40L,41L,42L,43L,44L,45L,47L,48L,49L,50L,51L,53L,54L,55L,56L,57L,59L,60L,61L,62L,63L,65L,66L,67L,68L,69L,71L,72L,73L,74L,75L,76L,78L,79L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184530Inst : IEnumerable<long>
{
public static readonly long[] Value=A184530.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184530.Bytes);
public long this[int i]=>Value[i];

public static A184530Inst Instance=new A184530Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184531
{
public static readonly long[] Value={ 2L,9L,15L,21L,27L,33L,39L,46L,52L,58L,64L,70L,77L,83L,89L,95L,101L,108L,114L,120L,126L,132L,139L,145L,151L,157L,163L,170L,176L,182L,188L,194L,201L,207L,213L,219L,225L,231L,238L,244L,250L,256L,262L,269L,275L,281L,287L,293L,300L,306L,312L,318L,324L,331L,337L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184531Inst : IEnumerable<long>
{
public static readonly long[] Value=A184531.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184531.Bytes);
public long this[int i]=>Value[i];

public static A184531Inst Instance=new A184531Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184532
{
public static readonly long[] Value={ 3L,2L,1L,1L,1L,1L,12L,6L,4L,3L,2L,2L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,27L,13L,9L,7L,5L,4L,4L,3L,3L,3L,2L,2L,2L,2L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,48L,24L,16L,12L,9L,8L,7L,6L,5L,5L,4L,4L,3L,3L,3L,3L,3L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,75L,37L,25L,18L,15L,12L,10L,9L,8L,7L,7L,6L,5L,5L,5L,4L,4L,4L,4L,3L,3L,3L,3L,3L,3L,3L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184532Inst : IEnumerable<long>
{
public static readonly long[] Value=A184532.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184532.Bytes);
public long this[int i]=>Value[i];

public static A184532Inst Instance=new A184532Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184533
{
public static readonly long[] Value={ 2L,6L,13L,24L,37L,54L,73L,96L,121L,150L,181L,216L,253L,294L,337L,384L,433L,486L,541L,600L,661L,726L,793L,864L,937L,1014L,1093L,1176L,1261L,1350L,1441L,1536L,1633L,1734L,1837L,1944L,2053L,2166L,2281L,2400L,2521L,2646L,2773L,2904L,3037L,3174L,3313L,3456L,3601L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184533Inst : IEnumerable<long>
{
public static readonly long[] Value=A184533.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184533.Bytes);
public long this[int i]=>Value[i];

public static A184533Inst Instance=new A184533Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184534
{
public static readonly long[] Value={ 1L,3L,7L,12L,18L,27L,36L,48L,60L,75L,90L,108L,126L,147L,168L,192L,216L,243L,270L,300L,330L,363L,396L,432L,468L,507L,546L,588L,630L,675L,720L,768L,816L,867L,918L,972L,1026L,1083L,1140L,1200L,1260L,1323L,1386L,1452L,1518L,1587L,1656L,1728L,1800L,1875L,1950L,2028L,2106L,2187L,2268L,2352L,2436L,2523L,2610L,2700L,2790L,2883L,2976L,3072L,3168L,3267L,3366L,3468L,3570L,3675L,3780L,3888L,3996L,4107L,4218L,4332L,4446L,4563L,4680L,4800L,4920L,5043L,5166L,5292L,5418L,5547L,5676L,5808L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184534Inst : IEnumerable<long>
{
public static readonly long[] Value=A184534.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184534.Bytes);
public long this[int i]=>Value[i];

public static A184534Inst Instance=new A184534Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184535
{
public static readonly long[] Value={ 1L,2L,5L,9L,15L,21L,29L,38L,48L,60L,72L,86L,101L,117L,135L,153L,173L,194L,216L,240L,264L,290L,317L,345L,375L,405L,437L,470L,504L,540L,576L,614L,653L,693L,735L,777L,821L,866L,912L,960L,1008L,1058L,1109L,1161L,1215L,1269L,1325L,1382L,1440L,1500L,1560L,1622L,1685L,1749L,1815L,1881L,1949L,2018L,2088L,2160L,2232L,2306L,2381L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184535Inst : IEnumerable<long>
{
public static readonly long[] Value=A184535.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184535.Bytes);
public long this[int i]=>Value[i];

public static A184535Inst Instance=new A184535Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184536
{
public static readonly long[] Value={ 5L,32L,108L,256L,500L,864L,1372L,2048L,2916L,4000L,5324L,6912L,8788L,10976L,13500L,16384L,19652L,23328L,27436L,32000L,37044L,42592L,48668L,55296L,62500L,70304L,78732L,87808L,97556L,108000L,119164L,131072L,143748L,157216L,171500L,186624L,202612L,219488L,237276L,256000L,275684L,296352L,318028L,340736L,364500L,389344L,415292L,442368L,470596L,500000L,530604L,562432L,595508L,629856L,665500L,702464L,740772L,780448L,821516L,864000L,907924L,953312L,1000188L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184536Inst : IEnumerable<long>
{
public static readonly long[] Value=A184536.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184536.Bytes);
public long this[int i]=>Value[i];

public static A184536Inst Instance=new A184536Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184537
{
public static readonly long[] Value={ 5L,3L,16L,54L,128L,250L,432L,686L,1024L,1458L,2000L,2662L,3456L,4394L,5488L,6750L,8192L,9826L,11664L,13718L,16000L,18522L,21296L,24334L,27648L,31250L,35152L,39366L,43904L,48778L,54000L,59582L,65536L,71874L,78608L,85750L,93312L,101306L,109744L,118638L,128000L,137842L,148176L,159014L,170368L,182250L,194672L,207646L,221184L,235298L,250000L,265302L,281216L,297754L,314928L,332750L,351232L,370386L,390224L,410758L,432000L,453962L,476656L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184537Inst : IEnumerable<long>
{
public static readonly long[] Value=A184537.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184537.Bytes);
public long this[int i]=>Value[i];

public static A184537Inst Instance=new A184537Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184538
{
public static readonly long[] Value={ 2L,11L,36L,85L,166L,288L,457L,682L,972L,1333L,1774L,2304L,2929L,3658L,4500L,5461L,6550L,7776L,9145L,10666L,12348L,14197L,16222L,18432L,20833L,23434L,26244L,29269L,32518L,36000L,39721L,43690L,47916L,52405L,57166L,62208L,67537L,73162L,79092L,85333L,91894L,98784L,106009L,113578L,121500L,129781L,138430L,147456L,156865L,166666L,176868L,187477L,198502L,209952L,221833L,234154L,246924L,260149L,273838L,288000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184538Inst : IEnumerable<long>
{
public static readonly long[] Value=A184538.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184538.Bytes);
public long this[int i]=>Value[i];

public static A184538Inst Instance=new A184538Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184539
{
public static readonly long[] Value={ 45L,193L,631L,1837L,5313L,16345L,54543L,194245L,719905L,2725367L,10430675L,40158073L,155173369L,601154073L,2333701711L,9075257125L,35345417073L,137846719279L,538258108483L,2104099248441L,8233431070825L,32247604093423L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184539Inst : IEnumerable<long>
{
public static readonly long[] Value=A184539.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184539.Bytes);
public long this[int i]=>Value[i];

public static A184539Inst Instance=new A184539Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184732
{
public static readonly long[] Value={ 1L,2L,4L,6L,7L,9L,11L,12L,14L,15L,17L,19L,20L,22L,24L,25L,27L,28L,30L,32L,33L,35L,36L,38L,40L,41L,43L,45L,46L,48L,49L,51L,53L,54L,56L,57L,59L,61L,62L,64L,66L,67L,69L,70L,72L,74L,75L,77L,79L,80L,82L,83L,85L,87L,88L,90L,91L,93L,95L,96L,98L,100L,101L,103L,104L,106L,108L,109L,111L,113L,114L,116L,117L,119L,121L,122L,124L,125L,127L,129L,130L,132L,134L,135L,137L,138L,140L,142L,143L,145L,146L,148L,150L,151L,153L,155L,156L,158L,159L,161L,163L,164L,166L,168L,169L,171L,172L,174L,176L,177L,179L,180L,182L,184L,185L,187L,189L,190L,192L,193L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184732Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184732.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184732Inst : IEnumerable<long>
{
public static readonly long[] Value=A184732.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184732.Bytes);
public long this[int i]=>Value[i];

public static A184732Inst Instance=new A184732Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184733
{
public static readonly long[] Value={ 3L,5L,8L,10L,13L,16L,18L,21L,23L,26L,29L,31L,34L,37L,39L,42L,44L,47L,50L,52L,55L,58L,60L,63L,65L,68L,71L,73L,76L,78L,81L,84L,86L,89L,92L,94L,97L,99L,102L,105L,107L,110L,112L,115L,118L,120L,123L,126L,128L,131L,133L,136L,139L,141L,144L,147L,149L,152L,154L,157L,160L,162L,165L,167L,170L,173L,175L,178L,181L,183L,186L,188L,191L,194L,196L,199L,201L,204L,207L,209L,212L,215L,217L,220L,222L,225L,228L,230L,233L,236L,238L,241L,243L,246L,249L,251L,254L,256L,259L,262L,264L,267L,270L,272L,275L,277L,280L,283L,285L,288L,291L,293L,296L,298L,301L,304L,306L,309L,311L,314L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184733Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184733.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184733Inst : IEnumerable<long>
{
public static readonly long[] Value=A184733.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184733.Bytes);
public long this[int i]=>Value[i];

public static A184733Inst Instance=new A184733Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184734
{
public static readonly long[] Value={ 1L,3L,5L,6L,8L,10L,11L,13L,14L,16L,18L,19L,21L,22L,24L,26L,27L,29L,31L,32L,34L,35L,37L,39L,40L,42L,44L,45L,47L,48L,50L,52L,53L,55L,56L,58L,60L,61L,63L,65L,66L,68L,69L,71L,73L,74L,76L,77L,79L,81L,82L,84L,86L,87L,89L,90L,92L,94L,95L,97L,99L,100L,102L,103L,105L,107L,108L,110L,111L,113L,115L,116L,118L,120L,121L,123L,124L,126L,128L,129L,131L,133L,134L,136L,137L,139L,141L,142L,144L,145L,147L,149L,150L,152L,154L,155L,157L,158L,160L,162L,163L,165L,166L,168L,170L,171L,173L,175L,176L,178L,179L,181L,183L,184L,186L,188L,189L,191L,192L,194L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184734Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184734.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184734Inst : IEnumerable<long>
{
public static readonly long[] Value=A184734.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184734.Bytes);
public long this[int i]=>Value[i];

public static A184734Inst Instance=new A184734Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184735
{
public static readonly long[] Value={ 2L,4L,7L,9L,12L,15L,17L,20L,23L,25L,28L,30L,33L,36L,38L,41L,43L,46L,49L,51L,54L,57L,59L,62L,64L,67L,70L,72L,75L,78L,80L,83L,85L,88L,91L,93L,96L,98L,101L,104L,106L,109L,112L,114L,117L,119L,122L,125L,127L,130L,132L,135L,138L,140L,143L,146L,148L,151L,153L,156L,159L,161L,164L,167L,169L,172L,174L,177L,180L,182L,185L,187L,190L,193L,195L,198L,201L,203L,206L,208L,211L,214L,216L,219L,221L,224L,227L,229L,232L,235L,237L,240L,242L,245L,248L,250L,253L,256L,258L,261L,263L,266L,269L,271L,274L,276L,279L,282L,284L,287L,290L,292L,295L,297L,300L,303L,305L,308L,311L,313L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184735Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184735.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184735Inst : IEnumerable<long>
{
public static readonly long[] Value=A184735.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184735.Bytes);
public long this[int i]=>Value[i];

public static A184735Inst Instance=new A184735Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184736
{
public static readonly long[] Value={ 1L,3L,4L,6L,8L,10L,12L,14L,15L,17L,19L,21L,23L,25L,26L,28L,30L,32L,34L,36L,37L,39L,41L,43L,45L,47L,48L,50L,52L,54L,56L,58L,59L,61L,63L,65L,67L,68L,70L,72L,74L,76L,78L,79L,81L,83L,85L,87L,89L,90L,92L,94L,96L,98L,100L,101L,103L,105L,107L,109L,111L,112L,114L,116L,118L,120L,122L,123L,125L,127L,129L,131L,132L,134L,136L,138L,140L,142L,143L,145L,147L,149L,151L,153L,154L,156L,158L,160L,162L,164L,165L,167L,169L,171L,173L,175L,176L,178L,180L,182L,184L,185L,187L,189L,191L,193L,195L,196L,198L,200L,202L,204L,206L,207L,209L,211L,213L,215L,217L,218L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184736Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184736.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184736Inst : IEnumerable<long>
{
public static readonly long[] Value=A184736.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184736.Bytes);
public long this[int i]=>Value[i];

public static A184736Inst Instance=new A184736Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184737
{
public static readonly long[] Value={ 2L,5L,7L,9L,11L,13L,16L,18L,20L,22L,24L,27L,29L,31L,33L,35L,38L,40L,42L,44L,46L,49L,51L,53L,55L,57L,60L,62L,64L,66L,69L,71L,73L,75L,77L,80L,82L,84L,86L,88L,91L,93L,95L,97L,99L,102L,104L,106L,108L,110L,113L,115L,117L,119L,121L,124L,126L,128L,130L,133L,135L,137L,139L,141L,144L,146L,148L,150L,152L,155L,157L,159L,161L,163L,166L,168L,170L,172L,174L,177L,179L,181L,183L,186L,188L,190L,192L,194L,197L,199L,201L,203L,205L,208L,210L,212L,214L,216L,219L,221L,223L,225L,227L,230L,232L,234L,236L,238L,241L,243L,245L,247L,250L,252L,254L,256L,258L,261L,263L,265L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184737Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184737.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184737Inst : IEnumerable<long>
{
public static readonly long[] Value=A184737.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184737.Bytes);
public long this[int i]=>Value[i];

public static A184737Inst Instance=new A184737Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184738
{
public static readonly long[] Value={ 1L,2L,4L,5L,6L,7L,9L,10L,11L,12L,14L,15L,16L,17L,19L,20L,21L,22L,23L,25L,26L,27L,28L,30L,31L,32L,33L,35L,36L,37L,38L,40L,41L,42L,43L,44L,46L,47L,48L,49L,51L,52L,53L,54L,56L,57L,58L,59L,61L,62L,63L,64L,66L,67L,68L,69L,70L,72L,73L,74L,75L,77L,78L,79L,80L,82L,83L,84L,85L,87L,88L,89L,90L,91L,93L,94L,95L,96L,98L,99L,100L,101L,103L,104L,105L,106L,108L,109L,110L,111L,112L,114L,115L,116L,117L,119L,120L,121L,122L,124L,125L,126L,127L,129L,130L,131L,132L,133L,135L,136L,137L,138L,140L,141L,142L,143L,145L,146L,147L,148L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184738Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184738.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184738Inst : IEnumerable<long>
{
public static readonly long[] Value=A184738.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184738.Bytes);
public long this[int i]=>Value[i];

public static A184738Inst Instance=new A184738Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184739
{
public static readonly long[] Value={ 3L,8L,13L,18L,24L,29L,34L,39L,45L,50L,55L,60L,65L,71L,76L,81L,86L,92L,97L,102L,107L,113L,118L,123L,128L,134L,139L,144L,149L,154L,160L,165L,170L,175L,181L,186L,191L,196L,202L,207L,212L,217L,223L,228L,233L,238L,243L,249L,254L,259L,264L,270L,275L,280L,285L,291L,296L,301L,306L,312L,317L,322L,327L,332L,338L,343L,348L,353L,359L,364L,369L,374L,380L,385L,390L,395L,401L,406L,411L,416L,422L,427L,432L,437L,442L,448L,453L,458L,463L,469L,474L,479L,484L,490L,495L,500L,505L,511L,516L,521L,526L,531L,537L,542L,547L,552L,558L,563L,568L,573L,579L,584L,589L,594L,600L,605L,610L,615L,620L,626L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184739Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184739.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184739Inst : IEnumerable<long>
{
public static readonly long[] Value=A184739.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184739.Bytes);
public long this[int i]=>Value[i];

public static A184739Inst Instance=new A184739Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184740
{
public static readonly long[] Value={ 1L,2L,4L,6L,8L,9L,11L,13L,14L,16L,18L,20L,21L,23L,25L,26L,28L,30L,32L,33L,35L,37L,39L,40L,42L,44L,45L,47L,49L,51L,52L,54L,56L,57L,59L,61L,63L,64L,66L,68L,69L,71L,73L,75L,76L,78L,80L,81L,83L,85L,87L,88L,90L,92L,94L,95L,97L,99L,100L,102L,104L,106L,107L,109L,111L,112L,114L,116L,118L,119L,121L,123L,124L,126L,128L,130L,131L,133L,135L,136L,138L,140L,142L,143L,145L,147L,148L,150L,152L,154L,155L,157L,159L,161L,162L,164L,166L,167L,169L,171L,173L,174L,176L,178L,179L,181L,183L,185L,186L,188L,190L,191L,193L,195L,197L,198L,200L,202L,203L,205L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184740Inst : IEnumerable<long>
{
public static readonly long[] Value=A184740.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184740.Bytes);
public long this[int i]=>Value[i];

public static A184740Inst Instance=new A184740Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184741
{
public static readonly long[] Value={ 3L,5L,7L,10L,12L,15L,17L,19L,22L,24L,27L,29L,31L,34L,36L,38L,41L,43L,46L,48L,50L,53L,55L,58L,60L,62L,65L,67L,70L,72L,74L,77L,79L,82L,84L,86L,89L,91L,93L,96L,98L,101L,103L,105L,108L,110L,113L,115L,117L,120L,122L,125L,127L,129L,132L,134L,137L,139L,141L,144L,146L,149L,151L,153L,156L,158L,160L,163L,165L,168L,170L,172L,175L,177L,180L,182L,184L,187L,189L,192L,194L,196L,199L,201L,204L,206L,208L,211L,213L,215L,218L,220L,223L,225L,227L,230L,232L,235L,237L,239L,242L,244L,247L,249L,251L,254L,256L,259L,261L,263L,266L,268L,271L,273L,275L,278L,280L,282L,285L,287L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184741Inst : IEnumerable<long>
{
public static readonly long[] Value=A184741.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184741.Bytes);
public long this[int i]=>Value[i];

public static A184741Inst Instance=new A184741Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184742
{
public static readonly long[] Value={ 1L,3L,4L,6L,8L,10L,11L,13L,15L,17L,18L,20L,22L,24L,26L,27L,29L,31L,33L,34L,36L,38L,40L,42L,43L,45L,47L,49L,50L,52L,54L,56L,57L,59L,61L,63L,65L,66L,68L,70L,72L,73L,75L,77L,79L,81L,82L,84L,86L,88L,89L,91L,93L,95L,96L,98L,100L,102L,104L,105L,107L,109L,111L,112L,114L,116L,118L,120L,121L,123L,125L,127L,128L,130L,132L,134L,135L,137L,139L,141L,143L,144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184742Inst : IEnumerable<long>
{
public static readonly long[] Value=A184742.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184742.Bytes);
public long this[int i]=>Value[i];

public static A184742Inst Instance=new A184742Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184743
{
public static readonly long[] Value={ 2L,5L,7L,9L,12L,14L,16L,19L,21L,23L,25L,28L,30L,32L,35L,37L,39L,41L,44L,46L,48L,51L,53L,55L,58L,60L,62L,64L,67L,69L,71L,74L,76L,78L,80L,83L,85L,87L,90L,92L,94L,97L,99L,101L,103L,106L,108L,110L,113L,115L,117L,119L,122L,124L,126L,129L,131L,133L,136L,138L,140L,142L,145L,147L,149L,152L,154L,156L,158L,161L,163L,165L,168L,170L,172L,175L,177L,179L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184743Inst : IEnumerable<long>
{
public static readonly long[] Value=A184743.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184743.Bytes);
public long this[int i]=>Value[i];

public static A184743Inst Instance=new A184743Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184744
{
public static readonly long[] Value={ 1L,3L,4L,5L,7L,8L,10L,11L,12L,14L,15L,16L,18L,19L,21L,22L,23L,25L,26L,27L,29L,30L,31L,33L,34L,36L,37L,38L,40L,41L,42L,44L,45L,47L,48L,49L,51L,52L,53L,55L,56L,57L,59L,60L,62L,63L,64L,66L,67L,68L,70L,71L,72L,74L,75L,77L,78L,79L,81L,82L,83L,85L,86L,88L,89L,90L,92L,93L,94L,96L,97L,98L,100L,101L,103L,104L,105L,107L,108L,109L,111L,112L,114L,115L,116L,118L,119L,120L,122L,123L,124L,126L,127L,129L,130L,131L,133L,134L,135L,137L,138L,140L,141L,142L,144L,145L,146L,148L,149L,150L,152L,153L,155L,156L,157L,159L,160L,161L,163L,164L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184744Inst : IEnumerable<long>
{
public static readonly long[] Value=A184744.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184744.Bytes);
public long this[int i]=>Value[i];

public static A184744Inst Instance=new A184744Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184745
{
public static readonly long[] Value={ 2L,6L,9L,13L,17L,20L,24L,28L,32L,35L,39L,43L,46L,50L,54L,58L,61L,65L,69L,73L,76L,80L,84L,87L,91L,95L,99L,102L,106L,110L,113L,117L,121L,125L,128L,132L,136L,139L,143L,147L,151L,154L,158L,162L,165L,169L,173L,177L,180L,184L,188L,191L,195L,199L,203L,206L,210L,214L,218L,221L,225L,229L,232L,236L,240L,244L,247L,251L,255L,258L,262L,266L,270L,273L,277L,281L,284L,288L,292L,296L,299L,303L,307L,310L,314L,318L,322L,325L,329L,333L,337L,340L,344L,348L,351L,355L,359L,363L,366L,370L,374L,377L,381L,385L,389L,392L,396L,400L,403L,407L,411L,415L,418L,422L,426L,429L,433L,437L,441L,444L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184745Inst : IEnumerable<long>
{
public static readonly long[] Value=A184745.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184745.Bytes);
public long this[int i]=>Value[i];

public static A184745Inst Instance=new A184745Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184746
{
public static readonly long[] Value={ 1L,3L,4L,6L,7L,9L,10L,12L,13L,14L,16L,17L,19L,20L,22L,23L,25L,26L,27L,29L,30L,32L,33L,35L,36L,38L,39L,41L,42L,43L,45L,46L,48L,49L,51L,52L,54L,55L,56L,58L,59L,61L,62L,64L,65L,67L,68L,69L,71L,72L,74L,75L,77L,78L,80L,81L,82L,84L,85L,87L,88L,90L,91L,93L,94L,96L,97L,98L,100L,101L,103L,104L,106L,107L,109L,110L,111L,113L,114L,116L,117L,119L,120L,122L,123L,124L,126L,127L,129L,130L,132L,133L,135L,136L,137L,139L,140L,142L,143L,145L,146L,148L,149L,151L,152L,153L,155L,156L,158L,159L,161L,162L,164L,165L,166L,168L,169L,171L,172L,174L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184746Inst : IEnumerable<long>
{
public static readonly long[] Value=A184746.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184746.Bytes);
public long this[int i]=>Value[i];

public static A184746Inst Instance=new A184746Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184747
{
public static readonly long[] Value={ 2L,5L,8L,11L,15L,18L,21L,24L,28L,31L,34L,37L,40L,44L,47L,50L,53L,57L,60L,63L,66L,70L,73L,76L,79L,83L,86L,89L,92L,95L,99L,102L,105L,108L,112L,115L,118L,121L,125L,128L,131L,134L,138L,141L,144L,147L,150L,154L,157L,160L,163L,167L,170L,173L,176L,180L,183L,186L,189L,193L,196L,199L,202L,205L,209L,212L,215L,218L,222L,225L,228L,231L,235L,238L,241L,244L,248L,251L,254L,257L,261L,264L,267L,270L,273L,277L,280L,283L,286L,290L,293L,296L,299L,303L,306L,309L,312L,316L,319L,322L,325L,328L,332L,335L,338L,341L,345L,348L,351L,354L,358L,361L,364L,367L,371L,374L,377L,380L,383L,387L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184747Inst : IEnumerable<long>
{
public static readonly long[] Value=A184747.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184747.Bytes);
public long this[int i]=>Value[i];

public static A184747Inst Instance=new A184747Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184828
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,3L,1L,13L,13L,1L,1L,1L,9L,3L,3L,11L,1L,1L,25L,25L,1L,3L,1L,13L,31L,1L,1L,3L,37L,1L,27L,1L,1L,7L,43L,5L,1L,1L,1L,1L,1L,17L,29L,1L,1L,1L,1L,3L,23L,5L,1L,45L,19L,19L,7L,31L,1L,5L,1L,1L,1L,43L,1L,31L,1L,5L,85L,85L,5L,1L,11L,43L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184828Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184828.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184828Inst : IEnumerable<long>
{
public static readonly long[] Value=A184828.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184828.Bytes);
public long this[int i]=>Value[i];

public static A184828Inst Instance=new A184828Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184829
{
public static readonly long[] Value={ 0L,0L,2L,3L,3L,2L,7L,7L,3L,5L,3L,3L,5L,3L,23L,5L,3L,2L,9L,11L,3L,13L,3L,5L,47L,3L,29L,61L,7L,3L,67L,7L,79L,7L,9L,31L,3L,9L,3L,5L,15L,9L,3L,2L,5L,25L,3L,43L,3L,29L,151L,53L,3L,5L,167L,3L,19L,3L,7L,3L,17L,199L,73L,3L,5L,227L,3L,239L,47L,6L,3L,251L,257L,3L,53L,7L,3L,277L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184829Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184829.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184829Inst : IEnumerable<long>
{
public static readonly long[] Value=A184829.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184829.Bytes);
public long this[int i]=>Value[i];

public static A184829Inst Instance=new A184829Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184830
{
public static readonly long[] Value={ 0L,0L,2L,3L,3L,6L,7L,7L,9L,10L,15L,15L,15L,21L,23L,25L,27L,30L,27L,33L,39L,39L,45L,45L,47L,57L,58L,61L,63L,69L,67L,77L,79L,77L,81L,93L,99L,99L,105L,105L,105L,117L,123L,126L,125L,125L,135L,129L,147L,145L,151L,159L,165L,165L,167L,177L,171L,189L,189L,195L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184830Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184830.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184830Inst : IEnumerable<long>
{
public static readonly long[] Value=A184830.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184830.Bytes);
public long this[int i]=>Value[i];

public static A184830Inst Instance=new A184830Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184831
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,3L,1L,1L,3L,2L,5L,5L,3L,7L,1L,5L,9L,15L,3L,3L,13L,3L,15L,9L,1L,19L,2L,1L,9L,23L,1L,11L,1L,11L,9L,3L,33L,11L,35L,21L,7L,13L,41L,63L,25L,5L,45L,3L,49L,5L,1L,3L,55L,33L,1L,59L,9L,63L,27L,65L,11L,1L,3L,75L,45L,1L,79L,1L,5L,41L,85L,1L,1L,89L,5L,39L,93L,1L,57L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184831Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184831.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184831Inst : IEnumerable<long>
{
public static readonly long[] Value=A184831.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184831.Bytes);
public long this[int i]=>Value[i];

public static A184831Inst Instance=new A184831Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184832
{
public static readonly long[] Value={ 0L,0L,0L,2L,5L,4L,3L,3L,2L,13L,13L,3L,17L,2L,3L,4L,23L,2L,29L,29L,2L,3L,3L,2L,37L,37L,2L,41L,4L,3L,43L,7L,3L,53L,2L,3L,3L,2L,59L,2L,5L,5L,2L,3L,3L,2L,71L,2L,7L,4L,3L,3L,2L,5L,5L,3L,89L,2L,3L,3L,31L,2L,101L,101L,2L,3L,3L,2L,109L,109L,2L,113L,4L,3L,4L,11L,7L,5L,2L,3L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184832Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184832.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184832Inst : IEnumerable<long>
{
public static readonly long[] Value=A184832.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184832.Bytes);
public long this[int i]=>Value[i];

public static A184832Inst Instance=new A184832Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184833
{
public static readonly long[] Value={ 0L,0L,0L,4L,5L,4L,9L,9L,12L,13L,13L,15L,17L,20L,21L,20L,23L,28L,29L,29L,32L,33L,33L,36L,37L,37L,40L,41L,40L,45L,43L,49L,51L,53L,56L,57L,57L,60L,59L,64L,65L,65L,68L,69L,69L,72L,71L,76L,77L,76L,81L,81L,84L,85L,85L,87L,89L,92L,93L,93L,93L,100L,101L,101L,104L,105L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184833Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184833.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184833Inst : IEnumerable<long>
{
public static readonly long[] Value=A184833.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184833.Bytes);
public long this[int i]=>Value[i];

public static A184833Inst Instance=new A184833Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184834
{
public static readonly long[] Value={ 0L,0L,0L,2L,1L,1L,3L,3L,6L,1L,1L,5L,1L,10L,7L,5L,1L,14L,1L,1L,16L,11L,11L,18L,1L,1L,20L,1L,10L,15L,1L,7L,17L,1L,28L,19L,19L,30L,1L,32L,13L,13L,34L,23L,23L,36L,1L,38L,11L,19L,27L,27L,42L,17L,17L,29L,1L,46L,31L,31L,3L,50L,1L,1L,52L,35L,35L,54L,1L,1L,56L,1L,28L,39L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184834Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184834.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184834Inst : IEnumerable<long>
{
public static readonly long[] Value=A184834.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184834.Bytes);
public long this[int i]=>Value[i];

public static A184834Inst Instance=new A184834Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184835
{
public static readonly long[] Value={ 1L,3L,4L,7L,8L,10L,11L,15L,16L,18L,19L,22L,23L,25L,27L,31L,32L,34L,35L,38L,39L,41L,43L,46L,47L,49L,50L,53L,54L,57L,60L,62L,63L,65L,67L,69L,70L,73L,75L,77L,78L,80L,82L,84L,86L,89L,91L,93L,94L,96L,98L,100L,101L,104L,106L,108L,109L,112L,114L,116L,119L,121L,123L,124L,126L,128L,130L,131L,134L,136L,138L,139L,141L,143L,146L,148L,150L,152L,154L,155L,157L,159L,161L,163L,165L,167L,169L,170L,173L,175L,177L,179L,182L,183L,185L,186L,189L,190L,193L,194L,197L,198L,200L,201L,205L,206L,209L,210L,213L,214L,216L,217L,220L,222L,224L,227L,228L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184835Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184835.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184835Inst : IEnumerable<long>
{
public static readonly long[] Value=A184835.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184835.Bytes);
public long this[int i]=>Value[i];

public static A184835Inst Instance=new A184835Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184836
{
public static readonly long[] Value={ 2L,6L,9L,14L,17L,21L,24L,30L,33L,37L,40L,45L,48L,52L,55L,61L,64L,68L,71L,76L,79L,83L,87L,92L,95L,99L,102L,107L,110L,113L,118L,122L,125L,129L,133L,137L,140L,145L,149L,153L,156L,160L,164L,168L,171L,176L,180L,184L,187L,191L,195L,199L,202L,207L,211L,215L,218L,223L,226L,229L,234L,238L,242L,245L,249L,253L,257L,260L,265L,269L,273L,276L,280L,284L,288L,292L,296L,300L,304L,307L,311L,315L,319L,323L,327L,331L,335L,338L,342L,345L,349L,353L,358L,361L,365L,368L,373L,376L,381L,384L,389L,392L,396L,399L,404L,407L,412L,415L,420L,423L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184836Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184836.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184836Inst : IEnumerable<long>
{
public static readonly long[] Value=A184836.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184836.Bytes);
public long this[int i]=>Value[i];

public static A184836Inst Instance=new A184836Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184837
{
public static readonly long[] Value={ 5L,13L,20L,29L,36L,44L,51L,59L,66L,74L,81L,90L,97L,105L,111L,120L,127L,135L,142L,151L,158L,166L,172L,181L,188L,196L,203L,212L,219L,225L,233L,241L,248L,256L,264L,272L,279L,286L,294L,302L,309L,317L,325L,333L,339L,347L,355L,363L,370L,378L,386L,393L,400L,408L,416L,424L,431L,440L,447L,453L,461L,469L,477L,484L,492L,500L,507L,514L,522L,530L,538L,545L,553L,561L,568L,575L,583L,591L,599L,606L,614L,621L,629L,636L,644L,652L,660L,667L,674L,681L,689L,696L,705L,712L,720L,727L,735L,742L,750L,757L,766L,773L,781L,787L,796L,803L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184837Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184837.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184837Inst : IEnumerable<long>
{
public static readonly long[] Value=A184837.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184837.Bytes);
public long this[int i]=>Value[i];

public static A184837Inst Instance=new A184837Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184838
{
public static readonly long[] Value={ 12L,28L,42L,58L,72L,88L,103L,117L,132L,147L,162L,178L,192L,208L,221L,237L,252L,267L,282L,297L,312L,328L,341L,357L,371L,387L,402L,417L,432L,445L,460L,476L,490L,506L,520L,536L,551L,565L,580L,595L,610L,626L,640L,656L,669L,685L,700L,715L,730L,745L,760L,775L,789L,805L,819L,835L,850L,865L,880L,893L,909L,924L,939L,954L,969L,984L,999L,1013L,1029L,1043L,1059L,1074L,1089L,1104L,1118L,1133L,1149L,1163L,1179L,1193L,1209L,1223L,1238L,1253L,1268L,1283L,1299L,1313L,1327L,1341L,1357L,1372L,1387L,1402L,1417L,1432L,1447L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184838Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184838.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184838Inst : IEnumerable<long>
{
public static readonly long[] Value=A184838.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184838.Bytes);
public long this[int i]=>Value[i];

public static A184838Inst Instance=new A184838Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184839
{
public static readonly long[] Value={ 26L,56L,85L,115L,144L,174L,204L,232L,262L,291L,321L,351L,380L,410L,438L,468L,497L,526L,556L,585L,615L,645L,673L,703L,732L,762L,792L,821L,851L,878L,908L,938L,966L,996L,1025L,1055L,1085L,1113L,1143L,1172L,1202L,1232L,1261L,1291L,1319L,1349L,1379L,1408L,1437L,1466L,1496L,1525L,1554L,1584L,1613L,1643L,1673L,1702L,1731L,1759L,1789L,1819L,1848L,1878L,1906L,1936L,1965L,1994L,2024L,2053L,2083L,2113L,2142L,2172L,2200L,2230L,2260L,2289L,2319L,2348L,2377L,2406L,2435L,2465L,2494L,2524L,2554L,2583L,2611L,2640L,2670L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184839Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184839.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184839Inst : IEnumerable<long>
{
public static readonly long[] Value=A184839.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184839.Bytes);
public long this[int i]=>Value[i];

public static A184839Inst Instance=new A184839Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184840
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,16L,76L,810L,10682L,203637L,3146155L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184840Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184840.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184840Inst : IEnumerable<long>
{
public static readonly long[] Value=A184840.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184840.Bytes);
public long this[int i]=>Value[i];

public static A184840Inst Instance=new A184840Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184841
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,7L,13L,25L,54L,122L,253L,558L,1199L,2596L,5619L,12049L,25695L,54733L,115830L,244106L,512444L,1070965L,2229313L,4622382L,9546244L,19639568L,40254273L,82200330L,167244370L,339055002L,684919569L,1378730235L,2765690543L,5528683663L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184841Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184841.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184841Inst : IEnumerable<long>
{
public static readonly long[] Value=A184841.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184841.Bytes);
public long this[int i]=>Value[i];

public static A184841Inst Instance=new A184841Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184842
{
public static readonly long[] Value={ 1L,1L,2L,2L,6L,10L,17L,45L,153L,561L,1670L,4780L,14974L,45555L,140211L,419924L,1245122L,3669858L,10724147L,31185503L,89840674L,256746801L,728672328L,2051488536L,5732076608L,15895090361L,43752447121L,119570863227L,324496444134L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184842Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184842.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184842Inst : IEnumerable<long>
{
public static readonly long[] Value=A184842.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184842.Bytes);
public long this[int i]=>Value[i];

public static A184842Inst Instance=new A184842Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184843
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,13L,33L,113L,433L,2358L,8535L,28389L,112039L,427748L,1769874L,6610091L,24128241L,90190764L,331582813L,1222929244L,4421062767L,15812600521L,56305580500L,198730488338L,696900040653L,2421645299793L,8352195108762L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184843Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184843.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184843Inst : IEnumerable<long>
{
public static readonly long[] Value=A184843.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184843.Bytes);
public long this[int i]=>Value[i];

public static A184843Inst Instance=new A184843Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185068
{
public static readonly long[] Value={ 0L,2L,2L,3L,4L,4L,1L,10L,5L,2L,2L,2L,20L,1L,1L,2L,1L,3L,2L,1L,3L,2L,2L,1L,26L,2L,3L,9L,2L,5L,2L,5L,1L,2L,3L,1L,1L,1L,1L,2L,1L,7L,4L,2L,1L,1L,1L,1L,2L,1L,5L,17L,9L,1L,31L,1L,4L,5L,5L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,6L,1L,10L,1L,3L,1L,4L,1L,1L,6L,5L,3L,2L,4L,1L,26L,1L,1L,1L,2L,3L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185068Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185068.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185068Inst : IEnumerable<long>
{
public static readonly long[] Value=A185068.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185068.Bytes);
public long this[int i]=>Value[i];

public static A185068Inst Instance=new A185068Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185069
{
public static readonly long[] Value={ 3L,13L,19L,31L,43L,67L,73L,79L,103L,109L,139L,181L,223L,283L,367L,397L,433L,439L,499L,607L,613L,619L,643L,787L,823L,829L,907L,1039L,1087L,1117L,1399L,1447L,1543L,1549L,1579L,1627L,1663L,1693L,1699L,1759L,1867L,1879L,1987L,2083L,2203L,2239L,2377L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185069Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185069.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185069Inst : IEnumerable<long>
{
public static readonly long[] Value=A185069.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185069.Bytes);
public long this[int i]=>Value[i];

public static A185069Inst Instance=new A185069Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185070
{
public static readonly long[] Value={ 1L,1L,4L,25L,2L,224L,32L,2625L,500L,38056L,8560L,40L,657433L,164150L,1960L,13178880L,3526656L,71680L,300585601L,84389928L,2442720L,2240L,7683776000L,2232672000L,83328000L,224000L,217534555161L,64830707370L,2931500880L,14907200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185070Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185070.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185070Inst : IEnumerable<long>
{
public static readonly long[] Value=A185070.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185070.Bytes);
public long this[int i]=>Value[i];

public static A185070Inst Instance=new A185070Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185071
{
public static readonly BigInteger[] Value={ 1L,1L,11L,311L,17401L,1605121L,221150291L,42544269431L,10895006389681L,3583312720242241L,1472043913711636571L,BigInteger.Parse("738696511605374082551"),BigInteger.Parse("444643435445854346001961"),BigInteger.Parse("316205489853515802822759361"),BigInteger.Parse("262279609103378710090568706851"),BigInteger.Parse("250969078703002751430687050751671") };
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
public class A185071Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185071.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185071Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A185071.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A185071.Bytes);
public BigInteger this[int i]=>Value[i];

public static A185071Inst Instance=new A185071Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185072
{
public static readonly BigInteger[] Value={ 1L,1L,-2L,6L,-28L,70L,-1446L,-22302L,-855032L,-33435486L,-1541257250L,-80299386706L,-4675923739764L,-300809006015466L,-21184444811987030L,-1620869900459370150L,BigInteger.Parse("-133878027649528854000"),BigInteger.Parse("-11872222666784936265342"),BigInteger.Parse("-1125045987661214982721602"),BigInteger.Parse("-113458738692543731877937418") };
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
public class A185072Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185072.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185072Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A185072.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A185072.Bytes);
public BigInteger this[int i]=>Value[i];

public static A185072Inst Instance=new A185072Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A185073
{
public static readonly long[] Value={ 13L,1493L,5851L,6379L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A185073Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A185073.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A185073Inst : IEnumerable<long>
{
public static readonly long[] Value=A185073.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A185073.Bytes);
public long this[int i]=>Value[i];

public static A185073Inst Instance=new A185073Inst();

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