using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A064845
{
public static readonly BigInteger[] Value={ 1L,1L,2L,5L,31L,1231L,1917121L,4667676800641L,BigInteger.Parse("27640053867460068128570881"),BigInteger.Parse("969475805641849161579046591814284573846079748476161") };
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
public class A064845Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064845.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064845Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A064845.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A064845.Bytes);
public BigInteger this[int i]=>Value[i];

public static A064845Inst Instance=new A064845Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064846
{
public static readonly BigInteger[] Value={ 1L,1L,1L,3L,18L,720L,1119600L,2726809311600L,BigInteger.Parse("16145931379144511904735600"),BigInteger.Parse("566327308576692897981544319968226968281922500063600") };
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
public class A064846Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064846.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064846Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A064846.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A064846.Bytes);
public BigInteger this[int i]=>Value[i];

public static A064846Inst Instance=new A064846Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064847
{
public static readonly BigInteger[] Value={ 1L,1L,2L,6L,30L,330L,13530L,5019630L,69777876630L,351229105131280530L,BigInteger.Parse("24509789089304573335878465330"),BigInteger.Parse("8608552999157278550998626549630446732052243030") };
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
public class A064847Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064847.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064847Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A064847.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A064847.Bytes);
public BigInteger this[int i]=>Value[i];

public static A064847Inst Instance=new A064847Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064848
{
public static readonly long[] Value={ 1L,2L,2L,4L,1L,2L,4L,4L,10L,2L,10L,2L,5L,4L,8L,12L,2L,6L,14L,8L,8L,6L,16L,4L,13L,10L,26L,8L,1L,8L,24L,24L,6L,2L,2L,6L,15L,18L,16L,20L,4L,8L,30L,6L,10L,16L,28L,8L,36L,22L,2L,20L,19L,30L,10L,12L,14L,2L,14L,8L,25L,20L,4L,48L,13L,6L,54L,2L,32L,2L,52L,16L,30L,26L,40L,10L,6L,16L,20L,36L,78L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064848Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064848.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064848Inst : IEnumerable<long>
{
public static readonly long[] Value=A064848.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064848.Bytes);
public long this[int i]=>Value[i];

public static A064848Inst Instance=new A064848Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064849
{
public static readonly long[] Value={ 2L,2L,2L,2L,4L,8L,2L,4L,10L,4L,2L,8L,6L,2L,2L,8L,6L,20L,4L,8L,14L,8L,8L,12L,16L,2L,30L,2L,16L,4L,18L,16L,10L,20L,16L,20L,18L,8L,6L,12L,2L,12L,8L,8L,6L,20L,20L,20L,30L,36L,6L,2L,8L,68L,14L,2L,16L,32L,22L,4L,38L,18L,40L,36L,6L,28L,10L,20L,40L,8L,4L,40L,18L,22L,16L,12L,28L,2L,46L,20L,98L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064849Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064849.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064849Inst : IEnumerable<long>
{
public static readonly long[] Value=A064849.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064849.Bytes);
public long this[int i]=>Value[i];

public static A064849Inst Instance=new A064849Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064850
{
public static readonly long[] Value={ 1L,2L,6L,2L,5L,4L,10L,4L,2L,14L,12L,4L,5L,10L,28L,8L,1L,2L,4L,14L,6L,8L,6L,4L,31L,14L,10L,12L,12L,20L,8L,20L,20L,2L,52L,2L,19L,4L,28L,24L,18L,8L,50L,12L,28L,6L,10L,4L,70L,62L,8L,18L,7L,10L,6L,8L,8L,12L,72L,20L,3L,12L,8L,36L,41L,28L,86L,2L,6L,44L,84L,2L,43L,42L,120L,4L,52L,36L,28L,44L,38L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064850Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064850.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064850Inst : IEnumerable<long>
{
public static readonly long[] Value=A064850.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064850.Bytes);
public long this[int i]=>Value[i];

public static A064850Inst Instance=new A064850Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064851
{
public static readonly long[] Value={ 2L,2L,6L,4L,2L,6L,6L,8L,2L,2L,4L,12L,16L,6L,12L,12L,22L,2L,18L,2L,24L,4L,20L,20L,18L,12L,10L,8L,22L,8L,26L,32L,4L,14L,8L,8L,40L,10L,40L,4L,34L,16L,38L,8L,8L,16L,40L,44L,2L,14L,10L,24L,50L,10L,12L,4L,18L,22L,22L,8L,56L,26L,20L,60L,32L,4L,58L,24L,60L,4L,68L,20L,34L,40L,58L,24L,28L,44L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064851Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064851.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064851Inst : IEnumerable<long>
{
public static readonly long[] Value=A064851.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064851.Bytes);
public long this[int i]=>Value[i];

public static A064851Inst Instance=new A064851Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064852
{
public static readonly long[] Value={ 1L,0L,0L,1L,4L,18L,102L,624L,4476L,36248L,329890L,3326054L,36846276L,444783906L,5811885808L,81729607680L,1230752346352L,19760412095328L,336967037143578L,6082255011151724L,115852476579789984L,2322315553090615850L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064852Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064852.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064852Inst : IEnumerable<long>
{
public static readonly long[] Value=A064852.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064852.Bytes);
public long this[int i]=>Value[i];

public static A064852Inst Instance=new A064852Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064853
{
public static readonly long[] Value={ 5L,2L,4L,4L,1L,1L,5L,1L,0L,8L,5L,8L,4L,2L,3L,9L,6L,2L,0L,9L,2L,9L,6L,7L,9L,1L,7L,9L,7L,8L,2L,2L,3L,8L,8L,2L,7L,3L,6L,5L,5L,0L,9L,9L,0L,2L,8L,6L,3L,2L,4L,6L,3L,2L,5L,6L,3L,3L,6L,4L,3L,4L,0L,7L,6L,0L,1L,5L,8L,1L,1L,7L,4L,1L,4L,0L,8L,2L,8L,5L,0L,0L,4L,6L,0L,5L,9L,1L,0L,6L,5L,9L,2L,2L,8L,5L,8L,1L,8L,6L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064853Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064853.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064853Inst : IEnumerable<long>
{
public static readonly long[] Value=A064853.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064853.Bytes);
public long this[int i]=>Value[i];

public static A064853Inst Instance=new A064853Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064854
{
public static readonly long[] Value={ 1L,0L,7L,0L,21L,37L,118L,56L,19L,428L,808L,3920L,2256L,15240L,28312L,46733L,128931L,251439L,434788L,645833L,1397733L,1179155L,7185704L,1551886L,33308648L,65879944L,121274199L,65829274L,228529703L,248939750L,799831532L,2835988891L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064854Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064854.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064854Inst : IEnumerable<long>
{
public static readonly long[] Value=A064854.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064854.Bytes);
public long this[int i]=>Value[i];

public static A064854Inst Instance=new A064854Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064855
{
public static readonly long[] Value={ 1L,2L,0L,14L,16L,10L,66L,21L,321L,917L,2037L,1550L,2420L,15152L,27439L,46731L,110953L,137148L,336949L,703202L,805647L,181132L,5835407L,3343039L,21816283L,18528238L,95129681L,241918238L,311938330L,48698222L,1539688558L,3481498150L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064855Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064855.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064855Inst : IEnumerable<long>
{
public static readonly long[] Value=A064855.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064855.Bytes);
public long this[int i]=>Value[i];

public static A064855Inst Instance=new A064855Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064856
{
public static readonly BigInteger[] Value={ 1L,1L,3L,12L,59L,338L,2185L,15613L,121553L,1020170L,9154963L,87276995L,879242215L,9319182044L,103537712361L,1201967382478L,14540040004755L,182840037042560L,2384985091689409L,32209645344213417L,449608555748234353L,6476887237235672388L,BigInteger.Parse("96156363230696213447") };
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
public class A064856Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064856.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064856Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A064856.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A064856.Bytes);
public BigInteger this[int i]=>Value[i];

public static A064856Inst Instance=new A064856Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064857
{
public static readonly long[] Value={ 1L,3L,5L,7L,53L,107L,25L,1501L,563L,901L,12389L,16519L,322121L,644243L,53687L,1288489L,3650719L,4380863L,18917363L,3557111L,104045497L,416181989L,2393046437L,455818369L,23930464373L,47860928747L,10255913303L,11044829711L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064857Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064857.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064857Inst : IEnumerable<long>
{
public static readonly long[] Value=A064857.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064857.Bytes);
public long this[int i]=>Value[i];

public static A064857Inst Instance=new A064857Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064858
{
public static readonly long[] Value={ 1L,2L,3L,4L,30L,60L,14L,840L,315L,504L,6930L,9240L,180180L,360360L,30030L,720720L,2042040L,2450448L,10581480L,1989680L,58198140L,232792560L,1338557220L,254963280L,13385572200L,26771144400L,5736673800L,6177956400L,291136195350L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064858Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064858.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064858Inst : IEnumerable<long>
{
public static readonly long[] Value=A064858.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064858.Bytes);
public long this[int i]=>Value[i];

public static A064858Inst Instance=new A064858Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064859
{
public static readonly long[] Value={ 1L,7L,8L,7L,7L,8L,0L,4L,5L,6L,1L,7L,2L,4L,6L,6L,5L,4L,6L,0L,6L,4L,9L,3L,4L,3L,2L,6L,0L,2L,5L,6L,6L,2L,7L,9L,4L,5L,9L,3L,9L,6L,1L,7L,4L,7L,2L,9L,6L,9L,6L,0L,8L,3L,7L,2L,5L,3L,0L,2L,6L,9L,9L,2L,9L,2L,2L,8L,9L,0L,2L,3L,5L,0L,8L,2L,2L,3L,2L,6L,1L,5L,5L,2L,8L,3L,3L,6L,8L,7L,8L,0L,8L,5L,6L,9L,7L,9L,7L,9L,9L,4L,6L,9L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064859Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064859.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064859Inst : IEnumerable<long>
{
public static readonly long[] Value=A064859.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064859.Bytes);
public long this[int i]=>Value[i];

public static A064859Inst Instance=new A064859Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064860
{
public static readonly long[] Value={ 4L,4L,2L,6L,6L,4L,16L,2L,6L,16L,10L,4L,14L,32L,6L,2L,4L,16L,14L,12L,24L,10L,14L,2L,26L,24L,22L,36L,38L,12L,24L,8L,14L,8L,52L,8L,34L,32L,14L,16L,52L,32L,46L,14L,2L,14L,52L,2L,120L,64L,4L,32L,50L,44L,12L,32L,18L,34L,58L,12L,70L,52L,48L,12L,50L,18L,66L,8L,14L,96L,18L,8L,64L,42L,30L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064860Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064860.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064860Inst : IEnumerable<long>
{
public static readonly long[] Value=A064860.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064860.Bytes);
public long this[int i]=>Value[i];

public static A064860Inst Instance=new A064860Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064861
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,2L,1L,5L,8L,4L,1L,6L,13L,12L,4L,1L,8L,25L,38L,28L,8L,1L,9L,33L,63L,66L,36L,8L,1L,11L,51L,129L,192L,168L,80L,16L,1L,12L,62L,180L,321L,360L,248L,96L,16L,1L,14L,86L,304L,681L,1002L,968L,592L,208L,32L,1L,15L,100L,390L,985L,1683L,1970L,1560L,800L,240L,32L,1L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064861Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064861.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064861Inst : IEnumerable<long>
{
public static readonly long[] Value=A064861.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064861.Bytes);
public long this[int i]=>Value[i];

public static A064861Inst Instance=new A064861Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064862
{
public static readonly long[] Value={ 1L,2L,2L,8L,7L,2L,10L,12L,8L,18L,18L,4L,4L,10L,14L,24L,11L,8L,2L,28L,12L,18L,38L,8L,39L,8L,32L,12L,23L,14L,44L,48L,18L,26L,60L,12L,1L,2L,4L,60L,30L,12L,60L,18L,38L,34L,74L,20L,86L,74L,30L,20L,36L,28L,96L,8L,2L,38L,30L,28L,45L,44L,28L,100L,54L,24L,36L,44L,34L,60L,104L,28L,47L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064862Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064862.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064862Inst : IEnumerable<long>
{
public static readonly long[] Value=A064862.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064862.Bytes);
public long this[int i]=>Value[i];

public static A064862Inst Instance=new A064862Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064863
{
public static readonly long[] Value={ 2L,8L,2L,4L,6L,4L,8L,8L,8L,2L,26L,4L,20L,16L,4L,16L,26L,12L,2L,2L,8L,52L,26L,8L,26L,40L,28L,12L,28L,2L,38L,40L,38L,40L,12L,12L,46L,8L,20L,8L,46L,12L,50L,64L,8L,30L,58L,12L,52L,18L,22L,40L,62L,40L,60L,32L,2L,68L,26L,2L,72L,42L,4L,80L,40L,64L,46L,48L,34L,8L,22L,20L,90L,34L,22L,8L,90L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064863Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064863.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064863Inst : IEnumerable<long>
{
public static readonly long[] Value=A064863.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064863.Bytes);
public long this[int i]=>Value[i];

public static A064863Inst Instance=new A064863Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064864
{
public static readonly long[] Value={ 5L,6L,6L,6L,1L,8L,22L,12L,4L,2L,10L,4L,35L,20L,2L,24L,22L,4L,58L,2L,24L,10L,60L,8L,11L,74L,12L,24L,19L,2L,98L,48L,6L,26L,24L,4L,43L,58L,86L,8L,17L,16L,32L,12L,2L,64L,42L,16L,174L,26L,22L,90L,68L,12L,12L,20L,62L,30L,10L,2L,20L,98L,24L,92L,47L,8L,206L,26L,56L,28L,70L,8L,93L,98L,26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064864Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064864.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064864Inst : IEnumerable<long>
{
public static readonly long[] Value=A064864.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064864.Bytes);
public long this[int i]=>Value[i];

public static A064864Inst Instance=new A064864Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064865
{
public static readonly long[] Value={ 1L,2L,1L,5L,1L,7L,14L,6L,15L,25L,11L,23L,36L,14L,29L,45L,13L,31L,50L,6L,27L,49L,72L,15L,40L,66L,93L,21L,50L,80L,111L,22L,55L,89L,124L,16L,53L,91L,130L,1L,42L,84L,127L,171L,20L,66L,113L,161L,210L,35L,86L,138L,191L,245L,44L,100L,157L,215L,274L,45L,106L,168L,231L,295L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064865Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064865.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064865Inst : IEnumerable<long>
{
public static readonly long[] Value=A064865.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064865.Bytes);
public long this[int i]=>Value[i];

public static A064865Inst Instance=new A064865Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064866
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,1L,2L,3L,4L,5L,6L,7L,8L,9L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064866Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064866.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064866Inst : IEnumerable<long>
{
public static readonly long[] Value=A064866.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064866.Bytes);
public long this[int i]=>Value[i];

public static A064866Inst Instance=new A064866Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064867
{
public static readonly long[] Value={ 26L,63L,68L,23L,27L,31L,35L,39L,43L,46L,50L,54L,58L,62L,66L,69L,73L,77L,81L,85L,89L,92L,96L,100L,104L,108L,112L,115L,119L,123L,127L,131L,135L,138L,142L,146L,150L,154L,158L,161L,165L,169L,173L,177L,181L,184L,188L,192L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064867Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064867.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064867Inst : IEnumerable<long>
{
public static readonly long[] Value=A064867.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064867.Bytes);
public long this[int i]=>Value[i];

public static A064867Inst Instance=new A064867Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064868
{
public static readonly long[] Value={ 2344L,172L,131L,174L,52L,77L,75L,83L,75L,81L,89L,95L,101L,104L,110L,133L,143L,127L,133L,119L,124L,129L,134L,139L,144L,149L,154L,159L,164L,169L,174L,179L,184L,189L,194L,199L,204L,209L,214L,219L,224L,229L,234L,238L,243L,248L,253L,258L,263L,268L,273L,278L,283L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064868Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064868.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064868Inst : IEnumerable<long>
{
public static readonly long[] Value=A064868.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064868.Bytes);
public long this[int i]=>Value[i];

public static A064868Inst Instance=new A064868Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064869
{
public static readonly long[] Value={ 244140624L,3629L,1601L,1535L,394L,679L,317L,1099L,127L,135L,582L,187L,168L,157L,201L,159L,230L,215L,180L,185L,246L,181L,188L,195L,198L,323L,239L,255L,259L,267L,239L,287L,295L,293L,310L,313L,280L,377L,375L,395L,347L,360L,321L,370L,439L,431L,458L,355L,362L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064869Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064869.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064869Inst : IEnumerable<long>
{
public static readonly long[] Value=A064869.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064869.Bytes);
public long this[int i]=>Value[i];

public static A064869Inst Instance=new A064869Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064870
{
public static readonly long[] Value={ 11262L,57596799L,30536L,6788L,4684L,1571L,439L,667L,1964L,683L,218L,857L,264L,278L,353L,393L,227L,382L,344L,311L,319L,307L,283L,417L,422L,381L,485L,436L,349L,431L,436L,449L,421L,469L,327L,575L,598L,483L,539L,413L,511L,517L,534L,641L,611L,609L,476L,479L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064870Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064870.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064870Inst : IEnumerable<long>
{
public static readonly long[] Value=A064870.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064870.Bytes);
public long this[int i]=>Value[i];

public static A064870Inst Instance=new A064870Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064871
{
public static readonly long[] Value={ 1409794L,68889L,38200L,17902874277L,1494L,2532L,19526L,15838L,1101L,15820L,943L,2674L,2118L,3275L,412L,3310L,1593L,440L,478L,2036L,456L,713L,738L,633L,658L,705L,907L,643L,803L,641L,653L,797L,484L,991L,814L,877L,1079L,767L,840L,575L,930L,843L,710L,880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064871Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064871.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064871Inst : IEnumerable<long>
{
public static readonly long[] Value=A064871.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064871.Bytes);
public long this[int i]=>Value[i];

public static A064871Inst Instance=new A064871Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064872
{
public static readonly long[] Value={ 7577L,130883L,596667L,3644381L,2820L,61773L,2752L,5136L,7452L,38631L,2780L,8015L,2996L,542L,8611L,4591L,575L,10586L,2532L,2681L,2764L,1016L,4547L,10151L,1065L,983L,813L,5431L,900L,1255L,983L,5179L,5117L,1190L,982L,1129L,1501L,1491L,1471L,1084L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064872Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064872.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064872Inst : IEnumerable<long>
{
public static readonly long[] Value=A064872.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064872.Bytes);
public long this[int i]=>Value[i];

public static A064872Inst Instance=new A064872Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064873
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064873Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064873.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064873Inst : IEnumerable<long>
{
public static readonly long[] Value=A064873.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064873.Bytes);
public long this[int i]=>Value[i];

public static A064873Inst Instance=new A064873Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064874
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,0L,1L,1L,0L,0L,0L,1L,2L,0L,1L,1L,0L,0L,0L,1L,0L,1L,2L,2L,2L,0L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,0L,0L,1L,1L,0L,0L,1L,3L,2L,0L,1L,1L,4L,0L,0L,1L,0L,0L,1L,1L,2L,2L,0L,1L,1L,0L,1L,1L,0L,0L,1L,3L,0L,1L,3L,3L,0L,0L,0L,1L,2L,2L,2L,2L,0L,0L,0L,1L,2L,0L,1L,1L,4L,0L,0L,1L,1L,2L,2L,2L,4L,0L,0L,1L,0L,0L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064874Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064874.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064874Inst : IEnumerable<long>
{
public static readonly long[] Value=A064874.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064874.Bytes);
public long this[int i]=>Value[i];

public static A064874Inst Instance=new A064874Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064875
{
public static readonly long[] Value={ 0L,0L,1L,1L,0L,1L,1L,1L,2L,0L,1L,1L,2L,2L,2L,2L,0L,1L,3L,3L,2L,2L,3L,3L,2L,0L,1L,1L,1L,2L,2L,2L,4L,4L,3L,3L,0L,1L,1L,1L,2L,4L,4L,3L,2L,3L,3L,3L,4L,0L,1L,1L,4L,2L,2L,2L,4L,2L,3L,3L,3L,5L,5L,5L,0L,1L,1L,3L,2L,2L,5L,5L,6L,3L,5L,5L,6L,3L,5L,5L,4L,0L,1L,1L,4L,2L,2L,2L,6L,5L,3L,3L,3L,5L,3L,3L,4L,4L,7L,7L,0L,1L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064875Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064875.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064875Inst : IEnumerable<long>
{
public static readonly long[] Value=A064875.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064875.Bytes);
public long this[int i]=>Value[i];

public static A064875Inst Instance=new A064875Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064876
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,2L,2L,2L,2L,3L,3L,3L,2L,3L,3L,3L,4L,4L,3L,3L,4L,4L,3L,3L,4L,5L,5L,5L,5L,5L,5L,5L,4L,4L,5L,5L,6L,6L,6L,6L,6L,5L,5L,5L,6L,6L,6L,6L,4L,7L,7L,7L,6L,7L,7L,7L,6L,7L,7L,7L,7L,6L,6L,6L,8L,8L,8L,7L,8L,8L,6L,6L,6L,8L,7L,7L,6L,8L,7L,7L,8L,9L,9L,9L,8L,9L,9L,9L,6L,8L,9L,9L,9L,8L,9L,9L,8L,9L,7L,7L,10L,10L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064876Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064876.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064876Inst : IEnumerable<long>
{
public static readonly long[] Value=A064876.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064876.Bytes);
public long this[int i]=>Value[i];

public static A064876Inst Instance=new A064876Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064877
{
public static readonly long[] Value={ 0L,0L,0L,0L,2L,2L,2L,2L,4L,6L,6L,6L,6L,8L,8L,8L,12L,12L,12L,12L,14L,14L,14L,14L,16L,20L,20L,20L,20L,22L,22L,22L,24L,24L,26L,26L,30L,30L,30L,30L,32L,32L,32L,32L,34L,36L,36L,36L,36L,42L,42L,42L,42L,44L,44L,44L,44L,46L,48L,48L,48L,50L,50L,50L,56L,56L,56L,54L,58L,58L,56L,56L,60L,62L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064877Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064877.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064877Inst : IEnumerable<long>
{
public static readonly long[] Value=A064877.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064877.Bytes);
public long this[int i]=>Value[i];

public static A064877Inst Instance=new A064877Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064878
{
public static readonly BigInteger[] Value={ 1L,1L,20L,2300L,464000L,116250000L,32580600000L,9779307000000L,3074524280000000L,999451946900000000L,BigInteger.Parse("333207298730000000000"),BigInteger.Parse("113305219025110000000000"),BigInteger.Parse("39145823948711200000000000") };
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
public class A064878Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064878.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064878Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A064878.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A064878.Bytes);
public BigInteger this[int i]=>Value[i];

public static A064878Inst Instance=new A064878Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064879
{
public static readonly long[] Value={ 1L,1L,1L,0L,1L,1L,0L,2L,1L,1L,0L,5L,4L,1L,1L,0L,14L,28L,6L,1L,1L,0L,42L,256L,81L,8L,1L,1L,0L,132L,2704L,1566L,176L,10L,1L,1L,0L,429L,31168L,36126L,5888L,325L,12L,1L,1L,0L,1430L,380608L,921456L,238848L,16750L,540L,14L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064879Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064879.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064879Inst : IEnumerable<long>
{
public static readonly long[] Value=A064879.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064879.Bytes);
public long this[int i]=>Value[i];

public static A064879Inst Instance=new A064879Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064880
{
public static readonly BigInteger[] Value={ 1L,2L,2L,4L,11L,50L,389L,4590L,73950L,1559648L,41768100L,1372257648L,53854228438L,2482184155472L,132554850677690L,8096323604940164L,559278345518698923L,BigInteger.Parse("43305732768029924394"),BigInteger.Parse("3731115433469990603265") };
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
public class A064880Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064880.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064880Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A064880.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A064880.Bytes);
public BigInteger this[int i]=>Value[i];

public static A064880Inst Instance=new A064880Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064881
{
public static readonly long[] Value={ 1L,2L,1L,3L,2L,1L,4L,3L,5L,2L,1L,5L,4L,7L,3L,8L,5L,7L,2L,1L,6L,5L,9L,4L,11L,7L,10L,3L,11L,8L,13L,5L,12L,7L,9L,2L,1L,7L,6L,11L,5L,14L,9L,13L,4L,15L,11L,18L,7L,17L,10L,13L,3L,14L,11L,19L,8L,21L,13L,18L,5L,17L,12L,19L,7L,16L,9L,11L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064881Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064881.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064881Inst : IEnumerable<long>
{
public static readonly long[] Value=A064881.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064881.Bytes);
public long this[int i]=>Value[i];

public static A064881Inst Instance=new A064881Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064882
{
public static readonly long[] Value={ 2L,1L,2L,3L,1L,2L,5L,3L,4L,1L,2L,7L,5L,8L,3L,7L,4L,5L,1L,2L,9L,7L,12L,5L,13L,8L,11L,3L,10L,7L,11L,4L,9L,5L,6L,1L,2L,11L,9L,16L,7L,19L,12L,17L,5L,18L,13L,21L,8L,19L,11L,14L,3L,13L,10L,17L,7L,18L,11L,15L,4L,13L,9L,14L,5L,11L,6L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064882Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064882.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064882Inst : IEnumerable<long>
{
public static readonly long[] Value=A064882.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064882.Bytes);
public long this[int i]=>Value[i];

public static A064882Inst Instance=new A064882Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064883
{
public static readonly long[] Value={ 1L,3L,1L,4L,3L,1L,5L,4L,7L,3L,1L,6L,5L,9L,4L,11L,7L,10L,3L,1L,7L,6L,11L,5L,14L,9L,13L,4L,15L,11L,18L,7L,17L,10L,13L,3L,1L,8L,7L,13L,6L,17L,11L,16L,5L,19L,14L,23L,9L,22L,13L,17L,4L,19L,15L,26L,11L,29L,18L,25L,7L,24L,17L,27L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064883Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064883.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064883Inst : IEnumerable<long>
{
public static readonly long[] Value=A064883.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064883.Bytes);
public long this[int i]=>Value[i];

public static A064883Inst Instance=new A064883Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064884
{
public static readonly long[] Value={ 3L,1L,3L,4L,1L,3L,7L,4L,5L,1L,3L,10L,7L,11L,4L,9L,5L,6L,1L,3L,13L,10L,17L,7L,18L,11L,15L,4L,13L,9L,14L,5L,11L,6L,7L,1L,3L,16L,13L,23L,10L,27L,17L,24L,7L,25L,18L,29L,11L,26L,15L,19L,4L,17L,13L,22L,9L,23L,14L,19L,5L,16L,11L,17L,6L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064884Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064884.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064884Inst : IEnumerable<long>
{
public static readonly long[] Value=A064884.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064884.Bytes);
public long this[int i]=>Value[i];

public static A064884Inst Instance=new A064884Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064885
{
public static readonly long[] Value={ 3L,2L,3L,5L,2L,3L,8L,5L,7L,2L,3L,11L,8L,13L,5L,12L,7L,9L,2L,3L,14L,11L,19L,8L,21L,13L,18L,5L,17L,12L,19L,7L,16L,9L,11L,2L,3L,17L,14L,25L,11L,30L,19L,27L,8L,29L,21L,34L,13L,31L,18L,23L,5L,22L,17L,29L,12L,31L,19L,26L,7L,23L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064885Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064885.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064885Inst : IEnumerable<long>
{
public static readonly long[] Value=A064885.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064885.Bytes);
public long this[int i]=>Value[i];

public static A064885Inst Instance=new A064885Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064886
{
public static readonly long[] Value={ 2L,3L,2L,5L,3L,2L,7L,5L,8L,3L,2L,9L,7L,12L,5L,13L,8L,11L,3L,2L,11L,9L,16L,7L,19L,12L,17L,5L,18L,13L,21L,8L,19L,11L,14L,3L,2L,13L,11L,20L,9L,25L,16L,23L,7L,26L,19L,31L,12L,29L,17L,22L,5L,23L,18L,31L,13L,34L,21L,29L,8L,27L,19L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064886Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064886.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064886Inst : IEnumerable<long>
{
public static readonly long[] Value=A064886.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064886.Bytes);
public long this[int i]=>Value[i];

public static A064886Inst Instance=new A064886Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064887
{
public static readonly long[] Value={ 4L,2L,4L,2L,6L,4L,16L,4L,14L,4L,10L,4L,18L,28L,2L,8L,28L,14L,22L,4L,40L,10L,10L,4L,26L,18L,50L,24L,6L,2L,4L,20L,32L,28L,40L,16L,50L,30L,14L,4L,20L,40L,54L,18L,10L,14L,52L,8L,136L,22L,48L,20L,70L,54L,32L,44L,30L,2L,78L,2L,22L,4L,128L,48L,14L,28L,82L,28L,14L,36L,22L,12L,112L,58L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064887Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064887.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064887Inst : IEnumerable<long>
{
public static readonly long[] Value=A064887.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064887.Bytes);
public long this[int i]=>Value[i];

public static A064887Inst Instance=new A064887Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064888
{
public static readonly long[] Value={ 1L,2L,3L,23L,323L,647L,971L,7121L,6943L,185147L,363173L,179407463L,412637165L,20631858251L,140035237L,3716297449L,27822060851939L,2853544702763L,58823785801243L,568431869527163L,279209361758899949L,4944838261875010691L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064888Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064888.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064888Inst : IEnumerable<long>
{
public static readonly long[] Value=A064888.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064888.Bytes);
public long this[int i]=>Value[i];

public static A064888Inst Instance=new A064888Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064889
{
public static readonly long[] Value={ 1L,2L,3L,4L,30L,420L,840L,1260L,9240L,9009L,240240L,471240L,232792560L,535422888L,26771144400L,181704600L,4822131600L,36100888223400L,3702655202400L,76327592243760L,737576396429600L,362291852261631600L,6416241209619040800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064889Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064889.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064889Inst : IEnumerable<long>
{
public static readonly long[] Value=A064889.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064889.Bytes);
public long this[int i]=>Value[i];

public static A064889Inst Instance=new A064889Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064890
{
public static readonly long[] Value={ 1L,7L,7L,0L,6L,7L,5L,2L,4L,4L,3L,2L,5L,5L,8L,0L,2L,2L,7L,9L,1L,9L,7L,9L,6L,0L,0L,7L,6L,4L,2L,6L,6L,0L,8L,0L,2L,2L,3L,3L,1L,8L,3L,7L,6L,7L,2L,7L,2L,8L,3L,3L,5L,2L,0L,5L,2L,2L,4L,5L,8L,9L,6L,4L,4L,1L,2L,2L,2L,0L,3L,3L,8L,1L,0L,2L,2L,9L,6L,1L,1L,0L,5L,6L,5L,0L,7L,0L,5L,7L,7L,5L,7L,0L,8L,0L,9L,3L,4L,0L,3L,3L,3L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064890Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064890.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064890Inst : IEnumerable<long>
{
public static readonly long[] Value=A064890.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064890.Bytes);
public long this[int i]=>Value[i];

public static A064890Inst Instance=new A064890Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064891
{
public static readonly long[] Value={ 0L,1L,2L,0L,2L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,2L,0L,1L,0L,0L,0L,2L,0L,0L,0L,0L,0L,3L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,3L,0L,0L,0L,3L,0L,0L,0L,0L,0L,3L,0L,0L,0L,0L,0L,1L,0L,3L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,2L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064891Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064891.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064891Inst : IEnumerable<long>
{
public static readonly long[] Value=A064891.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064891.Bytes);
public long this[int i]=>Value[i];

public static A064891Inst Instance=new A064891Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064892
{
public static readonly long[] Value={ 1L,2L,2L,1L,1L,1L,2L,1L,2L,3L,1L,1L,1L,3L,3L,3L,1L,3L,1L,1L,1L,1L,2L,1L,1L,1L,1L,3L,1L,1L,1L,1L,1L,3L,4L,2L,1L,1L,1L,2L,2L,2L,2L,1L,1L,1L,1L,1L,1L,2L,2L,2L,1L,1L,2L,4L,2L,1L,2L,1L,1L,1L,3L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,4L,3L,1L,1L,2L,1L,1L,1L,1L,2L,2L,2L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,2L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064892Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064892.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064892Inst : IEnumerable<long>
{
public static readonly long[] Value=A064892.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064892.Bytes);
public long this[int i]=>Value[i];

public static A064892Inst Instance=new A064892Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064893
{
public static readonly long[] Value={ 1L,2L,3L,29L,149L,4079L,4088027L,1887647351L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064893Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064893.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064893Inst : IEnumerable<long>
{
public static readonly long[] Value=A064893.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064893.Bytes);
public long this[int i]=>Value[i];

public static A064893Inst Instance=new A064893Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064894
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,2L,1L,1L,3L,3L,1L,1L,1L,1L,1L,1L,4L,4L,1L,1L,2L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,5L,5L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,6L,6L,1L,1L,2L,2L,1L,1L,3L,3L,1L,1L,1L,1L,1L,1L,2L,2L,1L,1L,2L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064894Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064894.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064894Inst : IEnumerable<long>
{
public static readonly long[] Value=A064894.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064894.Bytes);
public long this[int i]=>Value[i];

public static A064894Inst Instance=new A064894Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064895
{
public static readonly long[] Value={ 0L,1L,2L,3L,2L,3L,6L,7L,2L,3L,10L,11L,12L,13L,14L,15L,2L,3L,18L,19L,6L,7L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,2L,3L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,2L,3L,66L,67L,10L,11L,70L,71L,6L,7L,74L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064895Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064895.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064895Inst : IEnumerable<long>
{
public static readonly long[] Value=A064895.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064895.Bytes);
public long this[int i]=>Value[i];

public static A064895Inst Instance=new A064895Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064896
{
public static readonly long[] Value={ 1L,3L,5L,7L,9L,15L,17L,21L,31L,33L,63L,65L,73L,85L,127L,129L,255L,257L,273L,341L,511L,513L,585L,1023L,1025L,1057L,1365L,2047L,2049L,4095L,4097L,4161L,4369L,4681L,5461L,8191L,8193L,16383L,16385L,16513L,21845L,32767L,32769L,33825L,37449L,65535L,65537L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064896Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064896.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064896Inst : IEnumerable<long>
{
public static readonly long[] Value=A064896.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064896.Bytes);
public long this[int i]=>Value[i];

public static A064896Inst Instance=new A064896Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064897
{
public static readonly long[] Value={ 2L,4L,8L,2L,10L,8L,2L,2L,4L,20L,10L,8L,12L,8L,26L,4L,14L,8L,22L,16L,2L,12L,18L,8L,42L,24L,12L,8L,26L,48L,2L,8L,26L,10L,26L,8L,28L,14L,32L,16L,40L,8L,8L,16L,24L,18L,30L,12L,34L,88L,46L,32L,16L,20L,2L,8L,50L,52L,46L,48L,6L,2L,2L,20L,64L,52L,56L,10L,14L,40L,4L,8L,78L,64L,130L,18L,22L,64L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064897Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064897.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064897Inst : IEnumerable<long>
{
public static readonly long[] Value=A064897.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064897.Bytes);
public long this[int i]=>Value[i];

public static A064897Inst Instance=new A064897Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064898
{
public static readonly BigInteger[] Value={ 1L,0L,1L,5L,28L,199L,1721L,17394L,200803L,2607301L,37614922L,596933193L,10334308029L,193820343248L,3914731286181L,84716451763961L,1955520075368116L,47960724925499219L,1245468599978831333L,BigInteger.Parse("34139796082603477690"),BigInteger.Parse("985066290112167474255"),BigInteger.Parse("29844155285575945561913") };
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
public class A064898Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064898.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064898Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A064898.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A064898.Bytes);
public BigInteger this[int i]=>Value[i];

public static A064898Inst Instance=new A064898Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064899
{
public static readonly long[] Value={ 6L,10L,14L,21L,22L,26L,34L,38L,39L,46L,55L,57L,58L,62L,74L,82L,86L,93L,94L,106L,111L,118L,122L,129L,134L,142L,146L,155L,158L,166L,178L,183L,194L,201L,202L,203L,205L,206L,214L,218L,219L,226L,237L,253L,254L,262L,274L,278L,291L,298L,301L,302L,305L,309L,314L,326L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064899Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064899.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064899Inst : IEnumerable<long>
{
public static readonly long[] Value=A064899.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064899.Bytes);
public long this[int i]=>Value[i];

public static A064899Inst Instance=new A064899Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064900
{
public static readonly long[] Value={ 15L,33L,35L,51L,69L,85L,87L,123L,141L,143L,159L,161L,177L,185L,213L,235L,249L,259L,267L,303L,321L,323L,335L,339L,393L,411L,447L,485L,501L,519L,533L,535L,537L,553L,573L,591L,635L,681L,685L,699L,717L,749L,753L,771L,785L,789L,807L,835L,843L,869L,871L,879L,899L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064900Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064900.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064900Inst : IEnumerable<long>
{
public static readonly long[] Value=A064900.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064900.Bytes);
public long this[int i]=>Value[i];

public static A064900Inst Instance=new A064900Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064901
{
public static readonly long[] Value={ 65L,115L,119L,215L,217L,265L,365L,377L,413L,415L,511L,515L,517L,565L,629L,707L,779L,815L,865L,965L,1099L,1115L,1165L,1207L,1243L,1315L,1391L,1393L,1415L,1465L,1501L,1565L,1589L,1687L,1727L,1765L,1769L,1865L,1883L,1915L,1969L,1981L,2165L,2177L,2215L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064901Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064901.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064901Inst : IEnumerable<long>
{
public static readonly long[] Value=A064901.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064901.Bytes);
public long this[int i]=>Value[i];

public static A064901Inst Instance=new A064901Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064902
{
public static readonly long[] Value={ 77L,95L,145L,221L,295L,371L,395L,407L,437L,445L,469L,545L,559L,649L,695L,745L,763L,895L,959L,995L,1057L,1133L,1145L,1159L,1195L,1253L,1345L,1351L,1513L,1517L,1679L,1745L,1795L,1841L,1895L,1939L,1945L,2021L,2045L,2095L,2101L,2195L,2245L,2249L,2395L,2429L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064902Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064902.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064902Inst : IEnumerable<long>
{
public static readonly long[] Value=A064902.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064902.Bytes);
public long this[int i]=>Value[i];

public static A064902Inst Instance=new A064902Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064903
{
public static readonly long[] Value={ 133L,329L,403L,427L,623L,721L,781L,817L,917L,1079L,1211L,1241L,1417L,1507L,1603L,1799L,1819L,1897L,1991L,2077L,2191L,2231L,2681L,2779L,2923L,2959L,2983L,3073L,3107L,3269L,3443L,3563L,3661L,4121L,4151L,4169L,4249L,4411L,4427L,4709L,4739L,4837L,5033L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064903Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064903.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064903Inst : IEnumerable<long>
{
public static readonly long[] Value=A064903.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064903.Bytes);
public long this[int i]=>Value[i];

public static A064903Inst Instance=new A064903Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064904
{
public static readonly long[] Value={ 91L,187L,247L,287L,391L,581L,667L,671L,679L,913L,923L,973L,1147L,1169L,1261L,1267L,1397L,1561L,1591L,1639L,1757L,1919L,1927L,1937L,2051L,2123L,2149L,2443L,2491L,2641L,2933L,2951L,3031L,3091L,3127L,3227L,3281L,3521L,3817L,3841L,3859L,4087L,4109L,4207L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064904Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064904.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064904Inst : IEnumerable<long>
{
public static readonly long[] Value=A064904.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064904.Bytes);
public long this[int i]=>Value[i];

public static A064904Inst Instance=new A064904Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064905
{
public static readonly long[] Value={ 319L,697L,767L,803L,1219L,1529L,1577L,1781L,1853L,2119L,2497L,2981L,3133L,3223L,3509L,3587L,3649L,3707L,3743L,3809L,3949L,4061L,4393L,4747L,5161L,5249L,5321L,5401L,5837L,5899L,5909L,5983L,5989L,6127L,6509L,6611L,6631L,6931L,7633L,7697L,8063L,8203L,8473L,8797L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064905Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064905.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064905Inst : IEnumerable<long>
{
public static readonly long[] Value=A064905.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064905.Bytes);
public long this[int i]=>Value[i];

public static A064905Inst Instance=new A064905Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064906
{
public static readonly long[] Value={ 209L,451L,611L,713L,949L,1003L,1073L,1177L,1661L,1903L,1957L,1963L,2159L,2629L,2977L,3113L,3131L,3233L,3401L,3653L,3839L,3893L,3953L,3991L,4471L,4667L,5053L,5371L,5533L,5567L,5609L,5627L,5891L,6017L,6019L,6119L,6259L,6289L,6743L,7003L,7033L,7061L,7141L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064906Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064906.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064906Inst : IEnumerable<long>
{
public static readonly long[] Value=A064906.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064906.Bytes);
public long this[int i]=>Value[i];

public static A064906Inst Instance=new A064906Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064907
{
public static readonly long[] Value={ 341L,583L,731L,793L,893L,1067L,1469L,1793L,1807L,1943L,2201L,2323L,2483L,2519L,2761L,3043L,3071L,3487L,3497L,3781L,4213L,4439L,4511L,4777L,4841L,4849L,4939L,5497L,5809L,5933L,5947L,6511L,6539L,6989L,7093L,7117L,7391L,7493L,7601L,7613L,7783L,7891L,7967L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064907Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064907.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064907Inst : IEnumerable<long>
{
public static readonly long[] Value=A064907.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064907.Bytes);
public long this[int i]=>Value[i];

public static A064907Inst Instance=new A064907Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064908
{
public static readonly long[] Value={ 299L,473L,551L,1037L,1199L,1271L,1273L,1313L,1441L,1651L,1739L,1817L,2167L,2279L,2327L,2651L,2771L,2813L,2893L,3193L,3341L,3349L,3377L,3439L,3679L,4103L,4331L,4829L,4883L,5071L,5707L,5977L,6049L,6059L,6239L,6281L,6383L,6523L,6817L,7031L,7037L,7097L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064908Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064908.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064908Inst : IEnumerable<long>
{
public static readonly long[] Value=A064908.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064908.Bytes);
public long this[int i]=>Value[i];

public static A064908Inst Instance=new A064908Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064909
{
public static readonly long[] Value={ 481L,1157L,1343L,1921L,2171L,2263L,2369L,2509L,3077L,3097L,3427L,3523L,3683L,4171L,4537L,4541L,4811L,5213L,5263L,5389L,5543L,6107L,6227L,6707L,7123L,7241L,8279L,8593L,8621L,8717L,8857L,8873L,9353L,9607L,10411L,10537L,11359L,11461L,11567L,11747L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064909Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064909.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064909Inst : IEnumerable<long>
{
public static readonly long[] Value=A064909.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064909.Bytes);
public long this[int i]=>Value[i];

public static A064909Inst Instance=new A064909Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064910
{
public static readonly long[] Value={ 4L,6L,15L,65L,77L,133L,91L,319L,209L,341L,299L,481L,493L,799L,527L,1007L,1139L,2449L,703L,3611L,989L,1541L,1643L,3589L,1537L,2407L,2747L,2759L,1829L,3811L,1891L,4633L,2993L,3959L,2627L,4033L,2701L,6157L,3239L,9073L,3569L,5461L,4183L,6439L,5141L,6533L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064910Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064910.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064910Inst : IEnumerable<long>
{
public static readonly long[] Value=A064910.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064910.Bytes);
public long this[int i]=>Value[i];

public static A064910Inst Instance=new A064910Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064911
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,1L,0L,0L,1L,1L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,1L,1L,1L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,1L,1L,0L,0L,0L,1L,0L,1L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064911Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064911.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064911Inst : IEnumerable<long>
{
public static readonly long[] Value=A064911.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064911.Bytes);
public long this[int i]=>Value[i];

public static A064911Inst Instance=new A064911Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064912
{
public static readonly long[] Value={ 1L,2L,8L,2L,7L,8L,14L,2L,18L,6L,6L,4L,5L,20L,20L,4L,25L,22L,32L,6L,16L,6L,42L,4L,25L,6L,66L,12L,29L,20L,58L,8L,2L,58L,40L,16L,39L,36L,16L,6L,27L,12L,68L,4L,24L,42L,80L,4L,94L,50L,112L,6L,48L,58L,20L,12L,60L,50L,104L,16L,61L,66L,32L,20L,1L,2L,4L,82L,42L,40L,130L,16L,55L,70L,108L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064912Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064912.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064912Inst : IEnumerable<long>
{
public static readonly long[] Value=A064912.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064912.Bytes);
public long this[int i]=>Value[i];

public static A064912Inst Instance=new A064912Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064913
{
public static readonly long[] Value={ 6L,12L,2L,12L,10L,8L,22L,20L,10L,10L,12L,8L,4L,12L,12L,40L,6L,28L,90L,10L,24L,28L,22L,24L,46L,4L,46L,12L,72L,8L,8L,72L,14L,6L,20L,24L,92L,172L,2L,12L,94L,20L,50L,28L,24L,18L,130L,32L,134L,38L,6L,8L,140L,84L,32L,16L,102L,152L,130L,8L,134L,24L,60L,160L,4L,24L,146L,6L,18L,12L,172L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064913Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064913.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064913Inst : IEnumerable<long>
{
public static readonly long[] Value=A064913.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064913.Bytes);
public long this[int i]=>Value[i];

public static A064913Inst Instance=new A064913Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064914
{
public static readonly long[] Value={ 1L,1L,5L,23L,105L,449L,1902L,7828L,31976L,129200L,520425L,2088217L,8371186L,33514797L,134140430L,536699674L,2147154667L,8589198795L,34358341823L,137435830265L,549749857574L,2199010044813L,8796067657649L,35184315676573L,140737380485376L,562949713881526L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064914Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064914.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064914Inst : IEnumerable<long>
{
public static readonly long[] Value=A064914.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064914.Bytes);
public long this[int i]=>Value[i];

public static A064914Inst Instance=new A064914Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064915
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,12L,14L,16L,18L,22L,24L,26L,28L,30L,36L,42L,48L,54L,60L,66L,72L,77L,84L,90L,96L,102L,108L,114L,120L,126L,174L,180L,210L,240L,270L,300L,330L,420L,630L,840L,1050L,1260L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064915Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064915.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064915Inst : IEnumerable<long>
{
public static readonly long[] Value=A064915.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064915.Bytes);
public long this[int i]=>Value[i];

public static A064915Inst Instance=new A064915Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064916
{
public static readonly long[] Value={ 2L,3L,3L,5L,4L,7L,5L,5L,6L,11L,7L,13L,8L,7L,9L,17L,10L,19L,11L,9L,12L,23L,13L,9L,14L,11L,15L,29L,16L,31L,17L,13L,18L,11L,19L,37L,20L,15L,21L,41L,22L,43L,23L,17L,24L,47L,25L,13L,26L,19L,27L,53L,28L,15L,29L,21L,30L,59L,31L,61L,32L,23L,33L,17L,34L,67L,35L,25L,36L,71L,37L,73L,38L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064916Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064916.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064916Inst : IEnumerable<long>
{
public static readonly long[] Value=A064916.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064916.Bytes);
public long this[int i]=>Value[i];

public static A064916Inst Instance=new A064916Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064917
{
public static readonly long[] Value={ 2L,3L,3L,5L,3L,7L,5L,5L,3L,11L,7L,13L,5L,7L,5L,17L,3L,19L,11L,5L,7L,23L,13L,5L,5L,11L,7L,29L,5L,31L,17L,13L,3L,11L,19L,37L,11L,7L,5L,41L,7L,43L,23L,17L,13L,47L,5L,13L,5L,19L,11L,53L,7L,7L,29L,5L,5L,59L,31L,61L,17L,23L,13L,17L,3L,67L,11L,5L,19L,71L,37L,73L,11L,11L,7L,17L,5L,79L,41L,29L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064917Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064917.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064917Inst : IEnumerable<long>
{
public static readonly long[] Value=A064917.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064917.Bytes);
public long this[int i]=>Value[i];

public static A064917Inst Instance=new A064917Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064918
{
public static readonly long[] Value={ 0L,0L,1L,0L,2L,0L,1L,1L,3L,0L,1L,0L,2L,1L,2L,0L,4L,0L,1L,2L,2L,0L,1L,2L,3L,1L,2L,0L,3L,0L,1L,1L,5L,1L,1L,0L,2L,2L,3L,0L,3L,0L,1L,1L,2L,0L,3L,1L,4L,1L,2L,0L,3L,2L,1L,3L,4L,0L,1L,0L,2L,1L,2L,1L,6L,0L,2L,3L,2L,0L,1L,0L,3L,2L,3L,1L,4L,0L,1L,1L,4L,0L,1L,3L,2L,1L,2L,0L,3L,1L,1L,2L,4L,1L,2L,0L,5L,2L,2L,0L,3L,0L,1L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064918Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064918.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064918Inst : IEnumerable<long>
{
public static readonly long[] Value=A064918.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064918.Bytes);
public long this[int i]=>Value[i];

public static A064918Inst Instance=new A064918Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064919
{
public static readonly long[] Value={ 2L,3L,6L,5L,10L,7L,14L,16L,18L,11L,22L,13L,26L,28L,30L,17L,34L,19L,38L,40L,42L,23L,46L,48L,50L,52L,54L,29L,58L,31L,62L,64L,66L,68L,70L,37L,74L,76L,78L,41L,82L,43L,86L,88L,90L,47L,94L,96L,98L,100L,102L,53L,106L,108L,110L,112L,114L,59L,118L,61L,122L,124L,126L,128L,130L,67L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064919Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064919.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064919Inst : IEnumerable<long>
{
public static readonly long[] Value=A064919.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064919.Bytes);
public long this[int i]=>Value[i];

public static A064919Inst Instance=new A064919Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064920
{
public static readonly long[] Value={ 2L,3L,3L,5L,4L,7L,5L,5L,6L,11L,6L,13L,8L,7L,9L,17L,8L,19L,8L,9L,12L,23L,10L,9L,14L,11L,10L,29L,10L,31L,17L,13L,18L,11L,14L,37L,20L,15L,12L,41L,12L,43L,14L,13L,24L,47L,18L,13L,14L,19L,16L,53L,20L,15L,14L,21L,30L,59L,16L,61L,32L,15L,33L,17L,16L,67L,20L,25L,16L,71L,26L,73L,38L,19L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064920Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064920.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064920Inst : IEnumerable<long>
{
public static readonly long[] Value=A064920.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064920.Bytes);
public long this[int i]=>Value[i];

public static A064920Inst Instance=new A064920Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064921
{
public static readonly long[] Value={ 2L,3L,3L,5L,3L,7L,5L,5L,3L,11L,3L,13L,5L,7L,5L,17L,5L,19L,5L,5L,3L,23L,3L,5L,5L,11L,3L,29L,3L,31L,17L,13L,5L,11L,5L,37L,5L,7L,3L,41L,3L,43L,5L,13L,3L,47L,5L,13L,5L,19L,5L,53L,5L,7L,5L,5L,3L,59L,5L,61L,17L,7L,13L,17L,5L,67L,5L,5L,5L,71L,5L,73L,5L,19L,3L,17L,5L,79L,5L,29L,3L,83L,5L,5L,5L,31L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064921Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064921.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064921Inst : IEnumerable<long>
{
public static readonly long[] Value=A064921.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064921.Bytes);
public long this[int i]=>Value[i];

public static A064921Inst Instance=new A064921Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064922
{
public static readonly long[] Value={ 0L,0L,1L,0L,2L,0L,1L,1L,3L,0L,3L,0L,2L,1L,2L,0L,2L,0L,2L,2L,4L,0L,4L,2L,3L,1L,4L,0L,4L,0L,1L,1L,3L,1L,3L,0L,3L,2L,4L,0L,4L,0L,3L,1L,5L,0L,3L,1L,3L,1L,3L,0L,3L,2L,3L,3L,5L,0L,3L,0L,2L,2L,2L,1L,3L,0L,3L,3L,3L,0L,4L,0L,4L,1L,5L,1L,3L,0L,3L,1L,5L,0L,3L,3L,4L,1L,3L,0L,5L,1L,4L,2L,4L,1L,4L,0L,3L,1L,5L,0L,5L,0L,3L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064922Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064922.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064922Inst : IEnumerable<long>
{
public static readonly long[] Value=A064922.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064922.Bytes);
public long this[int i]=>Value[i];

public static A064922Inst Instance=new A064922Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064923
{
public static readonly long[] Value={ 2L,3L,6L,5L,10L,7L,14L,16L,24L,11L,22L,13L,26L,39L,52L,17L,34L,19L,38L,57L,76L,23L,46L,69L,72L,115L,120L,29L,58L,31L,62L,64L,96L,155L,160L,37L,74L,111L,148L,41L,82L,43L,86L,129L,172L,47L,94L,141L,144L,235L,240L,53L,106L,159L,162L,265L,270L,59L,118L,61L,122L,183L,244L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064923Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064923.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064923Inst : IEnumerable<long>
{
public static readonly long[] Value=A064923.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064923.Bytes);
public long this[int i]=>Value[i];

public static A064923Inst Instance=new A064923Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064924
{
public static readonly long[] Value={ 2L,3L,6L,5L,10L,7L,14L,21L,28L,11L,22L,13L,26L,39L,52L,17L,34L,19L,38L,57L,76L,23L,46L,69L,92L,115L,138L,29L,58L,31L,62L,93L,124L,155L,186L,37L,74L,111L,148L,41L,82L,43L,86L,129L,172L,47L,94L,141L,188L,235L,282L,53L,106L,159L,212L,265L,318L,59L,118L,61L,122L,183L,244L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064924Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064924.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064924Inst : IEnumerable<long>
{
public static readonly long[] Value=A064924.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064924.Bytes);
public long this[int i]=>Value[i];

public static A064924Inst Instance=new A064924Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064925
{
public static readonly long[] Value={ 6L,2L,4L,2L,6L,2L,26L,8L,8L,8L,6L,2L,26L,30L,8L,12L,34L,8L,10L,8L,30L,6L,10L,4L,42L,22L,36L,22L,12L,4L,26L,28L,4L,26L,60L,8L,8L,10L,38L,4L,78L,26L,22L,8L,20L,14L,80L,8L,202L,38L,34L,26L,32L,32L,2L,60L,14L,16L,116L,4L,98L,30L,86L,64L,60L,4L,42L,32L,10L,48L,42L,12L,158L,4L,34L,18L,52L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064925Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064925.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064925Inst : IEnumerable<long>
{
public static readonly long[] Value=A064925.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064925.Bytes);
public long this[int i]=>Value[i];

public static A064925Inst Instance=new A064925Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064926
{
public static readonly long[] Value={ 6L,6L,2L,8L,16L,2L,4L,20L,10L,16L,54L,8L,34L,4L,14L,40L,46L,10L,16L,32L,2L,62L,50L,20L,68L,30L,46L,4L,66L,14L,74L,84L,66L,38L,8L,24L,96L,28L,28L,56L,98L,2L,62L,108L,10L,54L,26L,36L,32L,72L,50L,26L,128L,38L,158L,12L,28L,70L,138L,28L,146L,82L,6L,156L,32L,58L,150L,100L,66L,8L,54L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064926Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064926.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064926Inst : IEnumerable<long>
{
public static readonly long[] Value=A064926.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064926.Bytes);
public long this[int i]=>Value[i];

public static A064926Inst Instance=new A064926Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064927
{
public static readonly long[] Value={ 4L,8L,8L,4L,2L,6L,8L,6L,14L,4L,18L,6L,18L,16L,4L,6L,28L,14L,34L,4L,16L,32L,72L,2L,14L,18L,58L,20L,42L,4L,22L,8L,40L,56L,8L,18L,54L,64L,14L,4L,18L,20L,66L,20L,16L,144L,6L,2L,4L,28L,60L,22L,74L,54L,14L,16L,64L,38L,14L,4L,106L,26L,20L,16L,20L,36L,26L,72L,152L,16L,50L,10L,28L,124L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064927Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064927.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064927Inst : IEnumerable<long>
{
public static readonly long[] Value=A064927.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064927.Bytes);
public long this[int i]=>Value[i];

public static A064927Inst Instance=new A064927Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064928
{
public static readonly long[] Value={ 0L,1L,11L,2L,7L,8L,3L,12L,40L,13L,4L,9L,24L,25L,10L,5L,14L,41L,19L,42L,15L,6L,35L,26L,31L,32L,27L,36L,47L,16L,43L,20L,102L,21L,44L,17L,48L,37L,28L,33L,58L,57L,34L,29L,38L,49L,18L,45L,22L,103L,79L,104L,23L,46L,75L,50L,39L,30L,63L,116L,59L,60L,115L,64L,55L,70L,51L,74L,109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064928Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064928.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064928Inst : IEnumerable<long>
{
public static readonly long[] Value=A064928.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064928.Bytes);
public long this[int i]=>Value[i];

public static A064928Inst Instance=new A064928Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064929
{
public static readonly long[] Value={ 0L,1L,6L,21L,14L,20L,33L,10L,15L,2L,16L,3L,4L,11L,29L,31L,43L,22L,53L,46L,24L,39L,36L,78L,7L,9L,52L,23L,44L,30L,41L,12L,13L,56L,19L,48L,26L,37L,34L,80L,5L,35L,18L,57L,42L,28L,91L,38L,27L,47L,64L,88L,119L,168L,70L,63L,71L,17L,8L,61L,83L,100L,94L,40L,58L,73L,123L,101L,85L,50L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064929Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064929.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064929Inst : IEnumerable<long>
{
public static readonly long[] Value=A064929.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064929.Bytes);
public long this[int i]=>Value[i];

public static A064929Inst Instance=new A064929Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064930
{
public static readonly long[] Value={ 0L,1L,9L,11L,12L,40L,2L,24L,58L,25L,7L,13L,31L,32L,4L,8L,10L,57L,42L,34L,5L,3L,17L,27L,20L,102L,36L,48L,45L,14L,29L,15L,87L,6L,38L,41L,22L,37L,47L,21L,63L,30L,44L,16L,28L,103L,19L,49L,35L,112L,69L,71L,26L,18L,85L,79L,33L,43L,64L,125L,116L,59L,181L,55L,50L,105L,104L,106L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064930Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064930.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064930Inst : IEnumerable<long>
{
public static readonly long[] Value=A064930.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064930.Bytes);
public long this[int i]=>Value[i];

public static A064930Inst Instance=new A064930Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064931
{
public static readonly long[] Value={ 1L,4L,5L,6L,9L,12L,24L,25L,29L,34L,39L,49L,56L,59L,67L,124L,125L,129L,137L,236L,238L,245L,249L,279L,345L,346L,347L,368L,389L,467L,689L,1235L,1236L,1238L,1249L,1256L,1258L,1345L,1368L,1459L,1467L,1567L,1679L,1689L,2349L,2359L,2457L,2458L,2589L,3459L,3467L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064931Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064931.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064931Inst : IEnumerable<long>
{
public static readonly long[] Value=A064931.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064931.Bytes);
public long this[int i]=>Value[i];

public static A064931Inst Instance=new A064931Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064932
{
public static readonly long[] Value={ 2L,10L,30L,98L,270L,818L,2382L,7282L,21818L,65650L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064932Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064932.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064932Inst : IEnumerable<long>
{
public static readonly long[] Value=A064932.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064932.Bytes);
public long this[int i]=>Value[i];

public static A064932Inst Instance=new A064932Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064933
{
public static readonly long[] Value={ 1L,2L,3L,4L,7L,11L,14L,15L,26L,28L,41L,52L,56L,78L,97L,130L,153L,156L,194L,209L,260L,362L,388L,390L,571L,679L,724L,765L,776L,780L,1351L,1358L,1552L,2131L,2702L,2716L,2911L,3982L,4053L,5042L,5404L,5432L,6755L,6878L,7953L,7964L,8106L,8109L,10084L,10808L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064933Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064933.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064933Inst : IEnumerable<long>
{
public static readonly long[] Value=A064933.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064933.Bytes);
public long this[int i]=>Value[i];

public static A064933Inst Instance=new A064933Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064934
{
public static readonly long[] Value={ 1L,2L,5L,11L,23L,43L,89L,179L,359L,719L,1433L,2879L,5749L,11497L,22993L,45989L,91997L,183971L,367949L,735901L,1471807L,2943599L,5887213L,11774429L,23548853L,47097697L,94195421L,188390809L,376781623L,753563269L,1507126519L,3014253049L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064934Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064934.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064934Inst : IEnumerable<long>
{
public static readonly long[] Value=A064934.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064934.Bytes);
public long this[int i]=>Value[i];

public static A064934Inst Instance=new A064934Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064935
{
public static readonly long[] Value={ 4L,64L,376L,1188L,1468L,25804L,58588L,134944L,137344L,170584L,272608L,285388L,420208L,538732L,592408L,618448L,680704L,778804L,1163064L,1520440L,1700944L,2099200L,2831008L,4020028L,4174168L,4516108L,5059888L,5215768L,5447272L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064935Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064935.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064935Inst : IEnumerable<long>
{
public static readonly long[] Value=A064935.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064935.Bytes);
public long this[int i]=>Value[i];

public static A064935Inst Instance=new A064935Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064936
{
public static readonly long[] Value={ 2L,3L,5L,181L,40087L,251737L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064936Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064936.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064936Inst : IEnumerable<long>
{
public static readonly long[] Value=A064936.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064936.Bytes);
public long this[int i]=>Value[i];

public static A064936Inst Instance=new A064936Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064937
{
public static readonly long[] Value={ 1L,25L,49L,55L,77L,119L,133L,143L,155L,161L,169L,185L,187L,203L,209L,217L,221L,235L,247L,275L,287L,289L,295L,301L,325L,329L,361L,365L,371L,377L,391L,403L,407L,415L,425L,427L,437L,451L,455L,469L,473L,485L,493L,497L,505L,511L,517L,527L,529L,539L,553L,559L,583L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064937Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064937.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064937Inst : IEnumerable<long>
{
public static readonly long[] Value=A064937.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064937.Bytes);
public long this[int i]=>Value[i];

public static A064937Inst Instance=new A064937Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064938
{
public static readonly long[] Value={ 1L,4L,6L,8L,10L,12L,14L,20L,24L,42L,48L,60L,63L,70L,72L,80L,84L,108L,120L,124L,126L,153L,156L,182L,240L,246L,264L,286L,327L,372L,374L,440L,492L,516L,552L,1008L,1053L,1664L,1941L,2160L,2494L,3048L,3741L,4116L,4136L,4144L,4152L,5106L,5698L,6012L,6458L,6459L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064938Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064938.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064938Inst : IEnumerable<long>
{
public static readonly long[] Value=A064938.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064938.Bytes);
public long this[int i]=>Value[i];

public static A064938Inst Instance=new A064938Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064939
{
public static readonly long[] Value={ 0L,2L,3L,2L,5L,8L,7L,2L,3L,12L,11L,8L,13L,16L,13L,2L,17L,8L,19L,12L,17L,24L,23L,8L,5L,28L,3L,16L,29L,23L,31L,2L,25L,36L,19L,8L,37L,40L,29L,12L,41L,29L,43L,24L,13L,48L,47L,8L,7L,12L,37L,28L,53L,8L,27L,16L,41L,60L,59L,23L,61L,64L,17L,2L,31L,41L,67L,36L,49L,33L,71L,8L,73L,76L,13L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064939Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064939.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064939Inst : IEnumerable<long>
{
public static readonly long[] Value=A064939.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064939.Bytes);
public long this[int i]=>Value[i];

public static A064939Inst Instance=new A064939Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064940
{
public static readonly long[] Value={ 2L,6L,34L,38L,42L,50L,54L,78L,86L,90L,106L,110L,114L,834L,842L,1390L,1406L,1410L,1470L,1578L,1586L,1650L,1662L,1842L,1850L,3382L,3490L,3506L,3514L,3518L,3546L,3658L,3690L,3718L,3746L,3778L,3818L,3822L,3842L,3850L,3854L,3870L,3898L,3938L,3946L,3986L,3990L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064940Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064940.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064940Inst : IEnumerable<long>
{
public static readonly long[] Value=A064940.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064940.Bytes);
public long this[int i]=>Value[i];

public static A064940Inst Instance=new A064940Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064941
{
public static readonly BigInteger[] Value={ 1L,3L,26L,596L,38171L,7083827L,3852835452L,6200587517574L,29752897658253125L,BigInteger.Parse("427721252609771505989"),BigInteger.Parse("18479976131829456895423324"),BigInteger.Parse("2405174963192312814001570260392"),BigInteger.Parse("944597040906414962273553855513194341"),BigInteger.Parse("1120924326970482645724785944664901286951323") };
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
public class A064941Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064941.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064941Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A064941.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A064941.Bytes);
public BigInteger this[int i]=>Value[i];

public static A064941Inst Instance=new A064941Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064942
{
public static readonly long[] Value={ 1L,1233L,8833L,10100L,990100L,5882353L,94122353L,99009901L,100010000L,1765038125L,2584043776L,7416043776L,8235038125L,9901009901L,48600220401L,116788321168L,123288328768L,601300773101L,876712328768L,883212321168L,990100990100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064942Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064942.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064942Inst : IEnumerable<long>
{
public static readonly long[] Value=A064942.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064942.Bytes);
public long this[int i]=>Value[i];

public static A064942Inst Instance=new A064942Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064943
{
public static readonly long[] Value={ 0L,2L,2L,2L,6L,6L,14L,30L,6L,14L,14L,6L,6L,14L,126L,14L,14L,62L,6L,14L,126L,14L,14L,510L,126L,14L,62L,30L,30L,62L,6L,6L,254L,14L,2046L,30L,126L,62L,126L,510L,6L,254L,6L,14L,2046L,14L,14L,254L,30L,254L,2046L,254L,30L,254L,4094L,510L,2046L,126L,6L,254L,30L,126L,2046L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064943Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064943.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064943Inst : IEnumerable<long>
{
public static readonly long[] Value=A064943.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064943.Bytes);
public long this[int i]=>Value[i];

public static A064943Inst Instance=new A064943Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A064944
{
public static readonly long[] Value={ 1L,5L,7L,17L,11L,38L,15L,49L,34L,60L,23L,132L,27L,82L,82L,129L,35L,191L,39L,207L,112L,126L,47L,384L,86L,148L,142L,283L,59L,469L,63L,321L,172L,192L,172L,666L,75L,214L,202L,597L,83L,640L,87L,435L,403L,258L,95L,1016L,162L,485L,262L,511L,107L,812L,264L,813L,292L,324L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A064944Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A064944.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A064944Inst : IEnumerable<long>
{
public static readonly long[] Value=A064944.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A064944.Bytes);
public long this[int i]=>Value[i];

public static A064944Inst Instance=new A064944Inst();

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