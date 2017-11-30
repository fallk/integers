using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A184991
{
public static readonly long[] Value={ 1L,9L,88193L,113314233813L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184991Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184991.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184991Inst : IEnumerable<long>
{
public static readonly long[] Value=A184991.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184991.Bytes);
public long this[int i]=>Value[i];

public static A184991Inst Instance=new A184991Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184990
{
public static readonly long[] Value={ 1L,1L,0L,2L,-1L,-2L,4L,-2L,-2L,6L,-4L,-4L,10L,-6L,-8L,16L,-9L,-10L,24L,-14L,-16L,36L,-20L,-24L,53L,-30L,-32L,76L,-43L,-48L,108L,-60L,-68L,150L,-84L,-92L,206L,-114L,-128L,280L,-155L,-172L,376L,-208L,-228L,504L,-276L,-304L,668L,-366L,-400L,878L,-480L,-524L,1148L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184990Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184990.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184990Inst : IEnumerable<long>
{
public static readonly long[] Value=A184990.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184990.Bytes);
public long this[int i]=>Value[i];

public static A184990Inst Instance=new A184990Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184989
{
public static readonly long[] Value={ 10L,21L,32L,43L,54L,65L,76L,87L,98L,190L,1110L,1121L,1132L,1143L,1154L,1165L,1176L,1187L,1198L,2109L,2210L,2221L,2232L,2243L,2254L,2265L,2276L,2287L,2298L,3209L,3310L,3321L,3332L,3343L,3354L,3365L,3376L,3387L,3398L,4309L,4410L,4421L,4432L,4443L,4454L,4465L,4476L,4487L,4498L,5409L,5510L,5521L,5532L,5543L,5554L,5565L,5576L,5587L,5598L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184989Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184989.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184989Inst : IEnumerable<long>
{
public static readonly long[] Value=A184989.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184989.Bytes);
public long this[int i]=>Value[i];

public static A184989Inst Instance=new A184989Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184988
{
public static readonly long[] Value={ 0L,1L,4L,9L,6L,5L,6L,9L,6L,8L,1L,121L,44L,9L,9L,22L,6L,9L,4L,6L,4L,44L,484L,9L,7L,6L,676L,9L,8L,8L,9L,9L,4L,9L,11L,22L,9L,9L,444L,5L,6L,8L,7L,9L,9L,202L,11L,22L,4L,4L,5L,6L,7L,9L,9L,5L,313L,9L,33L,8L,6L,7L,44L,969L,9L,22L,6L,44L,6L,7L,9L,5L,8L,9L,7L,6L,77L,929L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184988Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184988.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184988Inst : IEnumerable<long>
{
public static readonly long[] Value=A184988.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184988.Bytes);
public long this[int i]=>Value[i];

public static A184988Inst Instance=new A184988Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184955
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,4L,90L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184955Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184955.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184955Inst : IEnumerable<long>
{
public static readonly long[] Value=A184955.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184955.Bytes);
public long this[int i]=>Value[i];

public static A184955Inst Instance=new A184955Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184954
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,1L,7L,388L,406824L,1125022325L,3813549359274L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184954Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184954.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184954Inst : IEnumerable<long>
{
public static readonly long[] Value=A184954.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184954.Bytes);
public long this[int i]=>Value[i];

public static A184954Inst Instance=new A184954Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184953
{
public static readonly long[] Value={ 0L,0L,0L,1L,3L,59L,7847L,3459376L,2585136287L,2807104844073L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184953Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184953.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184953Inst : IEnumerable<long>
{
public static readonly long[] Value=A184953.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184953.Bytes);
public long this[int i]=>Value[i];

public static A184953Inst Instance=new A184953Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184952
{
public static readonly long[] Value={ 0L,1L,2L,4L,40L,52L,82L,4839L,5813L,8366L,11153L,46254L,1040968L,12925493L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184952Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184952.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184952Inst : IEnumerable<long>
{
public static readonly long[] Value=A184952.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184952.Bytes);
public long this[int i]=>Value[i];

public static A184952Inst Instance=new A184952Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184951
{
public static readonly long[] Value={ 1L,3L,60L,1L,7848L,1L,3459383L,7L,2585136675L,388L,2807105250897L,406824L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184951Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184951.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184951Inst : IEnumerable<long>
{
public static readonly long[] Value=A184951.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184951.Bytes);
public long this[int i]=>Value[i];

public static A184951Inst Instance=new A184951Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184950
{
public static readonly long[] Value={ 1L,3L,59L,1L,7847L,1L,3459376L,7L,2585136287L,388L,2807104844073L,406824L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184950Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184950.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184950Inst : IEnumerable<long>
{
public static readonly long[] Value=A184950.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184950.Bytes);
public long this[int i]=>Value[i];

public static A184950Inst Instance=new A184950Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184949
{
public static readonly BigInteger[] Value={ 1L,0L,2L,3L,68L,390L,8334L,98280L,2321136L,42895440L,1167767640L,29323831680L,926869947816L,29169311371200L,1064023191882000L,39974978077332480L,1664929964612590080L,BigInteger.Parse("72388846850592384000"),BigInteger.Parse("3402723408460217089344"),BigInteger.Parse("167636144501378081280000"),BigInteger.Parse("8796533195129444799189120") };
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
public class A184949Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184949.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184949Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184949.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A184949.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184949Inst Instance=new A184949Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184948
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,2L,1L,1L,3L,6L,10L,12L,12L,10L,6L,3L,1L,1L,4L,12L,28L,52L,84L,116L,140L,150L,140L,116L,84L,52L,28L,12L,4L,1L,1L,5L,20L,60L,150L,326L,620L,1060L,1635L,2295L,2952L,3480L,3780L,3780L,3480L,2952L,2295L,1635L,1060L,620L,326L,150L,60L,20L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184948Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184948.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184948Inst : IEnumerable<long>
{
public static readonly long[] Value=A184948.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184948.Bytes);
public long this[int i]=>Value[i];

public static A184948Inst Instance=new A184948Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184947
{
public static readonly BigInteger[] Value={ 1L,1L,3L,10L,45L,241L,1525L,11096L,91441L,842185L,8577871L,95768454L,1163339221L,15278140593L,215739927481L,3259925357716L,52489756856993L,897249441166993L,16228613753092315L,309660835748163394L,6216734677256575581L,BigInteger.Parse("130994769191324727697") };
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
public class A184947Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184947.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184947Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184947.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A184947.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184947Inst Instance=new A184947Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184946
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,4L,0L,19L,0L,1272L,25L,494031L,13504L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184946Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184946.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184946Inst : IEnumerable<long>
{
public static readonly long[] Value=A184946.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184946.Bytes);
public long this[int i]=>Value[i];

public static A184946Inst Instance=new A184946Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184945
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,2L,8L,131L,3917L,123859L,4131991L,132160607L,4018022149L,118369811959L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184945Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184945.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184945Inst : IEnumerable<long>
{
public static readonly long[] Value=A184945.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184945.Bytes);
public long this[int i]=>Value[i];

public static A184945Inst Instance=new A184945Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184944
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,2L,2L,12L,31L,220L,1606L,16828L,193900L,2452818L,32670329L,456028472L,6636066091L,100135577616L,1582718909051L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184944Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184944.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184944Inst : IEnumerable<long>
{
public static readonly long[] Value=A184944.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184944.Bytes);
public long this[int i]=>Value[i];

public static A184944Inst Instance=new A184944Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184943
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,1L,2L,5L,16L,57L,263L,1532L,10747L,87948L,803885L,8020590L,86027734L,983417704L,11913817317L,152352034707L,2050055948375L,28466137588780L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184943Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184943.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184943Inst : IEnumerable<long>
{
public static readonly long[] Value=A184943.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184943.Bytes);
public long this[int i]=>Value[i];

public static A184943Inst Instance=new A184943Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184942
{
public static readonly BigInteger[] Value={ 1L,1L,4L,22L,162L,1490L,16440L,211580L,3111620L,51477860L,946225200L,19131604600L,421979473800L,10083011777800L,259461056701600L,7153463299918000L,210372376616298000L,6573394764766154000L,BigInteger.Parse("217477401066324360000"),BigInteger.Parse("7594856249571370364000"),BigInteger.Parse("279190943147187411860000") };
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
public class A184942Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184942.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184942Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184942.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A184942.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184942Inst Instance=new A184942Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184941
{
public static readonly long[] Value={ 1L,1L,2L,6L,1L,16L,0L,59L,2L,265L,2L,1544L,12L,10778L,31L,88168L,220L,805491L,1606L,8037418L,16828L,86221634L,193900L,985870522L,2452818L,11946487647L,32670330L,1L,152808063181L,456028474L,2L,2056692014474L,6636066099L,8L,28566273166527L,100135577747L,131L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184941Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184941.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184941Inst : IEnumerable<long>
{
public static readonly long[] Value=A184941.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184941.Bytes);
public long this[int i]=>Value[i];

public static A184941Inst Instance=new A184941Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184940
{
public static readonly long[] Value={ 1L,1L,2L,5L,1L,16L,0L,57L,2L,263L,2L,1532L,12L,10747L,31L,87948L,220L,803885L,1606L,8020590L,16828L,86027734L,193900L,983417704L,2452818L,11913817317L,32670329L,1L,152352034707L,456028472L,2L,2050055948375L,6636066091L,8L,28466137588780L,100135577616L,131L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184940Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184940.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184940Inst : IEnumerable<long>
{
public static readonly long[] Value=A184940.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184940.Bytes);
public long this[int i]=>Value[i];

public static A184940Inst Instance=new A184940Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184859
{
public static readonly long[] Value={ 2L,3L,5L,11L,13L,19L,23L,29L,31L,37L,47L,53L,61L,71L,73L,79L,83L,89L,97L,107L,113L,131L,139L,149L,157L,163L,167L,173L,181L,191L,193L,197L,199L,223L,227L,233L,239L,241L,251L,257L,269L,277L,283L,293L,307L,311L,317L,337L,349L,353L,359L,367L,379L,383L,401L,409L,419L,421L,443L,461L,463L,479L,487L,503L,521L,523L,547L,557L,563L,571L,587L,599L,607L,613L,631L,641L,647L,659L,673L,683L,691L,701L,709L,733L,739L,743L,751L,757L,769L,773L,809L,811L,827L,853L,859L,877L,883L,887L,911L,919L,929L,937L,947L,953L,971L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184859Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184859.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184859Inst : IEnumerable<long>
{
public static readonly long[] Value=A184859.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184859.Bytes);
public long this[int i]=>Value[i];

public static A184859Inst Instance=new A184859Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184858
{
public static readonly long[] Value={ 2L,4L,5L,7L,9L,11L,12L,13L,15L,16L,18L,20L,22L,23L,26L,28L,29L,30L,32L,33L,34L,36L,39L,42L,43L,44L,45L,46L,47L,48L,49L,50L,54L,55L,60L,61L,64L,65L,66L,70L,72L,73L,74L,75L,77L,78L,79L,80L,81L,83L,84L,85L,87L,88L,89L,90L,92L,93L,94L,95L,96L,97L,99L,100L,101L,103L,104L,105L,106L,108L,109L,110L,111L,112L,115L,117L,118L,119L,120L,121L,122L,123L,124L,125L,128L,129L,132L,133L,134L,137L,138L,139L,140L,141L,142L,144L,148L,149L,150L,151L,152L,154L,156L,157L,160L,161L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184858Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184858.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184858Inst : IEnumerable<long>
{
public static readonly long[] Value=A184858.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184858.Bytes);
public long this[int i]=>Value[i];

public static A184858Inst Instance=new A184858Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184857
{
public static readonly long[] Value={ 2L,5L,7L,11L,15L,20L,24L,26L,30L,34L,39L,45L,50L,53L,64L,68L,69L,72L,83L,87L,88L,96L,106L,115L,121L,122L,125L,126L,134L,141L,144L,145L,159L,163L,178L,179L,197L,198L,201L,221L,227L,232L,236L,240L,246L,251L,254L,259L,265L,273L,274L,278L,284L,289L,292L,293L,303L,308L,311L,316L,318L,322L,331L,342L,346L,356L,360L,361L,365L,375L,379L,380L,384L,388L,399L,407L,409L,413L,417L,418L,426L,428L,432L,437L,455L,460L,470L,475L,479L,489L,498L,504L,512L,513L,519L,523L,542L,543L,546L,555L,557L,561L,576L,581L,595L,599L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184857Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184857.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184857Inst : IEnumerable<long>
{
public static readonly long[] Value=A184857.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184857.Bytes);
public long this[int i]=>Value[i];

public static A184857Inst Instance=new A184857Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184856
{
public static readonly long[] Value={ 3L,7L,11L,17L,23L,31L,37L,41L,47L,53L,61L,71L,79L,83L,101L,107L,109L,113L,131L,137L,139L,151L,167L,181L,191L,193L,197L,199L,211L,223L,227L,229L,251L,257L,281L,283L,311L,313L,317L,349L,359L,367L,373L,379L,389L,397L,401L,409L,419L,431L,433L,439L,449L,457L,461L,463L,479L,487L,491L,499L,503L,509L,523L,541L,547L,563L,569L,571L,577L,593L,599L,601L,607L,613L,631L,643L,647L,653L,659L,661L,673L,677L,683L,691L,719L,727L,743L,751L,757L,773L,787L,797L,809L,811L,821L,827L,857L,859L,863L,877L,881L,887L,911L,919L,941L,947L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184856Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184856.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184856Inst : IEnumerable<long>
{
public static readonly long[] Value=A184856.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184856.Bytes);
public long this[int i]=>Value[i];

public static A184856Inst Instance=new A184856Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184855
{
public static readonly long[] Value={ 1L,3L,6L,8L,10L,14L,17L,19L,21L,24L,25L,27L,31L,35L,37L,38L,40L,41L,51L,52L,53L,56L,57L,58L,59L,62L,63L,67L,68L,69L,71L,76L,82L,86L,91L,98L,102L,107L,113L,114L,116L,126L,127L,130L,131L,135L,136L,143L,145L,146L,147L,153L,155L,158L,159L,163L,168L,170L,171L,176L,177L,181L,185L,186L,187L,192L,193L,195L,196L,197L,199L,200L,202L,206L,208L,210L,214L,216L,218L,219L,222L,225L,226L,230L,232L,234L,237L,240L,243L,244L,248L,249L,252L,254L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184855Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184855.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184855Inst : IEnumerable<long>
{
public static readonly long[] Value=A184855.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184855.Bytes);
public long this[int i]=>Value[i];

public static A184855Inst Instance=new A184855Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184854
{
public static readonly long[] Value={ 0L,0L,0L,2L,0L,5L,3L,3L,2L,8L,1L,4L,9L,0L,9L,0L,6L,4L,7L,9L,4L,6L,8L,3L,7L,2L,2L,2L,8L,9L,2L,3L,7L,0L,6L,5L,3L,0L,2L,9L,5L,9L,8L,5L,3L,7L,7L,4L,1L,6L,6L,7L,6L,4L,3L,0L,3L,8L,4L,0L,2L,0L,8L,7L,1L,4L,3L,5L,3L,0L,0L,9L,0L,2L,4L,0L,7L,1L,0L,6L,9L,1L,7L,5L,1L,9L,8L,4L,9L,6L,0L,5L,1L,0L,6L,0L,9L,0L,2L,8L,1L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184854Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184854.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184854Inst : IEnumerable<long>
{
public static readonly long[] Value=A184854.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184854.Bytes);
public long this[int i]=>Value[i];

public static A184854Inst Instance=new A184854Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184853
{
public static readonly long[] Value={ 0L,0L,0L,0L,3L,4L,3L,9L,4L,7L,7L,4L,4L,1L,8L,0L,8L,8L,0L,4L,8L,1L,7L,7L,9L,1L,4L,6L,2L,3L,7L,9L,8L,2L,2L,7L,3L,9L,0L,6L,2L,0L,7L,8L,9L,5L,3L,8L,5L,9L,4L,4L,4L,1L,6L,2L,9L,7L,5L,9L,2L,9L,1L,9L,0L,4L,8L,4L,3L,1L,5L,0L,1L,0L,3L,3L,4L,4L,4L,6L,1L,5L,2L,8L,3L,7L,0L,9L,5L,7L,5L,4L,3L,8L,9L,3L,4L,5L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184853Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184853.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184853Inst : IEnumerable<long>
{
public static readonly long[] Value=A184853.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184853.Bytes);
public long this[int i]=>Value[i];

public static A184853Inst Instance=new A184853Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184852
{
public static readonly long[] Value={ 6L,25L,45L,113L,183L,388L,476L,810L,1300L,1671L,2367L,3609L,3980L,5198L,7471L,8576L,10419L,14992L,15210L,18919L,25028L,27560L,31199L,41822L,42799L,50603L,65284L,66683L,74594L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184852Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184852.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184852Inst : IEnumerable<long>
{
public static readonly long[] Value=A184852.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184852.Bytes);
public long this[int i]=>Value[i];

public static A184852Inst Instance=new A184852Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184851
{
public static readonly long[] Value={ 5L,13L,17L,33L,33L,76L,76L,137L,138L,196L,240L,398L,287L,495L,460L,765L,720L,968L,957L,1160L,1261L,1706L,1629L,2183L,1777L,2655L,2562L,3371L,3159L,3228L,3888L,4875L,4450L,5435L,4462L,6573L,6179L,7659L,6664L,7520L,8348L,9781L,9377L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184851Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184851.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184851Inst : IEnumerable<long>
{
public static readonly long[] Value=A184851.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184851.Bytes);
public long this[int i]=>Value[i];

public static A184851Inst Instance=new A184851Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184850
{
public static readonly long[] Value={ 4L,7L,10L,13L,8L,16L,19L,34L,54L,22L,31L,55L,55L,92L,47L,75L,92L,126L,117L,73L,121L,124L,149L,201L,83L,198L,256L,261L,250L,162L,265L,316L,324L,333L,194L,404L,336L,396L,551L,244L,401L,581L,466L,540L,372L,553L,604L,669L,634L,326L,785L,783L,764L,951L,408L,845L,951L,829L,908L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184850Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184850.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184850Inst : IEnumerable<long>
{
public static readonly long[] Value=A184850.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184850.Bytes);
public long this[int i]=>Value[i];

public static A184850Inst Instance=new A184850Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184849
{
public static readonly long[] Value={ 3L,3L,6L,3L,3L,6L,3L,3L,15L,3L,6L,6L,6L,3L,8L,3L,10L,15L,15L,3L,14L,6L,9L,6L,11L,6L,27L,3L,10L,8L,17L,3L,22L,10L,22L,15L,15L,15L,28L,3L,22L,14L,20L,6L,45L,9L,21L,6L,17L,11L,37L,6L,15L,27L,15L,3L,37L,10L,29L,8L,18L,17L,49L,3L,22L,22L,25L,10L,39L,22L,26L,15L,28L,15L,45L,15L,33L,28L,25L,3L,60L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184849Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184849.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184849Inst : IEnumerable<long>
{
public static readonly long[] Value=A184849.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184849.Bytes);
public long this[int i]=>Value[i];

public static A184849Inst Instance=new A184849Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184848
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,1L,2L,2L,1L,1L,2L,2L,3L,1L,1L,2L,2L,3L,4L,1L,1L,2L,2L,6L,7L,5L,1L,1L,2L,2L,3L,10L,13L,6L,1L,1L,2L,2L,3L,13L,17L,25L,8L,1L,1L,2L,2L,6L,8L,33L,45L,54L,10L,1L,1L,2L,2L,3L,16L,33L,113L,153L,122L,12L,1L,1L,2L,2L,3L,19L,76L,183L,433L,561L,253L,15L,1L,1L,2L,2L,15L,34L,76L,388L,1136L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184848Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184848.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184848Inst : IEnumerable<long>
{
public static readonly long[] Value=A184848.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184848.Bytes);
public long this[int i]=>Value[i];

public static A184848Inst Instance=new A184848Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184847
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,34L,137L,810L,6367L,66564L,448091L,2895361L,21050917L,147976680L,1131808944L,7785436438L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184847Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184847.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184847Inst : IEnumerable<long>
{
public static readonly long[] Value=A184847.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184847.Bytes);
public long this[int i]=>Value[i];

public static A184847Inst Instance=new A184847Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184846
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,19L,76L,476L,3627L,30780L,191122L,1143877L,7374982L,46220204L,305794362L,1874323984L,11217509631L,68193471721L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184846Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184846.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184846Inst : IEnumerable<long>
{
public static readonly long[] Value=A184846.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184846.Bytes);
public long this[int i]=>Value[i];

public static A184846Inst Instance=new A184846Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184845
{
public static readonly long[] Value={ 1L,1L,2L,2L,6L,16L,76L,388L,2152L,13887L,76684L,402552L,2246308L,12383123L,70009515L,374562273L,1971133886L,10420025889L,54379325900L,283582422717L,1451108174772L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184845Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184845.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184845Inst : IEnumerable<long>
{
public static readonly long[] Value=A184845.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184845.Bytes);
public long this[int i]=>Value[i];

public static A184845Inst Instance=new A184845Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184844
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,8L,33L,183L,1136L,5506L,24282L,117926L,569254L,2774987L,13031733L,58087202L,261738519L,1186540784L,5337900539L,23545839048L,102301482654L,442231758905L,1901120041905L,8113101102305L,34276506444563L,143502353379187L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184844Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184844.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184844Inst : IEnumerable<long>
{
public static readonly long[] Value=A184844.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184844.Bytes);
public long this[int i]=>Value[i];

public static A184844Inst Instance=new A184844Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184779
{
public static readonly long[] Value={ 2L,6L,7L,9L,12L,15L,18L,20L,29L,34L,37L,38L,39L,43L,47L,57L,61L,62L,63L,66L,67L,77L,80L,81L,84L,86L,88L,91L,94L,103L,106L,107L,111L,113L,115L,116L,129L,133L,134L,135L,140L,145L,146L,147L,150L,151L,154L,156L,166L,173L,177L,178L,186L,188L,193L,194L,197L,201L,204L,205L,208L,211L,214L,216L,222L,224L,225L,227L,229L,230L,233L,234L,243L,245L,247L,251L,252L,257L,263L,264L,271L,278L,281L,283L,285L,288L,291L,296L,298L,300L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184779Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184779.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184779Inst : IEnumerable<long>
{
public static readonly long[] Value=A184779.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184779.Bytes);
public long this[int i]=>Value[i];

public static A184779Inst Instance=new A184779Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184778
{
public static readonly long[] Value={ 1L,4L,5L,7L,11L,14L,18L,21L,32L,41L,46L,48L,49L,56L,62L,79L,83L,86L,90L,93L,97L,114L,120L,123L,127L,130L,134L,137L,144L,165L,169L,172L,178L,181L,185L,188L,213L,220L,222L,223L,237L,243L,246L,250L,253L,257L,260L,267L,288L,302L,308L,311L,325L,329L,343L,346L,352L,360L,366L,369L,376L,380L,383L,387L,410L,417L,418L,420L,424L,425L,431L,434L,452L,455L,459L,468L,469L,475L,489L,496L,510L,524L,534L,541L,547L,550L,557L,571L,578L,582L,584L,585L,591L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184778Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184778.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184778Inst : IEnumerable<long>
{
public static readonly long[] Value=A184778.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184778.Bytes);
public long this[int i]=>Value[i];

public static A184778Inst Instance=new A184778Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184777
{
public static readonly long[] Value={ 3L,13L,17L,23L,37L,47L,61L,71L,109L,139L,157L,163L,167L,191L,211L,269L,283L,293L,307L,317L,331L,389L,409L,419L,433L,443L,457L,467L,491L,563L,577L,587L,607L,617L,631L,641L,727L,751L,757L,761L,809L,829L,839L,853L,863L,877L,887L,911L,983L,1031L,1051L,1061L,1109L,1123L,1171L,1181L,1201L,1229L,1249L,1259L,1283L,1297L,1307L,1321L,1399L,1423L,1427L,1433L,1447L,1451L,1471L,1481L,1543L,1553L,1567L,1597L,1601L,1621L,1669L,1693L,1741L,1789L,1823L,1847L,1867L,1877L,1901L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184777Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184777.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184777Inst : IEnumerable<long>
{
public static readonly long[] Value=A184777.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184777.Bytes);
public long this[int i]=>Value[i];

public static A184777Inst Instance=new A184777Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184776
{
public static readonly long[] Value={ 1L,3L,4L,5L,8L,10L,11L,13L,14L,16L,17L,19L,21L,22L,23L,24L,25L,26L,27L,28L,30L,31L,32L,33L,35L,36L,40L,41L,42L,44L,45L,46L,48L,49L,50L,51L,52L,53L,54L,55L,56L,58L,59L,60L,64L,65L,68L,69L,70L,71L,72L,73L,74L,75L,76L,78L,79L,82L,83L,85L,87L,89L,90L,92L,93L,95L,96L,97L,98L,99L,100L,101L,102L,104L,105L,108L,109L,110L,112L,114L,117L,118L,119L,120L,121L,122L,123L,124L,125L,126L,127L,128L,130L,131L,132L,136L,137L,138L,139L,141L,142L,143L,144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184776Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184776.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184776Inst : IEnumerable<long>
{
public static readonly long[] Value=A184776.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184776.Bytes);
public long this[int i]=>Value[i];

public static A184776Inst Instance=new A184776Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184775
{
public static readonly long[] Value={ 2L,4L,5L,8L,14L,21L,22L,29L,31L,38L,42L,48L,52L,56L,59L,63L,69L,72L,73L,76L,80L,90L,93L,97L,106L,107L,123L,127L,128L,137L,140L,141L,158L,161L,162L,165L,169L,171L,178L,182L,186L,192L,196L,199L,220L,222L,239L,246L,247L,250L,254L,260L,264L,268L,271L,281L,284L,298L,305L,311L,318L,326L,328L,339L,345L,353L,356L,360L,369L,370L,383L,387L,394L,403L,404L,420L,424L,425L,434L,438L,455L,458L,462L,466L,468L,476L,479L,483L,489L,496L,502L,509L,519L,523L,526L,544L,547L,557L,564L,574L,581L,582L,585L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184775Inst : IEnumerable<long>
{
public static readonly long[] Value=A184775.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184775.Bytes);
public long this[int i]=>Value[i];

public static A184775Inst Instance=new A184775Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184774
{
public static readonly long[] Value={ 2L,5L,7L,11L,19L,29L,31L,41L,43L,53L,59L,67L,73L,79L,83L,89L,97L,101L,103L,107L,113L,127L,131L,137L,149L,151L,173L,179L,181L,193L,197L,199L,223L,227L,229L,233L,239L,241L,251L,257L,263L,271L,277L,281L,311L,313L,337L,347L,349L,353L,359L,367L,373L,379L,383L,397L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184774Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184774.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184774Inst : IEnumerable<long>
{
public static readonly long[] Value=A184774.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184774.Bytes);
public long this[int i]=>Value[i];

public static A184774Inst Instance=new A184774Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184773
{
public static readonly long[] Value={ 64L,424L,424L,2248L,8272L,2248L,13096L,108496L,108496L,13096L,73288L,1792144L,1967440L,1792144L,73288L,417256L,27993232L,62051344L,62051344L,27993232L,417256L,2358280L,454774672L,1444491280L,4975179472L,1444491280L,454774672L,2358280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184773Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184773.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184773Inst : IEnumerable<long>
{
public static readonly long[] Value=A184773.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184773.Bytes);
public long this[int i]=>Value[i];

public static A184773Inst Instance=new A184773Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184772
{
public static readonly BigInteger[] Value={ 13370536L,119205236368L,26695990774288L,77441892454241488L,BigInteger.Parse("38088784754633618128"),BigInteger.Parse("65125066574894542587856"),BigInteger.Parse("49227749118673440429632464"),BigInteger.Parse("65871504288847215551031759568") };
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
public class A184772Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184772.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184772Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184772.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A184772.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184772Inst Instance=new A184772Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184771
{
public static readonly BigInteger[] Value={ 2358280L,7339536784L,1005763454224L,1156853256240592L,308462363918463952L,BigInteger.Parse("225203116583181557968"),BigInteger.Parse("83362210743024650511568"),BigInteger.Parse("49227749118673440429632464"),BigInteger.Parse("21277949728043116377816749008") };
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
public class A184771Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184771.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184771Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184771.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A184771.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184771Inst Instance=new A184771Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184770
{
public static readonly BigInteger[] Value={ 417256L,454774672L,39939558160L,18492329456080L,3063406967117776L,1004331937875999952L,BigInteger.Parse("225203116583181557968"),BigInteger.Parse("65125066574894542587856"),BigInteger.Parse("16551036919295881635106768"),BigInteger.Parse("4596125898531178643947012816") };
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
public class A184770Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184770.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184770Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184770.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A184770.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184770Inst Instance=new A184770Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184769
{
public static readonly BigInteger[] Value={ 73288L,27993232L,1444491280L,267277851856L,22101775999696L,3063406967117776L,308462363918463952L,BigInteger.Parse("38088784754633618128"),BigInteger.Parse("4147681118591532446416"),BigInteger.Parse("489192384756554775330256"),BigInteger.Parse("54923301389754187275076048") };
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
public class A184769Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184769.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184769Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184769.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A184769.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184769Inst Instance=new A184769Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184768
{
public static readonly BigInteger[] Value={ 13096L,1792144L,62051344L,4975179472L,267277851856L,18492329456080L,1156853256240592L,77441892454241488L,5064538742140130512L,BigInteger.Parse("336992694113719404496"),BigInteger.Parse("22308222687181070310352"),BigInteger.Parse("1483254308363737851935440") };
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
public class A184768Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184768.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184768Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184768.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A184768.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184768Inst Instance=new A184768Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184767
{
public static readonly BigInteger[] Value={ 2248L,108496L,1967440L,62051344L,1444491280L,39939558160L,1005763454224L,26695990774288L,688562611427344L,18047210235975952L,468881159345732368L,12241663779855722512UL,BigInteger.Parse("318750682398626741776"),BigInteger.Parse("8312086512859451766544") };
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
public class A184767Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184767.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184767Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184767.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A184767.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184767Inst Instance=new A184767Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184766
{
public static readonly BigInteger[] Value={ 424L,8272L,108496L,1792144L,27993232L,454774672L,7339536784L,119205236368L,1934859805840L,31437977902480L,510797840746384L,8300795694017680L,134894624057920144L,2192213833325394832L,BigInteger.Parse("35626484733088902544") };
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
public class A184766Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184766.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184766Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184766.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A184766.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184766Inst Instance=new A184766Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184765
{
public static readonly long[] Value={ 64L,424L,2248L,13096L,73288L,417256L,2358280L,13370536L,75704776L,428889448L,2429192584L,13760163880L,77941013320L,441485755624L,2500712951560L,14164866483112L,80234377893064L,454473710492776L,2574286780013704L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184765Inst : IEnumerable<long>
{
public static readonly long[] Value=A184765.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184765.Bytes);
public long this[int i]=>Value[i];

public static A184765Inst Instance=new A184765Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184764
{
public static readonly BigInteger[] Value={ 64L,8272L,1967440L,4975179472L,22101775999696L,1004331937875999952L,BigInteger.Parse("83362210743024650511568"),BigInteger.Parse("65871504288847215551031759568") };
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
public class A184764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184764Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184764.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A184764.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184764Inst Instance=new A184764Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184699
{
public static readonly long[] Value={ 1L,3L,12L,46L,156L,476L,1349L,3571L,8939L,21310L,48701L,107233L,228465L,472626L,952169L,1872813L,3604103L,6798753L,12592030L,22930495L,41108069L,72630552L,126596216L,217879554L,370555433L,623223294L,1037221437L,1709205913L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184699Inst : IEnumerable<long>
{
public static readonly long[] Value=A184699.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184699.Bytes);
public long this[int i]=>Value[i];

public static A184699Inst Instance=new A184699Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184698
{
public static readonly long[] Value={ 1L,3L,9L,28L,78L,207L,504L,1169L,2574L,5439L,11071L,21841L,41846L,78193L,142787L,255441L,448444L,773966L,1314861L,2201731L,3637642L,5935817L,9574284L,15277075L,24130784L,37755124L,58545388L,90021407L,137320211L,207895383L,312495662L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184698Inst : IEnumerable<long>
{
public static readonly long[] Value=A184698.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184698.Bytes);
public long this[int i]=>Value[i];

public static A184698Inst Instance=new A184698Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184697
{
public static readonly long[] Value={ 1L,2L,6L,14L,34L,74L,154L,304L,580L,1066L,1901L,3304L,5610L,9332L,15241L,24476L,38721L,60418L,93088L,141765L,213590L,318608L,470873L,689907L,1002660L,1446141L,2070897L,2945590L,4163079L,5848345L,8168863L,11348145L,15683285L,21567664L,29520301L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184697Inst : IEnumerable<long>
{
public static readonly long[] Value=A184697.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184697.Bytes);
public long this[int i]=>Value[i];

public static A184697Inst Instance=new A184697Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184696
{
public static readonly long[] Value={ 1L,2L,3L,7L,12L,21L,35L,58L,91L,142L,215L,322L,472L,685L,979L,1385L,1936L,2684L,3685L,5023L,6790L,9119L,12163L,16130L,21264L,27887L,36383L,47249L,61076L,78621L,100787L,128714L,163766L,207643L,262385L,330506L,415023L,519630L,648751L,807768L,1003113L,1242574L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184696Inst : IEnumerable<long>
{
public static readonly long[] Value=A184696.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184696.Bytes);
public long this[int i]=>Value[i];

public static A184696Inst Instance=new A184696Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184695
{
public static readonly long[] Value={ 1L,2L,6L,28L,156L,985L,6575L,46037L,332729L,2467215L,18668476L,143639875L,1120736308L,8848906376L,70585065382L,568063412434L,4607556545105L,37630962749979L,309239715248494L,2555320702164649L,21220771891605441L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184695Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184695.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184695Inst : IEnumerable<long>
{
public static readonly long[] Value=A184695.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184695.Bytes);
public long this[int i]=>Value[i];

public static A184695Inst Instance=new A184695Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184694
{
public static readonly long[] Value={ 1L,3L,3L,9L,24L,9L,27L,192L,192L,27L,81L,1536L,4080L,1536L,81L,243L,12288L,86688L,86688L,12288L,243L,729L,98304L,1841856L,4890528L,1841856L,98304L,729L,2187L,786432L,39133824L,275895264L,275895264L,39133824L,786432L,2187L,6561L,6291456L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184694Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184694.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184694Inst : IEnumerable<long>
{
public static readonly long[] Value=A184694.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184694.Bytes);
public long this[int i]=>Value[i];

public static A184694Inst Instance=new A184694Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184693
{
public static readonly BigInteger[] Value={ 2187L,6291456L,17666296320L,49534593003552L,138877768818516672L,BigInteger.Parse("389362817519503469280"),BigInteger.Parse("1091631544523681779567680"),BigInteger.Parse("3060537246479645213149335744"),BigInteger.Parse("8580631691388515533867028831616") };
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
public class A184693Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184693.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184693Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184693.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A184693.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184693Inst Instance=new A184693Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184692
{
public static readonly BigInteger[] Value={ 729L,786432L,831474432L,878052505824L,927173138866560L,979037502950237760L,BigInteger.Parse("1033802803683039013248"),BigInteger.Parse("1091631544523681779567680"),BigInteger.Parse("1152695101814751026511782496"),BigInteger.Parse("1217174425159215145475386956576") };
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
public class A184692Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184692.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184692Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184692.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A184692.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184692Inst Instance=new A184692Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184691
{
public static readonly BigInteger[] Value={ 243L,98304L,39133824L,15564399648L,6189975781728L,2461751303097216L,979037502950237760L,BigInteger.Parse("389362817519503469280"),BigInteger.Parse("154849434408870800843040"),BigInteger.Parse("61583557179340633440836160"),BigInteger.Parse("24491755680833694286332417792") };
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
public class A184691Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184691.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184691Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184691.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A184691.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184691Inst Instance=new A184691Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184690
{
public static readonly BigInteger[] Value={ 81L,12288L,1841856L,275895264L,41325395328L,6189975781728L,927173138866560L,138877768818516672L,BigInteger.Parse("20801977386689522208"),BigInteger.Parse("3115849763962378244064"),BigInteger.Parse("466711388591033629230624"),BigInteger.Parse("69906939275393719770229056") };
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
public class A184690Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184690.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184690Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184690.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A184690.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184690Inst Instance=new A184690Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184689
{
public static readonly BigInteger[] Value={ 27L,1536L,86688L,4890528L,275895264L,15564399648L,878052505824L,49534593003552L,2794452367733472L,157646678048909856L,8893504640414384352L,BigInteger.Parse("501719578033435638816"),BigInteger.Parse("28304087663951554461408"),BigInteger.Parse("1596751280124982805188128") };
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
public class A184689Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184689.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184689Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184689.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A184689.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184689Inst Instance=new A184689Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184688
{
public static readonly BigInteger[] Value={ 9L,192L,4080L,86688L,1841856L,39133824L,831474432L,17666296320L,375354928128L,7975147677696L,169447570059264L,3600244178460672L,76494210805186560L,1625268730858733568L,BigInteger.Parse("34532004706009153536"),BigInteger.Parse("733699803838461640704") };
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
public class A184688Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184688.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184688Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184688.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A184688.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184688Inst Instance=new A184688Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184687
{
public static readonly BigInteger[] Value={ 1L,24L,4080L,4890528L,41325395328L,2461751303097216L,BigInteger.Parse("1033802803683039013248"),BigInteger.Parse("3060537246479645213149335744"),BigInteger.Parse("63873994081842807211176279381955968"),BigInteger.Parse("9397599222467284962086636818784583099209472") };
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
public class A184687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184687Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184687.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A184687.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184687Inst Instance=new A184687Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184686
{
public static readonly long[] Value={ 10L,28L,28L,76L,128L,76L,208L,544L,544L,208L,568L,2384L,3360L,2384L,568L,1552L,10384L,21968L,21968L,10384L,1552L,4240L,45392L,140816L,221968L,140816L,45392L,4240L,11584L,198352L,909520L,2171152L,2171152L,909520L,198352L,11584L,31648L,867152L,5858896L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184686Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184686.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184686Inst : IEnumerable<long>
{
public static readonly long[] Value=A184686.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184686.Bytes);
public long this[int i]=>Value[i];

public static A184686Inst Instance=new A184686Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184685
{
public static readonly BigInteger[] Value={ 11584L,867152L,37779664L,2107074576L,105530924944L,5556396815504L,286297979078416L,14901599172048528L,772255092178447120L,BigInteger.Parse("40103190379637623184"),BigInteger.Parse("2080745823672990984720"),BigInteger.Parse("108004153792892136250000") };
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
public class A184685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184685Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184685.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A184685.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184685Inst Instance=new A184685Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184684
{
public static readonly BigInteger[] Value={ 4240L,198352L,5858896L,212829840L,7079094288L,245133874960L,8344809419152L,286297979078416L,9790004471087504L,335277906309809680L,11474887935176701072UL,BigInteger.Parse("392843564281607701264"),BigInteger.Parse("13447355724118720653712") };
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
public class A184684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184684Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184684.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A184684.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184684Inst Instance=new A184684Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184635
{
public static readonly long[] Value={ 5L,16L,36L,64L,100L,144L,196L,256L,324L,400L,484L,576L,676L,784L,900L,1024L,1156L,1296L,1444L,1600L,1764L,1936L,2116L,2304L,2500L,2704L,2916L,3136L,3364L,3600L,3844L,4096L,4356L,4624L,4900L,5184L,5476L,5776L,6084L,6400L,6724L,7056L,7396L,7744L,8100L,8464L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184635Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184635.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184635Inst : IEnumerable<long>
{
public static readonly long[] Value=A184635.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184635.Bytes);
public long this[int i]=>Value[i];

public static A184635Inst Instance=new A184635Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184634
{
public static readonly long[] Value={ 1L,3L,11L,25L,50L,86L,137L,204L,291L,400L,532L,691L,878L,1097L,1350L,1638L,1965L,2332L,2743L,3200L,3704L,4259L,4866L,5529L,6250L,7030L,7873L,8780L,9755L,10800L,11916L,13107L,14374L,15721L,17150L,18662L,20261L,21948L,23727L,25600L,27568L,29635L,31802L,34073L,36450L,38934L,41529L,44236L,47059L,50000L,53060L,56243L,59550L,62985L,66550L,70246L,74077L,78044L,82151L,86400L,90792L,95331L,100018L,104857L,109850L,114998L,120305L,125772L,131403L,137200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184634Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184634.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184634Inst : IEnumerable<long>
{
public static readonly long[] Value=A184634.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184634.Bytes);
public long this[int i]=>Value[i];

public static A184634Inst Instance=new A184634Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184633
{
public static readonly long[] Value={ 1L,4L,12L,28L,55L,96L,152L,227L,324L,444L,591L,768L,976L,1219L,1500L,1820L,2183L,2592L,3048L,3555L,4116L,4732L,5407L,6144L,6944L,7811L,8748L,9756L,10839L,12000L,13240L,14563L,15972L,17468L,19055L,20736L,22512L,24387L,26364L,28444L,30631L,32928L,35336L,37859L,40500L,43260L,46143L,49152L,52288L,55555L,58956L,62492L,66167L,69984L,73944L,78051L,82308L,86716L,91279L,96000L,100880L,105923L,111132L,116508L,122055L,127776L,133672L,139747L,146004L,152444L,159071L,165888L,172896L,180099L,187500L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184633Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184633.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184633Inst : IEnumerable<long>
{
public static readonly long[] Value=A184633.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184633.Bytes);
public long this[int i]=>Value[i];

public static A184633Inst Instance=new A184633Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184632
{
public static readonly long[] Value={ 1L,4L,13L,32L,62L,108L,171L,256L,364L,500L,665L,864L,1098L,1372L,1687L,2048L,2456L,2916L,3429L,4000L,4630L,5324L,6083L,6912L,7812L,8788L,9841L,10976L,12194L,13500L,14895L,16384L,17968L,19652L,21437L,23328L,25326L,27436L,29659L,32000L,34460L,37044L,39753L,42592L,45562L,48668L,51911L,55296L,58824L,62500L,66325L,70304L,74438L,78732L,83187L,87808L,92596L,97556L,102689L,108000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184632Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184632.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184632Inst : IEnumerable<long>
{
public static readonly long[] Value=A184632.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184632.Bytes);
public long this[int i]=>Value[i];

public static A184632Inst Instance=new A184632Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184631
{
public static readonly long[] Value={ 1L,5L,15L,36L,71L,123L,196L,292L,416L,571L,760L,987L,1255L,1568L,1928L,2340L,2807L,3332L,3919L,4571L,5292L,6084L,6952L,7899L,8928L,10043L,11247L,12544L,13936L,15428L,17023L,18724L,20535L,22459L,24500L,26660L,28944L,31355L,33896L,36571L,39383L,42336L,45432L,48676L,52071L,55620L,59327L,63195L,67228L,71428L,75800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184631Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184631.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184631Inst : IEnumerable<long>
{
public static readonly long[] Value=A184631.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184631.Bytes);
public long this[int i]=>Value[i];

public static A184631Inst Instance=new A184631Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184630
{
public static readonly long[] Value={ 1L,6L,18L,43L,83L,144L,228L,341L,486L,666L,887L,1152L,1464L,1829L,2250L,2730L,3275L,3888L,4572L,5333L,6174L,7098L,8111L,9216L,10416L,11717L,13122L,14634L,16259L,18000L,19860L,21845L,23958L,26202L,28583L,31104L,33768L,36581L,39546L,42666L,45947L,49392L,53004L,56789L,60750L,64890L,69215L,73728L,78432L,83333L,88434L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184630Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184630.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184630Inst : IEnumerable<long>
{
public static readonly long[] Value=A184630.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184630.Bytes);
public long this[int i]=>Value[i];

public static A184630Inst Instance=new A184630Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184629
{
public static readonly long[] Value={ 1L,7L,22L,51L,100L,173L,274L,409L,583L,800L,1064L,1382L,1757L,2195L,2700L,3276L,3930L,4665L,5487L,6400L,7408L,8518L,9733L,11059L,12500L,14060L,15746L,17561L,19511L,21600L,23832L,26214L,28749L,31443L,34300L,37324L,40522L,43897L,47455L,51200L,55136L,59270L,63605L,68147L,72900L,77868L,83058L,88473L,94119L,100000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184629Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184629.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184629Inst : IEnumerable<long>
{
public static readonly long[] Value=A184629.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184629.Bytes);
public long this[int i]=>Value[i];

public static A184629Inst Instance=new A184629Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184628
{
public static readonly long[] Value={ 2L,8L,27L,64L,125L,216L,343L,512L,729L,1000L,1331L,1728L,2197L,2744L,3375L,4096L,4913L,5832L,6859L,8000L,9261L,10648L,12167L,13824L,15625L,17576L,19683L,21952L,24389L,27000L,29791L,32768L,35937L,39304L,42875L,46656L,50653L,54872L,59319L,64000L,68921L,74088L,79507L,85184L,91125L,97336L,103823L,110592L,117649L,125000L,132651L,140608L,148877L,157464L,166375L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184628Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184628.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184628Inst : IEnumerable<long>
{
public static readonly long[] Value=A184628.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184628.Bytes);
public long this[int i]=>Value[i];

public static A184628Inst Instance=new A184628Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184627
{
public static readonly long[] Value={ 2L,4L,6L,9L,11L,13L,16L,18L,20L,23L,25L,28L,30L,32L,35L,37L,39L,42L,44L,46L,49L,51L,54L,56L,58L,61L,63L,65L,68L,70L,73L,75L,77L,80L,82L,84L,87L,89L,91L,94L,96L,99L,101L,103L,106L,108L,110L,113L,115L,117L,120L,122L,125L,127L,129L,132L,134L,136L,139L,141L,143L,146L,148L,151L,153L,155L,158L,160L,162L,165L,167L,170L,172L,174L,177L,179L,181L,184L,186L,188L,191L,193L,196L,198L,200L,203L,205L,207L,210L,212L,214L,217L,219L,222L,224L,226L,229L,231L,233L,236L,238L,240L,243L,245L,248L,250L,252L,255L,257L,259L,262L,264L,267L,269L,271L,274L,276L,278L,281L,283L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184627Inst : IEnumerable<long>
{
public static readonly long[] Value=A184627.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184627.Bytes);
public long this[int i]=>Value[i];

public static A184627Inst Instance=new A184627Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184626
{
public static readonly long[] Value={ 1L,3L,5L,7L,8L,10L,12L,14L,15L,17L,19L,21L,22L,24L,26L,27L,29L,31L,33L,34L,36L,38L,40L,41L,43L,45L,47L,48L,50L,52L,53L,55L,57L,59L,60L,62L,64L,66L,67L,69L,71L,72L,74L,76L,78L,79L,81L,83L,85L,86L,88L,90L,92L,93L,95L,97L,98L,100L,102L,104L,105L,107L,109L,111L,112L,114L,116L,118L,119L,121L,123L,124L,126L,128L,130L,131L,133L,135L,137L,138L,140L,142L,144L,145L,147L,149L,150L,152L,154L,156L,157L,159L,161L,163L,164L,166L,168L,169L,171L,173L,175L,176L,178L,180L,182L,183L,185L,187L,189L,190L,192L,194L,195L,197L,199L,201L,202L,204L,206L,208L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184626Inst : IEnumerable<long>
{
public static readonly long[] Value=A184626.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184626.Bytes);
public long this[int i]=>Value[i];

public static A184626Inst Instance=new A184626Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184625
{
public static readonly long[] Value={ 4L,7L,10L,14L,17L,21L,24L,27L,31L,34L,38L,41L,44L,48L,51L,55L,58L,62L,65L,68L,72L,75L,79L,82L,85L,89L,92L,96L,99L,103L,106L,109L,113L,116L,120L,123L,126L,130L,133L,137L,140L,144L,147L,150L,154L,157L,161L,164L,167L,171L,174L,178L,181L,184L,188L,191L,195L,198L,202L,205L,208L,212L,215L,219L,222L,225L,229L,232L,236L,239L,243L,246L,249L,253L,256L,260L,263L,266L,270L,273L,277L,280L,283L,287L,290L,294L,297L,301L,304L,307L,311L,314L,318L,321L,324L,328L,331L,335L,338L,342L,345L,348L,352L,355L,359L,362L,365L,369L,372L,376L,379L,382L,386L,389L,393L,396L,400L,403L,406L,410L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184625Inst : IEnumerable<long>
{
public static readonly long[] Value=A184625.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184625.Bytes);
public long this[int i]=>Value[i];

public static A184625Inst Instance=new A184625Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184624
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,8L,9L,11L,12L,13L,15L,16L,18L,19L,20L,22L,23L,25L,26L,28L,29L,30L,32L,33L,35L,36L,37L,39L,40L,42L,43L,45L,46L,47L,49L,50L,52L,53L,54L,56L,57L,59L,60L,61L,63L,64L,66L,67L,69L,70L,71L,73L,74L,76L,77L,78L,80L,81L,83L,84L,86L,87L,88L,90L,91L,93L,94L,95L,97L,98L,100L,101L,102L,104L,105L,107L,108L,110L,111L,112L,114L,115L,117L,118L,119L,121L,122L,124L,125L,127L,128L,129L,131L,132L,134L,135L,136L,138L,139L,141L,142L,143L,145L,146L,148L,149L,151L,152L,153L,155L,156L,158L,159L,160L,162L,163L,165L,166L,168L,169L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184624Inst : IEnumerable<long>
{
public static readonly long[] Value=A184624.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184624.Bytes);
public long this[int i]=>Value[i];

public static A184624Inst Instance=new A184624Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184623
{
public static readonly long[] Value={ 4L,7L,11L,14L,17L,21L,24L,28L,31L,34L,38L,41L,45L,48L,52L,55L,58L,62L,65L,69L,72L,75L,79L,82L,86L,89L,92L,96L,99L,103L,106L,110L,113L,116L,120L,123L,127L,130L,133L,137L,140L,144L,147L,151L,154L,157L,161L,164L,168L,171L,174L,178L,181L,185L,188L,192L,195L,198L,202L,205L,209L,212L,215L,219L,222L,226L,229L,232L,236L,239L,243L,246L,250L,253L,256L,260L,263L,267L,270L,273L,277L,280L,284L,287L,291L,294L,297L,301L,304L,308L,311L,314L,318L,321L,325L,328L,331L,335L,338L,342L,345L,349L,352L,355L,359L,362L,366L,369L,372L,376L,379L,383L,386L,390L,393L,396L,400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184623Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184623.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184623Inst : IEnumerable<long>
{
public static readonly long[] Value=A184623.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184623.Bytes);
public long this[int i]=>Value[i];

public static A184623Inst Instance=new A184623Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184622
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,8L,9L,10L,12L,13L,15L,16L,18L,19L,20L,22L,23L,25L,26L,27L,29L,30L,32L,33L,35L,36L,37L,39L,40L,42L,43L,44L,46L,47L,49L,50L,51L,53L,54L,56L,57L,59L,60L,61L,63L,64L,66L,67L,68L,70L,71L,73L,74L,76L,77L,78L,80L,81L,83L,84L,85L,87L,88L,90L,91L,93L,94L,95L,97L,98L,100L,101L,102L,104L,105L,107L,108L,109L,111L,112L,114L,115L,117L,118L,119L,121L,122L,124L,125L,126L,128L,129L,131L,132L,134L,135L,136L,138L,139L,141L,142L,143L,145L,146L,148L,149L,150L,152L,153L,155L,156L,158L,159L,160L,162L,163L,165L,166L,167L,169L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184622Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184622.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184622Inst : IEnumerable<long>
{
public static readonly long[] Value=A184622.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184622.Bytes);
public long this[int i]=>Value[i];

public static A184622Inst Instance=new A184622Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184621
{
public static readonly long[] Value={ 2L,6L,9L,13L,16L,19L,23L,26L,30L,33L,36L,40L,43L,47L,50L,54L,57L,60L,64L,67L,71L,74L,77L,81L,84L,88L,91L,94L,98L,101L,105L,108L,112L,115L,118L,122L,125L,129L,132L,135L,139L,142L,146L,149L,153L,156L,159L,163L,166L,170L,173L,176L,180L,183L,187L,190L,194L,197L,200L,204L,207L,211L,214L,217L,221L,224L,228L,231L,234L,238L,241L,245L,248L,252L,255L,258L,262L,265L,269L,272L,275L,279L,282L,286L,289L,293L,296L,299L,303L,306L,310L,313L,316L,320L,323L,327L,330L,333L,337L,340L,344L,347L,351L,354L,357L,361L,364L,368L,371L,374L,378L,381L,385L,388L,392L,395L,398L,402L,405L,409L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184621Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184621.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184621Inst : IEnumerable<long>
{
public static readonly long[] Value=A184621.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184621.Bytes);
public long this[int i]=>Value[i];

public static A184621Inst Instance=new A184621Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184620
{
public static readonly long[] Value={ 1L,3L,4L,5L,7L,8L,10L,11L,12L,14L,15L,17L,18L,20L,21L,22L,24L,25L,27L,28L,29L,31L,32L,34L,35L,37L,38L,39L,41L,42L,44L,45L,46L,48L,49L,51L,52L,53L,55L,56L,58L,59L,61L,62L,63L,65L,66L,68L,69L,70L,72L,73L,75L,76L,78L,79L,80L,82L,83L,85L,86L,87L,89L,90L,92L,93L,95L,96L,97L,99L,100L,102L,103L,104L,106L,107L,109L,110L,111L,113L,114L,116L,117L,119L,120L,121L,123L,124L,126L,127L,128L,130L,131L,133L,134L,136L,137L,138L,140L,141L,143L,144L,145L,147L,148L,150L,151L,152L,154L,155L,157L,158L,160L,161L,162L,164L,165L,167L,168L,169L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184620Inst : IEnumerable<long>
{
public static readonly long[] Value=A184620.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184620.Bytes);
public long this[int i]=>Value[i];

public static A184620Inst Instance=new A184620Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184299
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,11L,21L,167L,616L,2308L,7792L,42090L,164290L,733278L,2785855L,13613231L,54109235L,230492863L,899895753L,3997708404L,16033421220L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184299Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184299.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184299Inst : IEnumerable<long>
{
public static readonly long[] Value=A184299.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184299.Bytes);
public long this[int i]=>Value[i];

public static A184299Inst Instance=new A184299Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184298
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,5L,19L,65L,179L,567L,1971L,7188L,24104L,86560L,307758L,1093010L,3680499L,12984253L,44872804L,155894872L,524533909L,1798853267L,6095276268L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184298Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184298.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184298Inst : IEnumerable<long>
{
public static readonly long[] Value=A184298.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184298.Bytes);
public long this[int i]=>Value[i];

public static A184298Inst Instance=new A184298Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184297
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,5L,4L,18L,52L,84L,243L,844L,2265L,6462L,15993L,52222L,136310L,389017L,998916L,2953402L,7916043L,21798836L,57115869L,161252708L,426637798L,1149156169L,3004327516L,8128762648L,21242600043L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184297Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184297.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184297Inst : IEnumerable<long>
{
public static readonly long[] Value=A184297.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184297.Bytes);
public long this[int i]=>Value[i];

public static A184297Inst Instance=new A184297Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184296
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,2L,5L,9L,12L,28L,52L,101L,210L,478L,1013L,1899L,4175L,8441L,17794L,36273L,74831L,153258L,314354L,630669L,1275787L,2563582L,5137717L,10176417L,20206831L,39762000L,78252739L,152625032L,297479773L,576578998L,1114993712L,2142088060L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184296Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184296.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184296Inst : IEnumerable<long>
{
public static readonly long[] Value=A184296.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184296.Bytes);
public long this[int i]=>Value[i];

public static A184296Inst Instance=new A184296Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184295
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,24L,82L,1516L,19403L,274731L,3598811L,88490744L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184295Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184295.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184295Inst : IEnumerable<long>
{
public static readonly long[] Value=A184295.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184295.Bytes);
public long this[int i]=>Value[i];

public static A184295Inst Instance=new A184295Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184294
{
public static readonly long[] Value={ 8L,36L,36L,176L,1072L,176L,1044L,43800L,43800L,1044L,6560L,2098720L,14913536L,2098720L,6560L,43800L,107377488L,5726645688L,5726645688L,107377488L,43800L,299600L,5726689312L,2345624810432L,17592189193216L,2345624810432L,5726689312L,299600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184294Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184294.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184294Inst : IEnumerable<long>
{
public static readonly long[] Value=A184294.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184294.Bytes);
public long this[int i]=>Value[i];

public static A184294Inst Instance=new A184294Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184293
{
public static readonly long[] Value={ 176L,43800L,14913536L,5726645688L,2345624810432L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184293Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184293.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184293Inst : IEnumerable<long>
{
public static readonly long[] Value=A184293.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184293.Bytes);
public long this[int i]=>Value[i];

public static A184293Inst Instance=new A184293Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184292
{
public static readonly long[] Value={ 36L,1072L,43800L,2098720L,107377488L,5726689312L,314146329192L,17592189191200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184292Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184292.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184292Inst : IEnumerable<long>
{
public static readonly long[] Value=A184292.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184292.Bytes);
public long this[int i]=>Value[i];

public static A184292Inst Instance=new A184292Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184291
{
public static readonly long[] Value={ 6L,21L,21L,76L,351L,76L,336L,7826L,7826L,336L,1560L,210456L,1119936L,210456L,1560L,7826L,6047412L,181402676L,181402676L,6047412L,7826L,39996L,181410426L,31345666736L,176319685116L,31345666736L,181410426L,39996L,210126L,5597460306L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184291Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184291.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184291Inst : IEnumerable<long>
{
public static readonly long[] Value=A184291.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184291.Bytes);
public long this[int i]=>Value[i];

public static A184291Inst Instance=new A184291Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184290
{
public static readonly long[] Value={ 76L,7826L,1119936L,181402676L,31345666736L,5642220395616L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184290Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184290.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184290Inst : IEnumerable<long>
{
public static readonly long[] Value=A184290.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184290.Bytes);
public long this[int i]=>Value[i];

public static A184290Inst Instance=new A184290Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184289
{
public static readonly long[] Value={ 21L,351L,7826L,210456L,6047412L,181410426L,5597460306L,176319684486L,5642220380006L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184289Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184289.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184289Inst : IEnumerable<long>
{
public static readonly long[] Value=A184289.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184289.Bytes);
public long this[int i]=>Value[i];

public static A184289Inst Instance=new A184289Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184288
{
public static readonly long[] Value={ 5L,15L,15L,45L,175L,45L,165L,2635L,2635L,165L,629L,49075L,217125L,49075L,629L,2635L,976887L,20346485L,20346485L,976887L,2635L,11165L,20349075L,2034505661L,9536816875L,2034505661L,20349075L,11165L,48915L,435970995L,211927741375L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184288Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184288.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184288Inst : IEnumerable<long>
{
public static readonly long[] Value=A184288.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184288.Bytes);
public long this[int i]=>Value[i];

public static A184288Inst Instance=new A184288Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184287
{
public static readonly long[] Value={ 165L,49075L,20346485L,9536816875L,4768372070757L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184287Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184287.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184287Inst : IEnumerable<long>
{
public static readonly long[] Value=A184287.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184287.Bytes);
public long this[int i]=>Value[i];

public static A184287Inst Instance=new A184287Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184286
{
public static readonly long[] Value={ 45L,2635L,217125L,20346485L,2034505661L,211927741375L,22706531350485L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184286Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184286.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184286Inst : IEnumerable<long>
{
public static readonly long[] Value=A184286.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184286.Bytes);
public long this[int i]=>Value[i];

public static A184286Inst Instance=new A184286Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184285
{
public static readonly long[] Value={ 15L,175L,2635L,49075L,976887L,20349075L,435970995L,9536816575L,211927736135L,4768373047015L,108372083629275L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184285Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184285.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184285Inst : IEnumerable<long>
{
public static readonly long[] Value=A184285.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184285.Bytes);
public long this[int i]=>Value[i];

public static A184285Inst Instance=new A184285Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184284
{
public static readonly long[] Value={ 3L,6L,6L,11L,27L,11L,24L,130L,130L,24L,51L,855L,2211L,855L,51L,130L,5934L,44368L,44368L,5934L,130L,315L,44487L,956635L,2691711L,956635L,44487L,315L,834L,341802L,21524790L,174342216L,174342216L,21524790L,341802L,834L,2195L,2691675L,498112275L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184284Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184284.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184284Inst : IEnumerable<long>
{
public static readonly long[] Value=A184284.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184284.Bytes);
public long this[int i]=>Value[i];

public static A184284Inst Instance=new A184284Inst();

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