using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A144161
{
public static readonly long[] Value={ 1L,1L,0L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,4L,3L,1L,0L,0L,10L,15L,12L,1L,0L,0L,20L,45L,72L,70L,1L,0L,0L,35L,105L,252L,490L,465L,1L,0L,0L,56L,210L,672L,1960L,3720L,3507L,1L,0L,0L,84L,378L,1512L,5880L,16740L,31563L,30016L,1L,0L,0L,120L,630L,3024L,14700L,55800L,157815L,300160L,286884L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144161Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144161.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144161Inst : IEnumerable<long>
{
public static readonly long[] Value=A144161.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144161.Bytes);
public long this[int i]=>Value[i];

public static A144161Inst Instance=new A144161Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144162
{
public static readonly long[] Value={ 51L,52L,53L,54L,56L,57L,58L,59L,501L,502L,503L,504L,506L,507L,508L,509L,551L,552L,553L,554L,556L,557L,558L,559L,5001L,5002L,5003L,5004L,5006L,5007L,5008L,5009L,5051L,5052L,5053L,5054L,5056L,5057L,5058L,5059L,5501L,5502L,5503L,5504L,5506L,5507L,5508L,5509L,5551L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144162Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144162.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144162Inst : IEnumerable<long>
{
public static readonly long[] Value=A144162.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144162.Bytes);
public long this[int i]=>Value[i];

public static A144162Inst Instance=new A144162Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144163
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,0L,1L,3L,3L,1L,1L,6L,15L,20L,3L,1L,10L,45L,120L,150L,12L,1L,15L,105L,455L,1185L,1473L,70L,1L,21L,210L,1330L,5565L,14469L,18424L,465L,1L,28L,378L,3276L,19635L,81060L,213990L,280200L,3507L,1L,36L,630L,7140L,57393L,334656L,1385076L,3732300L,5029218L,30016L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144163Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144163.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144163Inst : IEnumerable<long>
{
public static readonly long[] Value=A144163.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144163.Bytes);
public long this[int i]=>Value[i];

public static A144163Inst Instance=new A144163Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144164
{
public static readonly BigInteger[] Value={ 1L,1L,2L,8L,45L,338L,3304L,40485L,602075L,10576466L,214622874L,4941785261L,127282939615L,3625467047196L,113140481638088L,3838679644895477L,140681280613912089L,5538276165405744140L,BigInteger.Parse("233086092164091031114"),BigInteger.Parse("10443453353262112373541"),BigInteger.Parse("496313160155209940833001") };
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
public class A144164Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144164.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144164Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A144164.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A144164.Bytes);
public BigInteger this[int i]=>Value[i];

public static A144164Inst Instance=new A144164Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144165
{
public static readonly long[] Value={ 1L,12L,123L,1208L,11685L,112380L,1078735L,10352592L,99411561L,955512620L,9194193987L,88570160904L,854185695181L,8246896161756L,79703725659735L,771064720616480L,7466225595842385L,72357598508103756L,701804124937158283L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144165Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144165.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144165Inst : IEnumerable<long>
{
public static readonly long[] Value=A144165.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144165.Bytes);
public long this[int i]=>Value[i];

public static A144165Inst Instance=new A144165Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144166
{
public static readonly long[] Value={ 1L,14L,157L,1636L,16505L,163810L,1611309L,15768744L,153859377L,1498667990L,14583950557L,141854451788L,1379568224489L,13417231159402L,130514486317805L,1269893090519760L,12359796945574497L,120338685632742942L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144166Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144166.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144166Inst : IEnumerable<long>
{
public static readonly long[] Value=A144166.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144166.Bytes);
public long this[int i]=>Value[i];

public static A144166Inst Instance=new A144166Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144167
{
public static readonly long[] Value={ 1L,-2L,6L,-24L,122L,-726L,5060L,-40400L,363240L,-3630593L,39926622L,-479060379L,6227402193L,-87180957830L,1307694352218L,-20922949679481L,355688785859223L,-6402385922818921L,121645216453639396L,-2432903168507861321L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144167Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144167.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144167Inst : IEnumerable<long>
{
public static readonly long[] Value=A144167.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144167.Bytes);
public long this[int i]=>Value[i];

public static A144167Inst Instance=new A144167Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144200
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144200Inst : IEnumerable<long>
{
public static readonly long[] Value=A144200.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144200.Bytes);
public long this[int i]=>Value[i];

public static A144200Inst Instance=new A144200Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144201
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144201Inst : IEnumerable<long>
{
public static readonly long[] Value=A144201.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144201.Bytes);
public long this[int i]=>Value[i];

public static A144201Inst Instance=new A144201Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144202
{
public static readonly long[] Value={ 2L,2L,4L,4L,4L,5L,8L,5L,5L,9L,6L,7L,4L,7L,8L,8L,7L,9L,7L,5L,7L,13L,11L,10L,9L,9L,14L,13L,7L,9L,13L,14L,12L,11L,16L,10L,9L,17L,14L,12L,12L,18L,18L,12L,12L,17L,9L,8L,10L,16L,16L,11L,16L,7L,23L,12L,15L,21L,9L,17L,22L,13L,13L,16L,20L,18L,21L,17L,17L,11L,14L,21L,19L,21L,18L,22L,17L,23L,23L,21L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144202Inst : IEnumerable<long>
{
public static readonly long[] Value=A144202.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144202.Bytes);
public long this[int i]=>Value[i];

public static A144202Inst Instance=new A144202Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144203
{
public static readonly long[] Value={ 1L,2L,1L,4L,5L,3L,5L,4L,4L,4L,6L,4L,2L,7L,5L,9L,8L,11L,9L,6L,6L,9L,7L,8L,8L,13L,7L,6L,8L,9L,10L,6L,10L,12L,8L,16L,17L,11L,11L,16L,13L,7L,9L,10L,16L,13L,12L,14L,17L,17L,16L,17L,15L,14L,16L,16L,20L,15L,17L,17L,21L,13L,20L,17L,19L,17L,19L,19L,27L,16L,22L,19L,25L,10L,22L,25L,27L,13L,18L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144203Inst : IEnumerable<long>
{
public static readonly long[] Value=A144203.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144203.Bytes);
public long this[int i]=>Value[i];

public static A144203Inst Instance=new A144203Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144204
{
public static readonly long[] Value={ -1L,-1L,0L,-1L,1L,3L,-1L,2L,5L,8L,-1L,3L,7L,11L,15L,-1L,4L,9L,14L,19L,24L,-1L,5L,11L,17L,23L,29L,35L,-1L,6L,13L,20L,27L,34L,41L,48L,-1L,7L,15L,23L,31L,39L,47L,55L,63L,-1L,8L,17L,26L,35L,44L,53L,62L,71L,80L,-1L,9L,19L,29L,39L,49L,59L,69L,79L,89L,99L,-1L,10L,21L,32L,43L,54L,65L,76L,87L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144204Inst : IEnumerable<long>
{
public static readonly long[] Value=A144204.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144204.Bytes);
public long this[int i]=>Value[i];

public static A144204Inst Instance=new A144204Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144205
{
public static readonly long[] Value={ 21L,34L,89L,4181L,6765L,196418L,514229L,39088169L,7778742049L,139583862445L,365435296162L,10610209857723L,27777890035288L,44945570212853L,1304969544928657L,8944394323791464L,679891637638612258L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144205Inst : IEnumerable<long>
{
public static readonly long[] Value=A144205.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144205.Bytes);
public long this[int i]=>Value[i];

public static A144205Inst Instance=new A144205Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144206
{
public static readonly long[] Value={ 10L,16L,40L,70L,100L,106L,196L,226L,280L,310L,460L,616L,826L,856L,880L,1090L,1300L,1426L,1450L,1486L,1666L,1696L,1786L,1870L,1876L,1996L,2086L,2140L,2380L,2686L,2710L,2800L,3166L,3256L,3460L,3466L,3850L,4156L,4516L,4786L,5230L,5416L,5440L,5650L,5656L,5740L,6550L,6826L,7210L,7756L,7876L,8290L,8626L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144206Inst : IEnumerable<long>
{
public static readonly long[] Value=A144206.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144206.Bytes);
public long this[int i]=>Value[i];

public static A144206Inst Instance=new A144206Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144207
{
public static readonly long[] Value={ 1L,1L,0L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,4L,12L,1L,0L,0L,10L,60L,150L,1L,0L,0L,20L,180L,900L,2160L,1L,0L,0L,35L,420L,3150L,15180L,36015L,1L,0L,0L,56L,840L,8400L,60750L,291060L,688128L,1L,0L,0L,84L,1512L,18900L,182270L,1311240L,6300672L,14880348L,1L,0L,0L,120L,2520L,37800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144207Inst : IEnumerable<long>
{
public static readonly long[] Value=A144207.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144207.Bytes);
public long this[int i]=>Value[i];

public static A144207Inst Instance=new A144207Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144208
{
public static readonly BigInteger[] Value={ 1L,1L,1L,2L,17L,221L,3261L,54801L,1049235L,22695027L,548904831L,14701691121L,432342705351L,13856514927207L,480891887472585L,17971038945463101L,719613541474095591L,BigInteger.Parse("30743125693699501431"),BigInteger.Parse("1395902175504288127695") };
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
public class A144208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144208Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A144208.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A144208.Bytes);
public BigInteger this[int i]=>Value[i];

public static A144208Inst Instance=new A144208Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144209
{
public static readonly long[] Value={ 1L,1L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,3L,1L,0L,0L,0L,15L,60L,1L,0L,0L,0L,45L,360L,1080L,1L,0L,0L,0L,105L,1260L,7560L,20580L,1L,0L,0L,0L,210L,3360L,30240L,164640L,430080L,1L,0L,0L,0L,378L,7560L,90720L,740880L,3873240L,9920232L,1L,0L,0L,0L,630L,15120L,226800L,2469600L,19367460L,99406440L,252000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144209Inst : IEnumerable<long>
{
public static readonly long[] Value=A144209.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144209.Bytes);
public long this[int i]=>Value[i];

public static A144209Inst Instance=new A144209Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144210
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1L,4L,76L,1486L,29506L,628531L,14633011L,373486051L,10423892971L,316702467496L,10422938835196L,369779598658786L,14078057663869606L,572776958092098166L,BigInteger.Parse("24810200300393961286"),BigInteger.Parse("1140218754844983978646") };
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
public class A144210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144210Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A144210.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A144210.Bytes);
public BigInteger this[int i]=>Value[i];

public static A144210Inst Instance=new A144210Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144211
{
public static readonly long[] Value={ 3L,1L,4L,1L,0L,4L,1L,5L,2L,5L,4L,1L,0L,7L,8L,8L,5L,0L,0L,9L,4L,5L,2L,3L,1L,4L,4L,6L,7L,3L,3L,5L,1L,5L,1L,5L,9L,9L,7L,9L,8L,5L,6L,8L,5L,2L,4L,4L,5L,5L,9L,9L,4L,8L,8L,1L,9L,6L,5L,4L,6L,6L,3L,1L,4L,9L,6L,4L,2L,4L,1L,1L,3L,1L,7L,6L,4L,8L,6L,7L,1L,7L,0L,2L,8L,0L,0L,8L,9L,2L,2L,6L,1L,9L,7L,3L,3L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144211Inst : IEnumerable<long>
{
public static readonly long[] Value=A144211.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144211.Bytes);
public long this[int i]=>Value[i];

public static A144211Inst Instance=new A144211Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144212
{
public static readonly long[] Value={ 2L,17L,4L,221L,76L,13L,3261L,1486L,433L,61L,54801L,29506L,11593L,2941L,361L,1049235L,628531L,296353L,102481L,23041L,2521L,22695027L,14633011L,7795873L,3270961L,1010881L,204121L,20161L,548904831L,373486051L,217126225L,104038201L,39355201L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144212Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144212.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144212Inst : IEnumerable<long>
{
public static readonly long[] Value=A144212.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144212.Bytes);
public long this[int i]=>Value[i];

public static A144212Inst Instance=new A144212Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144213
{
public static readonly long[] Value={ 17L,19L,37L,41L,43L,53L,71L,79L,83L,89L,101L,103L,107L,109L,113L,131L,137L,151L,157L,167L,173L,179L,181L,193L,199L,211L,227L,229L,233L,241L,257L,263L,269L,277L,281L,293L,311L,317L,337L,347L,349L,353L,359L,367L,373L,379L,389L,401L,431L,439L,443L,449L,461L,463L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144213Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144213.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144213Inst : IEnumerable<long>
{
public static readonly long[] Value=A144213.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144213.Bytes);
public long this[int i]=>Value[i];

public static A144213Inst Instance=new A144213Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144214
{
public static readonly long[] Value={ 17L,19L,37L,41L,79L,103L,107L,109L,131L,137L,151L,157L,167L,173L,179L,181L,193L,199L,211L,227L,229L,233L,241L,257L,367L,379L,431L,439L,443L,463L,487L,491L,499L,521L,541L,557L,563L,569L,577L,587L,601L,607L,613L,617L,631L,641L,647L,653L,659L,661L,677L,701L,709L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144214Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144214.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144214Inst : IEnumerable<long>
{
public static readonly long[] Value=A144214.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144214.Bytes);
public long this[int i]=>Value[i];

public static A144214Inst Instance=new A144214Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144215
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,3L,1L,3L,5L,6L,1L,3L,7L,9L,10L,1L,4L,11L,17L,19L,20L,1L,4L,15L,28L,34L,36L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144215Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144215.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144215Inst : IEnumerable<long>
{
public static readonly long[] Value=A144215.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144215.Bytes);
public long this[int i]=>Value[i];

public static A144215Inst Instance=new A144215Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144280
{
public static readonly long[] Value={ 1L,3L,1L,21L,3L,1L,231L,30L,3L,1L,3465L,294L,30L,3L,1L,65835L,4599L,321L,30L,3L,1L,1514205L,81081L,4788L,321L,30L,3L,1L,40883535L,1837836L,84483L,4869L,321L,30L,3L,1L,1267389585L,47609100L,1892835L,85050L,4869L,321L,30L,3L,1L,44358635475L,1449052605L,48681864L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144280Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144280.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144280Inst : IEnumerable<long>
{
public static readonly long[] Value=A144280.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144280.Bytes);
public long this[int i]=>Value[i];

public static A144280Inst Instance=new A144280Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144281
{
public static readonly BigInteger[] Value={ 1L,4L,25L,265L,3793L,70789L,1600429L,42811078L,1316981794L,45858363502L,1781106761686L,76349861206627L,3579325969675135L,182170488961796899L,10002072131444031160UL,BigInteger.Parse("589261706147357617009"),BigInteger.Parse("37076870479319887575253"),BigInteger.Parse("2481442922857293505594237") };
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
public class A144281Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144281.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144281Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A144281.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A144281.Bytes);
public BigInteger this[int i]=>Value[i];

public static A144281Inst Instance=new A144281Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144282
{
public static readonly BigInteger[] Value={ 1L,3L,30L,294L,4599L,81081L,1837836L,47609100L,1449052605L,49597258095L,1908702935370L,81045039516210L,3775424041048275L,191061229964098725L,10445176764205306200UL,BigInteger.Parse("613084928455370309400"),BigInteger.Parse("38459158233446064893625"),BigInteger.Parse("2567221442902306374982875") };
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
public class A144282Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144282.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144282Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A144282.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A144282.Bytes);
public BigInteger this[int i]=>Value[i];

public static A144282Inst Instance=new A144282Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144283
{
public static readonly BigInteger[] Value={ 1L,3L,30L,321L,4788L,84483L,1892835L,48681864L,1471877946L,50200415496L,1925842959810L,81617639962320L,3796524406060155L,191934556035324795L,10484757631267725960UL,BigInteger.Parse("615052198937234606625"),BigInteger.Parse("38564916668583937458750"),BigInteger.Parse("2573353724722205851069875") };
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
public class A144283Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144283.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144283Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A144283.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A144283.Bytes);
public BigInteger this[int i]=>Value[i];

public static A144283Inst Instance=new A144283Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144284
{
public static readonly long[] Value={ 1L,4L,1L,36L,4L,1L,504L,36L,16L,4L,1L,9576L,504L,144L,36L,16L,4L,1L,229824L,9576L,2016L,1296L,504L,144L,64L,36L,16L,4L,1L,6664896L,229824L,38304L,18144L,9576L,2016L,1296L,576L,504L,144L,64L,36L,16L,4L,1L,226606464L,6664896L,919296L,344736L,254016L,229824L,38304L,18144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144284Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144284.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144284Inst : IEnumerable<long>
{
public static readonly long[] Value=A144284.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144284.Bytes);
public long this[int i]=>Value[i];

public static A144284Inst Instance=new A144284Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144285
{
public static readonly long[] Value={ 1L,4L,1L,36L,4L,1L,504L,52L,4L,1L,9576L,648L,52L,4L,1L,229824L,12888L,712L,52L,4L,1L,6664896L,286272L,13464L,712L,52L,4L,1L,226606464L,8182944L,299520L,13720L,712L,52L,4L,1L,8837652096L,266366016L,8455392L,301824L,13720L,712L,52L,4L,1L,388856692224L,10191545280L,273091392L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144285Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144285.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144285Inst : IEnumerable<long>
{
public static readonly long[] Value=A144285.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144285.Bytes);
public long this[int i]=>Value[i];

public static A144285Inst Instance=new A144285Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144286
{
public static readonly BigInteger[] Value={ 1L,5L,41L,561L,10281L,243481L,6965401L,235103417L,9112789817L,399330154617L,19502558109177L,1050527843743993L,61855087724349433L,3952225158444979193L,BigInteger.Parse("272326955744655069689"),BigInteger.Parse("20128716335079745234425"),BigInteger.Parse("1588573078022351774367225"),BigInteger.Parse("133323969310853649963402745") };
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
public class A144286Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144286.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144286Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A144286.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A144286.Bytes);
public BigInteger this[int i]=>Value[i];

public static A144286Inst Instance=new A144286Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144287
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,1L,3L,5L,3L,1L,4L,10L,22L,5L,1L,5L,17L,93L,181L,8L,1L,6L,26L,276L,2521L,5814L,13L,1L,7L,37L,655L,17681L,612696L,1488565L,21L,1L,8L,50L,1338L,81901L,18105620L,4019900977L,12194330294L,34L,1L,9L,65L,2457L,289045L,255941280L,1186569930001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144287Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144287.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144287Inst : IEnumerable<long>
{
public static readonly long[] Value=A144287.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144287.Bytes);
public long this[int i]=>Value[i];

public static A144287Inst Instance=new A144287Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144288
{
public static readonly BigInteger[] Value={ 1L,2L,10L,276L,81901L,2247615258L,81658169024988865L,BigInteger.Parse("644986443956439734064225751112"),BigInteger.Parse("3427833941153173630835645403655873661712817810325122") };
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
public class A144288Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144288.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144288Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A144288.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A144288.Bytes);
public BigInteger this[int i]=>Value[i];

public static A144288Inst Instance=new A144288Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144289
{
public static readonly long[] Value={ 1L,2L,0L,4L,2L,0L,8L,12L,9L,0L,16L,48L,84L,64L,0L,32L,160L,480L,820L,625L,0L,64L,480L,2160L,6120L,10230L,7776L,0L,128L,1344L,8400L,34720L,94500L,155274L,117649L,0L,256L,3584L,29568L,165760L,647920L,1712592L,2776200L,2097152L,0L,512L,9216L,96768L,701568L,3669120L,13783392L,35630784L,57138120L,43046721L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144289Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144289.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144289Inst : IEnumerable<long>
{
public static readonly long[] Value=A144289.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144289.Bytes);
public long this[int i]=>Value[i];

public static A144289Inst Instance=new A144289Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144290
{
public static readonly long[] Value={ 1L,4L,13L,9L,32L,28L,19L,29L,25L,133L,7L,183L,29L,31L,25L,308L,25L,382L,31L,43L,45L,554L,34L,36L,53L,37L,11L,871L,11L,993L,43L,67L,69L,71L,7L,111L,95L,130L,83L,246L,87L,344L,90L,498L,56L,93L,2258L,61L,64L,12L,170L,106L,742L,111L,170L,618L,78L,115L,117L,3542L,11L,3783L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144290Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144290.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144290Inst : IEnumerable<long>
{
public static readonly long[] Value=A144290.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144290.Bytes);
public long this[int i]=>Value[i];

public static A144290Inst Instance=new A144290Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144291
{
public static readonly long[] Value={ 0L,36L,45L,105L,120L,210L,231L,300L,325L,351L,378L,528L,561L,595L,630L,741L,780L,990L,1035L,1176L,1225L,1275L,1326L,1485L,1540L,1596L,1653L,1953L,2016L,2080L,2145L,2346L,2415L,2775L,2850L,2926L,3003L,3240L,3321L,3570L,3655L,3741L,3828L,4095L,4186L,4278L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144291Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144291.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144291Inst : IEnumerable<long>
{
public static readonly long[] Value=A144291.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144291.Bytes);
public long this[int i]=>Value[i];

public static A144291Inst Instance=new A144291Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144292
{
public static readonly long[] Value={ 0L,4L,21L,14L,40L,42L,40L,45L,70L,253L,10L,351L,44L,63L,42L,340L,63L,418L,52L,87L,68L,598L,84L,140L,80L,93L,18L,1711L,16L,1953L,76L,135L,104L,215L,10L,148L,798L,624L,200L,410L,210L,602L,176L,528L,102L,140L,2350L,208L,364L,14L,1020L,208L,1378L,270L,180L,638L,192L,231L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144292Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144292.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144292Inst : IEnumerable<long>
{
public static readonly long[] Value=A144292.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144292.Bytes);
public long this[int i]=>Value[i];

public static A144292Inst Instance=new A144292Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144293
{
public static readonly long[] Value={ 1L,1L,2L,5L,5L,13L,29L,877L,23L,53L,4639L,22619L,2423L,27644437L,1800937L,1101959L,43486067L,255755771L,5006399L,222527L,4326209287L,188633L,574631L,13369534669L,1204457631577L,171659L,11759883224809L,2479031L,171572636187431L,3516743833L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144293Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144293.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144293Inst : IEnumerable<long>
{
public static readonly long[] Value=A144293.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144293.Bytes);
public long this[int i]=>Value[i];

public static A144293Inst Instance=new A144293Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144294
{
public static readonly long[] Value={ 3L,5L,3L,7L,5L,3L,7L,3L,5L,5L,3L,13L,3L,5L,7L,3L,11L,5L,3L,7L,3L,5L,5L,3L,11L,7L,3L,5L,7L,3L,5L,3L,11L,7L,3L,5L,5L,3L,7L,11L,3L,5L,3L,11L,5L,3L,7L,7L,3L,5L,5L,3L,13L,7L,3L,5L,3L,7L,5L,3L,7L,13L,3L,5L,5L,3L,7L,7L,3L,5L,11L,3L,5L,3L,11L,11L,3L,5L,5L,3L,7L,17L,3L,5L,7L,3L,7L,5L,3L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144294Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144294.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144294Inst : IEnumerable<long>
{
public static readonly long[] Value=A144294.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144294.Bytes);
public long this[int i]=>Value[i];

public static A144294Inst Instance=new A144294Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144295
{
public static readonly long[] Value={ 1L,2L,4L,12L,82L,231L,380L,2990L,20954L,40953L,42852L,182492L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144295Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144295.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144295Inst : IEnumerable<long>
{
public static readonly long[] Value=A144295.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144295.Bytes);
public long this[int i]=>Value[i];

public static A144295Inst Instance=new A144295Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144328
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,1L,2L,3L,1L,1L,2L,3L,4L,1L,1L,2L,3L,4L,5L,1L,1L,2L,3L,4L,5L,6L,1L,1L,2L,3L,4L,5L,6L,7L,1L,1L,2L,3L,4L,5L,6L,7L,8L,1L,1L,2L,3L,4L,5L,6L,7L,8L,9L,1L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,1L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144328Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144328.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144328Inst : IEnumerable<long>
{
public static readonly long[] Value=A144328.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144328.Bytes);
public long this[int i]=>Value[i];

public static A144328Inst Instance=new A144328Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144329
{
public static readonly long[] Value={ 1L,2L,1L,3L,2L,2L,4L,3L,4L,3L,5L,4L,6L,6L,4L,6L,5L,8L,9L,8L,5L,7L,6L,10L,12L,12L,10L,6L,8L,7L,12L,15L,16L,15L,12L,7L,9L,8L,14L,18L,20L,20L,18L,14L,8L,10L,9L,16L,21L,24L,25L,24L,21L,16L,9L,11L,10L,18L,24L,28L,30L,30L,28L,24L,18L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144329Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144329.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144329Inst : IEnumerable<long>
{
public static readonly long[] Value=A144329.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144329.Bytes);
public long this[int i]=>Value[i];

public static A144329Inst Instance=new A144329Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144330
{
public static readonly long[] Value={ 1L,2L,1L,4L,3L,2L,7L,6L,5L,3L,11L,10L,9L,7L,4L,16L,15L,14L,12L,9L,5L,22L,21L,20L,18L,15L,11L,6L,29L,28L,27L,25L,22L,18L,13L,7L,37L,36L,35L,33L,30L,26L,21L,15L,8L,46L,45L,44L,42L,39L,35L,30L,24L,17L,9L,56L,55L,54L,52L,49L,45L,40L,34L,27L,19L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144330Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144330.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144330Inst : IEnumerable<long>
{
public static readonly long[] Value=A144330.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144330.Bytes);
public long this[int i]=>Value[i];

public static A144330Inst Instance=new A144330Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144331
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,0L,1L,3L,3L,0L,0L,0L,1L,6L,15L,15L,0L,0L,0L,0L,1L,10L,45L,105L,105L,0L,0L,0L,0L,0L,1L,15L,105L,420L,945L,945L,0L,0L,0L,0L,0L,0L,1L,21L,210L,1260L,4725L,10395L,10395L,0L,0L,0L,0L,0L,0L,0L,1L,28L,378L,3150L,17325L,62370L,135135L,135135L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144331Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144331.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144331Inst : IEnumerable<long>
{
public static readonly long[] Value=A144331.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144331.Bytes);
public long this[int i]=>Value[i];

public static A144331Inst Instance=new A144331Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144332
{
public static readonly long[] Value={ 1L,2L,1L,4L,5L,2L,7L,14L,11L,3L,11L,30L,35L,19L,4L,16L,55L,85L,69L,29L,5L,22L,91L,175L,189L,119L,41L,6L,29L,140L,322L,434L,364L,188L,55L,7L,37L,204L,546L,882L,924L,636L,279L,71L,8L,46L,285L,870L,1638L,2058L,1770L,1035L,395L,89L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144332Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144332.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144332Inst : IEnumerable<long>
{
public static readonly long[] Value=A144332.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144332.Bytes);
public long this[int i]=>Value[i];

public static A144332Inst Instance=new A144332Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144333
{
public static readonly long[] Value={ 1L,2L,1L,4L,3L,2L,8L,7L,8L,3L,16L,15L,22L,15L,4L,32L,31L,52L,48L,24L,5L,64L,63L,114L,126L,88L,35L,6L,128L,127L,240L,297L,256L,145L,48L,7L,256L,255L,494L,657L,652L,465L,222L,63L,8L,512L,511L,1004L,1398L,1528L,1280L,780L,322L,80L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144333Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144333.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144333Inst : IEnumerable<long>
{
public static readonly long[] Value=A144333.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144333.Bytes);
public long this[int i]=>Value[i];

public static A144333Inst Instance=new A144333Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144334
{
public static readonly long[] Value={ 1L,2L,1L,4L,3L,4L,7L,6L,10L,9L,11L,10L,18L,21L,16L,16L,15L,28L,36L,36L,25L,22L,21L,40L,54L,60L,55L,36L,29L,28L,54L,75L,88L,90L,78L,49L,37L,36L,70L,99L,120L,130L,126L,105L,64L,46L,45L,88L,126L,156L,175L,180L,168L,136L,81L,56L,55L,108L,156L,196L,225L,240L,238L,216L,171L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144334Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144334.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144334Inst : IEnumerable<long>
{
public static readonly long[] Value=A144334.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144334.Bytes);
public long this[int i]=>Value[i];

public static A144334Inst Instance=new A144334Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144335
{
public static readonly long[] Value={ 1L,3L,11L,32L,76L,156L,288L,491L,787L,1201L,1761L,2498L,3446L,4642L,6126L,7941L,10133L,12751L,15847L,19476L,23696L,28568L,34156L,40527L,47751L,55901L,65053L,75286L,86682L,99326L,113306L,128713L,145641L,164187L,184451L,206536L,230548L,256596L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144335Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144335.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144335Inst : IEnumerable<long>
{
public static readonly long[] Value=A144335.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144335.Bytes);
public long this[int i]=>Value[i];

public static A144335Inst Instance=new A144335Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144336
{
public static readonly long[] Value={ 1L,3L,1L,1L,4L,3L,3L,-1L,7L,5L,1L,6L,-2L,10L,7L,3L,-3L,14L,-4L,13L,9L,1L,8L,-11L,26L,-7L,16L,11L,3L,-5L,25L,-29L,43L,-11L,19L,13L,1L,10L,-24L,62L,-62L,66L,-16L,22L,15L,3L,-7L,40L,-78L,134L,-116L,96L,-22L,25L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144336Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144336.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144336Inst : IEnumerable<long>
{
public static readonly long[] Value=A144336.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144336.Bytes);
public long this[int i]=>Value[i];

public static A144336Inst Instance=new A144336Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144337
{
public static readonly long[] Value={ 1L,2L,1L,3L,2L,3L,4L,3L,6L,5L,5L,4L,9L,10L,7L,6L,5L,12L,15L,14L,9L,7L,6L,15L,10L,21L,18L,11L,8L,7L,18L,25L,28L,27L,22L,13L,9L,8L,21L,30L,35L,36L,33L,26L,15L,10L,9L,24L,35L,42L,45L,44L,39L,30L,17L,11L,10L,27L,40L,49L,54L,55L,52L,45L,34L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144337Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144337.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144337Inst : IEnumerable<long>
{
public static readonly long[] Value=A144337.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144337.Bytes);
public long this[int i]=>Value[i];

public static A144337Inst Instance=new A144337Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144338
{
public static readonly long[] Value={ 2L,3L,5L,6L,7L,10L,11L,13L,14L,15L,17L,19L,21L,22L,23L,26L,29L,30L,31L,33L,34L,35L,37L,38L,39L,41L,42L,43L,46L,47L,51L,53L,55L,57L,58L,59L,61L,62L,65L,66L,67L,69L,70L,71L,73L,74L,77L,78L,79L,82L,83L,85L,86L,87L,89L,91L,93L,94L,95L,97L,101L,102L,103L,105L,106L,107L,109L,110L,111L,113L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144338Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144338.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144338Inst : IEnumerable<long>
{
public static readonly long[] Value=A144338.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144338.Bytes);
public long this[int i]=>Value[i];

public static A144338Inst Instance=new A144338Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144339
{
public static readonly BigInteger[] Value={ 1L,4L,52L,648L,12888L,286272L,8182944L,266366016L,10191545280L,437925035520L,21158411936256L,1127285473434624L,65884689657464832L,4181915450891501568L,BigInteger.Parse("286704379021188538368"),BigInteger.Parse("21099339893878107144192"),BigInteger.Parse("1659252422924430692327424"),BigInteger.Parse("138827012602215571388891136") };
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
public class A144339Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144339.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144339Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A144339.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A144339.Bytes);
public BigInteger this[int i]=>Value[i];

public static A144339Inst Instance=new A144339Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144340
{
public static readonly BigInteger[] Value={ 1L,4L,52L,712L,13464L,299520L,8455392L,273091392L,10372138560L,443940231168L,21373226590464L,1136301643620864L,66301616889414144L,4203565310173630464L,BigInteger.Parse("287934809159520681984"),BigInteger.Parse("21176025476308764622848"),BigInteger.Parse("1664420505612432224993280"),BigInteger.Parse("139202656243140427345723392") };
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
public class A144340Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144340.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144340Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A144340.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A144340.Bytes);
public BigInteger this[int i]=>Value[i];

public static A144340Inst Instance=new A144340Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144341
{
public static readonly long[] Value={ 1L,5L,1L,55L,5L,1L,935L,55L,25L,5L,1L,21505L,935L,275L,55L,25L,5L,1L,623645L,21505L,4675L,3025L,935L,275L,125L,55L,25L,5L,1L,21827575L,623645L,107525L,51425L,21505L,4675L,3025L,1375L,935L,275L,125L,55L,25L,5L,1L,894930575L,21827575L,3118225L,1182775L,874225L,623645L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144341Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144341.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144341Inst : IEnumerable<long>
{
public static readonly long[] Value=A144341.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144341.Bytes);
public long this[int i]=>Value[i];

public static A144341Inst Instance=new A144341Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144342
{
public static readonly long[] Value={ 1L,5L,1L,55L,5L,1L,935L,80L,5L,1L,21505L,1210L,80L,5L,1L,623645L,29205L,1335L,80L,5L,1L,21827575L,782595L,30580L,1335L,80L,5L,1L,894930575L,27002800L,821095L,31205L,1335L,80L,5L,1L,42061737025L,1058476100L,27963925L,827970L,31205L,1335L,80L,5L,1L,2229272062325L,48782479625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144342Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144342.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144342Inst : IEnumerable<long>
{
public static readonly long[] Value=A144342.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144342.Bytes);
public long this[int i]=>Value[i];

public static A144342Inst Instance=new A144342Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144343
{
public static readonly BigInteger[] Value={ 1L,6L,61L,1021L,22801L,654271L,22642171L,922787096L,43149037646L,2279170742696L,134100508257596L,8698551285481371L,616549939781495121L,BigInteger.Parse("47409430650407225871"),BigInteger.Parse("3930455865337807339246"),BigInteger.Parse("349471231024984588597871"),BigInteger.Parse("33172028312913149756842121") };
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
public class A144343Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144343.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144343Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A144343.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A144343.Bytes);
public BigInteger this[int i]=>Value[i];

public static A144343Inst Instance=new A144343Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144376
{
public static readonly long[] Value={ 1L,10L,18L,54L,108L,540L,2700L,3780L,7560L,22680L,113400L,249480L,1247400L,3243240L,6486480L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144376Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144376.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144376Inst : IEnumerable<long>
{
public static readonly long[] Value=A144376.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144376.Bytes);
public long this[int i]=>Value[i];

public static A144376Inst Instance=new A144376Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144377
{
public static readonly long[] Value={ 1L,2L,0L,0L,2L,-2L,-4L,0L,0L,-2L,4L,8L,0L,0L,4L,-8L,-14L,0L,0L,-8L,14L,24L,0L,0L,12L,-22L,-40L,0L,0L,-20L,36L,64L,0L,0L,32L,-56L,-98L,0L,0L,-48L,84L,148L,0L,0L,72L,-126L,-220L,0L,0L,-106L,184L,320L,0L,0L,152L,-264L,-460L,0L,0L,-216L,376L,652L,0L,0L,306L,-528L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144377Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144377.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144377Inst : IEnumerable<long>
{
public static readonly long[] Value=A144377.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144377.Bytes);
public long this[int i]=>Value[i];

public static A144377Inst Instance=new A144377Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144378
{
public static readonly long[] Value={ 11L,22L,37L,136L,13L,64L,73L,163L,91L,1730L,289L,1639L,379L,1660L,2737L,919L,559L,14878L,7561L,5671L,9753L,2890L,7777L,4888L,5785L,5590L,27973L,47872L,28681L,22681L,3785L,36184L,46281L,71281L,6481L,48952L,48763L,64978L,119773L,69782L,77881L,55973L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144378Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144378.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144378Inst : IEnumerable<long>
{
public static readonly long[] Value=A144378.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144378.Bytes);
public long this[int i]=>Value[i];

public static A144378Inst Instance=new A144378Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144379
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,2L,2L,4L,1L,1L,1L,1L,1L,2L,1L,1L,2L,2L,4L,2L,6L,1L,1L,1L,2L,2L,2L,3L,4L,1L,1L,2L,1L,3L,2L,4L,3L,6L,1L,1L,1L,2L,2L,1L,2L,3L,2L,4L,1L,1L,2L,2L,4L,2L,6L,4L,6L,4L,10L,1L,1L,1L,1L,1L,2L,2L,3L,3L,2L,3L,4L,1L,1L,2L,2L,4L,2L,6L,4L,6L,4L,10L,4L,12L,1L,1L,1L,2L,2L,2L,3L,3L,2L,3L,4L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144379Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144379.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144379Inst : IEnumerable<long>
{
public static readonly long[] Value=A144379.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144379.Bytes);
public long this[int i]=>Value[i];

public static A144379Inst Instance=new A144379Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144380
{
public static readonly BigInteger[] Value={ 1L,166L,5482L,109640L,1709675L,23077694L,284433852L,3300384000L,36740695125L,397251942790L,4206505251886L,43874389439176L,452588032465727L,4630933106076350L,47101176806668160L,476947462419456864L,4813761757416769257L,BigInteger.Parse("48466731584985480870"),BigInteger.Parse("487104579690137249650"),BigInteger.Parse("4889039701269534580360") };
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
public class A144380Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144380.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144380Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A144380.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A144380.Bytes);
public BigInteger this[int i]=>Value[i];

public static A144380Inst Instance=new A144380Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144381
{
public static readonly long[] Value={ 1L,677L,47175L,1709675L,44451550L,947113254L,17716715490L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144381Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144381.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144381Inst : IEnumerable<long>
{
public static readonly long[] Value=A144381.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144381.Bytes);
public long this[int i]=>Value[i];

public static A144381Inst Instance=new A144381Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144382
{
public static readonly long[] Value={ -1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,0L,-1L,-1L,-1L,-1L,1L,-1L,-1L,-1L,-1L,0L,1L,-1L,-1L,-1L,-1L,-1L,1L,0L,-1L,-1L,-1L,-1L,-1L,0L,2L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,1L,2L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,0L,2L,1L,0L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,1L,3L,-1L,1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,0L,2L,3L,-3L,1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,1L,3L,2L,-4L,0L,-1L,-1L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144382Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144382.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144382Inst : IEnumerable<long>
{
public static readonly long[] Value=A144382.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144382.Bytes);
public long this[int i]=>Value[i];

public static A144382Inst Instance=new A144382Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144383
{
public static readonly long[] Value={ 1L,1L,-2L,1L,-1L,4L,1L,-1L,0L,-8L,1L,-1L,1L,1L,16L,1L,-1L,1L,-2L,-1L,-32L,1L,-1L,1L,-1L,3L,0L,64L,1L,-1L,1L,-1L,0L,-4L,1L,-128L,1L,-1L,1L,-1L,1L,1L,6L,-1L,256L,1L,-1L,1L,-1L,1L,-2L,-2L,-9L,0L,-512L,1L,-1L,1L,-1L,1L,-1L,3L,3L,13L,1L,1024L,1L,-1L,1L,-1L,1L,-1L,0L,-4L,-3L,-19L,-1L,-2048L,1L,-1L,1L,-1L,1L,-1L,1L,1L,5L,2L,28L,0L,4096L,1L,-1L,1L,-1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144383Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144383.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144383Inst : IEnumerable<long>
{
public static readonly long[] Value=A144383.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144383.Bytes);
public long this[int i]=>Value[i];

public static A144383Inst Instance=new A144383Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144384
{
public static readonly long[] Value={ 1L,1L,1L,1L,-1L,1L,1L,-1L,1L,1L,1L,-1L,0L,-1L,1L,1L,-1L,0L,1L,1L,1L,1L,-1L,0L,0L,-1L,-1L,1L,1L,-1L,0L,0L,1L,0L,1L,1L,1L,-1L,0L,0L,0L,-1L,1L,-1L,1L,1L,-1L,0L,0L,0L,1L,0L,-1L,1L,1L,1L,-1L,0L,0L,0L,0L,-1L,0L,0L,-1L,1L,1L,-1L,0L,0L,0L,0L,1L,0L,1L,1L,1L,1L,1L,-1L,0L,0L,0L,0L,0L,-1L,0L,-1L,-1L,-1L,1L,1L,-1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,1L,1L,-1L,0L,0L,0L,0L,0L,0L,-1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144384Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144384.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144384Inst : IEnumerable<long>
{
public static readonly long[] Value=A144384.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144384.Bytes);
public long this[int i]=>Value[i];

public static A144384Inst Instance=new A144384Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144385
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,0L,0L,1L,3L,7L,10L,10L,0L,0L,0L,1L,6L,25L,75L,175L,280L,280L,0L,0L,0L,0L,1L,10L,65L,315L,1225L,3780L,9100L,15400L,15400L,0L,0L,0L,0L,0L,1L,15L,140L,980L,5565L,26145L,102025L,323400L,800800L,1401400L,1401400L,0L,0L,0L,0L,0L,0L,1L,21L,266L,2520L,19425L,125895L,695695L,3273270L,12962950L,42042000L,106506400L,190590400L,190590400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144385Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144385.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144385Inst : IEnumerable<long>
{
public static readonly long[] Value=A144385.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144385.Bytes);
public long this[int i]=>Value[i];

public static A144385Inst Instance=new A144385Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144386
{
public static readonly long[] Value={ 0L,1L,5L,-3L,5L,15L,3L,17L,33L,15L,35L,13L,37L,63L,35L,65L,33L,67L,31L,69L,109L,67L,111L,65L,113L,63L,115L,61L,117L,59L,119L,181L,117L,183L,115L,185L,113L,187L,111L,189L,109L,191L,107L,193L,701408540L,701408450L,701408358L,701408264L,701408168L,701408070L,701407970L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144386Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144386.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144386Inst : IEnumerable<long>
{
public static readonly long[] Value=A144386.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144386.Bytes);
public long this[int i]=>Value[i];

public static A144386Inst Instance=new A144386Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144387
{
public static readonly long[] Value={ 2L,2L,1L,2L,-1L,4L,2L,-3L,5L,3L,2L,-5L,8L,-2L,8L,2L,-7L,13L,-10L,10L,5L,2L,-9L,20L,-23L,20L,-5L,12L,2L,-11L,29L,-43L,43L,-25L,17L,7L,2L,-13L,40L,-72L,86L,-68L,42L,-10L,16L,2L,-15L,53L,-112L,158L,-154L,110L,-52L,26L,13L,2L,-17L,68L,-165L,270L,-312L,264L,-162L,78L,-13L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144387Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144387.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144387Inst : IEnumerable<long>
{
public static readonly long[] Value=A144387.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144387.Bytes);
public long this[int i]=>Value[i];

public static A144387Inst Instance=new A144387Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144388
{
public static readonly long[] Value={ 1L,0L,1L,3L,0L,1L,-2L,9L,0L,1L,5L,-8L,18L,0L,1L,-4L,25L,-20L,30L,0L,1L,7L,-24L,75L,-40L,45L,0L,1L,-6L,49L,-84L,175L,-70L,63L,0L,1L,9L,-48L,196L,-224L,350L,-112L,84L,0L,1L,-8L,81L,-216L,588L,-504L,630L,-168L,108L,0L,1L,11L,-80L,405L,-720L,1470L,-1008L,1050L,-240L,135L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144388Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144388.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144388Inst : IEnumerable<long>
{
public static readonly long[] Value=A144388.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144388.Bytes);
public long this[int i]=>Value[i];

public static A144388Inst Instance=new A144388Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144389
{
public static readonly long[] Value={ -1L,2L,-1L,1L,4L,-1L,4L,3L,6L,-1L,3L,16L,6L,8L,-1L,6L,15L,40L,10L,10L,-1L,5L,36L,45L,80L,15L,12L,-1L,8L,35L,126L,105L,140L,21L,14L,-1L,7L,64L,140L,336L,210L,224L,28L,16L,-1L,10L,63L,288L,420L,756L,378L,336L,36L,18L,-1L,9L,100L,315L,960L,1050L,1512L,630L,480L,45L,20L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144389Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144389.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144389Inst : IEnumerable<long>
{
public static readonly long[] Value=A144389.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144389.Bytes);
public long this[int i]=>Value[i];

public static A144389Inst Instance=new A144389Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144390
{
public static readonly long[] Value={ 1L,9L,23L,43L,69L,101L,139L,183L,233L,289L,351L,419L,493L,573L,659L,751L,849L,953L,1063L,1179L,1301L,1429L,1563L,1703L,1849L,2001L,2159L,2323L,2493L,2669L,2851L,3039L,3233L,3433L,3639L,3851L,4069L,4293L,4523L,4759L,5001L,5249L,5503L,5763L,6029L,6301L,6579L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144390Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144390.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144390Inst : IEnumerable<long>
{
public static readonly long[] Value=A144390.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144390.Bytes);
public long this[int i]=>Value[i];

public static A144390Inst Instance=new A144390Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144391
{
public static readonly long[] Value={ 3L,13L,29L,51L,79L,113L,153L,199L,251L,309L,373L,443L,519L,601L,689L,783L,883L,989L,1101L,1219L,1343L,1473L,1609L,1751L,1899L,2053L,2213L,2379L,2551L,2729L,2913L,3103L,3299L,3501L,3709L,3923L,4143L,4369L,4601L,4839L,5083L,5333L,5589L,5851L,6119L,6393L,6673L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144391Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144391.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144391Inst : IEnumerable<long>
{
public static readonly long[] Value=A144391.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144391.Bytes);
public long this[int i]=>Value[i];

public static A144391Inst Instance=new A144391Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144408
{
public static readonly long[] Value={ 0L,1L,5L,9L,0L,2L,6L,9L,9L,1L,6L,0L,0L,1L,5L,9L,0L,2L,6L,9L,9L,1L,6L,0L,0L,1L,5L,9L,0L,2L,6L,9L,9L,1L,6L,0L,0L,1L,5L,9L,0L,2L,6L,9L,9L,1L,6L,0L,0L,1L,5L,9L,0L,2L,6L,9L,9L,1L,6L,0L,0L,1L,5L,9L,0L,2L,6L,9L,9L,1L,6L,0L,0L,1L,5L,9L,0L,2L,6L,9L,9L,1L,6L,0L,0L,1L,5L,9L,0L,2L,6L,9L,9L,1L,6L,0L,0L,1L,5L,9L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144408Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144408.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144408Inst : IEnumerable<long>
{
public static readonly long[] Value=A144408.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144408.Bytes);
public long this[int i]=>Value[i];

public static A144408Inst Instance=new A144408Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144409
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,0L,1L,3L,1L,1L,0L,1L,2L,5L,1L,1L,0L,1L,0L,3L,8L,1L,1L,0L,0L,0L,2L,4L,13L,1L,1L,0L,0L,1L,1L,0L,6L,21L,1L,1L,0L,0L,1L,0L,1L,3L,9L,34L,1L,1L,0L,0L,0L,0L,0L,1L,0L,13L,55L,1L,1L,0L,0L,0L,1L,0L,2L,2L,5L,19L,89L,1L,1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,28L,144L,1L,1L,0L,0L,0L,0L,0L,0L,1L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144409Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144409.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144409Inst : IEnumerable<long>
{
public static readonly long[] Value=A144409.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144409.Bytes);
public long this[int i]=>Value[i];

public static A144409Inst Instance=new A144409Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144410
{
public static readonly long[] Value={ 8L,80L,224L,440L,728L,1088L,1520L,2024L,2600L,3248L,3968L,4760L,5624L,6560L,7568L,8648L,9800L,11024L,12320L,13688L,15128L,16640L,18224L,19880L,21608L,23408L,25280L,27224L,29240L,31328L,33488L,35720L,38024L,40400L,42848L,45368L,47960L,50624L,53360L,56168L,59048L,62000L,65024L,68120L,71288L,74528L,77840L,81224L,84680L,88208L,91808L,95480L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144410Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144410.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144410Inst : IEnumerable<long>
{
public static readonly long[] Value=A144410.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144410.Bytes);
public long this[int i]=>Value[i];

public static A144410Inst Instance=new A144410Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144411
{
public static readonly long[] Value={ 2L,1L,1L,0L,-1L,1L,-1L,0L,1L,0L,-1L,0L,-1L,1L,-1L,0L,1L,-1L,0L,0L,-1L,0L,-1L,-1L,0L,1L,1L,0L,-1L,-1L,-1L,-1L,-1L,0L,0L,-1L,1L,-1L,-1L,-1L,1L,-1L,0L,-1L,0L,0L,-1L,0L,-1L,1L,-1L,-1L,-1L,1L,1L,-1L,-1L,-1L,-1L,0L,-1L,-1L,-1L,-1L,0L,1L,0L,-1L,1L,-1L,-1L,-1L,0L,-1L,0L,-1L,0L,-1L,1L,-1L,0L,1L,-1L,-1L,-1L,0L,-1L,-1L,-1L,-1L,-1L,0L,1L,0L,-1L,-1L,-1L,-1L,-1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144411Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144411.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144411Inst : IEnumerable<long>
{
public static readonly long[] Value=A144411.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144411.Bytes);
public long this[int i]=>Value[i];

public static A144411Inst Instance=new A144411Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144412
{
public static readonly long[] Value={ 2L,2L,4L,0L,-8L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144412Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144412.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144412Inst : IEnumerable<long>
{
public static readonly long[] Value=A144412.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144412.Bytes);
public long this[int i]=>Value[i];

public static A144412Inst Instance=new A144412Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144413
{
public static readonly long[] Value={ 0L,1L,-1L,1L,0L,-3L,10L,-24L,49L,-89L,145L,-208L,245L,-174L,-176L,1121L,-3185L,7137L,-13920L,24301L,-37926L,51256L,-53615L,20407L,97265L,-386224L,984549L,-2083934L,3896480L,-6537023L,9734175L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144413Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144413.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144413Inst : IEnumerable<long>
{
public static readonly long[] Value=A144413.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144413.Bytes);
public long this[int i]=>Value[i];

public static A144413Inst Instance=new A144413Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144414
{
public static readonly long[] Value={ 1L,8L,39L,166L,677L,2724L,10915L,43682L,174753L,699040L,2796191L,11184798L,44739229L,178956956L,715827867L,2863311514L,11453246105L,45812984472L,183251937943L,733007751830L,2932031007381L,11728124029588L,46912496118419L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144414Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144414.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144414Inst : IEnumerable<long>
{
public static readonly long[] Value=A144414.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144414.Bytes);
public long this[int i]=>Value[i];

public static A144414Inst Instance=new A144414Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144415
{
public static readonly long[] Value={ 0L,1L,21L,27L,45L,55L,57L,63L,65L,69L,77L,87L,91L,115L,121L,125L,141L,145L,175L,185L,195L,201L,203L,215L,219L,235L,237L,279L,289L,291L,295L,299L,305L,315L,319L,335L,339L,343L,381L,385L,435L,437L,441L,477L,497L,507L,533L,539L,543L,549L,561L,567L,581L,591L,629L,639L,649L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144415Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144415.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144415Inst : IEnumerable<long>
{
public static readonly long[] Value=A144415.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144415.Bytes);
public long this[int i]=>Value[i];

public static A144415Inst Instance=new A144415Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144416
{
public static readonly BigInteger[] Value={ 1L,3L,31L,842L,45296L,4061871L,546809243L,103123135501L,25942945219747L,8394104851717686L,3395846808758759686L,BigInteger.Parse("1679398297627675722593"),BigInteger.Parse("996789456118195908366641"),BigInteger.Parse("699283226713639676370419067"),BigInteger.Parse("572385833490097906671186099971"),BigInteger.Parse("540635257271794961275858251107746"),BigInteger.Parse("583630397618757664934692641037584628") };
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
public class A144416Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144416.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144416Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A144416.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A144416.Bytes);
public BigInteger this[int i]=>Value[i];

public static A144416Inst Instance=new A144416Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144417
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,0L,1L,3L,1L,0L,1L,6L,7L,0L,0L,1L,10L,25L,10L,0L,0L,1L,15L,65L,75L,10L,0L,0L,1L,21L,140L,315L,175L,0L,0L,0L,1L,28L,266L,980L,1225L,280L,0L,0L,0L,1L,36L,462L,2520L,5565L,3780L,280L,0L,0L,0L,1L,45L,750L,5670L,19425L,26145L,9100L,0L,0L,0L,0L,1L,55L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144417Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144417.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144417Inst : IEnumerable<long>
{
public static readonly long[] Value=A144417.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144417.Bytes);
public long this[int i]=>Value[i];

public static A144417Inst Instance=new A144417Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144418
{
public static readonly long[] Value={ 0L,1L,1L,9L,9L,15L,15L,21L,25L,25L,35L,49L,49L,51L,51L,65L,87L,93L,105L,105L,117L,129L,129L,135L,135L,143L,147L,155L,155L,159L,161L,161L,169L,183L,183L,185L,201L,209L,209L,215L,221L,225L,231L,235L,243L,249L,265L,265L,275L,285L,295L,301L,303L,309L,315L,325L,325L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144418Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144418.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144418Inst : IEnumerable<long>
{
public static readonly long[] Value=A144418.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144418.Bytes);
public long this[int i]=>Value[i];

public static A144418Inst Instance=new A144418Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144419
{
public static readonly long[] Value={ 3L,3L,5L,13L,17L,29L,31L,31L,37L,41L,47L,53L,67L,71L,71L,79L,79L,83L,89L,97L,97L,107L,107L,127L,131L,151L,181L,197L,211L,229L,241L,257L,257L,269L,271L,281L,283L,283L,311L,353L,373L,389L,401L,409L,409L,419L,419L,431L,449L,463L,479L,491L,499L,547L,563L,577L,577L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144419Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144419.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144419Inst : IEnumerable<long>
{
public static readonly long[] Value=A144419.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144419.Bytes);
public long this[int i]=>Value[i];

public static A144419Inst Instance=new A144419Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144420
{
public static readonly long[] Value={ 2L,4L,5L,23L,26L,130L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144420Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144420.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144420Inst : IEnumerable<long>
{
public static readonly long[] Value=A144420.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144420.Bytes);
public long this[int i]=>Value[i];

public static A144420Inst Instance=new A144420Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144421
{
public static readonly long[] Value={ 7L,41L,43L,47L,53L,83L,97L,107L,157L,167L,211L,251L,293L,353L,367L,401L,617L,683L,727L,839L,857L,859L,953L,1109L,1117L,1277L,1297L,1381L,1429L,1481L,1483L,1553L,1597L,1867L,1951L,1999L,2087L,2213L,2243L,2297L,2389L,2423L,2447L,2473L,2657L,2659L,2671L,2719L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144421Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144421.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144421Inst : IEnumerable<long>
{
public static readonly long[] Value=A144421.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144421.Bytes);
public long this[int i]=>Value[i];

public static A144421Inst Instance=new A144421Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144422
{
public static readonly BigInteger[] Value={ 1L,3L,62L,5052L,1087104L,487424520L,393702654960L,519740602925040L,1046019551260199040L,BigInteger.Parse("3046052768591313895680"),BigInteger.Parse("12322848899623787148556800"),BigInteger.Parse("67036205966744406283600262400"),BigInteger.Parse("477463744343745629221074425625600"),BigInteger.Parse("4354451197836949908463868034925593600") };
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
public class A144422Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144422.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144422Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A144422.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A144422.Bytes);
public BigInteger this[int i]=>Value[i];

public static A144422Inst Instance=new A144422Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144423
{
public static readonly long[] Value={ 3L,3L,5L,17L,41L,59L,71L,73L,79L,89L,89L,107L,127L,163L,173L,227L,227L,233L,233L,241L,271L,283L,331L,331L,337L,373L,379L,379L,383L,419L,443L,443L,461L,487L,503L,557L,563L,571L,577L,617L,619L,631L,659L,677L,683L,709L,709L,733L,769L,769L,823L,859L,887L,919L,997L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144423Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144423.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144423Inst : IEnumerable<long>
{
public static readonly long[] Value=A144423.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144423.Bytes);
public long this[int i]=>Value[i];

public static A144423Inst Instance=new A144423Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144456
{
public static readonly long[] Value={ 1L,-1L,1L,-2L,-3L,2L,-6L,-29L,-31L,6L,-30L,-299L,-920L,-869L,30L,-210L,-3569L,-21193L,-51769L,-43853L,210L,-2310L,-64679L,-665252L,-3136692L,-6760012L,-5333173L,2310L,-30030L,-1231229L,-19579519L,-153212408L,-618042328L,-1212020249L,-901760539L,30030L,-510510L,-29609579L,-688677932L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144456Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144456.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144456Inst : IEnumerable<long>
{
public static readonly long[] Value=A144456.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144456.Bytes);
public long this[int i]=>Value[i];

public static A144456Inst Instance=new A144456Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144457
{
public static readonly long[] Value={ 1L,-1L,1L,-3L,-8L,3L,-15L,-119L,-217L,15L,-105L,-1574L,-7440L,-10954L,105L,-945L,-22679L,-194646L,-702874L,-892281L,945L,-10395L,-363824L,-4885615L,-31288480L,-94892945L,-108046896L,10395L,-135135L,-6486479L,-124999827L,-1232430275L,-6521470845L,-17442096461L,-18261339153L,135135L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144457Inst : IEnumerable<long>
{
public static readonly long[] Value=A144457.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144457.Bytes);
public long this[int i]=>Value[i];

public static A144457Inst Instance=new A144457Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144458
{
public static readonly long[] Value={ -2L,-2L,0L,-4L,2L,2L,-6L,3L,3L,0L,-10L,6L,6L,2L,3L,-16L,13L,13L,10L,15L,17L,-26L,25L,25L,24L,36L,47L,31L,-42L,49L,49L,56L,84L,119L,119L,112L,-68L,95L,95L,122L,183L,271L,318L,385L,329L,-110L,182L,182L,254L,381L,580L,741L,991L,1127L,963L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144458Inst : IEnumerable<long>
{
public static readonly long[] Value=A144458.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144458.Bytes);
public long this[int i]=>Value[i];

public static A144458Inst Instance=new A144458Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144459
{
public static readonly long[] Value={ 1L,24L,77L,160L,273L,416L,589L,792L,1025L,1288L,1581L,1904L,2257L,2640L,3053L,3496L,3969L,4472L,5005L,5568L,6161L,6784L,7437L,8120L,8833L,9576L,10349L,11152L,11985L,12848L,13741L,14664L,15617L,16600L,17613L,18656L,19729L,20832L,21965L,23128L,24321L,25544L,26797L,28080L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144459Inst : IEnumerable<long>
{
public static readonly long[] Value=A144459.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144459.Bytes);
public long this[int i]=>Value[i];

public static A144459Inst Instance=new A144459Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144460
{
public static readonly long[] Value={ 1L,1L,0L,2L,1L,1L,4L,4L,4L,4L,7L,8L,8L,9L,4L,12L,15L,15L,18L,12L,9L,20L,26L,26L,32L,24L,22L,12L,33L,44L,44L,55L,44L,44L,33L,22L,54L,73L,73L,92L,76L,79L,66L,56L,33L,88L,120L,120L,152L,128L,136L,120L,112L,88L,56L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144460Inst : IEnumerable<long>
{
public static readonly long[] Value=A144460.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144460.Bytes);
public long this[int i]=>Value[i];

public static A144460Inst Instance=new A144460Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144461
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,1L,-3L,1L,1L,5L,-5L,1L,1L,7L,13L,-8L,1L,1L,10L,19L,29L,-13L,1L,1L,15L,29L,57L,86L,-21L,1L,1L,23L,45L,89L,155L,244L,-34L,1L,1L,36L,71L,141L,246L,421L,667L,-55L,1L,1L,57L,113L,225L,393L,673L,1121L,1794L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144461Inst : IEnumerable<long>
{
public static readonly long[] Value=A144461.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144461.Bytes);
public long this[int i]=>Value[i];

public static A144461Inst Instance=new A144461Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144462
{
public static readonly long[] Value={ 2L,2L,1L,2L,1L,2L,2L,1L,1L,3L,2L,1L,1L,2L,4L,2L,1L,1L,2L,2L,6L,2L,1L,1L,2L,2L,2L,9L,2L,1L,1L,2L,2L,2L,2L,14L,2L,1L,1L,2L,2L,2L,2L,2L,22L,2L,1L,1L,2L,2L,2L,2L,2L,2L,35L,2L,1L,1L,2L,2L,2L,2L,2L,2L,2L,56L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144462Inst : IEnumerable<long>
{
public static readonly long[] Value=A144462.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144462.Bytes);
public long this[int i]=>Value[i];

public static A144462Inst Instance=new A144462Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144463
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,1L,1L,6L,6L,1L,1L,8L,24L,8L,1L,1L,10L,40L,40L,10L,1L,1L,12L,60L,160L,60L,12L,1L,1L,14L,84L,280L,280L,84L,14L,1L,1L,16L,112L,448L,1120L,448L,112L,16L,1L,1L,18L,144L,672L,2016L,2016L,672L,144L,18L,1L,1L,20L,180L,960L,3360L,8064L,3360L,960L,180L,20L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144463Inst : IEnumerable<long>
{
public static readonly long[] Value=A144463.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144463.Bytes);
public long this[int i]=>Value[i];

public static A144463Inst Instance=new A144463Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144464
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,2L,2L,1L,1L,2L,4L,2L,1L,1L,2L,4L,4L,2L,1L,1L,2L,4L,8L,4L,2L,1L,1L,2L,4L,8L,8L,4L,2L,1L,1L,2L,4L,8L,16L,8L,4L,2L,1L,1L,2L,4L,8L,16L,16L,8L,4L,2L,1L,1L,2L,4L,8L,16L,32L,16L,8L,4L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144464Inst : IEnumerable<long>
{
public static readonly long[] Value=A144464.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144464.Bytes);
public long this[int i]=>Value[i];

public static A144464Inst Instance=new A144464Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144465
{
public static readonly long[] Value={ 1L,4L,23L,121L,617L,3109L,15593L,78061L,390497L,1952869L,9765113L,48827101L,244138577L,1220699029L,6103507433L,30517561741L,152587857857L,762939387589L,3814697134553L,19073486065981L,9536743111633L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144465Inst : IEnumerable<long>
{
public static readonly long[] Value=A144465.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144465.Bytes);
public long this[int i]=>Value[i];

public static A144465Inst Instance=new A144465Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144466
{
public static readonly long[] Value={ 2L,3L,37L,257L,1021L,1601L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144466Inst : IEnumerable<long>
{
public static readonly long[] Value=A144466.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144466.Bytes);
public long this[int i]=>Value[i];

public static A144466Inst Instance=new A144466Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144467
{
public static readonly long[] Value={ 3L,5L,11L,41L,919L,3517L,6691L,13709L,23669L,52301L,83101L,146051L,417959L,777901L,970231L,1076401L,1894117L,2315069L,2592269L,2641469L,2777111L,2997227L,3523343L,3788843L,4076257L,4159231L,5082059L,5271961L,5295569L,5363801L,6451931L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144467Inst : IEnumerable<long>
{
public static readonly long[] Value=A144467.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144467.Bytes);
public long this[int i]=>Value[i];

public static A144467Inst Instance=new A144467Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A144468
{
public static readonly long[] Value={ 0L,7L,4L,1L,8L,5L,2L,9L,6L,3L,0L,7L,4L,1L,8L,5L,2L,9L,6L,3L,0L,7L,4L,1L,8L,5L,2L,9L,6L,3L,0L,7L,4L,1L,8L,5L,2L,9L,6L,3L,0L,7L,4L,1L,8L,5L,2L,9L,6L,3L,0L,7L,4L,1L,8L,5L,2L,9L,6L,3L,0L,7L,4L,1L,8L,5L,2L,9L,6L,3L,0L,7L,4L,1L,8L,5L,2L,9L,6L,3L,0L,7L,4L,1L,8L,5L,2L,9L,6L,3L,0L,7L,4L,1L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A144468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A144468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A144468Inst : IEnumerable<long>
{
public static readonly long[] Value=A144468.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A144468.Bytes);
public long this[int i]=>Value[i];

public static A144468Inst Instance=new A144468Inst();

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